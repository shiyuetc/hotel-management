﻿
using HotelManagement.Extensions;

namespace HotelManagement.Enums
{
    /// <summary>
    /// 画面を表す列挙体
    /// </summary>
    public enum Display
    {
        [DisplayName("ログイン")]
        Login,

        [DisplayName("予約管理")]
        Reserve,

        [DisplayName("宿泊履歴")]
        History,

        [DisplayName("売上確認")]
        Sale,

        [DisplayName("従業員管理")]
        Employee,

        [DisplayName("顧客管理")]
        Customer,
    }
}