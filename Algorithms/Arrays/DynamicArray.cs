using System;
using System.Collections.Generic;
using System.IO;

namespace Arrays
    {
    class DynamicArray
        {
        public static void Main (string[] args)
        {
            string[] file = File.ReadAllLines(@"C:\Users\Prasad.Telkikar\Desktop\Docs\Input.txt");
            string[] nq = file[0].Split(' ');//Console.ReadLine().Split(' ');
            int emptySequences = Convert.ToInt32(nq[0]);
            int numberOfQueries = Convert.ToInt32(nq[1]);

            long[][] seqList = new long[emptySequences][];
            long lastAnswer = 0;
            List<long> lastAnswerlist = new List<long>();
            string[] queries = new string[numberOfQueries];

            //for ( int i = 0; i < numberOfQueries; i++ )
            //    {
            //    queries[i] = Console.ReadLine();
            //    }

            long lastIndex = 0;
            int index = 0;
            foreach ( string query in file )
                {
                if ( index == 0 )
                    {
                    index++;
                    continue;
                    }
                index++;
                string[] splitQuery = query.Split(' ');
                int queryType = Convert.ToInt32(splitQuery[0]);
                long x = Convert.ToInt64(splitQuery[1]);
                long y = Convert.ToInt64(splitQuery[2]);

                long commonTerm = ((x ^ lastAnswer) % emptySequences);
                if ( queryType == 1 )
                {
                    long[] seq = seqList[commonTerm];
                    if ( seq != null )
                        lastIndex = seq.Length - 1;
                    else
                        {
                        seqList[commonTerm] = new long[emptySequences];
                        }
                    seqList[commonTerm][lastIndex] = y;
                    }
                else
                    {
                    long[] seq = seqList[commonTerm];
                    if(seq != null)
                    lastIndex = y % seq.Length;
                    lastAnswerlist.Add(seq[lastIndex]);
                    lastAnswer = seq[lastIndex];
                    }
                }
            foreach (var value in lastAnswerlist)
                Console.WriteLine(value);

            Console.ReadLine();
            }
        }
    }