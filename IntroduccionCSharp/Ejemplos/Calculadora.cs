using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntroduccionCSharp.Ejemplos
{
    public class Calculadora
    {
        public int sumar (int n1, int n2)
        {
            return n1 + n2;
        }
        public int restar (int n1, int n2)
        {
            return n1 - n2;
        }
        public int Multiplicar(int n1, int n2) => n1 * n2;
        public int dividir (int n1, int n2) => n1/n2;
    }
}