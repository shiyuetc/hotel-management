
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
    [Bean(typeof(Mst画面マスタ))]
    public partial interface Mst画面マスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mst画面マスタCB cb);
        IList<Mst画面マスタ> SelectList(Mst画面マスタCB cb);

        int Insert(Mst画面マスタ entity);
        int UpdateModifiedOnly(Mst画面マスタ entity);
        int UpdateNonstrictModifiedOnly(Mst画面マスタ entity);
        int UpdateByQuery(Mst画面マスタCB cb, Mst画面マスタ entity);
        int Delete(Mst画面マスタ entity);
        int DeleteNonstrict(Mst画面マスタ entity);
        int DeleteByQuery(Mst画面マスタCB cb);// {DBFlute-0.7.9}
    }
}
