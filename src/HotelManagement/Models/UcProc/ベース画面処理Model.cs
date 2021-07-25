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

        protected Mst制御画面マスタBhv 制御画面マスタBhv;

        protected Mst権限マスタBhv 権限マスタBhv;

        #endregion

        #region メソッド

        /// <summary>
        /// "ログイン"制御画面マスタを返します。
        /// </summary>
        /// <returns>制御画面マスタ</returns>
        public Mst制御画面マスタ Getログイン制御画面マスタ()
        {
            var 制御画面マスタcb = new Mst制御画面マスタCB();
            制御画面マスタcb.Query().QueryKbnメニュー区分().Set優先順位_Equal(9999);
            var 制御画面マスタ = 制御画面マスタBhv.SelectEntity(制御画面マスタcb);

            return 制御画面マスタ;
        }

        /// <summary>
        /// 権限区分に紐づいた制御画面マスタのリストを返します。
        /// </summary>
        /// <param name="権限区分">権限区分</param>
        /// <returns>制御画面マスタのリスト</returns>
        public List<Mst制御画面マスタ> Get制御画面マスタListt(Kbn職位区分 権限区分)
        {
            var 権限マスタcb = new Mst権限マスタCB();
            権限マスタcb.SetupSelect_Mst制御画面マスタ().WithKbnメニュー区分();
            権限マスタcb.Query().ConditionQueryKbn職位区分.SetCode_Equal(権限区分.Code);
            権限マスタcb.Query().ConditionQueryMst制御画面マスタ.AddOrderBy_優先順位_Asc();
            var 権限マスタList = 権限マスタBhv.SelectList(権限マスタcb);
            var 制御画面マスタList = 権限マスタList.Select(x => x.Mst制御画面マスタ).ToList();

            return 制御画面マスタList.Any() ? 制御画面マスタList : new List<Mst制御画面マスタ>();
        }

        #endregion

    }
}
