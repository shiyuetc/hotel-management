

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
    /// The entity of dch宿泊利用台帳 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// 客室利用台帳
    /// 
    /// [primary-key]
    ///     客室利用台帳id
    /// 
    /// [column]
    ///     客室利用台帳id, 会員コード, 宿泊料金
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
    ///     mst会員マスタ, dch客室利用台帳
    /// 
    /// [referrer-table]
    ///     
    /// 
    /// [foreign-property]
    ///     mst会員マスタ, dch客室利用台帳
    /// 
    /// [referrer-property]
    ///     
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("dch宿泊利用台帳")]
    [System.Serializable]
    public partial class Dch宿泊利用台帳 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>客室利用台帳id: {PK, NotNull, int8(19), FK to dch客室利用台帳}</summary>
        protected long? _客室利用台帳id;

        /// <summary>会員コード: {NotNull, bpchar(10), FK to mst会員マスタ}</summary>
        protected String _会員コード;

        /// <summary>宿泊料金: {NotNull, int4(10)}</summary>
        protected int? _宿泊料金;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "dch宿泊利用台帳"; } }
        public String TablePropertyName { get { return "Dch宿泊利用台帳"; } }

        // ===============================================================================
        //                                                                          DBMeta
        //                                                                          ======
        public DBMeta DBMeta { get { return DBMetaInstanceHandler.FindDBMeta(TableDbName); } }

        // ===============================================================================
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        protected Mst会員マスタ _mst会員マスタ;

        /// <summary>mst会員マスタ as 'Mst会員マスタ'.</summary>
        [Seasar.Dao.Attrs.Relno(0), Seasar.Dao.Attrs.Relkeys("会員コード:会員コード")]
        public Mst会員マスタ Mst会員マスタ {
            get { return _mst会員マスタ; }
            set { _mst会員マスタ = value; }
        }

        protected Dch客室利用台帳 _dch客室利用台帳;

        /// <summary>dch客室利用台帳 as 'Dch客室利用台帳'.</summary>
        [Seasar.Dao.Attrs.Relno(1), Seasar.Dao.Attrs.Relkeys("客室利用台帳id:id")]
        public Dch客室利用台帳 Dch客室利用台帳 {
            get { return _dch客室利用台帳; }
            set { _dch客室利用台帳 = value; }
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
                if (_客室利用台帳id == null) { return false; }
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
            if (other == null || !(other is Dch宿泊利用台帳)) { return false; }
            Dch宿泊利用台帳 otherEntity = (Dch宿泊利用台帳)other;
            if (!xSV(this.客室利用台帳id, otherEntity.客室利用台帳id)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _客室利用台帳id);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Dch宿泊利用台帳:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_mst会員マスタ != null)
            { sb.Append(l).Append(xbRDS(_mst会員マスタ, "Mst会員マスタ")); }
            if (_dch客室利用台帳 != null)
            { sb.Append(l).Append(xbRDS(_dch客室利用台帳, "Dch客室利用台帳")); }
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
            sb.Append(c).Append(this.客室利用台帳id);
            sb.Append(c).Append(this.会員コード);
            sb.Append(c).Append(this.宿泊料金);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_mst会員マスタ != null) { sb.Append(c).Append("Mst会員マスタ"); }
            if (_dch客室利用台帳 != null) { sb.Append(c).Append("Dch客室利用台帳"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>客室利用台帳id: {PK, NotNull, int8(19), FK to dch客室利用台帳}</summary>
        /// <remarks>
        /// 客室利用台帳ID
        /// </remarks>
        [Seasar.Dao.Attrs.Column("客室利用台帳id")]
        public long? 客室利用台帳id {
            get { return _客室利用台帳id; }
            set {
                __modifiedProperties.AddPropertyName("客室利用台帳id");
                _客室利用台帳id = value;
            }
        }

        /// <summary>会員コード: {NotNull, bpchar(10), FK to mst会員マスタ}</summary>
        /// <remarks>
        /// 会員コード
        /// </remarks>
        [Seasar.Dao.Attrs.Column("会員コード")]
        public String 会員コード {
            get { return _会員コード; }
            set {
                __modifiedProperties.AddPropertyName("会員コード");
                _会員コード = value;
            }
        }

        /// <summary>宿泊料金: {NotNull, int4(10)}</summary>
        /// <remarks>
        /// 宿泊料金
        /// </remarks>
        [Seasar.Dao.Attrs.Column("宿泊料金")]
        public int? 宿泊料金 {
            get { return _宿泊料金; }
            set {
                __modifiedProperties.AddPropertyName("宿泊料金");
                _宿泊料金 = value;
            }
        }

        #endregion
    }
}
