

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
    /// The entity of dch客室利用実績台帳 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, 客室マスタid, 客室利用コード, 利用開始日時, 利用終了日時
    /// 
    /// [sequence]
    ///     dch004_id_seq
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     mst客室マスタ, kbn客室利用区分
    /// 
    /// [referrer-table]
    ///     dchその他実績台帳, dch宿泊実績台帳, dch清掃実績台帳
    /// 
    /// [foreign-property]
    ///     mst客室マスタ, kbn客室利用区分
    /// 
    /// [referrer-property]
    ///     dchその他実績台帳List, dch宿泊実績台帳List, dch清掃実績台帳List
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("dch客室利用実績台帳")]
    [System.Serializable]
    public partial class Dch客室利用実績台帳 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        protected long? _id;

        /// <summary>客室マスタid: {NotNull, int8(19), FK to mst客室マスタ}</summary>
        protected long? _客室マスタid;

        /// <summary>客室利用コード: {NotNull, bpchar(3), FK to kbn客室利用区分, classification=客室利用区分}</summary>
        protected String _客室利用コード;

        /// <summary>利用開始日時: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _利用開始日時;

        /// <summary>利用終了日時: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _利用終了日時;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "dch客室利用実績台帳"; } }
        public String TablePropertyName { get { return "Dch客室利用実績台帳"; } }

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
        protected Mst客室マスタ _mst客室マスタ;

        /// <summary>mst客室マスタ as 'Mst客室マスタ'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("客室マスタid:id")]
        public Mst客室マスタ Mst客室マスタ {
            get { return _mst客室マスタ; }
            set { _mst客室マスタ = value; }
        }

        protected Kbn客室利用区分 _kbn客室利用区分;

        /// <summary>kbn客室利用区分 as 'Kbn客室利用区分'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("客室利用コード:コード")]
        public Kbn客室利用区分 Kbn客室利用区分 {
            get { return _kbn客室利用区分; }
            set { _kbn客室利用区分 = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<Dchその他実績台帳> _dchその他実績台帳List;

        /// <summary>dchその他実績台帳 as 'Dchその他実績台帳List'.</summary>
        public IList<Dchその他実績台帳> Dchその他実績台帳List {
            get { if (_dchその他実績台帳List == null) { _dchその他実績台帳List = new List<Dchその他実績台帳>(); } return _dchその他実績台帳List; }
            set { _dchその他実績台帳List = value; }
        }

        protected IList<Dch宿泊実績台帳> _dch宿泊実績台帳List;

        /// <summary>dch宿泊実績台帳 as 'Dch宿泊実績台帳List'.</summary>
        public IList<Dch宿泊実績台帳> Dch宿泊実績台帳List {
            get { if (_dch宿泊実績台帳List == null) { _dch宿泊実績台帳List = new List<Dch宿泊実績台帳>(); } return _dch宿泊実績台帳List; }
            set { _dch宿泊実績台帳List = value; }
        }

        protected IList<Dch清掃実績台帳> _dch清掃実績台帳List;

        /// <summary>dch清掃実績台帳 as 'Dch清掃実績台帳List'.</summary>
        public IList<Dch清掃実績台帳> Dch清掃実績台帳List {
            get { if (_dch清掃実績台帳List == null) { _dch清掃実績台帳List = new List<Dch清掃実績台帳>(); } return _dch清掃実績台帳List; }
            set { _dch清掃実績台帳List = value; }
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
            if (other == null || !(other is Dch客室利用実績台帳)) { return false; }
            Dch客室利用実績台帳 otherEntity = (Dch客室利用実績台帳)other;
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
            return "Dch客室利用実績台帳:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_mst客室マスタ != null)
            { sb.Append(l).Append(xbRDS(_mst客室マスタ, "Mst客室マスタ")); }
            if (_kbn客室利用区分 != null)
            { sb.Append(l).Append(xbRDS(_kbn客室利用区分, "Kbn客室利用区分")); }
            if (_dchその他実績台帳List != null) { foreach (Entity e in _dchその他実績台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dchその他実績台帳List")); } } }
            if (_dch宿泊実績台帳List != null) { foreach (Entity e in _dch宿泊実績台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dch宿泊実績台帳List")); } } }
            if (_dch清掃実績台帳List != null) { foreach (Entity e in _dch清掃実績台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dch清掃実績台帳List")); } } }
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
            sb.Append(c).Append(this.客室マスタid);
            sb.Append(c).Append(this.客室利用コード);
            sb.Append(c).Append(this.利用開始日時);
            sb.Append(c).Append(this.利用終了日時);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_mst客室マスタ != null) { sb.Append(c).Append("Mst客室マスタ"); }
            if (_kbn客室利用区分 != null) { sb.Append(c).Append("Kbn客室利用区分"); }
            if (_dchその他実績台帳List != null && _dchその他実績台帳List.Count > 0)
            { sb.Append(c).Append("Dchその他実績台帳List"); }
            if (_dch宿泊実績台帳List != null && _dch宿泊実績台帳List.Count > 0)
            { sb.Append(c).Append("Dch宿泊実績台帳List"); }
            if (_dch清掃実績台帳List != null && _dch清掃実績台帳List.Count > 0)
            { sb.Append(c).Append("Dch清掃実績台帳List"); }
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

        /// <summary>客室マスタid: {NotNull, int8(19), FK to mst客室マスタ}</summary>
        [Seasar.Dao.Attrs.Column("客室マスタid")]
        public long? 客室マスタid {
            get { return _客室マスタid; }
            set {
                __modifiedProperties.AddPropertyName("客室マスタid");
                _客室マスタid = value;
            }
        }

        /// <summary>客室利用コード: {NotNull, bpchar(3), FK to kbn客室利用区分, classification=客室利用区分}</summary>
        [Seasar.Dao.Attrs.Column("客室利用コード")]
        public String 客室利用コード {
            get { return _客室利用コード; }
            set {
                __modifiedProperties.AddPropertyName("客室利用コード");
                _客室利用コード = value;
            }
        }

        /// <summary>利用開始日時: {NotNull, timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("利用開始日時")]
        public DateTime? 利用開始日時 {
            get { return _利用開始日時; }
            set {
                __modifiedProperties.AddPropertyName("利用開始日時");
                _利用開始日時 = value;
            }
        }

        /// <summary>利用終了日時: {NotNull, timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("利用終了日時")]
        public DateTime? 利用終了日時 {
            get { return _利用終了日時; }
            set {
                __modifiedProperties.AddPropertyName("利用終了日時");
                _利用終了日時 = value;
            }
        }

        #endregion
    }
}
