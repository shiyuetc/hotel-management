
using System;
using System.Collections;
using System.Text;
using Seasar.Extension.ADO;
using Seasar.Dao;
using Seasar.Dao.Impl;

using Dbflute.AllCommon;
using Dbflute.AllCommon.Exp;
using Dbflute.AllCommon.S2Dao.Internal.SqlHandler;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlCommand {

    public abstract class InternalAbstractAutoStaticCommand : AbstractStaticCommand {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		
        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        private IPropertyType[] propertyTypes;
        private bool checkSingleRowUpdate = true;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public InternalAbstractAutoStaticCommand(IDataSource dataSource,
            ICommandFactory commandFactory, IBeanMetaData beanMetaData, string[] propertyNames)
            : base(dataSource, commandFactory, beanMetaData) {
            SetupPropertyTypes(propertyNames);
            SetupSql();
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public override Object Execute(object[] args) {
            InternalAbstractAutoHandler handler = CreateAutoHandler();
            handler.Sql = Sql;
            handler.LoggingMessageSqlArgs = args;
            int rows = handler.Execute(args);
            if (IsCheckSingleRowUpdate && rows != 1) throw new EntityAlreadyUpdatedException(args[0], rows);
            return rows;
        }

        protected abstract InternalAbstractAutoHandler CreateAutoHandler();

        protected abstract void SetupPropertyTypes(string[] propertyNames);

        // ===============================================================================
        //                                                                        Setupper
        //                                                                        ========
        protected void SetupInsertPropertyTypes(string[] propertyNames) {
            ArrayList types = new ArrayList();
            for (int i = 0; i < propertyNames.Length; ++i) {
                IPropertyType pt = BeanMetaData.GetPropertyType(propertyNames[i]);
                if (pt.IsPrimaryKey && !BeanMetaData.IdentifierGenerator.IsSelfGenerate)
                    continue;
                types.Add(pt);
            }
            propertyTypes = (IPropertyType[]) types.ToArray(typeof(IPropertyType));
        }

        protected void SetupUpdatePropertyTypes(string[] propertyNames) {
            ArrayList types = new ArrayList();
            for (int i = 0; i < propertyNames.Length; ++i) {
                IPropertyType pt = BeanMetaData.GetPropertyType(propertyNames[i]);
                if (pt.IsPrimaryKey) continue;
                types.Add(pt);
            }
            propertyTypes = (IPropertyType[]) types.ToArray(typeof(IPropertyType));
        }

        protected virtual void SetupDeletePropertyTypes(string[] propertyNames) {
        }

        protected abstract void SetupSql();

        protected void SetupInsertSql() {
            IBeanMetaData bmd = BeanMetaData;
            StringBuilder sb = new StringBuilder(100);
            sb.Append("INSERT INTO ");
            sb.Append(bmd.TableName);
            sb.Append(" (");
            for (int i = 0; i < propertyTypes.Length; ++i) {
                IPropertyType pt = propertyTypes[i];
                sb.Append(pt.ColumnName);
                sb.Append(", ");
            }
            sb.Length = sb.Length - 2;
            sb.Append(") VALUES (");
            for (int i = 0; i < propertyTypes.Length; ++i) {
                sb.Append("?, ");
            }
            sb.Length = sb.Length - 2;
            sb.Append(")");
            Sql = sb.ToString();
        }

        protected void SetupUpdateSql() {
            CheckPrimaryKey();
            StringBuilder sb = new StringBuilder(100);
            sb.Append("UPDATE ");
            sb.Append(BeanMetaData.TableName);
            sb.Append(" SET ");
            for (int i = 0; i < propertyTypes.Length; ++i) {
                IPropertyType pt = propertyTypes[i];
                if (String.Compare(pt.PropertyName, BeanMetaData.VersionNoPropertyName, true) == 0) {
                    sb.Append(pt.ColumnName).Append(" = ").Append(pt.ColumnName).Append(" + 1, ");
                    continue;
                }
                sb.Append(pt.ColumnName);
                sb.Append(" = ?, ");
            }
            sb.Length = sb.Length - 2;
            SetupUpdateWhere(sb);
            Sql = sb.ToString();
        }

        protected void SetupDeleteSql() {
            CheckPrimaryKey();
            StringBuilder sb = new StringBuilder(100);
            sb.Append("DELETE FROM ");
            sb.Append(BeanMetaData.TableName);
            SetupUpdateWhere(sb);
            Sql = sb.ToString();
        }

        protected void CheckPrimaryKey() {
            IBeanMetaData bmd = BeanMetaData;
            if (bmd.PrimaryKeySize == 0) {
                throw new PrimaryKeyNotFoundRuntimeException(bmd.BeanType);
            }
        }

        protected void SetupUpdateWhere(StringBuilder sb) {
            IBeanMetaData bmd = BeanMetaData;
            sb.Append(" WHERE ");
            for (int i = 0; i < bmd.PrimaryKeySize; ++i) {
                sb.Append(bmd.GetPrimaryKey(i));
                sb.Append(" = ? AND ");
            }
            sb.Length = sb.Length - 5;
            if (bmd.HasVersionNoPropertyType) {
                IPropertyType pt = bmd.VersionNoPropertyType;
                sb.Append(" AND ");
                sb.Append(pt.ColumnName);
                sb.Append(" = ?");
            }
            if (bmd.HasTimestampPropertyType) {
                IPropertyType pt = bmd.TimestampPropertyType;
                sb.Append(" AND ");
                sb.Append(pt.ColumnName);
                sb.Append(" = ?");
            }
        }

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        protected IPropertyType[] PropertyTypes {
            get { return propertyTypes; }
            set { propertyTypes = value; }
        }

        public bool IsCheckSingleRowUpdate {
            get { return checkSingleRowUpdate; }
            set { checkSingleRowUpdate = value; }
        }
    }
}
