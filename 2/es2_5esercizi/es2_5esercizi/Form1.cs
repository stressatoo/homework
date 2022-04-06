using System;
using System.Windows.Forms;

namespace es2_5esercizi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            string targa;
            float durata;
            char codice;

            double P1;
            double P2;
            double P3;

            double prezzo_ora;

            double sconto;
            double importo;

            P1 = Convert.ToDouble(txtP1.Text);
            P2 = Convert.ToDouble(txtP2.Text);
            P3 = Convert.ToDouble(txtP3.Text);

            targa = txtTarga.Text;
            durata = Convert.ToSingle(txtDurataH.Text);
            codice = Convert.ToChar(txtCodice.Text);

            if (durata < 3)
            {
                prezzo_ora = P1;
            }
            else if (durata > 6)
            {
                prezzo_ora = P3;
            }
            else prezzo_ora = P2;

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
