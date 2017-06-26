using System;
using System.Collections.Generic;
/* Sample input 0:
 * 2 5
 * 1 0 5
 * 1 1 7
 * 1 0 3
 * 2 1 0
 * 2 1 1
 * Sample output 0:
 * 7
 * 3
 */
namespace Arrays
    {
    /// <summary>
    /// Dynamic array
    /// https://www.hackerrank.com/challenges/dynamic-array/problem
    /// Note: Used Dictionary. Not array; try to solve it with array
    /// </summary>
    class DynamicArray
        {
        public static void Main (string[] args)
            {
            //string[] lines = File.ReadAllLines(@"D:\GitHub\HackerRank\Algorithms\Arrays\InputsAndOutputs\Input.txt");
            //string[] nq = lines[0].Split(' ');

            string[] nq = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(nq[0]);
            int q = Convert.ToInt32(nq[1]);
            Dictionary<int, List<int>> seqList = new Dictionary<int, List<int>>(n);
            int lastAns = 0;
            
            List<long> lastAnsList = new List<long>();
            
            //Trying to test with file input then start for loop from 1 instead of 0.
            for ( int i = 0; i < q; i++ )
                {
                //string[] query = lines[i].Split(' ');
                string[] query = Console.ReadLine().Split(' ');
                int queryType = Convert.ToInt32(query[0]);
                int x = Convert.ToInt32(query[1]);
                int y = Convert.ToInt32(query[2]);

                int common = (x ^ lastAns) % n;
                if ( queryType == 1 )
                    {
                    if ( !seqList.ContainsKey(common) )
                        seqList.Add(common, new List<int>());

                    seqList[common].Add(y);
                    }
                if ( queryType == 2 )
                    {
                    List<int> temp = new List<int>();
                    if ( seqList.ContainsKey(common) )
                        temp = seqList[common];

                    lastAns = temp[y % temp.Count];
                    lastAnsList.Add(lastAns);
                    }
                }

            foreach ( int item in lastAnsList )
                {
                Console.WriteLine(item);
                }
            Console.ReadLine();
            }
        }
    }
