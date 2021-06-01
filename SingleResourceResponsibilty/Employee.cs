using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResourceResponsibilty
{
    /// <summary>
    /// This class is responsible for employee only
    /// No other than definition included in this class such as Department Salary
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GetAge() 
        {
            return DateTime.Now.Year - this.DateOfBirth.Year;
        }
    }
}
