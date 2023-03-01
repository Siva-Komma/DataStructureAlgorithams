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
            Anagram ana = new Anagram();    
            ana.DisplayAnagram();
            Console.ReadLine();
        }
    }
}
