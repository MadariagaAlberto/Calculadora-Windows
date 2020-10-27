using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
        
            //Se definen las 3 variables de tipo entero
            int numero1, numero2, resultado;
            //Ahora se leen los numeros ingresados por pantalla
            numero1 = int.Parse( txtnumero1.Text);
            numero2 = int.Parse( txtnumero2.Text);           
            //Aqui se suman los dos numeros enteros 
            resultado = numero1 + numero2;
            //Aqui se muestra el resultado
            //el metodo TOSTRING() nos permite convertir un numero entero en otra variable 
            txtResultado.Text = resultado.ToString() ;
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
           
            int numero1, numero2, resultado;          
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);        
            resultado = numero1 - numero2;          
            txtResultado.Text = resultado.ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {

            int numero1, numero2, resultado;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);
            resultado = numero1 * numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;
            numero1 = int.Parse(txtnumero1.Text);
            numero2 = int.Parse(txtnumero2.Text);
            resultado = numero1 / numero2;
            txtResultado.Text = resultado.ToString();
        }

        private void groupoperaciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
