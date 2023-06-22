using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class Stack<T> : IEnumerable<T> where T : CsvClass
    {
        private TheNode<T> top;
        public Stack()
        {
            top = null;
        }
        public void Push(T value)
        {
            TheNode<T> newNode = new TheNode<T>(value);
            newNode.Next = top;
            top = newNode;
        }
        public TheNode<T> Pop()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }
            TheNode<T> node = top;
            top = top.Next;
            return node;
        }
        public TheNode<T> Peek()
        {
            if (top == null)
            {
                throw new Exception("Stack is empty");
            }
            return top;
        }
        public bool IsEmpty()
        {
            return top == null;
        }

        public void mergeSort(string compareBase)
        {
            if (top == null || top.Next == null)
            {
                //throw new ArgumentException($"Input not supported");
                return;
            }
            TheNode<T> middle = getMiddle();
            TheNode<T> nextOfMiddle = middle.Next;
            middle.Next = null;
            Stack<T> left = new Stack<T>();
            left.top = top;
            Stack<T> right = new Stack<T>();
            right.top = nextOfMiddle;
            left.mergeSort(compareBase);
            right.mergeSort(compareBase);
            top = merge(left.top, right.top, compareBase);
        }

        public TheNode<T> merge(TheNode<T> left, TheNode<T> right, string compareBase)
        {
            if (left == null)
            {
                return right;
            }
            if (right == null)
            {
                return left;
            }
            if (left.Data.CompareTo(compareBase,right.Data) < 0)
            {
                left.Next = merge(left.Next, right, compareBase);
                return left;
            }
            else
            {
                right.Next = merge(left, right.Next, compareBase);
                return right;
            }
        }

        public TheNode<T> getMiddle()
        {
            if (top == null)
            {
                return top;
            }
            TheNode<T> slow = top;
            TheNode<T> fast = top;
            while (fast.Next != null && fast.Next.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
            }
            return slow;
        }

        public Stack<T> insertionSort(string compareBase)
        {
            TheNode<T> sorted = null;
            TheNode<T> current = top;
            while (current != null)
            {
                TheNode<T> next = current.Next;
                sorted = sortedInsert(sorted, current, compareBase);
                current = next;
            }
            top = sorted;
            return this;
        }

        public TheNode<T> sortedInsert(TheNode<T> sorted, TheNode<T> newNode, string compareBase)
        {
            if (sorted == null || sorted.Data.CompareTo(compareBase, newNode.Data) > 0)
            {
                newNode.Next = sorted;
                sorted = newNode;
                return sorted;
            }
            else
            {
                TheNode<T> current = sorted;
                while (current.Next != null && current.Next.Data.CompareTo(compareBase,newNode.Data) < 0)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                return sorted;
            }
        }

        public TheNode<T> linearSearch(string searchFor, string compareType)
        {
            TheNode<T> current = top;
            while (current != null)
            {
                if (current.Data.CompareBySearchTerm(searchFor, compareType) == 0)
                {
                    return current;
                }
                current = current.Next;
            }
            throw new ArgumentException($"Input not supported");
        }

        public IEnumerator<T> GetEnumerator()
        {
            TheNode<T> current = top;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }

}