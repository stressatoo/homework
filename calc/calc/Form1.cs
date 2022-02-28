using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Addizione
        private void button2_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBox1.Text);
            int numero2 = Convert.ToInt32(textBox2.Text);



            textBox3.Text = Convert.ToString(numero1 + numero2);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }
        // Sottrazione
        private void button3_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBox1.Text);
            int numero2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = Convert.ToString(numero1 - numero2);
        }

        // Moltiplicazione
        private void button4_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBox1.Text);
            int numero2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = Convert.ToString(numero1 * numero2);
        }

        // Divisione
        private void button5_Click(object sender, EventArgs e)
        {
            int numero1 = Convert.ToInt32(textBox1.Text);
            int numero2 = Convert.ToInt32(textBox2.Text);

            textBox3.Text = Convert.ToString(numero1 / numero2);
        }

    }
}
