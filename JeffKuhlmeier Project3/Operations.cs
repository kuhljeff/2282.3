using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeffKuhlmeier_Project3
{
    class dasInputCalc : Form1
    {
/***********************************
calculateDasInput - JK
This function takes das-Input which is
in the form of reverse polish notation
and evaluates it! 
*************************************/
        internal static int calculateDasInput(string dasInput)
        {
            string[] dasToken = dasInput.Split(' '); //Works better than .trim() because this allows double digit calculations
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
/***********************************
 *cough*- JK
Being in the web section has the 
 * unfortunate consequence of 
 * ambiguity when it comes to assignment
 * expectations. In Exemplum:
 * Do I build queue and stack classes from
 * scratch, or do I "implement generic
 * Stack and Queue classes" from 
 * Systems.Collections.Generic...
 * ramble,ramble...
*************************************/