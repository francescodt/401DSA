using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    class ArrayReverse
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            /* for (int i = arr.Length -1; i >= 0; i--)
             * {
             *      Console.Write(arr[i]);
             * }
             */
            int length = arr.Length - 1;
            string strReverse = null;

            while (length >= 0)
            {
                strReverse = strReverse + arr[length];
                length--;
            }
            Console.WriteLine();
            Console.WriteLine("Reverse Array is " + " " + strReverse);
            Console.ReadLine();
        }
    }
}
