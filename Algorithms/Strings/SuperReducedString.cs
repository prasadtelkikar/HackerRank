using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class SuperReducedString
    {
        public static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder result = new StringBuilder("");
            bool isTrue = false;
            int count = 0;
            do
            {
                count = 0;
                int i = 0;

                while (i < str.Length - 1)
                {

                    if (str[i] == str[i + 1])
                    {
                        result.Append(str[i]);
                        //result.Append(str[i + 1]);
                    }
                    else
                    {
                        i++;
                        count++;
                    }
                    i++;
                }

                str = result.ToString();
                result.Clear();
            } while (count != 0);

            Console.WriteLine(str.Length == 0 ? "Empty String" : str);
            //Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
