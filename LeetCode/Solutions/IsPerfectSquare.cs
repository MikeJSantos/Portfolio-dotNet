namespace LeetCode
{
    public partial class Solution
    {
        // TODO: Optimize. Time Limit Exceeded on "2147483647"
        public bool IsPerfectSquare(int num)
        {
            if (num < 1) return false;

            for (var i = 1; i < int.MaxValue; i++)
            {
                var squared = i * i;

                if (squared == num) return true;

                if (squared > num) return false;
            }

            return false;
        }
    }
}