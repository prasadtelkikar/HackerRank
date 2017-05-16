using System;
/*
 * Sample input:
 * 7 8 6
 * 16 19 7 11 23 8 16
 * 
 * Sample output:
 * 4
 */
namespace Contests.Week_of_Code_32
{
    /// <summary>
    /// Fight the monster
    /// https://www.hackerrank.com/contests/w32/challenges/fight-the-monsters
    /// </summary>
    public class FightTheMonster
    {
        public static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int numberOfMonsters = Convert.ToInt32(tokens_n[0]);
            int hit = Convert.ToInt32(tokens_n[1]);
            int chances = Convert.ToInt32(tokens_n[2]);
            string[] h_temp = Console.ReadLine().Split(' ');
            int[] h = Array.ConvertAll(h_temp, Int32.Parse);
            int result = GetMaxMonsters(numberOfMonsters, hit, chances, h);
            Console.WriteLine(result);
            Console.ReadKey();
        }

        private static int GetMaxMonsters(int numberOfMonsters, int hit, int chances, int[] monstersHealth)
        {
            Array.Sort(monstersHealth);
            int countMonsterDied = 0;
            int i = 0;
            while(numberOfMonsters > i && chances > 0)
            {
                //int result = Int32.MaxValue;
                while (monstersHealth[i] > 0 && chances > 0)
                {
                    monstersHealth[i] -= hit;
                    chances--;
                    if (monstersHealth[i] <= 0)
                        countMonsterDied++;
                }
                i++;
            }
            return countMonsterDied;
        }
    }
}