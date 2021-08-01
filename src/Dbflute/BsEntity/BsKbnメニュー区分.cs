

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
    /// The entity of kbnメニュー区分 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// メニュー区分
    /// 
    /// [primary-key]
    ///     メニューコード
    /// 
    /// [column]
    ///     メニューコード, メニュー名称, 優先順位
    /// 
    /// [sequence]
    ///     
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
    ///     mst画面マスタ
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     mst画面マスタList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("kbnメニュー区分")]
    [System.Serializable]
    public partial class Kbnメニュー区分 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>メニューコード: {PK, NotNull, bpchar(2), classification=メニュー区分}</summary>
        protected String _メニューコード;

        /// <summary>メニュー名称: {NotNull, varchar(20)}</summary>
        protected String _メニュー名称;

        /// <summary>優先順位: {NotNull, int4(10)}</summary>
        protected int? _優先順位;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "kbnメニュー区分"; } }
        public String TablePropertyName { get { return "Kbnメニュー区分"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.メニュー区分 メニューコードAsメニュー区分 { get {
            return CDef.メニュー区分.CodeOf(_メニューコード);
        } set {
            メニューコード = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of メニューコード as ログアウト.
        /// <![CDATA[
        /// ログアウト: 9999
        /// ]]>
        /// </summary>
        public void Setメニューコード_ログアウト() {
            メニューコードAsメニュー区分 = CDef.メニュー区分.ログアウト;
        }

        /// <summary>
        /// Set the value of メニューコード as 予約管理.
        /// <![CDATA[
        /// 予約管理: 10
        /// ]]>
        /// </summary>
        public void Setメニューコード_予約管理() {
            メニューコードAsメニュー区分 = CDef.メニュー区分.予約管理;
        }

        /// <summary>
        /// Set the value of メニューコード as 宿泊履歴.
        /// <![CDATA[
        /// 宿泊履歴: 20
        /// ]]>
        /// </summary>
        public void Setメニューコード_宿泊履歴() {
            メニューコードAsメニュー区分 = CDef.メニュー区分.宿泊履歴;
        }

        /// <summary>
        /// Set the value of メニューコード as 顧客管理.
        /// <![CDATA[
        /// 顧客管理: 30
        /// ]]>
        /// </summary>
        public void Setメニューコード_顧客管理() {
            メニューコードAsメニュー区分 = CDef.メニュー区分.顧客管理;
        }

        /// <summary>
        /// Set the value of メニューコード as 従業員管理.
        /// <![CDATA[
        /// 従業員管理: 40
        /// ]]>
        /// </summary>
        public void Setメニューコード_従業員管理() {
            メニューコードAsメニュー区分 = CDef.メニュー区分.従業員管理;
        }

        /// <summary>
        /// Set the value of メニューコード as 客室管理.
        /// <![CDATA[
        /// 客室管理: 50
        /// ]]>
        /// </summary>
        public void Setメニューコード_客室管理() {
            メニューコードAsメニュー区分 = CDef.メニュー区分.客室管理;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of メニューコード 'ログアウト'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// ログアウト: 9999
        /// ]]>
        /// </summary>
        public bool Isメニューコードログアウト {
            get {
                CDef.メニュー区分 cls = メニューコードAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.ログアウト) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューコード '予約管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 予約管理: 10
        /// ]]>
        /// </summary>
        public bool Isメニューコード予約管理 {
            get {
                CDef.メニュー区分 cls = メニューコードAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.予約管理) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューコード '宿泊履歴'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 宿泊履歴: 20
        /// ]]>
        /// </summary>
        public bool Isメニューコード宿泊履歴 {
            get {
                CDef.メニュー区分 cls = メニューコードAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.宿泊履歴) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューコード '顧客管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 顧客管理: 30
        /// ]]>
        /// </summary>
        public bool Isメニューコード顧客管理 {
            get {
                CDef.メニュー区分 cls = メニューコードAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.顧客管理) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューコード '従業員管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 従業員管理: 40
        /// ]]>
        /// </summary>
        public bool Isメニューコード従業員管理 {
            get {
                CDef.メニュー区分 cls = メニューコードAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.従業員管理) : false;
            }
        }

        /// <summary>
        /// Is the value of メニューコード '客室管理'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// 客室管理: 50
        /// ]]>
        /// </summary>
        public bool Isメニューコード客室管理 {
            get {
                CDef.メニュー区分 cls = メニューコードAsメニュー区分;
                return cls != null ? cls.Equals(CDef.メニュー区分.客室管理) : false;
            }
        }

        #endregion

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<Mst画面マスタ> _mst画面マスタList;

        /// <summary>mst画面マスタ as 'Mst画面マスタList'.</summary>
        public IList<Mst画面マスタ> Mst画面マスタList {
            get { if (_mst画面マスタList == null) { _mst画面マスタList = new List<Mst画面マスタ>(); } return _mst画面マスタList; }
            set { _mst画面マスタList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_メニューコード == null) { return false; }
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
            if (other == null || !(other is Kbnメニュー区分)) { return false; }
            Kbnメニュー区分 otherEntity = (Kbnメニュー区分)other;
            if (!xSV(this.メニューコード, otherEntity.メニューコード)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _メニューコード);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Kbnメニュー区分:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_mst画面マスタList != null) { foreach (Entity e in _mst画面マスタList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Mst画面マスタList")); } } }
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
            sb.Append(c).Append(this.メニューコード);
            sb.Append(c).Append(this.メニュー名称);
            sb.Append(c).Append(this.優先順位);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_mst画面マスタList != null && _mst画面マスタList.Count > 0)
            { sb.Append(c).Append("Mst画面マスタList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>メニューコード: {PK, NotNull, bpchar(2), classification=メニュー区分}</summary>
        /// <remarks>
        /// メニューコード
        /// </remarks>
        [Seasar.Dao.Attrs.Column("メニューコード")]
        public String メニューコード {
            get { return _メニューコード; }
            set {
                __modifiedProperties.AddPropertyName("メニューコード");
                _メニューコード = value;
            }
        }

        /// <summary>メニュー名称: {NotNull, varchar(20)}</summary>
        /// <remarks>
        /// メニュー名称
        /// </remarks>
        [Seasar.Dao.Attrs.Column("メニュー名称")]
        public String メニュー名称 {
            get { return _メニュー名称; }
            set {
                __modifiedProperties.AddPropertyName("メニュー名称");
                _メニュー名称 = value;
            }
        }

        /// <summary>優先順位: {NotNull, int4(10)}</summary>
        /// <remarks>
        /// 優先順位
        /// </remarks>
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
