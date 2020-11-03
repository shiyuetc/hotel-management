
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
    [Bean(typeof(KbnRank))]
    public partial interface KbnRankDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(KbnRankCB cb);
        IList<KbnRank> SelectList(KbnRankCB cb);

        int Insert(KbnRank entity);
        int UpdateModifiedOnly(KbnRank entity);
        int UpdateNonstrictModifiedOnly(KbnRank entity);
        int UpdateByQuery(KbnRankCB cb, KbnRank entity);
        int Delete(KbnRank entity);
        int DeleteNonstrict(KbnRank entity);
        int DeleteByQuery(KbnRankCB cb);// {DBFlute-0.7.9}
    }
}
