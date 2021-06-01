using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResourceResponsibilty
{
    public class Account
    {
        public void AssignSalary(int EmpId,int salaryId)
        {
            Console.WriteLine($"Salary with Id {salaryId} Assigned to Employee Id {EmpId}");
        }
    }
}
