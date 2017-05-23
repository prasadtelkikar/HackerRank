using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contests._101_hack_49
{
    class CartesianCountry
    {
        public static void Main(string[] args)
        {
            long minXdiff = 0, minYdiff = 0;
            string[] token_x = Console.ReadLine().Split(' ');
            long minX = Convert.ToInt32(token_x[0]);
            long minY = Convert.ToInt32(token_x[1]);

            string[] token_x1 = Console.ReadLine().Split(' ');
            long maxX = Convert.ToInt32(token_x1[0]);
            long maxY = Convert.ToInt32(token_x1[1]);

            string[] token_x2 = Console.ReadLine().Split(' ');
            long queenX = Convert.ToInt32(token_x2[0]);
            long queenY = Convert.ToInt32(token_x2[1]);

            long tempX1 = queenX - minX;
            long tempY1 = queenY - minY;

            long tempX2 = maxX - queenX;
            long tempY2 = maxY - queenY;

            minXdiff = (tempX1 < tempX2) ? tempX1 : tempX2;
            minYdiff = (tempY1 < tempY2) ? tempY1 : tempY2;

            long maxValue = (maxX > maxY) ? maxX : maxY;
            long count = 0;
            for (long i = 1; i <= maxValue; i++)
            {
                long currentHorizontalNegX = queenX + (-1*i);
                long currentHorizontalPosX = queenX + (1*i);
                if (currentHorizontalPosX <= maxX && currentHorizontalNegX >= minX)
                    count++;

                long currentVerticalNegY = queenY + (-1*i);
                long currentVerticalPosY = queenY + (1*i);
                if (currentVerticalPosY <= maxY && currentVerticalNegY >= minY)
                    count++;

                long currentDiaNEX = queenX + (1*i);
                long currentDiaNEY = queenY + (1*i);
                long currentDiaSWX = queenX + (-1 * i);
                long currentDiaSWY = queenY + (-1 * i);
                if ((currentDiaNEX <= maxX && currentDiaNEY <= maxY) && (currentDiaSWX >= minX && currentDiaSWY >= minY))
                    count++;

                long currentDiaNWX = queenX + (-1 * i);
                long currentDiaNWY = queenY + (1 * i);
                long currentDiaSEX = queenX + (1 * i);
                long currentDiaSEY = queenY + (-1 * i);
                if ((currentDiaNWX >= minX && currentDiaNWY <= maxY) && (currentDiaSEX <= maxX && currentDiaSEY >= minY))
                    count++;
                if (minXdiff > 1 || minYdiff > 1)
                {
                    long longDiaPosX = queenX + (minXdiff * 1 * i);
                    long longDiaPosY = queenY + (minYdiff * 1 * i);

                    long longDiaNegX = queenX + (minXdiff * -1 * i);
                    long longDiaNegY = queenY + (minYdiff * -1 * i);

                    if ((longDiaPosX <= maxX && longDiaPosY <= maxY) && (longDiaNegX >= minX && longDiaNegY >= minY))
                        count++;

                    long longSecondDiaPosX = queenX + (minXdiff * -1 * i);
                    long longSecondDiaPosY = queenY + (minYdiff * 1 * i);

                    long longSecondDiaNegX = queenX + (minXdiff * 1 * i);
                    long longSecondDiaNegY = queenY + (minYdiff * -1 * i);

                    if ((longSecondDiaPosX >= minX && longSecondDiaPosY <= maxY) &&
                        (longSecondDiaNegX <= maxX && longSecondDiaNegY >= minY))
                        count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
