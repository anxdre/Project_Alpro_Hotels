using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Alpro_Hotels
{
    public partial class FormMainMenu : Form
    {
        public List<string> historySaleOfData = new List<string>();
        public List<int> historyPriceSaleOfData = new List<int>();
        public String highestData = "0";
        public String lowestData = "0";
        public String averageData = "0";

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            textBoxAverageData.Enabled = false;
            textBoxHighData.Enabled = false;
            textBoxLowestData.Enabled = false;

            textBoxAverageData.Text = averageData;
            textBoxHighData.Text = highestData;
            textBoxLowestData.Text = lowestData;
        }

        public void ShowData()
        {
            listBoxHistoryData.Items.Add(historySaleOfData.Last());
            textBoxHighData.Text = $"{historyPriceSaleOfData.Max()}";
            textBoxLowestData.Text = $"{historyPriceSaleOfData.Min()}";
            textBoxAverageData.Text = $"{(int)historyPriceSaleOfData.Average()}";
        }

        private void newDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            formAddData.Owner = this;
            formAddData.Show();
        }

        private void clearAllDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            historyPriceSaleOfData.Clear();
            historySaleOfData.Clear();
            listBoxHistoryData.Items.Clear();
            textBoxHighData.Text = "0";
            textBoxLowestData.Text = "0";
            textBoxAverageData.Text = "0";
           
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Project Alpro Hotels " +
                "\n Created with love by" +
                "\n Andre Setiawan A (160420131)" +
                "\n Marcella Diva V (160420124)");
        }
    }
}
