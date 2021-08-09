using Dbflute.AllCommon.CBean;
using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Models
{
    [Implementation]
    public class 客室状態画面処理Model
    {
        #region 使用するテーブル

        protected Mst客室マスタBhv 客室マスタBhv;

        protected Dch客室利用台帳Bhv 客室利用台帳Bhv;

        #endregion

        public List<Mst客室マスタ> Get客室マスタList()
        {
            var 客室マスタcb = new Mst客室マスタCB();
            var 客室マスタList = 客室マスタBhv.SelectList(客室マスタcb).ToList();

            return 客室マスタList.Any() ? 客室マスタList : new List<Mst客室マスタ>();
        }

        public List<Dch客室利用台帳> Get未終了客室利用台帳()
        {
            var 客室利用台帳cb = new Dch客室利用台帳CB();
            客室利用台帳cb.SetupSelect_Mst客室マスタ();
            客室利用台帳cb.Query().Set終了実績日時_IsNull();
            客室利用台帳cb.Query().AddOrderBy_開始予定日時_Asc();
            var 客室利用台帳List = 客室利用台帳Bhv.SelectList(客室利用台帳cb).ToList();

            return 客室利用台帳List.Any() ? 客室利用台帳List : new List<Dch客室利用台帳>();
        }
    }
}
