using System;
using System.Threading;

namespace Thread_Examples
{
    class Program
    {

        public static Thread Thread1;
        public static Thread Thread2;
        static Random random = new Random();
        

        static void Main(string[] args)
        {
            Thread1 = new Thread(ThrowDice1);
            Thread1.IsBackground = true;
            Thread1.Start();

            Console.ReadLine();
        }

        static void ThrowDice1()
        {
            Thread2 = new Thread(ThrowDice2);
            Thread2.IsBackground = true;
            Thread2.Start();

            for (int i = 0; i < 100; i++)
            {
                int sayi = random.Next(1,7);
                Console.WriteLine("1. Atılan Zar : " + sayi);
                Thread.Sleep(100);
            }
        }

        static void ThrowDice2()
        {
            for (int i = 0; i < 100; i++)
            {
                int sayi2 = random.Next(1, 7);
                Console.WriteLine("2. Atılan Zar : " + sayi2);
                Thread.Sleep(100);
            }
        }

    }
}
