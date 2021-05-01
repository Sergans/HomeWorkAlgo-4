using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;



namespace Task_4_1
{
   class TestCase
    {
       public int Count;
       //public string[] arr;
       //public HashSet<string> hash;
       //public  string str = "stroka5999";
    }
    public  class ArrHash
    {
        public  string[] arr { get; set; }
        public  HashSet<string> hash { get; set; }
        public  string str = "stroka5999";

        
        public  string[] FillArray()
        {
            string str = "stroka";
            string[] a = new string[10000];
            for (int i = 0; i < 10000; i++)
            {
                a[i] = str + i;
            }
            return a;
        }
        public  HashSet<string> FillHash()
        {
            string str = "stroka";
            var hashSet = new HashSet<string>();
            for (int i = 0; i < 10000; i++)
            {
                hashSet.Add(str + i);
            }
            return hashSet;
        }
        public  bool SearchArray(string[] a, string search)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == search)
                {
                    return true;
                }

            }return false;

        }
        public  bool SearchHash(HashSet<string> hashSet, string search)
        {
            if (hashSet.Contains(search))
            {
                return true;
            }
            return false;


        }
        [Benchmark]
        public  void TestArBench()
        {
            arr = FillArray();
           
            SearchArray(arr,str);

        }
        [Benchmark]
        public  void TestHashBench()
        {
            hash = FillHash();
            
            SearchHash(hash,str);

        }




    }

    class Program
    {
      
        //public void TestFill(TestCase testCase)
        //{
        //    if (testCase.Count == FillArray().Length&&testCase.Count==FillHash().Count)
        //    {
        //        Console.WriteLine("VALID TEST");
        //    }
        //    else
        //    {
        //        Console.WriteLine("INVALID TEST");
        //    }

        //}
        
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
           

            //arrHash.arr = arrHash.FillArray();
            //arrHash.hash = arrHash.FillHash();

           // Console.ReadKey();
            
            

        }
    }
}
