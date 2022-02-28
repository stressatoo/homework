using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preventivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float cmd;
            float crc;
            int ore;
            int IVA;
            float prezzo;
            float prezzotot;
            float valoreIVA;

            cmd = Convert.ToSingle(txtCmd.Text);
            crc = Convert.ToSingle(txtCrc.Text);
            ore = Convert.ToInt32(txtOre.Text);
            IVA = Convert.ToInt32(txtIVA.Text);

            prezzo = (cmd * ore) + crc;
            valoreIVA = (prezzo * IVA) / 100;

            prezzotot = prezzo + valoreIVA;

            txtPrezzoTot.Text = Convert.ToString(prezzotot);

        }
    }
}
