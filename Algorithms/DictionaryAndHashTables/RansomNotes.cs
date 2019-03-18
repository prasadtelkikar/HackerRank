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
            List<string> magazine = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
            List<string> note = Console.ReadLine().Split(' ').OrderBy(x => x).ToList();
            bool resultBool = true;

            var magazineLength = magazine.Count;
            var noteLength = note.Count;

            if (noteLength > magazineLength)
                resultBool = false;
            else
            {
                int i = 0, j = 0, count = 0;
                while(i < magazineLength && j < noteLength)
                {
                    if(magazine[i] == note[j])
                    {
                        count++;
                        j++;
                    }
                    i++;
                }
                resultBool = count == noteLength;
            }

            Console.WriteLine(resultBool ? "Yes" : "No");
            Console.ReadKey();
        }
    }
}


/* My attempts
 * 
 *     // All passed except 3 test cases
 *     static void checkMagazine(List<string> magazine, List<string> note) {
 *          List<string> result = note.Intersect(magazine).ToList();
 *          Console.WriteLine(result.Count == note.Count ? "Yes" : "No");
 *    }
 */
