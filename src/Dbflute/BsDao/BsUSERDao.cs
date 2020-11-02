
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
    [Bean(typeof(USER))]
    public partial interface USERDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(USERCB cb);
        IList<USER> SelectList(USERCB cb);

        int Insert(USER entity);
        int UpdateModifiedOnly(USER entity);
        int UpdateNonstrictModifiedOnly(USER entity);
        int UpdateByQuery(USERCB cb, USER entity);
        int Delete(USER entity);
        int DeleteNonstrict(USER entity);
        int DeleteByQuery(USERCB cb);// {DBFlute-0.7.9}
    }
}
