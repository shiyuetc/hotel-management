
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
    [Bean(typeof(Dch宿泊利用台帳))]
    public partial interface Dch宿泊利用台帳Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Dch宿泊利用台帳CB cb);
        IList<Dch宿泊利用台帳> SelectList(Dch宿泊利用台帳CB cb);

        int Insert(Dch宿泊利用台帳 entity);
        int UpdateModifiedOnly(Dch宿泊利用台帳 entity);
        int UpdateNonstrictModifiedOnly(Dch宿泊利用台帳 entity);
        int UpdateByQuery(Dch宿泊利用台帳CB cb, Dch宿泊利用台帳 entity);
        int Delete(Dch宿泊利用台帳 entity);
        int DeleteNonstrict(Dch宿泊利用台帳 entity);
        int DeleteByQuery(Dch宿泊利用台帳CB cb);// {DBFlute-0.7.9}
    }
}
