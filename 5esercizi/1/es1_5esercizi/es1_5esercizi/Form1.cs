using System;
using System.Windows.Forms;

namespace es1_5esercizi
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
            string targa;
            float durata;
            char codice;
            
            double sconto;
            double importo;

            prezzo_ora = Convert.ToSingle(txtPrezzoOra.Text);
            targa = txtTarga.Text;
            durata = Convert.ToSingle(txtDurataH.Text);
            codice = Convert.ToChar(txtCodice.Text);

            importo = prezzo_ora * durata;

            if (codice == 'A')
            {
                sconto = (importo * 12.5) / 100;
                importo -= sconto;
            }

            txtImporto.Text = importo.ToString();

        }
    }
}
