using System;

namespace Laboratorio2
{


    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido a Espotifai");
            Console.WriteLine("Para ver todas las canciones presione 1");
            Console.WriteLine("Para agregar una canción presione 2");
            Console.WriteLine("Para finalizar el programa presione 3");

            int eleccion = Convert.ToInt32(Console.ReadLine()); ;

            if (eleccion == 1 || eleccion == 2 || eleccion == 3){

                Espotifai listaCanciones = new Espotifai();


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

                    default:
                        Console.WriteLine("Default case");
                        break;

                }

            } else {
                while (eleccion != 1 || eleccion != 2 || eleccion != 3)
                {
                    Console.WriteLine("Opción no valida. Por favor ingrese opción valida");
                    eleccion = Convert.ToInt32(Console.ReadLine());
                }
            }
            
        }
    }
}
