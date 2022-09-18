using MapsterPlayground.Entities;

namespace MapsterPlayground;

public static class UserGenerator
{
    public static User GenerateRandom()
    {
        int[] Ids = { 1, 2, 3, 4, 6, 7, 8, 9, 10 };
        string[] FirstNames = { "José", "Maria", "João", "Abel", "Daniela", "Angelo", "Lidiana", "Adolfo" };
        string[] LastNames = { "Costa", "Adams", "Santos", "Santana", "Aguiar" };

        var random = new Random();

        var Id = random.Next(10);
        var FirstName = FirstNames[random.Next(FirstNames.Length)];
        var LastName = LastNames[random.Next(LastNames.Length)];

        return new User(Id, FirstName, LastName);
    }
}