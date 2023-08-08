using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectLuckyNumber
{
    internal class Calculation
    {
        private int[][] table = new int[5][];
        private int[][] result = new int[30][];

        private List<OneData> datas;
        private bool isSorted = false;
        private static int MAX_NUMBER;
        private static int MIN_NUMBER;
        private static int MAX_EXTRANUMBER;
        private static int MIN_EXTRANUMBER;

        private GameType gameType;
        private int digit_count;
        public Calculation(List<OneData> datas, GameType gameType)
        {
            this.datas = datas;
            this.gameType = gameType;
            this.digit_count = Environment.COUNT_OF_NUMBER[(int)gameType];
        }
        public void SetMinMaxNumber(int[] numbers)
        {
            MIN_NUMBER = numbers[0];
            MAX_NUMBER = numbers[1];
            MIN_EXTRANUMBER = numbers[2];
            MAX_EXTRANUMBER = numbers[3];
        }
        public int[][] GetTable() { return this.table; }
        public void SetTable(int[][] table) { this.table = table; }
        public int[][] GetResult() { return this.result; }
        public bool WriteTable()
        {
            if (datas.Count < 5)
            {
                MessageBox.Show("Errors Occured\n History must be more than 5.\n");
                return false;
            }
            for(int i = 0; i < 5; i++)
            {
                table[i] = datas[i].GetNumbers();
                table[i][5] = datas[i].GetExtraNumber();
            }
            return true;
        }
        public void SortTable()
        {
            int[] row = new int[this.table.Length];
            for(int j = 0; j < digit_count; j++)
            {
                for (int i = 0; i < this.table.Length; i++)
                {
                    row[i] = this.table[i][j];
                }

                row = SortRow(row);
                
                for (int i = 0; i < this.table.Length; i++)
                {
                    this.table[i][j] = row[i];
                }
            }
            isSorted = true;
        }
        private int[] SortRow(int[] row)
        {
            for(int i = 0; i < row.Length - 1 ; i++)
            {
                for(int j = i + 1; j < row.Length; j++)
                {
                    if (row[i] < row[j])
                    {
                        int x = row[i];
                        row[i] = row[j];
                        row[j] = x;
                    }
                }
            }
            return row;
        }
        public void MakeMedianTable()
        {
            if(!isSorted) { MessageBox.Show("You need to sort a table firstly.\n"); return; }
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < digit_count; j++)
                {
                    table[i][j] = table[2][j] + (i - 2);
                }
            }
        }
        public void DisplayTable()
        {
            string str = "";
            for(int i = 0;i < this.table.Length; i++)
            {
                for(int j = 0; j < digit_count; j++)
                {
                    str += this.table[i][j] + ", ";
                }
                str += "\n";
            }
            MessageBox.Show(str);
        }
        public void MakeResultNumbers()
        {
            for(int i = 0; i < 5 * digit_count; i++)
            {
                result[i] = new int[digit_count];
                for(int j = 0; j < digit_count; j++)
                {
                    if (i / 5 == j)
                    { 
                        result[i][j] = table[i % 5][j];
                    }
                    else
                    {
                        result[i][j] = table[2][j];
                    }
                }
            }
        }
        public void Validate()
        {
            int SPAN_NUMBER = MAX_NUMBER - MIN_NUMBER + 1;
            int SPAN_EXTRANUMBER = MAX_EXTRANUMBER - MIN_EXTRANUMBER + 1;
            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    //MessageBox.Show(MIN_NUMBER.ToString());
                    if (table[i][j] < MIN_NUMBER) table[i][j] += SPAN_NUMBER;
                    if (table[i][j] > MAX_NUMBER) table[i][j] -= SPAN_NUMBER;
                }
                if( gameType == GameType.MegaMillions || gameType == GameType.PowerBall)
                {
                    if (table[i][5] < MIN_NUMBER) table[i][5] += SPAN_EXTRANUMBER;
                    if (table[i][5] > MAX_NUMBER) table[i][5] -= SPAN_EXTRANUMBER;
                } 
                else
                {
                    if (table[i][5] < MIN_NUMBER) table[i][5] += SPAN_NUMBER;
                    if (table[i][5] > MAX_NUMBER) table[i][5] -= SPAN_NUMBER;
                }
            }
        }
    }
}
