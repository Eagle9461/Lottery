using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndergroundPlayBook
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

    internal static class Environment
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
        public static bool isDuplicate(int[] numbers)
        {
            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = 0;j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j] &&  i != j) { return true; }
                }
            }
            return false;
        }
        public static bool IsSameArray(int[] x, int[] y)
        {
            try
            {
                for(int i = 0; i<x.Length; i++)
                {  
                    if (x[i] != y[i]) { return false; }
                }
            } catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public static int[][] RemoveSame(int[][] res)
        {
            int[][] result = new int[res.Length][];
            int n = 0;
            for(int i = 0; i < res.Length; i++)
            {
                bool isOk = true;
                for(int j = 0; j < res.Length; j++)
                {
                    if (IsSameArray(res[i], res[j]) && i != j) isOk = false;
                }
                if (isOk) result[n] = res[i];
                else continue;
                n++;
            }
            return result;
        }
        public static T[] Slice<T>(this T[] source, int start, int end)
        {
            // Handles negative ends.
            if (end < 0)
            {
                end = source.Length + end;
            }
            int len = end - start;

            // Return new array.
            T[] res = new T[len];
            for (int i = 0; i < len; i++)
            {
                res[i] = source[i + start];
            }
            return res;
        }
    }
}
