using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges.BaseBaseBase
{
    public class MergeSort
    {

        public static int[] MergeSortAlgo(int[] arr)
        {

            int[] leftHalf;
            int[] rightHalf;
            int[] result = new int[arr.Length];

            if (arr.Length <= 1)
                return arr;

            int mid = arr.Length / 2;
            leftHalf = new int[mid];


            if (arr.Length % 2 == 0)
                rightHalf = new int[mid];

            else
                rightHalf = new int[mid + 1];

            for (int i = 0; i < mid; i++)
                leftHalf[i] = arr[i];

            int x = 0;

            for (int i = mid; i < arr.Length; i++)
            {
                rightHalf[x] = arr[i];
                x++;
            }

            leftHalf = MergeSortAlgo(leftHalf);

            rightHalf = MergeSortAlgo(rightHalf);

            result = Merge(leftHalf, rightHalf);
            return result;
        }


        public static int[] Merge(int[] leftArr, int[] rightArr)
        {
            int resultLength = rightArr.Length + leftArr.Length;
            int[] result = new int[resultLength];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < leftArr.Length || j < rightArr.Length)
            {

                if (i < leftArr.Length && j < rightArr.Length)
                {

                    if (leftArr[i] <= rightArr[j])
                    {
                        result[k] = leftArr[i];
                        i++;
                        k++;
                    }

                    else
                    {
                        result[k] = rightArr[j];
                        j++;
                        k++;
                    }
                }

                else if (i < leftArr.Length)
                {
                    result[k] = leftArr[i];
                    i++;
                    k++;
                }

                else if (j < rightArr.Length)
                {
                    result[k] = rightArr[j];
                    j++;
                    k++;
                }
            }
            return result;
        }


    }
}
