using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
 * Aggiungere all'esercizio n.4 la visualizzazione: 
 * - (ACCUMULATORE) il totale degli importi pagati dai clienti
 * - (CONTATORE)    il n° di abbonati
 * - (CONTATORE)    il n° dei non abbonati
 /*/
namespace es5_5esercizi
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
            byte nClienti;

            string targa;
            float durataH;
            char codice;

            double importo;

            double sconto;

            prezzo_ora = Convert.ToSingle(txtPrezzoOra.Text);
            nClienti = Convert.ToByte(txtnClienti.Text);

            for (int i = 1; i <= nClienti; i++)
            {
                targa = Interaction.InputBox("Inserire la targa per il cliente numero " + i);
                durataH = Convert.ToSingle(Interaction.InputBox("Inserire la durata in ore per il cliente numero " + i));
                codice = Convert.ToChar(Interaction.InputBox("Inserire il codice (A = Abbonato, N = Non abbonato)"));

                lstTarghe.Items.Add(targa);

                importo = prezzo_ora * durataH;

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
