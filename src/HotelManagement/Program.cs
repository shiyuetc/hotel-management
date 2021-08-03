using Dbflute.AllCommon.Exp;
using HotelManagement.Common;
using HotelManagement.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelManagement
{
    public static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // タイマーを設定(毎秒)
            var tickTimer = new System.Timers.Timer(1000);

            // タイマーの処理
            tickTimer.Elapsed += (sender, e) =>
            {
                Constants.システム日付.現在値 = Constants.システム日付.現在値.AddSeconds(1);
            };

            // タイマーを開始する
            tickTimer.Start();

            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmMain());
        }

        /// <summary>
        /// 画面でキャッチしなかった例外が発生時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            string message;
            var type = e.Exception.GetType();
            if (type == typeof(SQLFailureException))
            {
                message = "データベースへの接続に失敗しました。";
            }
            else
            {
                message = string.Format("異常が発生しました。システム管理者へ連絡してください。\r\n例外情報：例外が{0}で発生。プログラムを終了します。\r\nメッセージ：{1}",
                    e.Exception.TargetSite, e.Exception.Message);
            }

            Messages.ShowError(message);
            Application.Exit();
        }
    }
}
