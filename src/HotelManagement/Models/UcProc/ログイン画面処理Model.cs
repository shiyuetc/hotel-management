using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using HotelManagement.Common;
using Seasar.Quill.Attrs;

namespace HotelManagement.Models
{
    /// <summary>
    /// ログイン画面処理を行うクラス
    /// </summary>
    [Implementation]
    public class ログイン画面処理Model
    {
        #region 使用するテーブル

        protected Mst従業員マスタBhv 従業員マスタBhv;

        #endregion

        #region メソッド

        /// <summary>
        /// ログイン処理を試行します。
        /// </summary>
        /// <param name="従業員番号">従業員番号</param>
        /// <param name="パスワード">パスワード</param>
        /// <returns>ログインに成功した場合は従業員マスタを返す</returns>
        public Mst従業員マスタ ログイン処理(string 従業員番号, string パスワード)
        {
            var 従業員マスタcb = new Mst従業員マスタCB();
            従業員マスタcb.SetupSelect_Kbn職位区分();
            従業員マスタcb.Query().Set従業員番号_Equal(従業員番号);
            
            var 従業員マスタ = 従業員マスタBhv.SelectEntity(従業員マスタcb);

            if(従業員マスタ != null && BcryptUtil.Verify(パスワード, 従業員マスタ.パスワード))
            {
                return 従業員マスタ;
            }

            return null;
        }

        /// <summary>
        /// ログイン処理が成功したかどうか判定します。
        /// </summary>
        /// <param name="従業員番号">従業員番号</param>
        /// <param name="パスワード">パスワード</param>
        /// <returns>ログイン成功可否</returns>
        public bool Tryログイン処理(string 従業員番号, string パスワード)
        {
            return this.ログイン処理(従業員番号, パスワード) != null;
        }

        #endregion

    }
}
