namespace YieldAppCSharp;

public class DataAccess
{
    public static IEnumerable<PersonModel> GetPeople()
    {

        yield return new PersonModel("First1", "Last1");
        yield return new PersonModel("First2", "Last2");
        yield return new PersonModel("First3", "Last3");

    }
}