

using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

using Dbflute.AllCommon;
using Dbflute.AllCommon.CBean;
using Dbflute.AllCommon.Dbm;
using Dbflute.AllCommon.Helper;
using Dbflute.ExEntity;
using Dbflute.BsEntity.Dbm;


namespace Dbflute.ExEntity {

    /// <summary>
    /// The entity of rank as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     code
    /// 
    /// [column]
    ///     code, english_name, japanese_name
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     
    /// 
    /// [referrer-table]
    ///     employee
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     employeeList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("rank")]
    [System.Serializable]
    public partial class Rank : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>code: {PK, NotNull, bpchar(3), classification=Rank}</summary>
        protected String _code;

        /// <summary>english_name: {NotNull, varchar(20)}</summary>
        protected String _englishName;

        /// <summary>japanese_name: {NotNull, varchar(20)}</summary>
        protected String _japaneseName;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "rank"; } }
        public String TablePropertyName { get { return "Rank"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.Rank CodeAsRank { get {
            return CDef.Rank.CodeOf(_code);
        } set {
            Code = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of code as SystemMaintenancer.
        /// <![CDATA[
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public void SetCode_SystemMaintenancer() {
            CodeAsRank = CDef.Rank.SystemMaintenancer;
        }

        /// <summary>
        /// Set the value of code as AssistantManager.
        /// <![CDATA[
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public void SetCode_AssistantManager() {
            CodeAsRank = CDef.Rank.AssistantManager;
        }

        /// <summary>
        /// Set the value of code as FinancialController.
        /// <![CDATA[
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public void SetCode_FinancialController() {
            CodeAsRank = CDef.Rank.FinancialController;
        }

        /// <summary>
        /// Set the value of code as FrontClerk.
        /// <![CDATA[
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public void SetCode_FrontClerk() {
            CodeAsRank = CDef.Rank.FrontClerk;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of code 'SystemMaintenancer'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public bool IsCodeSystemMaintenancer {
            get {
                CDef.Rank cls = CodeAsRank;
                return cls != null ? cls.Equals(CDef.Rank.SystemMaintenancer) : false;
            }
        }

        /// <summary>
        /// Is the value of code 'AssistantManager'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public bool IsCodeAssistantManager {
            get {
                CDef.Rank cls = CodeAsRank;
                return cls != null ? cls.Equals(CDef.Rank.AssistantManager) : false;
            }
        }

        /// <summary>
        /// Is the value of code 'FinancialController'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public bool IsCodeFinancialController {
            get {
                CDef.Rank cls = CodeAsRank;
                return cls != null ? cls.Equals(CDef.Rank.FinancialController) : false;
            }
        }

        /// <summary>
        /// Is the value of code 'FrontClerk'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public bool IsCodeFrontClerk {
            get {
                CDef.Rank cls = CodeAsRank;
                return cls != null ? cls.Equals(CDef.Rank.FrontClerk) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<Employee> _employeeList;

        /// <summary>employee as 'EmployeeList'.</summary>
        public IList<Employee> EmployeeList {
            get { if (_employeeList == null) { _employeeList = new List<Employee>(); } return _employeeList; }
            set { _employeeList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_code == null) { return false; }
                return true;
            }
        }

        // ===============================================================================
        //                                                             Modified Properties
        //                                                             ===================
        public virtual IDictionary<String, Object> ModifiedPropertyNames {
            get { return __modifiedProperties.PropertyNames; }
        }

        public virtual void ClearModifiedPropertyNames() {
            __modifiedProperties.Clear();
        }

        // ===============================================================================
        //                                                                  Basic Override
        //                                                                  ==============
        #region Basic Override
        public override bool Equals(Object other) {
            if (other == null || !(other is Rank)) { return false; }
            Rank otherEntity = (Rank)other;
            if (!xSV(this.Code, otherEntity.Code)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _code);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Rank:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_employeeList != null) { foreach (Entity e in _employeeList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "EmployeeList")); } } }
            return sb.ToString();
        }
        protected String xbRDS(Entity e, String name) { // buildRelationDisplayString()
            return e.BuildDisplayString(name, true, true);
        }

        public virtual String BuildDisplayString(String name, bool column, bool relation) {
            StringBuilder sb = new StringBuilder();
            if (name != null) { sb.Append(name).Append(column || relation ? ":" : ""); }
            if (column) { sb.Append(BuildColumnString()); }
            if (relation) { sb.Append(BuildRelationString()); }
            return sb.ToString();
        }
        protected virtual String BuildColumnString() {
            String c = ", ";
            StringBuilder sb = new StringBuilder();
            sb.Append(c).Append(this.Code);
            sb.Append(c).Append(this.EnglishName);
            sb.Append(c).Append(this.JapaneseName);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_employeeList != null && _employeeList.Count > 0)
            { sb.Append(c).Append("EmployeeList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>code: {PK, NotNull, bpchar(3), classification=Rank}</summary>
        [Seasar.Dao.Attrs.Column("code")]
        public String Code {
            get { return _code; }
            set {
                __modifiedProperties.AddPropertyName("Code");
                _code = value;
            }
        }

        /// <summary>english_name: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("english_name")]
        public String EnglishName {
            get { return _englishName; }
            set {
                __modifiedProperties.AddPropertyName("EnglishName");
                _englishName = value;
            }
        }

        /// <summary>japanese_name: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("japanese_name")]
        public String JapaneseName {
            get { return _japaneseName; }
            set {
                __modifiedProperties.AddPropertyName("JapaneseName");
                _japaneseName = value;
            }
        }

        #endregion
    }
}
