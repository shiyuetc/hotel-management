
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
    [Bean(typeof(Dch従業員職位履歴台帳))]
    public partial interface Dch従業員職位履歴台帳Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Dch従業員職位履歴台帳CB cb);
        IList<Dch従業員職位履歴台帳> SelectList(Dch従業員職位履歴台帳CB cb);

        int Insert(Dch従業員職位履歴台帳 entity);
        int UpdateModifiedOnly(Dch従業員職位履歴台帳 entity);
        int UpdateNonstrictModifiedOnly(Dch従業員職位履歴台帳 entity);
        int UpdateByQuery(Dch従業員職位履歴台帳CB cb, Dch従業員職位履歴台帳 entity);
        int Delete(Dch従業員職位履歴台帳 entity);
        int DeleteNonstrict(Dch従業員職位履歴台帳 entity);
        int DeleteByQuery(Dch従業員職位履歴台帳CB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
