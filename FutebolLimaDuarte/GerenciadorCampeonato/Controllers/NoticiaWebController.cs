using GerenciadorCampeonato.Controllers.Abstratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Campeonato.Business.Logics;
using Campeonato.Dominio;
using System.Web.Mvc;
using Kendo.Mvc.UI;
using Kendo.Mvc.Extensions;
using System.Collections;
using System.IO;
using System.Drawing;

namespace GerenciadorCampeonato.Controllers
{
    public class NoticiaWebController : BaseController
    {

        NoticiaBusiness noticiaBusiness = new NoticiaBusiness();

        public ActionResult Consultar()
        {
            if (!string.IsNullOrEmpty(User.Identity.Name))
                return View("~/Views/Noticia/Index.cshtml");
            else
                return View("~/Views/AdminHome/Login.cshtml");              
        }

        public ActionResult Ler([DataSourceRequest] DataSourceRequest request)
        {
            List<Noticia_Web> noticia_Web = new List<Noticia_Web>();

            try
            {
                noticia_Web = noticiaBusiness.ObterNoticia();

                return Json(noticia_Web.ToList().ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(noticia_Web.ToList().ToDataSourceResult(request, ModelState));
            }
        }

        public ActionResult Inserir([DataSourceRequest] DataSourceRequest request, Noticia_Web item)
        {
            try
            {
                noticiaBusiness.InserirNoticia(item);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
        }

        public ActionResult Atualizar([DataSourceRequest] DataSourceRequest request, Noticia_Web item)
        {
            try
            {
                noticiaBusiness.AtualizaNoticia(item);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }

        }

        public ActionResult Apagar([DataSourceRequest] DataSourceRequest request, Noticia_Web item)
        {
            try
            {
                noticiaBusiness.RemoveNoticia(item);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
        }
    }
}