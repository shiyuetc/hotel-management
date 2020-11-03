

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
    /// The entity of kbn_rank as TABLE. (partial class for auto-generation)
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
    ///     mst_employee
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     mstEmployeeList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("kbn_rank")]
    [System.Serializable]
    public partial class KbnRank : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>code: {PK, NotNull, varchar(3)}</summary>
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
        public String TableDbName { get { return "kbn_rank"; } }
        public String TablePropertyName { get { return "KbnRank"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<MstEmployee> _mstEmployeeList;

        /// <summary>mst_employee as 'MstEmployeeList'.</summary>
        public IList<MstEmployee> MstEmployeeList {
            get { if (_mstEmployeeList == null) { _mstEmployeeList = new List<MstEmployee>(); } return _mstEmployeeList; }
            set { _mstEmployeeList = value; }
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
            if (other == null || !(other is KbnRank)) { return false; }
            KbnRank otherEntity = (KbnRank)other;
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
            return "KbnRank:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_mstEmployeeList != null) { foreach (Entity e in _mstEmployeeList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "MstEmployeeList")); } } }
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
            if (_mstEmployeeList != null && _mstEmployeeList.Count > 0)
            { sb.Append(c).Append("MstEmployeeList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>code: {PK, NotNull, varchar(3)}</summary>
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
