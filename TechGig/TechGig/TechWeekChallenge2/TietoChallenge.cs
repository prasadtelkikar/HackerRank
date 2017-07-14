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
            string[] arr = GetAdjacencyMatrix(ip1);
            foreach ( var i in arr )
                {
                Console.Write(i);
                }
            Console.ReadKey();
            }

        private static string[] GetAdjacencyMatrix (string[] input1)
            {
            string[] outputArr = new string[0];
            foreach ( string stringInput in input1 )
                {
                Dictionary<int, List<int>> index = new Dictionary<int, List<int>>();
                index.Add(1, new List<int>());
                index.Add(2, new List<int>());

                string name = stringInput.TrimStart('(').TrimEnd(')');
                string[] splitNames = name.Split('{');
                string[] vertices = splitNames[1].TrimEnd(',').TrimEnd('}').Split(',');
                char[] charVer = new char[vertices.Length];
                int count = 0;
                foreach ( string element in vertices )
                    {
                    charVer[count] = Convert.ToChar(element);
                    count++;
                    }

                int[][] adjucentMatrix = new int[vertices.Length][];
                for ( int i = 0; i < vertices.Length; i++ )
                    adjucentMatrix[i] = new int[vertices.Length];

                string bridges = splitNames[2].TrimEnd('}');
                    string sb = "";
                //StringBuilder sb = new StringBuilder();
                List<string> edges = new List<string>();
                //int index = 0;

                foreach ( char ch in bridges )
                {
                    if (ch == '(')
                        sb = "";
                    else if (ch == ')')
                    {
                        edges.Add(sb);
                    }
                    else if (ch == ',')
                        continue;
                    else
                        sb+=ch;
                }

                foreach ( var edge in edges )
                    {
                    int rowIndex = Convert.ToInt32(edge[0]) - Convert.ToInt32(charVer[0]);
                    int columnIndex = Convert.ToInt32(edge[1]) - Convert.ToInt32(charVer[0]);

                    adjucentMatrix[rowIndex][columnIndex] = 1;
                    adjucentMatrix[columnIndex][rowIndex] = 1;
                    }
                List<string> output = new List<string>();
                for ( int i = 0; i < vertices.Length; i++ )
                    {
                    int countElement = 0;
                    int[] arr = adjucentMatrix[i];
                    foreach ( int element in arr )
                        {
                        if ( element == 1 )
                            countElement++;
                        }
                    if ( countElement == 2 )
                        index[2].Add(i);
                    if ( countElement == 1 )
                        index[1].Add(i);
                    }

                foreach ( int element in index[1] )
                    {
                    int[] arr = adjucentMatrix[element];
                    for ( int i = 0; i < arr.Length; i++ )
                        {
                        if ( arr[i] == 1 )
                            {
                            if ( i > element )
                                {
                                string outString = "(" + vertices[element] + "," + vertices[i] + ")";
                                if ( !output.Contains(outString) )
                                    output.Add(outString);
                                }
                            else
                                {
                                string outString = "(" + vertices[i] + "," + vertices[element] + ")";
                                if ( !output.Contains(outString) )
                                    output.Add(outString);
                                }
                            }
                        }
                    foreach ( int element2 in index[2] )
                        {
                        if ( adjucentMatrix[element2][element] == 1 )
                            {
                            int[] arrCriticle = adjucentMatrix[element2];
                            for ( int i = 0; i < arrCriticle.Length; i++ )
                                {
                                if ( i != element && arrCriticle[i] == 1 )
                                    {
                                    if ( i > element2 )
                                        {
                                        string outString = "(" + vertices[element2] + "," + vertices[i] + ")";
                                        if ( !output.Contains(outString) )
                                            output.Add(outString);
                                        }
                                    else
                                        {
                                        string outString = "(" + vertices[i] + "," + vertices[element2] + ")";
                                        if ( !output.Contains(outString) )
                                            output.Add(outString);
                                        }
                                    }
                                }
                            }
                        }
                    }

                if ( output.Count == 0 )
                    {
                    outputArr = new string[1];
                    outputArr[0] = "{NA}";
                    return outputArr;
                    }
                else
                    {
                    outputArr = new string[output.Count];

                    for ( int i = 0; i < output.Count; i++ )
                        {
                        if ( i == 0 )
                            {
                            outputArr[i] = "{" + output[i] + ",";
                            }
                        else if ( i == output.Count - 1 )
                            {
                            outputArr[i] = output[i] + "}";
                            }
                        else
                            {
                            outputArr[i] = output[i] + ",";
                            }
                        }
                    }
                }
            return outputArr;
            }

        private static string CriticalBridges (int[][] matrix, string[] vertices)
            {

            StringBuilder sb = new StringBuilder();

            return sb.ToString();
            }
        }

    }