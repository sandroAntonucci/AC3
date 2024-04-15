namespace AC3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Recoge los datos csv y actualiza el dataGridView
        private void Form1_Load(object sender, EventArgs e)
        {
            List<ConsumAigua> consumAigua = Helper.GetCSV("../../../consum.csv");
            dataGridView1.DataSource = consumAigua;
        }
    }
}
