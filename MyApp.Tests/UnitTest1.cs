
namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void four_is_a_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = leapYear.isLeapYear(4);

        //Assert
        actual.Should().Be(true);

    }

    [Fact]
    public void six_is_not_a_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = leapYear.isLeapYear(6);

        //Assert
        actual.Should().Be(false);
    }
    [Fact]
    public void hundred_is_not_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = leapYear.isLeapYear(100);

        //Assert
        actual.Should().Be(false);
    }
    
    [Fact]
    public void fourhundred_is_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = leapYear.isLeapYear(400);

        //Assert
        actual.Should().Be(true);
    }
    
        

}