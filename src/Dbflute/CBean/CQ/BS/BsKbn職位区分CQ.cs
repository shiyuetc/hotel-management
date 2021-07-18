
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


        protected ConditionValue _コード;
        public ConditionValue コード {
            get { if (_コード == null) { _コード = new ConditionValue(); } return _コード; }
        }
        protected override ConditionValue getCValueコード() { return this.コード; }


        protected Map<String, Dch従業員職位履歴台帳CQ> _コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> コード_ExistsSubQuery_Dch従業員職位履歴台帳List { get { return _コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keepコード_ExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap == null) { _コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _コード_ExistsSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "コード_ExistsSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _コード_ExistsSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> コード_ExistsSubQuery_Mst従業員マスタList { get { return _コード_ExistsSubQuery_Mst従業員マスタListMap; }}
        public override String keepコード_ExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_コード_ExistsSubQuery_Mst従業員マスタListMap == null) { _コード_ExistsSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_ExistsSubQuery_Mst従業員マスタListMap.size() + 1);
            _コード_ExistsSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "コード_ExistsSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_ExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_ExistsSubQuery_Mst権限マスタList { get { return _コード_ExistsSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_ExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_ExistsSubQuery_Mst権限マスタListMap == null) { _コード_ExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_ExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_ExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_ExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> コード_NotExistsSubQuery_Dch従業員職位履歴台帳List { get { return _コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keepコード_NotExistsSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap == null) { _コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _コード_NotExistsSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "コード_NotExistsSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _コード_NotExistsSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> コード_NotExistsSubQuery_Mst従業員マスタList { get { return _コード_NotExistsSubQuery_Mst従業員マスタListMap; }}
        public override String keepコード_NotExistsSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_コード_NotExistsSubQuery_Mst従業員マスタListMap == null) { _コード_NotExistsSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_NotExistsSubQuery_Mst従業員マスタListMap.size() + 1);
            _コード_NotExistsSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "コード_NotExistsSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_NotExistsSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_NotExistsSubQuery_Mst権限マスタList { get { return _コード_NotExistsSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_NotExistsSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_NotExistsSubQuery_Mst権限マスタListMap == null) { _コード_NotExistsSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_NotExistsSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_NotExistsSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_NotExistsSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> コード_InScopeSubQuery_Dch従業員職位履歴台帳List { get { return _コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keepコード_InScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap == null) { _コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _コード_InScopeSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "コード_InScopeSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _コード_InScopeSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> コード_InScopeSubQuery_Mst従業員マスタList { get { return _コード_InScopeSubQuery_Mst従業員マスタListMap; }}
        public override String keepコード_InScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_コード_InScopeSubQuery_Mst従業員マスタListMap == null) { _コード_InScopeSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_InScopeSubQuery_Mst従業員マスタListMap.size() + 1);
            _コード_InScopeSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "コード_InScopeSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_InScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_InScopeSubQuery_Mst権限マスタList { get { return _コード_InScopeSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_InScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_InScopeSubQuery_Mst権限マスタListMap == null) { _コード_InScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_InScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_InScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_InScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List { get { return _コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap; }}
        public override String keepコード_NotInScopeSubQuery_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap == null) { _コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap.size() + 1);
            _コード_NotInScopeSubQuery_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "コード_NotInScopeSubQuery_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _コード_NotInScopeSubQuery_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> コード_NotInScopeSubQuery_Mst従業員マスタList { get { return _コード_NotInScopeSubQuery_Mst従業員マスタListMap; }}
        public override String keepコード_NotInScopeSubQuery_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_コード_NotInScopeSubQuery_Mst従業員マスタListMap == null) { _コード_NotInScopeSubQuery_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_NotInScopeSubQuery_Mst従業員マスタListMap.size() + 1);
            _コード_NotInScopeSubQuery_Mst従業員マスタListMap.put(key, subQuery); return "コード_NotInScopeSubQuery_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_NotInScopeSubQuery_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_NotInScopeSubQuery_Mst権限マスタList { get { return _コード_NotInScopeSubQuery_Mst権限マスタListMap; }}
        public override String keepコード_NotInScopeSubQuery_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_NotInScopeSubQuery_Mst権限マスタListMap == null) { _コード_NotInScopeSubQuery_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_NotInScopeSubQuery_Mst権限マスタListMap.size() + 1);
            _コード_NotInScopeSubQuery_Mst権限マスタListMap.put(key, subQuery); return "コード_NotInScopeSubQuery_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List { get { return _コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap; }}
        public override String keepコード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap == null) { _コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap.size() + 1);
           _コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "コード_SpecifyDerivedReferrer_Dch従業員職位履歴台帳List." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _コード_SpecifyDerivedReferrer_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> コード_SpecifyDerivedReferrer_Mst従業員マスタList { get { return _コード_SpecifyDerivedReferrer_Mst従業員マスタListMap; }}
        public override String keepコード_SpecifyDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_コード_SpecifyDerivedReferrer_Mst従業員マスタListMap == null) { _コード_SpecifyDerivedReferrer_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_SpecifyDerivedReferrer_Mst従業員マスタListMap.size() + 1);
           _コード_SpecifyDerivedReferrer_Mst従業員マスタListMap.put(key, subQuery); return "コード_SpecifyDerivedReferrer_Mst従業員マスタList." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_SpecifyDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_SpecifyDerivedReferrer_Mst権限マスタList { get { return _コード_SpecifyDerivedReferrer_Mst権限マスタListMap; }}
        public override String keepコード_SpecifyDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_SpecifyDerivedReferrer_Mst権限マスタListMap == null) { _コード_SpecifyDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_SpecifyDerivedReferrer_Mst権限マスタListMap.size() + 1);
           _コード_SpecifyDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "コード_SpecifyDerivedReferrer_Mst権限マスタList." + key;
        }

        protected Map<String, Dch従業員職位履歴台帳CQ> _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap;
        public Map<String, Dch従業員職位履歴台帳CQ> コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List { get { return _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap; } }
        public override String keepコード_QueryDerivedReferrer_Dch従業員職位履歴台帳List(Dch従業員職位履歴台帳CQ subQuery) {
            if (_コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap == null) { _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap = new LinkedHashMap<String, Dch従業員職位履歴台帳CQ>(); }
            String key = "subQueryMapKey" + (_コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap.size() + 1);
            _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListMap.put(key, subQuery); return "コード_QueryDerivedReferrer_Dch従業員職位履歴台帳List." + key;
        }
        protected Map<String, Object> _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap;
        public Map<String, Object> コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter { get { return _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap; } }
        public override String keepコード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter(Object parameterValue) {
            if (_コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap == null) { _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap.size() + 1);
            _コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameterMap.put(key, parameterValue); return "コード_QueryDerivedReferrer_Dch従業員職位履歴台帳ListParameter." + key;
        }

        protected Map<String, Mst従業員マスタCQ> _コード_QueryDerivedReferrer_Mst従業員マスタListMap;
        public Map<String, Mst従業員マスタCQ> コード_QueryDerivedReferrer_Mst従業員マスタList { get { return _コード_QueryDerivedReferrer_Mst従業員マスタListMap; } }
        public override String keepコード_QueryDerivedReferrer_Mst従業員マスタList(Mst従業員マスタCQ subQuery) {
            if (_コード_QueryDerivedReferrer_Mst従業員マスタListMap == null) { _コード_QueryDerivedReferrer_Mst従業員マスタListMap = new LinkedHashMap<String, Mst従業員マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_QueryDerivedReferrer_Mst従業員マスタListMap.size() + 1);
            _コード_QueryDerivedReferrer_Mst従業員マスタListMap.put(key, subQuery); return "コード_QueryDerivedReferrer_Mst従業員マスタList." + key;
        }
        protected Map<String, Object> _コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap;
        public Map<String, Object> コード_QueryDerivedReferrer_Mst従業員マスタListParameter { get { return _コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap; } }
        public override String keepコード_QueryDerivedReferrer_Mst従業員マスタListParameter(Object parameterValue) {
            if (_コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap == null) { _コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap.size() + 1);
            _コード_QueryDerivedReferrer_Mst従業員マスタListParameterMap.put(key, parameterValue); return "コード_QueryDerivedReferrer_Mst従業員マスタListParameter." + key;
        }

        protected Map<String, Mst権限マスタCQ> _コード_QueryDerivedReferrer_Mst権限マスタListMap;
        public Map<String, Mst権限マスタCQ> コード_QueryDerivedReferrer_Mst権限マスタList { get { return _コード_QueryDerivedReferrer_Mst権限マスタListMap; } }
        public override String keepコード_QueryDerivedReferrer_Mst権限マスタList(Mst権限マスタCQ subQuery) {
            if (_コード_QueryDerivedReferrer_Mst権限マスタListMap == null) { _コード_QueryDerivedReferrer_Mst権限マスタListMap = new LinkedHashMap<String, Mst権限マスタCQ>(); }
            String key = "subQueryMapKey" + (_コード_QueryDerivedReferrer_Mst権限マスタListMap.size() + 1);
            _コード_QueryDerivedReferrer_Mst権限マスタListMap.put(key, subQuery); return "コード_QueryDerivedReferrer_Mst権限マスタList." + key;
        }
        protected Map<String, Object> _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap;
        public Map<String, Object> コード_QueryDerivedReferrer_Mst権限マスタListParameter { get { return _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap; } }
        public override String keepコード_QueryDerivedReferrer_Mst権限マスタListParameter(Object parameterValue) {
            if (_コード_QueryDerivedReferrer_Mst権限マスタListParameterMap == null) { _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap = new LinkedHashMap<String, Object>(); }
            String key = "subQueryParameterKey" + (_コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.size() + 1);
            _コード_QueryDerivedReferrer_Mst権限マスタListParameterMap.put(key, parameterValue); return "コード_QueryDerivedReferrer_Mst権限マスタListParameter." + key;
        }

        public BsKbn職位区分CQ AddOrderBy_コード_Asc() { regOBA("コード");return this; }
        public BsKbn職位区分CQ AddOrderBy_コード_Desc() { regOBD("コード");return this; }

        protected ConditionValue _名称;
        public ConditionValue 名称 {
            get { if (_名称 == null) { _名称 = new ConditionValue(); } return _名称; }
        }
        protected override ConditionValue getCValue名称() { return this.名称; }


        public BsKbn職位区分CQ AddOrderBy_名称_Asc() { regOBA("名称");return this; }
        public BsKbn職位区分CQ AddOrderBy_名称_Desc() { regOBD("名称");return this; }

        protected ConditionValue _名称英字;
        public ConditionValue 名称英字 {
            get { if (_名称英字 == null) { _名称英字 = new ConditionValue(); } return _名称英字; }
        }
        protected override ConditionValue getCValue名称英字() { return this.名称英字; }


        public BsKbn職位区分CQ AddOrderBy_名称英字_Asc() { regOBA("名称_英字");return this; }
        public BsKbn職位区分CQ AddOrderBy_名称英字_Desc() { regOBD("名称_英字");return this; }

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
