using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
{
   public class TreeNode : ITree
    {
        public int Value { get; set; }
        public TreeNode RightChild { get; set; }
        public TreeNode LefttChild { get; set; }
        public TreeNode Parent { get; set; }
        public TreeNode Root { get; set; }
        public void AddItem(int value)
        {
            
            if (Root == null)
            {
                TreeNode root = new TreeNode { Value = value };
                Root = root;
            }
            
            
            else
            {
                Add(Root, value);
            }
        }
        public void Add(TreeNode node, int value)
        {
            TreeNode next = new TreeNode { Value = value };
            if (node.Value > value)
            {
                
                if (node.LefttChild == null)
                {
                    node.LefttChild = next;
                    next.Parent = node;
                }
                else
                {
                    
                    Add(node.LefttChild, value);
                }
            }
            else
            {
               
                if (node.RightChild == null)
                {
                    node.RightChild = next;
                    next.Parent = node;
                }
                else
                {
                   
                    Add(node.RightChild, value);
                }


            }
        }

        public TreeNode GetNodeByValue(int value)
        {
            TreeNode searchnode = Root;
            TreeNode tmp = null;
            while (searchnode != null)
            {
                int current = searchnode.Value.CompareTo(value);
                if (current > 0)
                {
                    tmp = searchnode;
                    searchnode = searchnode.LefttChild;

                }
                else if (current < 0)
                {
                    tmp = searchnode;
                    searchnode = searchnode.RightChild;
                }
                else
                {

                    return searchnode;
                    break;
                }
            }
            return searchnode;
        }

        public TreeNode GetRoot()
        {
            return Root;
        }

        public void PrintTree()
        {
            TreeHelper.Print(GetRoot());
        }

        public void RemoveItem(int value)
        {
            TreeNode remparent;
            TreeNode removenode = GetNodeByValue(value);
            if (removenode.RightChild == null)
            {

                int result = removenode.Parent.Value.CompareTo(removenode.Value);
                if (result > 0)
                {
                    removenode.Parent.LefttChild = removenode.LefttChild;

                }

                else if (result < 0)
                {
                    removenode.Parent.RightChild = removenode.LefttChild;

                }


            }
            else
            {
                int result = removenode.Parent.Value.CompareTo(removenode.Value);
                if (removenode.LefttChild == null)
                {
                    removenode.Parent.LefttChild = removenode.RightChild;

                }
                else if (removenode.LefttChild != null && removenode.RightChild.LefttChild == null)
                {
                    removenode.RightChild.LefttChild = removenode.LefttChild;
                    removenode.Parent.LefttChild = removenode.RightChild;

                }
                else if (removenode.LefttChild != null && removenode.RightChild.LefttChild != null)
                {
                    removenode.RightChild.LefttChild.LefttChild = removenode.LefttChild;
                    removenode.Parent.LefttChild = removenode.RightChild;

                }


            }
        }
    }
}
