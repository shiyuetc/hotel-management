
using System;

using Seasar.Quill.Attrs;
using Dbflute.AllCommon.Bhv;

namespace Dbflute.AllCommon {

    [Implementation(typeof(CacheBehaviorSelector))]
    public interface BehaviorSelector {
        void InitializeConditionBeanMetaData();
        BEHAVIOR Select<BEHAVIOR>() where BEHAVIOR : BehaviorReadable;
        BehaviorReadable ByName(String tableFlexibleName);
    }
}
