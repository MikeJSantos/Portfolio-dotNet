using System;
using System.Linq;
using System.Collections.Generic;

namespace LeetCode
{
    public class CountElements
    {
        public static int Run(int[] arr)
        {
            if (arr.Length < 2) return 0;

            var counter = 0;
            Array.Sort(arr);
            var duplicates = new Dictionary<int,int>();
            
            for (var i = 0; i < arr.Length - 1; i++)
            {                
                if (arr[i] + 1 == arr[i+1])
                    counter += duplicates.ContainsKey(arr[i]) ? duplicates[arr[i]] : 1;

                // Add duplicates to a dictionary
                if (arr[i] == arr[i+1])
                {
                    var j = i;
                    while (j < arr.Length - 1 && arr[j] == arr[j+1])
                        j++;
                    
                    duplicates[arr[i]] = j - i + 1;
                    i = j - 1;
                }
            }

            return counter;
        }
    }
}