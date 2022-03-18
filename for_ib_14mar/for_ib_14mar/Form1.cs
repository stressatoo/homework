using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace for_ib_14mar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVai_Click(object sender, EventArgs e)
        {
            byte nPers;
            string posto;
            byte nBiglietti;
            float importo;
            float sconto;
            float accumulatore = 0;

            nPers = Convert.ToByte(txtNPersone.Text);

            for (int i = 1; i <= nPers; i++)
            {
                posto = Interaction.InputBox("Inserire tipo biglietto (C = Curva, T = Tribuna)");
                nBiglietti = Convert.ToByte(Interaction.InputBox("Inserire numero biglietti"));

                if (posto == "T")
                {
                    importo = 100 * nBiglietti;
                }
                else
                {
                    importo = 15 * nBiglietti;
                }

                if (nBiglietti > 10)
                {
                    sconto = importo * 15 / 100;
                    importo -= sconto;
                }

                accumulatore += importo;

                lstRis.Items.Add(importo.ToString());
                txtIncTot.Text = accumulatore.ToString();
            }
        }
    }
}
