using System;

namespace Laboratorio2
{
    class Cancion
    {

        public String nombre;
        public String album;
        public String artista;
        public String genero;

        public Cancion(string nombre, string album, string artista, string genero)
        {

            this.nombre = nombre;
            this.album = album;
            this.artista = artista;
            this.genero = genero;

        }

        public String Informacion()
        {

            return "genero: " + genero + ", artista: " + artista + ", album: " + album + ", nombre: " + nombre;
        }
    }
}
