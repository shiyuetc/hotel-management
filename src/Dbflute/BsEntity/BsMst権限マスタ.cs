

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
    /// The entity of mst権限マスタ as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, 職位コード, 権限コード
    /// 
    /// [sequence]
    ///     mst001_id_seq
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     kbn権限区分, kbn職位区分
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     kbn権限区分, kbn職位区分
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("mst権限マスタ")]
    [System.Serializable]
    public partial class Mst権限マスタ : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        protected long? _id;

        /// <summary>職位コード: {NotNull, bpchar(3), FK to kbn職位区分, classification=職位区分}</summary>
        protected String _職位コード;

        /// <summary>権限コード: {NotNull, bpchar(3), FK to kbn権限区分}</summary>
        protected String _権限コード;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst権限マスタ"; } }
        public String TablePropertyName { get { return "Mst権限マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.職位区分 職位コードAs職位区分 { get {
            return CDef.職位区分.CodeOf(_職位コード);
        } set {
            職位コード = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of 職位コード as システム保守.
        /// <![CDATA[
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public void Set職位コード_システム保守() {
            職位コードAs職位区分 = CDef.職位区分.システム保守;
        }

        /// <summary>
        /// Set the value of 職位コード as アシスタントマネージャー.
        /// <![CDATA[
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public void Set職位コード_アシスタントマネージャー() {
            職位コードAs職位区分 = CDef.職位区分.アシスタントマネージャー;
        }

        /// <summary>
        /// Set the value of 職位コード as ファイナンシャルコントローラー.
        /// <![CDATA[
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public void Set職位コード_ファイナンシャルコントローラー() {
            職位コードAs職位区分 = CDef.職位区分.ファイナンシャルコントローラー;
        }

        /// <summary>
        /// Set the value of 職位コード as フロントクラーク.
        /// <![CDATA[
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public void Set職位コード_フロントクラーク() {
            職位コードAs職位区分 = CDef.職位区分.フロントクラーク;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of 職位コード 'システム保守'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public bool Is職位コードシステム保守 {
            get {
                CDef.職位区分 cls = 職位コードAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.システム保守) : false;
            }
        }

        /// <summary>
        /// Is the value of 職位コード 'アシスタントマネージャー'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public bool Is職位コードアシスタントマネージャー {
            get {
                CDef.職位区分 cls = 職位コードAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.アシスタントマネージャー) : false;
            }
        }

        /// <summary>
        /// Is the value of 職位コード 'ファイナンシャルコントローラー'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public bool Is職位コードファイナンシャルコントローラー {
            get {
                CDef.職位区分 cls = 職位コードAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.ファイナンシャルコントローラー) : false;
            }
        }

        /// <summary>
        /// Is the value of 職位コード 'フロントクラーク'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public bool Is職位コードフロントクラーク {
            get {
                CDef.職位区分 cls = 職位コードAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.フロントクラーク) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Kbn権限区分 _kbn権限区分;

        /// <summary>kbn権限区分 as 'Kbn権限区分'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("権限コード:コード")]
        public Kbn権限区分 Kbn権限区分 {
            get { return _kbn権限区分; }
            set { _kbn権限区分 = value; }
        }

        protected Kbn職位区分 _kbn職位区分;

        /// <summary>kbn職位区分 as 'Kbn職位区分'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("職位コード:コード")]
        public Kbn職位区分 Kbn職位区分 {
            get { return _kbn職位区分; }
            set { _kbn職位区分 = value; }
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
            if (other == null || !(other is Mst権限マスタ)) { return false; }
            Mst権限マスタ otherEntity = (Mst権限マスタ)other;
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
            return "Mst権限マスタ:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_kbn権限区分 != null)
            { sb.Append(l).Append(xbRDS(_kbn権限区分, "Kbn権限区分")); }
            if (_kbn職位区分 != null)
            { sb.Append(l).Append(xbRDS(_kbn職位区分, "Kbn職位区分")); }
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
            sb.Append(c).Append(this.職位コード);
            sb.Append(c).Append(this.権限コード);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_kbn権限区分 != null) { sb.Append(c).Append("Kbn権限区分"); }
            if (_kbn職位区分 != null) { sb.Append(c).Append("Kbn職位区分"); }
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

        /// <summary>職位コード: {NotNull, bpchar(3), FK to kbn職位区分, classification=職位区分}</summary>
        [Seasar.Dao.Attrs.Column("職位コード")]
        public String 職位コード {
            get { return _職位コード; }
            set {
                __modifiedProperties.AddPropertyName("職位コード");
                _職位コード = value;
            }
        }

        /// <summary>権限コード: {NotNull, bpchar(3), FK to kbn権限区分}</summary>
        [Seasar.Dao.Attrs.Column("権限コード")]
        public String 権限コード {
            get { return _権限コード; }
            set {
                __modifiedProperties.AddPropertyName("権限コード");
                _権限コード = value;
            }
        }

        #endregion
    }
}
