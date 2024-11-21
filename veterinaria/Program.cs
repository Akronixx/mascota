/*
cree una aplicativo de veterinaria
clases con propiedades: 
   Mascota: nombre, edad, especie
   Servicio: descripcion, precio
   Boleta: codigo, mascota, servicio1, servicio2, total

Use arreglos estáticos de las clases
Debe tener un menu con estas opciones:
- crear, eliminar, listar Servicios
- crear, eliminar, listar Mascotas
- crear, listar Boletas

Para crear boletas debe seleccionar la Mascota y el Servicio de 
sus respectivos arreglos

Divida entre sus integrantes, el lider consolida y los integrantes uno hace lo de servicios y el otro el de mascotas
Debe tener una rama por integrante, el lider debe tener por lo menos 2 ramas: main y dev. debe trabajar y consolidar en dev
*/
using Veterinario;
creard d = new creard();
byte opcion;

string regresar;


do
{

    Console.WriteLine("Programa de Desayunos\n");

    Console.WriteLine("******* MENÚ *******");

    Console.WriteLine("* 1. Crear         *");
    Console.WriteLine("* 2. Lista         *");

    Console.WriteLine("* 3. Eliminar      *");

    Console.WriteLine("* 0. Salir         *");

    Console.WriteLine("********************\n");



    Console.Write("Ingrese opcion: ");



    while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
    {

        Console.Write("Error: Ingrese opcion: ");

    }



    switch (opcion)
    {

        case 0: Environment.Exit(0); break;

        case 1: d.crear(); break;

        case 2: break;

        case 3: break;


    }

    Console.WriteLine("Desea regresar al menú? [si]: ");

    regresar = Console.ReadLine();

    Console.Clear();

} while (regresar == "si");