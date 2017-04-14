using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Tried minimum 6 submissions still problem is in todo.
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
            int towardsWestC = queenColumn, towardsEastC = queenColumn;
            int towardsNorthR = queenRow, towardsSouthR = queenRow;

            //I guess loop needed
            for (int i = 0; i < nk[1]; i++)
            {
                String[] obstacle = Console.ReadLine().Split(' ');
                int rowObstacle = Convert.ToInt32(obstacle[0]);
                int columnObstacle = Convert.ToInt32(obstacle[1]);

                if (queenRow == rowObstacle && queenColumn > columnObstacle)//Towards west
                {
                    int previousObs = (queenColumn - towardsWestC);
                    int currentObs = (queenColumn - columnObstacle);

                    if (previousObs == 0)
                        towardsWestC = columnObstacle;

                    if (previousObs != 0 && previousObs > currentObs)
                        towardsWestC = columnObstacle;
                }

                if (queenRow == rowObstacle && queenColumn < columnObstacle) //Towards east
                {
                    int previousObs = (towardsEastC - queenColumn);
                    int currentObs = (columnObstacle - queenColumn);

                    if (previousObs == 0)
                        towardsEastC = columnObstacle;

                    if (previousObs != 0 && previousObs < currentObs)
                        towardsEastC = columnObstacle;
                }

                if (queenRow < rowObstacle && queenColumn == columnObstacle) //Towards North
                {
                    int previousObs = (towardsNorthR - queenRow);
                    int currentObs = (rowObstacle - queenRow);

                    if (previousObs == 0)
                        towardsNorthR = columnObstacle;

                    if (previousObs != 0 && previousObs > currentObs)
                        towardsNorthR = columnObstacle;
                }
                if (queenRow > rowObstacle && queenColumn == columnObstacle) //Towards South
                {
                    int previousObs = (queenRow - towardsSouthR);
                    int currentObs = (queenRow - rowObstacle);

                    if (previousObs == 0)
                        towardsSouthR = rowObstacle;

                    if (previousObs != 0 && queenColumn == columnObstacle)
                        towardsSouthR = rowObstacle;
                }
                if (queenRow < rowObstacle && queenColumn < columnObstacle) ; //Towards North East
                if (queenRow > rowObstacle && queenColumn > columnObstacle) ; //Towards North West
                if (queenRow > rowObstacle && queenColumn < columnObstacle) ; //Towards South East
                if (queenRow < rowObstacle && queenColumn < columnObstacle) ; //Towards South West

            }

            /*StringBuilder obstacles = new StringBuilder();

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
            count += MoveToSouthWest(queenRow, queenColumn, obstacles.ToString(), nk[0]);*/
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
