
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsDmyプロシージャCQ : AbstractBsDmyプロシージャCQ {

        protected DmyプロシージャCIQ _inlineQuery;

        public BsDmyプロシージャCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public DmyプロシージャCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new DmyプロシージャCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public DmyプロシージャCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            DmyプロシージャCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _dummy;
        public ConditionValue Dummy {
            get { if (_dummy == null) { _dummy = new ConditionValue(); } return _dummy; }
        }
        protected override ConditionValue getCValueDummy() { return this.Dummy; }


        public BsDmyプロシージャCQ AddOrderBy_Dummy_Asc() { regOBA("dummy");return this; }
        public BsDmyプロシージャCQ AddOrderBy_Dummy_Desc() { regOBD("dummy");return this; }

        public BsDmyプロシージャCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsDmyプロシージャCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    

    }
}
