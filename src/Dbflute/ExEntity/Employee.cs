
namespace Dbflute.ExEntity {

    partial class Employee
    {
        public string FullName
        {
            get
            {
                return $"{this.LastName} {this.FirstName}";
            }
        }

        public bool IsLeave
        {
            get
            {
                return this.LeaveDate != null;
            }
        }
    }
}
