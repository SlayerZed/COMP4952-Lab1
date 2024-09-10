namespace ZodiacAnimals.Models;
public class Zodiac
{
    public static string GetZodiac(int year) {
        string[] zodiac =
        [
            "Monkey",
            "Rooster",
            "Dog",
            "Pig",
            "Rat",
            "Ox",
            "Tiger",
            "Rabbit",
            "Dragon",
            "Snake",
            "Horse",
            "Goat",
        ];
        int remainder = year % 12;
        if (year < 1900 || year > 2025) {
            return "-1";
        }
        return zodiac[remainder];
    }
}