using Common;

namespace Answer1_Polymorphism
{
    public class Dog : Animal
    {
        public override string AnimalSong()
        {
            return Verse.AnimalSong("dog", "wow");
        }
    }
}
