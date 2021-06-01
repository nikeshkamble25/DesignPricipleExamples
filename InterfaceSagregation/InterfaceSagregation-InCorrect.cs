using System;

namespace InterfaceSagregation_InCorrect
{
    public interface ICreature
    {
        public String Eat();
        public void Sleep();
        public void Walk();
        public void Run();
    }
    public class Deer : ICreature
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

        public void Run()
        {
            throw new NotImplementedException();
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
