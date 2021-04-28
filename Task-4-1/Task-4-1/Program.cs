using System;

namespace Task_4_1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] a=new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                a[i] = "stroka";
            }
            a[6] = "gb";
            Console.WriteLine($"{a[5]},{a[9999]},{a[6]}");
        }
    }
}
