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
            foreach (string name in Enum.GetNames(typeof(GameType)))
            {
                selGameType.Items.Add(name);
            }
            selGameType.SelectedIndex = (int)GameType.MegaMillions;

            foreach (string name in Enum.GetNames(typeof(ExtraTime)))
            {
                selDrawingTime.Items.Add(name);
            }
            selDrawingTime.SelectedIndex = (int)ExtraTime.Morning;

            foreach (int value in Enumerable.Range(1, 100))
            {
                selNumbersRange.Items.Add(value);
            }
            selNumbersRange.SelectedIndex = 75;

            foreach (int value in Enumerable.Range(1, 60))
            {
                selExtraNumberRange.Items.Add(value);
            }
            selExtraNumberRange.SelectedIndex = 35;

            lstHistory.View = View.Details;
            lstHistory.Columns.Add("Date Time", 70, HorizontalAlignment.Center);
            lstHistory.Columns.Add("Numbers", 120, HorizontalAlignment.Center);
            lstHistory.Columns.Add("Power Ball", 80, HorizontalAlignment.Center);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
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
            if(!File.Exists(filePath)) { return; }
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
            if(tabPane.SelectedIndex == 1)
            {
                readFromFile();

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
    }
}