using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversiorNumerosRomanos
{
    public partial class MainWindow : Form
    {
        private Convertidor convertidor;
        private int entrada;
        private string salida;

        public MainWindow()
        {
            InitializeComponent();
            convertidor = new Convertidor();
            entrada = 0;

            //Llama los metodos de prueba definidos en la clase convertidor.
            convertidor.TestConvertidor();
        }

        //Llama al metodo de conversión
        private void botonConvertir_Click(object sender, EventArgs e)
        {
            if (!ValidarEntrada())
            {
                MessageBox.Show("El numero ingresado contiene caracteres no validos.");
                return;
            }
            if (entrada >= 4000 || entrada < 0)
            {
                MessageBox.Show("El numero ingresado debe ser mayor a 0 y menor que 4000.");
                return;
            }

            //Asigna la cadena de numeros romanos a la variable de salida y la muestra en el area de texto inferior.
            salida = convertidor.Convertir(entrada);
            textoSalida.Text = salida;


        }

        

        //Retorna verdadero si pudo realizar la conversion, falso en caso contrario, y asigna valor entero a la entrada.
        private bool ValidarEntrada()
        {
            bool valido = Int32.TryParse(textoEntrada.Text, out entrada);
            return valido;
        }
    }
}
