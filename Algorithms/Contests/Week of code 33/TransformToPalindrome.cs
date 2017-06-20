using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Contests.Week_of_code_33
    {
    public class TransformToPalindrome
        {
        public static void Main (string[] args)
            {
            string[] arguments = Console.ReadLine().Split(' ');
            int maxKeySize = Convert.ToInt32(arguments[0]);
            int numberOfQueries = Convert.ToInt32(arguments[1]);
            int lenghtOfArray = Convert.ToInt32(arguments[2]);
            Dictionary<int, IList<int>> links = new Dictionary<int, IList<int>>();
            for ( int i = 0; i < numberOfQueries; i++ )
                {
                string[] xy = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(xy[0]);
                int y = Convert.ToInt32(xy[1]);
                AddValuesToLink(links, x, y);
                AddValuesToLink(links, y, x);
                }
            int j = 0;
            string[] arrString = Console.ReadLine().Split(' ');
            List<int> arr = Array.ConvertAll(arrString, Int32.Parse).ToList();
            while ( IsPalindrome(arr) && j < (lenghtOfArray / 2) )
            {
                bool flag = true;
                int lastElementIndex = arr.Count - j - 1;
                if ( arr[j] != arr[lastElementIndex] )
                {
                    int lastElement = arr[lastElementIndex];
                    while (flag)
                    {
                        
                    }
                }
            }
            foreach ( KeyValuePair<int, IList<int>> x in links )
                {
                foreach ( int value in x.Value )
                    {
                    Console.WriteLine(x.Key + ":" + value);
                    }
                Console.WriteLine();
                }
            Console.ReadLine();
            }

        private static void AddValuesToLink (Dictionary<int, IList<int>> links, int x, int y)
            {
            if ( links.ContainsKey(x) )
                {
                IList<int> values = links[x];
                if ( values.Count == 0 )
                    {
                    links[x].Add(y);
                    }
                else
                    {
                    foreach ( int value in values )
                        {
                        if ( links.ContainsKey(value) )
                            {
                            foreach ( var innerValue in links[value] )
                                {
                                if ( !links[x].Contains(innerValue) && innerValue != x )
                                    links[x].Add(innerValue);
                                }
                            }
                            links[x].Add(y);
                            break;
                        }
                    }
                }
            else
                {
                //List<int> temp = 
                links.Add(x, new List<int> { y });
                }
            }

        private static bool IsPalindrome (List<int> arr)
            {
            int size = arr.Count;
            for ( int i = 0; i < (size / 2); i++ )
                {
                if ( arr[i] != arr[size - 1 - i] )
                    return false;
                }
            return true;
            }
        }
    }
