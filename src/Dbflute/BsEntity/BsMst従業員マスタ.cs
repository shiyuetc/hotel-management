

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
    /// The entity of mst従業員マスタ as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, 従業員番号, 氏名_姓, 氏名_名, 氏名_カナ, メールアドレス, パスワード, 生年月日, 入社年月日, 退社年月日, 職位code, 最終ログイン日時, 備考
    /// 
    /// [sequence]
    ///     mst003_id_seq
    /// 
    /// [identity]
    ///     
    /// 
    /// [version-no]
    ///     
    /// 
    /// [foreign-table]
    ///     kbn職位区分
    /// 
    /// [referrer-table]
    ///     dch従業員職位履歴台帳
    /// 
    /// [foreign-property]
    ///     kbn職位区分
    /// 
    /// [referrer-property]
    ///     dch従業員職位履歴台帳List
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("mst従業員マスタ")]
    [System.Serializable]
    public partial class Mst従業員マスタ : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        protected long? _id;

        /// <summary>従業員番号: {UQ, NotNull, varchar(20)}</summary>
        protected String _従業員番号;

        /// <summary>氏名_姓: {NotNull, varchar(20)}</summary>
        protected String _氏名姓;

        /// <summary>氏名_名: {NotNull, varchar(20)}</summary>
        protected String _氏名名;

        /// <summary>氏名_カナ: {NotNull, varchar(50)}</summary>
        protected String _氏名カナ;

        /// <summary>メールアドレス: {varchar(255)}</summary>
        protected String _メールアドレス;

        /// <summary>パスワード: {NotNull, varchar(255)}</summary>
        protected String _パスワード;

        /// <summary>生年月日: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _生年月日;

        /// <summary>入社年月日: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _入社年月日;

        /// <summary>退社年月日: {timestamp(26, 3)}</summary>
        protected DateTime? _退社年月日;

        /// <summary>職位code: {NotNull, bpchar(3), FK to kbn職位区分, classification=職位区分}</summary>
        protected String _職位code;

        /// <summary>最終ログイン日時: {timestamp(26, 3)}</summary>
        protected DateTime? _最終ログイン日時;

        /// <summary>備考: {varchar(255)}</summary>
        protected String _備考;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst従業員マスタ"; } }
        public String TablePropertyName { get { return "Mst従業員マスタ"; } }

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
        protected Kbn職位区分 _kbn職位区分;

        /// <summary>kbn職位区分 as 'Kbn職位区分'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("職位code:code")]
        public Kbn職位区分 Kbn職位区分 {
            get { return _kbn職位区分; }
            set { _kbn職位区分 = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<Dch従業員職位履歴台帳> _dch従業員職位履歴台帳List;

        /// <summary>dch従業員職位履歴台帳 as 'Dch従業員職位履歴台帳List'.</summary>
        public IList<Dch従業員職位履歴台帳> Dch従業員職位履歴台帳List {
            get { if (_dch従業員職位履歴台帳List == null) { _dch従業員職位履歴台帳List = new List<Dch従業員職位履歴台帳>(); } return _dch従業員職位履歴台帳List; }
            set { _dch従業員職位履歴台帳List = value; }
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
            if (other == null || !(other is Mst従業員マスタ)) { return false; }
            Mst従業員マスタ otherEntity = (Mst従業員マスタ)other;
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
            return "Mst従業員マスタ:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_kbn職位区分 != null)
            { sb.Append(l).Append(xbRDS(_kbn職位区分, "Kbn職位区分")); }
            if (_dch従業員職位履歴台帳List != null) { foreach (Entity e in _dch従業員職位履歴台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dch従業員職位履歴台帳List")); } } }
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
            sb.Append(c).Append(this.従業員番号);
            sb.Append(c).Append(this.氏名姓);
            sb.Append(c).Append(this.氏名名);
            sb.Append(c).Append(this.氏名カナ);
            sb.Append(c).Append(this.メールアドレス);
            sb.Append(c).Append(this.パスワード);
            sb.Append(c).Append(this.生年月日);
            sb.Append(c).Append(this.入社年月日);
            sb.Append(c).Append(this.退社年月日);
            sb.Append(c).Append(this.職位code);
            sb.Append(c).Append(this.最終ログイン日時);
            sb.Append(c).Append(this.備考);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_kbn職位区分 != null) { sb.Append(c).Append("Kbn職位区分"); }
            if (_dch従業員職位履歴台帳List != null && _dch従業員職位履歴台帳List.Count > 0)
            { sb.Append(c).Append("Dch従業員職位履歴台帳List"); }
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

        /// <summary>従業員番号: {UQ, NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("従業員番号")]
        public String 従業員番号 {
            get { return _従業員番号; }
            set {
                __modifiedProperties.AddPropertyName("従業員番号");
                _従業員番号 = value;
            }
        }

        /// <summary>氏名_姓: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("氏名_姓")]
        public String 氏名姓 {
            get { return _氏名姓; }
            set {
                __modifiedProperties.AddPropertyName("氏名姓");
                _氏名姓 = value;
            }
        }

        /// <summary>氏名_名: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("氏名_名")]
        public String 氏名名 {
            get { return _氏名名; }
            set {
                __modifiedProperties.AddPropertyName("氏名名");
                _氏名名 = value;
            }
        }

        /// <summary>氏名_カナ: {NotNull, varchar(50)}</summary>
        [Seasar.Dao.Attrs.Column("氏名_カナ")]
        public String 氏名カナ {
            get { return _氏名カナ; }
            set {
                __modifiedProperties.AddPropertyName("氏名カナ");
                _氏名カナ = value;
            }
        }

        /// <summary>メールアドレス: {varchar(255)}</summary>
        [Seasar.Dao.Attrs.Column("メールアドレス")]
        public String メールアドレス {
            get { return _メールアドレス; }
            set {
                __modifiedProperties.AddPropertyName("メールアドレス");
                _メールアドレス = value;
            }
        }

        /// <summary>パスワード: {NotNull, varchar(255)}</summary>
        [Seasar.Dao.Attrs.Column("パスワード")]
        public String パスワード {
            get { return _パスワード; }
            set {
                __modifiedProperties.AddPropertyName("パスワード");
                _パスワード = value;
            }
        }

        /// <summary>生年月日: {NotNull, timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("生年月日")]
        public DateTime? 生年月日 {
            get { return _生年月日; }
            set {
                __modifiedProperties.AddPropertyName("生年月日");
                _生年月日 = value;
            }
        }

        /// <summary>入社年月日: {NotNull, timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("入社年月日")]
        public DateTime? 入社年月日 {
            get { return _入社年月日; }
            set {
                __modifiedProperties.AddPropertyName("入社年月日");
                _入社年月日 = value;
            }
        }

        /// <summary>退社年月日: {timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("退社年月日")]
        public DateTime? 退社年月日 {
            get { return _退社年月日; }
            set {
                __modifiedProperties.AddPropertyName("退社年月日");
                _退社年月日 = value;
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

        /// <summary>最終ログイン日時: {timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("最終ログイン日時")]
        public DateTime? 最終ログイン日時 {
            get { return _最終ログイン日時; }
            set {
                __modifiedProperties.AddPropertyName("最終ログイン日時");
                _最終ログイン日時 = value;
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
