namespace ExperimentRunners;
using Experiments.WrapperTypes;

public class IntWrapperTests
{
    [Fact]
    public void Day_AllowsDayToIntConversion()
    {
        // Arrange
        // Act
        int monday = Day.Monday;

        // Assert
        Assert.Equal(0, monday);
    }

    [Fact]
    public void Day_AllowsIntToDayConversion()
    {
        // Arrange
        // Act
        Day tuesday = 1;

        // Assert
        Assert.Equal(Day.Tuesday, tuesday);
    }
}