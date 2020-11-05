using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;
using System.Linq;

namespace HotelManagement.Models
{
    [Implementation]
    public class EmployeeModel
    {
        protected EmployeeBhv EmployeeBhv;

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
