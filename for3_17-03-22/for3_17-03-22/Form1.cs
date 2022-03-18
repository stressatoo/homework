using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace for3_17_03_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            float importi;
            float accumulatore = 0;

            for (int i = 1; i <= 12; i++)
            {
                importi = Convert.ToSingle(Interaction.InputBox("Inserire l'importo per la spesa del mese numero " + i));
                accumulatore += importi;
            }
            txtSpesa.Text = accumulatore.ToString();
        }
    }
}
