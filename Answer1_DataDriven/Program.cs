using System;

namespace Answer1_DataDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Console.WriteLine(cat);
            Cow cow = new Cow();
            Console.WriteLine(cow);
            Dog dog = new Dog();
            Console.WriteLine(dog);
            Goat goat = new Goat();
            Console.WriteLine(goat);
            Pig pig = new Pig();
            Console.WriteLine(pig);
        }
    }
}
