
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsUSERCQ : AbstractBsUSERCQ {

        protected USERCIQ _inlineQuery;

        public BsUSERCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public USERCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new USERCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public USERCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            USERCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _iD;
        public ConditionValue ID {
            get { if (_iD == null) { _iD = new ConditionValue(); } return _iD; }
        }
        protected override ConditionValue getCValueID() { return this.ID; }


        public BsUSERCQ AddOrderBy_ID_Asc() { regOBA("ID");return this; }
        public BsUSERCQ AddOrderBy_ID_Desc() { regOBD("ID");return this; }

        protected ConditionValue _nAME;
        public ConditionValue NAME {
            get { if (_nAME == null) { _nAME = new ConditionValue(); } return _nAME; }
        }
        protected override ConditionValue getCValueNAME() { return this.NAME; }


        public BsUSERCQ AddOrderBy_NAME_Asc() { regOBA("NAME");return this; }
        public BsUSERCQ AddOrderBy_NAME_Desc() { regOBD("NAME");return this; }

        protected ConditionValue _uPDATE_DATETIME;
        public ConditionValue UPDATE_DATETIME {
            get { if (_uPDATE_DATETIME == null) { _uPDATE_DATETIME = new ConditionValue(); } return _uPDATE_DATETIME; }
        }
        protected override ConditionValue getCValueUPDATE_DATETIME() { return this.UPDATE_DATETIME; }


        public BsUSERCQ AddOrderBy_UPDATE_DATETIME_Asc() { regOBA("UPDATE_DATETIME");return this; }
        public BsUSERCQ AddOrderBy_UPDATE_DATETIME_Desc() { regOBD("UPDATE_DATETIME");return this; }

        protected ConditionValue _uPDATE_USER;
        public ConditionValue UPDATE_USER {
            get { if (_uPDATE_USER == null) { _uPDATE_USER = new ConditionValue(); } return _uPDATE_USER; }
        }
        protected override ConditionValue getCValueUPDATE_USER() { return this.UPDATE_USER; }


        public BsUSERCQ AddOrderBy_UPDATE_USER_Asc() { regOBA("UPDATE_USER");return this; }
        public BsUSERCQ AddOrderBy_UPDATE_USER_Desc() { regOBD("UPDATE_USER");return this; }

        protected ConditionValue _vERSION_NO;
        public ConditionValue VERSION_NO {
            get { if (_vERSION_NO == null) { _vERSION_NO = new ConditionValue(); } return _vERSION_NO; }
        }
        protected override ConditionValue getCValueVERSION_NO() { return this.VERSION_NO; }


        public BsUSERCQ AddOrderBy_VERSION_NO_Asc() { regOBA("VERSION_NO");return this; }
        public BsUSERCQ AddOrderBy_VERSION_NO_Desc() { regOBD("VERSION_NO");return this; }

        public BsUSERCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsUSERCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, USERCQ> _scalarSubQueryMap;
	    public Map<String, USERCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(USERCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, USERCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, USERCQ> _myselfInScopeSubQueryMap;
        public Map<String, USERCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(USERCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, USERCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
