using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace for_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnCalcola_Click(object sender, EventArgs e)
        {
            // Input
            byte nDip;
            byte ore_prev;
            
            // Input da Inputbox
            string nome; // I/O
            byte ore_ass;
            char codice;
            
            // Output
            float tasso; // Percentuale assenteismo
            string mess = "DIMISSIONARIO";

            nDip = Convert.ToByte(txtnDip.Text);
            ore_prev = Convert.ToByte(txtOlp.Text);

            for (int i = 1; i <= nDip; i++)
            {
                nome = Interaction.InputBox("Inserire nome del dipendente " + i);
                ore_ass = Convert.ToByte(Interaction.InputBox("Inserire ore di assenza del dipendente " + i));
                codice = Convert.ToChar(Interaction.InputBox("Inserire il codice del dipendente " + i + " (D = Non in servizio, S = In servizio)"));
                
                if(codice == 'S') // Se in servizio
                {
                    lstNome.Items.Add(nome);
                    tasso = (ore_ass * 100) / ore_prev;
                    lstTasso.Items.Add(tasso + "%");
                    lstMess.Items.Add("-");
                }
                else
                {
                    lstNome.Items.Add(nome);
                    lstTasso.Items.Add("-");
                    lstMess.Items.Add(mess);
                }
            }
        }
    }
}
