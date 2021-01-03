using Dbflute.AllCommon;
using Dbflute.ExEntity;
using HotelManagement.Common;
using HotelManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

        /// <summary>
        /// 新規登録かどうか
        /// </summary>
        private bool IsRegister { get; set; }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// UcEmployeeDialogクラスを初期化します。
        /// </summary>
        /// <param name="employee">従業員</param>
        public UcEmployeeDialog(Employee employee = null)
        {
            InitializeComponent();

            this.Employee = employee ?? new Employee()
            {
                EmployeeNo = string.Empty,
                LastName = string.Empty,
                FirstName = string.Empty,
                RubyName = string.Empty,
                RankCode = CDef.Rank.FrontClerk.Code,
                Email = string.Empty,
                EntryDate = DateTime.Now
            };

            this.UpdateLeaveDateGroup_SetEnable(false);
            this.UpdatePasswordGroup_SetEnable(false);
        }

        #endregion

        #region イベントハンドラ

        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcEmployeeDialog_Load(object sender, EventArgs e)
        {
            this.EmployeeNoTextBox.Text = this.Employee.EmployeeNo;
            this.LastNameTextBox.Text = this.Employee.LastName;
            this.FirstNameTextBox.Text = this.Employee.FirstName;
            this.RubyNameTextBox.Text = this.Employee.RubyName;
            this.RankComboBox.SelectFromValue(this.Employee.RankCode);
            this.EmailTextBox.Text = this.Employee.Email;
            this.EntryDateTimePicker.Value = this.Employee.EntryDate.Value;

            // 新規登録かどうか
            if (this.Employee.Id == null)
            {
                // 新規登録フラグを切り替え
                this.IsRegister = true;

                this.Text = "新規登録";
                this.IsLeaveCheckBox.Enabled = false;
                this.UpdatePasswordCheckBox.Enabled = false;
                this.UpdatePasswordCheckBox.Checked = true;
            }
            else
            {
                this.Text = this.Employee.FullName;
                
                // 退職している場合
                if (this.Employee.IsLeave)
                {
                    this.IsLeaveCheckBox.Checked = true;
                    this.LeaveDateTimePicker.Value = this.Employee.LeaveDate.Value;
                }

                // 従業員番号は編集不可にする
                this.EmployeeNoTextBox.Enabled = false;
            }
        }

        /// <summary>
        /// フォームの終了時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UcEmployeeDialog_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            // 破棄確認チェック
            if (!this.UpdateFlag && !this.RevokeCheck())
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// 退社チェックボックスのチェック変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void IsLeaveCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // 退職関係の活性を切り替える
            this.UpdateLeaveDateGroup_SetEnable(this.IsLeaveCheckBox.Checked);
        }

        /// <summary>
        /// パスワード変更チェックボックスのチェック変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // パスワード変更関係の活性を切り替える
            this.UpdatePasswordGroup_SetEnable(this.UpdatePasswordCheckBox.Checked);
        }

        /// <summary>
        /// 登録ボタンのクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // 入力チェック
            if (!this.InputCheck()) return;

            // 登録確認チェック
            if (!this.ConfirmCheck()) return;

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
            // ダイアログを閉じる
            this.Close();
        }

        #endregion

        #region コントロール制御

        /// <summary>
        /// 退職関係のコントロールの活性を切り替えます。
        /// </summary>
        /// <param name="value">活性・非活性</param>
        private void UpdateLeaveDateGroup_SetEnable(bool value)
        {
            this.LeaveDateLabel.SetEnable(value);
            this.LeaveDateTimePicker.Enabled = value;
        }

        /// <summary>
        /// パスワード変更関係のコントロールの活性を切り替えます。
        /// </summary>
        /// <param name="value">活性・非活性</param>
        private void UpdatePasswordGroup_SetEnable(bool value)
        {
            this.PasswordLabel.SetEnable(value);
            this.PasswordTextBox.Enabled = value;
            this.RePasswordLabel.SetEnable(value);
            this.RePasswordTextBox.Enabled = value;
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
            return Messages.ShowConfirm("従業員を登録しますか？");
        }

        /// <summary>
        /// 破棄確認チェックを行います。
        /// </summary>
        /// <returns>チェックが通ればtrueを返す</returns>
        private bool RevokeCheck()
        {
            // 変更フラグを定義
            bool change = false;

            // 従業員番号の変更をチェック
            if (this.Employee.EmployeeNo != this.EmployeeNoTextBox.Text)
            {
                change = true;
            }

            // 氏名（性）の変更をチェック
            else if (this.Employee.LastName != this.LastNameTextBox.Text)
            {
                change = true;
            }

            // 氏名（名）の変更をチェック
            else if (this.Employee.FirstName != this.FirstNameTextBox.Text)
            {
                change = true;
            }

            // 氏名（ｶﾅ）の変更をチェック
            else if (this.Employee.RubyName != this.RubyNameTextBox.Text)
            {
                change = true;
            }

            // 職位の変更をチェック
            else if (this.Employee.RankCode != this.RankComboBox.SelectedValue.ToString())
            {
                change = true;
            }

            // Eメールの変更をチェック
            else if (this.Employee.Email != this.EmailTextBox.Text)
            {
                change = true;
            }

            // 入社年月日の変更をチェック
            else if (this.Employee.EntryDate != this.EntryDateTimePicker.Value)
            {
                change = true;
            }

            // 退職の変更をチェック
            else if (this.Employee.IsLeave != this.IsLeaveCheckBox.Checked)
            {
                change = true;
            }

            // 退社年月日の変更をチェック
            else if (this.Employee.IsLeave && (this.Employee.LeaveDate != this.LeaveDateTimePicker.Value))
            {
                change = true;
            }

            // 新しいパスワードの変更をチェック
            else if (!string.IsNullOrEmpty(this.PasswordTextBox.Text))
            {
                change = true;
            }

            // パスワード再入力の変更をチェック
            else if (!string.IsNullOrEmpty(this.RePasswordTextBox.Text))
            {
                change = true;
            }

            // 変更がない場合はtrue
            if (!change) return true;

            // 変更がある場合は破棄確認を表示
            return Messages.ShowConfirm("変更内容を取り消しますか？");
        }

        #endregion

        #region 登録イベント

        /// <summary>
        /// 従業員の登録処理を行います。
        /// </summary>
        private void UpdateEvent()
        {
            // 従業員情報を代入
            this.Employee.EmployeeNo = this.EmployeeNoTextBox.Text;
            this.Employee.LastName = this.LastNameTextBox.Text;
            this.Employee.FirstName = this.FirstNameTextBox.Text;
            this.Employee.RubyName = this.RubyNameTextBox.Text;
            this.Employee.RankCode = this.RankComboBox.SelectedValue.ToString();
            this.Employee.Email = this.EmailTextBox.Text;
            this.Employee.EntryDate = this.EntryDateTimePicker.Value;
            this.Employee.LeaveDate = this.IsLeaveCheckBox.Checked ? (DateTime?)this.LeaveDateTimePicker.Value : null;

            if(this.UpdatePasswordCheckBox.Checked)
            {
                this.Employee.Password = BcryptUtil.GetHashedString(this.PasswordTextBox.Text);
            }

            var vm = new ModelQuillInjector<EmployeeModel>();
            if(this.IsRegister)
            {
                // 従業員情報を登録
                vm.Model.CreateEmployee(this.Employee);
            }
            else
            {
                // 従業員情報を更新
                vm.Model.UpdateEmployee(this.Employee);
            }

            // 登録フラグを切り替え
            this.UpdateFlag = true;
        }

        #endregion

    }
}
