using System;
namespace Sorting.Methods
{
	public class InsertionSort : ISort
	{
		public InsertionSort()
		{
		}

        public int[] Sort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int val = data[i];
                int flag = 0;
                for (int j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = val;
                    }
                    else flag = 1;
                }
            }

            return data;
        }
    }
}

