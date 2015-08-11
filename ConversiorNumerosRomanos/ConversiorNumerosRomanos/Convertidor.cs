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
            unidades = new string[10] { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "XI" };
            decenas = new string[10] { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            centenas = new string[10] { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            millares = new string[4] { "", "M", "MM", "MMM" };

        }

        public string Convertir(int entrada)
        {
            return "I";
        }

        public void test1()
        {
            string salida = Convertir(1);
            Debug.Assert(salida == "I", "1 debe retornar I");
        }

        public void test5()
        {
            string salida = Convertir(5);
            Debug.Assert(salida == "V", "5 debe retornar V");
        }
    }
}
