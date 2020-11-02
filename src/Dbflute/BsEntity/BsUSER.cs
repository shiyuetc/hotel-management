

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
    /// The entity of USER as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     ID
    /// 
    /// [column]
    ///     ID, NAME, UPDATE_DATETIME, UPDATE_USER, VERSION_NO
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     VERSION_NO
    /// 
    /// [foreign-table]
    ///     
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("USER")]
    [Seasar.Dao.Attrs.VersionNoProperty("VERSION_NO")]
    [System.Serializable]
    public partial class USER : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>ID: {PK, NotNull, INTEGER(10)}</summary>
        protected int? _iD;

        /// <summary>NAME: {NotNull, VARCHAR(20)}</summary>
        protected String _nAME;

        /// <summary>UPDATE_DATETIME: {NotNull, TIMESTAMP(26, 6)}</summary>
        protected DateTime? _uPDATE_DATETIME;

        /// <summary>UPDATE_USER: {NotNull, VARCHAR(200)}</summary>
        protected String _uPDATE_USER;

        /// <summary>VERSION_NO: {NotNull, BIGINT(19)}</summary>
        protected long? _vERSION_NO;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "USER"; } }
        public String TablePropertyName { get { return "USER"; } }

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
        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_iD == null) { return false; }
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
            if (other == null || !(other is USER)) { return false; }
            USER otherEntity = (USER)other;
            if (!xSV(this.ID, otherEntity.ID)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _iD);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "USER:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            return sb.ToString();
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
            sb.Append(c).Append(this.ID);
            sb.Append(c).Append(this.NAME);
            sb.Append(c).Append(this.UPDATE_DATETIME);
            sb.Append(c).Append(this.UPDATE_USER);
            sb.Append(c).Append(this.VERSION_NO);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            return "";
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>ID: {PK, NotNull, INTEGER(10)}</summary>
        [Seasar.Dao.Attrs.Column("ID")]
        public int? ID {
            get { return _iD; }
            set {
                __modifiedProperties.AddPropertyName("ID");
                _iD = value;
            }
        }

        /// <summary>NAME: {NotNull, VARCHAR(20)}</summary>
        [Seasar.Dao.Attrs.Column("NAME")]
        public String NAME {
            get { return _nAME; }
            set {
                __modifiedProperties.AddPropertyName("NAME");
                _nAME = value;
            }
        }

        /// <summary>UPDATE_DATETIME: {NotNull, TIMESTAMP(26, 6)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_DATETIME")]
        public DateTime? UPDATE_DATETIME {
            get { return _uPDATE_DATETIME; }
            set {
                __modifiedProperties.AddPropertyName("UPDATE_DATETIME");
                _uPDATE_DATETIME = value;
            }
        }

        /// <summary>UPDATE_USER: {NotNull, VARCHAR(200)}</summary>
        [Seasar.Dao.Attrs.Column("UPDATE_USER")]
        public String UPDATE_USER {
            get { return _uPDATE_USER; }
            set {
                __modifiedProperties.AddPropertyName("UPDATE_USER");
                _uPDATE_USER = value;
            }
        }

        /// <summary>VERSION_NO: {NotNull, BIGINT(19)}</summary>
        [Seasar.Dao.Attrs.Column("VERSION_NO")]
        public long? VERSION_NO {
            get { return _vERSION_NO; }
            set {
                __modifiedProperties.AddPropertyName("VERSION_NO");
                _vERSION_NO = value;
            }
        }

        #endregion
    }
}
