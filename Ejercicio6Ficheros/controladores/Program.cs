using Ejercicio6Ficheros.servicios;

namespace Ejercicio6Ficheros.controladores
{

    class Program
    {

        public static void Main(string[] args)
        {
            string archivo1 = "C:\\Users\\Carlos\\Desktop\\Programación\\Ejercicio6Ficheros\\Archivo1.txt";
            string archivo2 = "C:\\Users\\Carlos\\Desktop\\Programación\\Ejercicio6Ficheros\\Archivo2.txt";
            string archivo3 = "C:\\Users\\Carlos\\Desktop\\Programación\\Ejercicio6Ficheros\\Archivo3.txt";
            int linea;
            string textoNuevo;
            MenuInterfaz menu = new MenuImplementacion();
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                int opcion = menu.menu();

                switch (opcion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("Archivo 1 Elegido");
                        int opcion2 = menu.menu2();
                        string[] lineas = File.ReadAllLines(archivo1);
                        switch (opcion2)
                        {
                            case 0:
                                cerrarMenu = true;
                                break;
                            case 1:
                                Console.WriteLine("Contenido del archivo");
                                using (var sr = new StreamReader(archivo1))
                                {
                                    Console.WriteLine(sr.ReadToEnd());
                                    
                                }
                                break;
                            case 2:
                                Console.WriteLine("Modificar línea específica");
                                try
                                {
                                    Console.WriteLine("Modificar línea específica");

                                    Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                                    linea = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame lo que deseas escribir en esa línea");
                                    textoNuevo = Console.ReadLine();

                                    if (linea >= 0 && linea <= lineas.Length)
                                    {

                                        lineas[linea - 1] = textoNuevo;

                                        File.WriteAllLines(archivo1, lineas);

                                        Console.WriteLine("La línea del texto elegida ya ha sido modificada");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Fallo en el número de línea elegido");
                                    }
                                    break;

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error tipo IO en la opción 1: " + ex.Message + ex.Data);
                                }
                                break;


                            case 3:

                                Console.WriteLine("Modificar contenido específico");
                                try
                                {



                                    Console.WriteLine("Modificar texto por posición");

                                    Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                                    linea = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame el número de la posición que quieres editar");
                                    int posicion = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame lo que deseas escribir en esa línea");
                                    textoNuevo = Console.ReadLine();

                                    if (linea >= 1 && linea <= lineas.Length)
                                    {
                                        string lineasN = lineas[linea - 1];

                                        if (posicion >= 0 && posicion <= lineas.Length)
                                        {
                                            string textoN = lineasN.Insert(posicion, textoNuevo);

                                            lineas[linea - 1] = textoN;

                                            File.WriteAllLines(archivo1, lineas);

                                            Console.WriteLine("La línea del texto elegida ya ha sido modificada");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fallo en el número de posición elegido");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fallo en el número de línea elegido");
                                    }
                                }

                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error tipo IO en la opción 1: " + ex.Message + ex.Data);
                                }
                                break;

                        }
                        break;

                    case 2:
                        Console.WriteLine("Archivo 2 Elegido");
                        opcion2 = menu.menu2();
                        lineas = File.ReadAllLines(archivo2);
                        switch (opcion2)
                        {
                            case 0:
                                cerrarMenu = true;
                                break;
                            case 1:
                                Console.WriteLine("Contenido del archivo");
                                using (var sr = new StreamReader(archivo2))
                                {
                                    Console.WriteLine(sr.ReadToEnd());

                                }
                                break;
                            case 2:
                                Console.WriteLine("Modificar línea específica");

                                try
                                {
                                    Console.WriteLine("Modificar línea específica");

                                    Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                                    linea = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame lo que deseas escribir en esa línea");
                                    textoNuevo = Console.ReadLine();

                                    if (linea >= 0 && linea <= lineas.Length)
                                    {

                                        lineas[linea - 1] = textoNuevo;

                                        File.WriteAllLines(archivo2, lineas);

                                        Console.WriteLine("La línea del texto elegida ya ha sido modificada");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Fallo en el número de línea elegido");
                                    }
                                    break;

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error tipo IO en la opción 1: " + ex.Message + ex.Data);
                                }
                                break;

                            case 3:
                                Console.WriteLine("Modificar contenido específico");
                                try
                                {



                                    Console.WriteLine("Modificar texto por posición");

                                    Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                                    linea = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame el número de la posición que quieres editar");
                                    int posicion = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame lo que deseas escribir en esa línea");
                                    textoNuevo = Console.ReadLine();

                                    if (linea >= 1 && linea <= lineas.Length)
                                    {
                                        string lineasN = lineas[linea - 1];

                                        if (posicion >= 0 && posicion <= lineas.Length)
                                        {
                                            string textoN = lineasN.Insert(posicion, textoNuevo);

                                            lineas[linea - 1] = textoN;

                                            File.WriteAllLines(archivo2, lineas);

                                            Console.WriteLine("La línea del texto elegida ya ha sido modificada");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fallo en el número de posición elegido");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fallo en el número de línea elegido");
                                    }
                                }

                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error tipo IO en la opción 2: " + ex.Message + ex.Data);
                                }
                                break;

                        }

                        break;
                
            
                    case 3:
                        Console.WriteLine("Archivo 3 Elegido");
                        opcion2 = menu.menu2();
                        lineas = File.ReadAllLines(archivo3);
                        switch (opcion2)
                        {
                            case 0:
                                cerrarMenu = true;
                                break;
                            case 1:
                                Console.WriteLine("Contenido del archivo");
                                using (var sr = new StreamReader(archivo3))
                                {
                                    Console.WriteLine(sr.ReadToEnd());

                                }
                                break;
                            case 2:
                                Console.WriteLine("Modificar línea específica");
                                
                                try
                                {
                                    Console.WriteLine("Modificar línea específica");

                                    Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                                    linea = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame lo que deseas escribir en esa línea");
                                    textoNuevo = Console.ReadLine();

                                    if (linea >= 0 && linea <= lineas.Length)
                                    {

                                        lineas[linea - 1] = textoNuevo;

                                        File.WriteAllLines(archivo3, lineas);

                                        Console.WriteLine("La línea del texto elegida ya ha sido modificada");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Fallo en el número de línea elegido");
                                    }
                                    break;

                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error tipo IO en la opción 1: " + ex.Message + ex.Data);
                                }
                                break;
                                
                            case 3:
                                Console.WriteLine("Modificar contenido específico");
                                try
                                {



                                    Console.WriteLine("Modificar texto por posición");

                                    Console.WriteLine("Dame el número de la línea que quieres editar (entre el (1-10))");
                                    linea = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame el número de la posición que quieres editar");
                                    int posicion = Convert.ToInt32(Console.ReadLine());

                                    Console.WriteLine("Dame lo que deseas escribir en esa línea");
                                    textoNuevo = Console.ReadLine();

                                    if (linea >= 1 && linea <= lineas.Length)
                                    {
                                        string lineasN = lineas[linea - 1];

                                        if (posicion >= 0 && posicion <= lineas.Length)
                                        {
                                            string textoN = lineasN.Insert(posicion, textoNuevo);

                                            lineas[linea - 1] = textoN;

                                            File.WriteAllLines(archivo3, lineas);

                                            Console.WriteLine("La línea del texto elegida ya ha sido modificada");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Fallo en el número de posición elegido");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Fallo en el número de línea elegido");
                                    }
                                }

                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error tipo IO en la opción 2: " + ex.Message + ex.Data);
                                }
                                break;

                        }

                        break;
                    default:
                        Console.WriteLine("Error al elegir la opción");
                        break;
                        

                }


            }
        }


    }
}
