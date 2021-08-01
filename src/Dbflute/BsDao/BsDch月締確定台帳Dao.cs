
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
    [Bean(typeof(Dch月締確定台帳))]
    public partial interface Dch月締確定台帳Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Dch月締確定台帳CB cb);
        IList<Dch月締確定台帳> SelectList(Dch月締確定台帳CB cb);

        int Insert(Dch月締確定台帳 entity);
        int UpdateModifiedOnly(Dch月締確定台帳 entity);
        int UpdateNonstrictModifiedOnly(Dch月締確定台帳 entity);
        int UpdateByQuery(Dch月締確定台帳CB cb, Dch月締確定台帳 entity);
        int Delete(Dch月締確定台帳 entity);
        int DeleteNonstrict(Dch月締確定台帳 entity);
        int DeleteByQuery(Dch月締確定台帳CB cb);// {DBFlute-0.7.9}
    }
}
