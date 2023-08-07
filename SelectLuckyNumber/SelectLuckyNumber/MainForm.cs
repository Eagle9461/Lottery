namespace SelectLuckyNumber
{
    public partial class MainForm : Form
    {
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
            newData.setExtraNumber((int) numDataExtra.Value);

            saveToFile(newData);
            //MessageBox.Show(newData.GetNumbers()[3].ToString());
        }
        private void saveToFile(OneData newData)
        {
            string folder = @"./";
            // Filename
            string fileName = "Data.txt";
            // Fullpath. You can direct hardcode it if you like.
            string fullPath = folder + fileName;
            // An array of strings
            // Write array of strings to a file using WriteAllLines.
            // If the file does not exists, it will create a new file.
            // This method automatically opens the file, writes to it, and closes file
            // Read a file
            string readText = File.ReadAllText(fullPath);
            File.WriteAllText(fullPath, readText+"\n"+newData.convertToString());
        }
    }
}