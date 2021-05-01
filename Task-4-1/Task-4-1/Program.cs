using System;
using System.Collections.Generic;


namespace Task_4_1
{
   class TestCase
    {
       public int Count;
    }


  

    class Program
    {
      
        public static string[] FillArray()
        {
            string str = "stroka";
            string[] a = new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                a[i] = str + i;
            }
            return a;
        }
        public static HashSet<string> FillHash()
        {
            string str = "stroka";
           var hashSet = new HashSet<string>();
            for (int i = 0; i < 10000; i++)
            {
                hashSet.Add(str + i);
            }
            return hashSet;
        }
        public static void SearchArray(string[]a,string search)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == search)
                {
                    Console.WriteLine($"Найдена строка {search}");
                }

            }

        }
        public static void SearchHash(HashSet<string> hashSet,string search)
        {
            if (hashSet.Contains(search))
            {
                Console.WriteLine($"Найдена строка {search}");
            }
            

        }
        public static void TestFill(TestCase testCase)
        {
            if (testCase.Count == FillArray().Length&&testCase.Count==FillHash().Count)
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }

        }
        
       

        static void Main(string[] args)
        {
            TestCase testCase = new TestCase { Count = 10000 };
            TestFill(testCase);


        }
    }
}
