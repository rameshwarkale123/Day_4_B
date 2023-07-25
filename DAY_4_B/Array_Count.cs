using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DAY_4_B
{
    public class Array_Count
    {

        public void  ArrayCount() 
        {
            int[] arr = { 1, 2, 3, 1, 2, 3};
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = i + 1; k < arr.Length; k++)
                {
                    if (arr[i] == arr[k])
                    {
                        count++;
                        break;
                    }

                }
            }
            Console.WriteLine("total num of duplicate element in the array : " + count);

        }
       

        

    }
}
