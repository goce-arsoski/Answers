using System;

namespace Answer1_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Cat();
            Console.WriteLine(animal.AnimalSong());

            animal = new Cow();
            Console.WriteLine(animal.AnimalSong());

            animal = new Dog();
            Console.WriteLine(animal.AnimalSong());

            animal = new Goat();
            Console.WriteLine(animal.AnimalSong());

            animal = new Pig();
            Console.WriteLine(animal.AnimalSong());
        }
    }
}
