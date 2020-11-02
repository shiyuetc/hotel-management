
using System;
using System.Collections.Generic;

namespace Dbflute.AllCommon.CBean {

    public delegate void SpecifyQuery<CB>(CB cb) where CB : ConditionBean;
}
