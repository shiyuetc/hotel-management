
using System;

using Seasar.Quill.Attrs;

namespace Dbflute.AllCommon {

    [Implementation(typeof(CacheDaoSelector))]
    public interface DaoSelector {
        DAO Select<DAO>() where DAO : DaoReadable;
        DaoReadable ByName(String tableFlexibleName);
    }
}
