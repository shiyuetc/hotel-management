
using System;
using System.Collections.Generic;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CKey;
using Dbflute.AllCommon.CBean.COption;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public abstract class AbstractBsDmyプロシージャCQ : AbstractConditionQuery {

        public AbstractBsDmyプロシージャCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public override String getTableDbName() { return "dmyプロシージャ"; }
        public override String getTableSqlName() { return "dmyプロシージャ"; }

        public void SetDummy_Equal(String v) { DoSetDummy_Equal(fRES(v)); }
        protected void DoSetDummy_Equal(String v) { regDummy(CK_EQ, v); }
        public void SetDummy_NotEqual(String v) { DoSetDummy_NotEqual(fRES(v)); }
        protected void DoSetDummy_NotEqual(String v) { regDummy(CK_NES, v); }
        public void SetDummy_GreaterThan(String v) { regDummy(CK_GT, fRES(v)); }
        public void SetDummy_LessThan(String v) { regDummy(CK_LT, fRES(v)); }
        public void SetDummy_GreaterEqual(String v) { regDummy(CK_GE, fRES(v)); }
        public void SetDummy_LessEqual(String v) { regDummy(CK_LE, fRES(v)); }
        public void SetDummy_InScope(IList<String> ls) { regINS<String>(CK_INS, cTL<String>(ls), getCValueDummy(), "dummy"); }
        public void SetDummy_NotInScope(IList<String> ls) { regINS<String>(CK_NINS, cTL<String>(ls), getCValueDummy(), "dummy"); }
        public void SetDummy_PrefixSearch(String v) { SetDummy_LikeSearch(v, cLSOP()); }
        public void SetDummy_LikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_LS, fRES(v), getCValueDummy(), "dummy", option); }
        public void SetDummy_NotLikeSearch(String v, LikeSearchOption option)
        { regLSQ(CK_NLS, fRES(v), getCValueDummy(), "dummy", option); }
        public void SetDummy_IsNull() { regDummy(CK_ISN, DUMMY_OBJECT); }
        public void SetDummy_IsNotNull() { regDummy(CK_ISNN, DUMMY_OBJECT); }
        protected void regDummy(ConditionKey k, Object v) { regQ(k, v, getCValueDummy(), "dummy"); }
        protected abstract ConditionValue getCValueDummy();

        public override String ToString() { return xgetSqlClause().getClause(); }
    }
}
