using Common;

namespace Answer2
{
    public class Animal
    {
        public string AnimalType { get; private set; }
        public string AnimalSound { get; private set; }
        
        public Animal(string animalType, string animalSound)
        {
            AnimalType = animalType;
            AnimalSound = animalSound;
        }

        public string AnimalSong()
        {
            return Verse.AnimalSong(AnimalType, AnimalSound);
        }
    }
}
