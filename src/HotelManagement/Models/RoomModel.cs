using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using HotelManagement.Common;
using Seasar.Quill.Attrs;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Models
{
    /// <summary>
    /// 客室管理関係の情報の仲介を行うクラス
    /// </summary>
    [Implementation]
    public class RoomModel
    {
        #region 使用するテーブル

        protected RoomBhv RoomBhv;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Room> GetRoomList()
        {
            var roomCB = new RoomCB();
            roomCB.SetupSelect_RoomType();

            var selectList = RoomBhv.SelectList(roomCB);

            return selectList.Any() ? selectList.ToList() : new List<Room>();
        }
    }
}
