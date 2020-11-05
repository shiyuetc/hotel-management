
using System;
using System.Collections.Generic;

using Seasar.Quill.Attrs;
using Seasar.Dao.Attrs;

using Dbflute.AllCommon;
using Dbflute.AllCommon.S2Dao;
using Dbflute.ExEntity;
using Dbflute.CBean;

namespace Dbflute.ExDao {

    [Implementation]
    [S2Dao(typeof(S2DaoSetting))]
    [Bean(typeof(Customer))]
    public partial interface CustomerDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(CustomerCB cb);
        IList<Customer> SelectList(CustomerCB cb);

        int Insert(Customer entity);
        int UpdateModifiedOnly(Customer entity);
        int UpdateNonstrictModifiedOnly(Customer entity);
        int UpdateByQuery(CustomerCB cb, Customer entity);
        int Delete(Customer entity);
        int DeleteNonstrict(Customer entity);
        int DeleteByQuery(CustomerCB cb);// {DBFlute-0.7.9}

        int? SelectNextVal();
    }
}
