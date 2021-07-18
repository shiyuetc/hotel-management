
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
    [Bean(typeof(Mst客室タイプマスタ))]
    public partial interface Mst客室タイプマスタDao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Mst客室タイプマスタCB cb);
        IList<Mst客室タイプマスタ> SelectList(Mst客室タイプマスタCB cb);

        int Insert(Mst客室タイプマスタ entity);
        int UpdateModifiedOnly(Mst客室タイプマスタ entity);
        int UpdateNonstrictModifiedOnly(Mst客室タイプマスタ entity);
        int UpdateByQuery(Mst客室タイプマスタCB cb, Mst客室タイプマスタ entity);
        int Delete(Mst客室タイプマスタ entity);
        int DeleteNonstrict(Mst客室タイプマスタ entity);
        int DeleteByQuery(Mst客室タイプマスタCB cb);// {DBFlute-0.7.9}

        long? SelectNextVal();
    }
}
