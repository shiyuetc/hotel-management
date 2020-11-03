

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
    /// The entity of mst_employee as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, employee_no, name, password, rank_code, entry_date, leave_date
    /// 
    /// [sequence]
    ///     mst_employee_id_seq
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     kbn_rank
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     kbnRank
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("mst_employee")]
    [System.Serializable]
    public partial class MstEmployee : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, serial(10)}</summary>
        protected int? _id;

        /// <summary>employee_no: {UQ, NotNull, varchar(10)}</summary>
        protected String _employeeNo;

        /// <summary>name: {NotNull, varchar(50)}</summary>
        protected String _name;

        /// <summary>password: {NotNull, varchar(255)}</summary>
        protected String _password;

        /// <summary>rank_code: {NotNull, varchar(3), FK to kbn_rank}</summary>
        protected String _rankCode;

        /// <summary>entry_date: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _entryDate;

        /// <summary>leave_date: {timestamp(26, 3)}</summary>
        protected DateTime? _leaveDate;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst_employee"; } }
        public String TablePropertyName { get { return "MstEmployee"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected KbnRank _kbnRank;

        /// <summary>kbn_rank as 'KbnRank'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("rank_code:code")]
        public KbnRank KbnRank {
            get { return _kbnRank; }
            set { _kbnRank = value; }
        }

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
            if (other == null || !(other is MstEmployee)) { return false; }
            MstEmployee otherEntity = (MstEmployee)other;
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
            return "MstEmployee:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_kbnRank != null)
            { sb.Append(l).Append(xbRDS(_kbnRank, "KbnRank")); }
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
            sb.Append(c).Append(this.Id);
            sb.Append(c).Append(this.EmployeeNo);
            sb.Append(c).Append(this.Name);
            sb.Append(c).Append(this.Password);
            sb.Append(c).Append(this.RankCode);
            sb.Append(c).Append(this.EntryDate);
            sb.Append(c).Append(this.LeaveDate);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_kbnRank != null) { sb.Append(c).Append("KbnRank"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
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

        /// <summary>employee_no: {UQ, NotNull, varchar(10)}</summary>
        [Seasar.Dao.Attrs.Column("employee_no")]
        public String EmployeeNo {
            get { return _employeeNo; }
            set {
                __modifiedProperties.AddPropertyName("EmployeeNo");
                _employeeNo = value;
            }
        }

        /// <summary>name: {NotNull, varchar(50)}</summary>
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

        /// <summary>rank_code: {NotNull, varchar(3), FK to kbn_rank}</summary>
        [Seasar.Dao.Attrs.Column("rank_code")]
        public String RankCode {
            get { return _rankCode; }
            set {
                __modifiedProperties.AddPropertyName("RankCode");
                _rankCode = value;
            }
        }

        /// <summary>entry_date: {NotNull, timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("entry_date")]
        public DateTime? EntryDate {
            get { return _entryDate; }
            set {
                __modifiedProperties.AddPropertyName("EntryDate");
                _entryDate = value;
            }
        }

        /// <summary>leave_date: {timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("leave_date")]
        public DateTime? LeaveDate {
            get { return _leaveDate; }
            set {
                __modifiedProperties.AddPropertyName("LeaveDate");
                _leaveDate = value;
            }
        }

        #endregion
    }
}
