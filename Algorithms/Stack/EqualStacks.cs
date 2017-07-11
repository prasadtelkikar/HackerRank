using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
    {
    public class EqualStacks
        {
        public static void Main (string[] args)
            {
            string[] heightStringArr = Console.ReadLine().Split(' ');
            int[] arrHeightArr = Array.ConvertAll(heightStringArr, Int32.Parse);

            string[] temp1 = Console.ReadLine().Split(' ');
            int[] stackArr1 = Array.ConvertAll(temp1, Int32.Parse);
            Stack<int> stack1 = new Stack<int>(stackArr1.Length);

            string[] temp2 = Console.ReadLine().Split(' ');
            int[] stackArr2 = Array.ConvertAll(temp2, Int32.Parse);
            Stack<int> stack2 = new Stack<int>(stackArr2.Length);

            string[] temp3 = Console.ReadLine().Split(' ');
            int[] stackArr3 = Array.ConvertAll(temp3, Int32.Parse);
            Stack<int> stack3 = new Stack<int>(stackArr3.Length);

            int sum1 = PushToStack(stack1, stackArr1);
            int sum2 = PushToStack(stack2, stackArr2);
            int sum3 = PushToStack(stack3, stackArr3);

            int result = PopFromStack(stack1, stack2, stack3, sum1, sum2, sum3);
            Console.WriteLine(result);
            Console.ReadKey();
            }

        private static int PopFromStack (Stack<int> stack1, Stack<int> stack2, Stack<int> stack3, int sum1, int sum2, int sum3)
            {
            do
                {
                if ( sum1 == sum2 && sum2 == sum3 )
                    return sum1;
                if ( stack1.Count == 0 || stack2.Count == 0 || stack3.Count == 0 )
                    return 0;

                sum1 -= stack1.Pop();
                sum2 -= stack2.Pop();
                sum3 -= stack3.Pop();

                } while ( true );
            }

        private static int PushToStack (Stack<int> stack1, int[] stackArr1)
            {
            int sum = 0;
            for ( int i = 0; i < stackArr1.Length; i++ )
                {
                stack1.Push(stackArr1[i]);
                sum += stackArr1[i];
                }
            return sum;
            }
        }
    }
