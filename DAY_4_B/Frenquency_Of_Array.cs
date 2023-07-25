using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_4_B
{
    public  class Frenquency_Of_Array
    {
        public  void MethodF()
        {
            string[] arr = { "R", "A", "M", "E", "S", "H", "W", "A", "R" };
            int[] frenc= new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i +1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        frenc[j] = -1;
                    }
               
                }
                if (frenc[i] != -1)
                {
                    frenc[i] = count; 
                }
            }
            Console.WriteLine("frequency of each element in the array : ");
            for (int i = 0; i < frenc.Length;i++)
            {
                if (frenc[i] != -1)
                {
                    Console.WriteLine(arr[i] + " : " + frenc[i] + "time");
                }
            }
        }
    }
}
