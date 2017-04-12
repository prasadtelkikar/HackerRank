using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementations
{
    class QueensAttack
    {
        public static void Main(String[] args)
        {
            String[] nkString = Console.ReadLine().Split(' ');
            int[] nk = Array.ConvertAll(nkString, Int32.Parse);
            String[] queenString = Console.ReadLine().Split(' ');
            int queenRow = Convert.ToInt32(queenString[0]);
            int queenColumn = Convert.ToInt32(queenString[1]);
            StringBuilder obstacles = new StringBuilder();
            int count = 0;
            for (int a0 = 0; a0 < nk[1]; a0++)
                obstacles.Append(Console.ReadLine()).Append('\n');
            count += MoveToEast(queenRow, queenColumn, obstacles.ToString(), nk[0]);
            count += MoveToWest(queenRow, queenColumn, obstacles.ToString(), 1);
            count += MoveToNorth(queenRow, queenColumn, obstacles.ToString(), nk[0]);
            count += MoveToSouth(queenRow, queenColumn, obstacles.ToString(), 1);
            count += MoveToNorthEast(queenRow, queenColumn, obstacles.ToString(), nk[0]);
            count += MoveToNorthWest(queenRow, queenColumn, obstacles.ToString(), nk[0]);
            count += MoveToSouthEast(queenRow, queenColumn, obstacles.ToString(), nk[0]);
            count += MoveToSouthWest(queenRow, queenColumn, obstacles.ToString(), nk[0]);
            Console.WriteLine(count);
            Console.ReadKey();
        }
        private static int MoveToEast(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenColumn < limit)
            {
                queenColumn++;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
            //    Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }
        private static int MoveToWest(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenColumn > limit)
            {
                queenColumn--;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
                //Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }
        private static int MoveToNorth(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenRow < limit)
            {
                queenRow++;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
                //Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }
        private static int MoveToSouth(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenRow > limit)
            {
                queenRow--;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
                //Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }

        private static int MoveToNorthEast(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenRow < limit && queenColumn < limit)
            {
                queenRow++;
                queenColumn++;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
                //Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }
        private static int MoveToNorthWest(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenRow < limit && queenColumn > 1)
            {
                queenRow++;
                queenColumn--;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
                //Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }

        private static int MoveToSouthEast(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenRow > 1 && queenColumn < limit)
            {
                queenRow--;
                queenColumn++;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
                //Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }

        private static int MoveToSouthWest(int queenRow, int queenColumn, string obstacles, int limit)
        {
            int count = 0;
            while (queenRow > 1 && queenColumn > 1)
            {
                queenRow--;
                queenColumn--;
                string location = queenRow.ToString() + " " + queenColumn.ToString() + "\n";
                //Console.WriteLine(location);
                if (obstacles.Contains(location))
                    return count;
                count++;
            }
            return count;
        }
    }
}
