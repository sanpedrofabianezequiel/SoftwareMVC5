using SoftwareMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareMVC5.Services
{
    //Esta clase nos va a devolver la informacion desde
    //una WEB Service-- una BD -- Archivos TXT etc
    public class PeliculasService
    {
        #region Metodos
        public Pelicula ObtenerPelicula()
        {
            //Retornamos en Primera instancia 1 sola pelicula
            return (new Pelicula
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2020, 10, 28)
            });
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2020, 10, 28)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "Capitan America: Civil War",
                Duracion = 14,
                Pais = "USA",
                Publicacion = new DateTime(2016, 04, 28)
            };

            //Creamos una New List, y en las llaves, los elementos del tipo
            //Pelicula
            return new List<Pelicula> { pelicula1, pelicula2 };
        }
        #endregion
    }
}