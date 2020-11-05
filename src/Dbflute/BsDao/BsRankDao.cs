
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
    [Bean(typeof(Rank))]
    public partial interface RankDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(RankCB cb);
        IList<Rank> SelectList(RankCB cb);

        int Insert(Rank entity);
        int UpdateModifiedOnly(Rank entity);
        int UpdateNonstrictModifiedOnly(Rank entity);
        int UpdateByQuery(RankCB cb, Rank entity);
        int Delete(Rank entity);
        int DeleteNonstrict(Rank entity);
        int DeleteByQuery(RankCB cb);// {DBFlute-0.7.9}
    }
}
