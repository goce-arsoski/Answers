using System;
using System.Collections.Generic;

namespace Answer2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Cat());
            animals.Add(new Cow());
            animals.Add(new Dog());
            animals.Add(new Goat());
            animals.Add(new Pig());
            animals.Add(new Animal("bear", "growl"));
            animals.Add(new Animal("duck", "quack"));
            animals.Add(new Animal("sheep", "baa"));
            animals.Add(new Animal("snake", "hiss"));
            animals.Add(new Animal("wolf", "howl"));
            animals.Add(new Animal("horse", "neigh"));
            animals.Add(new Animal("donkey", "hee-haw"));
            animals.Add(new Animal("pigeons", "coo"));
            animals.Add(new Animal("frog", "croak"));
            animals.Add(new Animal("tiger", "roar"));

            GetSong(animals);
        }

        private static void GetSong(List<Animal> animals)
        {
            for (int i = 0; i < animals.Count; i++)
            {
                Console.WriteLine(animals[i].AnimalSong());
            }
        }
    }
}
