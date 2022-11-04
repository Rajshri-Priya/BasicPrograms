using System;
public class evenodd
{
    public static void Main()
    {
        int num, rem;
        Console.Write("Check whether a number is even or odd :\n");
        Console.Write("Enter Number : ");
        num = Convert.ToInt32(Console.ReadLine());
        rem = num % 2;
        if (rem == 0)
            Console.WriteLine("{0} is an even number.\n", num);
        else
            Console.WriteLine("{0} is an odd number.\n", num);
    }
}