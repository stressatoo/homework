using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
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
            float statura;

            float IMC;

            peso = Convert.ToSingle(txtPeso.Text);
            statura = Convert.ToSingle(txtStatura.Text);

            IMC = peso / (statura * statura);

            txtIMC.Text = Convert.ToString(IMC);

            if (IMC > 25)
            {
                txtXPeso.Text = "SOVRAPPESO";
                txtSupera.Text = Convert.ToString(IMC - 25);
            }
            else if (IMC < 18.5)
            {
                txtXPeso.Text = "SOTTOPESO";
            }
            else txtXPeso.Text = "NORMOPESO";
        }
    }
}

