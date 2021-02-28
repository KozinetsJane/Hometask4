using System;

namespace Hometask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число большее 0:");
            int end = int.Parse(Console.ReadLine());
            for (int i = 2; i <= end; i++)
            {
                bool b = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0 & i % 1 == 0)
                    {                   
                        b = false;
                    }
                }
                if (b)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.ReadKey();
        }
       

    }
}
