//using SingleResourceResponsibilty;
//using OpenClosed_Correct;
using LiskovSubstitution_Correct;
using System;

namespace DesignPricipleExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //1*
            ////Single Resource Respo Example

            //Employee employee = new Employee();
            //Salary empSalary = new Salary();
            //Account empSalaryTran = new Account();

            //employee.DateOfBirth = new DateTime(1990,10,25);
            //employee.Id = 1;
            //employee.Name = "Nikesh Kamble";


            //empSalary.SalaryId = 1;
            //empSalary.CTC = 150000;
            //empSalary.HRAComponent = 150000;
            //empSalary.BonusPercentage = 30;

            //empSalaryTran.AssignSalary(employee.Id, empSalary.SalaryId);

            //float salary = empSalary.CalculateSalary();
            //Console.WriteLine($"Calculated salary for {employee.Name} is {salary} per year having bouns percentage {empSalary.BonusPercentage}");


            //2*
            ////Open closed principle

            //IEmployee juniorEmployee = new JuniorEmployee();
            //IEmployee seniorEmployee = new SeniorEmployee();
            //float s_salary = seniorEmployee.CalculateSalary();
            //float j_salary = juniorEmployee.CalculateSalary();
            //Console.ReadLine();

            //3*
            ////Liskov Substitution Principle
            ////Sub Employee class can be easily replaceble with its Parent class
            ///Dont use inheritance just to avoid a code
            ///For example, Duck class (Quack, Eat, Fly)
            ///For Toy duck can Quack but cant eat eat battery or fly            
            //Employee employee = new JuniorEmployee();


            //4*
            ////Intrerface Sagregation Principle
            ///Creature is a generic word which exists in the world
            ///If we use only one interface ICreature for all types of creature then this would add complexity plus some of the function could be not useful some of the types of creature
            ///For Example Deer can walk, run, eat, sleep
            ///Plants cant have all similler properties hence we have to sagregate all type with its associated propeties
            
        }
    }
}
