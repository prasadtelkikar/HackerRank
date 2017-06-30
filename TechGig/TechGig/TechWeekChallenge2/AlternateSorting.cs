using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechWeekChallenge2
    {
    public class AlternateSorting
        {
        public static void Main (String[] args)
            {
            int[] output;
            int ip1_size = 0;
            ip1_size = Convert.ToInt32(Console.ReadLine());
            int[] ip1 = new int[ip1_size];
            int ip1_item;
            for ( int ip1_i = 0; ip1_i < ip1_size; ip1_i++ )
                {
                ip1_item = Convert.ToInt32(Console.ReadLine());
                ip1[ip1_i] = ip1_item;
                }
            output = AlternateSortingFunction(ip1);
            for ( int output_i = 0; output_i < output.Length; output_i++ )
                {
                Console.WriteLine(output[output_i]);
                }
            Console.ReadKey();
            }

        private static int[] AlternateSortingFunction (int[] ip1)
            {
            int[] result = new int[ip1.Length];

            Array.Sort(ip1);
            int j = ip1.Length;
            int k = 0;
            for ( int i = 0; i < ip1.Length; i++ )
                {
                if ( i % 2 == 0 )
                    result[i] = ip1[--j];
                else
                    result[i] = ip1[k++];

                }
            return result;
            }
        }
    }