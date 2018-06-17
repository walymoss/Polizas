using GAP.Polizas.ContratoLogicaNegocio;
using GAP.Polizas.Modelo;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace GAP.Polizas.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "GAP Pólizas";
            var client = new HttpClient();
            var response = client.GetAsync("http://localhost:52855/api/poliza/consultarPolizas").Result;
            var polizas = response.Content.ReadAsAsync<IEnumerable<Poliza>>().Result;
            return View(polizas);
        }

        public ActionResult Edit(int id)
        {
            ViewBag.Title = "GAP Pólizas";
            var client = new HttpClient();
            var response = client.GetAsync("http://localhost:52855/api/poliza/consultarPoliza/"+id.ToString()).Result;
            var poliza = response.Content.ReadAsAsync<Poliza>().Result;
            return View(poliza);
        }

        [HttpPost]
        public ActionResult Edit(Poliza pol)
        {
            var client = new HttpClient();
            var polizaEnviar = JsonConvert.SerializeObject(pol);
            var buffer = System.Text.Encoding.UTF8.GetBytes(polizaEnviar);
            var bytesPoliza = new ByteArrayContent(buffer);

            bytesPoliza.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = client.PostAsync("http://localhost:52855/api/poliza/guardarPoliza", bytesPoliza).Result;
            return RedirectToAction("Index");
        }
    }
}
