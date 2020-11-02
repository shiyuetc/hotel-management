
using System;

namespace Dbflute.AllCommon.S2Dao.Internal.SqlLog {

    public class InternalSqlLogRegistryLocator {
        protected static InternalSqlLogRegistry instance;
        public static InternalSqlLogRegistry Instance { get {
            return instance;
        } set {
            instance = value;
        }}
    }
}
