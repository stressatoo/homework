using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IVA
{
    public partial class IVA : Form
    {
        public IVA()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            float PrUnit;
            float Quantità;
            
            float Imponibile;
            float IVA;
            
            float ImpFinale;


            PrUnit = Convert.ToSingle(txtPrUnit.Text);
            Quantità = Convert.ToSingle(txtQuantità.Text);  

            Imponibile = (PrUnit * Quantità);

            txtImponibile.Text = Convert.ToString(Imponibile);

            
            IVA = ((Imponibile * 22) / 100);

            txtIVA.Text = Convert.ToString(IVA);


            ImpFinale = (IVA + Imponibile);

            txtImpFinale.Text = Convert.ToString(ImpFinale);

        }
    }
}
