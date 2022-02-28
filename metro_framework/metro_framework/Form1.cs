using MetroSet_UI.Forms;
using System;
using System.Drawing;

namespace metro_framework
{
    public partial class Sandbox : MetroSetForm
    {
        public Sandbox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mtr_chkTheme_CheckedChanged(object sender)
        {
            if (mtr_chkTheme.Checked == true)
            {
                Style = MetroSet_UI.Enums.Style.Dark;
                mtr_chkTheme.ForeColor = Color.White;
            }
            else
            {
                Style = MetroSet_UI.Enums.Style.Light;
                mtr_chkTheme.ForeColor = Color.Black;
            }
        }

        private void mtrSwitch_SwitchedChanged(object sender)
        {
            metroSetProgressBar1.Maximum = 100;
            metroSetProgressBar1.Minimum = 0;

            if (mtrSwitch.Switched == true)
            {
                metroSetProgressBar1.Value = 100;
            }
            else
            {
                metroSetProgressBar1.Value = 0;
            }
        }
    }
}
