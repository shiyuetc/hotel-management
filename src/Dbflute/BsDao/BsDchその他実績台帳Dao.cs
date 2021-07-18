
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
    [Bean(typeof(Dchその他実績台帳))]
    public partial interface Dchその他実績台帳Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Dchその他実績台帳CB cb);
        IList<Dchその他実績台帳> SelectList(Dchその他実績台帳CB cb);

        int Insert(Dchその他実績台帳 entity);
        int UpdateModifiedOnly(Dchその他実績台帳 entity);
        int UpdateNonstrictModifiedOnly(Dchその他実績台帳 entity);
        int UpdateByQuery(Dchその他実績台帳CB cb, Dchその他実績台帳 entity);
        int Delete(Dchその他実績台帳 entity);
        int DeleteNonstrict(Dchその他実績台帳 entity);
        int DeleteByQuery(Dchその他実績台帳CB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
