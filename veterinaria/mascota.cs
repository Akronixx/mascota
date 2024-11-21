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
        string[] lista4 = new string[0];
        string[] lista5 = new string[0];

        int posicion = 0;

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
            lista2[posicion] = RespuestaEd;
            posicion = posicion + 1;
            Console.WriteLine("A agregado la edad del animal ");
            string RespuestaEs;
            Console.Write("Ingresa el nombre del perro : ");
            RespuestaEs = Console.ReadLine();
            Array.Resize(ref lista3, lista3.Length + 1);
            lista3[posicion] = RespuestaEs;
            posicion = posicion + 1;
            Console.WriteLine("A agregado la especie del animal ");
            string servicio1;
            Console.Write("Ingresa el nombre de animal : ");
            servicio1 = Console.ReadLine();
            Array.Resize(ref lista4, lista4.Length + 1);
            lista4[posicion] = servicio1;
            string servicio2;
            Console.Write("Ingresa el nombre de animal : ");
            servicio2 = Console.ReadLine();
            Array.Resize(ref lista5, lista5.Length + 1);
            lista5[posicion] = servicio2;
        }
    }
}