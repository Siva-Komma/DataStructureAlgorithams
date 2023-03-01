using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureandAlgoritham
{
    class PrimeAnagramPalindrome
    {
        public static void Checking()
        {
            int num,count = 0,rev=0,rem=0;
            Console.WriteLine("Enter value: ");
            num = int.Parse(Console.ReadLine());
            int temp = num;
            for (int j = 1; j <= num; j++)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("Prime: " + num);
                    while (num != 0)
                    {
                        rev = num % 10;
                        rem = (rem * 10) + rev;
                        num = num / 10;
                    }
                    Console.WriteLine("reverse" + rem);
                    if (temp == rem)
                    {
                        Console.WriteLine("{0} Palindrome ", rem);
                    }
                    else
                    {
                        Console.WriteLine("{0} not palindrome: ", rem);
                    }
                }
                else
                {
                    Console.WriteLine("Not Prime number: " + num);
                    break;
                }
            }
        }
    }
}
