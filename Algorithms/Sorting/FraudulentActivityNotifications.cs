using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    /// <summary>
    ///Three test cases pass; remaining failed.
    /// </summary>
    public class FraudulentActivityNotifications
    {
        public static void Main(string[] args)
        {
            string[] content = new string[2];
            string testCasesPath = Path.Combine(Directory.GetCurrentDirectory(), @"TestCases\FraudulentActivityNotification-Input.txt"); 
            if(File.Exists(testCasesPath))
                content = File.ReadAllLines(testCasesPath);


            int[] nd = Array.ConvertAll(content[0].Split(' '), int.Parse);
            int n = nd[0];
            int d = nd[1];
            int[] expenditure = Array.ConvertAll(content[1].Split(' '), int.Parse);
            int count = 0;

            for (int i = 0; i < n - d; i ++)
            {
                int temp = i + 1;

                int median = FindMedian(expenditure, i, d);
                median *= 2;
                if (expenditure[i + d] >= median)
                    count++;
            }

            Console.WriteLine(count);
            Console.ReadLine();
        }

        public static int FindMedian(int[] a, int start, int end)
        {
            int[] temp = a.Skip(start).Take(end).OrderBy(x => x).ToArray();
            int midIndexer = temp.Length / 2;

            return (temp.Length % 2 != 0) ? temp[midIndexer] : ((temp[midIndexer] + temp[midIndexer + 1]) / 2); 
        }
    }
}
