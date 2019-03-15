using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAndHashTables
{
    public class RansomNotes
    {
        public static void Main(string[] args)
        {
            string inputLength = Console.ReadLine();
            List<string> firstSentenceArray = Console.ReadLine().Split(' ').ToList();
            List<string> secondSentenceArray = Console.ReadLine().Split(' ').ToList();

            var result = secondSentenceArray.Intersect(firstSentenceArray).ToList();

            Console.WriteLine(result.Count == secondSentenceArray.Count ? "Yes" : "No");
            Console.ReadKey();
        }
    }
}
