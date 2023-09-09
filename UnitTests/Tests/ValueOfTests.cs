namespace ExperimentRunners;
using Experiments.WrapperTypes;

public class ValueOfTests
{
    private class EmailAddress : ValueOf<string, EmailAddress> { }

    [Fact]
    public void Day_AllowsDayToIntConversion()
    {
        // Arrange
        var primitive = "d@b.com";
        EmailAddress emailAddress = EmailAddress.From(primitive);  

        // Act
        var emailAddressValue = emailAddress.Value; 

        // Assert
        Assert.Equal(primitive, emailAddressValue);
    }
}