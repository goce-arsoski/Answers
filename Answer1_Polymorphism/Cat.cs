using Common;

namespace Answer1_Polymorphism
{
    public class Cat : Animal
    {
        public override string AnimalSong()
        {
            return Verse.AnimalSong("cat", "meow");
        }
    }
}
