using System;
using System.Collections.Generic;

namespace Stack
{
    public class LargestRectangle
    {
        public Stack<int> stack;
        public LargestRectangle(int size)
        {
            stack = new Stack<int>(size);
        }

        //buildingHeight = 1 2 3 4 5
        private int FindMaxArea(int[] buildingHeight)
        {
            int count = 0;
            int maxArea = int.MinValue;
            for (int i = 0; i < buildingHeight.Length; i++)
            {
                //Push= 1 2 3 4 5
                if (stack.Count == 0 || stack.Peek() < buildingHeight[i])
                    stack.Push(buildingHeight[i]);
                else
                {
                    count = 0;
                    while(stack.Count != 0 && stack.Peek() > buildingHeight[i])
                    {
                        count++;
                        maxArea = Math.Max(maxArea, (stack.Pop() * count));
                    }
                    for (int j = 0; j <= count; j++)
                    {
                        stack.Push(buildingHeight[i]);
                    }
                }
            }
            count = 0;
            while(stack.Count != 0)
            {
                count++;
                //MaxArea = 9, popped 3, 3, 3
                maxArea = Math.Max(maxArea, (stack.Pop() * count));
            }
            return maxArea;
        }

        public static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] buildingHeight = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            LargestRectangle lRect = new LargestRectangle(size);
            int maxArea = lRect.FindMaxArea(buildingHeight);
            Console.WriteLine(maxArea);
            Console.ReadKey();
        }
    }
}
