
namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void divisible_by_four_is_a_leap_year()
    {
        //Arrange

        //Act
        var actual  = LeapYear.IsLeapYear(4000);

        //Assert
        actual.Should().Be(true);

    }

    [Fact]
    public void six_is_not_a_leap_year()
    {
        //Arrange

        //Act
        var actual  = LeapYear.IsLeapYear(6);

        //Assert
        actual.Should().Be(false);
    }
    [Fact]
    public void hundred_is_not_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = LeapYear.IsLeapYear(100);

        //Assert
        actual.Should().Be(false);
    }
    
    [Fact]
    public void divisible_by_fourhundred_is_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = LeapYear.IsLeapYear(40000);

        //Assert
        actual.Should().Be(true);
    }

    [Fact]
    public void number_before_1582_is_()
    {
        //Arrange
        var leapYear = new LeapYear();
        //Act
        var actual = LeapYear.IsLeapYear(1440);
        //Assert
        actual.Should().Be(false);
    }
    
    [Fact]
    public void negative_number_inserted()
    {
        //Arrange
        var leapYear = new LeapYear();
        //Act
        var actual = LeapYear.IsLeapYear(-4);
        //Assert
        actual.Should().Be(false);
    }

    [Fact]
    public void non_integer_inserted()
    {
        //Arrange
        //Act
        Action actual = () => LeapYear.IsLeapYear("Hello");
        //Assert
        actual.Should().Throw<FormatException>();
    }
    
    
    [Fact]
    public void name()
    {
        //Arrange
        
        //Act
        
        //Assert
    }
    
        

}