using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffKuhlmeier_Project3
{
    class dasInputCalc : Form1
    {
        internal static int CalculatedasInput(string dasInput)
        {
            string[] dasToken = dasInput.Split(' ');
            Stack<int> stack = new Stack<int>();
            int number = 0;

            foreach (string token in dasToken)
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
