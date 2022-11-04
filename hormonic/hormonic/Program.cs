using System;
namespace hormonic
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hormonic series like 1/1+1/2+1/3+1/4+....1/n");
            Console.WriteLine("enter the number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("1/{0} + ", i);
            }
        }
    }
}