using System.Globalization;
using System.Security.Policy;

namespace SelectLuckyNumber
{
    public partial class MainForm : Form
    {
        public static string filePath = @"./Data.txt";

        private GameType filterGameType = GameType.MegaMillions;

        private List<OneData> history = new List<OneData> { };
        public MainForm()
        {
            InitializeComponent();
            RedrawControls();
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
            newData.SetExtraNumber((int)numDataExtra.Value);

            saveToFile(newData);
            //MessageBox.Show(newData.GetNumbers()[3].ToString());
        }
        private void saveToFile(OneData newData)
        {
            string readText = "";
            if (File.Exists(filePath)) {
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
                    selDrawingTime.Enabled = true;
                    break;
                case GameType.Pick6:
                    numData4.Enabled = true;
                    numData5.Enabled = true;
                    numData6.Enabled = true;
                    numDataExtra.Enabled = false;
                    selNumbersRange.SelectedIndex = 45;
                    selExtraNumberRange.SelectedIndex = 8;
                    selNumbersRange.Enabled = false;
                    selExtraNumberRange.Enabled = false;
                    selDrawingTime.Enabled = true;
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
            if (numData1.Value > selNumbersRange.SelectedIndex + 1)
            {
                MessageBox.Show("Number 1 is Invalid.\n");
                return false;
            }
            if (numData2.Value > selNumbersRange.SelectedIndex + 1)
            {
                MessageBox.Show("Number 2 is Invalid.\n");
                return false;
            }
            if (numData3.Value > selNumbersRange.SelectedIndex + 1)
            {
                MessageBox.Show("Number 3 is Invalid.\n");
                return false;
            }
            if (numData4.Value > selNumbersRange.SelectedIndex + 1)
            {
                MessageBox.Show("Number 4 is Invalid.\n");
                return false;
            }
            if (numData5.Value > selNumbersRange.SelectedIndex + 1)
            {
                MessageBox.Show("Number 5 is Invalid.\n");
                return false;
            }
            if (numData6.Value > selNumbersRange.SelectedIndex + 1)
            {
                MessageBox.Show("Number 6 is Invalid.\n");
                return false;
            }
            if (numDataExtra.Value > selExtraNumberRange.SelectedIndex + 1)
            {
                MessageBox.Show("Extra Number must be less than the Extra Number Range.\n");
                return false;
            }
            return true;
        }

        private void selGameTypeToCalculate_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterGameType = (GameType)selGameTypeToCalculate.SelectedIndex;

            loadDataToHistory();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();

            Calculation Oper = new Calculation(history, filterGameType);
            Oper.SetMinMaxNumber(Environment.MIN_MAX_NUMBERS[(int)filterGameType]);
            Oper.WriteTable();
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
                    int[] numbers = new int[5];
                    if (filterGameType == GameType.MegaMillions || filterGameType == GameType.PowerBall)
                    {
                        numbers = result[i][new Range(0, Environment.COUNT_OF_NUMBER[(int)filterGameType]-1)];
                        item.SubItems.Add(Environment.ConvertArrayToString(numbers));
                        item.SubItems.Add(result[i][Environment.COUNT_OF_NUMBER[(int)filterGameType]-1].ToString());
                    }
                    else
                    {
                        numbers = result[i][new Range(0, Environment.COUNT_OF_NUMBER[(int)filterGameType])];
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
    }
}