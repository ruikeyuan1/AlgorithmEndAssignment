using System.Xml.Linq;
using System;
using System.Collections.Generic;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Algorithm
{
    class BinaryTree<T> where T : CsvClass
    {
        public Node Root { get; set; }

        public List<T> traverseResult = new List<T>(); 

        public int height = -1;

        public class Node
        {
            public Node LeftNode { get; set; }
            public Node RightNode { get; set; }
            public T Data { get; set; }
        }

        public bool Add(T value,string compareBase)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value.CompareTo(compareBase, after.Data) < 0) //Is new node in left tree? 
                    after = after.LeftNode;
                else if (value.CompareTo(compareBase, after.Data) > 0) //Is new node in right tree?
                    after = after.RightNode;
                else
                {
                    //Exist same value
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)//Tree ise empty
                this.Root = newNode;
            else
            {
                if (value.CompareTo(compareBase, before.Data) < 0)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        public Node Find(string value,string compareBase)
        {
            return this.Find(value, this.Root, compareBase);
        }

        public void Remove(T value,string compareBase)
        {
            this.Root = Remove(this.Root, value, compareBase);
        }

        private Node Remove(Node parent, T key, string compareBase)
        {
            if (parent == null) return parent;
            if (key.CompareTo(compareBase, parent.Data) < 0)
            {
                parent.LeftNode = Remove(parent.LeftNode, key, compareBase);
            }
            else if (key.CompareTo(compareBase, parent.Data) > 0)
            {
                parent.RightNode = Remove(parent.RightNode, key, compareBase);
            }
           
            // if value is same as parent's value, then this is the node to be deleted  
            else
            {
                // node with only one child or no child  
                if (parent.LeftNode == null)
                    return parent.RightNode;
                else if (parent.RightNode == null)
                    return parent.LeftNode;

                // node with two children: Get the inorder successor (smallest in the right subtree)  
                parent.Data = MinValue(parent.RightNode);

                // Delete the inorder successor  
                parent.RightNode = Remove(parent.RightNode, parent.Data, compareBase);
            }
            return parent;
        }

        private T MinValue(Node node)
        {
            T minv = node.Data;

            while (node.LeftNode != null)
            {
                minv = node.LeftNode.Data;
                node = node.LeftNode;
            }
            return minv;
        }

        private Node Find(string valueToSearch, Node parent,string compareBase)
        {
            try
            {
                if (parent != null)
                {
                    if (parent.Data.CompareBySearchTerm(valueToSearch, compareBase) == 0) return parent;
                    if (parent.Data.CompareBySearchTerm(valueToSearch, compareBase) > 0)
                        return Find(valueToSearch, parent.LeftNode, compareBase);
                    else
                        return Find(valueToSearch, parent.RightNode, compareBase);
                }
                throw new Exception("value input invalid");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public int GetTreeDepth()
        {
            return this.GetTreeDepth(this.Root);
        }

        private int GetTreeDepth(Node parent)
        {
            return parent == null ? 0 : Math.Max(GetTreeDepth(parent.LeftNode), GetTreeDepth(parent.RightNode)) + 1;
        }

        public void TraversePreOrder(Node parent)
        {
            if (parent != null)
            {
                Console.WriteLine(parent.Data.StringValue + " ");
                this.traverseResult.Add(parent.Data);
                TraversePreOrder(parent.LeftNode);
                TraversePreOrder(parent.RightNode);
            }
        }

        public void TraverseInOrder(Node parent)
        {
            if (parent != null)
            {
                TraverseInOrder(parent.LeftNode);
                this.traverseResult.Add(parent.Data);
                Console.WriteLine(parent.Data.StringValue + " ");
                TraverseInOrder(parent.RightNode);
            }
        }

        public void TraversePostOrder(Node parent)
        {
            if (parent != null)
            {
                TraversePostOrder(parent.LeftNode);
                TraversePostOrder(parent.RightNode);
                this.traverseResult.Add(parent.Data);
                Console.WriteLine(parent.Data.StringValue + " ");
            }
        }

        // Helper function to find the height
        // of a given node in the binary tree
        public int findHeightUtil(Node root, string x, string compareBase)
        {
            // Base Case
            if (root == null)
            {
                return -1;
            }

            // Store the maximum height of
            // the left and right subtree
            int leftHeight = findHeightUtil(root.LeftNode, x,compareBase);

            int rightHeight = findHeightUtil(root.RightNode, x, compareBase);

            // Update height of the current node
            int ans = Math.Max(leftHeight, rightHeight) + 1;

            // If current node is the required node

            if (root.Data.CompareBySearchTerm(x, compareBase) == 0)
                height = ans;

            return ans;
        }

        // Function to find the height of
        // a given node in a Binary Tree
        public int findHeight(string value,string compareBase)
        {
            // Stores height of the Tree
            findHeightUtil(Root, value, compareBase);

            // Return the height
            return height;
        }

    }
}