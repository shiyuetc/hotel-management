
using System;

using Dbflute.AllCommon.CBean.OutsideSql;
using Dbflute.AllCommon.Ado;

namespace Dbflute.AllCommon.CBean.OutsideSql.Executor {

    public class OutsideSqlCursorExecutor<PARAMETER_BEAN> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected OutsideSqlDao _outsideSqlDao;

        protected OutsideSqlOption _outsideSqlOption;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public OutsideSqlCursorExecutor(OutsideSqlDao outsideSqlDao, OutsideSqlOption outsideSqlOption) {
            this._outsideSqlDao = outsideSqlDao;
            this._outsideSqlOption = outsideSqlOption;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public Object SelectCursor(String path, PARAMETER_BEAN pmb, CursorHandler handler) {
            return _outsideSqlDao.SelectCursor(path, pmb, _outsideSqlOption, handler);
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public OutsideSqlCursorExecutor<PARAMETER_BEAN> Configure(StatementConfig statementConfig) {
            _outsideSqlOption.StatementConfig = statementConfig;
            return this;
        }

        public OutsideSqlCursorExecutor<PARAMETER_BEAN> DynamicBinding() {
            _outsideSqlOption.DynamicBinding();
            return this;
        }
    }
}
