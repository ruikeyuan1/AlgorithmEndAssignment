using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the node class for LinkList and Stack
namespace Algorithm
{
    public class TheNode<T> 
    {
        //Data
        public T Data { get; set; }
        //Link
        public TheNode<T> Next { get; set; }

        public TheNode() { }

        public TheNode(T data)
        {
            Data = data;
        }
    }
}
