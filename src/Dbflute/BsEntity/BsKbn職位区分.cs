

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
    /// The entity of kbn職位区分 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     code
    /// 
    /// [column]
    ///     code, 名称, 名称_英字
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
    ///     dch従業員職位履歴台帳, mst従業員マスタ, mst権限マスタ
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     dch従業員職位履歴台帳List, mst従業員マスタList, mst権限マスタList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("kbn職位区分")]
    [System.Serializable]
    public partial class Kbn職位区分 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>code: {PK, NotNull, bpchar(3), classification=職位区分}</summary>
        protected String _code;

        /// <summary>名称: {NotNull, varchar(20)}</summary>
        protected String _名称;

        /// <summary>名称_英字: {NotNull, varchar(20)}</summary>
        protected String _名称英字;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "kbn職位区分"; } }
        public String TablePropertyName { get { return "Kbn職位区分"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                         Classification Property
        //                                                         =======================
        #region Classification Property
        public CDef.職位区分 CodeAs職位区分 { get {
            return CDef.職位区分.CodeOf(_code);
        } set {
            Code = value != null ? value.Code : null;
        }}

        #endregion

        // ===============================================================================
        //                                                          Classification Setting
        //                                                          ======================
        #region Classification Setting
        /// <summary>
        /// Set the value of code as システム保守.
        /// <![CDATA[
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public void SetCode_システム保守() {
            CodeAs職位区分 = CDef.職位区分.システム保守;
        }

        /// <summary>
        /// Set the value of code as アシスタントマネージャー.
        /// <![CDATA[
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public void SetCode_アシスタントマネージャー() {
            CodeAs職位区分 = CDef.職位区分.アシスタントマネージャー;
        }

        /// <summary>
        /// Set the value of code as ファイナンシャルコントローラー.
        /// <![CDATA[
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public void SetCode_ファイナンシャルコントローラー() {
            CodeAs職位区分 = CDef.職位区分.ファイナンシャルコントローラー;
        }

        /// <summary>
        /// Set the value of code as フロントクラーク.
        /// <![CDATA[
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public void SetCode_フロントクラーク() {
            CodeAs職位区分 = CDef.職位区分.フロントクラーク;
        }

        #endregion

        // ===============================================================================
        //                                                    Classification Determination
        //                                                    ============================
        #region Classification Determination
        /// <summary>
        /// Is the value of code 'システム保守'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// システム保守: System Maintenancer
        /// ]]>
        /// </summary>
        public bool IsCodeシステム保守 {
            get {
                CDef.職位区分 cls = CodeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.システム保守) : false;
            }
        }

        /// <summary>
        /// Is the value of code 'アシスタントマネージャー'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// アシスタントマネージャー: Assistant Manager
        /// ]]>
        /// </summary>
        public bool IsCodeアシスタントマネージャー {
            get {
                CDef.職位区分 cls = CodeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.アシスタントマネージャー) : false;
            }
        }

        /// <summary>
        /// Is the value of code 'ファイナンシャルコントローラー'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// ファイナンシャルコントローラー: Financial Controller
        /// ]]>
        /// </summary>
        public bool IsCodeファイナンシャルコントローラー {
            get {
                CDef.職位区分 cls = CodeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.ファイナンシャルコントローラー) : false;
            }
        }

        /// <summary>
        /// Is the value of code 'フロントクラーク'?
        /// <![CDATA[
        /// The difference of capital letters and small letters is NOT distinguished.
        /// If the value is null, this method returns false!
        /// フロントクラーク: Front Clerk
        /// ]]>
        /// </summary>
        public bool IsCodeフロントクラーク {
            get {
                CDef.職位区分 cls = CodeAs職位区分;
                return cls != null ? cls.Equals(CDef.職位区分.フロントクラーク) : false;
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
        protected IList<Dch従業員職位履歴台帳> _dch従業員職位履歴台帳List;

        /// <summary>dch従業員職位履歴台帳 as 'Dch従業員職位履歴台帳List'.</summary>
        public IList<Dch従業員職位履歴台帳> Dch従業員職位履歴台帳List {
            get { if (_dch従業員職位履歴台帳List == null) { _dch従業員職位履歴台帳List = new List<Dch従業員職位履歴台帳>(); } return _dch従業員職位履歴台帳List; }
            set { _dch従業員職位履歴台帳List = value; }
        }

        protected IList<Mst従業員マスタ> _mst従業員マスタList;

        /// <summary>mst従業員マスタ as 'Mst従業員マスタList'.</summary>
        public IList<Mst従業員マスタ> Mst従業員マスタList {
            get { if (_mst従業員マスタList == null) { _mst従業員マスタList = new List<Mst従業員マスタ>(); } return _mst従業員マスタList; }
            set { _mst従業員マスタList = value; }
        }

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
                if (_code == null) { return false; }
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
            if (other == null || !(other is Kbn職位区分)) { return false; }
            Kbn職位区分 otherEntity = (Kbn職位区分)other;
            if (!xSV(this.Code, otherEntity.Code)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _code);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Kbn職位区分:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_dch従業員職位履歴台帳List != null) { foreach (Entity e in _dch従業員職位履歴台帳List)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Dch従業員職位履歴台帳List")); } } }
            if (_mst従業員マスタList != null) { foreach (Entity e in _mst従業員マスタList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Mst従業員マスタList")); } } }
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
            sb.Append(c).Append(this.Code);
            sb.Append(c).Append(this.名称);
            sb.Append(c).Append(this.名称英字);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_dch従業員職位履歴台帳List != null && _dch従業員職位履歴台帳List.Count > 0)
            { sb.Append(c).Append("Dch従業員職位履歴台帳List"); }
            if (_mst従業員マスタList != null && _mst従業員マスタList.Count > 0)
            { sb.Append(c).Append("Mst従業員マスタList"); }
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
        /// <summary>code: {PK, NotNull, bpchar(3), classification=職位区分}</summary>
        [Seasar.Dao.Attrs.Column("code")]
        public String Code {
            get { return _code; }
            set {
                __modifiedProperties.AddPropertyName("Code");
                _code = value;
            }
        }

        /// <summary>名称: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("名称")]
        public String 名称 {
            get { return _名称; }
            set {
                __modifiedProperties.AddPropertyName("名称");
                _名称 = value;
            }
        }

        /// <summary>名称_英字: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("名称_英字")]
        public String 名称英字 {
            get { return _名称英字; }
            set {
                __modifiedProperties.AddPropertyName("名称英字");
                _名称英字 = value;
            }
        }

        #endregion
    }
}
