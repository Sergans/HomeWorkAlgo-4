using System;

namespace Task_4_2
{

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
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode();
            tree.AddItem(8);
            tree.AddItem(1);
            tree.AddItem(9);
            tree.PrintTree();
           
        }
    }
}
