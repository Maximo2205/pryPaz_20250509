using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pryPaz_20250509.Properties;

namespace pryPaz_20250509
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbParcial.Items.Add("Superman");
            cmbParcial.Items.Add("Batman");
            cmbParcial.Items.Add("WonderWoman");
        }

        private void pctParcial_Click(object sender, EventArgs e)
        {

        }

        private void cmbParcial_SelectedIndexChanged(object sender, EventArgs e)
        {
            int eleccion = cmbParcial.SelectedIndex;

            switch (eleccion)
            {
                case 0:
                    pctParcial.Image = Resources.Superman;    
                    break;  
                case 1:
                    pctParcial.Image = Resources.Batman;
                    break;
                case 2:
                    pctParcial.Image = Resources.WonderWoman;
                    break;

            }
        }
    }
}
