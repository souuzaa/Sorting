using System;
namespace Sorting.Methods
{
    public class BubbleSort : ISort
    {
        public int[] Sort(int[] data)
        {
            int tmp = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - 1; j++)
                {
                    if (data[j] > data[j + 1])
                    {
                        tmp = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = tmp;
                    }
                }
            }
            return data;
        }
    }
}

