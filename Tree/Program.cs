using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTree
{
    public class Node
    {
        //1. fields of class : using recursion
        public int Data; 
        public Node Left;
        public Node Right; 
        public Node(int data)
        {
            //2. constructor: Data recieves a value
            this.Data = data;
        }
    }
    public class BinaryTree
    {
        //3. an instanse of object from class Node
        private Node _root;

        // 4. constructor: _root defined to be null by default
        public BinaryTree()
        {
            _root = null;
        }

        //5. recieving values from the user
        public void Insert(int data){
            // 6. If the tree is empty,set the root with the first value 
            if (_root == null)
            {
                _root = new Node(data);
                return;
            }
            // 7. Otherwise, find a correct place for the value using recursion
            InsertRec(_root, new Node(data));
        }
        private void InsertRec(Node root, Node newNode){
            //8. if their is a value in the root , this function finds the new value's place
            if (newNode.Data < root.Data){
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);
            }
            else{
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right, newNode);
            }
        }
  

        private void DisplayTree(Node root)
        {
            //9. printing the tree from the smallest value to the highest
            //this function recieves the root from a function with the same name
            if (root == null) return;

            DisplayTree(root.Left);
            Console.Write(root.Data + " ");
            DisplayTree(root.Right);
        }
        public void DisplayTree()
        {
            DisplayTree(_root);
        }
        public void ShowMax()
        {
            ShowMax(_root);
        }
        private void ShowMax(Node root)
        {
            if (root.Right == null)
                Console.WriteLine(root.Data);
            else
                ShowMax(root.Right);
        }
        public void ReverseDisp()
        {
            ReverseDisp(_root);
        }
        private void ReverseDisp(Node root)
        {
            if (root == null) return;

            ReverseDisp(root.Right);
            Console.Write(root.Data + " ");
            ReverseDisp(root.Left);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Insert(4);
            tree.Insert(10);
            tree.Insert(-32);
            tree.Insert(25);
            tree.Insert(232);
            tree.Insert(22);
            tree.Insert(2);
            tree.Insert(5);
            tree.Insert(1);
            tree.Insert(3);
            tree.DisplayTree();
            Console.WriteLine();
            tree.ShowMax();
            tree.ReverseDisp();
            Console.ReadLine();
        }
    }
}
