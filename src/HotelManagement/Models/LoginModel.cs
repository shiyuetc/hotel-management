using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using HotelManagement.Common;
using Seasar.Quill.Attrs;

namespace HotelManagement.Models
{
    /// <summary>
    /// ログイン関係の情報の仲介を行うクラス
    /// </summary>
    [Implementation]
    public class LoginModel
    {
        #region 使用するテーブル

        protected EmployeeBhv EmployeeBhv;

        #endregion

        /// <summary>
        /// 従業員のログインを試行します。
        /// </summary>
        /// <param name="id">従業員番号</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログインに成功した場合は従業員情報を返す</returns>
        public Employee Login(string id, string password)
        {
            var employeeCB = new EmployeeCB();
            employeeCB.SetupSelect_Rank();
            employeeCB.Query().SetEmployeeNo_Equal(id);
            var employee = EmployeeBhv.SelectEntity(employeeCB);

            if(employee != null && BcryptUtil.Verify(password, employee.Password))
            {
                return employee;
            }

            return null;
        }

        /// <summary>
        /// 従業員のログインが成功したかどうか判定します。
        /// </summary>
        /// <param name="id">従業員番号</param>
        /// <param name="password">パスワード</param>
        /// <returns>ログインに成功した場合はtrueを返す</returns>
        public bool TryLogin(string id, string password)
        {
            return this.Login(id, password) != null;
        }
    }
}
