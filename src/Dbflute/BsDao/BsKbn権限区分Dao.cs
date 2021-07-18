
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
    [Bean(typeof(Kbn権限区分))]
    public partial interface Kbn権限区分Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Kbn権限区分CB cb);
        IList<Kbn権限区分> SelectList(Kbn権限区分CB cb);

        int Insert(Kbn権限区分 entity);
        int UpdateModifiedOnly(Kbn権限区分 entity);
        int UpdateNonstrictModifiedOnly(Kbn権限区分 entity);
        int UpdateByQuery(Kbn権限区分CB cb, Kbn権限区分 entity);
        int Delete(Kbn権限区分 entity);
        int DeleteNonstrict(Kbn権限区分 entity);
        int DeleteByQuery(Kbn権限区分CB cb);// {DBFlute-0.7.9}
    }
}
