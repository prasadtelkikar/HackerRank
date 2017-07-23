using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
    {
    public class ChocolateFeast
        {
        public static void Main (string[] args)
            {
            int trips = Convert.ToInt32(Console.ReadLine());
            List<int> results = new List<int>(trips);
            for ( int i = 0; i < trips; i++ )
                {
                string input = Console.ReadLine();
                int result = GetTotalNumberOfChocolate(input);
                results.Add(result);
                }
            foreach ( int result in results )
                {
                Console.WriteLine(result);
                }
            Console.ReadKey();
            }

        private static int GetTotalNumberOfChocolate (string input)
            {
            string[] inputs = input.Split(' ');
            int dollers = Convert.ToInt32(inputs[0]);
            int rateOfChocolate = Convert.ToInt32(inputs[1]);
            int tradeRate = Convert.ToInt32(inputs[2]);
            int wrappers = 0;
            int result = 0;
            do
                {
                wrappers = dollers / rateOfChocolate;
                int remainingChocolate = dollers % rateOfChocolate;
                dollers = wrappers + remainingChocolate;
                rateOfChocolate = tradeRate;
                result += wrappers;
                } while ( wrappers != 0 && dollers >= tradeRate );
            return result;
            }
        }
    }
