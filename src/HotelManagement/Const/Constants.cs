
using Dbflute.AllCommon;
using HotelManagement.Enums;
using System.Collections.Generic;

namespace HotelManagement.Const
{
    /// <summary>
    /// 定数
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// アプリケーション名
        /// </summary>
        public static readonly string AppName = "HotelManagement";

        /// <summary>
        /// DayOfWeek列挙体に対応した日本語
        /// </summary>
        public static readonly char[] WeekNames = { '日', '月', '火', '水', '木', '金', '土' };

        /// <summary>
        /// 従業員の権限に対応した操作できるメニューボタン
        /// </summary>
        public static Dictionary<string, Display[]> Permissions = new Dictionary<string, Display[]>()
        {
            { 
                CDef.Rank.SystemMaintenancer.Code, 
                new Display[] { 
                    Display.Reserve,
                    Display.History,
                    Display.Sale,
                    Display.Employee,
                    Display.Customer,
                    Display.Room
                } 
            },
            {
                CDef.Rank.AssistantManager.Code,
                new Display[] {
                    Display.Reserve,
                    Display.History,
                    Display.Sale,
                    Display.Employee,
                    Display.Customer,
                    Display.Room
                }
            },
            {
                CDef.Rank.FinancialController.Code,
                new Display[] {
                    Display.History,
                    Display.Sale,
                    Display.Employee,
                    Display.Customer
                }
            },
            {
                CDef.Rank.FrontClerk.Code,
                new Display[] {
                    Display.Reserve,
                    Display.History
                }
            }
        };
    }
}
