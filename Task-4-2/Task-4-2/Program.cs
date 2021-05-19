using System;
using System.Collections.Generic;

namespace Task_4_2
{
    public class TestCase
    {
        public int []testtree { get; set; }
        public int counttree = 0;
        public TreeNode Node { get; set; }
        public  int CountTree(TreeNode root)
        {
            if (root != null)
            {
                counttree++;
                CountTree(root.LefttChild);

                CountTree(root.RightChild);
            }
            return counttree;
         }  
    }

    public interface ITree
    {
        TreeNode GetRoot();
        void AddItem(int value); // добавить узел
        void RemoveItem(int value); // удалить узел по значению
        TreeNode GetNodeByValue(int value); //получить узел дерева по значению
        void PrintTree(); //вывести дерево в консоль
    }

    class Program
    {
      
        
        public static TreeNode NewTree(TestCase testcase)
        {
            TreeNode tree = new TreeNode();
            for (int i = 0; i < testcase.testtree.Length; i++)
            {
                tree.AddItem(testcase.testtree[i]);

            }


            return tree.Root;


        }
        public static void TestTree(TreeNode node,TestCase testCase)
        {
            bool y = true;
            bool n = true;

            if (testCase.testtree.Length == testCase.CountTree(node.Root))
            {
                Console.WriteLine("VALID TEST");
            }
            else
            {
                Console.WriteLine("INVALID TEST");
            }
            for (int i = 0; i < testCase.testtree.Length; i++)
            {
                if (testCase.testtree[i] == node.GetNodeByValue(testCase.testtree[i]).Value)
                {
                    y = true;
                   
                }
                else if(testCase.testtree[i] == node.GetNodeByValue(testCase.testtree[i]).Value)
                {
                    n = false;
                }
                

            }
            if (y == n)
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
            TreeNode node = new TreeNode();
            TestCase testCase = new TestCase();
            testCase.testtree = new[] { 8, 4, 9, 8, 5, 3, 10 };
            node.Root=NewTree(testCase);
           
            TestTree(node, testCase);
            //Console.WriteLine(testCase.counttree);
            //node.PrintTree();







        }
    }
}
