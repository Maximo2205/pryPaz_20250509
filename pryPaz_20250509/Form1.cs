using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPaz_20250509
{
    public partial class Form1 : Form
    {
        public Form1()
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
            string imagen = cmbParcial.Text;

            if(imagen == "Superman")
            {
                
            }

        }
    }
}
