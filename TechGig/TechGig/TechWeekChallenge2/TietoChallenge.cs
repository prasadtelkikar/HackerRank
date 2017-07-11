using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechWeekChallenge2
    {
    public class TietoChallenge
        {
        public static void Main (String[] args)
            {
            string[] output;
            int ip1_size = 0;
            ip1_size = Convert.ToInt32(Console.ReadLine());
            string[] ip1 = new string[ip1_size];
            string ip1_item;
            for ( int ip1_i = 0; ip1_i < ip1_size; ip1_i++ )
                {
                ip1_item = Console.ReadLine();
                ip1[ip1_i] = ip1_item;
                }
            output = CriticalBridges(ip1);
            for ( int output_i = 0; output_i < output.Length; output_i++ )
                {
                Console.WriteLine(output[output_i]);
                }
            }

        private static string[] CriticalBridges (string[] ip1)
            {
            foreach ( var ip in ip1 )
                {
                string name = ip.TrimStart('(').TrimEnd(')');
                string[] splitNames = name.Split('{');
                string bridges = splitNames[2].TrimEnd('}');
                List<string> edges = new List<string>();

                for ( int i = 0; i < bridges.Length; i += 6 )
                    {
                    edges.Add(bridges.Substring(i, 5));
                    }

                Console.WriteLine(name);
                Console.ReadKey();
                }
            string[] output = new string[120];
            return output;

            }
        }

    }