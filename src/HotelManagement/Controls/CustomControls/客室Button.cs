using Dbflute.AllCommon;
using Dbflute.ExEntity;
using HotelManagement.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagement.Controls.CustomControls
{
    [DesignTimeVisible(false)]
    public partial class 客室Button : Button
    {
        /// <summary>
        /// 客室Buttonクラスを初期化します。
        /// </summary>
        /// <param name="客室番号">客室番号</param>
        /// <param name="客室利用台帳">客室利用台帳</param>
        public 客室Button(string 客室番号, Dch客室利用台帳 客室利用台帳) : base()
        {
            this.Size = new Size(100, 60);
            this.BackColor = Color.LightGray;
            this.Font = new Font("MS UI Gothic", 15, FontStyle.Bold);
            this.Text = $"{客室番号}号室";

            // 客室利用台帳がnullの場合は終了
            if (客室利用台帳 == null)
            {
                return;
            }

            // 利用状況によって背景色を設定
            if (客室利用台帳.開始実績日時 != null && 客室利用台帳.開始実績日時 <= Constants.システム日付.現在値)
            {
                // 宿泊中
                if (客室利用台帳.客室利用コード == CDef.客室利用区分.宿泊.Code)
                {
                    this.BackColor = Constants.客室利用状態配色.宿泊中;
                }
                // 清掃中
                else if (客室利用台帳.客室利用コード == CDef.客室利用区分.清掃.Code)
                {
                    this.BackColor = Constants.客室利用状態配色.清掃中;
                }
                // 工事中
                else if (客室利用台帳.客室利用コード == CDef.客室利用区分.工事.Code)
                {
                    this.BackColor = Constants.客室利用状態配色.工事中;
                }
            }
            else if (客室利用台帳.開始実績日時 == null && 客室利用台帳.開始予定日時 <= Constants.システム日付.現在値)
            {
                // ﾁｪｯｸｲﾝ待機中
                if (客室利用台帳.客室利用コード == CDef.客室利用区分.宿泊.Code)
                {
                    this.BackColor = Constants.客室利用状態配色.チェックイン待機中;
                }
            }
            else if (客室利用台帳.開始実績日時 != null && 客室利用台帳.終了予定日時 <= Constants.システム日付.現在値)
            {
                // ﾁｪｯｸｱｳﾄ待機中
                if (客室利用台帳.客室利用コード == CDef.客室利用区分.宿泊.Code)
                {
                    this.BackColor = Constants.客室利用状態配色.チェックアウト待機中;
                }
            }
        }
    }
}
