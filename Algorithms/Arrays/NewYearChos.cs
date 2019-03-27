using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{

    public class NewYearChos
    {
        public static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                Console.WriteLine(GetResult(q));
            }

            Console.ReadLine();
        }

        //Use of bubble sort logic was from discussion board.
        public static string GetResult(int[] q)
        {
            int swapCount = 0;
            bool isChoatic = true;
            for (int i = 0; i < q.Length - 1; i++)
            {
                if (q[i] - (i+1) > 2)
                    return "To chaotic";
            }

            for (int i = 0; i < q.Length && isChoatic; i++)
            {
                isChoatic = false;
                for (int j = 0; j < q.Length - 1; j++)
                {
                    if(q[j] > q[j + 1])
                    {
                        int temp = q[j];
                        q[j] = q[j + 1];
                        q[j + 1] = temp;

                        isChoatic = true;
                        swapCount++;
                    }
                }
            }
            return swapCount.ToString();
        }
    }
}


//My first approach was to check difference between original and input array and consider positive difference as a bribe. 
//This is failing in case of 1 2 5 3 7 8 6 4

//How it works
//Initially 
/*
1 2 3 4 5 6 7 8
1 2 3 5 4 6 7 8 -> 5 bribed 4 - 1
1 2 3 5 6 4 7 8 -> 6 bribed 4 - 2
1 2 3 5 6 7 4 8 -> 7 bribed 4 - 3
1 2 3 5 6 7 8 4 -> 8 bribed 4 - 4
1 2 5 3 6 7 8 4 -> 5 bribed 3 - 5
1 2 5 3 7 6 8 4 -> 7 bribed 6 - 6
1 2 5 3 7 8 6 4 -> 8 bribed 6 - 7

    Answer is 7
*/
