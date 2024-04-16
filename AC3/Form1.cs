using System.Xml.Linq;
using CsvHelper.Configuration.Attributes;

namespace AC3
{
    public partial class Form1 : Form
    {

        const int MaxPoblation = 20000, Zero = 0, One = 1, Two = 2, Three = 3, Four = 4, Seven = 7;

        const string CsvPath = "../../../consum.csv", XmlPath = "../../../comarques.xml", Yes = "Si", No = "No";

        public Form1()
        {
            InitializeComponent();
        }

        // S'executa al carregar el formulari
        private void Form1_Load(object sender, EventArgs e)
        {
            // S'agafen les dades del csv
            List<ConsumAigua> consumAigua = Helper.GetCSV(CsvPath);

            // Es guarden les comarques en un fitxer xml
            Helper.ConvertToXML(consumAigua);

            // S'amplien les dades del datagridview amb consumAigua

            foreach (var item in consumAigua)
            {
                dataGridView1.Rows.Add(item.Any, item.CodiComarca, item.Comarca, item.Poblacio, item.DomXarxa, item.ActEcon, item.Total, item.ConsDomPerCapita);
            }

            // S'actualitza el combobox de comarques mitjançant el XML amb linq
            XDocument doc = XDocument.Load(XmlPath);

            var comarcas = doc.Descendants("Comarca")
                  .Select(c => new
                  {
                      CodiComarca = c.Element("CodiComarca")?.Value,
                      Comarca = c.Element("Comarca")?.Value
                  })
                  .Where(c => c.CodiComarca != null && c.Comarca != null);

            foreach (var comarca in comarcas)
            {
                cmbComarca.Items.Add(comarca.Comarca);
            }

        }

        // S'actualitzen les estadístiques
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > Zero)
            {

                //Població més gran que 20000 si o no
                float poblacio = Convert.ToInt32(dataGridView1.SelectedRows[Zero].Cells[Three].Value);

                lblPoblationGreater.Text = poblacio > MaxPoblation ? Yes : No;

                //Consum mitjà per habitant
                float domXarxa = Convert.ToInt32(dataGridView1.SelectedRows[Zero].Cells[Four].Value);
                lblConsMitj.Text = Math.Round(domXarxa / poblacio, Two).ToString();

                //Cons dom per capita major de tots si o no
                float consDomPerCapita = Convert.ToSingle(dataGridView1.SelectedRows[Zero].Cells[Seven].Value);

                // S'actualitza el consum màxim i mínim
                float maxConsCap = Helper.GetMaxConsum(Helper.GetCSV(CsvPath));
                float minConsCap = Helper.GetMinConsum(Helper.GetCSV(CsvPath));

                lblConsCapMax.Text = consDomPerCapita == maxConsCap ? Yes : No;
                lblConsCapLow.Text = consDomPerCapita == minConsCap ? Yes : No;

            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            dataGridView1.ClearSelection();
            lblPoblationGreater.Text = "";
            lblConsMitj.Text = "";
            lblConsCapMax.Text = "";
            lblConsCapLow.Text = "";

            txtActEcon.Clear();
            txtAny.Clear();
            txtCodiComarca.Clear();
            txtComarca.Clear();
            txtConsDomPerCapita.Clear();
            txtDomXarxa.Clear();
            txtPoblacio.Clear();
            txtTotal.Clear();




        }
    }
}
