using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using HotelManagement.Common;
using Seasar.Quill.Attrs;

namespace HotelManagement.Models
{
    [Implementation]
    public class LoginModel
    {
        protected EmployeeBhv EmployeeBhv;

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
    }
}
