
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
    [Bean(typeof(MstEmployee))]
    public partial interface MstEmployeeDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MstEmployeeCB cb);
        IList<MstEmployee> SelectList(MstEmployeeCB cb);

        int Insert(MstEmployee entity);
        int UpdateModifiedOnly(MstEmployee entity);
        int UpdateNonstrictModifiedOnly(MstEmployee entity);
        int UpdateByQuery(MstEmployeeCB cb, MstEmployee entity);
        int Delete(MstEmployee entity);
        int DeleteNonstrict(MstEmployee entity);
        int DeleteByQuery(MstEmployeeCB cb);// {DBFlute-0.7.9}

        int? SelectNextVal();
    }
}
