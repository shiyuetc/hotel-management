using Dbflute.CBean;
using Dbflute.ExBhv;
using Dbflute.ExEntity;
using Seasar.Quill.Attrs;

namespace HotelManagement.Models
{

    [Implementation]
    public class LoginModel
    {
        protected MstUserBhv MstUserBhv;

        public MstUser Login(string id, string password)
        {
            var mstUserCB = new MstUserCB();
            mstUserCB.Query().SetLoginId_Equal(id);
            mstUserCB.Query().SetPassword_Equal(password);
            return MstUserBhv.SelectEntity(mstUserCB);
        }
    }
}
