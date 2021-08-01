using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Models
{
    /// <summary>
    /// 従業員マスタの処理を行うクラス
    /// </summary>
    [Implementation]
    public class 従業員マスタModel
    {
        #region 利用するテーブル

        protected Mst従業員マスタBhv 従業員マスタBhv;

        #endregion

        #region データ登録

        /// <summary>
        /// 従業員マスタを作成します。
        /// </summary>
        /// <param name="従業員マスタ">従業員マスタ</param>
        /// <returns></returns>
        public Mst従業員マスタ Create従業員マスタ(Mst従業員マスタ 従業員マスタ)
        {
            従業員マスタBhv.Insert(従業員マスタ);
            return 従業員マスタ;
        }

        #endregion

        #region データ取得

        /// <summary>
        /// 指定した従業員コードまたは従業員番号と一致する従業員マスタを取得します。
        /// </summary>
        /// <param name="従業員コード">従業員コードまたは従業員番号</param>
        /// <param name="Is従業員番号">1つめの引数が従業員番号であるか</param>
        /// <returns>取得した従業員を返す</returns>
        public Mst従業員マスタ Get従業員マスタ(string 従業員コード, bool Is従業員番号)
        {
            var 従業員マスタcb = new Mst従業員マスタCB();
            従業員マスタcb.SetupSelect_Kbn職位区分();
            if(!Is従業員番号)
            {
                従業員マスタcb.Query().Set従業員コード_Equal(従業員コード);
            }
            else
            {
                従業員マスタcb.Query().Set従業員番号_Equal(従業員コード);
            }

            return this.従業員マスタBhv.SelectEntity(従業員マスタcb);
        }

        /// <summary>
        /// 従業員マスタを全件取得します。
        /// </summary>
        /// <returns>取得した従業員マスタの配列を返す</returns>
        public List<Mst従業員マスタ> Get従業員マスタList()
        {
            var 従業員マスタcb = new Mst従業員マスタCB();
            従業員マスタcb.SetupSelect_Kbn職位区分();
            var selectList = 従業員マスタBhv.SelectList(従業員マスタcb);

            return selectList.Any() ? selectList.ToList() : new List<Mst従業員マスタ>();
        }

        #endregion

        #region データ更新

        /// <summary>
        /// 従業員マスタを更新します。
        /// </summary>
        /// <param name="従業員マスタ">従業員マスタ</param>
        public void Update従業員マスタ(Mst従業員マスタ 従業員マスタ)
        {
            this.従業員マスタBhv.Update(従業員マスタ);
        }

        #endregion

    }
}
