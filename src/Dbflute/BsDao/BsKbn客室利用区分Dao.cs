
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
    [Bean(typeof(Kbn客室利用区分))]
    public partial interface Kbn客室利用区分Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Kbn客室利用区分CB cb);
        IList<Kbn客室利用区分> SelectList(Kbn客室利用区分CB cb);

        int Insert(Kbn客室利用区分 entity);
        int UpdateModifiedOnly(Kbn客室利用区分 entity);
        int UpdateNonstrictModifiedOnly(Kbn客室利用区分 entity);
        int UpdateByQuery(Kbn客室利用区分CB cb, Kbn客室利用区分 entity);
        int Delete(Kbn客室利用区分 entity);
        int DeleteNonstrict(Kbn客室利用区分 entity);
        int DeleteByQuery(Kbn客室利用区分CB cb);// {DBFlute-0.7.9}
    }
}
