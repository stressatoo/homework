using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace compagnia_aerea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte kg;
            float qf;
            float totalkg;

            float importotot;

            float x;

            kg = Convert.ToByte(txtKg.Text);
            qf = Convert.ToSingle(txtQf.Text);
            totalkg = Convert.ToSingle(txtTotAlKg.Text);

            if (kg < 10)
            {
                txtImpTot.Text = "BAGAGLIO GRATIS";
            }
            else
            {
                x = (kg - 10) * totalkg;
                importotot = qf + x;
                txtImpTot.Text = Convert.ToString(importotot);
            }
        }
    }
}
