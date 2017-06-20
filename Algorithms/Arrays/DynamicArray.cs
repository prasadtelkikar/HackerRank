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
            Dictionary<int, List<int>> seqList = new Dictionary<int, List<int>>();
            int lastAnswer = 0;
            string[] nq = Console.ReadLine().Split(' ');

            int N = Convert.ToInt32(nq[0]);
            int Q = Convert.ToInt32(nq[1]);
            for (int i = 0; i < N; i++)
            {
                List<int> emptyLinkedList = new List<int>();
                seqList.Add(i, emptyLinkedList);
            }
            List<int> lastAnsList = new List<int>();
            for (int i = 0; i < Q; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                int queryType = Convert.ToInt32(line[0]);
                int x = Convert.ToInt32(line[1]);
                int y = Convert.ToInt32(line[2]);

                int index = (x ^ lastAnswer)%N;
                if(queryType == 1)
                    seqList[index].Add(y);
                if ( queryType == 2 )
                {
                    int length = y%(seqList.Count);
                    IList<int> list = seqList[index];
                    lastAnswer = list[length];
                    lastAnsList.Add(lastAnswer);
                }
            }
            foreach (var entity in lastAnsList)
            {
                Console.WriteLine(entity);
            }
            Console.ReadKey();
        }
    }
}
