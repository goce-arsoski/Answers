using Common;

namespace Answer1_Polymorphism
{
    public class Goat : Animal 
    {
        public override string AnimalSong()
        {
            return Verse.AnimalSong("goat", "maa");
        }
    }
}
