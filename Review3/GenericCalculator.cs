using System;
using System.Collections.Generic;
using System.Text;
namespace Review3
{
    internal class GenericCalculator<T>
    {

        public static T Calculator(T m, T n, char op) 
        {
            dynamic a = m;
            dynamic b = n;
            T result = default(T); // Initialize result to a default value

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;

                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
               
            }
            return result;

        }

    }
}
