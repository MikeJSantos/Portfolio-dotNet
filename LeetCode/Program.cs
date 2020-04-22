namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            RunMaxProfit();
        }

        static void RunCountElements()
        {
            var arr = new int[] {1,2,3}; // 2
            var retVal = CountElements.Run(arr);

            arr = new int[] {1,1,3,3,5,5,7,7}; // 0
            retVal = CountElements.Run(arr);

            arr = new int[] {1,3,2,3,5,0}; // 3
            retVal = CountElements.Run(arr);

            arr = new int[] {1,1,1,1,2,2}; // 2
            retVal = CountElements.Run(arr);
        }

        static void RunMaxProfit()
        {
            int[] intArray;
            int retVal ;

            // intArray = new int[] { 7, 1, 5, 3, 6, 4 }; // 7
            // retVal = MaxProfit.Run(intArray);

            // intArray = new int[] { 1, 2, 3, 4, 5 }; // 4
            // retVal = MaxProfit.Run(intArray);

            // intArray = new int[] { 7, 6, 4, 3, 1 }; // 0
            // retVal = MaxProfit.Run(intArray);

            // intArray = new int[] { 1,2 }; // 1
            // retVal = MaxProfit.Run(intArray);

            intArray = new int[] { 2,1,4,5,2,9,7 }; // 11
            retVal = MaxProfit.Run(intArray);
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
