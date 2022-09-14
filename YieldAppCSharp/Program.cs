using System;

namespace YieldAppCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*** Start of the App ***");

        var people = DataAccess.GetPeople();

        foreach (var p in people)
        {
            Console.WriteLine($"Read{p.FirstName} {p.Lastname}");
        }

        Console.WriteLine("*** End of the App ***");

        Console.ReadLine();
    }

}

public class DataAccess
{
    public static IEnumerable<PersonModel> GetPeople()
    {


        yield return new PersonModel("First1", "Last1");
        yield return new PersonModel("First2", "Last2");
        yield return new PersonModel("First3", "Last3");


    }
}