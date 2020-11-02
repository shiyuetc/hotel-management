
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
    [Bean(typeof(MstUser))]
    public partial interface MstUserDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MstUserCB cb);
        IList<MstUser> SelectList(MstUserCB cb);

        int Insert(MstUser entity);
        int UpdateModifiedOnly(MstUser entity);
        int UpdateNonstrictModifiedOnly(MstUser entity);
        int UpdateByQuery(MstUserCB cb, MstUser entity);
        int Delete(MstUser entity);
        int DeleteNonstrict(MstUser entity);
        int DeleteByQuery(MstUserCB cb);// {DBFlute-0.7.9}
    }
}
