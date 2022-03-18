using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace for4_18_03_22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            byte nredditi;

            float reddito;

            float tassa;

            byte nRedditiF = 0; // numero dei redditi (F)ino a 3.000
            byte nRedditiS = 0; // numero dei redditi che (S)uperano 3.000

            nredditi = Convert.ToByte(txt_nRedditi.Text);

            for (int i = 1; i <= nredditi; i++)
            {
                reddito = Convert.ToSingle(Interaction.InputBox("Inserire valore del reddito numero " + i));

                if (reddito <= 3000)
                {
                    tassa = reddito * 9 / 100;
                    nRedditiF++;
                }
                else
                {
                    tassa = reddito * 15 / 100;
                    nRedditiS++;
                }

                lstReddito.Items.Add(reddito.ToString());
                lstTassa.Items.Add(tassa.ToString());
            }
            txt_nRedditiF.Text = nRedditiF.ToString();
            txt_nRedditiS.Text = nRedditiS.ToString();
        }
    }
}
