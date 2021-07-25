using Dbflute.AllCommon.Exp;
using HotelManagement.Common;
using HotelManagement.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace HotelManagement
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmMain());
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
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
