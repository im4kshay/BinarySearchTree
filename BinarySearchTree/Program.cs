using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            //Displaying Welcome Message
            Console.WriteLine("=-=-=-=-=-=-=-=Welcome To The Binary Search Tree Program=-=-=-=-=-=-=-=");

            //Creating binary search tree to insert and display node values(UC1)
            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Insert(22);
            binaryTree.Insert(40);
            binaryTree.Insert(60);
            binaryTree.Insert(95);
            binaryTree.Insert(11);
            binaryTree.Insert(65);
            binaryTree.Insert(3);
            binaryTree.Insert(16);
            binaryTree.Insert(6);
            binaryTree.Insert(67);

            //Display inputs
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Created A Binary Search Tree");
            Console.WriteLine("--------------------------------");

            binaryTree.Display();

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Checking Size Of Binary Search Tree");
            Console.WriteLine("--------------------------------");

            binaryTree.GetSize();

            Console.WriteLine("--------------------------------");

            Console.ReadLine();
        }
    }
}
