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
        protected MstEmployeeBhv MstEmployeeBhv;

        public MstEmployee[] GetEmployeeList()
        {
            var mstEmployeeCB = new MstEmployeeCB();
            mstEmployeeCB.SetupSelect_KbnRank();
            var selectList = MstEmployeeBhv.SelectList(mstEmployeeCB);
            var employees = selectList.Count > 0 ? selectList.ToArray() : new MstEmployee[0];
            return employees;
        }
    }
}
