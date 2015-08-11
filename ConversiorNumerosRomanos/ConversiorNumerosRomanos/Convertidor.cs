﻿using System;
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
            return unidades[entrada];
        }

        //prueba para unidad
        public void Test1()
        {
            string salida = Convertir(1);
            Debug.Assert(salida == "I", "1 debe retornar I");
        }

        //pueba para cinco
        public void Test5()
        {
            string salida = Convertir(5);
            Debug.Assert(salida == "V", "5 debe retornar V");
        }

        public void Test16()
        {
            string salida = Convertir(16);
            Debug.Assert(salida == "XVI", "16 debe retornar XVI");
        }
    }
}
