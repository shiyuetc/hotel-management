

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
    ///     id, 職位code, 制御画面id
    /// 
    /// [sequence]
    ///     mst002_id_seq
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     mst制御画面マスタ, kbn職位区分
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     mst制御画面マスタ, kbn職位区分
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

        /// <summary>職位code: {NotNull, bpchar(3), FK to kbn職位区分, classification=職位区分}</summary>
        protected String _職位code;

        /// <summary>制御画面id: {NotNull, int8(19), FK to mst制御画面マスタ}</summary>
        protected long? _制御画面id;

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
        public CDef.職位区分 職位codeAs職位区分 { get {
            return CDef.職位区分.CodeOf(_職位code);
        } set {
            職位code = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of 職位code as システム保守.
        /// <![CDATA[
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public void Set職位code_システム保守() {
            職位codeAs職位区分 = CDef.職位区分.システム保守;
        }

        /// <summary>
        /// Set the value of 職位code as アシスタントマネージャー.
        /// <![CDATA[
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public void Set職位code_アシスタントマネージャー() {
            職位codeAs職位区分 = CDef.職位区分.アシスタントマネージャー;
        }

        /// <summary>
        /// Set the value of 職位code as ファイナンシャルコントローラー.
        /// <![CDATA[
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public void Set職位code_ファイナンシャルコントローラー() {
            職位codeAs職位区分 = CDef.職位区分.ファイナンシャルコントローラー;
        }

        /// <summary>
        /// Set the value of 職位code as フロントクラーク.
        /// <![CDATA[
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public void Set職位code_フロントクラーク() {
            職位codeAs職位区分 = CDef.職位区分.フロントクラーク;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of 職位code 'システム保守'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public bool Is職位codeシステム保守 {
            get {
                CDef.職位区分 cls = 職位codeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.システム保守) : false;
            }
        }

        /// <summary>
        /// Is the value of 職位code 'アシスタントマネージャー'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public bool Is職位codeアシスタントマネージャー {
            get {
                CDef.職位区分 cls = 職位codeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.アシスタントマネージャー) : false;
            }
        }

        /// <summary>
        /// Is the value of 職位code 'ファイナンシャルコントローラー'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public bool Is職位codeファイナンシャルコントローラー {
            get {
                CDef.職位区分 cls = 職位codeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.ファイナンシャルコントローラー) : false;
            }
        }

        /// <summary>
        /// Is the value of 職位code 'フロントクラーク'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public bool Is職位codeフロントクラーク {
            get {
                CDef.職位区分 cls = 職位codeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.フロントクラーク) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Mst制御画面マスタ _mst制御画面マスタ;

        /// <summary>mst制御画面マスタ as 'Mst制御画面マスタ'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("制御画面id:id")]
        public Mst制御画面マスタ Mst制御画面マスタ {
            get { return _mst制御画面マスタ; }
            set { _mst制御画面マスタ = value; }
        }

        protected Kbn職位区分 _kbn職位区分;

        /// <summary>kbn職位区分 as 'Kbn職位区分'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("職位code:code")]
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
            if (_mst制御画面マスタ != null)
            { sb.Append(l).Append(xbRDS(_mst制御画面マスタ, "Mst制御画面マスタ")); }
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
            sb.Append(c).Append(this.職位code);
            sb.Append(c).Append(this.制御画面id);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_mst制御画面マスタ != null) { sb.Append(c).Append("Mst制御画面マスタ"); }
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

        /// <summary>職位code: {NotNull, bpchar(3), FK to kbn職位区分, classification=職位区分}</summary>
        [Seasar.Dao.Attrs.Column("職位code")]
        public String 職位code {
            get { return _職位code; }
            set {
                __modifiedProperties.AddPropertyName("職位code");
                _職位code = value;
            }
        }

        /// <summary>制御画面id: {NotNull, int8(19), FK to mst制御画面マスタ}</summary>
        [Seasar.Dao.Attrs.Column("制御画面id")]
        public long? 制御画面id {
            get { return _制御画面id; }
            set {
                __modifiedProperties.AddPropertyName("制御画面id");
                _制御画面id = value;
            }
        }

        #endregion
    }
}
