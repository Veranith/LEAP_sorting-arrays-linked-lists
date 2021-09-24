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
            for (int firstIndex = 1; firstIndex < arr.Length; firstIndex++)
            {
                for (int secondIndex = 0; secondIndex < firstIndex; secondIndex++)
                {
                    if (arr[firstIndex] < arr[secondIndex])
                    {
                        Swap(arr, firstIndex, secondIndex);
                    }
                }
            }
        }

        public static int[] MergeSort(int[] arr)
        {
            // Base case
            if (arr.Length <= 1) return arr;

            // Split array
            //decimal middle = arr.Length / 2;
            //var middle = (int)Math.Ceiling((decimal)(arr.Length / 2.0));
            int middle = arr.Length / 2;
            var topArray = arr.Take(middle).ToArray();
            var bottomArray = arr.Skip(middle).ToArray();

            // Recursively sort each side
            topArray = MergeSort(topArray);
            bottomArray = MergeSort(bottomArray);


            // Merge results
            return Combine(topArray, bottomArray);

        }

        private static int[] Combine(int[] topArray, int[] bottomArray)
        {
            var sortedArray = new int[topArray.Length + bottomArray.Length];

            var topIndex = 0;
            var bottomIndex = 0;
            var sortedIndex = 0;

            while (topIndex < topArray.Length && bottomIndex < bottomArray.Length)
            {
                if (bottomArray[bottomIndex] > topArray[topIndex])
                {
                    sortedArray[sortedIndex] = topArray[topIndex];
                    topIndex++;
                }
                else
                {
                    sortedArray[sortedIndex] = bottomArray[bottomIndex];
                    bottomIndex++;
                }
                sortedIndex++;
            }

            if (topIndex < topArray.Length)
            {
                for (int i = topIndex; i < topArray.Length; i++)
                {
                    sortedArray[sortedIndex] = topArray[i];
                    sortedIndex++;
                }
            }
            else
            {
                for (int i = bottomIndex; i < bottomArray.Length; i++)
                {
                    sortedArray[sortedIndex] = bottomArray[i];
                    sortedIndex++;
                }
            }


            return sortedArray;
        }

        private static void Swap(int[] arr, int firstIndex, int secondIndex)
        {
            var temp = arr[firstIndex];
            arr[firstIndex] = arr[secondIndex];
            arr[secondIndex] = temp;
        }
    }
}
