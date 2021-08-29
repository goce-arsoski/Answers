using System;

namespace Answer3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write 'END' to end program");
            string animalType;
            string animalSound;
            Animal animal;

            while (true)
            {
                Console.Write("Insert animal type: ");
                animalType = Console.ReadLine();
                if (animalType != null && animalType.ToLower() == "end")
                    break;

                Console.Write("Insert animal sound: ");
                animalSound = Console.ReadLine();
                if (animalSound != null && animalSound.ToLower() == "end")
                    break;

                animal = new Animal(animalType, animalSound);
                Console.WriteLine(animal.AnimalSong());
            }
         }
    }
}
