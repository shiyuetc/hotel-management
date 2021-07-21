

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
    ///     id, 画面名, 表示名, 優先順位
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
    ///     
    /// 
    /// [referrer-table]
    ///     mstメニュー権限マスタ
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     mstメニュー権限マスタList
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
        //                                                                Foreign Property
        //                                                                ================
        #region Foreign Property
        #endregion

        // ===============================================================================
        //                                                               Referrer Property
        //                                                               =================
        #region Referrer Property
        protected IList<Mstメニュー権限マスタ> _mstメニュー権限マスタList;

        /// <summary>mstメニュー権限マスタ as 'Mstメニュー権限マスタList'.</summary>
        public IList<Mstメニュー権限マスタ> Mstメニュー権限マスタList {
            get { if (_mstメニュー権限マスタList == null) { _mstメニュー権限マスタList = new List<Mstメニュー権限マスタ>(); } return _mstメニュー権限マスタList; }
            set { _mstメニュー権限マスタList = value; }
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
            if (_mstメニュー権限マスタList != null) { foreach (Entity e in _mstメニュー権限マスタList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "Mstメニュー権限マスタList")); } } }
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
            if (_mstメニュー権限マスタList != null && _mstメニュー権限マスタList.Count > 0)
            { sb.Append(c).Append("Mstメニュー権限マスタList"); }
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
