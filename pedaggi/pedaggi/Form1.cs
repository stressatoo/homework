using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

/*
 * Si devono calcolare i pedaggi di una sequenza di auto che passano il casello delal A1 al Km123.
 * L'operatore inserisce targa, città di partenza, città di arrivo e km percorsi.
 * Ogni km ha un costo di 0.2 centesimi. Visualizzare l'importo del pedaggio e la somma
 * dei valori inseriri dall'operatore sino alla fine del suo turno.
 */

namespace pedaggi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            const float euroPerKm = 0.2F;
            
            string fineTurno = "no";

            string targa;
            string cdp; // città di partenza
            string cda; // città di arrivo
            float kmPercorsi;

            float imp;
            float accumulatore = 0;
            
            int i = 1; // per comodità durante l'inputbox

            do
            {
                targa = Interaction.InputBox("Inserire targa numero " + i);
                cdp = Interaction.InputBox("Inserire città di partenza per la targa " + targa);
                cda = Interaction.InputBox("Inserire città di arrivo per la targa " + targa);
                kmPercorsi = Convert.ToSingle(Interaction.InputBox("Inserire km percorsi per la targa " + targa));

                imp = kmPercorsi * euroPerKm;

                lstTarghe.Items.Add(targa);
                lstCDP.Items.Add(cdp);
                lstCDA.Items.Add(cda);
                lstKmPerc.Items.Add(kmPercorsi);

                lstImp.Items.Add(imp);

                accumulatore += imp;
                
                i++;

                fineTurno = Interaction.InputBox("Finire il turno? (Sì / No)");
            } while (fineTurno == "no" || fineTurno == "No" || fineTurno == "NO");

            txtSomma.Text = accumulatore.ToString();
        }
    }
}
