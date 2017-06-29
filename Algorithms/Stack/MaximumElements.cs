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
            Stack<long> stack = new Stack<long>();
            int size = Convert.ToInt16(Console.ReadLine());
            List<long> valueList = new List<long>();
            for ( int i = 0; i < size; i++ )
                {
                string[] query = Console.ReadLine().Split(' ');
                int type = Convert.ToInt32(query[0]);
                
                if ( type == 1 )
                    {
                    long value = Convert.ToInt64(query[1]);
                    stack.Push(value);
                    }
                else if ( type == 2 )
                    {
                    stack.Pop();
                    }
                else
                    {
                    valueList.Add(stack.Peek());
                    }

                }
            foreach ( var item in valueList )
                {
                Console.WriteLine(item);
                }
            Console.ReadKey();
            }
        }
    }