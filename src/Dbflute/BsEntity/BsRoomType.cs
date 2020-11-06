

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
    /// The entity of room_type as TABLE. (partial class for auto-generation)
    /// <![CDATA[
    /// [primary-key]
    ///     code
    /// 
    /// [column]
    ///     code, name, price, capacity, description
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
    ///     room
    /// 
    /// [foreign-property]
    ///     
    /// 
    /// [referrer-property]
    ///     roomList
    /// ]]>
    /// Author: DBFlute(AutoGenerator)
    /// </summary>
    [Seasar.Dao.Attrs.Table("room_type")]
    [System.Serializable]
    public partial class RoomType : Entity {

        // ===============================================================================
        //                                                                       Attribute
        //                                                                       =========
        #region Attribute
        /// <summary>code: {PK, NotNull, bpchar(3)}</summary>
        protected String _code;

        /// <summary>name: {NotNull, varchar(20)}</summary>
        protected String _name;

        /// <summary>price: {int4(10), default=[0]}</summary>
        protected int? _price;

        /// <summary>capacity: {int4(10), default=[1]}</summary>
        protected int? _capacity;

        /// <summary>description: {NotNull, varchar(255)}</summary>
        protected String _description;

        protected EntityModifiedProperties __modifiedProperties = new EntityModifiedProperties();
        #endregion

        // ===============================================================================
        //                                                                      Table Name
        //                                                                      ==========
        public String TableDbName { get { return "room_type"; } }
        public String TablePropertyName { get { return "RoomType"; } }

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
        protected IList<Room> _roomList;

        /// <summary>room as 'RoomList'.</summary>
        public IList<Room> RoomList {
            get { if (_roomList == null) { _roomList = new List<Room>(); } return _roomList; }
            set { _roomList = value; }
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
            if (other == null || !(other is RoomType)) { return false; }
            RoomType otherEntity = (RoomType)other;
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
            return "RoomType:" + BuildColumnString() + BuildRelationString();
        }

        public virtual String ToStringWithRelation() {
            StringBuilder sb = new StringBuilder();
            sb.Append(ToString());
            String l = "\n  ";
            if (_roomList != null) { foreach (Entity e in _roomList)
            { if (e != null) { sb.Append(l).Append(xbRDS(e, "RoomList")); } } }
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
            sb.Append(c).Append(this.Name);
            sb.Append(c).Append(this.Price);
            sb.Append(c).Append(this.Capacity);
            sb.Append(c).Append(this.Description);
            if (sb.Length > 0) { sb.Remove(0, c.Length); }
            sb.Insert(0, "{").Append("}");
            return sb.ToString();
        }
        protected virtual String BuildRelationString() {
            StringBuilder sb = new StringBuilder();
            String c = ",";
            if (_roomList != null && _roomList.Count > 0)
            { sb.Append(c).Append("RoomList"); }
            if (sb.Length > 0) { sb.Remove(0, c.Length).Insert(0, "(").Append(")"); }
            return sb.ToString();
        }
        #endregion

        // ===============================================================================
        //                                                                        Accessor
        //                                                                        ========
        #region Accessor
        /// <summary>code: {PK, NotNull, bpchar(3)}</summary>
        [Seasar.Dao.Attrs.Column("code")]
        public String Code {
            get { return _code; }
            set {
                __modifiedProperties.AddPropertyName("Code");
                _code = value;
            }
        }

        /// <summary>name: {NotNull, varchar(20)}</summary>
        [Seasar.Dao.Attrs.Column("name")]
        public String Name {
            get { return _name; }
            set {
                __modifiedProperties.AddPropertyName("Name");
                _name = value;
            }
        }

        /// <summary>price: {int4(10), default=[0]}</summary>
        [Seasar.Dao.Attrs.Column("price")]
        public int? Price {
            get { return _price; }
            set {
                __modifiedProperties.AddPropertyName("Price");
                _price = value;
            }
        }

        /// <summary>capacity: {int4(10), default=[1]}</summary>
        [Seasar.Dao.Attrs.Column("capacity")]
        public int? Capacity {
            get { return _capacity; }
            set {
                __modifiedProperties.AddPropertyName("Capacity");
                _capacity = value;
            }
        }

        /// <summary>description: {NotNull, varchar(255)}</summary>
        [Seasar.Dao.Attrs.Column("description")]
        public String Description {
            get { return _description; }
            set {
                __modifiedProperties.AddPropertyName("Description");
                _description = value;
            }
        }

        #endregion
    }
}
