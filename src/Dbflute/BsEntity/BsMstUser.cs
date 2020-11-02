

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
    /// The entity of mst_user as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, login_name, name, password, update_time, update_user, version_no
    /// 
    /// [sequence]
    ///     
    /// 
    /// [identity]
    ///     id
    /// 
    /// [version-no]
    ///     version_no
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
    [Seasar.Dao.Attrs.Table("mst_user")]
    [Seasar.Dao.Attrs.VersionNoProperty("VersionNo")]
    [System.Serializable]
    public partial class MstUser : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, serial(10)}</summary>
        protected int? _id;

        /// <summary>login_name: {UQ, NotNull, varchar(20)}</summary>
        protected String _loginName;

        /// <summary>name: {NotNull, varchar(40)}</summary>
        protected String _name;

        /// <summary>password: {NotNull, varchar(255)}</summary>
        protected String _password;

        /// <summary>update_time: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _updateTime;

        /// <summary>update_user: {NotNull, varchar(100)}</summary>
        protected String _updateUser;

        /// <summary>version_no: {NotNull, int8(19)}</summary>
        protected long? _versionNo;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst_user"; } }
        public String TablePropertyName { get { return "MstUser"; } }

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
                if (_id == null) { return false; }
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
            if (other == null || !(other is MstUser)) { return false; }
            MstUser otherEntity = (MstUser)other;
            if (!xSV(this.Id, otherEntity.Id)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _id);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "MstUser:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.Id);
            sb.Append(c).Append(this.LoginName);
            sb.Append(c).Append(this.Name);
            sb.Append(c).Append(this.Password);
            sb.Append(c).Append(this.UpdateTime);
            sb.Append(c).Append(this.UpdateUser);
            sb.Append(c).Append(this.VersionNo);
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
        /// <summary>id: {PK, ID, NotNull, serial(10)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("id")]
        public int? Id {
            get { return _id; }
            set {
                __modifiedProperties.AddPropertyName("Id");
                _id = value;
            }
        }

        /// <summary>login_name: {UQ, NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("login_name")]
        public String LoginName {
            get { return _loginName; }
            set {
                __modifiedProperties.AddPropertyName("LoginName");
                _loginName = value;
            }
        }

        /// <summary>name: {NotNull, varchar(40)}</summary>
        [Seasar.Dao.Attrs.Column("name")]
        public String Name {
            get { return _name; }
            set {
                __modifiedProperties.AddPropertyName("Name");
                _name = value;
            }
        }

        /// <summary>password: {NotNull, varchar(255)}</summary>
        [Seasar.Dao.Attrs.Column("password")]
        public String Password {
            get { return _password; }
            set {
                __modifiedProperties.AddPropertyName("Password");
                _password = value;
            }
        }

        /// <summary>update_time: {NotNull, timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("update_time")]
        public DateTime? UpdateTime {
            get { return _updateTime; }
            set {
                __modifiedProperties.AddPropertyName("UpdateTime");
                _updateTime = value;
            }
        }

        /// <summary>update_user: {NotNull, varchar(100)}</summary>
        [Seasar.Dao.Attrs.Column("update_user")]
        public String UpdateUser {
            get { return _updateUser; }
            set {
                __modifiedProperties.AddPropertyName("UpdateUser");
                _updateUser = value;
            }
        }

        /// <summary>version_no: {NotNull, int8(19)}</summary>
        [Seasar.Dao.Attrs.Column("version_no")]
        public long? VersionNo {
            get { return _versionNo; }
            set {
                __modifiedProperties.AddPropertyName("VersionNo");
                _versionNo = value;
            }
        }

        #endregion
    }
}
