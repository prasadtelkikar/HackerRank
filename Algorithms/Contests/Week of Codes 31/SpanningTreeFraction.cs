using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
/* Sample input 0:
 * 3 3
 * 0 1 1 1
 * 1 2 2 4
 * 2 0 1 2 
 * Sample output 0:
 * 2/3
 */
namespace Contests.Week_of_Codes_31
{
    /// <summary>
    /// First time tried problem from Tree: No logic just tried with brute force. One test case passed other failed; Adding problems in TODO list
    /// https://www.hackerrank.com/contests/w31/challenges/spanning-tree-fraction
    /// </summary>
    class SpanningTreeFraction
    {
        public static void Main(String[] args)
        {
            String[] nm = Console.ReadLine().Split(' ');
            int numberOfVertices = Convert.ToInt32(nm[0]);
            int numberOfEdges = Convert.ToInt32(nm[1]);
            String[] inputs = new string[numberOfEdges];
            for (int i = 0; i < numberOfEdges; i++)
                inputs[i] = Console.ReadLine();
            double tolerance = 0.0001;
            Dictionary<int, string> result = new Dictionary<int, string>();
            for (int i = 0; i < numberOfVertices; i++)
            {
                int p = 0, q = 0;
                bool flag = false;
                for (int j = 0; j < numberOfEdges; j++)
                {
                    int firstVertex = Convert.ToInt32(inputs[j].Split(' ')[0]);
                    int secondVertex = Convert.ToInt32(inputs[j].Split(' ')[1]);
                    if (firstVertex == i || secondVertex == i)
                    {
                        p += Convert.ToInt32(inputs[j].Split(' ')[2]);
                        q += Convert.ToInt32(inputs[j].Split(' ')[3]);
                        StringBuilder pq = new StringBuilder();
                        pq.Append(p.ToString()).Append(' ');
                        pq.Append(q.ToString());
                        if (!flag)
                        {
                            result.Add(i, pq.ToString());
                            flag = true;
                        }
                        else
                            result[i] = pq.ToString();       
                    }
                }
            }

            double max = float.MaxValue;
            int maxKeyValue = 0;
            foreach (int key in result.Keys)
            {
                int numerator = Convert.ToInt32(result[key].Split(' ')[0]);
                double denominator = Convert.ToDouble(result[key].Split(' ')[1]);
                double results = (numerator/denominator);
                if (IsDouble(max, results, tolerance))
                {
                    max = results;
                    maxKeyValue = key;
                }
            }
            int n = Convert.ToInt32(result[maxKeyValue].Split(' ')[0]);
            double d = Convert.ToDouble(result[maxKeyValue].Split(' ')[1]);
            Console.WriteLine(n+"/"+d);
            Console.ReadKey();
        }
        private static bool IsDouble(double value1, double value2, double tolerance)
        {
            double a = Math.Abs(value1);
            double b = Math.Abs(value2);
            double result = (a - b);
            if (result > 0)
                return false;
            else
                return true;
        }
    }
}