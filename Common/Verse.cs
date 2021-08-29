using System;

namespace Common
{
    public static class Verse
    {
        public static string AnimalSong(string animalType, string animalSound)
        {
            if (string.IsNullOrWhiteSpace(animalType) || string.IsNullOrWhiteSpace(animalSound))
            {
                return "Please insert animal type or animal sound";
            }

            String song = $"Old MacDonald had a farm, E I E I O,\n" +
                          $"And on his farm he had a {animalType}, E I E I O.\n" +
                          $"With a {animalSound} {animalSound} here and a {animalSound} there,\n" +
                          $"Here a {animalSound}, there a {animalSound}, ev'rywhere a {animalSound} {animalSound}.\n" +
                          $"Old MacDonald had a farm, E I E I O.\n";
            return song;
        }
    }
}
