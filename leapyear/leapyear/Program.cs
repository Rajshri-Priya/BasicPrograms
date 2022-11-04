using System;
namespace leapyear
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LEAP YEAR");
            Console.WriteLine("ENTER YEAR FOR CHECKING : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999 && year < 10000)
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine(year +" is leap year");
                }
                else
                    Console.WriteLine(year +" is not leap year");
            }
            else
            {
                Console.WriteLine(" please write 4 digit year");
            }
        }
    }
}