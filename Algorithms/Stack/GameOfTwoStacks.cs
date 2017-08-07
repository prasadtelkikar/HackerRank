using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
    {
    public class GameOfTwoStacks
        {
        public static void Main (string[] args)
            {
            int gameCount = Convert.ToInt32(Console.ReadLine());
            while ( gameCount-- != 0 )
                {
                string[] inputs = Console.ReadLine().Split(' ');
                int firstStackSize = Convert.ToInt32(inputs[0]);
                int secondStackSize = Convert.ToInt32(inputs[1]);
                int limit = Convert.ToInt32(inputs[2]);
                Stack<int> firstStack = new Stack<int>();
                Stack<int> secondStack = new Stack<int>();
                string[] firstInput = Console.ReadLine().Split(' ');
                string[] secondInput = Console.ReadLine().Split(' ');

                for ( int i = firstStackSize - 1; i >= 0; i-- )
                    firstStack.Push(Convert.ToInt32(firstInput[i]));

                for ( int i = secondStackSize - 1; i >= 0; i-- )
                    secondStack.Push(Convert.ToInt32(secondInput[i]));
                
                int sum = 0;
                int count = 0;
                while ( sum < limit )
                    {
                    int first = 0;
                    int second = 0;
                    if(firstStack.Count != 0)
                        first = firstStack.Peek();
                    if(secondStack.Count != 0)
                        second = secondStack.Peek();

                    if (first != 0 && first < second )
                        {
                        sum += first;
                        firstStack.Pop();
                        }
                    else
                        {
                        if ( second != 0 )
                            {
                            sum += second;
                            secondStack.Pop();
                            }
                        }
                    if ( sum > limit || (firstStack == null && secondStack == null))
                        break;

                    count++;
                    }
                Console.WriteLine(count);
                Console.ReadKey();
                }
            }
        }
    }
