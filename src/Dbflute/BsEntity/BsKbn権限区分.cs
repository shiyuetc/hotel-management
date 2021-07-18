

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
    /// The entity of kbn権限区分 as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     コード
    /// 
    /// [column]
    ///     コード, 名称
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
    ///     mst権限マスタ
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     mst権限マスタList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("kbn権限区分")]
    [System.Serializable]
    public partial class Kbn権限区分 : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>コード: {PK, NotNull, bpchar(3)}</summary>
        protected String _コード;

        /// <summary>名称: {NotNull, varchar(20)}</summary>
        protected String _名称;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "kbn権限区分"; } }
        public String TablePropertyName { get { return "Kbn権限区分"; } }

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
                if (_コード == null) { return false; }
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
            if (other == null || !(other is Kbn権限区分)) { return false; }
            Kbn権限区分 otherEntity = (Kbn権限区分)other;
            if (!xSV(this.コード, otherEntity.コード)) { return false; }
            return true;
        }
        protected bool xSV(Object value1, Object value2) { // isSameValue()
            if (value1 == null && value2 == null) { return true; }
            if (value1 == null || value2 == null) { return false; }
            return value1.Equals(value2);
        }

        public override int GetHashCode() {
            int result = 17;
            result = xCH(result, _コード);
            return result;
        }
        protected int xCH(int result, Object value) { // calculateHashcode()
            if (value == null) { return result; }
            return (31*result) + (value is byte[] ? ((byte[])value).Length : value.GetHashCode());
        }

        public override String ToString() {
            return "Kbn権限区分:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
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
            sb.Append(c).Append(this.コード);
            sb.Append(c).Append(this.名称);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
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
        /// <summary>コード: {PK, NotNull, bpchar(3)}</summary>
        [Seasar.Dao.Attrs.Column("コード")]
        public String コード {
            get { return _コード; }
            set {
                __modifiedProperties.AddPropertyName("コード");
                _コード = value;
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

        #endregion
    }
}
