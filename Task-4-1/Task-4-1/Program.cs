using System;
using System.Collections.Generic;


namespace Task_4_1
{
    public class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public override bool Equals(object obj)
        {
            var user = obj as User;
            if (user == null)
                return false;

            return FirstName == user.FirstName && SecondName == user.SecondName;
        }
        public override int GetHashCode()
        {
            int firtsNameHashCode = FirstName?.GetHashCode() ?? 0;
            int secondNameHashCode = SecondName?.GetHashCode() ?? 0;
            return firtsNameHashCode ^ secondNameHashCode;
        }


    }

    class Program
    {
        

        static void Main(string[] args)
        {
            //string[] a=new string[10000];
            //for (int i = 0; i < 10000; i++)
            //{
            //    a[i] = "stroka";
            //}
            //a[6] = "gb";
            //Console.WriteLine($"{a[5]},{a[9999]},{a[6]}");
            var hashSet = new HashSet<User>();

            var user = new User() { FirstName = "Barbara", SecondName = "Santa" };

            hashSet.Add(user);

            var searchUsser = new User() { FirstName = "Barbara", SecondName = "Santa" };

            Console.WriteLine($"contains user {hashSet.Contains(user)}, contains searchUsser {hashSet.Contains(searchUsser)}");

        }
    }
}
