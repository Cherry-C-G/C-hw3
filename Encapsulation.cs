using System;

namespace oop3
{


    public class Animal
    {
        //encapsulation - declare private variables 
        private String animalName;
        private int animalAge;
        private String animalGender;

        public String Name
        {
            get
            {
                return animalName;
            }
            set
            {
                animalName = value;
            }
        }
        public int Age
        {
            get
            {
                return animalAge;
            }
            set
            {
                animalAge = value;
            }
        }
        public String Gender
        {
            get
            {
                return animalGender;
            }
            set
            {
                animalGender = value;
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.Name = "Kitty";
            cat.Age = 2;
            cat.Gender = "Female";
            Console.WriteLine(cat.Name +" "+ cat.Age+ " " +cat.Gender);

        }
    }
}