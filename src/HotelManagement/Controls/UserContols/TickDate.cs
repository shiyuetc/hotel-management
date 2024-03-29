﻿using HotelManagement.Common;
using HotelManagement.Extensions;
using System;
using System.Windows.Forms;

namespace HotelManagement.Controls.UserControls
{
    /// <summary>
    /// 現在時刻を表示するコントロール
    /// </summary>
    public partial class TickDate : UserControl
    {
        /// <summary>
        /// TickDateを初期化します。
        /// </summary>
        public TickDate()
        {
            InitializeComponent();

            // 時刻を更新
            this.UpdateDateTime(Constants.システム日付.現在値);
        }

        /// <summary>
        /// TickTimerのTickイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TickTimer_Tick(object sender, EventArgs e)
        {
            this.UpdateDateTime(Constants.システム日付.現在値);
        }
        
        /// <summary>
        /// 表示時刻を更新します。
        /// </summary>
        /// <param name="nowDateTime">更新する時刻</param>
        private void UpdateDateTime(DateTime nowDateTime)
        {
            this.DateLabel.Text = nowDateTime.ToYYYYMMDD();
            this.DayOfWeekLabel.Text = $"({Constants.WeekNames[(int)nowDateTime.DayOfWeek]})";
            this.TimeLabel.Text = nowDateTime.ToHHMM();
        }
    }
}
