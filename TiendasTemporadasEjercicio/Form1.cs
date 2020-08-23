using System;
using System.Windows.Forms;

namespace TiendasTemporadasEjercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double compra;
            double descuento;
            double valor;
            string temporada;
            compra = double.Parse(txtcompra.Text);
            if (rbnavidad.Checked)
            {
                temporada = "ESCOLAR";
            }
            else if (rbhalloween.Checked)
            {
                temporada = "HALLOWEEN";
            }
            else if (rbnavidad.Checked)
            {
                temporada = "NAVIDAD";

            }
            else
            {
                temporada = "";
            }

            if (temporada == "ESCOLAR")
            {
                if (compra < 100000)
                {
                    descuento = compra * 0;
                    valor = compra + descuento;
                }
                else if (compra >= 100000 && compra <= 300000)
                {
                    descuento = compra * 0.1;
                    valor = compra + descuento;
                }
                else if (compra > 300000)
                {
                    descuento = compra * 0.15;
                    valor = compra + descuento;
                }

            }
            else if (temporada == "HALLOWEEN")
            {
                if (compra > 50 && compra <= 30000)
                {
                    descuento = compra * 0;
                    valor = compra + descuento;
                }
                else if (compra > 30000 && compra <= 200000)
                {
                    descuento = compra * 0.02;
                    valor = compra + descuento;
                }
                else if (compra > 200000)
                {
                    descuento = compra * 0.05;
                    valor = compra + descuento;
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es válido");
                    valor = 0;
                }

            }
            else if (temporada == "NAVIDAD")
            {
                if (compra > 50 && compra <= 300000)
                {
                    descuento = compra * 0;
                    valor = compra + descuento;
                }
                else if (compra > 300000 && compra <= 500000)
                {
                    descuento = compra * 0.05;
                    valor = compra + descuento;
                }
                else if (compra > 500000)
                {
                    descuento = compra * 0.1;
                    valor = compra + descuento;
                }
                else
                {
                    MessageBox.Show("El valor ingresado no es válido");
                    valor = 0;
                }
                lblvalor.Text = Convert.ToString(valor);
                gb2.Visible = true;





            }
            else
            {
                MessageBox.Show("Elija una temporada");
            }

        }


    }
}
