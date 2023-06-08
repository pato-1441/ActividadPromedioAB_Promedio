using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Promedio
    {
        public Promedio(){}
        int contador = 0;
        int acumulador = 0;


        public void AgregarValor(int valor)
        {
            contador++;
            acumulador += valor;
        }

        public double CalcularPromedio()
        {
            if (contador > 0)
            {
                return (double)acumulador / contador;
            } else
            {
                return 0;
            }
        }
    }
}
