
using System;
using System.Collections.Generic;

namespace Dbflute.AllCommon.CBean {

    public class ResultBeanBuilder<ENTITY> {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected String _tableDbName;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public ResultBeanBuilder(String tableDbName) {
            _tableDbName = tableDbName;
        }

        // ===============================================================================
        //                                                                         Builder
        //                                                                         =======
        public ListResultBean<ENTITY> BuildListResultBean(IList<ENTITY> selectedList) {
            ListResultBean<ENTITY> rb = new ListResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = selectedList.Count;
            rb.SelectedList = selectedList;
            return rb;
        }

        public ListResultBean<ENTITY> BuildListResultBean(ConditionBean ob, IList<ENTITY> selectedList) {
            ListResultBean<ENTITY> rb = new ListResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = selectedList.Count;
            rb.SelectedList = selectedList;
            rb.OrderByClause = ob.SqlComponentOfOrderByClause;
            return rb;
        }

        public PagingResultBean<ENTITY> BuildPagingResultBean(PagingBean pb, int allRecordCount, IList<ENTITY> selectedList) {
            PagingResultBean<ENTITY> rb = new PagingResultBean<ENTITY>();
            rb.TableDbName = _tableDbName;
            rb.AllRecordCount = allRecordCount;
            rb.SelectedList = selectedList;
            rb.OrderByClause = pb.SqlComponentOfOrderByClause;
            rb.CurrentPageNumber = pb.FetchPageNumber;
            rb.PageSize = pb.FetchSize;
            return rb;
        }
    }
}
