using System;
using System.Collections;
using System.Text;
using DataStructures.Stack;

namespace Challenges.QueueStacks
{
    public class MultiBracketValidation
    {

        public static bool braceCheck(string braces)
        {
            Stacks<char> newStack = new Stacks<char>();
            int openBracesInString = 0;
            int closedBracesInString = 0;

            for (int i = 0; i <= braces.Length - 1; i++)
            {
                if (braces[i] == '{' || braces[i] == '[' || braces[i] == '(')
                {
                    newStack.Push(braces[i]);
                    openBracesInString++;
                }

                else if(braces[i] == '}' || braces[i] == ')' || braces[i] == ']')
                {
                    closedBracesInString++;
                    if(!ValidateBraces(newStack.Pop(), braces[i]))
                    {
                        return false;
                    }
                }

                if(i >= braces.Length - 1)
                {
                    if(openBracesInString != closedBracesInString)
                    {
                        return false;
                    }
                }
            }

            return true;

        }

        public static bool ValidateBraces(char a, char b)
        {
            return a == '(' && b == ')' || a == '[' && b == ']' || a == '{' && b == '}';
        }

    } 
}
