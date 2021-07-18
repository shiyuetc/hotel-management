
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
    [Bean(typeof(Dchその他予定台帳))]
    public partial interface Dchその他予定台帳Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Dchその他予定台帳CB cb);
        IList<Dchその他予定台帳> SelectList(Dchその他予定台帳CB cb);

        int Insert(Dchその他予定台帳 entity);
        int UpdateModifiedOnly(Dchその他予定台帳 entity);
        int UpdateNonstrictModifiedOnly(Dchその他予定台帳 entity);
        int UpdateByQuery(Dchその他予定台帳CB cb, Dchその他予定台帳 entity);
        int Delete(Dchその他予定台帳 entity);
        int DeleteNonstrict(Dchその他予定台帳 entity);
        int DeleteByQuery(Dchその他予定台帳CB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
