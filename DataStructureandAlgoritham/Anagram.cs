﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureandAlgoritham
{
    class Anagram
    {
        public void DisplayAnagram()
        {
            string str1 = "heater";
            string str2 = "reahet";
            char[] chr1 = str1.ToLower().ToCharArray();
            char[] chr2 = str2.ToLower().ToCharArray();
            Array.Sort(chr1);
            Array.Sort(chr2);
            string val1 = new string(chr1);
            string val2 = new string(chr2);
            if (val1 == val2)
            {
                Console.WriteLine("Both strings are anagram");
            }
            else
            {
                Console.WriteLine("Both strings are not anagram");
            }
        }
    }
}
