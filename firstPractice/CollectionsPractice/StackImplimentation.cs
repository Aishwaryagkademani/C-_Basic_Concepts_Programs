using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CollectionsPractice


{
    internal class StackImplimentation
    {
        public int count { get; private set; }
        private int[] stack;

        public StackImplimentation(int size)
        {
            stack = new int[size];
            count = 0;
        }

        public void push(int value)
        {
            if (count == stack.Length)
            {
                Console.WriteLine("stack is full");
            }
            else
            {
                stack[count++] = value;
            }
        }

        public int Pop()
        {
            int result = -1;
            if (count == 0)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                result = stack[--count];
            }
            return result;
        }

        public void Display()
        {
            if (count == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                for (int i = count-1; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            bool exit = false;
            StackImplimentation ob = new StackImplimentation(5);
            while (!exit)
            {
                Console.WriteLine("choose the operations:\n1.push\n2.pop\n3.Display");
                int key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("Insert a number: ");
                        int no = int.Parse(Console.ReadLine()); 
                        ob.push(no);
                        break;
                    case 2:
                        int pop = ob.Pop();
                        Console.WriteLine("poped element is :" + pop);
                        break;

                    case 3:
                        Console.WriteLine("Elements of stack are: ");
                        ob.Display();
                        break;

                    default: exit = true;
                        break;
                }
            } 
        }
    }
}
