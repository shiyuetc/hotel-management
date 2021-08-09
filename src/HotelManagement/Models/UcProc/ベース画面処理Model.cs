using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Models
{
    /// <summary>
    /// ベース画面処理を行うクラス
    /// </summary>
    [Implementation]
    public class ベース画面処理Model
    {
        #region 使用するテーブル

        protected Mst画面マスタBhv 画面マスタBhv;

        protected Mst権限マスタBhv 権限マスタBhv;

        #endregion

        #region メソッド

        /// <summary>
        /// "ログイン"画面マスタを返します。
        /// </summary>
        /// <returns>画面マスタ</returns>
        public Mst画面マスタ Getログイン画面マスタ()
        {
            var 画面マスタcb = new Mst画面マスタCB();
            画面マスタcb.Query().QueryKbnメニュー区分().Set優先順位_Equal(9999);
            var 画面マスタ = 画面マスタBhv.SelectEntity(画面マスタcb);

            return 画面マスタ;
        }

        /// <summary>
        /// 権限区分に紐づいた画面マスタのリストを返します。
        /// </summary>
        /// <param name="職位区分">職位区分</param>
        /// <returns>画面マスタのリスト</returns>
        public List<Mst画面マスタ> Get画面マスタList(Kbn職位区分 職位区分)
        {
            var 権限マスタcb = new Mst権限マスタCB();
            権限マスタcb.SetupSelect_Mst画面マスタ().WithKbnメニュー区分();
            権限マスタcb.Query().ConditionQueryKbn職位区分.Set職位コード_Equal(職位区分.職位コード);
            権限マスタcb.Query().ConditionQueryMst画面マスタ.AddOrderBy_優先順位_Asc();
            var 権限マスタList = 権限マスタBhv.SelectList(権限マスタcb);
            var 画面マスタList = 権限マスタList.Select(x => x.Mst画面マスタ).ToList();

            return 画面マスタList.Any() ? 画面マスタList : new List<Mst画面マスタ>();
        }

        #endregion

    }
}
