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

        protected Mstメニュー権限マスタBhv メニュー権限マスタBhv;

        #endregion

        #region メソッド

        /// <summary>
        /// 権限区分に紐づいた権限マスタのリストを返します。
        /// </summary>
        /// <param name="権限区分">権限区分</param>
        /// <returns>権限マスタのリスト</returns>
        public List<Mstメニュー権限マスタ> Getメニュー権限マスタList(Kbn職位区分 権限区分)
        {
            var メニュー権限マスタcb = new Mstメニュー権限マスタCB();
            メニュー権限マスタcb.SetupSelect_Mst制御画面マスタ();
            メニュー権限マスタcb.Query().ConditionQueryKbn職位区分.SetCode_Equal(権限区分.Code);
            メニュー権限マスタcb.Query().ConditionQueryMst制御画面マスタ.AddOrderBy_優先順位_Asc();
            var メニュー権限マスタList = メニュー権限マスタBhv.SelectList(メニュー権限マスタcb);

            return メニュー権限マスタList.Any() ? メニュー権限マスタList.ToList() : new List<Mstメニュー権限マスタ>();
        }

        #endregion

    }
}
