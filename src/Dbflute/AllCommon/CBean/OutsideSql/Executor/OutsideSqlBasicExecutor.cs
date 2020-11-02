
using System;
using System.Collections.Generic;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.OutsideSql;
using Dbflute.AllCommon.Ado;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.CBean.OutsideSql.Executor {

    public class OutsideSqlBasicExecutor {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected OutsideSqlDao _outsideSqlDao;
        protected String _tableDbName;
        protected bool _dynamicBinding;
        protected StatementConfig _statementConfig;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public OutsideSqlBasicExecutor(OutsideSqlDao outsideSqlDao, String tableDbName) {
            _outsideSqlDao = outsideSqlDao;
            _tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public ListResultBean<ENTITY> SelectList<ENTITY>(String path, Object pmb) {
            IList<ENTITY> resultList = ToGenericList<ENTITY>(_outsideSqlDao.SelectList(path, pmb, CreateOutsideSqlOption(), typeof(ENTITY)));
            return new ResultBeanBuilder<ENTITY>(_tableDbName).BuildListResultBean(resultList);
            
        }

        protected IList<ENTITY> ToGenericList<ENTITY>(System.Collections.IList plainList) {
            return DfCollectionUtil.ToGenericList<ENTITY>(plainList);
        }

        // ===============================================================================
        //                                                                         Execute
        //                                                                         =======
        public int Execute(String path, Object pmb) {
            return _outsideSqlDao.Execute(path, pmb, CreateOutsideSqlOption());
        }

        // Implements at the future!
        //    public int BatchExecute(String path, Object pmb) {
        //        throw new UnsupportedOperationException("Sorry! The method of batchExecute() has not been implemented yet.");
        //        // return _outsideSqlDao.batchExecute(path, pmb, CreateOutsideSqlOption());
        //    }

        // [DBFlute-0.8.0]
        // ===============================================================================
        //                                                                  Procedure Call
        //                                                                  ==============
        public void Call(ProcedurePmb pmb) {
            if (pmb == null) { throw new ArgumentNullException("The argument of call() 'pmb' should not be null!"); }
            _outsideSqlDao.Call(pmb.ProcedureName, pmb, CreateOutsideSqlOption());
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public OutsideSqlCursorExecutor<Object> CursorHandling() {
            return new OutsideSqlCursorExecutor<Object>(_outsideSqlDao, CreateOutsideSqlOption());
        }

        public OutsideSqlEntityExecutor<Object> EntityHandling() {
            return new OutsideSqlEntityExecutor<Object>(_outsideSqlDao, CreateOutsideSqlOption());
        }

        public OutsideSqlPagingExecutor AutoPaging() {
            OutsideSqlOption option = CreateOutsideSqlOption();
            option.AutoPaging();
            return new OutsideSqlPagingExecutor(_outsideSqlDao, option, _tableDbName);
        }

        public OutsideSqlPagingExecutor ManualPaging() {
            OutsideSqlOption option = CreateOutsideSqlOption();
            option.ManualPaging();
            return new OutsideSqlPagingExecutor(_outsideSqlDao, option, _tableDbName);
        }

        public OutsideSqlBasicExecutor DynamicBinding() {
            _dynamicBinding = true;
            return this;
        }

        public OutsideSqlBasicExecutor Configure(StatementConfig statementConfig) {
            _statementConfig = statementConfig;
            return this;
        }

        // -------------------------------------------------
        //                                            Helper
        //                                            ------
        protected OutsideSqlOption CreateOutsideSqlOption() {
            OutsideSqlOption option = new OutsideSqlOption();
            option.StatementConfig = _statementConfig;
            if (_dynamicBinding) {
                option.DynamicBinding();
            }
			option.TableDbName = _tableDbName;
            return option;
        }
    }
}
