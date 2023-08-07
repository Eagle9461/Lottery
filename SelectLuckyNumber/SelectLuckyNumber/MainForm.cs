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

            newData.SetDateTime(DateTime.Now);
            newData.SetExtraTime((ExtraTime)selDrawingTime.SelectedIndex);
            MessageBox.Show(newData.GetExtraTime().ToString());
           
        }
    }
}