
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
    [Bean(typeof(Mst権限マスタ))]
    public partial interface Mst権限マスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mst権限マスタCB cb);
        IList<Mst権限マスタ> SelectList(Mst権限マスタCB cb);

        int Insert(Mst権限マスタ entity);
        int UpdateModifiedOnly(Mst権限マスタ entity);
        int UpdateNonstrictModifiedOnly(Mst権限マスタ entity);
        int Delete(Mst権限マスタ entity);
        int DeleteNonstrict(Mst権限マスタ entity);
    }
}
