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
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Leer lo que el usuario escribió y guardarlo en variables
                double precioOriginal = Convert.ToDouble(txtPrecioOriginal.Text);
                double montoTotal = Convert.ToDouble(txtMontoTotal.Text);
                string categoria = cmbCategoria.Text;

                // Variable para guardar el descuento 
                double descuento = 0;

                // Evaluar la categoría usando switchcase 
                switch (categoria)
                {
                    case "Electrónica":
                        if (montoTotal > 500)
                        {
                            descuento = 0.10; // 10%
                        }
                        break;

                    case "Ropa":
                        if (montoTotal > 300)
                        {
                            descuento = 0.15; // 15%
                        }
                        break;

                    case "Alimentos":
                        if (montoTotal > 200)
                        {
                            descuento = 0.05; // 5%
                        }
                        break;

                    case "Hogar":
                        if (montoTotal > 400)
                        {
                            descuento = 0.20; // 20%
                        }
                        break;

                    default:
                        // Si no seleccionó nada en el ComboBox
                        MessageBox.Show("Por favor, seleccione una categoría.");
                        return; // Salimos de aquí para que no calcule nada
                }

                // Hacer las operaciones matemáticas básicas
                double cantidadDescontada = precioOriginal * descuento;
                double precioFinal = precioOriginal - cantidadDescontada;

                // Mostrar el precio en el Label
                lblPrecioFinal.Text = "Precio final: $" + precioFinal;

                if (descuento > 0)
                {
                    // Multiplicamos por 100 para que se vea como porcentaje
                    double porcentaje = descuento * 100;
                    lblMensaje.Text = "Se aplicó un descuento del " + porcentaje + "%.";
                }
                else
                {
                    lblMensaje.Text = "No se aplicó ningún descuento.";
                }
            }
            catch
            {
                // Si hay un error 
                MessageBox.Show("Error: Asegúrese de escribir solo números válidos en las cajas de texto.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
