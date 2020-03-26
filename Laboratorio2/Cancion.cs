using System;

namespace Laboratorio2
{
    class Cancion
    {

        String nombre;
        String album;
        String artista;
        String genero;

        public Cancion(string nombre, string album, string artista, string genero)
        {

            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;

        }

        public String Informacion()
        {

            return "genero: {genero}, artista: {artista}, album: {album}, nombre: {nombre}";
        }
    }
}
