namespace MyApp;

public class LeapYear
{
    public bool isLeapYear(int year)
    {
        if (year < 1582)
        {
            Console.Write(year);
            return false;
        } 
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }

                return false;
            }
            return true;
        }
        return false;
    }
}