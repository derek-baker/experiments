namespace ExperimentRunners;
using Experiments.WrapperTypes;

public class StringWrapperTests
{
    [Fact]
    public void WorkItemStatus_SupportsStatusToStringConversion()
    {
        // Arrange
        // Act
        string readyValue = WorkItemStatus.Ready;

        // Assert
        Assert.Equal("ready", readyValue);
    }

    [Fact]
    public void WorkItemStatus_SupportsStringToStatusConversion()
    {
        // Arrange
        // Act
        WorkItemStatus readyStatus = "ready";

        // Assert
        Assert.Equal(WorkItemStatus.Ready, readyStatus);
    }
}