

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
    /// The entity of dch客室利用台帳 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// 客室利用台帳
    /// 
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, 客室利用コード, 客室コード, 開始予定日時, 終了予定日時, 開始実績日時, 終了実績日時, 備考
    /// 
    /// [sequence]
    ///     dch002_id_seq
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     mst客室マスタ, kbn客室利用区分, dch宿泊利用台帳(AsOne)
    /// 
    /// [referrer-table]
    ///     dch宿泊利用台帳
    /// 
    /// [foreign-property]
    ///     mst客室マスタ, kbn客室利用区分, dch宿泊利用台帳AsOne
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("dch客室利用台帳")]
    [System.Serializable]
    public partial class Dch客室利用台帳 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        protected long? _id;

        /// <summary>客室利用コード: {NotNull, bpchar(3), FK to kbn客室利用区分, classification=客室利用区分}</summary>
        protected String _客室利用コード;

        /// <summary>客室コード: {NotNull, bpchar(6), FK to mst客室マスタ}</summary>
        protected String _客室コード;

        /// <summary>開始予定日時: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _開始予定日時;

        /// <summary>終了予定日時: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _終了予定日時;

        /// <summary>開始実績日時: {timestamp(26, 3)}</summary>
        protected DateTime? _開始実績日時;

        /// <summary>終了実績日時: {timestamp(26, 3)}</summary>
        protected DateTime? _終了実績日時;

        /// <summary>備考: {varchar(255)}</summary>
        protected String _備考;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "dch客室利用台帳"; } }
        public String TablePropertyName { get { return "Dch客室利用台帳"; } }

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
        protected Mst客室マスタ _mst客室マスタ;

        /// <summary>mst客室マスタ as 'Mst客室マスタ'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("客室コード:客室コード")]
        public Mst客室マスタ Mst客室マスタ {
            get { return _mst客室マスタ; }
            set { _mst客室マスタ = value; }
        }

        protected Kbn客室利用区分 _kbn客室利用区分;

        /// <summary>kbn客室利用区分 as 'Kbn客室利用区分'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("客室利用コード:客室利用コード")]
        public Kbn客室利用区分 Kbn客室利用区分 {
            get { return _kbn客室利用区分; }
            set { _kbn客室利用区分 = value; }
        }

        protected Dch宿泊利用台帳 _dch宿泊利用台帳AsOne;

        /// <summary>dch宿泊利用台帳 as 'Dch宿泊利用台帳AsOne'.</summary>
        [Seasar.Dao.Attrs.Relno(2), Seasar.Dao.Attrs.Relkeys("id:客室利用台帳id")]
        public Dch宿泊利用台帳 Dch宿泊利用台帳AsOne {
            get { return _dch宿泊利用台帳AsOne; }
            set { _dch宿泊利用台帳AsOne = value; }
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
            if (other == null || !(other is Dch客室利用台帳)) { return false; }
            Dch客室利用台帳 otherEntity = (Dch客室利用台帳)other;
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
            return "Dch客室利用台帳:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_mst客室マスタ != null)
            { sb.Append(l).Append(xbRDS(_mst客室マスタ, "Mst客室マスタ")); }
            if (_kbn客室利用区分 != null)
            { sb.Append(l).Append(xbRDS(_kbn客室利用区分, "Kbn客室利用区分")); }
            if (_dch宿泊利用台帳AsOne != null)
            { sb.Append(l).Append(xbRDS(_dch宿泊利用台帳AsOne, "Dch宿泊利用台帳AsOne")); }
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
            sb.Append(c).Append(this.客室利用コード);
            sb.Append(c).Append(this.客室コード);
            sb.Append(c).Append(this.開始予定日時);
            sb.Append(c).Append(this.終了予定日時);
            sb.Append(c).Append(this.開始実績日時);
            sb.Append(c).Append(this.終了実績日時);
            sb.Append(c).Append(this.備考);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_mst客室マスタ != null) { sb.Append(c).Append("Mst客室マスタ"); }
            if (_kbn客室利用区分 != null) { sb.Append(c).Append("Kbn客室利用区分"); }
            if (_dch宿泊利用台帳AsOne != null) { sb.Append(c).Append("Dch宿泊利用台帳AsOne"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        /// <remarks>
        /// 客室利用台帳ID
        /// </remarks>
        [Seasar.Dao.Attrs.ID("identity")]
        [Seasar.Dao.Attrs.Column("id")]
        public long? Id {
            get { return _id; }
            set {
                __modifiedProperties.AddPropertyName("Id");
                _id = value;
            }
        }

        /// <summary>客室利用コード: {NotNull, bpchar(3), FK to kbn客室利用区分, classification=客室利用区分}</summary>
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

        /// <summary>客室コード: {NotNull, bpchar(6), FK to mst客室マスタ}</summary>
        /// <remarks>
        /// 客室コード
        /// </remarks>
        [Seasar.Dao.Attrs.Column("客室コード")]
        public String 客室コード {
            get { return _客室コード; }
            set {
                __modifiedProperties.AddPropertyName("客室コード");
                _客室コード = value;
            }
        }

        /// <summary>開始予定日時: {NotNull, timestamp(26, 3)}</summary>
        /// <remarks>
        /// 開始予定日時
        /// </remarks>
        [Seasar.Dao.Attrs.Column("開始予定日時")]
        public DateTime? 開始予定日時 {
            get { return _開始予定日時; }
            set {
                __modifiedProperties.AddPropertyName("開始予定日時");
                _開始予定日時 = value;
            }
        }

        /// <summary>終了予定日時: {NotNull, timestamp(26, 3)}</summary>
        /// <remarks>
        /// 終了予定日時
        /// </remarks>
        [Seasar.Dao.Attrs.Column("終了予定日時")]
        public DateTime? 終了予定日時 {
            get { return _終了予定日時; }
            set {
                __modifiedProperties.AddPropertyName("終了予定日時");
                _終了予定日時 = value;
            }
        }

        /// <summary>開始実績日時: {timestamp(26, 3)}</summary>
        /// <remarks>
        /// 開始実績日時
        /// </remarks>
        [Seasar.Dao.Attrs.Column("開始実績日時")]
        public DateTime? 開始実績日時 {
            get { return _開始実績日時; }
            set {
                __modifiedProperties.AddPropertyName("開始実績日時");
                _開始実績日時 = value;
            }
        }

        /// <summary>終了実績日時: {timestamp(26, 3)}</summary>
        /// <remarks>
        /// 終了実績日時
        /// </remarks>
        [Seasar.Dao.Attrs.Column("終了実績日時")]
        public DateTime? 終了実績日時 {
            get { return _終了実績日時; }
            set {
                __modifiedProperties.AddPropertyName("終了実績日時");
                _終了実績日時 = value;
            }
        }

        /// <summary>備考: {varchar(255)}</summary>
        /// <remarks>
        /// 備考
        /// </remarks>
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
