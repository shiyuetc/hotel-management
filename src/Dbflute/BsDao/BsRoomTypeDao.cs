
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
    [Bean(typeof(RoomType))]
    public partial interface RoomTypeDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(RoomTypeCB cb);
        IList<RoomType> SelectList(RoomTypeCB cb);

        int Insert(RoomType entity);
        int UpdateModifiedOnly(RoomType entity);
        int UpdateNonstrictModifiedOnly(RoomType entity);
        int UpdateByQuery(RoomTypeCB cb, RoomType entity);
        int Delete(RoomType entity);
        int DeleteNonstrict(RoomType entity);
        int DeleteByQuery(RoomTypeCB cb);// {DBFlute-0.7.9}
    }
}
