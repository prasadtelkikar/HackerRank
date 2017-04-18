using System;
using System.IO;
/*Sample input 0:
 * 4 0
 * 4 4
 * Sample output 0:
 * 9
 * Sample input 1:
 * 5 3
 * 4 3
 * 5 5
 * 4 2
 * 2 3
 * Sample output 1:
 * 10
 */
namespace Implementations
{
    /// <summary>
    /// Interesting program: Calculated nearest obstacle and then calculated distance.
    /// https://www.hackerrank.com/challenges/queens-attack-2
    /// </summary>
    class QueensAttack
    {
        public static void Main(String[] args)
        {

            /*//for long inputs
            string path = Directory.GetCurrentDirectory();
            string[] readAllLines = File.ReadAllLines(Path.Combine(path, "QueensAttack.txt"));
            String[] nkString = readAllLines[0].Split(' ');
            int[] nk = Array.ConvertAll(nkString, Int32.Parse);
            String[] queenString = readAllLines[1].Split(' ');
            int queenRow = Convert.ToInt32(queenString[0]);
            int queenColumn = Convert.ToInt32(queenString[1]);
            */
            
            String[] nkString = Console.ReadLine().Split(' ');
            int[] nk = Array.ConvertAll(nkString, Int32.Parse);
            String[] queenString = Console.ReadLine().Split(' ');
            int queenRow = Convert.ToInt32(queenString[0]);
            int queenColumn = Convert.ToInt32(queenString[1]);
           
            int towardsWestC = 0, towardsEastC = nk[0] + 1;
            int towardsNorthR = nk[0] + 1, towardsSouthR = 0;
            int towardsNERow = nk[0] + 1, towardsNEColumn = nk[0] + 1;
            int towardsNWRow = nk[0] + 1, towardsNWColumn = 0;
            int towardsSERow = 1, towardsSEColumn = nk[0] + 1;
            int towardsSWRow = 1, towardsSWColumn = 0;

            for (int i = 0; i < nk[1]; i++)
            {
                String[] obstacle = Console.ReadLine().Split(' ');
                //for long input
              //  String[] obstacle = readAllLines[i + 2].Split(' ');
                int rowObstacle = Convert.ToInt32(obstacle[0]);
                int columnObstacle = Convert.ToInt32(obstacle[1]);

                //Towards west
                if (queenRow == rowObstacle && queenColumn > columnObstacle)
                    towardsWestC = GetMinimumDistanceSecond(queenColumn, towardsWestC, columnObstacle);

                //Towards South
                if (queenRow > rowObstacle && queenColumn == columnObstacle)
                    towardsSouthR = GetMinimumDistanceSecond(queenRow, towardsSouthR, rowObstacle);

                //Towards east
                if (queenRow == rowObstacle && queenColumn < columnObstacle)
                    towardsEastC = GetMinimualDistanceFirst(towardsEastC, queenColumn, columnObstacle);
                //Towards North
                if (queenRow < rowObstacle && queenColumn == columnObstacle)
                    towardsNorthR = GetMinimualDistanceFirst(towardsNorthR, queenRow, rowObstacle);

                //Towards North East
                if (rowObstacle - queenRow > 0 && (rowObstacle - queenRow == columnObstacle - queenColumn))
                    GetMinimumDistanceNorth(queenRow, ref towardsNERow, ref towardsNEColumn, rowObstacle, columnObstacle);
                //North west
                if (rowObstacle - queenRow > 0 && (rowObstacle - queenRow == queenColumn - columnObstacle))
                    GetMinimumDistanceNorth(queenRow, ref towardsNWRow, ref towardsNWColumn, rowObstacle, columnObstacle);
                
                //South West
                if (queenRow - rowObstacle > 0 && (queenRow - rowObstacle == queenColumn - columnObstacle))
                    GetMinimumDistanceSouth(queenRow, ref towardsSWRow, ref towardsSWColumn, rowObstacle, columnObstacle);
                
                //south east
                if (queenRow - rowObstacle > 0 && (queenRow - rowObstacle == columnObstacle - queenColumn))
                    GetMinimumDistanceSouth(queenRow, ref towardsSERow, ref towardsSEColumn, rowObstacle, columnObstacle);
            }
            int count = 0;
            int choice = 1;
            while (choice < 9)
            {
                switch (choice)
                {
                    case 1://East
                        if (queenColumn == towardsEastC)
                            towardsEastC = nk[0];

                        for (int i = queenColumn + 1; i <= nk[0]; i++)
                        {
                            if (i == towardsEastC)
                                break;
                            else
                                count++;
                        }
                        break;
                    case 2://West
                        if (queenColumn == towardsWestC)
                            towardsWestC = 1;
                        for (int i = queenColumn - 1; i >= 1; i--)
                        {
                            if (i == towardsWestC)
                                break;
                            else count++;
                        }
                        break;
                    case 3: //North
                        if (towardsNorthR == queenRow)
                            towardsNorthR = nk[0];
                        for (int i = queenRow + 1; i <= nk[0]; i++)
                        {
                            if (i == towardsNorthR)
                                break;
                            else
                                count++;
                        }
                        break;
                    case 4://south
                        if (queenRow == towardsSouthR)
                            towardsSouthR = 1;
                        for (int i = queenRow - 1; i >= 1; i--)
                        {
                            if (i == towardsSouthR)
                                break;
                            else count++;
                        }
                        break;
                    case 5://NorthEast
                        if (queenRow + 1 > nk[0] || queenColumn + 1 > nk[0])
                            break;
                        if (queenRow == towardsNERow && queenColumn == towardsNEColumn)
                        {
                            towardsNEColumn = towardsNERow = nk[0];
                        }
                        int tempQC = queenColumn + 1, tempQR = queenRow + 1;
                        while (tempQC <= nk[0] && tempQR <= nk[0])
                        {
                            if (tempQC == towardsNEColumn && tempQR == towardsNERow)
                                break;
                            else count++;

                            tempQR++;
                            tempQC++;
                        }
                        break;
                    case 6: //SouthWest
                        if (queenRow - 1 > nk[0] || queenColumn - 1 > nk[0] || queenRow - 1 < 1 || queenColumn - 1 < 1)
                            break;
                        if (queenRow == towardsSWRow && queenColumn == towardsSWColumn)
                        {
                            towardsSWColumn = towardsSWRow = 1;
                        }
                        tempQC = queenColumn - 1;
                        tempQR = queenRow - 1;
                        while (tempQR >= 1 && tempQC >= 1)
                        {
                            if (tempQC == towardsSWColumn && tempQR == towardsSWRow)
                                break;
                            else count++;

                            tempQR--;
                            tempQC--;
                        }
                        break;
                    case 7://NorthWest
                        if (queenRow + 1 > nk[0] || queenColumn - 1 > nk[0] || queenRow + 1 < 1 || queenColumn - 1 < 1)
                            break;

                        if (queenRow == towardsNWRow && queenColumn == towardsNWColumn)
                        {
                            towardsNWRow = nk[0];
                            towardsNWColumn = 1;
                        }
                        tempQC = queenColumn - 1;
                        tempQR = queenRow + 1;
                        while (tempQR <= nk[0] && tempQC >= 1)
                        {
                            if (tempQC == towardsNWColumn && tempQR == towardsNWRow)
                                break;
                            else count++;

                            tempQR++;
                            tempQC--;
                        }
                        break;
                    case 8://SouthEast
                        if (queenRow - 1 > nk[0] || queenColumn + 1 > nk[0] || queenRow - 1 < 1 || queenColumn + 1 < 1)
                            break;
                        if (queenRow == towardsSERow && queenColumn == towardsSEColumn)
                        {
                            towardsSERow = 1;
                            towardsSEColumn = nk[0];
                        }
                        tempQC = queenColumn + 1;
                        tempQR = queenRow - 1;
                        while (tempQR >= 1 && tempQC <= nk[0])
                        {
                            if (tempQC == towardsSEColumn && tempQR == towardsSERow)
                                break;
                            else count++;

                            tempQR--;
                            tempQC++;
                        }
                        break;
                    default:
                        break;
                }
                choice++;
            }

            Console.WriteLine(count);
            /*
            Console.WriteLine("Queens position:(" + queenRow + ", " + queenColumn + ")");
            Console.WriteLine("West position:(" + queenRow + ", " + towardsWestC + ")");
            Console.WriteLine("East position:(" + queenRow + ", " + towardsEastC + ")");
            Console.WriteLine("North position:(" + towardsNorthR + ", " + queenColumn + ")");
            Console.WriteLine("South position:(" + towardsSouthR + ", " + queenColumn + ")");
            Console.WriteLine("NorthEast position:(" + towardsNERow + ", " + towardsNEColumn + ")");
            Console.WriteLine("NorthWest position:(" + towardsNWRow + ", " + towardsNWColumn + ")");
            Console.WriteLine("SouthEast position:(" + towardsSERow + ", " + towardsSEColumn + ")");
            Console.WriteLine("SouthWest position:(" + towardsSWRow + ", " + towardsSWColumn + ")");
            */
            Console.ReadKey();
        }

        private static void GetMinimumDistanceSouth(int queenPosition, ref int nearestSWRow, ref int nearestSWColumn, int rowObstacle, int columnObstacle)
        {
            int previousObs = queenPosition - nearestSWRow;
            int currentObs = queenPosition - rowObstacle;
            if (previousObs == 0)
            {
                nearestSWRow = rowObstacle;
                nearestSWColumn = columnObstacle;
            }
            if (previousObs != 0 && previousObs > currentObs)
            {
                nearestSWRow = rowObstacle;
                nearestSWColumn = columnObstacle;
            }
        }

        private static void GetMinimumDistanceNorth(int queenPosition, ref int nearestNERow, ref int nearestNEColumn, int rowObstacle, int columnObstacle)
        {
            int previousObs = nearestNERow - queenPosition;
            int currentObs = rowObstacle - queenPosition;
            if(previousObs <= 0)
            {
                nearestNERow = rowObstacle;
                nearestNEColumn = columnObstacle;
            }
            if (previousObs != 0 && previousObs > currentObs)
            {
                nearestNERow = rowObstacle;
                nearestNEColumn = columnObstacle;
            }
        }

        private static int GetMinimualDistanceFirst(int nearestObs, int queenPosition, int obstacle)
        {
            int previousObs = (nearestObs - queenPosition);
            int currentObs = (obstacle - queenPosition);

            if (previousObs != 0 && previousObs > currentObs)
                nearestObs = obstacle;
            return nearestObs;
        }

        private static int GetMinimumDistanceSecond(int queenPosition, int nearestObs, int obstacle)
        {
            int previousObs = (queenPosition - nearestObs);
            int currentObs = (queenPosition - obstacle);

            if (previousObs != 0 && previousObs > currentObs)
                nearestObs = obstacle;

            return nearestObs;
        }
    }
}
