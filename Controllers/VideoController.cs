using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLaboratorio.Utilerias;
using System.Data;
using System.Data.SqlClient;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/
        
        public ActionResult Index()
        {
            return View();
        }
        //Muestra la interfaz
        public ActionResult Create()
        {
            return View();
        }
        //Procesa los datos 
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int repro, string url)
        {
            //Guardar el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url",url));
            BaseHelper.ejecutarConsulta("sp_video_insertar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }
        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            //Elimina el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            BaseHelper.ejecutarSentencia("sp_video_borrar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index","Video");
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(int idVideo, string titulo, int repro, string url)
        {
            return View();
        }
        //Podemos agregar cuantos más metodos que cumplan con diferentes acciones

    }
}
