using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArregloDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // LISTAS

            // INT
            IList<int> listaInt = new List<int>();

            listaInt.Add(10);
            listaInt.Add(20);
            listaInt.Add(30);

            Console.WriteLine("Lista Ints");
            Console.WriteLine("Primer valor: " + listaInt[0]);
            Console.WriteLine("Segundo valor: " + listaInt[1]);
            Console.WriteLine("Tercer valor: " + listaInt[2]);

            Console.WriteLine(" ");

            // STRING
            IList<String> listaString = new List<string>();

            listaString.Add("Enero");
            listaString.Add("Febrero");
            listaString.Add("Marzo");
            listaString.Add("Abril");
            listaString.Add("Mayo");
            listaString.Add("Junio");

            // Intraciones

            // De la Lista listaString
            // Recorrer todos sus elementos
            // del Primerer elemento al Último
            // Morrar por pantalla la ubicación y el valor del mismo

            /// for (definimos_variable; condición; incremento)


            Console.WriteLine("Lista Strings");

            for (int i = 0;  i <= listaString.Count(); i++)
            {
                Console.WriteLine("Posición: " + i + " Valor: " + listaString[i]);
            }

            Console.ReadLine();



        }
    }
}
