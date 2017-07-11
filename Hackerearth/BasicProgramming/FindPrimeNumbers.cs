using System;

namespace BasicProgramming
    {
    class FindPrimeNumbers
        {
        public static void Main (string[] args)
            {
            int limit = Convert.ToInt32(Console.ReadLine());
            int squareRoot = Convert.ToInt32(Math.Sqrt(limit));
            int[] flag = new int[limit];
            for ( int i = 2; i <= squareRoot; i++ )
                {
                if ( flag[i] == 0 )
                    {
                    for ( int j = i * 2; j < limit; j += i)
                        {
                        flag[j] = 1;
                        }
                    }
                }

            for ( int i = 2; i < limit; i++ )
                {
                if ( flag[i] == 0 )
                    Console.Write(i + " ");
                }
            Console.ReadKey();
            }
        }
    }
