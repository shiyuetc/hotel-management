
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
    [Bean(typeof(Dch客室利用台帳))]
    public partial interface Dch客室利用台帳Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Dch客室利用台帳CB cb);
        IList<Dch客室利用台帳> SelectList(Dch客室利用台帳CB cb);

        int Insert(Dch客室利用台帳 entity);
        int UpdateModifiedOnly(Dch客室利用台帳 entity);
        int UpdateNonstrictModifiedOnly(Dch客室利用台帳 entity);
        int UpdateByQuery(Dch客室利用台帳CB cb, Dch客室利用台帳 entity);
        int Delete(Dch客室利用台帳 entity);
        int DeleteNonstrict(Dch客室利用台帳 entity);
        int DeleteByQuery(Dch客室利用台帳CB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
