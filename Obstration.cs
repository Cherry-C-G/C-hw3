using System;

namespace oop2
{

    // Abstract class
    abstract class Person
    {
        // Abstract method (does not have a body)
        public abstract void sing();//abtraction
 
 
    }

    // Derived class (inherit from Animal)
    class Student : Person
    {
   
        public override void sing()//polimorphism
        {
            Console.WriteLine("Student sing.");
        }
    }
    class Instructor : Person
    {
        public override void sing()//polimorphism
        {
            // The body of animalSound() is provided here
            Console.WriteLine("Instuctor sing.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student Daisy = new Student();
            Daisy.sing();
    
            Instructor teacher = new Instructor();
            teacher.sing();

        }
    }
}