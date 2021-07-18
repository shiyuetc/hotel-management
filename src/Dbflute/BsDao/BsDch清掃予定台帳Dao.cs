
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
    [Bean(typeof(Dch清掃予定台帳))]
    public partial interface Dch清掃予定台帳Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Dch清掃予定台帳CB cb);
        IList<Dch清掃予定台帳> SelectList(Dch清掃予定台帳CB cb);

        int Insert(Dch清掃予定台帳 entity);
        int UpdateModifiedOnly(Dch清掃予定台帳 entity);
        int UpdateNonstrictModifiedOnly(Dch清掃予定台帳 entity);
        int UpdateByQuery(Dch清掃予定台帳CB cb, Dch清掃予定台帳 entity);
        int Delete(Dch清掃予定台帳 entity);
        int DeleteNonstrict(Dch清掃予定台帳 entity);
        int DeleteByQuery(Dch清掃予定台帳CB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
