namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMiddleNode();
        }

        static void RunMaxProfit()
        {
            var intArray = new int[] { 7, 1, 5, 3, 6, 4 }; // 7
            var retVal = new MaxProfit().Run(intArray);

            intArray = new int[] { 1, 2, 3, 4, 5 }; // 4
            retVal = new MaxProfit().Run(intArray);

            intArray = new int[] { 7, 6, 4, 3, 1 }; // 0
            retVal = new MaxProfit().Run(intArray);
        }

        static void RunMiddleNode()
        {
            var head1 = ListNode.Build(new int[] {1,2,3,4,5});
            var output1 = new MiddleNode().Run(head1);

            var head2 = ListNode.Build(new int[] {1,2,3,4,5,6});
            var output2 = new MiddleNode().Run(head2);

            System.Console.WriteLine();
        }
    }
}
