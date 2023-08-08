namespace SelectLuckyNumber
{
    public partial class MainForm : Form
    {
        public static string filePath = @"./Data.txt";

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

            foreach (string name in Enum.GetNames(typeof(ExtraTime)))
            {
                selDrawingTime.Items.Add(name);
            }
            selDrawingTime.SelectedIndex = (int)ExtraTime.Night;


            lstHistory.View = View.Details;
            lstHistory.Columns.Add("Date Time", 70, HorizontalAlignment.Center);
            lstHistory.Columns.Add("Numbers", 120, HorizontalAlignment.Center);
            lstHistory.Columns.Add("Power Ball", 80, HorizontalAlignment.Center);

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
            newData.SetDateTime(DateTime.Now);
            newData.SetExtraTime((ExtraTime)selDrawingTime.SelectedIndex);
            newData.SetNumbers(numbers);
            newData.SetExtraNumber((int)numDataExtra.Value);

            saveToFile(newData);
            //MessageBox.Show(newData.GetNumbers()[3].ToString());
        }
        private void saveToFile(OneData newData)
        {
            string readText = File.ReadAllText(filePath);

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
                history.Add(oneData);
            }
        }

        private void tabPane_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPane.SelectedIndex == 1)
            {
                readFromFile();

                lstHistory.Items.Clear();

                foreach (OneData one in history)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = one.GetDateTime().ToString();
                    item.SubItems.Add(one.GetStrNumbers().ToString());
                    item.SubItems.Add(one.GetExtraNumber().ToString());
                    lstHistory.Items.Add(item);
                }
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
    }
}