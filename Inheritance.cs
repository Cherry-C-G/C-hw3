using System;

namespace oop4
{
    public abstract class Plants
    {
        // Abstract method (does not have a body)
        public abstract void plants();//abtraction
        // Regular method
        public void flowers()
        {
            Console.WriteLine("Flowers are beautiful");
        }
    }

    // Derived class (inherit from Animal)
    class Daisy : Plants
    {
        public override void plants()//polimorphism
        {
            // The body of animalSound() is provided here
            Console.WriteLine("Daisy is yellow.");
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Plants Daisy = new Daisy();
            Daisy.flowers();
            Console.WriteLine(Daisy.plants);

        }
    }
}