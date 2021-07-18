
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
    [Bean(typeof(Kbn職位区分))]
    public partial interface Kbn職位区分Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Kbn職位区分CB cb);
        IList<Kbn職位区分> SelectList(Kbn職位区分CB cb);

        int Insert(Kbn職位区分 entity);
        int UpdateModifiedOnly(Kbn職位区分 entity);
        int UpdateNonstrictModifiedOnly(Kbn職位区分 entity);
        int UpdateByQuery(Kbn職位区分CB cb, Kbn職位区分 entity);
        int Delete(Kbn職位区分 entity);
        int DeleteNonstrict(Kbn職位区分 entity);
        int DeleteByQuery(Kbn職位区分CB cb);// {DBFlute-0.7.9}
    }
}
