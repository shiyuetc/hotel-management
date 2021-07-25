

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
    /// The entity of mst制御画面マスタ as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     id
    /// 
    /// [column]
    ///     id, メニューcode, 画面名, 表示名, 優先順位
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
    ///     kbnメニュー区分
    /// 
    /// [referrer-table]
    ///     mst権限マスタ
    /// 
    /// [foreign-property]
    ///     kbnメニュー区分
    /// 
    /// [referrer-property]
    ///     mst権限マスタList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("mst制御画面マスタ")]
    [System.Serializable]
    public partial class Mst制御画面マスタ : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>id: {PK, ID, NotNull, bigserial(19)}</summary>
        protected long? _id;

        /// <summary>メニューcode: {NotNull, bpchar(3), FK to kbnメニュー区分, classification=メニュー区分}</summary>
        protected String _メニューcode;

        /// <summary>画面名: {NotNull, varchar(20)}</summary>
        protected String _画面名;

        /// <summary>表示名: {NotNull, varchar(20)}</summary>
        protected String _表示名;

        /// <summary>優先順位: {NotNull, int4(10)}</summary>
        protected int? _優先順位;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst制御画面マスタ"; } }
        public String TablePropertyName { get { return "Mst制御画面マスタ"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.メニュー区分 メニューcodeAsメニュー区分 { get {
            return CDef.メニュー区分.CodeOf(_メニューcode);
        } set {
            メニューcode = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of メニューcode as ログアウト.
        /// <![CDATA[
        /// ログアウト: 9999
        /// ]]>
        /// </summary>
        public void Setメニューcode_ログアウト() {
            メニューcodeAsメニュー区分 = CDef.メニュー区分.ログアウト;
        }

        /// <summary>
        /// Set the value of メニューcode as 予約管理.
        /// <![CDATA[
        /// 予約管理: 10
        /// ]]>
        /// </summary>
        public void Setメニューcode_予約管理() {
            メニューcodeAsメニュー区分 = CDef.メニュー区分.予約管理;
        }

        /// <summary>
        /// Set the value of メニューcode as 宿泊履歴.
        /// <![CDATA[
        /// 宿泊履歴: 20
        /// ]]>
        /// </summary>
        public void Setメニューcode_宿泊履歴() {
            メニューcodeAsメニュー区分 = CDef.メニュー区分.宿泊履歴;
        }

        /// <summary>
        /// Set the value of メニューcode as 顧客管理.
        /// <![CDATA[
        /// 顧客管理: 30
        /// ]]>
        /// </summary>
        public void Setメニューcode_顧客管理() {
            メニューcodeAsメニュー区分 = CDef.メニュー区分.顧客管理;
        }

        /// <summary>
        /// Set the value of メニューcode as 従業員管理.
        /// <![CDATA[
        /// 従業員管理: 40
        /// ]]>
        /// </summary>
        public void Setメニューcode_従業員管理() {
            メニューcodeAsメニュー区分 = CDef.メニュー区分.従業員管理;
        }

        /// <summary>
        /// Set the value of メニューcode as 客室管理.
        /// <![CDATA[
        /// 客室管理: 50
        /// ]]>
        /// </summary>
        public void Setメニューcode_客室管理() {
            メニューcodeAsメニュー区分 = CDef.メニュー区分.客室管理;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of メニューcode 'ログアウト'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// ログアウト: 9999
        /// ]]>
        /// </summary>
        public bool Isメニューcodeログアウト {
            get {
                CDef.メニュー区分 cls = メニューcodeAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.ログアウト) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューcode '予約管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 予約管理: 10
        /// ]]>
        /// </summary>
        public bool Isメニューcode予約管理 {
            get {
                CDef.メニュー区分 cls = メニューcodeAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.予約管理) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューcode '宿泊履歴'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 宿泊履歴: 20
        /// ]]>
        /// </summary>
        public bool Isメニューcode宿泊履歴 {
            get {
                CDef.メニュー区分 cls = メニューcodeAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.宿泊履歴) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューcode '顧客管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 顧客管理: 30
        /// ]]>
        /// </summary>
        public bool Isメニューcode顧客管理 {
            get {
                CDef.メニュー区分 cls = メニューcodeAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.顧客管理) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューcode '従業員管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 従業員管理: 40
        /// ]]>
        /// </summary>
        public bool Isメニューcode従業員管理 {
            get {
                CDef.メニュー区分 cls = メニューcodeAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.従業員管理) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューcode '客室管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 客室管理: 50
        /// ]]>
        /// </summary>
        public bool Isメニューcode客室管理 {
            get {
                CDef.メニュー区分 cls = メニューcodeAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.客室管理) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Kbnメニュー区分 _kbnメニュー区分;

        /// <summary>kbnメニュー区分 as 'Kbnメニュー区分'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("メニューcode:code")]
        public Kbnメニュー区分 Kbnメニュー区分 {
            get { return _kbnメニュー区分; }
            set { _kbnメニュー区分 = value; }
        }

        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<Mst権限マスタ> _mst権限マスタList;

        /// <summary>mst権限マスタ as 'Mst権限マスタList'.</summary>
        public IList<Mst権限マスタ> Mst権限マスタList {
            get { if (_mst権限マスタList == null) { _mst権限マスタList = new List<Mst権限マスタ>(); } return _mst権限マスタList; }
            set { _mst権限マスタList = value; }
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
            if (other == null || !(other is Mst制御画面マスタ)) { return false; }
            Mst制御画面マスタ otherEntity = (Mst制御画面マスタ)other;
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
            return "Mst制御画面マスタ:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_kbnメニュー区分 != null)
            { sb.Append(l).Append(xbRDS(_kbnメニュー区分, "Kbnメニュー区分")); }
            if (_mst権限マスタList != null) { foreach (Entity e in _mst権限マスタList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Mst権限マスタList")); } } }
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
            sb.Append(c).Append(this.メニューcode);
            sb.Append(c).Append(this.画面名);
            sb.Append(c).Append(this.表示名);
            sb.Append(c).Append(this.優先順位);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_kbnメニュー区分 != null) { sb.Append(c).Append("Kbnメニュー区分"); }
            if (_mst権限マスタList != null && _mst権限マスタList.Count > 0)
            { sb.Append(c).Append("Mst権限マスタList"); }
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

        /// <summary>メニューcode: {NotNull, bpchar(3), FK to kbnメニュー区分, classification=メニュー区分}</summary>
        [Seasar.Dao.Attrs.Column("メニューcode")]
        public String メニューcode {
            get { return _メニューcode; }
            set {
                __modifiedProperties.AddPropertyName("メニューcode");
                _メニューcode = value;
            }
        }

        /// <summary>画面名: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("画面名")]
        public String 画面名 {
            get { return _画面名; }
            set {
                __modifiedProperties.AddPropertyName("画面名");
                _画面名 = value;
            }
        }

        /// <summary>表示名: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("表示名")]
        public String 表示名 {
            get { return _表示名; }
            set {
                __modifiedProperties.AddPropertyName("表示名");
                _表示名 = value;
            }
        }

        /// <summary>優先順位: {NotNull, int4(10)}</summary>
        [Seasar.Dao.Attrs.Column("優先順位")]
        public int? 優先順位 {
            get { return _優先順位; }
            set {
                __modifiedProperties.AddPropertyName("優先順位");
                _優先順位 = value;
            }
        }

        #endregion
    }
}
