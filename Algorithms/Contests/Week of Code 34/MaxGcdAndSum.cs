using System;
using System.Collections.Generic;

namespace Contests.Week_of_Code_34
    {
    class MaxGcdAndSum
        {
        public static void Main (string[] args)
            {
            int size = Convert.ToInt32(Console.ReadLine());
            string[] firstArrStr = Console.ReadLine().Split(' ');
            string[] secondArrStr = Console.ReadLine().Split(' ');
            int[] firstArr = Array.ConvertAll(firstArrStr, Int32.Parse);
            int[] secondArr = Array.ConvertAll(secondArrStr, Int32.Parse);
            Dictionary<int, List<int>> results = new Dictionary<int, List<int>>();
            int maxFirst = 0, maxSecond = 0;
            List<int> firstList = new List<int>();
            List<int> secondList;
            int maxKey = Int32.MinValue;

            for ( int i = 0; i < size; i++ )
                {
                if ( firstList.Count == 0 || !firstList.Contains(firstArr[i]) )
                    {
                    firstList.Add(firstArr[i]);
                    secondList = new List<int>();
                    for ( int j = 0; j < size; j++ )
                        {
                        if ( secondList.Count == 0 || !secondList.Contains(secondArr[j]) )
                            {
                            secondList.Add(secondArr[j]);

                            int gcd = FindGCD(firstArr[i], secondArr[j]);
                            if ( !results.ContainsKey(gcd) )
                                {
                                if ( maxKey < gcd )
                                    {
                                    maxKey = gcd;
                                    maxFirst = 0;
                                    maxSecond = 0;
                                    }
                                List<int> list = new List<int>();
                                list.Add(firstArr[i]);
                                list.Add(secondArr[j]);
                                results.Add(gcd, list);
                                }
                            else
                                {
                                if ( !results[gcd].Contains(firstArr[i]) )
                                    {
                                    results[gcd].Add(firstArr[i]);
                                    }
                                if ( !results[gcd].Contains(secondArr[j]) )
                                    {
                                    results[gcd].Add(secondArr[j]);
                                    }
                                }
                            if ( gcd == maxKey )
                                {
                                if ( firstArr[i] > secondArr[j] )
                                    {
                                    if ( maxFirst == 0 && maxSecond == 0 )
                                        {
                                        maxFirst = firstArr[i];
                                        maxSecond = secondArr[j];
                                        }
                                    else
                                        {
                                        if ( firstArr[i] > maxFirst )
                                            {
                                            maxSecond = maxFirst;
                                            maxFirst = firstArr[i];
                                            }
                                        if ( firstArr[i] < maxFirst && firstArr[i] > maxSecond )
                                            maxSecond = firstArr[i];
                                        }
                                    }
                                else
                                    {
                                    if ( maxFirst == 0 && maxSecond == 0 )
                                        {
                                        maxFirst = secondArr[j];
                                        maxSecond = firstArr[i];
                                        }
                                    else
                                        {
                                        if ( secondArr[j] > maxFirst )
                                            {
                                            maxSecond = maxFirst;
                                            maxFirst = secondArr[j];
                                            }
                                        if ( secondArr[j] < maxFirst && secondArr[j] > maxSecond )
                                            maxSecond = secondArr[j];
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            Console.WriteLine(maxFirst + maxSecond);
            Console.ReadLine();
            }

        private static int FindGCD (int x, int y)
            {
            int numerator = 0;
            int denominator = 0;
            int remainder = 0;
            if ( x > y )
                {
                numerator = x;
                denominator = y;
                }
            else
                {
                numerator = y;
                denominator = x;
                }
            do
                {
                remainder = numerator % denominator;
                numerator = denominator;
                denominator = remainder;
                } while ( remainder != 0 );
            return numerator;
            }
        }
    }
