using Datos;
using Negocio.Interfaces;
using Negocio.Modelos;
using Negocio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QCS.Controllers
{
    public class OrdenProduccionController : Controller
    {
        private TFI_ControlCalidadEntities db = new TFI_ControlCalidadEntities();

        private IRepoOrdenProduccion _repoOP;
        private IRepoModelo _repoModelo;
        private IRepoColor _repoColor;
        private IRepoLinea _repoLinea;

        public OrdenProduccionController()
        {
            if (_repoOP == null)
            {

                _repoOP = new RepoOrdenProduccion();
            }
            if (_repoModelo == null)
            {

                _repoModelo = new RepoModelo();
            }

            if (_repoColor == null)
            {

                _repoColor = new RepoColor();
            }
            if (_repoLinea == null)
            {

                _repoLinea = new RepoLinea();
            }
        }

        // GET: OrdeProduccion
        public ActionResult Index()
        {
            var listaOP = _repoOP.ListarOP();

            return View(listaOP);
        }


        public ActionResult Create()
        {
            var listaModelos = _repoModelo.ListarModelos();
            var listaLineas = _repoLinea.ListarLineas();

            ViewBag.listamodelos = new SelectList(listaModelos, "SKU", "Denominacion");
            ViewBag.listalineas = new SelectList(listaLineas, "Numero_Linea", "Numero_Linea");

            return View();
        }


        // POST: OrdeProduccion/Create
        [HttpPost]
        public ActionResult Create(ModeloOP op)
        {
            if (ModelState.IsValid)
            {
                op.Fecha_I = DateTime.Now; // Establecer la propiedad Fecha_I con la fecha y hora actual
                _repoOP.IniciarOP(op);
                return RedirectToAction("Index");
            }


            return View();
            
        }


        public ActionResult GetColordelModelo(int sku_model)
        {
            var colores = _repoModelo.BuscarModelo(sku_model).Colores
                                          .Select(c => new SelectListItem
                                          {
                                              Value = c.Codigo.ToString(),
                                              Text = c.Descripcion
                                          }).ToList();
            return Json(colores, JsonRequestBehavior.AllowGet);
        }



        //// GET: OrdeProduccion/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: OrdeProduccion/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: OrdeProduccion/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: OrdeProduccion/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }


        //}




    }




}
    
