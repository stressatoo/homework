using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            float voto1 = Convert.ToSingle(textBox1.Text);
            float voto2 = Convert.ToSingle(textBox2.Text);
            float voto3 = Convert.ToSingle(textBox3.Text);
            float somma = Convert.ToSingle(voto1 + voto2 + voto3);
            textBox7.Text = Convert.ToString(somma / 3);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
