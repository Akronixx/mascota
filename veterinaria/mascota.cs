using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinario
{
    public class creard
    {
        string[] lista1 = new string[0];
        int[] lista2 = new int[0];
        string[] lista3 = new string[0];

        int posicion = 0;
        int posicion2 = 0;
        int posicion3 = 0;

        public void crear()
        {
            string RespuestaN;
            Console.Write("Ingresa el nombre de animal : ");
            RespuestaN = Console.ReadLine();
            Array.Resize(ref lista1, lista1.Length + 1);
            lista1[posicion] = RespuestaN;
            posicion = posicion + 1;
            Console.WriteLine("A agregado un nombre ");
            int RespuestaEd;
            Console.Write("Ingresa la edad del animal : ");
            RespuestaEd = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref lista2, lista2.Length + 1);
            lista2[posicion2] = RespuestaEd;
            posicion2 = posicion2 + 1;
            Console.WriteLine("A agregado la edad del animal ");
            string RespuestaEs;
            Console.Write("Ingresa la raza del animal : ");
            RespuestaEs = Console.ReadLine();
            Array.Resize(ref lista3, lista3.Length + 1);
            lista3[posicion3] = RespuestaEs;
            posicion3 = posicion3 + 1;
        }
        public void mostrar()
        {
            for (int i = 0; i < lista1.Length; i++)
            {
                Console.WriteLine($"Datos del animal N°{i+1}");
                Console.WriteLine($"Nombre del animal {lista1[i]}");
                Console.WriteLine($"Edad del animal {lista2[i]}");
                Console.WriteLine($"Raza del animal {lista3[i]}");
            }
            
        }

    }
}