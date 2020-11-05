
namespace Dbflute.ExEntity {

    partial class Employee
    {
        public bool IsLeave
        {
            get
            {
                return this.LeaveDate != null;
            }
        }
    }
}
