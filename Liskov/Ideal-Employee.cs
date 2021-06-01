using System;

namespace LiskovSubstitution_Correct
{
    //Liskov Substitution Principle 
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GetAge()
        {
            return DateOfBirth.Year - DateTime.Now.Year;
        }
        public virtual float CalculateSalary()
        {
            Console.WriteLine("Calculating Salary with business logic for Generic Employee");
            return 3000;
        }
    }

    public interface ISalary
    {
        public float CalculateBonus();
    }

    public class JuniorEmployee : Employee, ISalary
    {
        public float CalculateBonus()
        {
            Console.WriteLine("Calculating Bonus with business logic for Junior Employee");
            return 1000;
        }

        public override float CalculateSalary()
        {
            Console.WriteLine("Calculating Salary with business logic for Junior Employee");
            return 2000;
        }
    }
    public class SeniorEmployee : Employee, ISalary
    {
        public float CalculateBonus()
        {
            Console.WriteLine("Calculating Bonus with business logic for Senior Employee");
            return 1000;
        }

        public override float CalculateSalary()
        {
            Console.WriteLine("Calculating Salary with business logic for Senior Employee");
            return 2000;
        }
    }


    public class ContractorEmployee : Employee
    {
        public override float CalculateSalary()
        {
            Console.WriteLine("Calculating Salary with business logic for Senior Employee");
            return 2000;
        }
    }
}
