using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiendaWebE.Models;

namespace TiendaWebE.Controllers
{
    public class DenemeController : Controller
    {
        // GET: Deneme
        public ActionResult Index()
        {
            TiendaEscritorioEntities DB = new TiendaEscritorioEntities();
            List<Producto> productos = DB.Producto.ToList();
            return View(productos);
        }
    }
}