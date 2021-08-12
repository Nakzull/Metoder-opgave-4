using System;

namespace Metoder_opgave_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber1 = 1;
            int startNumber2 = 10;
            CountUp(startNumber1);
            CountDown(startNumber2);
            Console.WriteLine("Number");
            int number = Convert.ToInt32(Console.ReadLine());
            CountUpAndDown(number);
        }
        public static void CountUp(int a)
        {
            for (int i = a;i<11;i++)
                Console.WriteLine(i);
        }
        public static void CountDown(int a)
        {
            for (int i = a; i>0; i--)
            {
                Console.WriteLine(i);
            }
        }
        public static void CountUpAndDown(int a)
        {
            for (int i = a; i <= a + 32; i++)
                Console.WriteLine(i);
            for (int i = a; i >= a - 16; i--)
                Console.WriteLine(i);
        }
    }
}
