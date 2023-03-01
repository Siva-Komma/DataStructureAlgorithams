using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataStructureandAlgoritham
{
    class PrimeNumbers
    {
        public static void PrimeRange()
        {
            int num1, num2, count = 0;
            Console.WriteLine("Enter Stating value: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter range: ");
            num2 = int.Parse(Console.ReadLine());
            for (int i = 1; i < num2; i++)
            {
                for (int j = 1; j < num2; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count==2)
                { 
                    Console.WriteLine(i);
                }
                count = 0;
            }
        }
    }
}
    

