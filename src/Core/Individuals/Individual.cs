namespace GildedRoseKata.Individuals;

public class Individual
{
    public required string FirstName { get; init; }

    public required string LastName { get; init; }

    public required DateOnly BirthDate { get; init; }

    public required string Nationality { get; init; }
}
