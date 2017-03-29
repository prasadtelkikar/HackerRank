using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class PickingNumber
    {
        public static void Main(string[] arg)
        {
            //int size = Convert.ToInt32(Console.ReadLine());
            //string[] value_temp = Console.ReadLine().Split(' ');
            //int[] values = Array.ConvertAll(value_temp, Int32.Parse);

            string[] s = File.ReadAllLines(@"D:\GitHub\HackerRank\Algorithms\Implementations\PickingNumbers.txt");
            int size = Convert.ToInt32(s[0]);
            
            String[] value_temp = s[1].Split(' ');
            int[] values = Array.ConvertAll(value_temp, Int32.Parse);
            

            Array.Sort(values);

            List<int> arrayList = new List<int>();
            arrayList = values.ToList();

            int count = 0;
            List<int> resultArray = GetAbsoluteArray(arrayList, false);
            foreach (int r in resultArray)
            {
                Console.WriteLine(r);
            }

            List<int> finalArray = GetAbsoluteArray(resultArray, true);
            Console.WriteLine(finalArray.Count);

            Console.ReadKey();
        }

        private static List<int> GetAbsoluteArray(List<int> values, bool isSecond)
        {
            List<int> finalArrayList = new List<int>();
            for (int i = 0; i < values.Count; i++)
            {
                List<int> tempArrayList = new List<int>();
                for (int j = 0; j < values.Count; j++)
                {
                    if (Math.Abs(values[i] - values[j]) <= 1)
                    {
                        tempArrayList.Add(values[j]);
                    }
                    if (isSecond && Math.Abs(values[i] - values[j]) > 1)
                    {
                        return tempArrayList;
                    }
                }
                if (tempArrayList.Count > finalArrayList.Count)
                    finalArrayList = tempArrayList;
            }
            return finalArrayList;
        }
    }
}
