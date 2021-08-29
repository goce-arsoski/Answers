using Common;

namespace Answer1_Polymorphism
{
    public class Cow : Animal
    {
        public override string AnimalSong()
        {
            return Verse.AnimalSong("cow", "moo");
        }
    }
}
