using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace affrancatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            float peso;
            double importo;
            
            string ns;
            ns = "NON SPEDIBILE";

            peso = Convert.ToSingle(txtPesoLettera.Text);

            if (peso <= 50)
            {
                if (peso <= 10)
                {
                    importo = 0.15 * peso;
                    txtAffrancatura.Text = Convert.ToString(importo);
                }
                else if (peso > 10)
                {
                    importo = 2.75;
                    txtAffrancatura.Text = Convert.ToString(importo);
                }
            }
            else txtAffrancatura.Text = ns;

        }
    }
}
