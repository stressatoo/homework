using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace switch_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEsegui_Click(object sender, EventArgs e)
        {
            string  mese;
            byte    giorni;
            bool    bisestile;

            mese      = cmbMese.Text;
            bisestile = chkBisestile.Checked;

            switch (mese)
            {
                case "Gennaio":
                    giorni = 31;
                    break;

                case "Febbraio":
                    if (bisestile)
                    {
                        giorni = 29;
                    }
                    else giorni = 28;
                    break;

                case "Marzo":
                    giorni = 31;
                    break;

                case "Aprile":
                    giorni = 30;
                    break;

                case "Maggio":
                    giorni = 31;
                    break;

                case "Giugno":
                    giorni = 30;
                    break;

                case "Luglio":
                    giorni = 31;
                    break;

                case "Agosto":
                    giorni = 31;
                    break;

                case "Settembre":
                    giorni = 30;
                    break;

                case "Ottobre":
                    giorni = 31;
                    break;

                case "Novembre":
                    giorni = 30;
                    break;

                case "Dicembre":
                    giorni = 31;
                    break;

                default:
                    giorni = 0;
                    break;
            }

            if (giorni == 0)
            {
                lblOutput.Text = "Hai inserito " + mese.ToString() + " e non è un mese valido.";
            }
            else lblOutput.Text = mese + " ha " + giorni.ToString() + " giorni.";
        }
    }
}

