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
            {'+',Add},
            {'-', Subtract},
            {'/',Divide},
            {'*',Multiply}
        };

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }


    }
}
