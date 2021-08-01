using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Models
{
    [Implementation]
    public class 客室状態画面処理Model
    {
        #region 使用するテーブル

        protected Mst客室マスタBhv 客室マスタBhv;

        #endregion

        public List<Mst客室マスタ> Get客室マスタList()
        {
            var 客室マスタcb = new Mst客室マスタCB();
            var 客室マスタList = 客室マスタBhv.SelectList(客室マスタcb).ToList();

            return 客室マスタList.Any() ? 客室マスタList : new List<Mst客室マスタ>();
        }
    }
}
