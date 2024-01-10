using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsPractice
{
    internal class Node <T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; internal set; }
        public Node(T data)
        {
            this.Data = data;
        }
    }
}
