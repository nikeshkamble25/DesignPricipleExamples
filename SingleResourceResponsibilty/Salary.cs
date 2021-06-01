using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResourceResponsibilty
{
    public class Salary
    {
        public int SalaryId { get; set; }
        public float CTC { get; set; }
        public float HRAComponent { get; set; }
        public int BonusPercentage { get; set; }
        public float CalculateSalary()
        {
            return CTC + HRAComponent + this.CalculateBonus();
        }
        public float CalculateBonus()
        {
            return ((CTC + HRAComponent) * 30) / 100;
        }       
    }
}
