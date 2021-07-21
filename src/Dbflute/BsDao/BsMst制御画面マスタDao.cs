
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
    [Bean(typeof(Mst制御画面マスタ))]
    public partial interface Mst制御画面マスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mst制御画面マスタCB cb);
        IList<Mst制御画面マスタ> SelectList(Mst制御画面マスタCB cb);

        int Insert(Mst制御画面マスタ entity);
        int UpdateModifiedOnly(Mst制御画面マスタ entity);
        int UpdateNonstrictModifiedOnly(Mst制御画面マスタ entity);
        int UpdateByQuery(Mst制御画面マスタCB cb, Mst制御画面マスタ entity);
        int Delete(Mst制御画面マスタ entity);
        int DeleteNonstrict(Mst制御画面マスタ entity);
        int DeleteByQuery(Mst制御画面マスタCB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
