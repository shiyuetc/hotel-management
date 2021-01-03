using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Collections.Generic;
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

        #region データ登録

        /// <summary>
        /// 従業員を作成します。
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public Employee CreateEmployee(Employee employee)
        {
            EmployeeBhv.Insert(employee);
            return employee;
        }

        #endregion

        #region データ取得

        /// <summary>
        /// 指定したIDと一致する従業員を取得します。
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>取得した従業員を返す</returns>
        public Employee GetEmployee(long id)
        {
            var employeeCB = new EmployeeCB();
            employeeCB.SetupSelect_Rank();
            employeeCB.Query().SetId_Equal(id);

            return this.EmployeeBhv.SelectEntity(employeeCB);
        }

        /// <summary>
        /// 指定した従業員番号と一致する従業員を取得します。
        /// </summary>
        /// <param name="employeeNo">従業員番号</param>
        /// <returns>取得した従業員を返す</returns>
        public Employee GetEmployee(string employeeNo)
        {
            var employeeCB = new EmployeeCB();
            employeeCB.SetupSelect_Rank();
            employeeCB.Query().SetEmployeeNo_Equal(employeeNo);

            return this.EmployeeBhv.SelectEntity(employeeCB);
        }

        /// <summary>
        /// 従業員を全件取得します。
        /// </summary>
        /// <returns>取得した従業員の配列を返す</returns>
        public List<Employee> GetEmployeeList()
        {
            var employeeCB = new EmployeeCB();
            employeeCB.SetupSelect_Rank();

            var selectList = EmployeeBhv.SelectList(employeeCB);

            return selectList.Any() ? selectList.ToList() : new List<Employee>();
        }

        #endregion

        #region データ更新

        /// <summary>
        /// 従業員を更新します。
        /// </summary>
        /// <param name="employee">従業員</param>
        public void UpdateEmployee(Employee employee)
        {
            this.EmployeeBhv.Update(employee);
        }

        #endregion
    }
}
