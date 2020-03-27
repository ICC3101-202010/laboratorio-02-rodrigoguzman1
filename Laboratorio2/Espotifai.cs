using System;
using System.Collections.Generic;

namespace Laboratorio2
{
    class Espotifai
    {


        List<Cancion> canciones = new List<Cancion>();

        public Espotifai()
        {

        }

        public bool AgregarCancion(Cancion cancion)
        {

            bool cancionEnLista = false;

            foreach (Cancion elemento in canciones)
            {

                if (elemento.Informacion() == cancion.Informacion())
                {

                    cancionEnLista = true;
                }
            }

            if (cancionEnLista)
            {
                return false;
            }
            else
            {
                canciones.Add(cancion);
                return true;
            }
        }

        public void VerCanciones()
        {

            if (canciones.Count == 0)
            {
                Console.WriteLine("No hay canciones");
            }
            else
            {

                for (int i = 0; i < canciones.Count; i++)
                {

                    Console.WriteLine(canciones[i].Informacion());
                }
            }

        }

        public List<Cancion> CancionesPorCriterio(String criterio, String valor)
        {
            List<Cancion> cumpleCriterio = new List<Cancion>();

            for (int i = 0; i < canciones.Count; i++)
            {
                switch (criterio) {

                case "nombre":
                    if(valor == canciones[i].nombre)
                    {
                        cumpleCriterio.Add(canciones[i]);
                    } break;

                case "album":
                    if(valor == canciones[i].album)
                    {
                        cumpleCriterio.Add(canciones[i]);
                    } break;
                
                case "artista":
                    if(valor == canciones[i].artista)
                    {
                        cumpleCriterio.Add(canciones[i]);
                    } break;

                case "genero":
                    if(valor == canciones[i].genero)
                    {
                        cumpleCriterio.Add(canciones[i]);
                    } break;

                default:
                    Console.WriteLine("Criterio no valido");
                    return cumpleCriterio;
                }

            }

            if (cumpleCriterio.Count == 0)
            {
                Console.WriteLine("No hay canciones que cumplan el criterio");
                return cumpleCriterio;
            }
            else
            {
                return cumpleCriterio;
            }
        }

    }
}
