using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordMaintenance.Personnel
{
    class EnrollmentStaff : Person
    {
        #region Constructors
        public EnrollmentStaff(){ }
        
        public EnrollmentStaff(Person person, string empId, DateTime startDate, decimal salary, Department department)
        {

        }
        #endregion

        #region Properties
        public DateTime StartDate { get; set; }
        public string EmpId { get; }
        public decimal Salary { get; private set; }
        public string Department { get; set; }
        #endregion
    }
}
