
using System;
using System.Collections;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Dao;

using Dbflute.AllCommon.Exp;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlHandler {

    public class InternalUpdateAutoHandler : InternalAbstractAutoHandler {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected bool checkSingleRowUpdate = true;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public InternalUpdateAutoHandler(IDataSource dataSource, ICommandFactory commandFactory, IBeanMetaData beanMetaData, IPropertyType[] propertyTypes)
            : base(dataSource, commandFactory, beanMetaData, propertyTypes) {
        }
		
        // ===============================================================================
        //                                                                        Override
        //                                                                        ========
        protected override void SetupBindVariables(Object bean) {
            SetupUpdateBindVariables(bean);
            LoggingMessageSqlArgs = _bindVariables;
        }

        protected override void PostUpdateBean(Object bean, int ret) {
            if (IsCheckSingleRowUpdate && ret < 1) {
                throw CreateEntityAlreadyUpdatedException(bean, ret);
            }
            UpdateVersionNoIfNeed(bean);
            UpdateTimestampIfNeed(bean);
        }

        protected virtual EntityAlreadyUpdatedException CreateEntityAlreadyUpdatedException(Object bean, int rows) {
            return new EntityAlreadyUpdatedException(bean, rows);
        }
        
        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        public bool IsCheckSingleRowUpdate {
            get { return checkSingleRowUpdate; }
            set { checkSingleRowUpdate = value; }
        }
    }
}
