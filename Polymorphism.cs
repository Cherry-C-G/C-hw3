
using System;

namespace oop5
{

    // Abstract class
    abstract class Animal
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();//abtraction
        // Regular method
        public void sleep()
        {
            Console.WriteLine("Sleeping Zzz");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Animal
    {
        public override void animalSound()//polimorphism
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();
        }
    }
}