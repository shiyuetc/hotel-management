
using System;
using System.Collections;

namespace Dbflute.AllCommon {

    public interface EntityDefinedCommonColumn : Entity {

        void EnableCommonColumnAutoSetup(); // for after disable because the default is enabled
        void DisableCommonColumnAutoSetup();
        bool CanCommonColumnAutoSetup();
    }
}
