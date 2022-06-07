using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskHome_07._06._2022
{
    static class Extensions
    {
        public static void Add(this int[] arr, int a) 
        {
            
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length - 1] = a;
            
        }
    }
}
