using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    class Playlist
    {
        public String nombre;
        public List<Cancion> listaCancionesPlaylist = new List<Cancion>();


        public Playlist(String nombre)
        {
            this.nombre = nombre;
        }


        public void Informacion()
        {
            Console.WriteLine("Nombre de la Playlist:" + nombre);
            Console.WriteLine("Canciones:");

            foreach (Cancion cancion in listaCancionesPlaylist)
            {
                Console.WriteLine(cancion.Informacion());
            }

        }

    }
}
