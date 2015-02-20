using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffKuhlmeier_Project3
{
    class RPNCalc : Form1
    {
        public Queue mathQueue = new Queue();


        public static readonly Dictionary<char, Func<int, int, int>> operation = new Dictionary<char, Func<int, int, int>>()
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



        internal static int CalculateRPN(string rpn)
        {
            string[] rpnTokens = rpn.Split(' ');
            Stack<int> stack = new Stack<int>();
            int number = 0;

            foreach (string token in rpnTokens)
            {
                if (int.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    switch (token)
                    {
                        case "*":
                            {
                                stack.Push(stack.Pop() * stack.Pop());
                                break;
                            }
                        case "/":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() / number);
                                break;
                            }
                        case "+":
                            {
                                stack.Push(stack.Pop() + stack.Pop());
                                break;
                            }
                        case "-":
                            {
                                number = stack.Pop();
                                stack.Push(stack.Pop() - number);
                                break;
                            }
                        default:
                            
                            break;
                    }
                }
                
            }

            return stack.Pop();
        }



    }
}
