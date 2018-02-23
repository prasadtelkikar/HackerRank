using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class FormingAMagicSquare
    {
        public static void Main(string[] args)
        {
            int[][] magicSquareConst = new int[8][]
            {
                new int[]{8, 1, 6, 3, 5, 7, 4, 9, 2},
                new int[]{6, 1, 8, 7, 5, 3, 2, 9, 4},
                new int[]{4, 3, 8, 9, 5, 1, 2, 7, 6},
                new int[]{2, 7, 6, 9, 5, 1, 4, 3, 8},
                new int[]{2, 9, 4, 7, 5, 3, 6, 1, 8},
                new int[]{4, 9, 2, 3, 5, 7, 8, 1, 6},
                new int[]{6, 7, 2, 1, 5, 9, 8, 3, 4},
                new int[]{8, 3, 4, 1, 5, 9, 6, 7, 2}
            };
            
            string input = "";
            for (int i = 0; i < 2; i++)
            {
                input += Console.ReadLine();
                input += ' ';
            }

            input += Console.ReadLine();
            int[] sumInput = Array.ConvertAll(input.Split(' '), Int32.Parse);
            int min = Int32.MaxValue;
            int index = -1;
            for (int i = 0; i < 8; i++)
            {
                int count = 0;
                int[] temp = magicSquareConst[i];
                for (int j = 0; j < 9; j++)
                {
                    if (temp[j] != sumInput[j])
                        count++;
                }
                if (min > count)
                {
                    index = i;                
                    min = count;

                }  
            }
            int sum = 0;
            for(int i = 0; i < 9; i++)
            {
                if(magicSquareConst[index][i] != sumInput[i])
                {
                    sum += Math.Abs(magicSquareConst[index][i] - sumInput[i]);
                }
            }
            //Console.WriteLine(i);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
