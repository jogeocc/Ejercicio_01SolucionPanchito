using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kaktura
{
    public partial class Kaktura : Form
    {
        decimal[] aux = new decimal[3];

        public Kaktura()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            aux[0] = Convert.ToDecimal(textBox1.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            aux[1] = Convert.ToDecimal(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            aux[2] = Convert.ToDecimal(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarea01_MenuGen.MenuGen objdos = new Tarea01_MenuGen.MenuGen();
            this.Hide();
            objdos.h34gn54(aux);
            objdos.Show();
        }

    }
}
