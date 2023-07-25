using System;
using System.Collections.Generic;
using System.Text;

namespace DAY_4_B
{
    public  class Sum_Digits
    {
        public void Sum()
        {
            int num = 36782
                ;
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine("The sum of digits is : "+ sum);
        }
    }
}
