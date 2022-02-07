using System;
namespace Sorting.Methods
{
    public class MergeSort : ISort
    {
        public MergeSort()
        {
        }

        public int[] Sort(int[] data)
        {
            if (data.Length <= 1)
                return data;

            int[] left, right;
            int x = 0;
            var midPoint = data.Length / 2;
            
            left = new int[midPoint];

            if (data.Length % 2 == 0)
                right = new int[midPoint];
            else
                right = new int[midPoint + 1];

            for (int i = 0; i < midPoint; i++)
                left[i] = data[i];

            for (int i = midPoint; i < data.Length; i++)
            {
                right[x] = data[i];
                x++;
            }

            left = Sort(left);
            right = Sort(right);
            return Merge(left, right);
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            var result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }
    }
}