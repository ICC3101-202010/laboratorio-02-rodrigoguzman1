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

            foreach (Cancion elemento in canciones)
            {

                Console.WriteLine(elemento.Informacion());
            }

        }

    }
}
