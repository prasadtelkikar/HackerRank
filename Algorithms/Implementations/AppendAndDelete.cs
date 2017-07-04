using System;
using System.Collections.Generic;

namespace Implementations
    {
    public class AppendAndDelete
        {
        public static void Main (string[] args)
            {
            string initialString = Console.ReadLine();
            string desireString = Console.ReadLine();
            int desireOperation = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int smallerString = (initialString.Length < desireString.Length)
                ? initialString.Length
                : desireString.Length;
            for ( int i = 0; i < smallerString; i++ )
                {
                if ( initialString[i] != desireString[i] )
                    break;
                count++;
                }
            string endInitialString = initialString.Substring(count);
            string endDesireString = desireString.Substring(count);

            Console.WriteLine(endInitialString.Length >= endDesireString.Length && (endInitialString.Length + endDesireString.Length <= desireOperation) ? "Yes" : "No");
            Console.ReadKey();
            }
        }
    }
