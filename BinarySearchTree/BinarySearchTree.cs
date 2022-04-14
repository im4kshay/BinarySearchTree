using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Creating binary search tree using generics and IComparable to use CompareTo method in program(UC1)
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftCount = 0, rightCount = 0;

        //Method to check node and add node value to either left or right by comparing(UC1)
        public void Insert(T data)
        {
            T currentNodeValue = NodeData;
            if ((data.CompareTo(currentNodeValue)) < 0)
            {
                if (this.LeftTree == null)
                    this.LeftTree = new BinarySearchTree<T>(data);
                else
                    this.LeftTree.Insert(data);
            }
            else
            {
                if (this.RightTree == null)
                    this.RightTree = new BinarySearchTree<T>(data);
                else
                    this.RightTree.Insert(data);
            }
        }

        //Displaying the data in the binary tree(UC1)
        public void Display()
        {
            if (this.LeftTree != null)
            {
                leftCount++;
                LeftTree.Display();
            }
            Console.Write("Binary Tree:{0}", NodeData.ToString() + " " + "\n");
            if (this.RightTree != null)
            {
                rightCount++;
                RightTree.Display();
            }
        }

        //Method to get the size of the binary tree(UC2)
        public void GetSize()
        {
            Console.WriteLine("Size of the binary tree is : " + (this.leftCount + this.rightCount + 1 ));
        }
    }
}
