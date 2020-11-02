
using System;

namespace Dbflute.AllCommon.Annotation {

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class OutsideSql : Attribute {
        public OutsideSql() {
        }
    }
}
