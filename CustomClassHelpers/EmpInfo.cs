using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel_Specflow
{

    public class EmpInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class HRMEmpInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class HRMAdminInfo
    {
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }

    public class HRMJobInfo
    {
        public string JobTitle { get; set; }
    }
    
}
