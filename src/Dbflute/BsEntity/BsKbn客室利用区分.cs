

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
    /// The entity of kbn客室利用区分 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// 客室利用区分
    /// 
    /// [primary-key]
    ///     客室利用コード
    /// 
    /// [column]
    ///     客室利用コード, 客室利用名称
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
    ///     dch客室利用台帳
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     dch客室利用台帳List
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("kbn客室利用区分")]
    [System.Serializable]
    public partial class Kbn客室利用区分 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>客室利用コード: {PK, NotNull, bpchar(2), classification=客室利用区分}</summary>
        protected String _客室利用コード;

        /// <summary>客室利用名称: {NotNull, varchar(20)}</summary>
        protected String _客室利用名称;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "kbn客室利用区分"; } }
        public String TablePropertyName { get { return "Kbn客室利用区分"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.客室利用区分 客室利用コードAs客室利用区分 { get {
            return CDef.客室利用区分.CodeOf(_客室利用コード);
        } set {
            客室利用コード = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of 客室利用コード as 宿泊.
        /// <![CDATA[
        /// 宿泊
        /// ]]>
        /// </summary>
        public void Set客室利用コード_宿泊() {
            客室利用コードAs客室利用区分 = CDef.客室利用区分.宿泊;
        }

        /// <summary>
        /// Set the value of 客室利用コード as 清掃.
        /// <![CDATA[
        /// 清掃
        /// ]]>
        /// </summary>
        public void Set客室利用コード_清掃() {
            客室利用コードAs客室利用区分 = CDef.客室利用区分.清掃;
        }

        /// <summary>
        /// Set the value of 客室利用コード as 工事.
        /// <![CDATA[
        /// 工事
        /// ]]>
        /// </summary>
        public void Set客室利用コード_工事() {
            客室利用コードAs客室利用区分 = CDef.客室利用区分.工事;
        }

        /// <summary>
        /// Set the value of 客室利用コード as その他.
        /// <![CDATA[
        /// その他
        /// ]]>
        /// </summary>
        public void Set客室利用コード_その他() {
            客室利用コードAs客室利用区分 = CDef.客室利用区分.その他;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of 客室利用コード '宿泊'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 宿泊
        /// ]]>
        /// </summary>
        public bool Is客室利用コード宿泊 {
            get {
                CDef.客室利用区分 cls = 客室利用コードAs客室利用区分;
                return cls != null ? cls.Equals(CDef.客室利用区分.宿泊) : false;
            }
        }

        /// <summary>
        /// Is the value of 客室利用コード '清掃'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 清掃
        /// ]]>
        /// </summary>
        public bool Is客室利用コード清掃 {
            get {
                CDef.客室利用区分 cls = 客室利用コードAs客室利用区分;
                return cls != null ? cls.Equals(CDef.客室利用区分.清掃) : false;
            }
        }

        /// <summary>
        /// Is the value of 客室利用コード '工事'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 工事
        /// ]]>
        /// </summary>
        public bool Is客室利用コード工事 {
            get {
                CDef.客室利用区分 cls = 客室利用コードAs客室利用区分;
                return cls != null ? cls.Equals(CDef.客室利用区分.工事) : false;
            }
        }

        /// <summary>
        /// Is the value of 客室利用コード 'その他'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// その他
        /// ]]>
        /// </summary>
        public bool Is客室利用コードその他 {
            get {
                CDef.客室利用区分 cls = 客室利用コードAs客室利用区分;
                return cls != null ? cls.Equals(CDef.客室利用区分.その他) : false;
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
        protected IList<Dch客室利用台帳> _dch客室利用台帳List;

        /// <summary>dch客室利用台帳 as 'Dch客室利用台帳List'.</summary>
        public IList<Dch客室利用台帳> Dch客室利用台帳List {
            get { if (_dch客室利用台帳List == null) { _dch客室利用台帳List = new List<Dch客室利用台帳>(); } return _dch客室利用台帳List; }
            set { _dch客室利用台帳List = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_客室利用コード == null) { return false; }
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
            if (other == null || !(other is Kbn客室利用区分)) { return false; }
            Kbn客室利用区分 otherEntity = (Kbn客室利用区分)other;
            if (!xSV(this.客室利用コード, otherEntity.客室利用コード)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _客室利用コード);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Kbn客室利用区分:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_dch客室利用台帳List != null) { foreach (Entity e in _dch客室利用台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dch客室利用台帳List")); } } }
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
            sb.Append(c).Append(this.客室利用コード);
            sb.Append(c).Append(this.客室利用名称);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_dch客室利用台帳List != null && _dch客室利用台帳List.Count > 0)
            { sb.Append(c).Append("Dch客室利用台帳List"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>客室利用コード: {PK, NotNull, bpchar(2), classification=客室利用区分}</summary>
        /// <remarks>
        /// 客室利用コード
        /// </remarks>
        [Seasar.Dao.Attrs.Column("客室利用コード")]
        public String 客室利用コード {
            get { return _客室利用コード; }
            set {
                __modifiedProperties.AddPropertyName("客室利用コード");
                _客室利用コード = value;
            }
        }

        /// <summary>客室利用名称: {NotNull, varchar(20)}</summary>
        /// <remarks>
        /// 客室利用名称
        /// </remarks>
        [Seasar.Dao.Attrs.Column("客室利用名称")]
        public String 客室利用名称 {
            get { return _客室利用名称; }
            set {
                __modifiedProperties.AddPropertyName("客室利用名称");
                _客室利用名称 = value;
            }
        }

        #endregion
    }
}
