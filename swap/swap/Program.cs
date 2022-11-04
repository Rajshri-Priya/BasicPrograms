using System;
public class Swap
{
    public static void Main(string[] args)
    {
        int number1, number2, temp;
        Console.Write("\nInput the First Number : ");
        number1 = Convert.ToInt32(Console.ReadLine());
        //20
        Console.Write("\nInput the Second Number : ");
        number2 = Convert.ToInt32(Console.ReadLine());
        //52
        temp = number1;//temp assigned by 20
        number1 = number2;//num1 assigned by 52
        number2 = temp;//number2 assigned by 20

        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + number1);//52
        Console.Write("\nSecond Number : " + number2);//20
    }
}