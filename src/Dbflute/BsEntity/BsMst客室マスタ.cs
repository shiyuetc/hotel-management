

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
    /// The entity of mst客室マスタ as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, 客室番号, 客室タイプid, 喫煙, 備考
    /// 
    /// [sequence]
    ///     mst006_id_seq
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     mst客室タイプマスタ
    /// 
    /// [referrer-table]
    ///     dch客室利用予定台帳, dch客室利用実績台帳
    /// 
    /// [foreign-property]
    ///     mst客室タイプマスタ
    /// 
    /// [referrer-property]
    ///     dch客室利用予定台帳List, dch客室利用実績台帳List
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("mst客室マスタ")]
    [System.Serializable]
    public partial class Mst客室マスタ : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        protected long? _id;

        /// <summary>客室番号: {UQ, NotNull, bpchar(3)}</summary>
        protected String _客室番号;

        /// <summary>客室タイプid: {NotNull, int8(19), FK to mst客室タイプマスタ}</summary>
        protected long? _客室タイプid;

        /// <summary>喫煙: {NotNull, bool(1)}</summary>
        protected bool? _喫煙;

        /// <summary>備考: {varchar(255)}</summary>
        protected String _備考;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst客室マスタ"; } }
        public String TablePropertyName { get { return "Mst客室マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Mst客室タイプマスタ _mst客室タイプマスタ;

        /// <summary>mst客室タイプマスタ as 'Mst客室タイプマスタ'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("客室タイプid:id")]
        public Mst客室タイプマスタ Mst客室タイプマスタ {
            get { return _mst客室タイプマスタ; }
            set { _mst客室タイプマスタ = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<Dch客室利用予定台帳> _dch客室利用予定台帳List;

        /// <summary>dch客室利用予定台帳 as 'Dch客室利用予定台帳List'.</summary>
        public IList<Dch客室利用予定台帳> Dch客室利用予定台帳List {
            get { if (_dch客室利用予定台帳List == null) { _dch客室利用予定台帳List = new List<Dch客室利用予定台帳>(); } return _dch客室利用予定台帳List; }
            set { _dch客室利用予定台帳List = value; }
        }

        protected IList<Dch客室利用実績台帳> _dch客室利用実績台帳List;

        /// <summary>dch客室利用実績台帳 as 'Dch客室利用実績台帳List'.</summary>
        public IList<Dch客室利用実績台帳> Dch客室利用実績台帳List {
            get { if (_dch客室利用実績台帳List == null) { _dch客室利用実績台帳List = new List<Dch客室利用実績台帳>(); } return _dch客室利用実績台帳List; }
            set { _dch客室利用実績台帳List = value; }
        }

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
            if (other == null || !(other is Mst客室マスタ)) { return false; }
            Mst客室マスタ otherEntity = (Mst客室マスタ)other;
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
            return "Mst客室マスタ:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_mst客室タイプマスタ != null)
            { sb.Append(l).Append(xbRDS(_mst客室タイプマスタ, "Mst客室タイプマスタ")); }
            if (_dch客室利用予定台帳List != null) { foreach (Entity e in _dch客室利用予定台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dch客室利用予定台帳List")); } } }
            if (_dch客室利用実績台帳List != null) { foreach (Entity e in _dch客室利用実績台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dch客室利用実績台帳List")); } } }
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
            sb.Append(c).Append(this.客室番号);
            sb.Append(c).Append(this.客室タイプid);
            sb.Append(c).Append(this.喫煙);
            sb.Append(c).Append(this.備考);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_mst客室タイプマスタ != null) { sb.Append(c).Append("Mst客室タイプマスタ"); }
            if (_dch客室利用予定台帳List != null && _dch客室利用予定台帳List.Count > 0)
            { sb.Append(c).Append("Dch客室利用予定台帳List"); }
            if (_dch客室利用実績台帳List != null && _dch客室利用実績台帳List.Count > 0)
            { sb.Append(c).Append("Dch客室利用実績台帳List"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("id")]
        public long? Id {
            get { return _id; }
            set {
                __modifiedProperties.AddPropertyName("Id");
                _id = value;
            }
        }

        /// <summary>客室番号: {UQ, NotNull, bpchar(3)}</summary>
        [Seasar.Dao.Attrs.Column("客室番号")]
        public String 客室番号 {
            get { return _客室番号; }
            set {
                __modifiedProperties.AddPropertyName("客室番号");
                _客室番号 = value;
            }
        }

        /// <summary>客室タイプid: {NotNull, int8(19), FK to mst客室タイプマスタ}</summary>
        [Seasar.Dao.Attrs.Column("客室タイプid")]
        public long? 客室タイプid {
            get { return _客室タイプid; }
            set {
                __modifiedProperties.AddPropertyName("客室タイプid");
                _客室タイプid = value;
            }
        }

        /// <summary>喫煙: {NotNull, bool(1)}</summary>
        [Seasar.Dao.Attrs.Column("喫煙")]
        public bool? 喫煙 {
            get { return _喫煙; }
            set {
                __modifiedProperties.AddPropertyName("喫煙");
                _喫煙 = value;
            }
        }

        /// <summary>備考: {varchar(255)}</summary>
        [Seasar.Dao.Attrs.Column("備考")]
        public String 備考 {
            get { return _備考; }
            set {
                __modifiedProperties.AddPropertyName("備考");
                _備考 = value;
            }
        }

        #endregion
    }
}
