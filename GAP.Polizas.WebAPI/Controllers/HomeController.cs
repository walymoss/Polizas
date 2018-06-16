using GAP.Polizas.ContratoLogicaNegocio;
using GAP.Polizas.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GAP.Polizas.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var client = new HttpClient();
            var response = client.GetAsync("http://localhost:52855/api/poliza/consultarPolizas").Result;
            var polizas = response.Content.ReadAsAsync<IEnumerable<Poliza>>().Result;
            return View(polizas);
        }
    }
}
