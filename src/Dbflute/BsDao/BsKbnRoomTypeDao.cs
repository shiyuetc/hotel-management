
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
    [Bean(typeof(KbnRoomType))]
    public partial interface KbnRoomTypeDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(KbnRoomTypeCB cb);
        IList<KbnRoomType> SelectList(KbnRoomTypeCB cb);

        int Insert(KbnRoomType entity);
        int UpdateModifiedOnly(KbnRoomType entity);
        int UpdateNonstrictModifiedOnly(KbnRoomType entity);
        int UpdateByQuery(KbnRoomTypeCB cb, KbnRoomType entity);
        int Delete(KbnRoomType entity);
        int DeleteNonstrict(KbnRoomType entity);
        int DeleteByQuery(KbnRoomTypeCB cb);// {DBFlute-0.7.9}
    }
}
