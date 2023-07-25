using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_4_B
{
    public class star__pattern
    {
     //   int i, j;
        public void starPattern()
        {
            
            for(int  i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("\n");

            } 
        }

    }
}
