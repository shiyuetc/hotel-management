
using System;
using System.Data;

using Seasar.Dao;
using Seasar.Dao.Impl;
using Seasar.Extension.ADO;
using Seasar.Extension.ADO.Impl;
using Seasar.Quill.Dao.Impl;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.OutsideSql;
using Dbflute.AllCommon.Ado;

namespace Dbflute.AllCommon.S2Dao {

    public class S2DaoSetting : AbstractDaoSetting {

        protected override void SetupDao(IDataSource dataSource) {
            ICommandFactory commandFactory = CreateCommandFactory();
            IDataReaderFactory dataReaderFactory = CreateDataReaderFactory(commandFactory);
            IAnnotationReaderFactory annotationReaderFactory = CreateAnnotationReaderFactory();
            _daoMetaDataFactory = new S2DaoMetaDataFactoryImpl(dataSource, commandFactory, annotationReaderFactory, dataReaderFactory);
            _daoInterceptor = new S2DaoInterceptor(_daoMetaDataFactory);
        }

        protected ICommandFactory CreateCommandFactory() {
            IDbParameterParser dbParamterParser = DBFluteConfig.GetInstance().DbParameterParser;
            BasicCommandFactory commandFactory;
            if (dbParamterParser != null) {
                commandFactory = new TnBasicCommandFactory(dbParamterParser);
            } else {
                commandFactory = new TnBasicCommandFactory();
            }
            return commandFactory;
        }

        protected IDataReaderFactory CreateDataReaderFactory(ICommandFactory commandFactory) {
            return new BasicDataReaderFactory(commandFactory);
        }

        protected IAnnotationReaderFactory CreateAnnotationReaderFactory() {
            return new FieldAnnotationReaderFactory();
        }
    }

    public class TnBasicCommandFactory : BasicCommandFactory {

        // ===============================================================================
        //                                                                      Definition
        //                                                                      ==========
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public TnBasicCommandFactory() : base() {}
        public TnBasicCommandFactory(IDbParameterParser dbParameterParser) : base(dbParameterParser) {}

        // ===============================================================================
        //                                                                Command Creation
        //                                                                ================
        public override IDbCommand CreateCommand(IDbConnection conn, string sql) {
            IDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = ChangeSignSql(cmd, sql);
            StatementConfig defaultStatementConfig = DBFluteConfig.GetInstance().DefaultStatementConfig;
            bool internalDebug = DBFluteConfig.GetInstance().IsInternalDebug;
            StatementConfig config = FindStatementConfigOnThread();
            if (config != null && config.HasQueryTimeout()) {
                if (internalDebug) {
                    _log.Debug("...Setting statement config as request: " + config);
                }
                cmd.CommandTimeout = config.GetQueryTimeout().Value;// DBFlute original logic.
            } else if (defaultStatementConfig != null && defaultStatementConfig.HasQueryTimeout()) {
                if (internalDebug) {
                    _log.Debug("...Setting statement config as default: " + config);
                }
                cmd.CommandTimeout = defaultStatementConfig.GetQueryTimeout().Value;// DBFlute original logic.
            } else {
                if (CommandTimeout > -1) {
                    cmd.CommandTimeout = CommandTimeout;// S2Dao original logic.
                }
            }
            return cmd;
        }

        protected StatementConfig FindStatementConfigOnThread() {
            StatementConfig config = null;
            if (ConditionBeanContext.IsExistConditionBeanOnThread()) {
                ConditionBean cb = ConditionBeanContext.GetConditionBeanOnThread();
                config = cb.StatementConfig;
            } else if (OutsideSqlContext.IsExistOutsideSqlContextOnThread()) {
                OutsideSqlContext context = OutsideSqlContext.GetOutsideSqlContextOnThread();
                config = context.StatementConfig;
            }
            return config;
        }
    }
}
