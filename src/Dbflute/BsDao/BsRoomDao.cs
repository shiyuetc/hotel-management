
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
    [Bean(typeof(Room))]
    public partial interface RoomDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(RoomCB cb);
        IList<Room> SelectList(RoomCB cb);

        int Insert(Room entity);
        int UpdateModifiedOnly(Room entity);
        int UpdateNonstrictModifiedOnly(Room entity);
        int UpdateByQuery(RoomCB cb, Room entity);
        int Delete(Room entity);
        int DeleteNonstrict(Room entity);
        int DeleteByQuery(RoomCB cb);// {DBFlute-0.7.9}

        int? SelectNextVal();
    }
}
