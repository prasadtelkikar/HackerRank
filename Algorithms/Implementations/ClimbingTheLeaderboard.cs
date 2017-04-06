using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: Incomplete. still failing some test cases.
namespace Implementations
{
    class ClimbingTheLeaderboard
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] scores_temp = Console.ReadLine().Split(' ');
            int[] scores = Array.ConvertAll(scores_temp, Int32.Parse);

            int m = Convert.ToInt32(Console.ReadLine());
            string[] alice_temp = Console.ReadLine().Split(' ');
            int[] alice_score = Array.ConvertAll(alice_temp, Int32.Parse);
            
        }
    }
}
