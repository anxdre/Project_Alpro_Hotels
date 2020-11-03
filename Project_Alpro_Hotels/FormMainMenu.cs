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
        public String highestData = "0";
        public String lowestData = "0";
        public String averageData = "0";

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void addDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAddData formAddData = new FormAddData();
            formAddData.Owner = this;
            formAddData.Show();
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
        }

    }
}
