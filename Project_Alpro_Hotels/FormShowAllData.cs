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
    public partial class FormShowAllData : Form
    {
        public FormShowAllData()
        {
            InitializeComponent();
        }

        private void FormShowAllData_Load(object sender, EventArgs e)
        {
            FormMainMenu formMainMenu = (FormMainMenu)this.Owner;
            for(int i = 0; i< formMainMenu.listOfHistorySaleData.Count; i++)
            {
                listBoxShowAllData.Items.Add(formMainMenu.listOfHistorySaleData[i]);
            }
        }
    }
}
