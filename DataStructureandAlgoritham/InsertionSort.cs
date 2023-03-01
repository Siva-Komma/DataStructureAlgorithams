using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureandAlgoritham
{
    class InsertionSort
    {
        public static void Sorting()
        {
            int i, j;
            string temp=" " ;
            string[] arr = { "Siva", "Komma", "Jyothi" };
            for(i=1;i<arr.Length;i++)
            {
                for(j=i-1;j<arr.Length;j++)
                {
                    while(j>0 && arr[j].CompareTo(arr[j])>0)
                    {
                        temp = arr[i];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach(var ele in arr)
            {
                Console.WriteLine(ele) ;
            }
        }
    }
}
