using System;

namespace LiskovSubstitution_Incorrect
{
    //Liskov Substitution Principle 
    //
    public abstract class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GetAge() 
        {
            return DateOfBirth.Year - DateTime.Now.Year;
        }
        public float CalculateSalary()
        {
            Console.WriteLine("Calculating Bonus with business logic for Generic Employee");
            return 1000;
        }
        public abstract float CalculateBonus();

    }

    public class JuniorEmployee : Employee
    {
        public override  float CalculateBonus()
        {
            Console.WriteLine("Calculating Bonus with business logic for Junior Employee");
            return 1000;
        }
    }
    public class SeniorEmployee : Employee
    {
        public override float CalculateBonus()
        {
            Console.WriteLine("Calculating Bonus with business logic for Senior Employee");
            return 1000;
        }
    }

    public class ContractorEmployee : Employee
    {
        public override float CalculateBonus()
        {
            throw new NotImplementedException();
        }
    }
}
