using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            float P1;
            float P2;
            float P3;


            byte nClienti;

            string targa;
            float durataH;
            char codice;

            double importo;

            double sconto;
            
            P1 = Convert.ToSingle(txtP1.Text);
            P2 = Convert.ToSingle(txtP2.Text);
            P3 = Convert.ToSingle(txtP3.Text);

            nClienti = Convert.ToByte(txtnClienti.Text);

            for (int i = 1; i <= nClienti; i++)
            {
                targa = Interaction.InputBox("Inserire la targa per il cliente numero " + i);
                durataH = Convert.ToSingle(Interaction.InputBox("Inserire la durata in ore per il cliente numero " + i));
                codice = Convert.ToChar(Interaction.InputBox("Inserire il codice (A = Abbonato, N = Non abbonato)"));

                lstTarghe.Items.Add(targa);

                if (durataH < 3)
                {
                    importo = P1 * durataH;
                }

                if (codice == 'A')
                {
                    sconto = (importo * 12.5) / 100;
                    importo -= sconto;
                }

                lstImporti.Items.Add(importo.ToString());
            }
        }
    }
}
