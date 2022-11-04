using System;
namespace power
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FOR CALCULATING POWER OF 2");
            Console.WriteLine("ENTER POWER FOR (2^n): ");
            int num = Convert.ToInt32(Console.ReadLine());
            int power=1;
            for (int i = 1; i <= num; i++)
            {
                power = (2 * power);
                Console.WriteLine(power);
            }
        }
    }
}