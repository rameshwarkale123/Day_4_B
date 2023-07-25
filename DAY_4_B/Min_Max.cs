using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_4_B
{
    public class Min_Max

    {
        public void MinMax() 
        {
            int[] arr = { 47, 58, 77, 11, 90, 44, 30, 29 };
            int min  = arr[0];

            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("mini element in the array is : " + min);
            Console.WriteLine("max element in the array is : " + max);
        }
    }
}
