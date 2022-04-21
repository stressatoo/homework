using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
 * Programma che legge una serie di numeri interi positivi
 * arrestandosi quando la somma dei numeri immessi supera
 * un valore letto come primo numero della sequenza
 */

namespace esercizio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            int input;
            int numeroDaSup; // numero da superare
            int accumulatore = 0;
            
            numeroDaSup = Convert.ToInt32(txtNDaSuperare.Text);

            do
            {
                input = Convert.ToInt32(Interaction.InputBox("Inserisci numero intero positivo"));
                accumulatore += input;
                txtSommaNumeri.Text = accumulatore.ToString();

            } while (accumulatore < numeroDaSup);
        }
    }
}
