
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
    [Bean(typeof(Dmyプロシージャ))]
    public partial interface DmyプロシージャDao : DaoReadable {
		void InitializeDaoMetaData(String methodName);// Very Internal Method!

        int SelectCount(DmyプロシージャCB cb);
        IList<Dmyプロシージャ> SelectList(DmyプロシージャCB cb);

    }
}
