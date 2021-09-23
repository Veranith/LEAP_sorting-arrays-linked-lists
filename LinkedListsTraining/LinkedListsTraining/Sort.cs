using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListsTraining
{
    public static class Sort
    {
        public static void Bubble(int[] arr)
        {
            while (true)
            {
                var count = 0;
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        Swap(arr, i, i + 1);
                        count++;
                    }
                }
                if (count == 0)
                {
                    break;
                }
                count = 0;
            }
        }


        public static void Selection(int[] arr)
        {
            for (int firstIndex = 0; firstIndex < arr.Length - 1; firstIndex++)
            {
                var lowestIndex = firstIndex;
                for (int secondIndex = firstIndex + 1; secondIndex < arr.Length; secondIndex++)
                {
                    if (arr[lowestIndex] > arr[secondIndex])
                    {
                        lowestIndex = secondIndex;
                    }
                }
                Swap(arr, firstIndex, lowestIndex);
            }
        }

        public static void Insertion(int[] arr)
        {
            throw new NotImplementedException();
        }

        public static void MergeSort(int[] arr)
        {
            throw new NotImplementedException();
        }
        private static void Swap(int[] arr, int firstIndex, int secondIndex)
        {
            var temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
}
