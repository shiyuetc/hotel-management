using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
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
            mstEmployeeCB.Query().SetPassword_Equal(password);
            return MstEmployeeBhv.SelectEntity(mstEmployeeCB);
        }
    }
}
