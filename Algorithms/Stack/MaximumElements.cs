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
            string[] inputs = new string[size];
            long max = int.MinValue;

            for ( int i = 0; i < size; i++ )
                {
                inputs[i] = Console.ReadLine();
                }

            foreach ( string input in inputs )
                {
                string[] values = input.Split(' ');
                int option = Convert.ToInt32(values[0]);

                if ( option == 1 )
                    { 
                    long value = Convert.ToInt32(values[1]);
                    if ( max < value )
                        max = value;

                    stack.Push(value);
                    }
                else if ( stack.Count != 0 && option == 2 )
                    {
                    stack.Pop();
                    if ( stack.Count == 0 )
                        max = int.MinValue;
                    else
                        max = stack.Max();
                    }
                else if ( option == 3 )
                    {
                    Console.WriteLine(max);
                    }
                }
            Console.ReadKey();
            }
        }
    }