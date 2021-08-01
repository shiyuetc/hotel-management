
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
    [Bean(typeof(Mst従業員マスタ))]
    public partial interface Mst従業員マスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mst従業員マスタCB cb);
        IList<Mst従業員マスタ> SelectList(Mst従業員マスタCB cb);

        int Insert(Mst従業員マスタ entity);
        int UpdateModifiedOnly(Mst従業員マスタ entity);
        int UpdateNonstrictModifiedOnly(Mst従業員マスタ entity);
        int UpdateByQuery(Mst従業員マスタCB cb, Mst従業員マスタ entity);
        int Delete(Mst従業員マスタ entity);
        int DeleteNonstrict(Mst従業員マスタ entity);
        int DeleteByQuery(Mst従業員マスタCB cb);// {DBFlute-0.7.9}
    }
}
