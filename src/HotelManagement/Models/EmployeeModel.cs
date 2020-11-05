using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Linq;

namespace HotelManagement.Models
{
    /// <summary>
    /// 従業員管理関係の情報の仲介を行うクラス
    /// </summary>
    [Implementation]
    public class EmployeeModel
    {
        #region 利用するテーブル

        protected EmployeeBhv EmployeeBhv;

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns>取得した従業員情報の配列を返す</returns>
        public Employee[] GetEmployeeList()
        {
            var employeeCB = new EmployeeCB();
            employeeCB.SetupSelect_Rank();

            var selectList = EmployeeBhv.SelectList(employeeCB);

            var employees = selectList.Count > 0 ? selectList.ToArray() : new Employee[0];
            return employees;
        }
    }
}
