using MyApp;

Console.WriteLine("Enter a year of your choice and we'll tell you if it's a leap year!");
var year = Console.ReadLine();
int yearInt = 0;

try {
    yearInt = Int32.Parse(year);
}catch (FormatException)
{
    Console.Write("Error! You must insert a year in the format XXXX, where X is a number!");
}catch (Exception E)
{
    Console.Write("Error! Unknown error has happened.");
    Console.Write(E.StackTrace);
}

if (LeapYear.IsLeapYear(yearInt))
{
    Console.Write("Yay");
}
else
{
    Console.Write("Nay");
}