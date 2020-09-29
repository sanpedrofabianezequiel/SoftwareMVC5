using SoftwareMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareMVC5.DAL
{
    public class PeliculasRepository
    {
        #region Metodos
        public List<Pelicula> ObtenerPeliculas()
        {



            return new List<Pelicula>()
            {

                new Pelicula()
                {
                    Titulo="Pete's Dragon",EstaEnCartelera=true,Genero="Accion"
                },
                new Pelicula()
                {
                    Titulo="Machinc: Resurrection",EstaEnCartelera=false,Genero="Accion"
                },
                new Pelicula()
                {
                    Titulo="DeadPool",EstaEnCartelera=false,Genero="Accion"
                }

            };
        }



        #endregion

    }
}