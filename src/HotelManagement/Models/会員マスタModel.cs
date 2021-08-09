using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagement.Models
{
    /// <summary>会員マスタ
    /// 会員マスタの処理を行うクラス
    /// </summary>
    [Implementation]
    public class 会員マスタModel
    {
        #region 利用するテーブル

        protected Mst会員マスタBhv 会員マスタBhv;

        #endregion

        #region データ登録

        /// <summary>
        /// 会員マスタを作成します。
        /// </summary>
        /// <param name="会員マスタ">会員マスタ</param>
        /// <returns></returns>
        public Mst会員マスタ Create会員マスタ(Mst会員マスタ 会員マスタ)
        {
            会員マスタBhv.Insert(会員マスタ);
            return 会員マスタ;
        }

        #endregion

        #region データ取得

        /// <summary>
        /// 指定した会員コードまたは会員番号と一致する会員マスタを取得します。
        /// </summary>
        /// <param name="会員コード">会員コードまたは会員番号</param>
        /// <param name="Is会員番号">1つめの引数が会員番号であるか</param>
        /// <returns>取得した会員を返す</returns>
        public Mst会員マスタ Get会員マスタ(string 会員コード, bool Is会員番号)
        {
            var 会員マスタcb = new Mst会員マスタCB();
            if (!Is会員番号)
            {
                会員マスタcb.Query().Set会員コード_Equal(会員コード);
            }
            else
            {
                会員マスタcb.Query().Set会員番号_Equal(会員コード);
            }

            return this.会員マスタBhv.SelectEntity(会員マスタcb);
        }

        /// <summary>
        /// 会員マスタを全件取得します。
        /// </summary>
        /// <returns>取得した会員マスタの配列を返す</returns>
        public List<Mst会員マスタ> Get会員マスタList()
        {
            var 会員マスタcb = new Mst会員マスタCB();
            var selectList = 会員マスタBhv.SelectList(会員マスタcb);

            return selectList.Any() ? selectList.ToList() : new List<Mst会員マスタ>();
        }

        #endregion

        #region データ更新

        /// <summary>
        /// 会員マスタを更新します。
        /// </summary>
        /// <param name="会員マスタ">会員マスタ</param>
        public void Update会員マスタ(Mst会員マスタ 会員マスタ)
        {
            this.会員マスタBhv.Update(会員マスタ);
        }

        #endregion

    }
}
