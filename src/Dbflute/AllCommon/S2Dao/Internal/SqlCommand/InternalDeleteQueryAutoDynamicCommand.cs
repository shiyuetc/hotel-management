
using System;
using Seasar.Extension.ADO;
using Seasar.Dao;

using Dbflute.AllCommon.S2Dao.Internal.SqlParser;
using Dbflute.AllCommon.S2Dao.Internal.SqlHandler;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlCommand {

public class InternalDeleteQueryAutoDynamicCommand : ISqlCommand {

    // ===================================================================================
    //                                                                           Attribute
    //                                                                           =========
    protected IDataSource dataSource;
    protected ICommandFactory commandFactory;

    // ===================================================================================
    //                                                                         Constructor
    //                                                                         ===========
    public InternalDeleteQueryAutoDynamicCommand(IDataSource dataSource, ICommandFactory commandFactory) {
        this.dataSource = dataSource;
        this.commandFactory = commandFactory;
    }

    // ===================================================================================
    //                                                                             Execute
    //                                                                             =======
    public Object Execute(Object[] args) {
        ConditionBean cb = extractConditionBeanWithCheck(args);
        String[] argNames = new String[]{"pmb"};
        Type[] argTypes = new Type[]{cb.GetType()};
        String twoWaySql = buildQueryDeleteTwoWaySql(cb);
        ICommandContext context = createCommandContext(twoWaySql, argNames, argTypes, args);
        InternalCommandContextHandler handler = createCommandContextHandler(context);
        handler.LoggingMessageSqlArgs = context.BindVariables;
        int rows = handler.Execute(args);
        return rows;
    }
    
    protected ConditionBean extractConditionBeanWithCheck(Object[] args) {
        if (args == null || args.Length == 0) {
            String msg = "The arguments should have one argument! But:";
            msg = msg + " args=" + (args != null ? "" + args.Length : "null");
            throw new IllegalArgumentException(msg);
        }
        Object fisrtArg = args[0];
        if (!(fisrtArg is ConditionBean)) {
            String msg = "The type of argument should be " + typeof(ConditionBean) + "! But:";
            msg = msg + " type=" + fisrtArg.GetType();
            throw new IllegalArgumentException(msg);
        }
        return (ConditionBean) fisrtArg;
    }
    
    protected InternalCommandContextHandler createCommandContextHandler(ICommandContext context) {
        return new InternalCommandContextHandler(dataSource, commandFactory, context);
    }

    protected String buildQueryDeleteTwoWaySql(ConditionBean cb) {
        return cb.SqlClause.getClauseQueryDelete();
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
