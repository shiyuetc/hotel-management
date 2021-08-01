
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
    [Bean(typeof(Mst会員マスタ))]
    public partial interface Mst会員マスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mst会員マスタCB cb);
        IList<Mst会員マスタ> SelectList(Mst会員マスタCB cb);

        int Insert(Mst会員マスタ entity);
        int UpdateModifiedOnly(Mst会員マスタ entity);
        int UpdateNonstrictModifiedOnly(Mst会員マスタ entity);
        int UpdateByQuery(Mst会員マスタCB cb, Mst会員マスタ entity);
        int Delete(Mst会員マスタ entity);
        int DeleteNonstrict(Mst会員マスタ entity);
        int DeleteByQuery(Mst会員マスタCB cb);// {DBFlute-0.7.9}
    }
}
