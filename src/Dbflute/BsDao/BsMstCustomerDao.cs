
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
    [Bean(typeof(MstCustomer))]
    public partial interface MstCustomerDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MstCustomerCB cb);
        IList<MstCustomer> SelectList(MstCustomerCB cb);

        int Insert(MstCustomer entity);
        int UpdateModifiedOnly(MstCustomer entity);
        int UpdateNonstrictModifiedOnly(MstCustomer entity);
        int UpdateByQuery(MstCustomerCB cb, MstCustomer entity);
        int Delete(MstCustomer entity);
        int DeleteNonstrict(MstCustomer entity);
        int DeleteByQuery(MstCustomerCB cb);// {DBFlute-0.7.9}

        int? SelectNextVal();
    }
}
