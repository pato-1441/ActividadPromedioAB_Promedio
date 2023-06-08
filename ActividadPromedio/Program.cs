using System;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = -1;
            int valor;

            Promedio promedio = new Promedio();

            while (opcion != 3)
            {
                Console.WriteLine("1 - Agregar valor. \n2 - Calcular promedio.\n3 - Salir.");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Console.WriteLine("Ingrese un valor: ");
                            valor = Convert.ToInt32(Console.ReadLine());
                            promedio.AgregarValor(valor);
                            break;
                    case 2: Console.WriteLine("Promedio: {0}", promedio.CalcularPromedio());
                            break;
                    case 3: Console.WriteLine("Presione una tecla para salir.");
                            Console.ReadKey();
                            break;
                    default:
                            break;
                }
            }
        }
    }
}
