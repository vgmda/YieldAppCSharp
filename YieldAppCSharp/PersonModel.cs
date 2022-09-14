namespace YieldAppCSharp;

public class PersonModel
{
    public PersonModel(string firstName, string lastname)
    {
        FirstName = firstName;
        Lastname = lastname;
        Console.WriteLine($"Initialized user {FirstName} {Lastname}");
    }

    public string FirstName { get; set; }
    public string Lastname { get; set; }
}