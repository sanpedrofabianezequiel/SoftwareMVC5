using SoftwareMVC5.DAL;
using SoftwareMVC5.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwareMVC5.Controllers
{
    public class HomeController : Controller
    {

        //Creamos una instancia de PeliculaRepository
        private PeliculasRepository _peliculasRepository;

        //lo iniciamos en el constructor
        //la consumimos en el ACTION Contact
        public HomeController()
        {
            this._peliculasRepository = new PeliculasRepository();
        }



        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            //Creamos una Instancia de nuestro ServicePelicula
            var peliculaService = new PeliculasService();
            var model = peliculaService.ObtenerPelicula();//Retorna un tipo Pelicula
            var models = peliculaService.ObtenerPeliculas();
            return View(models);
        }



        // GET URL=>Home/Contact
        //Recorradar que el QUERY == Nombre Variable
        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page." ;
            ViewData["ezequielMensaje"] = "Esto es un mensaje ViewData";
            //Usamos los metodos de la instancia de PeliculasRepository
            var model = _peliculasRepository.ObtenerPeliculas();

            return View(model);
        }
        //[HttpPost]
        //public ActionResult Contact(int edadR)
        //{
        //    //En el caso que usemos un FORM HTML CLASICO
        //    //Esperamos de la propiedad NAME del formulario COINCIDA
        //    //con el parametro de este ACTION
        //    ViewBag.Message = "Your Contac Page :" + edadR;
        //    return View();
        //}
        

        public ActionResult MiAction()
        {
            return View();
        }


        #region SINTAXIS

        //---------------------------------HTTP
        //[HttpGet]
        //public ActionResult Contact(string nombreR, int edadR)
        //{
        //    ViewBag.Message = "Your contact page." + nombreR + edadR.ToString();

        //    return View();
        //}


        //---------------------------------FileResult
        //public ActionResult Index()
        //{
        //    var ruta = Server.MapPath("dowland.pdf");
        //    return File(ruta, "application/pdf", "ezequiel.pdf");
        //}

        //public FileResult Index()
        //{
        //    //Hace la referencia o URL del archivo que esta en nuestro servidor
        //    //Mapeamos el archivo con Server.MapPath
        //    var ruta = Server.MapPath("dowland.pdf");
        //    //Retornamos un FILE(ruta,tipo aplicacion,nombre a eleccion)
        //    return File(ruta, "application/pdf", "ezequiel.pdf");

        //}





        //-------------------------------------------HTTPStatusCodeResult

        //public HttpStatusCodeResult Index()
        //{
        //    //(codigoINT,string Mensaje)
        //    //  return new HttpStatusCodeResult(404,"Error 404 No Found S.P");
        //    return new HttpStatusCodeResult(301, "Error 301 S.P");
        //}


        ////------------------------------------------JSON

        //public JsonResult /*ActionResult*/ Index()//Podriamos retornar un JSONRESULT
        //{
        //    //Instanciamos la clase Persona
        //    var persona1 = new Persona() { Nombre = "Ezequiel", Edad = 27 };
        //    var persona2 = new Persona() { Nombre = "Ezequiel", Edad = 15 };

        //    //JsonRequestBehavior.AllowGet =>Nos permite verlo en el navagedor
        //    //ya que por convencion no se permite
        //    //return Json(persona1,JsonRequestBehavior.AllowGet);

        //    return Json(new List<Persona>(){ persona1,persona2},JsonRequestBehavior.AllowGet);

        //}

        //--------------------------------------RedirectToAction


        //public ActionResult Index()
        //{
        //    //(name:en el routeConfig)
        //    return RedirectToRoute("chury");
        //}

        //public RedirectToRouteResult Index()
        //{
        //    //(accion,controlador)
        //    return RedirectToAction("About", "Home");
        //}


        //public RedirectResult Index()
        //{
        //    return Redirect("https://google.com");
        //}

        //------------------------------------------
        //public ActionResult Index()
        //{          
        //    return View();
        //}
        //------------------------------------------
        //public ContentResult Index()
        //{
        //    return Content("Ezequiel San Pedro"/*,"application/json"*/);
        //}
        //------------------------------------------
        //public ContentResult Index()
        //{
        //    return  Content("<b>Ezequiel</b>");
        //}
        #endregion
    }
}