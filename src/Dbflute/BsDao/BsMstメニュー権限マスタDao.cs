
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
    [Bean(typeof(Mstメニュー権限マスタ))]
    public partial interface Mstメニュー権限マスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mstメニュー権限マスタCB cb);
        IList<Mstメニュー権限マスタ> SelectList(Mstメニュー権限マスタCB cb);

        int Insert(Mstメニュー権限マスタ entity);
        int UpdateModifiedOnly(Mstメニュー権限マスタ entity);
        int UpdateNonstrictModifiedOnly(Mstメニュー権限マスタ entity);
        int UpdateByQuery(Mstメニュー権限マスタCB cb, Mstメニュー権限マスタ entity);
        int Delete(Mstメニュー権限マスタ entity);
        int DeleteNonstrict(Mstメニュー権限マスタ entity);
        int DeleteByQuery(Mstメニュー権限マスタCB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
