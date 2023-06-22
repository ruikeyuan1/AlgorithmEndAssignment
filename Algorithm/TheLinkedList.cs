
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Algorithm
{
    public class TheLinkedList<T> : IEnumerable<T> where T : CsvClass
    {
        private TheNode<T> First { get; set; }

        private TheNode<T> Last { get; set; }

        public int Count { get; set; }

        public TheLinkedList()
        {
            this.First = null;
            this.Last = null;
            this.Count = 0;
        }

        public void AddFirst(T value)
        {
            var newNode = new TheNode<T>
            {
                Data = value,
                Next = null
            };

            //check if the list is empty
            if (this.First == null)
            {
                // this means the linked list is empty
                //insert the new node on point the head and tail to the node
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                newNode.Next = this.First;
                this.First = newNode;
            }
            Count++;
        }

        public void AddLast(T value)
        {
            var newNode = new TheNode<T>
            {
                Data = value,
                Next = null
            };

            //check if the list is empty
            if (this.First == null)
            {
                // this means the linked list is empty
                //insert the new node on point the head and tail to the node
                this.First = newNode;
                this.Last = newNode;
            }
            else
            {
                this.Last.Next = newNode;
                Last = newNode;
            }
            Count++;
        }

        public TheNode<T> AddAfter(T value, TheNode<T> existingNode)
        {
            // if you are adding after the last node, then you need to repoint Last Pointer
            var valueNode = new TheNode<T>
            {
                Next = existingNode.Next,
                Data = value,
            };

            if (this.Last == existingNode)
            {
                this.Last = valueNode;
            }

            return valueNode;
        }

        public TheNode<T> Find(T target)
        {
            TheNode<T> currentNode = First;

            while (currentNode != null && !currentNode.Data.Equals(target))
            {
                currentNode = currentNode.Next;
            }
            return currentNode;
        }

        public TheNode<T> findNodeByIndex(int index)
        {
            TheNode<T> currentNode = First;
            int count = 0;
            while (count != index)
            {
                currentNode = currentNode.Next;
                count++;
            }
            return currentNode;          
        }

        public bool RemoveFirst()
        {
            if (First == null || this.Count == 0)
            {
                //nothing to do . Return
                return false;
            }

            First = First.Next;
            this.Count--;
            return true;
        }

        public bool Remove(T value)
        {
            // in a perfect world, you would not need this
            if (First == null || this.Count == 0)
            {
                return false;
            }

            if (this.First.Data.Equals(value))
            {
                this.RemoveFirst();
                return true;
            }

            //else, you will need to traverse the linked list to find
            //the node to be removed and remove it

            TheNode<T> previous = First;
            TheNode<T> current = previous.Next;

            while (current != null && current.Next.Data.Equals(value))
            {
                // move to the next node
                previous = current;
                current = previous.Next;
            }

            // remove it 
            if (current != null)
            {
                previous.Next = current.Next;
                this.Count--;
                return true;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            TheNode<T> current = First;
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


        public TheLinkedList<T> bubbleSort(string compareType) // BubbleSort method
        {
            try
            {
                T temp;
                int n = Count;
                for (int i = 0; i < n - 1; i++)
                    for (int j = 0; j < n - i - 1; j++)
                        if (this.findNodeByIndex(j).Data.CompareTo(compareType, this.findNodeByIndex(j + 1).Data) > 0)
                        {
                            // swap temp and arr[i]
                            temp = this.findNodeByIndex(j).Data;
                            this.findNodeByIndex(j).Data = this.findNodeByIndex(j + 1).Data;
                            this.findNodeByIndex(j + 1).Data = temp;
                        }
                return this;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }         
        }

        public int binarySearch(string searchFor, string compareType)
        {
            this.bubbleSort(compareType);
            int high, low, mid;
            high = this.Count - 1;
            low = 0;
            mid = (high + low) / 2;

            if (this.findNodeByIndex(0).Data.CompareBySearchTerm(searchFor,compareType) == 0)
                return 0;
            else if (this.findNodeByIndex(high).Data.CompareBySearchTerm(searchFor, compareType) == 0)
                return high;
            else
            {
                while (low <= high)
                {
                    mid = (high + low) / 2;
                    if (this.findNodeByIndex(mid).Data.CompareBySearchTerm(searchFor, compareType) == 0)
                        return mid;
                    else if (this.findNodeByIndex(mid).Data.CompareBySearchTerm(searchFor, compareType) > 0)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                throw new ArgumentException($"Input not supported");
                //return -1;
            }
            
        }
    }
}
