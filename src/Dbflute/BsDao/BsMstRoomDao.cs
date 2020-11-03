
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
    [Bean(typeof(MstRoom))]
    public partial interface MstRoomDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(MstRoomCB cb);
        IList<MstRoom> SelectList(MstRoomCB cb);

        int Insert(MstRoom entity);
        int UpdateModifiedOnly(MstRoom entity);
        int UpdateNonstrictModifiedOnly(MstRoom entity);
        int UpdateByQuery(MstRoomCB cb, MstRoom entity);
        int Delete(MstRoom entity);
        int DeleteNonstrict(MstRoom entity);
        int DeleteByQuery(MstRoomCB cb);// {DBFlute-0.7.9}

        int? SelectNextVal();
    }
}
