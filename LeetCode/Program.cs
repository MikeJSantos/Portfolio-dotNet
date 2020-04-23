namespace LeetCode
{
    class Program
    {
        static Solution s;

        static void Main(string[] args)
        {
            s = new Solution();
            RunLastStoneWeight();
        }

        static void RunCountElements()
        {
            var arr = new int[] {1,2,3}; // 2
            var retVal = s.CountElements(arr);

            arr = new int[] {1,1,3,3,5,5,7,7}; // 0
            retVal = s.CountElements(arr);

            arr = new int[] {1,3,2,3,5,0}; // 3
            retVal = s.CountElements(arr);

            arr = new int[] {1,1,1,1,2,2}; // 2
            retVal = s.CountElements(arr);
        }

        static void RunMaxProfit()
        {
            int[] intArray;
            int retVal ;

            intArray = new int[] { 7, 1, 5, 3, 6, 4 }; // 7
            retVal = s.MaxProfit(intArray);

            intArray = new int[] { 1, 2, 3, 4, 5 }; // 4
            retVal = s.MaxProfit(intArray);

            intArray = new int[] { 7, 6, 4, 3, 1 }; // 0
            retVal = s.MaxProfit(intArray);

            intArray = new int[] { 1,2 }; // 1
            retVal = s.MaxProfit(intArray);

            intArray = new int[] { 2,1,4,5,2,9,7 }; // 11
            retVal = s.MaxProfit(intArray);
        }

        static void RunMiddleNode()
        {
            var head1 = ListNode.Build(new int[] {1,2,3,4,5});
            var output1 = new MiddleNode().Run(head1);

            var head2 = ListNode.Build(new int[] {1,2,3,4,5,6});
            var output2 = new MiddleNode().Run(head2);

            System.Console.WriteLine();
        }

        static void RunBackspaceCompare()
        {
            bool output;

            output = s.BackspaceCompare("ab#c", "ad#c"); // true, "ac"
            output = s.BackspaceCompare("ab##", "c#d#"); // true, ""
            output = s.BackspaceCompare("a##c", "#a#c"); // true, "c"
            output = s.BackspaceCompare("a#c", "b");     // false, "c" > "b"
        }

        static void RunMinStack()
        {
            var retVal = 0;
            var minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            retVal = minStack.GetMin(); // return -3
            minStack.Pop();
            minStack.ToString();
            retVal = minStack.Top();    // return 0
            retVal = minStack.GetMin(); // return -2
        }

        static void RunLastStoneWeight()
        {
            int[] stones;
            int retVal;

            stones = new int[] {2,7,4,1,8,1}; // 1
            retVal = s.LastStoneWeight(stones);

            stones = new int[] {7,6,7,6,9}; // 3
            retVal = s.LastStoneWeight(stones);
        }
    }
}
