using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureandAlgoritham
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure and Algoritham");
            Console.WriteLine("Choose your Option: ");
            Console.WriteLine("1.Anagram\n2.Prime Number Range\n3.BubbleSort\n4.Insertion Sort");
            int Option=Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    Anagram ana = new Anagram();
                    ana.DisplayAnagram();
                    break;
                case 2:
                    PrimeNumbers.PrimeRange();
                    Console.ReadLine();
                    break;
                case 3:
                    BubbleSort.DisplayNumbers();
                    break;
                case 4:
                    InsertionSort.Sorting();
                    break;
            }
            Console.ReadLine();
        }
    }
}
