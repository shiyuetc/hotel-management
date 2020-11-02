
using System;
using System.Reflection;

using Seasar.Extension.ADO;
using Seasar.Dao;

using Dbflute.AllCommon.S2Dao.Internal.SqlParser;
using Dbflute.AllCommon.S2Dao.Internal.SqlHandler;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.Dbm.Info;
using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlCommand {

public class InternalUpdateQueryAutoDynamicCommand : ISqlCommand {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected IDataSource dataSource;
    protected ICommandFactory commandFactory;

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public InternalUpdateQueryAutoDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory) {
        this.dataSource = dataSource;
        this.commandFactory = commandFactory;
    }

    // ===================================================================================
    //                                                                             Execute
    //                                                                             =======
    public Object Execute(Object[] args) {
        ConditionBean cb = extractConditionBeanWithCheck(args);
        Entity entity = extractEntityWithCheck(args);
        String[] argNames = new String[]{"pmb", "entity"};
        Type[] argTypes = new Type[]{cb.GetType(), entity.GetType()};
        String twoWaySql = buildQueryUpdateTwoWaySql(cb, entity);
        if (twoWaySql == null) {
            return 0;// No execute!
        }
        ICommandContext context = createCommandContext(twoWaySql, argNames, argTypes, args);
        InternalCommandContextHandler handler = createCommandContextHandler(context);
        handler.LoggingMessageSqlArgs = context.BindVariables;
        return handler.Execute(args);
    }
    
    protected ConditionBean extractConditionBeanWithCheck(Object[] args) {
        assertArgument(args);
        Object fisrtArg = args[0];
        if (!(fisrtArg is ConditionBean)) {
            String msg = "The type of first argument should be " + typeof(ConditionBean) + "! But:";
            msg = msg + " type=" + fisrtArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (ConditionBean) fisrtArg;
    }
    
    protected Entity extractEntityWithCheck(Object[] args) {
        assertArgument(args);
        Object secondArg = args[1];
        if (!(secondArg is Entity)) {
            String msg = "The type of second argument should be " + typeof(Entity) + "! But:";
            msg = msg + " type=" + secondArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (Entity) secondArg;
    }
	
    protected void assertArgument(Object[] args) {
        if (args == null || args.Length <= 1) {
            String msg = "The arguments should have two argument! But:";
            msg = msg + " args=" + (args != null ? "" + args.Length : "null");
            throw new IllegalArgumentException(msg);
        }
    }
    
    protected InternalCommandContextHandler createCommandContextHandler(ICommandContext context) {
        return new InternalCommandContextHandler(dataSource, commandFactory, context);
    }

    /**
     * @param cb Condition-bean. (NotNull)
     * @param entity Entity. (NotNull)
     * @return The two-way SQL of query update. (NullAllowed: If the set of modified properties is empty, return null.)
     */
    protected String buildQueryUpdateTwoWaySql(ConditionBean cb, Entity entity) {
        Map<String, String> columnParameterMap = new LinkedHashMap<String, String>();
        DBMeta dbmeta = DBMetaInstanceHandler.FindDBMeta(entity.TableDbName);
        System.Collections.Generic.IDictionary<String, Object> modifiedPropertyNames = entity.ModifiedPropertyNames;
        if (modifiedPropertyNames.Count == 0) {
            return null;
        }
        String currentPropertyName = null;
        foreach (String propertyName in modifiedPropertyNames.Keys) {
            currentPropertyName = propertyName;
            ColumnInfo columnInfo = dbmeta.FindColumnInfo(propertyName);
            String columnName = columnInfo.ColumnDbName;
            PropertyInfo getter = columnInfo.FindProperty();
            Object value = getter.GetValue(entity, null);
            if (value != null) {
                columnParameterMap.put(columnName, "/*entity." + propertyName + "*/null");
            } else {
                columnParameterMap.put(columnName, "null");
            }
        }
        if (dbmeta.HasVersionNo) {
            ColumnInfo columnInfo = dbmeta.VersionNoColumnInfo;
            String columnName = columnInfo.ColumnDbName;
            columnParameterMap.put(columnName, columnName + " + 1");
        }
        if (dbmeta.HasUpdateDate) {
            ColumnInfo columnInfo = dbmeta.UpdateDateColumnInfo;
            PropertyInfo setter = columnInfo.FindProperty();
            setter.SetValue(entity, DateTime.Now, null);
            String columnName = columnInfo.ColumnDbName;
            columnParameterMap.put(columnName, "/*entity." + columnInfo.PropertyName + "*/null");
        }
        return cb.SqlClause.getClauseQueryUpdate(columnParameterMap);
    }

    protected ICommandContext createCommandContext(String twoWaySql, String[] argNames, Type[] argTypes, Object[] args) {
        ICommandContext context;
        {
            InternalSqlParser parser = new InternalSqlParser(twoWaySql, true);
            INode node = parser.Parse();
            InternalCommandContextCreator creator = new InternalCommandContextCreator(argNames, argTypes);
            context = creator.CreateCommandContext(args);
            node.Accept(context);
        }
        return context;
    }
	
    // ===================================================================================
    //                                                                      General Helper
    //                                                                      ==============
    protected String getLineSeparator() {
        return SimpleSystemUtil.GetLineSeparator();
    }
}

}
