
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
    [Bean(typeof(Mst客室マスタ))]
    public partial interface Mst客室マスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mst客室マスタCB cb);
        IList<Mst客室マスタ> SelectList(Mst客室マスタCB cb);

        int Insert(Mst客室マスタ entity);
        int UpdateModifiedOnly(Mst客室マスタ entity);
        int UpdateNonstrictModifiedOnly(Mst客室マスタ entity);
        int UpdateByQuery(Mst客室マスタCB cb, Mst客室マスタ entity);
        int Delete(Mst客室マスタ entity);
        int DeleteNonstrict(Mst客室マスタ entity);
        int DeleteByQuery(Mst客室マスタCB cb);// {DBFlute-0.7.9}
    }
}
