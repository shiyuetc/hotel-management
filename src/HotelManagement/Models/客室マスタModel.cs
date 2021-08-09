using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Models
{
    /// <summary>
    /// 客室マスタの処理を行うクラス
    /// </summary>
    [Implementation]
    public class 客室マスタModel
    {
        #region 利用するテーブル

        protected Mst客室マスタBhv 客室マスタBhv;

        #endregion

        #region データ登録

        /// <summary>
        /// 客室マスタを作成します。
        /// </summary>
        /// <param name="客室マスタ">客室マスタ</param>
        /// <returns></returns>
        public Mst客室マスタ Create客室マスタ(Mst客室マスタ 客室マスタ)
        {
            客室マスタBhv.Insert(客室マスタ);
            return 客室マスタ;
        }

        #endregion

        #region データ取得

        /// <summary>
        /// 指定した客室コードまたは客室番号と一致する客室マスタを取得します。
        /// </summary>
        /// <param name="客室コード">客室コードまたは客室番号</param>
        /// <param name="Is客室番号">1つめの引数が客室番号であるか</param>
        /// <returns>取得した客室を返す</returns>
        public Mst客室マスタ Get客室マスタ(string 客室コード, bool Is客室番号)
        {
            var 客室マスタcb = new Mst客室マスタCB();
            客室マスタcb.SetupSelect_Mst客室タイプマスタ();
            if (!Is客室番号)
            {
                客室マスタcb.Query().Set客室コード_Equal(客室コード);
            }
            else
            {
                客室マスタcb.Query().Set客室番号_Equal(客室コード);
            }

            return this.客室マスタBhv.SelectEntity(客室マスタcb);
        }

        /// <summary>
        /// 客室マスタを全件取得します。
        /// </summary>
        /// <returns>取得した客室マスタの配列を返す</returns>
        public List<Mst客室マスタ> Get客室マスタList()
        {
            var 客室マスタcb = new Mst客室マスタCB();
            客室マスタcb.SetupSelect_Mst客室タイプマスタ();
            var selectList = 客室マスタBhv.SelectList(客室マスタcb);

            return selectList.Any() ? selectList.ToList() : new List<Mst客室マスタ>();
        }

        #endregion

        #region データ更新

        /// <summary>
        /// 客室マスタを更新します。
        /// </summary>
        /// <param name="客室マスタ">客室マスタ</param>
        public void Update客室マスタ(Mst客室マスタ 客室マスタ)
        {
            this.客室マスタBhv.Update(客室マスタ);
        }

        #endregion
    }
}
