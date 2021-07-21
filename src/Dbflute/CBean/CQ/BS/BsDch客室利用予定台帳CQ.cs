
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsDch客室利用予定台帳CQ : AbstractBsDch客室利用予定台帳CQ {

        protected Dch客室利用予定台帳CIQ _inlineQuery;

        public BsDch客室利用予定台帳CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Dch客室利用予定台帳CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Dch客室利用予定台帳CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Dch客室利用予定台帳CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Dch客室利用予定台帳CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _id;
        public ConditionValue Id {
            get { if (_id == null) { _id = new ConditionValue(); } return _id; }
        }
        protected override ConditionValue getCValueId() { return this.Id; }


        protected Map<String, Dchその他予定台帳CQ> _id_ExistsSubQuery_Dchその他予定台帳ListMap;
        public Map<String, Dchその他予定台帳CQ> Id_ExistsSubQuery_Dchその他予定台帳List { get { return _id_ExistsSubQuery_Dchその他予定台帳ListMap; }}
        public override String keepId_ExistsSubQuery_Dchその他予定台帳List(Dchその他予定台帳CQ subQuery) {
            if (_id_ExistsSubQuery_Dchその他予定台帳ListMap == null) { _id_ExistsSubQuery_Dchその他予定台帳ListMap = new LinkedHashMap<String, Dchその他予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Dchその他予定台帳ListMap.size() + 1);
            _id_ExistsSubQuery_Dchその他予定台帳ListMap.put(key, subQuery); return "Id_ExistsSubQuery_Dchその他予定台帳List." + key;
        }

        protected Map<String, Dch宿泊予定台帳CQ> _id_ExistsSubQuery_Dch宿泊予定台帳ListMap;
        public Map<String, Dch宿泊予定台帳CQ> Id_ExistsSubQuery_Dch宿泊予定台帳List { get { return _id_ExistsSubQuery_Dch宿泊予定台帳ListMap; }}
        public override String keepId_ExistsSubQuery_Dch宿泊予定台帳List(Dch宿泊予定台帳CQ subQuery) {
            if (_id_ExistsSubQuery_Dch宿泊予定台帳ListMap == null) { _id_ExistsSubQuery_Dch宿泊予定台帳ListMap = new LinkedHashMap<String, Dch宿泊予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Dch宿泊予定台帳ListMap.size() + 1);
            _id_ExistsSubQuery_Dch宿泊予定台帳ListMap.put(key, subQuery); return "Id_ExistsSubQuery_Dch宿泊予定台帳List." + key;
        }

        protected Map<String, Dch清掃予定台帳CQ> _id_ExistsSubQuery_Dch清掃予定台帳ListMap;
        public Map<String, Dch清掃予定台帳CQ> Id_ExistsSubQuery_Dch清掃予定台帳List { get { return _id_ExistsSubQuery_Dch清掃予定台帳ListMap; }}
        public override String keepId_ExistsSubQuery_Dch清掃予定台帳List(Dch清掃予定台帳CQ subQuery) {
            if (_id_ExistsSubQuery_Dch清掃予定台帳ListMap == null) { _id_ExistsSubQuery_Dch清掃予定台帳ListMap = new LinkedHashMap<String, Dch清掃予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_ExistsSubQuery_Dch清掃予定台帳ListMap.size() + 1);
            _id_ExistsSubQuery_Dch清掃予定台帳ListMap.put(key, subQuery); return "Id_ExistsSubQuery_Dch清掃予定台帳List." + key;
        }

        protected Map<String, Dchその他予定台帳CQ> _id_NotExistsSubQuery_Dchその他予定台帳ListMap;
        public Map<String, Dchその他予定台帳CQ> Id_NotExistsSubQuery_Dchその他予定台帳List { get { return _id_NotExistsSubQuery_Dchその他予定台帳ListMap; }}
        public override String keepId_NotExistsSubQuery_Dchその他予定台帳List(Dchその他予定台帳CQ subQuery) {
            if (_id_NotExistsSubQuery_Dchその他予定台帳ListMap == null) { _id_NotExistsSubQuery_Dchその他予定台帳ListMap = new LinkedHashMap<String, Dchその他予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Dchその他予定台帳ListMap.size() + 1);
            _id_NotExistsSubQuery_Dchその他予定台帳ListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Dchその他予定台帳List." + key;
        }

        protected Map<String, Dch宿泊予定台帳CQ> _id_NotExistsSubQuery_Dch宿泊予定台帳ListMap;
        public Map<String, Dch宿泊予定台帳CQ> Id_NotExistsSubQuery_Dch宿泊予定台帳List { get { return _id_NotExistsSubQuery_Dch宿泊予定台帳ListMap; }}
        public override String keepId_NotExistsSubQuery_Dch宿泊予定台帳List(Dch宿泊予定台帳CQ subQuery) {
            if (_id_NotExistsSubQuery_Dch宿泊予定台帳ListMap == null) { _id_NotExistsSubQuery_Dch宿泊予定台帳ListMap = new LinkedHashMap<String, Dch宿泊予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Dch宿泊予定台帳ListMap.size() + 1);
            _id_NotExistsSubQuery_Dch宿泊予定台帳ListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Dch宿泊予定台帳List." + key;
        }

        protected Map<String, Dch清掃予定台帳CQ> _id_NotExistsSubQuery_Dch清掃予定台帳ListMap;
        public Map<String, Dch清掃予定台帳CQ> Id_NotExistsSubQuery_Dch清掃予定台帳List { get { return _id_NotExistsSubQuery_Dch清掃予定台帳ListMap; }}
        public override String keepId_NotExistsSubQuery_Dch清掃予定台帳List(Dch清掃予定台帳CQ subQuery) {
            if (_id_NotExistsSubQuery_Dch清掃予定台帳ListMap == null) { _id_NotExistsSubQuery_Dch清掃予定台帳ListMap = new LinkedHashMap<String, Dch清掃予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotExistsSubQuery_Dch清掃予定台帳ListMap.size() + 1);
            _id_NotExistsSubQuery_Dch清掃予定台帳ListMap.put(key, subQuery); return "Id_NotExistsSubQuery_Dch清掃予定台帳List." + key;
        }

        protected Map<String, Dchその他予定台帳CQ> _id_InScopeSubQuery_Dchその他予定台帳ListMap;
        public Map<String, Dchその他予定台帳CQ> Id_InScopeSubQuery_Dchその他予定台帳List { get { return _id_InScopeSubQuery_Dchその他予定台帳ListMap; }}
        public override String keepId_InScopeSubQuery_Dchその他予定台帳List(Dchその他予定台帳CQ subQuery) {
            if (_id_InScopeSubQuery_Dchその他予定台帳ListMap == null) { _id_InScopeSubQuery_Dchその他予定台帳ListMap = new LinkedHashMap<String, Dchその他予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Dchその他予定台帳ListMap.size() + 1);
            _id_InScopeSubQuery_Dchその他予定台帳ListMap.put(key, subQuery); return "Id_InScopeSubQuery_Dchその他予定台帳List." + key;
        }

        protected Map<String, Dch宿泊予定台帳CQ> _id_InScopeSubQuery_Dch宿泊予定台帳ListMap;
        public Map<String, Dch宿泊予定台帳CQ> Id_InScopeSubQuery_Dch宿泊予定台帳List { get { return _id_InScopeSubQuery_Dch宿泊予定台帳ListMap; }}
        public override String keepId_InScopeSubQuery_Dch宿泊予定台帳List(Dch宿泊予定台帳CQ subQuery) {
            if (_id_InScopeSubQuery_Dch宿泊予定台帳ListMap == null) { _id_InScopeSubQuery_Dch宿泊予定台帳ListMap = new LinkedHashMap<String, Dch宿泊予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Dch宿泊予定台帳ListMap.size() + 1);
            _id_InScopeSubQuery_Dch宿泊予定台帳ListMap.put(key, subQuery); return "Id_InScopeSubQuery_Dch宿泊予定台帳List." + key;
        }

        protected Map<String, Dch清掃予定台帳CQ> _id_InScopeSubQuery_Dch清掃予定台帳ListMap;
        public Map<String, Dch清掃予定台帳CQ> Id_InScopeSubQuery_Dch清掃予定台帳List { get { return _id_InScopeSubQuery_Dch清掃予定台帳ListMap; }}
        public override String keepId_InScopeSubQuery_Dch清掃予定台帳List(Dch清掃予定台帳CQ subQuery) {
            if (_id_InScopeSubQuery_Dch清掃予定台帳ListMap == null) { _id_InScopeSubQuery_Dch清掃予定台帳ListMap = new LinkedHashMap<String, Dch清掃予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_InScopeSubQuery_Dch清掃予定台帳ListMap.size() + 1);
            _id_InScopeSubQuery_Dch清掃予定台帳ListMap.put(key, subQuery); return "Id_InScopeSubQuery_Dch清掃予定台帳List." + key;
        }

        protected Map<String, Dchその他予定台帳CQ> _id_NotInScopeSubQuery_Dchその他予定台帳ListMap;
        public Map<String, Dchその他予定台帳CQ> Id_NotInScopeSubQuery_Dchその他予定台帳List { get { return _id_NotInScopeSubQuery_Dchその他予定台帳ListMap; }}
        public override String keepId_NotInScopeSubQuery_Dchその他予定台帳List(Dchその他予定台帳CQ subQuery) {
            if (_id_NotInScopeSubQuery_Dchその他予定台帳ListMap == null) { _id_NotInScopeSubQuery_Dchその他予定台帳ListMap = new LinkedHashMap<String, Dchその他予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Dchその他予定台帳ListMap.size() + 1);
            _id_NotInScopeSubQuery_Dchその他予定台帳ListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Dchその他予定台帳List." + key;
        }

        protected Map<String, Dch宿泊予定台帳CQ> _id_NotInScopeSubQuery_Dch宿泊予定台帳ListMap;
        public Map<String, Dch宿泊予定台帳CQ> Id_NotInScopeSubQuery_Dch宿泊予定台帳List { get { return _id_NotInScopeSubQuery_Dch宿泊予定台帳ListMap; }}
        public override String keepId_NotInScopeSubQuery_Dch宿泊予定台帳List(Dch宿泊予定台帳CQ subQuery) {
            if (_id_NotInScopeSubQuery_Dch宿泊予定台帳ListMap == null) { _id_NotInScopeSubQuery_Dch宿泊予定台帳ListMap = new LinkedHashMap<String, Dch宿泊予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Dch宿泊予定台帳ListMap.size() + 1);
            _id_NotInScopeSubQuery_Dch宿泊予定台帳ListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Dch宿泊予定台帳List." + key;
        }

        protected Map<String, Dch清掃予定台帳CQ> _id_NotInScopeSubQuery_Dch清掃予定台帳ListMap;
        public Map<String, Dch清掃予定台帳CQ> Id_NotInScopeSubQuery_Dch清掃予定台帳List { get { return _id_NotInScopeSubQuery_Dch清掃予定台帳ListMap; }}
        public override String keepId_NotInScopeSubQuery_Dch清掃予定台帳List(Dch清掃予定台帳CQ subQuery) {
            if (_id_NotInScopeSubQuery_Dch清掃予定台帳ListMap == null) { _id_NotInScopeSubQuery_Dch清掃予定台帳ListMap = new LinkedHashMap<String, Dch清掃予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_NotInScopeSubQuery_Dch清掃予定台帳ListMap.size() + 1);
            _id_NotInScopeSubQuery_Dch清掃予定台帳ListMap.put(key, subQuery); return "Id_NotInScopeSubQuery_Dch清掃予定台帳List." + key;
        }

        protected Map<String, Dchその他予定台帳CQ> _id_SpecifyDerivedReferrer_Dchその他予定台帳ListMap;
        public Map<String, Dchその他予定台帳CQ> Id_SpecifyDerivedReferrer_Dchその他予定台帳List { get { return _id_SpecifyDerivedReferrer_Dchその他予定台帳ListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Dchその他予定台帳List(Dchその他予定台帳CQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Dchその他予定台帳ListMap == null) { _id_SpecifyDerivedReferrer_Dchその他予定台帳ListMap = new LinkedHashMap<String, Dchその他予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Dchその他予定台帳ListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Dchその他予定台帳ListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Dchその他予定台帳List." + key;
        }

        protected Map<String, Dch宿泊予定台帳CQ> _id_SpecifyDerivedReferrer_Dch宿泊予定台帳ListMap;
        public Map<String, Dch宿泊予定台帳CQ> Id_SpecifyDerivedReferrer_Dch宿泊予定台帳List { get { return _id_SpecifyDerivedReferrer_Dch宿泊予定台帳ListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Dch宿泊予定台帳List(Dch宿泊予定台帳CQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Dch宿泊予定台帳ListMap == null) { _id_SpecifyDerivedReferrer_Dch宿泊予定台帳ListMap = new LinkedHashMap<String, Dch宿泊予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Dch宿泊予定台帳ListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Dch宿泊予定台帳ListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Dch宿泊予定台帳List." + key;
        }

        protected Map<String, Dch清掃予定台帳CQ> _id_SpecifyDerivedReferrer_Dch清掃予定台帳ListMap;
        public Map<String, Dch清掃予定台帳CQ> Id_SpecifyDerivedReferrer_Dch清掃予定台帳List { get { return _id_SpecifyDerivedReferrer_Dch清掃予定台帳ListMap; }}
        public override String keepId_SpecifyDerivedReferrer_Dch清掃予定台帳List(Dch清掃予定台帳CQ subQuery) {
            if (_id_SpecifyDerivedReferrer_Dch清掃予定台帳ListMap == null) { _id_SpecifyDerivedReferrer_Dch清掃予定台帳ListMap = new LinkedHashMap<String, Dch清掃予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_SpecifyDerivedReferrer_Dch清掃予定台帳ListMap.size() + 1);
            _id_SpecifyDerivedReferrer_Dch清掃予定台帳ListMap.put(key, subQuery); return "Id_SpecifyDerivedReferrer_Dch清掃予定台帳List." + key;
        }

        protected Map<String, Dchその他予定台帳CQ> _id_QueryDerivedReferrer_Dchその他予定台帳ListMap;
        public Map<String, Dchその他予定台帳CQ> Id_QueryDerivedReferrer_Dchその他予定台帳List { get { return _id_QueryDerivedReferrer_Dchその他予定台帳ListMap; } }
        public override String keepId_QueryDerivedReferrer_Dchその他予定台帳List(Dchその他予定台帳CQ subQuery) {
            if (_id_QueryDerivedReferrer_Dchその他予定台帳ListMap == null) { _id_QueryDerivedReferrer_Dchその他予定台帳ListMap = new LinkedHashMap<String, Dchその他予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Dchその他予定台帳ListMap.size() + 1);
            _id_QueryDerivedReferrer_Dchその他予定台帳ListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Dchその他予定台帳List." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Dchその他予定台帳ListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Dchその他予定台帳ListParameter { get { return _id_QueryDerivedReferrer_Dchその他予定台帳ListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Dchその他予定台帳ListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Dchその他予定台帳ListParameterMap == null) { _id_QueryDerivedReferrer_Dchその他予定台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Dchその他予定台帳ListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Dchその他予定台帳ListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Dchその他予定台帳ListParameter." + key;
        }

        protected Map<String, Dch宿泊予定台帳CQ> _id_QueryDerivedReferrer_Dch宿泊予定台帳ListMap;
        public Map<String, Dch宿泊予定台帳CQ> Id_QueryDerivedReferrer_Dch宿泊予定台帳List { get { return _id_QueryDerivedReferrer_Dch宿泊予定台帳ListMap; } }
        public override String keepId_QueryDerivedReferrer_Dch宿泊予定台帳List(Dch宿泊予定台帳CQ subQuery) {
            if (_id_QueryDerivedReferrer_Dch宿泊予定台帳ListMap == null) { _id_QueryDerivedReferrer_Dch宿泊予定台帳ListMap = new LinkedHashMap<String, Dch宿泊予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Dch宿泊予定台帳ListMap.size() + 1);
            _id_QueryDerivedReferrer_Dch宿泊予定台帳ListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Dch宿泊予定台帳List." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameter { get { return _id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Dch宿泊予定台帳ListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameterMap == null) { _id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Dch宿泊予定台帳ListParameter." + key;
        }

        protected Map<String, Dch清掃予定台帳CQ> _id_QueryDerivedReferrer_Dch清掃予定台帳ListMap;
        public Map<String, Dch清掃予定台帳CQ> Id_QueryDerivedReferrer_Dch清掃予定台帳List { get { return _id_QueryDerivedReferrer_Dch清掃予定台帳ListMap; } }
        public override String keepId_QueryDerivedReferrer_Dch清掃予定台帳List(Dch清掃予定台帳CQ subQuery) {
            if (_id_QueryDerivedReferrer_Dch清掃予定台帳ListMap == null) { _id_QueryDerivedReferrer_Dch清掃予定台帳ListMap = new LinkedHashMap<String, Dch清掃予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_id_QueryDerivedReferrer_Dch清掃予定台帳ListMap.size() + 1);
            _id_QueryDerivedReferrer_Dch清掃予定台帳ListMap.put(key, subQuery); return "Id_QueryDerivedReferrer_Dch清掃予定台帳List." + key;
        }
        protected Map<String, Object> _id_QueryDerivedReferrer_Dch清掃予定台帳ListParameterMap;
        public Map<String, Object> Id_QueryDerivedReferrer_Dch清掃予定台帳ListParameter { get { return _id_QueryDerivedReferrer_Dch清掃予定台帳ListParameterMap; } }
        public override String keepId_QueryDerivedReferrer_Dch清掃予定台帳ListParameter(Object parameterValue) {
            if (_id_QueryDerivedReferrer_Dch清掃予定台帳ListParameterMap == null) { _id_QueryDerivedReferrer_Dch清掃予定台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_id_QueryDerivedReferrer_Dch清掃予定台帳ListParameterMap.size() + 1);
            _id_QueryDerivedReferrer_Dch清掃予定台帳ListParameterMap.put(key, parameterValue); return "Id_QueryDerivedReferrer_Dch清掃予定台帳ListParameter." + key;
        }

        public BsDch客室利用予定台帳CQ AddOrderBy_Id_Asc() { regOBA("id");return this; }
        public BsDch客室利用予定台帳CQ AddOrderBy_Id_Desc() { regOBD("id");return this; }

        protected ConditionValue _客室マスタid;
        public ConditionValue 客室マスタid {
            get { if (_客室マスタid == null) { _客室マスタid = new ConditionValue(); } return _客室マスタid; }
        }
        protected override ConditionValue getCValue客室マスタid() { return this.客室マスタid; }


        protected Map<String, Mst客室マスタCQ> _客室マスタid_InScopeSubQuery_Mst客室マスタMap;
        public Map<String, Mst客室マスタCQ> 客室マスタid_InScopeSubQuery_Mst客室マスタ { get { return _客室マスタid_InScopeSubQuery_Mst客室マスタMap; }}
        public override String keep客室マスタid_InScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery) {
            if (_客室マスタid_InScopeSubQuery_Mst客室マスタMap == null) { _客室マスタid_InScopeSubQuery_Mst客室マスタMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_客室マスタid_InScopeSubQuery_Mst客室マスタMap.size() + 1);
            _客室マスタid_InScopeSubQuery_Mst客室マスタMap.put(key, subQuery); return "客室マスタid_InScopeSubQuery_Mst客室マスタ." + key;
        }

        protected Map<String, Mst客室マスタCQ> _客室マスタid_NotInScopeSubQuery_Mst客室マスタMap;
        public Map<String, Mst客室マスタCQ> 客室マスタid_NotInScopeSubQuery_Mst客室マスタ { get { return _客室マスタid_NotInScopeSubQuery_Mst客室マスタMap; }}
        public override String keep客室マスタid_NotInScopeSubQuery_Mst客室マスタ(Mst客室マスタCQ subQuery) {
            if (_客室マスタid_NotInScopeSubQuery_Mst客室マスタMap == null) { _客室マスタid_NotInScopeSubQuery_Mst客室マスタMap = new LinkedHashMap<String, Mst客室マスタCQ>(); }
            String key = "subQueryMapKey" + (_客室マスタid_NotInScopeSubQuery_Mst客室マスタMap.size() + 1);
            _客室マスタid_NotInScopeSubQuery_Mst客室マスタMap.put(key, subQuery); return "客室マスタid_NotInScopeSubQuery_Mst客室マスタ." + key;
        }

        public BsDch客室利用予定台帳CQ AddOrderBy_客室マスタid_Asc() { regOBA("客室マスタid");return this; }
        public BsDch客室利用予定台帳CQ AddOrderBy_客室マスタid_Desc() { regOBD("客室マスタid");return this; }

        protected ConditionValue _客室利用code;
        public ConditionValue 客室利用code {
            get { if (_客室利用code == null) { _客室利用code = new ConditionValue(); } return _客室利用code; }
        }
        protected override ConditionValue getCValue客室利用code() { return this.客室利用code; }


        protected Map<String, Kbn客室利用区分CQ> _客室利用code_InScopeSubQuery_Kbn客室利用区分Map;
        public Map<String, Kbn客室利用区分CQ> 客室利用code_InScopeSubQuery_Kbn客室利用区分 { get { return _客室利用code_InScopeSubQuery_Kbn客室利用区分Map; }}
        public override String keep客室利用code_InScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery) {
            if (_客室利用code_InScopeSubQuery_Kbn客室利用区分Map == null) { _客室利用code_InScopeSubQuery_Kbn客室利用区分Map = new LinkedHashMap<String, Kbn客室利用区分CQ>(); }
            String key = "subQueryMapKey" + (_客室利用code_InScopeSubQuery_Kbn客室利用区分Map.size() + 1);
            _客室利用code_InScopeSubQuery_Kbn客室利用区分Map.put(key, subQuery); return "客室利用code_InScopeSubQuery_Kbn客室利用区分." + key;
        }

        protected Map<String, Kbn客室利用区分CQ> _客室利用code_NotInScopeSubQuery_Kbn客室利用区分Map;
        public Map<String, Kbn客室利用区分CQ> 客室利用code_NotInScopeSubQuery_Kbn客室利用区分 { get { return _客室利用code_NotInScopeSubQuery_Kbn客室利用区分Map; }}
        public override String keep客室利用code_NotInScopeSubQuery_Kbn客室利用区分(Kbn客室利用区分CQ subQuery) {
            if (_客室利用code_NotInScopeSubQuery_Kbn客室利用区分Map == null) { _客室利用code_NotInScopeSubQuery_Kbn客室利用区分Map = new LinkedHashMap<String, Kbn客室利用区分CQ>(); }
            String key = "subQueryMapKey" + (_客室利用code_NotInScopeSubQuery_Kbn客室利用区分Map.size() + 1);
            _客室利用code_NotInScopeSubQuery_Kbn客室利用区分Map.put(key, subQuery); return "客室利用code_NotInScopeSubQuery_Kbn客室利用区分." + key;
        }

        public BsDch客室利用予定台帳CQ AddOrderBy_客室利用code_Asc() { regOBA("客室利用code");return this; }
        public BsDch客室利用予定台帳CQ AddOrderBy_客室利用code_Desc() { regOBD("客室利用code");return this; }

        protected ConditionValue _利用開始日時;
        public ConditionValue 利用開始日時 {
            get { if (_利用開始日時 == null) { _利用開始日時 = new ConditionValue(); } return _利用開始日時; }
        }
        protected override ConditionValue getCValue利用開始日時() { return this.利用開始日時; }


        public BsDch客室利用予定台帳CQ AddOrderBy_利用開始日時_Asc() { regOBA("利用開始日時");return this; }
        public BsDch客室利用予定台帳CQ AddOrderBy_利用開始日時_Desc() { regOBD("利用開始日時");return this; }

        protected ConditionValue _利用終了日時;
        public ConditionValue 利用終了日時 {
            get { if (_利用終了日時 == null) { _利用終了日時 = new ConditionValue(); } return _利用終了日時; }
        }
        protected override ConditionValue getCValue利用終了日時() { return this.利用終了日時; }


        public BsDch客室利用予定台帳CQ AddOrderBy_利用終了日時_Asc() { regOBA("利用終了日時");return this; }
        public BsDch客室利用予定台帳CQ AddOrderBy_利用終了日時_Desc() { regOBD("利用終了日時");return this; }

        public BsDch客室利用予定台帳CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsDch客室利用予定台帳CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {
            Dch客室利用予定台帳CQ baseQuery = (Dch客室利用予定台帳CQ)baseQueryAsSuper;
            Dch客室利用予定台帳CQ unionQuery = (Dch客室利用予定台帳CQ)unionQueryAsSuper;
            if (baseQuery.hasConditionQueryMst客室マスタ()) {
                unionQuery.QueryMst客室マスタ().reflectRelationOnUnionQuery(baseQuery.QueryMst客室マスタ(), unionQuery.QueryMst客室マスタ());
            }
            if (baseQuery.hasConditionQueryKbn客室利用区分()) {
                unionQuery.QueryKbn客室利用区分().reflectRelationOnUnionQuery(baseQuery.QueryKbn客室利用区分(), unionQuery.QueryKbn客室利用区分());
            }

        }
    
        protected Mst客室マスタCQ _conditionQueryMst客室マスタ;
        public Mst客室マスタCQ QueryMst客室マスタ() {
            return this.ConditionQueryMst客室マスタ;
        }
        public Mst客室マスタCQ ConditionQueryMst客室マスタ {
            get {
                if (_conditionQueryMst客室マスタ == null) {
                    _conditionQueryMst客室マスタ = xcreateQueryMst客室マスタ();
                    xsetupOuterJoin_Mst客室マスタ();
                }
                return _conditionQueryMst客室マスタ;
            }
        }
        protected Mst客室マスタCQ xcreateQueryMst客室マスタ() {
            String nrp = resolveNextRelationPathMst客室マスタ();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Mst客室マスタCQ cq = new Mst客室マスタCQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("mst客室マスタ"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Mst客室マスタ() {
            Mst客室マスタCQ cq = ConditionQueryMst客室マスタ;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("客室マスタid", "id");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathMst客室マスタ() {
            return resolveNextRelationPath("dch客室利用予定台帳", "mst客室マスタ");
        }
        public bool hasConditionQueryMst客室マスタ() {
            return _conditionQueryMst客室マスタ != null;
        }
        protected Kbn客室利用区分CQ _conditionQueryKbn客室利用区分;
        public Kbn客室利用区分CQ QueryKbn客室利用区分() {
            return this.ConditionQueryKbn客室利用区分;
        }
        public Kbn客室利用区分CQ ConditionQueryKbn客室利用区分 {
            get {
                if (_conditionQueryKbn客室利用区分 == null) {
                    _conditionQueryKbn客室利用区分 = xcreateQueryKbn客室利用区分();
                    xsetupOuterJoin_Kbn客室利用区分();
                }
                return _conditionQueryKbn客室利用区分;
            }
        }
        protected Kbn客室利用区分CQ xcreateQueryKbn客室利用区分() {
            String nrp = resolveNextRelationPathKbn客室利用区分();
            String jan = resolveJoinAliasName(nrp, xgetNextNestLevel());
            Kbn客室利用区分CQ cq = new Kbn客室利用区分CQ(this, xgetSqlClause(), jan, xgetNextNestLevel());
            cq.xsetForeignPropertyName("kbn客室利用区分"); cq.xsetRelationPath(nrp); return cq;
        }
        public void xsetupOuterJoin_Kbn客室利用区分() {
            Kbn客室利用区分CQ cq = ConditionQueryKbn客室利用区分;
            Map<String, String> joinOnMap = new LinkedHashMap<String, String>();
            joinOnMap.put("客室利用code", "code");
            registerOuterJoin(cq, joinOnMap);
        }
        protected String resolveNextRelationPathKbn客室利用区分() {
            return resolveNextRelationPath("dch客室利用予定台帳", "kbn客室利用区分");
        }
        public bool hasConditionQueryKbn客室利用区分() {
            return _conditionQueryKbn客室利用区分 != null;
        }


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Dch客室利用予定台帳CQ> _scalarSubQueryMap;
	    public Map<String, Dch客室利用予定台帳CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Dch客室利用予定台帳CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Dch客室利用予定台帳CQ> _myselfInScopeSubQueryMap;
        public Map<String, Dch客室利用予定台帳CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Dch客室利用予定台帳CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Dch客室利用予定台帳CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
