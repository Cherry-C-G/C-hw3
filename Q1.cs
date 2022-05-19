using System;

namespace oop1
{


    public class AnimalName
    {
        //encapsulation - declare private variables 
        private String animalName;

        public String Name
        {
            get { return animalName;
            }
            set
            {
                animalName = value;
            }
        }
    }

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
            AnimalName cat = new AnimalName();
            cat.Name = "Kitty";
            Console.WriteLine(cat.Name);


            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();
        }
    }
}