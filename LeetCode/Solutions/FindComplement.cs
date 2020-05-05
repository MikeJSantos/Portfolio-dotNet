using System;

namespace LeetCode
{
    public partial class Solution
    {
        public int FindComplement(int num)
        {
            var binaryArray = Convert.ToString(num, 2).ToCharArray();
            
            for(var i = 0; i < binaryArray.Length; i++)
            {
                binaryArray[i] = binaryArray[i] == '1'
                    ? '0'
                    : '1';
            }

            return Convert.ToInt32(new string(binaryArray), 2);
        }
    }
}