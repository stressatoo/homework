using System;
using System.Windows.Forms;

namespace arrays_1
{
    public partial class Form1 : Form
    {
        public string[] vettore;
        public ulong grandezzaVettore = 0;
        public string input = "";
        public int contatore = 0;

        public Form1()
        {
            InitializeComponent();
            vettore = new string[1];
        }

        public void btnImposta_Click() 
        {
            ulong grandezzaVettore = Convert.ToUInt64(txtDimVettore.Text); // Chiede grandezza vettore 
            vettore = new string[grandezzaVettore];
        }

        public void btnInserisciAggiungi_Click() // Textbox input -> Store in array -> Output in ListBox
        {
            btnInserisci.Text = "Add";
            contatore++;
            input = txtContenuto.Text;
            
            vettore[contatore] = input;

            lstArray.Items.Add(vettore[contatore]);

            txtContenuto.Clear();
            txtContenuto.Select();
        }

    }
}
