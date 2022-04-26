using System;
using System.Collections.Generic;
using System.Text;


namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public void number()
        {
            {
                int n, i, a, b, sum;
                Console.Write("Enter the starting  number : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the ending number : ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write("The Perfect numbers within the given Numbers : ");
                for (n = a; n <= b; n++)
                {
                    i = 1;
                    sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum = sum + i;
                        i++;
                    }
                    if (sum == n)
                        Console.Write("{0} ", n);
                }
                Console.Write("\n");
            }
        }
    }
}