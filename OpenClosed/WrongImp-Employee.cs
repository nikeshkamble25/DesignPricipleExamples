using System;

namespace OpenClosed_Wrong
{
    //Open for extension but closed for modification
    //Employee class has all basic details
    //We have recieved an extra requirement to add a functionality to calculate salary for different types of employees 
    //Like JuniorEmployee and SeniorEmployee 
    public class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int GetAge()
        {
            return DateTime.Now.Year - this.DateOfBirth.Year;
        }
        public float CalculateSalaryJuniorEmployee() 
        {
            return 1000; //test salary
        }
        public float CalculateSalarySeniorEmployee()
        {
            return 5000; //test salary having different business logic/calculation
        }
    }    
}
