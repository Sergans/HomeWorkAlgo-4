using System;
using System.Collections.Generic;

namespace Task_4_2
{
    public class TestCase
    {
        public int []testtree { get; set; }
        public int counttree { get; set; }
        public TreeNode Node { get; set; }


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
        public static void CountTree(TreeNode root)
        {

        }
        public static TreeNode TestTree(TestCase testcase)
        {
            TreeNode tree = new TreeNode();
            for (int i = 0; i < testcase.testtree.Length; i++)
            {
                tree.AddItem(testcase.testtree[i]);

            }


            return tree.Root;


        }
        static void Main(string[] args)
        {
            TreeNode node = new TreeNode();
            TestCase testCase = new TestCase();
            testCase.testtree = new[] { 8, 4, 9, 8, 5, 3, 10 };
            node.Root=TestTree(testCase);
            node.PrintTree();

            
            
            
           
            
           
        }
    }
}
