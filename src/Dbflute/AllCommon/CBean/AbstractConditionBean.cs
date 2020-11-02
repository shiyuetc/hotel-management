
using System;
using System.Reflection;

using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.CBean.SClause;
using Dbflute.AllCommon.JavaLike;
using Dbflute.AllCommon.Ado;
using Dbflute.AllCommon.Util;

namespace Dbflute.AllCommon.CBean {

    [System.Serializable]
    public abstract class AbstractConditionBean : ConditionBean {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        protected readonly SqlClause _sqlClause;
        protected bool _canPagingReSelect = true;
        private Map<String, Object> _freeParameterMap;
        private UnionQuery<ConditionBean> _unionQuerySynchronizer;
    
        // [DBFlute-0.7.4] @jflute -- At the future, I'll implement some check logics by these purpose types.
        protected bool _forUnion;
        protected bool _forExistsReferrer;
        protected bool _forInScopeRelation;
        protected bool _forDerivedReferrer;
        protected bool _forScalarSelect;
        protected bool _forScalarCondition;
        protected bool _forColumnQuery;

        protected int _safetyMaxResultSize;
        protected StatementConfig _statementConfig;
        protected bool _relationMappingCache = true;

        // ===============================================================================
        //                                                                     Constructor
        //                                                                     ===========
        public AbstractConditionBean() {
            DBMeta dbmeta = DBMetaInstanceHandler.FindDBMeta(TableDbName);
            _sqlClause = new SqlClauseH2(dbmeta.TableSqlName);
        }

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public abstract String TableDbName { get; }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                       SqlClause
        //                                                                       =========
        public SqlClause SqlClause { get { return _sqlClause; } }
        public String GetClause() { return this.SqlClause.getClause(); }

        // ===============================================================================
        //                                                                           Query
        //                                                                           =====
        public abstract ConditionQuery LocalCQ { get; }

        // ===============================================================================
        //                                                    Implementation of PagingBean
        //                                                    ============================
        // -------------------------------------------------
        //                              Paging Determination
        //                              --------------------
        // * * * * * * * *
        // For SQL Comment
        // * * * * * * * *
        public virtual bool IsPaging { get { throw new UnsupportedOperationException("This method is unsupported on ConditionBean!"); } }

        // * * * * * * * *
        // For Framework
        // * * * * * * * *
        public virtual bool IsCountLater { get { throw new UnsupportedOperationException("This method is unsupported on ConditionBean!"); } }

        // -------------------------------------------------
        //                                    Paging Setting
        //                                    --------------
        public void XSetPaging(bool paging) {// Very Internal!
            throw new UnsupportedOperationException("This method is unsupported on ConditionBean!");
        }
        public void Paging(int pageSize, int pageNumber) {
            FetchFirst(pageSize);
            FetchPage(pageNumber);
        }

        public void DisablePagingReSelect() { _canPagingReSelect = false; }
        public virtual bool CanPagingReSelect { get { return _canPagingReSelect; } }

        // -------------------------------------------------
        //                                     Fetch Setting
        //                                     -------------
        public PagingBean FetchFirst(int fetchSize) {
            this.SqlClause.fetchFirst(fetchSize);
            return this;
        }

        public PagingBean FetchScope(int fetchStartIndex, int fetchSize) {
            this.SqlClause.fetchScope(fetchStartIndex, fetchSize);
            return this;
        }

        public PagingBean FetchPage(int fetchPageNumber) {
            this.SqlClause.fetchPage(fetchPageNumber);
            return this;
        }

        // -------------------------------------------------
        //                                    Fetch Property
        //                                    --------------
        public int SafetyMaxResultSize { get { return _safetyMaxResultSize; } }
        public int FetchStartIndex { get { return this.SqlClause.getFetchStartIndex(); } }
        public int FetchSize { get { return this.SqlClause.getFetchSize(); } }
        public int FetchPageNumber { get { return this.SqlClause.getFetchPageNumber(); } }
        public int PageStartIndex { get { return this.SqlClause.getPageStartIndex(); } }
        public int PageEndIndex { get { return this.SqlClause.getPageEndIndex(); } }
        public bool IsFetchScopeEffective { get { return this.SqlClause.isFetchScopeEffective(); } }

        // -------------------------------------------------
        //                                     Hint Property
        //                                     -------------
        public String SelectHint { get { return this.SqlClause.getSelectHint(); } }
        public String FromBaseTableHint { get { return this.SqlClause.getFromBaseTableHint(); } }
        public String FromHint { get { return this.SqlClause.getFromHint(); } }
        public String WhereClause { get { return this.SqlClause.getWhereClause(); } }
        public String OrderByClause { get { return this.SqlClause.getOrderByClause(); } }
        public String SqlSuffix { get { return this.SqlClause.getSqlSuffix(); } }

        // ===============================================================================
        //                                                     Implementation of FetchBean
        //                                                     ===========================
        public void CheckSafetyResult(int safetyMaxResultSize) {
            this._safetyMaxResultSize = safetyMaxResultSize;
        }

        // ===============================================================================
        //                                            Implementation of FetchNarrowingBean
        //                                            ====================================
        public int FetchNarrowingSkipStartIndex { get { return this.SqlClause.getFetchNarrowingSkipStartIndex(); } }
        public int FetchNarrowingLoopCount { get { return this.SqlClause.getFetchNarrowingLoopCount(); } }
        public bool IsFetchNarrowingSkipStartIndexEffective { get { return !this.SqlClause.isFetchStartIndexSupported(); } }
        public bool IsFetchNarrowingLoopCountEffective { get { return !this.SqlClause.isFetchSizeSupported(); } }
        public bool IsFetchNarrowingEffective { get { return this.SqlClause.isFetchNarrowingEffective(); } }
        public void IgnoreFetchNarrowing() { throw new UnsupportedOperationException("This method is unsupported on ConditionBean!"); }
        public void RestoreIgnoredFetchNarrowing() {}

        // ===============================================================================
        //                                                   Implementation of OrderByBean
        //                                                   =============================
        public OrderByClause SqlComponentOfOrderByClause {
            get { return this.SqlClause.getSqlComponentOfOrderByClause(); }
        }

        public OrderByBean ClearOrderBy() {
            this.SqlClause.clearOrderBy();
            return this;
        }

        public OrderByBean IgnoreOrderBy() {
            this.SqlClause.ignoreOrderBy();
            return this;
        }

        public OrderByBean MakeOrderByEffective() {
            this.SqlClause.makeOrderByEffective();
            return this;
        }

        public abstract ConditionBean AddOrderBy_PK_Asc();
        public abstract ConditionBean AddOrderBy_PK_Desc();

        // ===============================================================================
        //                                                                    Lock Setting
        //                                                                    ============
        public ConditionBean LockForUpdate() {
            this.SqlClause.lockForUpdate();
            return this;
        }

        // ===============================================================================
        //                                                                    Select Count
        //                                                                    ============
        public ConditionBean xsetupSelectCountIgnoreFetchScope() {
            _isSelectCountIgnoreFetchScope = true;

            this.SqlClause.classifySelectClauseType(SelectClauseType.COUNT);
            this.SqlClause.ignoreOrderBy();
            this.SqlClause.ignoreFetchScope();
            return this;
        }

        public ConditionBean xafterCareSelectCountIgnoreFetchScope() {
            _isSelectCountIgnoreFetchScope = false;

            this.SqlClause.rollbackSelectClauseType();
            this.SqlClause.makeOrderByEffective();
            this.SqlClause.makeFetchScopeEffective();
            return this;
        }

        protected bool _isSelectCountIgnoreFetchScope;

        public bool IsSelectCountIgnoreFetchScope() {
            return _isSelectCountIgnoreFetchScope;
        }

        // ===============================================================================
        //                                                                     ColumnQuery
        //                                                                     ===========
        protected void xcolqy<CB>(CB leftCB, CB rightCB, SpecifyQuery<CB> leftSp,
                SpecifyQuery<CB> rightSp, String operand) where CB : ConditionBean {
            // specify left column
            leftSp.Invoke(leftCB);
            String leftColumn = leftCB.SqlClause.getSpecifiedColumnRealNameAsOne();
            if (leftColumn == null) {
                String msg = "The left column for ColumnQuery was not found: " + leftCB.GetType();
                throw new SystemException(msg);
            }
            // specify right column
            rightSp.Invoke(rightCB);
            String rightColumn = rightCB.SqlClause.getSpecifiedColumnRealNameAsOne();
            if (rightColumn == null) {
                String msg = "The right column for ColumnQuery was not found: " + rightCB.GetType();
                throw new SystemException(msg);
            }
            // register where clause
            String clause = leftColumn + " " + operand + " " + rightColumn;
            this.SqlClause.registerWhereClause(clause);
        }

        // ===============================================================================
        //                                                                    OrScopeQuery
        //                                                                    ============
        protected void xorQ<CB>(CB cb, OrQuery<CB> orQuery) where CB : ConditionBean {
            this.SqlClause.makeOrScopeQueryEffective();
            try {
                orQuery.Invoke(cb);
            } finally {
                this.SqlClause.closeOrScopeQuery();
            }
        }

        // ===============================================================================
        //                                                                    InvalidQuery
        //                                                                    ============
        public void CheckInvalidQuery() {
            this.SqlClause.checkInvalidQuery();
        }

        // ===============================================================================
        //                                                                Statement Config
        //                                                                ================
        public void Configure(StatementConfig statementConfig) {
            _statementConfig = statementConfig;
        }
    
        public StatementConfig StatementConfig { get {
            return _statementConfig;
        }}

        // ===============================================================================
        //                                                                  Entity Mapping
        //                                                                  ==============
        [System.Obsolete("You should not use this easily. It's a dangerous function.")]
        public virtual void DisableRelationMappingCache() {
            // deprecated methods from the beginning are not defined as interface methods
            _relationMappingCache = false;
        }

        public virtual bool CanRelationMappingCache() {
            return _relationMappingCache;
        }

        // ===============================================================================
        //                                                                     Display SQL
        //                                                                     ===========
        public virtual String ToDisplaySql() {
            return ConditionBeanContext.ConvertConditionBean2DisplaySql(this);
        }
    
        // [DBFlute-0.8.9.2]
        // ===============================================================================
        //                                                      Basic Status Determination
        //                                                      ==========================
        public virtual bool HasWhereClause() {
            return this.SqlClause.hasWhereClause();
        }

        public virtual bool HasOrderByClause() {
            return this.SqlClause.hasOrderByClause();
        }

        public abstract bool HasUnionQueryOrUnionAllQuery();

        // [DBFlute-0.8.9.2]
        // ===============================================================================
        //                                                                  Free Parameter
        //                                                                  ==============
        public Map<String, Object> FreeParameterMap { get { // Very Internal
            return _freeParameterMap;
        }}

        public void xregisterFreeParameter(String key, Object value) {
            if (_freeParameterMap == null) {
                _freeParameterMap = new LinkedHashMap<String, Object>();
            }
            _freeParameterMap.put(key, value);
        }

        // [DBFlute-0.8.9.2]
        // ===============================================================================
        //                                                              Query Synchronizer
        //                                                              ==================
        protected void xsyncUQ(ConditionBean unionCB) { // synchronizeUnionQuery()
            if (_unionQuerySynchronizer != null) {
                _unionQuerySynchronizer.Invoke(unionCB);
            }
        }

        public void xregisterUnionQuerySynchronizer(UnionQuery<ConditionBean> unionQuerySynchronizer) {
            _unionQuerySynchronizer = unionQuerySynchronizer;
        }

        // [DBFlute-0.7.4]
        // ===============================================================================
        //                                                                    Purpose Type
        //                                                                    ============
        // /- - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        // very internal (super very important)
        // these are called immediate after creation of condition-bean
        // because there are important initializations here
        // - - - - - - - - - -/

        public void xsetupForUnion(ConditionBean mainCB) {
            xinheritSubQueryInfo(mainCB.LocalCQ);
            _forUnion = true;
        }

        public void xsetupForExistsReferrer(ConditionQuery mainCQ) {
            xprepareSubQueryInfo(mainCQ);
            _forExistsReferrer = true;
        }

        public void xsetupForInScopeRelation(ConditionQuery mainCQ) {
            xprepareSubQueryInfo(mainCQ);
            _forInScopeRelation = true;
        }

        public void xsetupForDerivedReferrer(ConditionQuery mainCQ) {
            xprepareSubQueryInfo(mainCQ);
            _forDerivedReferrer = true;
        }

        public void xsetupForScalarSelect() { // not sub-query
            _forScalarSelect = true;
        }

        public void xsetupForScalarCondition(ConditionQuery mainCQ) {
            xprepareSubQueryInfo(mainCQ);
            _forScalarCondition = true;
        }

        // *defined at base condition-bean per table
        //  o xsetupForColumnQuery()
        //  o xsetupForVaryingUpdate()

        protected void xinheritSubQueryInfo(ConditionQuery mainCQ) {
            if (mainCQ.xgetSqlClause().isForSubQuery()) {
                this.SqlClause.setupForSubQuery(mainCQ.xgetSqlClause().getSubQueryLevel()); // inherited
            }
        }

        protected void xprepareSubQueryInfo(ConditionQuery mainCQ) {
            int nextSubQueryLevel = mainCQ.xgetSqlClause().getSubQueryLevel() + 1;
            this.SqlClause.setupForSubQuery(nextSubQueryLevel); // incremented
        }

        // ===============================================================================
        //                                                                   Assist Helper
        //                                                                   =============
        protected void doSetupSelect(SsCall callback) {
            String foreignPropertyName = callback.Invoke().xgetForeignPropertyName();
            assertSetupSelectBeforeUnion(foreignPropertyName);
            String foreignTableAliasName = callback.Invoke().xgetAliasName();
            String localRelationPath = LocalCQ.xgetRelationPath();
            SqlClause.registerSelectedSelectColumn(foreignTableAliasName, TableDbName, foreignPropertyName, localRelationPath);
            SqlClause.registerSelectedForeignInfo(callback.Invoke().xgetRelationPath(), foreignPropertyName);
        }

        protected delegate ConditionQuery SsCall();

        // ===============================================================================
        //                                                                   Assert Helper
        //                                                                   =============
        protected void assertObjectNotNull(String variableName, Object arg) {
            if (variableName == null) {
                String msg = "Argument[variableName] should not be null.";
                throw new IllegalArgumentException(msg);
            }
            if (arg == null) {
                String msg = "Argument[" + variableName + "] should not be null.";
                throw new IllegalArgumentException(msg);
            }
        }

        protected void assertSetupSelectBeforeUnion(String foreignPropertyName) {
            if (HasUnionQueryOrUnionAllQuery()) {
                throwSetupSelectAfterUnionException(this.GetType().Name, foreignPropertyName);
            }
        }

        protected void throwSetupSelectAfterUnionException(String className, String foreignPropertyName) {
            String methodName = "setupSelect_" + initCap(foreignPropertyName) + "()";
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "You should NOT call " + methodName + " after calling union()!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + methodName + " should be called before calling union()." + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    " + className + " cb = new " + className + "();" + ln();
            msg = msg + "    cb." + methodName + "; // You should call here!" + ln();
            msg = msg + "    cb.query().setXxx...;" + ln();
            msg = msg + "    cb.union(new UnionQuery<" + className + ">() {" + ln();
            msg = msg + "        public void query(" + className + " unionCB) {" + ln();
            msg = msg + "            unionCB.query().setXxx...;" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    });" + ln();
            msg = msg + "    // You should not call setupSelect after calling union()!" + ln();
            msg = msg + "    // cb." + methodName + ";" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "[SetupSelect Method]" + ln() + methodName + ln();
            msg = msg + ln();
            msg = msg + "[ConditionBean SQL]" + ln() + ToDisplaySql() + ln();
            msg = msg + "* * * * * * * * * */" + ln();
            throw new IllegalStateException(msg);
        }
    
        // ===============================================================================
        //                                                                  General Helper
        //                                                                  ==============
        protected String initCap(String str) {
            return SimpleStringUtil.InitCap(str);
        }
    
        protected String ln() {
            return SimpleSystemUtil.GetLineSeparator();
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        public override String ToString() {
            StringBuilder sb = new StringBuilder();
            sb.append(GetType().Name).append(":").append(ln());
            try {
                sb.append(ToDisplaySql());
            } catch (Exception) {
                sb.append(this.SqlClause.getClause());
            }
            return sb.toString();
        }
    }

    // [DBFlute-0.7.4]
    public abstract class AbstractSpecification<CQ> where CQ : ConditionQuery {
        protected ConditionBean _baseCB;
        protected HpSpQyCall<CQ> _qyCall;
        protected HpSpQyCall<CQ> _syncQyCall;
        protected bool _forDerivedReferrer;
        protected bool _forScalarSelect;
        protected bool _forScalarCondition;
        protected bool _forColumnQuery;
        protected CQ _query;
        protected bool _alreadySpecifiedRequiredColumn;

        protected AbstractSpecification(ConditionBean baseCB, HpSpQyCall<CQ> qyCall
                                      , bool forDerivedReferrer, bool forScalarSelect, bool forScalarSubQuery, bool forColumnQuery) {
            _baseCB = baseCB;
            _qyCall = qyCall;
            _forDerivedReferrer = forDerivedReferrer;
            _forScalarSelect = forScalarSelect;
            _forScalarCondition = forScalarSubQuery;
            _forColumnQuery = forColumnQuery;
        }

        protected void doColumn(String columnName) {
            assertColumn(columnName);
            if (_query == null) {
                _query = qyCall().qy();
            }
            if (isRequiredColumnSpecificationEnabled()) {
                _alreadySpecifiedRequiredColumn = true;
                doSpecifyRequiredColumn();
            }
            String relationPath = _query.xgetRelationPath() != null ? _query.xgetRelationPath() : "";
            String tableAliasName;
            if (_query.isBaseQuery()) {
                tableAliasName = _baseCB.SqlClause.getBasePointAliasName();
            } else {
                tableAliasName = _baseCB.SqlClause.resolveJoinAliasName(relationPath, _query.xgetNestLevel());
            }
            _baseCB.SqlClause.specifySelectColumn(tableAliasName, columnName);
        }

        protected HpSpQyCall<CQ> qyCall() { // basically for SpecifyColumn (NOT DerivedReferrer)
            return _syncQyCall != null ? _syncQyCall : _qyCall;
        }

        protected bool isRequiredColumnSpecificationEnabled() {
            if (_alreadySpecifiedRequiredColumn) {
                return false;
            }
            return isNormalUse();
        }

        protected abstract void doSpecifyRequiredColumn();
        protected abstract String getTableDbName();

        public bool IsAlreadySpecifiedRequiredColumn { get {
            return _alreadySpecifiedRequiredColumn;
        }}

        public HpSpQyCall<CQ> xsyncQyCall() {
            return _syncQyCall;
        }

        public void xsetSyncQyCall(HpSpQyCall<CQ> qyCall) {
            _qyCall = qyCall;
        }

        public bool xhasSyncQyCall() {
            return _syncQyCall != null;
        }

        protected void assertColumn(String columnName) {
            if (isNormalUse()) {
                if (_query == null && !_qyCall.has())
                { throwSpecifyColumnNotSetupSelectColumnException(columnName); }
            }
        }

        protected bool isNormalUse() {
            return !_forDerivedReferrer && !_forScalarSelect && !_forScalarCondition && !_forColumnQuery;
        }

        protected void assertForeign(String foreignPropertyName) {
            if (_forDerivedReferrer) { throwDerivedReferrerInvalidForeignSpecificationException(foreignPropertyName); }
            if (_forScalarSelect) { throwScalarSelectInvalidForeignSpecificationException(foreignPropertyName); }
            if (_forScalarCondition) { throwScalarSubQueryInvalidForeignSpecificationException(foreignPropertyName); }
        }

        protected void throwSpecifyColumnNotSetupSelectColumnException(String columnName) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "You specified the column that had Not been Set up!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "You should call setupSelect_[ForeignTable]() before calling specify[ForeignTable]().column[TargetColumn]()." + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Wrong]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.Specify().SpecifyMemberStatus().ColumnMemberStatusName(); // *No!" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Good!]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.SetupSelect_MemberStatus(); // *Point!" + ln();
            msg = msg + "    cb.Specify().SpecifyMemberStatus().ColumnMemberStatusName();" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "[ConditionBean]" + ln() + _baseCB.GetType().Name + ln();
            msg = msg + ln();
            msg = msg + "[Specified Column]" + ln() + getTableDbName() + "." + columnName + ln();
            msg = msg + "* * * * * * * * * */";
            throw new SpecifyColumnNotSetupSelectColumnException(msg);
        }

        protected void throwDerivedReferrerInvalidForeignSpecificationException(String foreignPropertyName) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "You specified a foreign table column in spite of derived-referrer!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "You should specified a local table column at condition-bean for derived-referrer." + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Wrong]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.specify().derivePurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
            msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
            msg = msg + "            subCB.specify().specifyProduct().columnProductName(); // *No!" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Good!]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.specify().derivePurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
            msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
            msg = msg + "            subCB.specify().columnPurchaseDatetime();// *Point!" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "[Specified Foreign Property]" + ln() + foreignPropertyName + ln();
            msg = msg + "* * * * * * * * * */";
            throw new DerivedReferrerInvalidForeignSpecificationException(msg);
        }

        protected void throwScalarSelectInvalidForeignSpecificationException(String foreignPropertyName) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "You specified a foreign table column in spite of scalar select!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "You should specified a local table column at condition-bean for scalar select." + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Wrong]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    memberBhv.scalarSelect(Integer.class).max(new ScalarSelect<MemberCB>() {" + ln();
            msg = msg + "        public void query(MemberCB cb) {" + ln();
            msg = msg + "            cb.specify().specifyMemberStatus().columnDisplayOrder(); // *No!" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    });" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Good!]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    memberBhv.scalarSelect(Date.class).max(new ScalarSelect() {" + ln();
            msg = msg + "        public void query(MemberCB cb) {" + ln();
            msg = msg + "            cb.specify().columnMemberBirthday(); // *Point!" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    });" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "[Specified Foreign Property]" + ln() + foreignPropertyName + ln();
            msg = msg + "* * * * * * * * * */";
            throw new ScalarSelectInvalidForeignSpecificationException(msg);
        }

        protected void throwScalarSubQueryInvalidForeignSpecificationException(String foreignPropertyName) {
            ConditionBeanContext.ThrowScalarSubQueryInvalidForeignSpecificationException(foreignPropertyName);
        }

        protected String ln() {
            return SimpleSystemUtil.GetLineSeparator();
        }
    }

    public interface HpSpQyCall<CQ> where CQ : ConditionQuery {
        bool has(); 
        CQ qy(); 
    }

    public class HpColQyOperand<CB> where CB : ConditionBean {

        protected HpColQyHandler<CB> _handler;

        public HpColQyOperand(HpColQyHandler<CB> handler) {
            _handler = handler;
        }

        public void Equal(SpecifyQuery<CB> rightSpecifyQuery) {
            _handler.Invoke(rightSpecifyQuery, "=");
        }

        public void NotEqual(SpecifyQuery<CB> rightSpecifyQuery) {
            _handler.Invoke(rightSpecifyQuery, "<>");
        }

        public void GreaterThan(SpecifyQuery<CB> rightSpecifyQuery) {
            _handler.Invoke(rightSpecifyQuery, ">");
        }

        public void GreaterEqual(SpecifyQuery<CB> rightSpecifyQuery) {
            _handler.Invoke(rightSpecifyQuery, ">=");
        }

        public void LessThan(SpecifyQuery<CB> rightSpecifyQuery) {
            _handler.Invoke(rightSpecifyQuery, "<");
        }

        public void LessEqual(SpecifyQuery<CB> rightSpecifyQuery) {
            _handler.Invoke(rightSpecifyQuery, "<=");
        }
    }

    public delegate void HpColQyHandler<CB>(SpecifyQuery<CB> rightSp, String operand) where CB : ConditionBean;

    public class SpecifyColumnNotSetupSelectColumnException : SystemException {
        public SpecifyColumnNotSetupSelectColumnException(String msg) : base(msg) {
        }
    }
    
    public class DerivedReferrerInvalidForeignSpecificationException : SystemException {
        public DerivedReferrerInvalidForeignSpecificationException(String msg) : base(msg) {
        }
    }
    
    public class ScalarSelectInvalidForeignSpecificationException : SystemException {
        public ScalarSelectInvalidForeignSpecificationException(String msg) : base(msg) {
        }
    }

    public class RAFunction<REFERRER_CB, LOCAL_CQ> where REFERRER_CB : ConditionBean where LOCAL_CQ : ConditionQuery {
        protected ConditionBean _baseCB;
        protected LOCAL_CQ _localCQ;
        protected RAQSetupper<REFERRER_CB, LOCAL_CQ> _querySetupper;

        public RAFunction(ConditionBean baseCB, LOCAL_CQ localCQ, RAQSetupper<REFERRER_CB, LOCAL_CQ> querySetupper) {
            _baseCB = baseCB;
            _localCQ = localCQ;
            _querySetupper = querySetupper;
        }

        public void Count(SubQuery<REFERRER_CB> subQuery, String aliasName) {
            assertAliasName(aliasName);
            _querySetupper.Invoke("count", subQuery, _localCQ, aliasName.Trim());
        }
        public void CountDistinct(SubQuery<REFERRER_CB> subQuery, String aliasName) {
            assertAliasName(aliasName);
            _querySetupper.Invoke("count(distinct", subQuery, _localCQ, aliasName.Trim());
        }
        public void Max(SubQuery<REFERRER_CB> subQuery, String aliasName) {
            assertAliasName(aliasName);
            _querySetupper.Invoke("max", subQuery, _localCQ, aliasName.Trim());
        }
        public void Min(SubQuery<REFERRER_CB> subQuery, String aliasName) {
            assertAliasName(aliasName);
            _querySetupper.Invoke("min", subQuery, _localCQ, aliasName.Trim());
        }
        public void Sum(SubQuery<REFERRER_CB> subQuery, String aliasName) {
            assertAliasName(aliasName);
            _querySetupper.Invoke("sum", subQuery, _localCQ, aliasName.Trim());
        }
        public void Avg(SubQuery<REFERRER_CB> subQuery, String aliasName) {
            assertAliasName(aliasName);
            _querySetupper.Invoke("avg", subQuery, _localCQ, aliasName.Trim());
        }

        protected void assertAliasName(String aliasName) {
            if (aliasName == null || aliasName.Trim().Length == 0) {
                throwDerivedReferrerInvalidAliasNameException();
            }
            DBMeta dbmeta = DBMetaInstanceHandler.FindDBMeta(_baseCB.TableDbName);
            PropertyInfo[] properties = dbmeta.EntityType.GetProperties();
            String targetPropertyName = aliasName.Replace("_", "").ToLower();
            bool existsSetterMethod = false;
            foreach (PropertyInfo property in properties) {
                if (!property.CanWrite) {
                    continue;
                }
                if (targetPropertyName.Equals(property.Name.ToLower())) {
                    existsSetterMethod = true;
                    break;
                }
            }
            if (!existsSetterMethod) {
                throwDerivedReferrerEntityPropertyNotFoundException(aliasName, dbmeta.EntityType);
            }
        }

        protected void throwDerivedReferrerInvalidAliasNameException() {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "The alias name for derive-referrer was Invalid!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "You should set valid alias name. {NotNull, NotEmpty}" + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Wrong]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.Specify().DerivePurchaseList().Max(delegate(PurchaseCB subCB) {" + ln();
            msg = msg + "        subCB.Specify().ColumnPurchaseDatetime();" + ln();
            msg = msg + "    }, null); // *No! {null, \"\", \"   \"} are NG!" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Good!]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.Specify().DerivePurchaseList().Max(delegate(PurchaseCB subCB) {" + ln();
            msg = msg + "        subCB.Specify().ColumnPurchaseDatetime();" + ln();
            msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\"); // *Point!" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "[Local Table]" + ln() + _localCQ.getTableDbName() + ln();
            msg = msg + "* * * * * * * * * */";
            throw new DerivedReferrerInvalidAliasNameException(msg);
        }

        protected void throwDerivedReferrerEntityPropertyNotFoundException(String aliasName, Type entityType) {
            String msg = "Look! Read the message below." + ln();
            msg = msg + "/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *" + ln();
            msg = msg + "A property for derive-referrer was Not Found in the entity!" + ln();
            msg = msg + ln();
            msg = msg + "[Advice]" + ln();
            msg = msg + "You should implement a property(setter and getter) in the entity." + ln();
            msg = msg + "Or you should confirm whether the alias name has typo or not." + ln();
            msg = msg + "  For example:" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [ConditionBean Invoking]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    MemberCB cb = new MemberCB();" + ln();
            msg = msg + "    cb.specify().derivePurchaseList().max(new SubQuery<PurchaseCB>() {" + ln();
            msg = msg + "        public void query(PurchaseCB subCB) {" + ln();
            msg = msg + "            subCB.specify().columnPurchaseDatetime();" + ln();
            msg = msg + "        }" + ln();
            msg = msg + "    }, \"LATEST_PURCHASE_DATETIME\");" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + "    " + ln();
            msg = msg + "    [Extended Entity]" + ln();
            msg = msg + "    /- - - - - - - - - - - - - - - - - - - - " + ln();
            msg = msg + "    // At the entity of Purchase..." + ln();
            msg = msg + "    protected Date _latestPurchaseDatetime;" + ln();
            msg = msg + "    public Date getLatestPurchaseDatetime() {" + ln();
            msg = msg + "        return _latestPurchaseDatetime;" + ln();
            msg = msg + "    }" + ln();
            msg = msg + "    public void setLatestPurchaseDatetime(Date latestPurchaseDatetime) {" + ln();
            msg = msg + "        _latestPurchaseDatetime = latestPurchaseDatetime;" + ln();
            msg = msg + "    }" + ln();
            msg = msg + "    - - - - - - - - - -/" + ln();
            msg = msg + ln();
            msg = msg + "[Alias Name]" + ln() + aliasName + ln();
            msg = msg + ln();
            msg = msg + "[Target Entity]" + ln() + entityType + ln();
            msg = msg + "* * * * * * * * * */";
            throw new DerivedReferrerEntityPropertyNotFoundException(msg);
        }

        protected String replaceString(String text, String fromText, String toText) {
            return SimpleStringUtil.Replace(text, fromText, toText);
        }
        protected String ln() {
            return SimpleSystemUtil.GetLineSeparator();
        }
    }

    public delegate void RAQSetupper<REFERRER_CB, LOCAL_CQ>(String function, SubQuery<REFERRER_CB> subQuery, LOCAL_CQ cq, String aliasName)
            where REFERRER_CB : ConditionBean where LOCAL_CQ : ConditionQuery;
    
    public class DerivedReferrerInvalidAliasNameException : SystemException {
        public DerivedReferrerInvalidAliasNameException(String msg) : base(msg) {
        }
    }
    
    public class DerivedReferrerEntityPropertyNotFoundException : SystemException {
        public DerivedReferrerEntityPropertyNotFoundException(String msg) : base(msg) {
        }
    }
}
