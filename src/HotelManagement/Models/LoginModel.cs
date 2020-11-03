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
        protected MstEmployeeBhv MstEmployeeBhv;

        public MstEmployee Login(string id, string password)
        {
            var mstEmployeeCB = new MstEmployeeCB();
            mstEmployeeCB.SetupSelect_KbnRank();
            mstEmployeeCB.Query().SetEmployeeNo_Equal(id);
            var employee = MstEmployeeBhv.SelectEntity(mstEmployeeCB);

            if(employee != null && BcryptUtil.Verify(password, employee.Password))
            {
                return employee;
            }

            return null;
        }
    }
}
