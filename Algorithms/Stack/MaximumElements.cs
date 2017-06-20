using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
    {
    public class MaximumElements
        {
        public static void Main (string[] args)
            {
            int size = Convert.ToInt32(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            List<int> results = new List<int>();
            for ( int i = 0; i < size; i++ )
                {
                string[] input = Console.ReadLine().Split(' ');
                int operation = Convert.ToInt32(input[0]);
                switch ( operation )
                    {
                    case 1:
                        int value = Convert.ToInt32(input[1]);
                        stack.Push(value);
                        break;
                    case 2:
                        int temp = stack.Pop();
                        break;
                    case 3:
                        int popedValue = stack.Pop();
                        results.Add(popedValue);
                        break;
                    }
                }
            foreach ( int result in results )
                {
                Console.WriteLine(result);
                }
            Console.ReadLine();
            }
        }
    }