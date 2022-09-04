using MyApp;

var leapYear = new LeapYear();

Console.Write("Enter a year of your choice and we'll tell you if it's a leap year!");
Console.WriteLine();
var year = Console.ReadLine();
var yearInt = Int32.Parse(year);

if (leapYear.isLeapYear(yearInt))
{
    Console.Write("Yay");
}
else
{
    Console.Write("Nay");
}