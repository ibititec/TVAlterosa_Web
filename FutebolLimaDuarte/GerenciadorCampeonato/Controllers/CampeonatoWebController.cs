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
using GerenciadorCampeonato.Controllers.Abstratos;
using Campeonato.Aplicacao;

namespace GerenciadorCampeonato.Controllers
{
    public class CampeonatoWebController : BaseController
    {

        CampeonatoBusiness campeonatoBusiness = new CampeonatoBusiness();
        private readonly ClassificacaoAplicacao appClassificacao;

        public CampeonatoWebController()
        {
            appClassificacao = ClassificacaoAplicacaoConstrutor.ClassificacaoAplicacaoADO();
        }

        public ActionResult Consultar()
        {
            if (!string.IsNullOrEmpty(User.Identity.Name))
                return View("~/Views/Campeonato/Index.cshtml");
            else
                return View("~/Views/AdminHome/Login.cshtml");
        }

        public ActionResult Ler([DataSourceRequest] DataSourceRequest request)
        {
            List<Campeonato_Web> campeonato_Web = new List<Campeonato_Web>();

            try
            {
                campeonato_Web = campeonatoBusiness.ObterCampeonato();

                return Json(campeonato_Web.ToList().ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(campeonato_Web.ToList().ToDataSourceResult(request, ModelState));
            }
        }

        public ActionResult Inserir([DataSourceRequest] DataSourceRequest request, Campeonato_Web item)
        {
            try
            {
                campeonatoBusiness.InserirCampeonato(item);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
        }

        public ActionResult Atualizar([DataSourceRequest] DataSourceRequest request, Campeonato_Web item)
        {
            try
            {
                campeonatoBusiness.AtualizaCampeonato(item);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }

        }


        public ActionResult Apagar([DataSourceRequest] DataSourceRequest request, Campeonato_Web item)
        {
            try
            {
                campeonatoBusiness.RemoveCampeonato(item);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(new[] { item }.ToDataSourceResult(request, ModelState));
            }
        }

        public ActionResult Classificacao()
        {
            if (!string.IsNullOrEmpty(User.Identity.Name))
                return View("~/Views/Campeonato/Classificacao.cshtml");
            else
                return View("~/Views/AdminHome/Login.cshtml");
        }

        public ActionResult ClassificacaoJson([DataSourceRequest] DataSourceRequest request)
        {
            IEnumerable<Classificacao> classificacao = null;
            try
            {
                List<String> listaTimesCampeonato = campeonatoBusiness.ObterTimesCampeonato();



                classificacao = appClassificacao.ListarClassificacao();
                foreach (Classificacao clas in classificacao)
                {
                    String Chave = listaTimesCampeonato.Where(a => a.StartsWith(clas.IdTime)).First();
                    clas.IdCampeonato = Chave.Split('_')[1];
                }
                DataSourceResult result = classificacao.ToDataSourceResult(request);

                return Json(result);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);

                return Json(new[] { classificacao }.ToDataSourceResult(request, ModelState));
            }
        }

    }
}