using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea01_MenuGen
{
    public partial class MenuGen : Form
    {
        Int16 opcion;
        decimal[] vector = new decimal[3];
        decimal[] resp = new decimal[4];

        public MenuGen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            opcion=Convert.ToInt16(textBox1.Text);

            switch (opcion) {
                case 1:
                    //Kaktura
                    //this.hide()
                    //onj.show();
                            Kaktura.Kaktura obj = new Kaktura.Kaktura();
                            this.Hide();
                            obj.Show();

                    break;
                case 2:
                    //Suma
                    //this.hide
                    //metodo
                    //show
                    this.Hide();
                    PSuma.PSuma obj3 = new PSuma.PSuma();
                    obj3.h34gn54(vector);
                    obj3.Show();
                    

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    label8.Text = "Error de Opción.....";
                    break;

            }

        }


        public void h34gn54(decimal[] xyz)
        {
            for (Int16 i = 0; i < 3; i++) {

                vector[i] = xyz[i];

            }
            return;
        }

        public void gt464(decimal suma)
        {
            resp[0] = suma;

            return;
        }


    }
}
