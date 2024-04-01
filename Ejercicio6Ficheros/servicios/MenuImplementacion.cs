using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6Ficheros.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
   
        public int menu()
        {

            Console.WriteLine("-----------------");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Archivo1");
            Console.WriteLine("[2] - Archivo2");
            Console.WriteLine("[3] - Archivo3");
            Console.WriteLine("-----------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }

        public int menu2()
        {

            Console.WriteLine("-----------------");
            Console.WriteLine("[0] - Cerrar Menú");
            Console.WriteLine("[1] - Ver contenido");
            Console.WriteLine("[2] - Modificar línea específica.");
            Console.WriteLine("[3] - Inserta texto por posición");
            Console.WriteLine("-----------------");

            int opcion = Convert.ToInt32(Console.ReadLine());

            return opcion;
        }
    }
}

