using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_sardegna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            float costo_fisso;
            short cilindrata;
            string regione;
            float totale;
            byte costocil;

            costo_fisso = Convert.ToSingle(txtCostoFisso.Text);
            cilindrata = Convert.ToInt16(txtCilindrata.Text);
            regione = txtRegione.Text;

            if (cilindrata <= 1000)
            {
                costocil = 50;
            }
            else costocil = 150;

            totale = costo_fisso + costocil;

            float sconto;

            if (regione == "Sardegna" || regione == "sardegna" || regione == "SARDEGNA")
            {
                sconto = (totale * 15) / 100;
                txtTotale.Text = Convert.ToString(totale - sconto);
            }
            else txtTotale.Text = Convert.ToString(totale);
        }
    }
}
