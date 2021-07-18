

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
    /// The entity of mst会員マスタ as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, 会員番号, 氏名_姓, 氏名_名, 氏名_カナ, 会社名, 会社名_カナ, 電話番号, メールアドレス, 入会年月日, 退会年月日, 備考
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
    [Seasar.Dao.Attrs.Table("mst会員マスタ")]
    [System.Serializable]
    public partial class Mst会員マスタ : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        protected long? _id;

        /// <summary>会員番号: {UQ, NotNull, varchar(9)}</summary>
        protected String _会員番号;

        /// <summary>氏名_姓: {NotNull, varchar(20)}</summary>
        protected String _氏名姓;

        /// <summary>氏名_名: {NotNull, varchar(20)}</summary>
        protected String _氏名名;

        /// <summary>氏名_カナ: {NotNull, varchar(50)}</summary>
        protected String _氏名カナ;

        /// <summary>会社名: {varchar(50)}</summary>
        protected String _会社名;

        /// <summary>会社名_カナ: {varchar(50)}</summary>
        protected String _会社名カナ;

        /// <summary>電話番号: {varchar(20)}</summary>
        protected String _電話番号;

        /// <summary>メールアドレス: {varchar(255)}</summary>
        protected String _メールアドレス;

        /// <summary>入会年月日: {NotNull, timestamp(26, 3)}</summary>
        protected DateTime? _入会年月日;

        /// <summary>退会年月日: {timestamp(26, 3)}</summary>
        protected DateTime? _退会年月日;

        /// <summary>備考: {varchar(255)}</summary>
        protected String _備考;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst会員マスタ"; } }
        public String TablePropertyName { get { return "Mst会員マスタ"; } }

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
            if (other == null || !(other is Mst会員マスタ)) { return false; }
            Mst会員マスタ otherEntity = (Mst会員マスタ)other;
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
            return "Mst会員マスタ:" + BuildColumnString() + BuildRelationString();
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
            sb.Append(c).Append(this.会員番号);
            sb.Append(c).Append(this.氏名姓);
            sb.Append(c).Append(this.氏名名);
            sb.Append(c).Append(this.氏名カナ);
            sb.Append(c).Append(this.会社名);
            sb.Append(c).Append(this.会社名カナ);
            sb.Append(c).Append(this.電話番号);
            sb.Append(c).Append(this.メールアドレス);
            sb.Append(c).Append(this.入会年月日);
            sb.Append(c).Append(this.退会年月日);
            sb.Append(c).Append(this.備考);
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

        /// <summary>会員番号: {UQ, NotNull, varchar(9)}</summary>
        [Seasar.Dao.Attrs.Column("会員番号")]
        public String 会員番号 {
            get { return _会員番号; }
            set {
                __modifiedProperties.AddPropertyName("会員番号");
                _会員番号 = value;
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

        /// <summary>会社名: {varchar(50)}</summary>
        [Seasar.Dao.Attrs.Column("会社名")]
        public String 会社名 {
            get { return _会社名; }
            set {
                __modifiedProperties.AddPropertyName("会社名");
                _会社名 = value;
            }
        }

        /// <summary>会社名_カナ: {varchar(50)}</summary>
        [Seasar.Dao.Attrs.Column("会社名_カナ")]
        public String 会社名カナ {
            get { return _会社名カナ; }
            set {
                __modifiedProperties.AddPropertyName("会社名カナ");
                _会社名カナ = value;
            }
        }

        /// <summary>電話番号: {varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("電話番号")]
        public String 電話番号 {
            get { return _電話番号; }
            set {
                __modifiedProperties.AddPropertyName("電話番号");
                _電話番号 = value;
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

        /// <summary>入会年月日: {NotNull, timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("入会年月日")]
        public DateTime? 入会年月日 {
            get { return _入会年月日; }
            set {
                __modifiedProperties.AddPropertyName("入会年月日");
                _入会年月日 = value;
            }
        }

        /// <summary>退会年月日: {timestamp(26, 3)}</summary>
        [Seasar.Dao.Attrs.Column("退会年月日")]
        public DateTime? 退会年月日 {
            get { return _退会年月日; }
            set {
                __modifiedProperties.AddPropertyName("退会年月日");
                _退会年月日 = value;
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
