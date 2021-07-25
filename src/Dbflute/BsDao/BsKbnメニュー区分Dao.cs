
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
    [Bean(typeof(Kbnメニュー区分))]
    public partial interface Kbnメニュー区分Dao : DaoWritable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(Kbnメニュー区分CB cb);
        IList<Kbnメニュー区分> SelectList(Kbnメニュー区分CB cb);

        int Insert(Kbnメニュー区分 entity);
        int UpdateModifiedOnly(Kbnメニュー区分 entity);
        int UpdateNonstrictModifiedOnly(Kbnメニュー区分 entity);
        int UpdateByQuery(Kbnメニュー区分CB cb, Kbnメニュー区分 entity);
        int Delete(Kbnメニュー区分 entity);
        int DeleteNonstrict(Kbnメニュー区分 entity);
        int DeleteByQuery(Kbnメニュー区分CB cb);// {DBFlute-0.7.9}
    }
}
