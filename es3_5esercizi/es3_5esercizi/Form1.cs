using System;
using System.Windows.Forms;

namespace es3_5esercizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            float prezzo_ora;

            float importo;

            prezzo_ora = Convert.ToSingle(txtPrezzoOra.Text);


            for (int i = 1; i <= 24; i++)
            {
                importo = prezzo_ora * i;

                lstOra.Items.Add(i.ToString());
                lstImporto.Items.Add(importo.ToString());
            }
        }
    }
}
