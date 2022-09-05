using MyApp;

var running = true;
while (running)
{
    
    //Information:
    Console.WriteLine("---Enter a year of your choice and we'll tell you if it's a leap year!---");
    Console.WriteLine("---If you wish to exit, simply type \"Exit\".---");
    Console.Write("Year: ");
    
    //Reading input and converting to int:
    var year = Console.ReadLine();
    if (year.Equals("Exit")  || year.Equals("exit"))
    {
        Console.WriteLine("Exiting...");
        break;
    }
    int yearInt = 0;
    try {
        yearInt = Int32.Parse(year);
    }catch (FormatException)
    {
        Console.WriteLine("### Error! You must insert a year in the format XXXX, where X is a number! ###");
        continue;
    }catch (Exception E)
    {
        Console.Write("Error! Unknown error has happened. Exiting...");
        Console.Write(E.StackTrace);
        break;

    }

    //Checking if input is a leap year:
    if (LeapYear.IsLeapYear(yearInt))
    {
        Console.WriteLine("Yay");
    }
    else
    {
        Console.WriteLine("Nay");
    }
}