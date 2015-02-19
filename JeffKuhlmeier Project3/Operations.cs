using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffKuhlmeier_Project3
{
    class RPNCalc
    {
        public Queue mathQueue = new Queue();
        public Stack mathStack = new Stack();


        public static readonly Dictionary<char, Func<int, int, int>> functions = new Dictionary<char, Func<int, int, int>>()
        {
            {'+',add},
            {'-', subtract},
            {'/',divide},
            {'*',multiply}
        };

        static int add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int divide(int num1, int num2)
        {
            return num1 / num2;
        }


    }
}
