
using System;
using System.Collections.Generic;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.OutsideSql;
using Dbflute.AllCommon.Exp;
using Dbflute.AllCommon.Ado;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.CBean.OutsideSql.Executor {

    public class OutsideSqlPagingExecutor {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected OutsideSqlDao _outsideSqlDao;
        protected OutsideSqlOption _outsideSqlOption;
        protected String _tableDbName;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public OutsideSqlPagingExecutor(OutsideSqlDao outsideSqlDao, OutsideSqlOption outsideSqlOption, String tableDbName) {
            this._outsideSqlDao = outsideSqlDao;
            this._outsideSqlOption = outsideSqlOption;
            this._tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                          Select
        //                                                                          ======
        public ListResultBean<ENTITY> SelectList<ENTITY>(String path, PagingBean pmb) {
            IList<ENTITY> resultList = ToGenericList<ENTITY>(_outsideSqlDao.SelectList(path, pmb, _outsideSqlOption, typeof(ENTITY)));
            return new ResultBeanBuilder<ENTITY>(_tableDbName).BuildListResultBean(resultList);
        }

        protected IList<ENTITY> ToGenericList<ENTITY>(System.Collections.IList plainList) {
            return DfCollectionUtil.ToGenericList<ENTITY>(plainList);
        }

        public PagingResultBean<ENTITY> SelectPage<ENTITY>(String path, PagingBean pmb) {
            OutsideSqlOption countOption = _outsideSqlOption.CopyOptionWithoutPaging();
            OutsideSqlEntityExecutor<PagingBean> countExecutor
                    = new OutsideSqlEntityExecutor<PagingBean>(_outsideSqlDao, countOption);
            DefaultPagingHandler<ENTITY> handler
                    = new DefaultPagingHandler<ENTITY>(path, pmb, typeof(ENTITY), countExecutor, this, _tableDbName);
            PagingInvoker<ENTITY> invoker = new PagingInvoker<ENTITY>(_tableDbName);
            if (pmb.IsCountLater) {
                invoker.CountLater();
            }
            return invoker.InvokePaging(handler);
        }

        protected class DefaultPagingHandler<ENTITY> : PagingHandler<ENTITY> {
            protected String _path;
            protected PagingBean _pmb;
            protected Type _entityType;
            protected OutsideSqlEntityExecutor<PagingBean> _countExecutor;
            protected OutsideSqlPagingExecutor _pagingExecutor;
            protected String _tableDbName;

            public DefaultPagingHandler(String path, PagingBean pmb, Type entityType
                    , OutsideSqlEntityExecutor<PagingBean> countExecutor
                    , OutsideSqlPagingExecutor pagingExecutor, String tableDbName) {
                this._path = path;
                this._pmb = pmb;
                this._entityType = entityType;
                this._countExecutor = countExecutor;
                this._pagingExecutor = pagingExecutor;
                this._tableDbName = tableDbName;
            }

            public PagingBean PagingBean {
                get { return _pmb; }
            }

            public int Count() {
                _pmb.XSetPaging(false);
                try {
                    return _countExecutor.SelectEntityWithDeletedCheck<int>(_path, _pmb);
                } catch (EntityDuplicatedException e) { // means switching the select clause failed
                    throwPagingCountSelectNotCountException(_path, _pmb, _entityType, e);
                    return -1; // unreachable
                }
            }

            public IList<ENTITY> Paging() {
                _pmb.XSetPaging(true);
                return _pagingExecutor.SelectList<ENTITY>(_path, _pmb);
            }

            protected void throwPagingCountSelectNotCountException(String path, PagingBean pmb,
                    Type entityType, EntityDuplicatedException e) {
                String msg = "Look! Read the message below." + ln();
                msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
                msg = msg + "The count select for paging could not get a count." + ln();
                msg = msg + ln();
                msg = msg + "[Advice]" + ln();
                msg = msg + "A select clause of OutsideSql paging should be switchable like this:" + ln();
                msg = msg + "For example:" + ln();
                msg = msg + "  /*IF pmb.IsPaging*/" + ln();
                msg = msg + "  select member.MEMBER_ID" + ln();
                msg = msg + "       , member.MEMBER_NAME" + ln();
                msg = msg + "       , ..." + ln();
                msg = msg + "  -- ELSE select count(*)" + ln();
                msg = msg + "  /*END*/" + ln();
                msg = msg + "    from ..." + ln();
                msg = msg + "   where ..." + ln();
                msg = msg + ln();
                msg = msg + "This specificaton is for both ManualPaging and AutoPaging." + ln();
                msg = msg + "(AutoPaging is only allowed to omit a paging condition)" + ln();
                msg = msg + ln();
                msg = msg + "[Table]" + ln() + _tableDbName + ln();
                msg = msg + ln();
                msg = msg + "[OutsideSql]" + ln() + path + ln();
                msg = msg + ln();
                msg = msg + "[ParameterBean]" + ln() + pmb + ln();
                msg = msg + ln();
                msg = msg + "[Entity Type]" + ln() + entityType + ln();
                msg = msg + "* * * * * * * * * */";
                throw new SystemException(msg, e);
            }
        }

        // ===============================================================================
        //                                                                          Option
        //                                                                          ======
        public OutsideSqlPagingExecutor Configure(StatementConfig statementConfig) {
            _outsideSqlOption.StatementConfig = statementConfig;
            return this;
        }

        public OutsideSqlPagingExecutor DynamicBinding() {
            _outsideSqlOption.DynamicBinding();
            return this;
        }

    	// ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected static String ln() {
            return SimpleSystemUtil.GetLineSeparator();
        }
    }
}
