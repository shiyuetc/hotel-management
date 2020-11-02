
using System;

using Seasar.Extension.ADO;
using Seasar.Dao;

using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.CBean.OutsideSql;
using Dbflute.AllCommon.S2Dao;
using Dbflute.AllCommon.S2Dao.Internal.SqlHandler;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlCommand {

public class InternalProcedureCommand : ISqlCommand {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected IDataSource _dataSource;
        protected IDataReaderHandler _dataReaderHandler;
        protected ICommandFactory _commandFactory;
        protected IDataReaderFactory _dataReaderFactory;
        protected InternalProcedureMetaData _procedureMetaData;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public InternalProcedureCommand(IDataSource dataSource, IDataReaderHandler dataReaderHandler,
                ICommandFactory commandFactory, IDataReaderFactory dataReaderFactory,
                InternalProcedureMetaData procedureMetaData) {
            this._dataSource = dataSource;
            this._dataReaderHandler = dataReaderHandler;
            this._commandFactory = commandFactory;
            this._dataReaderFactory = dataReaderFactory;
            this._procedureMetaData = procedureMetaData;
        }

	    // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public Object Execute(Object[] args) {
            InternalProcedureHandler handler = NewArgumentDtoProcedureHandler();
            OutsideSqlContext outsideSqlContext = OutsideSqlContext.GetOutsideSqlContextOnThread();
            Object pmb = outsideSqlContext.ParameterBean;
            // The logging message SQL of procedure is unnecessary.
            // handler.LoggingMessageSqlArgs = ...;
            return handler.Execute(new Object[]{pmb});
        }
        protected InternalProcedureHandler NewArgumentDtoProcedureHandler() {
            return new InternalProcedureHandler(_dataSource, CreateSql(_procedureMetaData), _dataReaderHandler,
                    _commandFactory, _dataReaderFactory, _procedureMetaData);
        }
        protected String CreateSql(InternalProcedureMetaData procedureMetaData) {
            // StringBuilder sb = new StringBuilder();
            // sb.append("{");
            // int size = procedureMetaData.ParameterTypeSize;
            // if (procedureMetaData.HasReturnParameterType) {
            //     sb.append("? = ");
            //     size--;
            // }
            // sb.append("call ").append(procedureMetaData.ProcedureName).append("(");
            // for (int i = 0; i < size; i++) {
            //     sb.append("?, ");
            // }
            // if (size > 0) {
            //     sb = new StringBuilder().append(sb.toString().Substring(0, sb.length() - 2));
            // }
            // sb.append(")}");
            // return sb.toString();

            // The procedure name is SQL at CSharp!
            return procedureMetaData.ProcedureName;
        }
    }
}
