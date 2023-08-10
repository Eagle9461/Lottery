using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UndergroundPlayBook
{
    public partial class Main : Form
    {
        public static string filePath = @"./Data.txt";

        private GameType filterGameType = GameType.MegaMillions;

        private GameType gameType;

        private List<OneData> history = new List<OneData> { };

        private int min, max, emin, emax;

        public Main()
        {
            InitializeComponent();
            RedrawControls();
        }

        private void tabDataEntry_Click(object sender, EventArgs e)
        {

        }

        private void RedrawControls()
        {
            foreach (int value in Enumerable.Range(1, 100))
            {
                selNumbersRange.Items.Add(value);
            }

            foreach (int value in Enumerable.Range(1, 60))
            {
                selExtraNumberRange.Items.Add(value);
            }

            foreach (string name in Enum.GetNames(typeof(GameType)))
            {
                selGameType.Items.Add(name);
            }
            selGameType.SelectedIndex = (int)GameType.MegaMillions;

            foreach (string name in Enum.GetNames(typeof(GameType)))
            {
                selGameTypeToCalculate.Items.Add(name);
            }
            selGameTypeToCalculate.SelectedIndex = (int)GameType.MegaMillions;

            foreach (string name in Enum.GetNames(typeof(ExtraTime)))
            {
                selDrawingTime.Items.Add(name);
            }
            selDrawingTime.SelectedIndex = (int)ExtraTime.Night;


            lstHistory.View = View.Details;
            lstHistory.Columns.Add("Date Time", 70, HorizontalAlignment.Center);
            lstHistory.Columns.Add("Numbers", 120, HorizontalAlignment.Center);
            lstHistory.Columns.Add("Extra", 80, HorizontalAlignment.Center);

            lstResult.View = View.Details;
            lstResult.Columns.Add(" # ", 30, HorizontalAlignment.Center);
            lstResult.Columns.Add("Numbers", 120, HorizontalAlignment.Center);
            lstResult.Columns.Add("Extra", 80, HorizontalAlignment.Center);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid()) return;
            OneData newData = new OneData();
            int[] numbers = new int[6];
            numbers[0] = (int)numData1.Value;
            numbers[1] = (int)numData2.Value;
            numbers[2] = (int)numData3.Value;
            numbers[3] = (int)numData4.Value;
            numbers[4] = (int)numData5.Value;
            numbers[5] = (int)numData6.Value;

            newData.SetGameType((GameType)selGameType.SelectedIndex);
            newData.SetDateTime(calendar.SelectionStart);
            newData.SetExtraTime((ExtraTime)selDrawingTime.SelectedIndex);
            newData.SetNumbers(numbers);
            newData.SetExtraNumber((int)numData1.Value);

            saveToFile(newData);
            //MessageBox.Show(newData.GetNumbers()[3].ToString());
        }
        private void saveToFile(OneData newData)
        {
            string readText = "";
            if (File.Exists(filePath))
            {
                readText = File.ReadAllText(filePath);
            }

            File.WriteAllText(filePath, readText + "\n" + newData.ConvertToString());
        }
        private void readFromFile()
        {
            history.Clear();

            if (!File.Exists(filePath)) { return; }
            string readText = File.ReadAllText(filePath);

            string[] datas = readText.Split('\n');
            foreach (string data in datas)
            {
                if (data == "") continue;
                OneData oneData = new OneData();
                oneData.SetDataFromString(data);
                if (oneData.GetGameType() == filterGameType)
                {
                    history.Add(oneData);
                }
            }
        }
        private void loadDataToHistory()
        {
            readFromFile();

            lstHistory.Items.Clear();

            foreach (OneData one in history)
            {
                ListViewItem item = new ListViewItem();
                item.Text = one.GetDateTime().ToString();
                item.SubItems.Add(one.GetStrNumbers().ToString());
                if (filterGameType == GameType.MegaMillions || filterGameType == GameType.PowerBall)
                    item.SubItems.Add(one.GetExtraNumber().ToString());
                lstHistory.Items.Add(item);
            }
        }
        private void tabPane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPane.SelectedIndex == 1)
            {
                loadDataToHistory();
            }
        }

        private void selGameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gameType = (GameType)selGameType.SelectedIndex;
            numData1.Value = 1;
            numData2.Value = 1;
            numData3.Value = 1;
            numData4.Value = 1;
            numData5.Value = 1;
            numData6.Value = 1;
            numDataExtra.Value = 1;

            min = Environment.MIN_MAX_NUMBERS[(int)gameType][0];
            max = Environment.MIN_MAX_NUMBERS[(int)gameType][1];
            emin = Environment.MIN_MAX_NUMBERS[(int)gameType][2];
            emax = Environment.MIN_MAX_NUMBERS[(int)gameType][3];

            switch ((GameType)selGameType.SelectedIndex)
            {
                case GameType.Pick3:
                    numData4.Enabled = false;
                    numData5.Enabled = false;
                    numData6.Enabled = false;
                    numDataExtra.Enabled = false;
                    selNumbersRange.SelectedIndex = 8;
                    selExtraNumberRange.SelectedIndex = 8;
                    selNumbersRange.Enabled = false;
                    selExtraNumberRange.Enabled = false;
                    selDrawingTime.Enabled = true;
                    break;
                case GameType.Pick4:
                    numData4.Enabled = true;
                    numData5.Enabled = false;
                    numData6.Enabled = false;
                    numDataExtra.Enabled = false;
                    selNumbersRange.SelectedIndex = 8;
                    selExtraNumberRange.SelectedIndex = 8;
                    selNumbersRange.Enabled = false;
                    selExtraNumberRange.Enabled = false;
                    selDrawingTime.Enabled = true;
                    break;
                case GameType.Pick5:
                    numData4.Enabled = true;
                    numData5.Enabled = true;
                    numData6.Enabled = false;
                    numDataExtra.Enabled = false;
                    selNumbersRange.SelectedIndex = 48;
                    selExtraNumberRange.SelectedIndex = 8;
                    selNumbersRange.Enabled = true;
                    selExtraNumberRange.Enabled = false;
                    selDrawingTime.Enabled = false;
                    break;
                case GameType.Pick6:
                    numData4.Enabled = true;
                    numData5.Enabled = true;
                    numData6.Enabled = true;
                    numDataExtra.Enabled = false;
                    selNumbersRange.SelectedIndex = 45;
                    selExtraNumberRange.SelectedIndex = 0;
                    selNumbersRange.Enabled = true;
                    selExtraNumberRange.Enabled = false;
                    selDrawingTime.Enabled = false;
                    break;
                case GameType.MegaMillions:
                    numData4.Enabled = true;
                    numData5.Enabled = true;
                    numData6.Enabled = false;
                    numDataExtra.Enabled = true;
                    selNumbersRange.SelectedIndex = 69;
                    selExtraNumberRange.SelectedIndex = 24;
                    selNumbersRange.Enabled = true;
                    selExtraNumberRange.Enabled = true;
                    selDrawingTime.Enabled = false;
                    break;
                case GameType.PowerBall:
                    numData4.Enabled = true;
                    numData5.Enabled = true;
                    numData6.Enabled = false;
                    numDataExtra.Enabled = true;
                    selNumbersRange.SelectedIndex = 68;
                    selExtraNumberRange.SelectedIndex = 25;
                    selNumbersRange.Enabled = true;
                    selExtraNumberRange.Enabled = true;
                    selDrawingTime.Enabled = false;
                    break;
            }
        }
        private bool isValid()
        {

            if (numData1.Value > max || numData1.Value < min)
            {
                MessageBox.Show("Number 1 is Invalid. Must to be "+min+" to "+max+".\n");
                return false;
            }
            if (numData2.Value > max || numData2.Value < min)
            {
                MessageBox.Show("Number 2 is Invalid. Must to be " + min + " to " + max + ".\n");
                return false;
            }
            if (numData3.Value > max || numData3.Value < min)
            {
                MessageBox.Show("Number 3 is Invalid. Must to be " + min + " to " + max + ".\n");
                return false;
            }
            if (numData4.Value > max || numData4.Value < min)
            {
                MessageBox.Show("Number 4 is Invalid. Must to be " + min + " to " + max + ".\n");
                return false;
            }
            if (numData5.Value > max || numData5.Value < min)
            {
                MessageBox.Show("Number 5 is Invalid. Must to be " + min + " to " + max + ".\n");
                return false;
            }
            if (numData6.Value > max || numData6.Value < min)
            {
                MessageBox.Show("Number 6 is Invalid. Must to be " + min + " to " + max + ".\n");
                return false;
            }
            if (numDataExtra.Value > emax || numDataExtra.Value < emin)
            {
                MessageBox.Show("Extra Number must be "+emin+" to "+emax+".\n");
                return false;
            }
            return true;
        }

        private void selNumbersRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            max = selNumbersRange.SelectedIndex + 1;
        }

        private void selExtraNumberRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            emax = selExtraNumberRange.SelectedIndex + 1;
        }

        private void btnDeleteHistory_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filePath, "");
            lstHistory.Items.Clear();
        }
        private void numData1_Enter(object sender, EventArgs e)
        {
            numData1.Select(0, numData1.ToString().Length);
        }

        private void numData2_Enter(object sender, EventArgs e)
        {
            numData2.Select(0, numData2.ToString().Length);
        }


        private void numData3_Enter(object sender, EventArgs e)
        {
            numData3.Select(0, numData3.ToString().Length);
        }

        private void numData4_Enter(object sender, EventArgs e)
        {
            numData4.Select(0, numData4.ToString().Length);
        }

        private void numData5_Enter(object sender, EventArgs e)
        {
            numData5.Select(0, numData5.ToString().Length);
        }

        private void numData6_Enter(object sender, EventArgs e)
        {
            numData6.Select(0, numData6.ToString().Length);
        }

        private void numDataExtra_Enter(object sender, EventArgs e)
        {
            numDataExtra.Select(0, numDataExtra.ToString().Length);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();

            Calculation Oper = new Calculation(history, filterGameType);
            Oper.SetMinMaxNumber(Environment.MIN_MAX_NUMBERS[(int)filterGameType]);
            if(!Oper.WriteTable())return;
            Oper.SortTable();
            Oper.MakeMedianTable();
            Oper.Validate();
            Oper.MakeResultNumbers();
            int[][] result = Oper.GetResult();

            int n = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] != null)
                {
                    if (Environment.isDuplicate(result[i])) { continue; }
                    ListViewItem item = new ListViewItem();
                    item.Text = (++n).ToString();
                    int[] numbers;
                    if (filterGameType == GameType.MegaMillions || filterGameType == GameType.PowerBall)
                    {
                        numbers = Environment.Slice(result[i], 0, Environment.COUNT_OF_NUMBER[(int)filterGameType] - 1);
                        item.SubItems.Add(Environment.ConvertArrayToString(numbers));
                        item.SubItems.Add(result[i][Environment.COUNT_OF_NUMBER[(int)filterGameType] - 1].ToString());
                    }
                    else
                    {
                        numbers = Environment.Slice(result[i], 0, Environment.COUNT_OF_NUMBER[(int)filterGameType]);
                        item.SubItems.Add(Environment.ConvertArrayToString(numbers));
                    }
                    lstResult.Items.Add(item);
                }
            }
            //Oper.DisplayTable();

        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }

        private void selGameTypeToCalculate_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterGameType = (GameType)selGameTypeToCalculate.SelectedIndex;

            loadDataToHistory();
        }
    }
}
