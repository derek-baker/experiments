namespace Experiments.WrapperTypes;

/// <summary>
/// Example of how we can abstract away primitive integer values in favor of more domain-centric concepts.
/// This example assumes we're modelling a small set of possible states, similar to what we'd do with an enum.
/// </summary>
public record struct Day 
{
    private const int MAX_VALUE = 6;
    private readonly int day;

    public Day(int day) 
    {
        if (day > MAX_VALUE) throw new ArgumentOutOfRangeException(nameof(day));
        this.day = day; 
    }

    // TODO: Would we need constants for these int values?
    public static readonly Day Monday = 0;
    public static readonly Day Tuesday = 1;
    public static readonly Day Wednesday = 2;
    public static readonly Day Thursday = 3;
    public static readonly Day Friday = 4;
    public static readonly Day Saturday = 5;
    public static readonly Day Sunday = MAX_VALUE;

    public static implicit operator int(Day value) => value.day;
    public static implicit operator Day(int value) => new Day(value);
}