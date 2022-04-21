using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace dispari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            int nPari    = 0;
            int nDispari = 0;

            int input;

            do
            {
                input = Convert.ToInt32(Interaction.InputBox("Inserisci numero"));

                if (input % 2 == 0)
                {
                    nPari++;
                }
                else nDispari++;

            } while (nDispari < 1);

            txtNPari.Text = nPari.ToString();
        }
    }
}
