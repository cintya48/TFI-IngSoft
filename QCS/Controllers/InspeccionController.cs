using Datos;
using Microsoft.Ajax.Utilities;
using Negocio.Interfaces;
using Negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace QCS.Controllers
{
    public class InspeccionController : Controller
    {

        private IRepoDefecto repoDefecto;
        public InspeccionController()
        {
            if (repoDefecto == null)
            {
                repoDefecto = new RepoDefecto();
            }

        }
        // GET: Inspeccion
        public ActionResult Index()
        {
            var defectos = repoDefecto.GetDefectos();
            ViewData.Model = defectos;
            return View();
        }

        public ActionResult MyView(int currentValue)
        {
           
            ViewBag.CurrentValue = currentValue;
            return View();
        }

    }
}

