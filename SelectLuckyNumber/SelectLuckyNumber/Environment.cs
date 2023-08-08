using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectLuckyNumber
{
    enum ExtraTime
    {
        Morning,
        Midday,
        Evening,
        Night
    }
    enum GameType
    {
        Pick3,
        Pick4,
        Pick5,
        Pick6,
        MegaMillions,
        PowerBall,
    }

    internal class Environment
    {
        public static int[][] MIN_MAX_NUMBERS = new int[][]
        {
            new int[] { 1, 9, 1, 9 },
            new int[] { 1, 9, 1, 9 },
            new int[] { 1, 49, 1, 9 },
            new int[] { 1, 46, 0, 0 },
            new int[] { 1, 70, 1, 25 },
            new int[] { 1, 69, 1, 26 }
        };

        public static int[] COUNT_OF_NUMBER = new int[]
        {
            3,4,5,6,6,6
        };

        public static string ConvertArrayToString(int[] numbers)
        {
            string str = "";
            foreach(int number in numbers)
            {
                str += number.ToString(); str += ", ";
            }
            return str;
        }
    }
}
