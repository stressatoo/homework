using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Costo_per_fotocopie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {

            int nFotocopie;
            float PrezzoRilegatura;

            float ImportoSenzaRilegatura;
            float ImportoConRilegatura;


            nFotocopie = Convert.ToInt32(txtFotocopie.Text);
            PrezzoRilegatura = Convert.ToSingle(txtRilegatura.Text);

            ImportoSenzaRilegatura = (float)0.10 * nFotocopie;  // Prezzo unitario fotocopie = 0.10
            ImportoConRilegatura = ImportoSenzaRilegatura + PrezzoRilegatura;

            txtImp.Text = Convert.ToString(ImportoSenzaRilegatura);
            txtImpConRil.Text = Convert.ToString(ImportoConRilegatura);

        }
    }
}
