using System;
using System.Collections;
using System.Text;

namespace CollectionsPractice
{
   
    internal class LinkedListImplementation <T>
    {
        public Node<T> first { get; private set; }
        public Node<T> last { get; private set;}
        public int count { get; private set;}
        public void AddFirst(Node<T> newNode)
        {
            if(this.first == null)
            {
                this.first = newNode;
                this.last = newNode;
            }
            else
            {
                this.last.Next = newNode;
                last = newNode;
            }
            count++;


        }
    }
}
