
namespace MyApp.Tests;

public class UnitTest1
{
    [Fact]
    public void divisible_by_four_is_a_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = leapYear.isLeapYear(4000);

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
    public void divisible_by_fourhundred_is_leap_year()
    {
        //Arrange
        var leapYear = new LeapYear();

        //Act
        var actual  = leapYear.isLeapYear(40000);

        //Assert
        actual.Should().Be(true);
    }

    [Fact]
    public void number_before_1582()
    {
        //Arrange
        var leapYear = new LeapYear();
        //Act
        var actual = leapYear.isLeapYear(1440);
        //Assert
        actual.Should().Be(false);
    }
    
    [Fact]
    public void negative_number_inserted()
    {
        //Arrange
        var leapYear = new LeapYear();
        //Act
        var actual = leapYear.isLeapYear(-4);
        //Assert
        actual.Should().Be(false);
    }
    
    
    [Fact]
    public void name()
    {
        //Arrange
        
        //Act
        
        //Assert
    }
    
        

}