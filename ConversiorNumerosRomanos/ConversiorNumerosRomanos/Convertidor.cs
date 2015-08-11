using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversiorNumerosRomanos
{
    class Convertidor
    {
        //Definicion de los números romanos.
        string[] unidades, decenas, centenas, millares;

        //Constructor, inicializa los arreglos de números romanos.
        public Convertidor()
        {
            unidades = new string[10] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            decenas = new string[10] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            centenas = new string[10] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            millares = new string[4] { "", "M", "MM", "MMM" };

        }

        //Metodo que a partir de la entrada numerica retorna una en cadena el numero romano 
        public string Convertir(int entrada)
        {
            string salida = "";
            if (entrada > 9)
            {
                entrada -= 10;
                salida += "X";
            }
            salida += unidades[entrada];
            return salida;
        }

        public void TestConvertidor(){

            //prueba para 1
            string salida = Convertir(1);
            Debug.Assert(salida == "I", "1 debe retornar I");

            //pueba para 5
            salida = Convertir(5);
            Debug.Assert(salida == "V", "5 debe retornar V");

            //prueba para 16
            salida = Convertir(16);
            Debug.Assert(salida == "XVI", "16 debe retornar XVI");

            //prueba para 43
            salida = Convertir(43);
            Debug.Assert(salida == "XLIII", "43 debe retornar XLIII");
        }
        

    }
}
