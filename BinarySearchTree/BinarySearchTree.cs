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
        //Initializing variables
        public int leftCount, rightCount;
        public bool result = false;

        //Declaring Properties
        public T NodeData { get; set; }
        public BinarySearchTree<T> LeftTree { get; set; }
        public BinarySearchTree<T> RightTree { get; set; }

        //Paramerterized constructor
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }


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
            Console.Write("Binary Tree:{0}", NodeData.ToString() + " "+ "\n");
            if (this.RightTree != null)
            {
                rightCount++;
                RightTree.Display();
            }
        }

        //Method to get the size of the binary tree(UC2)
        public void GetSize()
        {
            Console.WriteLine("Size of the binary tree is : " + (1 + this.leftCount + this.rightCount));
        }

        //Method to search the given value in the binary tree(UC3)
        //public bool IfValueExists(T data, BinarySearchTree<T> node)
        //{
        //    if (node == null)
        //    {
        //        return false;
        //    }
        //    if (node.NodeData.Equals(data))
        //    {
        //        result = true;
        //    }
        //    else if (data.CompareTo(node.NodeData) < 0)
        //    {
        //        IfValueExists(data, node.LeftTree);
        //    }
        //    else
        //    {
        //        IfValueExists(data, node.RightTree);
        //    }
        //    return result;
        //}
        public bool IfValueExists(T data, BinarySearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(data))
            {
                Console.WriteLine("Found the element in BST: " + node.NodeData);
                result = true;
            }
            else
            {
                Console.WriteLine("Current element is {0} in BST", node.NodeData);
            }
            if (data.CompareTo(node.NodeData) < 0)
            {
                IfValueExists(data, node.LeftTree);
            }
            if (data.CompareTo(node.NodeData) > 0)
            {
                IfValueExists(data, node.RightTree);
            }
            return result;
        }

    }
}
