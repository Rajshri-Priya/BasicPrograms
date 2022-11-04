using System;
namespace FlipCoin
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FLIP COIN");
            Console.WriteLine("Please enter the number of times you want Flip Coin.");
            int n = Convert.ToInt32(Console.ReadLine());
            int head = 0;
            double headpercent=0.0;
            Random random = new Random();
            //computation
            for (int i = 0; i < n; i++)
            {

                int Check = random.Next(0, 2);
                if (Check == 1)
                {
                    Console.WriteLine("head");
                    head += 1;
                   
                }
                else
                {
                    Console.WriteLine("tail");
                }
                headpercent = head/n*100;
            }
            Console.WriteLine("Head percentage is:" +headpercent);
            Console.WriteLine("tail percentage is:", + 100-headpercent);
        }
    }
}