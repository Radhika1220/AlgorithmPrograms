using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmPrograms1
{
    class BubbleSort<T> where T:IComparable
    {
        public void BubbleSortInArray(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i <= n- 2; i++)

            {

                for (int j = n- 1; j >= 1; j--)

                {
                    if (arr[j].CompareTo(arr[j - 1]) < 0)

                    {

                        T temp = arr[j];

                        arr[j] = arr[j - 1];

                        arr[j - 1] = temp;

                    }
                }
            }
        }
        public void PrintArray(T[] arr)
        {
            Console.WriteLine("The Sorted array Using Bubble Sort : ");
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
    }
}
