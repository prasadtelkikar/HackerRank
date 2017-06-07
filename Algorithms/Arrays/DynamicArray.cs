using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class DynamicArray
    {
        public static void Main(string[] args)
        {
            string[] firstLine = Console.ReadLine().Split(' ');
            int[] nq = Array.ConvertAll(firstLine, Int32.Parse);
            int size = nq[0];
            int sizeOfQueue = nq[1];
            int[] Y = new int[sizeOfQueue];
            int[] X = new int[sizeOfQueue];
            int[] seqValue = new int[sizeOfQueue];
            
            for (int i = 0; i < sizeOfQueue; i++)
            {
                string[] nextLine = Console.ReadLine().Split(' ');
                Y[i] = Convert.ToInt32(nextLine[0]);
                X[i] = Convert.ToInt32(nextLine[1]);
                seqValue[i] = Convert.ToInt32(nextLine[2]);
            }

            int lastAnswer = 0;
            List<int> s1 = new List<int>();
            List<int> s2 = new List<int>();

            for (int i = 0; i < sizeOfQueue; i++)
            {
                int calc = (X[i] ^ lastAnswer)%size;
                
                if (Y[i] == 1)
                {
                    if (calc == 0)
                        s1.Add(seqValue[i]);
                    else
                        s2.Add(seqValue[i]);
                }
                else
                {
                    if (calc == 0)
                    {
                        lastAnswer = s1[s1.Count - 1];
                        Console.WriteLine(lastAnswer);
                    }
                    else
                    {
                        lastAnswer = s2[s2.Count - 1];
                        Console.WriteLine(lastAnswer);
                    }
                        
                }
            }
            Console.ReadKey();
        }
    }
}
