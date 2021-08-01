

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
    /// The entity of mst客室タイプマスタ as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// 客室タイプマスタ
    /// 
    /// [primary-key]
    ///     客室タイプコード
    /// 
    /// [column]
    ///     客室タイプコード, 客室タイプ名称, 料金, 宿泊人数, 備考
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
    ///     mst客室マスタ
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     mst客室マスタList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("mst客室タイプマスタ")]
    [System.Serializable]
    public partial class Mst客室タイプマスタ : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>客室タイプコード: {PK, NotNull, bpchar(4)}</summary>
        protected String _客室タイプコード;

        /// <summary>客室タイプ名称: {NotNull, varchar(20)}</summary>
        protected String _客室タイプ名称;

        /// <summary>料金: {NotNull, int4(10)}</summary>
        protected int? _料金;

        /// <summary>宿泊人数: {NotNull, int4(10)}</summary>
        protected int? _宿泊人数;

        /// <summary>備考: {varchar(255)}</summary>
        protected String _備考;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "mst客室タイプマスタ"; } }
        public String TablePropertyName { get { return "Mst客室タイプマスタ"; } }

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
        protected IList<Mst客室マスタ> _mst客室マスタList;

        /// <summary>mst客室マスタ as 'Mst客室マスタList'.</summary>
        public IList<Mst客室マスタ> Mst客室マスタList {
            get { if (_mst客室マスタList == null) { _mst客室マスタList = new List<Mst客室マスタ>(); } return _mst客室マスタList; }
            set { _mst客室マスタList = value; }
        }

        #endregion

        // ===============================================================================
        //                                                                   Determination
        //                                                                   =============
        public virtual bool HasPrimaryKeyValue {
            get {
                if (_客室タイプコード == null) { return false; }
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
            if (other == null || !(other is Mst客室タイプマスタ)) { return false; }
            Mst客室タイプマスタ otherEntity = (Mst客室タイプマスタ)other;
            if (!xSV(this.客室タイプコード, otherEntity.客室タイプコード)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _客室タイプコード);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Mst客室タイプマスタ:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_mst客室マスタList != null) { foreach (Entity e in _mst客室マスタList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Mst客室マスタList")); } } }
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
            sb.Append(c).Append(this.客室タイプコード);
            sb.Append(c).Append(this.客室タイプ名称);
            sb.Append(c).Append(this.料金);
            sb.Append(c).Append(this.宿泊人数);
            sb.Append(c).Append(this.備考);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_mst客室マスタList != null && _mst客室マスタList.Count > 0)
            { sb.Append(c).Append("Mst客室マスタList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>客室タイプコード: {PK, NotNull, bpchar(4)}</summary>
        /// <remarks>
        /// 客室タイプコード
        /// </remarks>
        [Seasar.Dao.Attrs.Column("客室タイプコード")]
        public String 客室タイプコード {
            get { return _客室タイプコード; }
            set {
                __modifiedProperties.AddPropertyName("客室タイプコード");
                _客室タイプコード = value;
            }
        }

        /// <summary>客室タイプ名称: {NotNull, varchar(20)}</summary>
        /// <remarks>
        /// 客室タイプ名称
        /// </remarks>
        [Seasar.Dao.Attrs.Column("客室タイプ名称")]
        public String 客室タイプ名称 {
            get { return _客室タイプ名称; }
            set {
                __modifiedProperties.AddPropertyName("客室タイプ名称");
                _客室タイプ名称 = value;
            }
        }

        /// <summary>料金: {NotNull, int4(10)}</summary>
        /// <remarks>
        /// 料金
        /// </remarks>
        [Seasar.Dao.Attrs.Column("料金")]
        public int? 料金 {
            get { return _料金; }
            set {
                __modifiedProperties.AddPropertyName("料金");
                _料金 = value;
            }
        }

        /// <summary>宿泊人数: {NotNull, int4(10)}</summary>
        /// <remarks>
        /// 宿泊人数
        /// </remarks>
        [Seasar.Dao.Attrs.Column("宿泊人数")]
        public int? 宿泊人数 {
            get { return _宿泊人数; }
            set {
                __modifiedProperties.AddPropertyName("宿泊人数");
                _宿泊人数 = value;
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
