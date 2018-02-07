using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSuma
{
    public partial class PSuma : Form
    {
        decimal[] aux2 = new decimal[3];

        public PSuma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            suma += aux2[0] + aux2[0] + aux2[0];
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tarea01_MenuGen.MenuGen obj5 = new Tarea01_MenuGen.MenuGen();

            this.Hide();
            obj5.Show();


        }

        public void h34gn54(decimal[] xyz)
        {
            for (Int16 i = 0; i < 3; i++)
            {

                aux2[i] = xyz[i];

            }
            return;
        }
    }
}
