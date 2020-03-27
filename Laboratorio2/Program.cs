using System;
using System.Collections.Generic;

namespace Laboratorio2
{


    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Espotifai");

            int eleccion = 0;
            Espotifai listaCanciones = new Espotifai();

            while (eleccion != 3)
            {
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("SELECCIONE UNA OPCIÓN");
                Console.WriteLine(Environment.NewLine);
                Console.WriteLine("[1]VER TODAS LAS CANCIONES");
                Console.WriteLine("[2]AGREGAR UNA CANCIÓN");
                Console.WriteLine("[3]SALIR DEL PROGRAMA");
                Console.WriteLine("[4]VER CANCIONES POR CRITERIO");

                eleccion = Convert.ToInt32(Console.ReadLine()); ;

                if (eleccion == 1 || eleccion == 2 || eleccion == 3 || eleccion == 4)
                {
                    switch (eleccion)
                    {
                        case 1:

                            listaCanciones.VerCanciones();
                            break;

                        case 2:

                            Console.WriteLine("Nombre de Canción:");
                            String nombreCancion = Console.ReadLine();
                            Console.WriteLine("Album de Canción:");
                            String albumCancion = Console.ReadLine();
                            Console.WriteLine("Artista de Canción:");
                            String artistaCancion = Console.ReadLine();
                            Console.WriteLine("Genero de Canción:");
                            String generoCancion = Console.ReadLine();

                            Cancion cancion = new Cancion(nombreCancion, albumCancion, artistaCancion, generoCancion);

                            listaCanciones.AgregarCancion(cancion);
                            break;

                        case 3:

                            Console.WriteLine("Saliendo del programa...");
                            break;

                        case 4:
                            Console.WriteLine("Ingrese Criterio de Busqueda:");
                            String criterio = Console.ReadLine();
                            Console.WriteLine("Ingrese Valor Criterio:");
                            String valor = Console.ReadLine();

                            List<Cancion> listaCriterio = listaCanciones.CancionesPorCriterio(criterio, valor);


                            for (int i = 0;i < listaCriterio.Count; i++)
                            {
                                Console.WriteLine(listaCriterio[i].Informacion());
                            }

                            break;
                        default:
                            Console.WriteLine("Default case");
                            break;

                    }

                }
                else
                {
                    Console.WriteLine("Opción no valida. Por favor ingrese opción valida");
                }
            }
            
        }
    }
}
