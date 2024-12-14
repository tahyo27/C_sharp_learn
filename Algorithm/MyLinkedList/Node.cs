using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node
    {
        public T Data;
        public Node<T> Next;

        public Node(T data)
        {
            this.Data = data;
            this.Next = null;
        }
    }
}
