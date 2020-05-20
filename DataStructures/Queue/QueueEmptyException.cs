using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Queue
{
    public class QueueEmptyException : Exception
    {

        public QueueEmptyException()
        {
            string message = "Nope.";
            Console.WriteLine(message);
        }

    }
}
