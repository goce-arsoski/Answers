using Common;

namespace Answer1_Polymorphism
{
    public class Pig : Animal
    {
        public override string AnimalSong()
        {
            return Verse.AnimalSong("pig", "wee");
        }
    }
}
