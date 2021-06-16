using System;

namespace Estructura_de_datos_tipo_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[10];
            char buscar;

            //dato[0] = 'a';

            for (int i=0; i<=9; i++)
            {
                Console.WriteLine("i: " + i);
                Console.Write("Ingrese una letra: ");
                dato[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("-------------------");

            Console.Write("Ingrese caracter a buscar: ");
            buscar = char.Parse(Console.ReadLine());
            {
                if (dato[10] == buscar);
                {
                    Console.Write("dato " + buscar );
                }
            }
        }
    }
}
