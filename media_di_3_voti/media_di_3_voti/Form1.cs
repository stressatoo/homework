using System;
using System.Windows.Forms;

namespace media_di_3_voti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string materia = textBox1.Text;

            label5.Text = "Media dei voti di: " + materia;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            float v1;
            float v2;
            float v3;



            v1 = Convert.ToSingle(txtVoto1.Text);
            v2 = Convert.ToSingle(txtVoto2.Text);
            v3 = Convert.ToSingle(txtVoto3.Text);

            float media; 


            media = (v1 + v2 + v3) / 3;

            txtMedia.Text = Convert.ToString(media);


            byte premio;

            if (media > 8)
            {
                premio = 20;
            }

            else premio = 10;

            txtPremio.Text = Convert.ToString(premio);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtVoto2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVoto3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
