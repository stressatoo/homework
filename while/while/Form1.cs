using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @while
{
    public partial class While_DoWhile : Form
    {
        public While_DoWhile()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            float numero;
            bool checkato;
			int contatore; // ecco lol
            
            numero = Convert.ToSingle(txtNum.Text);
            checkato = chkDoWhile.Checked;

            if (checkato)
            {
                do
                {
                    lstOutput.Items.Add(numero); 	// esegue
                    contatore++;             		// l'output
                } 					// "numero"
                while (contatore <= numero); 		// volte
            }
        }
    }
}

