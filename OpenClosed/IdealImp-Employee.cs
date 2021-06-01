using System;

namespace OpenClosed_Correct
{
    public interface IEmployee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GetAge();
        public float CalculateSalary();
    }

    public class JuniorEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float CalculateSalary()
        {
            Console.WriteLine("Calculating Salary with business logic for Junior Employee");
            return 1000;
        }
        public int GetAge()
        {
            return DateOfBirth.Year - DateTime.Now.Year;
        }
    }
    public class SeniorEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float CalculateSalary()
        {
            Console.WriteLine("Calculating Salary with business logic for Senior Employee");
            return 2000;
        }
        public int GetAge()
        {
            return DateOfBirth.Year - DateTime.Now.Year;
        }
    }
}
