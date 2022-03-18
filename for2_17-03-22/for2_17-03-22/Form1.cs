using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace for2_17_03_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            byte npersone;
            
            string nome;
            float stipendio;
            char genere;

            float accumulatore = 0;
            int cmaschi = 0;
            int cfemmine = 0;

            npersone = Convert.ToByte(txtNPersone.Text);

            for (int i = 1; i <= npersone; i++)
            {
                nome = Interaction.InputBox("Inserire nome della persona numero " + i);
                stipendio = Convert.ToSingle(Interaction.InputBox("Inserire stipendio di " + nome));
                genere = Convert.ToChar(Interaction.InputBox("Inserire genere di " + nome + " (F = Femmina, M = Maschio)"));

                if (genere == 'F')
                {
                    cfemmine++;
                }
                else cmaschi++;

                accumulatore += stipendio;
            }

            txtNFemmine.Text = Convert.ToString(cfemmine);
            txtNMaschi.Text = Convert.ToString(cmaschi);
            txtTotStipendi.Text = Convert.ToString(accumulatore);
        }
    }
}
