using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MaximumElements
    {
        public static void Main(string[] args)
        {
            Stack<long> stack = new Stack<long>();
            List<long> maxStorage = new List<long>();

            long size = Convert.ToInt64(Console.ReadLine());
            string[] inputs = new string[size];
            long max = int.MinValue;
            for (int i = 0; i < size; i++)
            {
                inputs[i] = Console.ReadLine();
            }

            foreach (string input in inputs)
            {
                string[] values = input.Split(' ');
                long option = Convert.ToInt64(values[0]);

                if (option == 1)
                {
                    long value = Convert.ToInt64(values[1]);
                    stack.Push(value);
                    max = stack.Max();
                }
                else if (option == 2)
                {
                    if (stack.Count != 0)
                        stack.Pop();

                    if (stack.Count == 0)
                        max = int.MinValue;
                    else
                        max = stack.Max();
                }
                else if (option == 3)
                {
                    if (stack.Count > 0)
                    {
                        max = stack.Max();
                        maxStorage.Add(max);
                        //Console.WriteLine(max);
                    }
                }
            }

            using (TextWriter tw = new StreamWriter("SavedList.txt"))
            {
                foreach (long s in maxStorage)
                    tw.WriteLine(s);
            }

            Console.ReadKey();
        }
    }
}