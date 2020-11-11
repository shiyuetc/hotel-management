using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Models;
using System;

namespace HotelManagement.View.Dialog
{
    /// <summary>
    /// 従業員情報の編集を行うダイアログフォームクラス
    /// </summary>
    public partial class UcEmployeeDialog : UcDialogBase
    {
        #region メンバ変数

        /// <summary>
        /// 従業員情報の受け渡しに利用
        /// </summary>
        public Employee Employee { get; private set; }

        /// <summary>
        /// 登録を行ったかどうか判定するフラグ
        /// </summary>
        public bool UpdateFlag { get; private set; }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// UcEmployeeDialogクラスを初期化します。
        /// </summary>
        /// <param name="employee">従業員</param>
        public UcEmployeeDialog(Employee employee = null)
        {
            InitializeComponent();

            if (employee != null)
            {
                this.Employee = employee;
                this.Text = $"{employee.FullName}";
                this.EmployeeNoTextBox.Text = employee.EmployeeNo;
                this.LastNameTextBox.Text = employee.LastName;
                this.FirstNameTextBox.Text = employee.FirstName;
                this.RubyNameTextBox.Text = employee.RubyName;
                this.RankComboBox.Text = employee.Rank.JapaneseName;
                this.EmailTextBox.Text = employee.Email;
                this.EntryDateTimePicker.Value = employee.EntryDate.Value;

                if(employee.IsLeave)
                {
                    this.IsLeaveCheckBox.Checked = true;
                    this.LeaveDateTimePicker.Value = employee.LeaveDate.Value;
                }
            }
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// 退社チェックボックスのチェック変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsLeaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.LeaveDateTimePicker.Enabled = this.IsLeaveCheckBox.Checked;
        }

        /// <summary>
        /// パスワード変更チェックボックスのチェック変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.PasswordTextBox.Enabled = this.UpdatePasswordCheckBox.Checked;
            this.RePasswordTextBox.Enabled = this.UpdatePasswordCheckBox.Checked;
        }

        /// <summary>
        /// 登録ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if(!this.InputCheck()) return;

            // 登録確認チェック
            if (this.ConfirmCheck()) return;

            // データ登録処理
            this.UpdateEvent();

            // ダイアログを閉じる
            this.Close();
        }

        /// <summary>
        /// キャンセルボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 登録チェック

        /// <summary>
        /// 入力チェックを行います。
        /// </summary>
        /// <returns>チェックが通ればtrueを返す</returns>
        private bool InputCheck()
        {
            if (string.IsNullOrEmpty(this.EmployeeNoTextBox.Text))
            {
                Messages.ShowError("{0}が入力されていません。", "従業員番号");
                return false;
            }

            if (string.IsNullOrEmpty(this.LastNameTextBox.Text))
            {
                Messages.ShowError("{0}が入力されていません。", "氏名（性）");
                return false;
            }

            if (string.IsNullOrEmpty(this.FirstNameTextBox.Text))
            {
                Messages.ShowError("{0}が入力されていません。", "氏名（名）");
                return false;
            }

            if (string.IsNullOrEmpty(this.RubyNameTextBox.Text))
            {
                Messages.ShowError("{0}が入力されていません。", "氏名（ｶﾅ）");
                return false;
            }

            if (string.IsNullOrEmpty(this.EmailTextBox.Text))
            {
                Messages.ShowError("{0}が入力されていません。", "Eメール");
                return false;
            }

            if (this.UpdatePasswordCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(this.PasswordTextBox.Text))
                {
                    Messages.ShowError("{0}が入力されていません。", "新しいパスワード");
                    return false;
                }

                if (string.IsNullOrEmpty(this.RePasswordTextBox.Text))
                {
                    Messages.ShowError("{0}が入力されていません。", "パスワード再入力");
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 登録確認チェックを行います。
        /// </summary>
        /// <returns>チェックが通ればtrueを返す</returns>
        private bool ConfirmCheck()
        {
            return !Messages.ShowConfirm("従業員を登録しますか？");
        }

        #endregion

        #region 登録イベント

        /// <summary>
        /// 従業員の登録処理を行います。
        /// </summary>
        private void UpdateEvent()
        {
            this.Employee.EmployeeNo = this.EmployeeNoTextBox.Text;
            this.Employee.LastName = this.LastNameTextBox.Text;
            this.Employee.FirstName = this.FirstNameTextBox.Text;
            this.Employee.RubyName = this.RubyNameTextBox.Text;
            this.Employee.Email = this.EmailTextBox.Text;
            this.Employee.EntryDate = this.EntryDateTimePicker.Value;

            this.Employee.LeaveDate = this.IsLeaveCheckBox.Checked ? (DateTime?)this.LeaveDateTimePicker.Value : null;

            if(this.UpdatePasswordCheckBox.Checked)
            {
                this.Employee.Password = BcryptUtil.GetHashedString(this.PasswordTextBox.Text);
            }

            var vm = new ModelQuillInjector<EmployeeModel>();
            vm.Model.UpdateEmployee(this.Employee);

            this.UpdateFlag = true;
        }

        #endregion
    }
}
