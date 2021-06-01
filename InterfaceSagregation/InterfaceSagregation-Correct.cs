using System;

namespace InterfaceSagregation_Correct
{
    public interface ICreature
    {
        public String Eat();
        public void Sleep();
        public void Walk();
    }

    //Sagregating Interface as per reqirement
    public interface IRunningCreature: ICreature
    {
        public void Run();
    }

    public class Deer : IRunningCreature
    {
        public string Eat()
        {
            return "Grass";
        }

        public void Run()
        {
            Console.WriteLine("Deer Runs from Bhai :P");   
        }

        public void Sleep()
        {
            Console.WriteLine("Deer Sleep");
        }

        public void Walk()
        {
            Console.WriteLine("Deer Walks");
        }
    }

    public class Tortoise : ICreature
    {
        public string Eat()
        {
            return "Small Fish";
        }

        public void Sleep()
        {
            Console.WriteLine("Tortoise Sleep");
        }

        public void Walk()
        {
            Console.WriteLine("Deer Walks");
        }
    }
}
