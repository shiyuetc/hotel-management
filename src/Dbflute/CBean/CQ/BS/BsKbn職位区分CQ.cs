
using System;

using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.CBean.CValue;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.CBean.CQ;
using Dbflute.CBean.CQ.Ciq;

namespace Dbflute.CBean.CQ.BS {

    [System.Serializable]
    public class BsKbn職位区分CQ : AbstractBsKbn職位区分CQ {

        protected Kbn職位区分CIQ _inlineQuery;

        public BsKbn職位区分CQ(ConditionQuery childQuery, SqlClause sqlClause, String aliasName, int nestLevel)
            : base(childQuery, sqlClause, aliasName, nestLevel) {}

        public Kbn職位区分CIQ Inline() {
            if (_inlineQuery == null) {
                _inlineQuery = new Kbn職位区分CIQ(xgetReferrerQuery(), xgetSqlClause(), xgetAliasName(), xgetNestLevel(), this);
            }
            _inlineQuery.xsetOnClause(false);
            return _inlineQuery;
        }
        
        public Kbn職位区分CIQ On() {
            if (isBaseQuery()) { throw new UnsupportedOperationException("Unsupported onClause of Base Table!"); }
            Kbn職位区分CIQ inlineQuery = Inline();
            inlineQuery.xsetOnClause(true);
            return inlineQuery;
        }


        protected ConditionValue _職位コード;
        public ConditionValue 職位コード {
            get { if (_職位コード == null) { _職位コード = new ConditionValue(); } return _職位コード; }
        }
        protected override ConditionValue getCValue職位コード() { return this.職位コード; }


        protected Map<String, Dch従業員職位履歴台帳CQ> _職位コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 職位コード_ExistsSubQuery_Dch従業員職位履歴台帳List { get { return _職位コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep職位コード_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_職位コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap == null) { _職位コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _職位コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "職位コード_ExistsSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _職位コード_ExistsSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> 職位コード_ExistsSubQuery_Mst従業員マスタList { get { return _職位コード_ExistsSubQuery_Mst従業員マスタListMap; }}
        public override String keep職位コード_ExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_職位コード_ExistsSubQuery_Mst従業員マスタListMap == null) { _職位コード_ExistsSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_ExistsSubQuery_Mst従業員マスタListMap.size() + 1);
            _職位コード_ExistsSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "職位コード_ExistsSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _職位コード_ExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 職位コード_ExistsSubQuery_Mst権限マスタList { get { return _職位コード_ExistsSubQuery_Mst権限マスタListMap; }}
        public override String keep職位コード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_職位コード_ExistsSubQuery_Mst権限マスタListMap == null) { _職位コード_ExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_ExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _職位コード_ExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "職位コード_ExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳List { get { return _職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap == null) { _職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "職位コード_NotExistsSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _職位コード_NotExistsSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> 職位コード_NotExistsSubQuery_Mst従業員マスタList { get { return _職位コード_NotExistsSubQuery_Mst従業員マスタListMap; }}
        public override String keep職位コード_NotExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_職位コード_NotExistsSubQuery_Mst従業員マスタListMap == null) { _職位コード_NotExistsSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotExistsSubQuery_Mst従業員マスタListMap.size() + 1);
            _職位コード_NotExistsSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "職位コード_NotExistsSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _職位コード_NotExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 職位コード_NotExistsSubQuery_Mst権限マスタList { get { return _職位コード_NotExistsSubQuery_Mst権限マスタListMap; }}
        public override String keep職位コード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_職位コード_NotExistsSubQuery_Mst権限マスタListMap == null) { _職位コード_NotExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _職位コード_NotExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "職位コード_NotExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _職位コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 職位コード_InScopeSubQuery_Dch従業員職位履歴台帳List { get { return _職位コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep職位コード_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_職位コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap == null) { _職位コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _職位コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "職位コード_InScopeSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _職位コード_InScopeSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> 職位コード_InScopeSubQuery_Mst従業員マスタList { get { return _職位コード_InScopeSubQuery_Mst従業員マスタListMap; }}
        public override String keep職位コード_InScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_職位コード_InScopeSubQuery_Mst従業員マスタListMap == null) { _職位コード_InScopeSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_InScopeSubQuery_Mst従業員マスタListMap.size() + 1);
            _職位コード_InScopeSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "職位コード_InScopeSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _職位コード_InScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 職位コード_InScopeSubQuery_Mst権限マスタList { get { return _職位コード_InScopeSubQuery_Mst権限マスタListMap; }}
        public override String keep職位コード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_職位コード_InScopeSubQuery_Mst権限マスタListMap == null) { _職位コード_InScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_InScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _職位コード_InScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "職位コード_InScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List { get { return _職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keep職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap == null) { _職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "職位コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _職位コード_NotInScopeSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> 職位コード_NotInScopeSubQuery_Mst従業員マスタList { get { return _職位コード_NotInScopeSubQuery_Mst従業員マスタListMap; }}
        public override String keep職位コード_NotInScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_職位コード_NotInScopeSubQuery_Mst従業員マスタListMap == null) { _職位コード_NotInScopeSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotInScopeSubQuery_Mst従業員マスタListMap.size() + 1);
            _職位コード_NotInScopeSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "職位コード_NotInScopeSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _職位コード_NotInScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 職位コード_NotInScopeSubQuery_Mst権限マスタList { get { return _職位コード_NotInScopeSubQuery_Mst権限マスタListMap; }}
        public override String keep職位コード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_職位コード_NotInScopeSubQuery_Mst権限マスタListMap == null) { _職位コード_NotInScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_NotInScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _職位コード_NotInScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "職位コード_NotInScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List { get { return _職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap; }}
        public override String keep職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap == null) { _職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap.size() + 1);
           _職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "職位コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _職位コード_SpecifyDerivedReferrer_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> 職位コード_SpecifyDerivedReferrer_Mst従業員マスタList { get { return _職位コード_SpecifyDerivedReferrer_Mst従業員マスタListMap; }}
        public override String keep職位コード_SpecifyDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_職位コード_SpecifyDerivedReferrer_Mst従業員マスタListMap == null) { _職位コード_SpecifyDerivedReferrer_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_SpecifyDerivedReferrer_Mst従業員マスタListMap.size() + 1);
           _職位コード_SpecifyDerivedReferrer_Mst従業員マスタListMap.put(key, subQuery); return "職位コード_SpecifyDerivedReferrer_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _職位コード_SpecifyDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 職位コード_SpecifyDerivedReferrer_Mst権限マスタList { get { return _職位コード_SpecifyDerivedReferrer_Mst権限マスタListMap; }}
        public override String keep職位コード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_職位コード_SpecifyDerivedReferrer_Mst権限マスタListMap == null) { _職位コード_SpecifyDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_SpecifyDerivedReferrer_Mst権限マスタListMap.size() + 1);
           _職位コード_SpecifyDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "職位コード_SpecifyDerivedReferrer_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> 職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List { get { return _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap; } }
        public override String keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap == null) { _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap.size() + 1);
            _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List." + key;
        }
        protected Map<String, Object> _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap;
        public Map<String, Object> 職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter { get { return _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap; } }
        public override String keep職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue) {
            if (_職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap == null) { _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap.size() + 1);
            _職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap.put(key, parameterValue); return "職位コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _職位コード_QueryDerivedReferrer_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> 職位コード_QueryDerivedReferrer_Mst従業員マスタList { get { return _職位コード_QueryDerivedReferrer_Mst従業員マスタListMap; } }
        public override String keep職位コード_QueryDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_職位コード_QueryDerivedReferrer_Mst従業員マスタListMap == null) { _職位コード_QueryDerivedReferrer_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_QueryDerivedReferrer_Mst従業員マスタListMap.size() + 1);
            _職位コード_QueryDerivedReferrer_Mst従業員マスタListMap.put(key, subQuery); return "職位コード_QueryDerivedReferrer_Mst従業員マスタList." + key;
        }
        protected Map<String, Object> _職位コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap;
        public Map<String, Object> 職位コード_QueryDerivedReferrer_Mst従業員マスタListParameter { get { return _職位コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap; } }
        public override String keep職位コード_QueryDerivedReferrer_Mst従業員マスタListParameter(Object parameterValue) {
            if (_職位コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap == null) { _職位コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_職位コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap.size() + 1);
            _職位コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap.put(key, parameterValue); return "職位コード_QueryDerivedReferrer_Mst従業員マスタListParameter." + key;
        }

        protected Map<String, Mst権限マスタCQ> _職位コード_QueryDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> 職位コード_QueryDerivedReferrer_Mst権限マスタList { get { return _職位コード_QueryDerivedReferrer_Mst権限マスタListMap; } }
        public override String keep職位コード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_職位コード_QueryDerivedReferrer_Mst権限マスタListMap == null) { _職位コード_QueryDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_職位コード_QueryDerivedReferrer_Mst権限マスタListMap.size() + 1);
            _職位コード_QueryDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "職位コード_QueryDerivedReferrer_Mst権限マスタList." + key;
        }
        protected Map<String, Object> _職位コード_QueryDerivedReferrer_Mst権限マスタListParameterMap;
        public Map<String, Object> 職位コード_QueryDerivedReferrer_Mst権限マスタListParameter { get { return _職位コード_QueryDerivedReferrer_Mst権限マスタListParameterMap; } }
        public override String keep職位コード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            if (_職位コード_QueryDerivedReferrer_Mst権限マスタListParameterMap == null) { _職位コード_QueryDerivedReferrer_Mst権限マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_職位コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.size() + 1);
            _職位コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.put(key, parameterValue); return "職位コード_QueryDerivedReferrer_Mst権限マスタListParameter." + key;
        }

        public BsKbn職位区分CQ AddOrderBy_職位コード_Asc() { regOBA("職位コード");return this; }
        public BsKbn職位区分CQ AddOrderBy_職位コード_Desc() { regOBD("職位コード");return this; }

        protected ConditionValue _職位名称;
        public ConditionValue 職位名称 {
            get { if (_職位名称 == null) { _職位名称 = new ConditionValue(); } return _職位名称; }
        }
        protected override ConditionValue getCValue職位名称() { return this.職位名称; }


        public BsKbn職位区分CQ AddOrderBy_職位名称_Asc() { regOBA("職位名称");return this; }
        public BsKbn職位区分CQ AddOrderBy_職位名称_Desc() { regOBD("職位名称");return this; }

        protected ConditionValue _職位英字名称;
        public ConditionValue 職位英字名称 {
            get { if (_職位英字名称 == null) { _職位英字名称 = new ConditionValue(); } return _職位英字名称; }
        }
        protected override ConditionValue getCValue職位英字名称() { return this.職位英字名称; }


        public BsKbn職位区分CQ AddOrderBy_職位英字名称_Asc() { regOBA("職位英字名称");return this; }
        public BsKbn職位区分CQ AddOrderBy_職位英字名称_Desc() { regOBD("職位英字名称");return this; }

        public BsKbn職位区分CQ AddSpecifiedDerivedOrderBy_Asc(String aliasName) { registerSpecifiedDerivedOrderBy_Asc(aliasName); return this; }
        public BsKbn職位区分CQ AddSpecifiedDerivedOrderBy_Desc(String aliasName) { registerSpecifiedDerivedOrderBy_Desc(aliasName); return this; }

        public override void reflectRelationOnUnionQuery(ConditionQuery baseQueryAsSuper, ConditionQuery unionQueryAsSuper) {

        }
    


	    // ===============================================================================
	    //                                                                 Scalar SubQuery
	    //                                                                 ===============
	    protected Map<String, Kbn職位区分CQ> _scalarSubQueryMap;
	    public Map<String, Kbn職位区分CQ> ScalarSubQuery { get { return _scalarSubQueryMap; } }
	    public override String keepScalarSubQuery(Kbn職位区分CQ subQuery) {
	        if (_scalarSubQueryMap == null) { _scalarSubQueryMap = new LinkedHashMap<String, Kbn職位区分CQ>(); }
	        String key = "subQueryMapKey" + (_scalarSubQueryMap.size() + 1);
	        _scalarSubQueryMap.put(key, subQuery); return "ScalarSubQuery." + key;
	    }

        // ===============================================================================
        //                                                         Myself InScope SubQuery
        //                                                         =======================
        protected Map<String, Kbn職位区分CQ> _myselfInScopeSubQueryMap;
        public Map<String, Kbn職位区分CQ> MyselfInScopeSubQuery { get { return _myselfInScopeSubQueryMap; } }
        public override String keepMyselfInScopeSubQuery(Kbn職位区分CQ subQuery) {
            if (_myselfInScopeSubQueryMap == null) { _myselfInScopeSubQueryMap = new LinkedHashMap<String, Kbn職位区分CQ>(); }
            String key = "subQueryMapKey" + (_myselfInScopeSubQueryMap.size() + 1);
            _myselfInScopeSubQueryMap.put(key, subQuery); return "MyselfInScopeSubQuery." + key;
        }
    }
}
