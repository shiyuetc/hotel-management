
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsMst客室マスタCQ : AbstractBsMst客室マスタCQ {

        protected Mst客室マスタCIQ _inlineQuery;

        public BsMst客室マスタCQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Mst客室マスタCIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Mst客室マスタCIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Mst客室マスタCIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Mst客室マスタCIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        protected Map<String, Dch客室利用予定台帳CQ> _id_ExistsSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Id_ExistsSubQuery_Dch客室利用予定台帳List { get { return _id_ExistsSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepId_ExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_id_ExistsSubQuery_Dch客室利用予定台帳ListMap == null) { _id_ExistsSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _id_ExistsSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Id_ExistsSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _id_ExistsSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Id_ExistsSubQuery_Dch客室利用実績台帳List { get { return _id_ExistsSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepId_ExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_id_ExistsSubQuery_Dch客室利用実績台帳ListMap == null) { _id_ExistsSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _id_ExistsSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Id_ExistsSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _id_NotExistsSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Id_NotExistsSubQuery_Dch客室利用予定台帳List { get { return _id_NotExistsSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepId_NotExistsSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_id_NotExistsSubQuery_Dch客室利用予定台帳ListMap == null) { _id_NotExistsSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _id_NotExistsSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _id_NotExistsSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Id_NotExistsSubQuery_Dch客室利用実績台帳List { get { return _id_NotExistsSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepId_NotExistsSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_id_NotExistsSubQuery_Dch客室利用実績台帳ListMap == null) { _id_NotExistsSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _id_NotExistsSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _id_InScopeSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Id_InScopeSubQuery_Dch客室利用予定台帳List { get { return _id_InScopeSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepId_InScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_id_InScopeSubQuery_Dch客室利用予定台帳ListMap == null) { _id_InScopeSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _id_InScopeSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Id_InScopeSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _id_InScopeSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Id_InScopeSubQuery_Dch客室利用実績台帳List { get { return _id_InScopeSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepId_InScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_id_InScopeSubQuery_Dch客室利用実績台帳ListMap == null) { _id_InScopeSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _id_InScopeSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Id_InScopeSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _id_NotInScopeSubQuery_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Id_NotInScopeSubQuery_Dch客室利用予定台帳List { get { return _id_NotInScopeSubQuery_Dch客室利用予定台帳ListMap; }}
        public override String keepId_NotInScopeSubQuery_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_id_NotInScopeSubQuery_Dch客室利用予定台帳ListMap == null) { _id_NotInScopeSubQuery_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Dch客室利用予定台帳ListMap.size() + 1);
            _id_NotInScopeSubQuery_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _id_NotInScopeSubQuery_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Id_NotInScopeSubQuery_Dch客室利用実績台帳List { get { return _id_NotInScopeSubQuery_Dch客室利用実績台帳ListMap; }}
        public override String keepId_NotInScopeSubQuery_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_id_NotInScopeSubQuery_Dch客室利用実績台帳ListMap == null) { _id_NotInScopeSubQuery_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Dch客室利用実績台帳ListMap.size() + 1);
            _id_NotInScopeSubQuery_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _id_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Id_SpecifyDerivedReferrer_Dch客室利用予定台帳List { get { return _id_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap == null) { _id_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Dch客室利用予定台帳List." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _id_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Id_SpecifyDerivedReferrer_Dch客室利用実績台帳List { get { return _id_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap == null) { _id_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Dch客室利用実績台帳List." + key;
        }

        protected Map<String, Dch客室利用予定台帳CQ> _id_QueryDerivedReferrer_Dch客室利用予定台帳ListMap;
        public Map<String, Dch客室利用予定台帳CQ> Id_QueryDerivedReferrer_Dch客室利用予定台帳List { get { return _id_QueryDerivedReferrer_Dch客室利用予定台帳ListMap; } }
        public override String keepId_QueryDerivedReferrer_Dch客室利用予定台帳List(Dch客室利用予定台帳CQ subQuery) {
            if (_id_QueryDerivedReferrer_Dch客室利用予定台帳ListMap == null) { _id_QueryDerivedReferrer_Dch客室利用予定台帳ListMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Dch客室利用予定台帳ListMap.size() + 1);
            _id_QueryDerivedReferrer_Dch客室利用予定台帳ListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Dch客室利用予定台帳List." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter { get { return _id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap == null) { _id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Dch客室利用予定台帳ListParameter." + key;
        }

        protected Map<String, Dch客室利用実績台帳CQ> _id_QueryDerivedReferrer_Dch客室利用実績台帳ListMap;
        public Map<String, Dch客室利用実績台帳CQ> Id_QueryDerivedReferrer_Dch客室利用実績台帳List { get { return _id_QueryDerivedReferrer_Dch客室利用実績台帳ListMap; } }
        public override String keepId_QueryDerivedReferrer_Dch客室利用実績台帳List(Dch客室利用実績台帳CQ subQuery) {
            if (_id_QueryDerivedReferrer_Dch客室利用実績台帳ListMap == null) { _id_QueryDerivedReferrer_Dch客室利用実績台帳ListMap = new LinkedHashMap<String, Dch客室利用実績台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Dch客室利用実績台帳ListMap.size() + 1);
            _id_QueryDerivedReferrer_Dch客室利用実績台帳ListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Dch客室利用実績台帳List." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter { get { return _id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap == null) { _id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Dch客室利用実績台帳ListParameter." + key;
        }

        public BsMst客室マスタCQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsMst客室マスタCQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _客室番号;
        public ConditionValue 客室番号 {
            get { if (_客室番号 == null) { _客室番号 = new ConditionValue(); } return _客室番号; }
        }
        protected override ConditionValue getCValue客室番号() { return this.客室番号; }


        public BsMst客室マスタCQ AddOrderBy_客室番号_Asc() { regOBA("客室番号");return this; }
        public BsMst客室マスタCQ AddOrderBy_客室番号_Desc() { regOBD("客室番号");return this; }

        protected ConditionValue _客室タイプid;
        public ConditionValue 客室タイプid {
            get { if (_客室タイプid == null) { _客室タイプid = new ConditionValue(); } return _客室タイプid; }
        }
        protected override ConditionValue getCValue客室タイプid() { return this.客室タイプid; }


        protected Map<String, Mst客室タイプマスタCQ> _客室タイプid_InScopeSubQuery_Mst客室タイプマスタMap;
        public Map<String, Mst客室タイプマスタCQ> 客室タイプid_InScopeSubQuery_Mst客室タイプマスタ { get { return _客室タイプid_InScopeSubQuery_Mst客室タイプマスタMap; }}
        public override String keep客室タイプid_InScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery) {
            if (_客室タイプid_InScopeSubQuery_Mst客室タイプマスタMap == null) { _客室タイプid_InScopeSubQuery_Mst客室タイプマスタMap = new LinkedHashMap<String, Mst客室タイプマスタCQ>(); }
            String key = "subQueryMapKey" + (_客室タイプid_InScopeSubQuery_Mst客室タイプマスタMap.size() + 1);
            _客室タイプid_InScopeSubQuery_Mst客室タイプマスタMap.put(key, subQuery); return "客室タイプid_InScopeSubQuery_Mst客室タイプマスタ." + key;
        }

        protected Map<String, Mst客室タイプマスタCQ> _客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタMap;
        public Map<String, Mst客室タイプマスタCQ> 客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタ { get { return _客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタMap; }}
        public override String keep客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタ(Mst客室タイプマスタCQ subQuery) {
            if (_客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタMap == null) { _客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタMap = new LinkedHashMap<String, Mst客室タイプマスタCQ>(); }
            String key = "subQueryMapKey" + (_客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタMap.size() + 1);
            _客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタMap.put(key, subQuery); return "客室タイプid_NotInScopeSubQuery_Mst客室タイプマスタ." + key;
        }

        public BsMst客室マスタCQ AddOrderBy_客室タイプid_Asc() { regOBA("客室タイプid");return this; }
        public BsMst客室マスタCQ AddOrderBy_客室タイプid_Desc() { regOBD("客室タイプid");return this; }

        protected ConditionValue _喫煙;
        public ConditionValue 喫煙 {
            get { if (_喫煙 == null) { _喫煙 = new ConditionValue(); } return _喫煙; }
        }
        protected override ConditionValue getCValue喫煙() { return this.喫煙; }


        public BsMst客室マスタCQ AddOrderBy_喫煙_Asc() { regOBA("喫煙");return this; }
        public BsMst客室マスタCQ AddOrderBy_喫煙_Desc() { regOBD("喫煙");return this; }

        protected ConditionValue _備考;
        public ConditionValue 備考 {
            get { if (_備考 == null) { _備考 = new ConditionValue(); } return _備考; }
        }
        protected override ConditionValue getCValue備考() { return this.備考; }


        public BsMst客室マスタCQ AddOrderBy_備考_Asc() { regOBA("備考");return this; }
        public BsMst客室マスタCQ AddOrderBy_備考_Desc() { regOBD("備考");return this; }

        public BsMst客室マスタCQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsMst客室マスタCQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Mst客室マスタCQ baseQuery = (Mst客室マスタCQ)baseQueryAsSuper;
            Mst客室マスタCQ unionQuery = (Mst客室マスタCQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMst客室タイプマスタ()) {
                unionQuery.QueryMst客室タイプマスタ().reflectRelationOnUnionQuery(baseQuery.QueryMst客室タイプマスタ(), unionQuery.QueryMst客室タイプマスタ());
            }

        }
    
        protected Mst客室タイプマスタCQ _conditionQueryMst客室タイプマスタ;
        public Mst客室タイプマスタCQ QueryMst客室タイプマスタ() {
            return this.ConditionQueryMst客室タイプマスタ;
        }
        public Mst客室タイプマスタCQ ConditionQueryMst客室タイプマスタ {
            get {
                if (_conditionQueryMst客室タイプマスタ == null) {
                    _conditionQueryMst客室タイプマスタ = xcreateQueryMst客室タイプマスタ();
                    xsetupOuterJoin_Mst客室タイプマスタ();
                }
                return _conditionQueryMst客室タイプマスタ;
            }
        }
        protected Mst客室タイプマスタCQ xcreateQueryMst客室タイプマスタ() {
            String nrp = resolveNextRelationPathMst客室タイプマスタ();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Mst客室タイプマスタCQ cq = new Mst客室タイプマスタCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("mst客室タイプマスタ"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Mst客室タイプマスタ() {
            Mst客室タイプマスタCQ cq = ConditionQueryMst客室タイプマスタ;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("客室タイプid", "id");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMst客室タイプマスタ() {
            return resolveNextRelationPath("mst客室マスタ", "mst客室タイプマスタ");
        }
        public bool hasConditionQueryMst客室タイプマスタ() {
            return _conditionQueryMst客室タイプマスタ != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Mst客室マスタCQ> _scalarSubQueryMap;
	    public Map<String, Mst客室マスタCQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Mst客室マスタCQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Mst客室マスタCQ> _myselfInScopeSubQueryMap;
        public Map<String, Mst客室マスタCQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Mst客室マスタCQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
