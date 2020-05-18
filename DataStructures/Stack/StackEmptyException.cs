using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Stack
{
    public class StackEmptyException : Exception
    {

        public StackEmptyException()
        {
            string message = "Nope.";
            Console.WriteLine(message);
        }

    }
}
