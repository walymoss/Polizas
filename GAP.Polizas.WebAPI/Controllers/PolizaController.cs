using GAP.Polizas.ContratoLogicaNegocio;
using GAP.Polizas.LogicaNegocio;
using GAP.Polizas.Modelo;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GAP.Polizas.WebAPI.Controllers
{
    [RoutePrefix("api/poliza")]
    public class PolizaController : ApiController
    {
        IPoliza ipoliza;
        public PolizaController(IPoliza poliza)
        {
            this.ipoliza = poliza;
        }
        [Authorize]
        [HttpPost]
        [Route("guardarPoliza")]
        public async Task<HttpResponseMessage> GuardarPoliza(Poliza poliza)
        {
            bool respuesta = false;
            Dictionary<string, string> mensajes = new Dictionary<string, string>();
            try
            {
                respuesta = ipoliza.GuardarPoliza(poliza);
            }
            catch (Exception ex)
            {
                mensajes.Add("Message", ex.InnerException.Message);
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error: " + ex.InnerException);
            }
            if (respuesta)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "OK");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error");
            }
        }
        
        [HttpGet]
        [Route("consultarPolizas")]
        public async Task<HttpResponseMessage> ConsultarPolizas()
        {
            Dictionary<string, string> mensajes = new Dictionary<string, string>();
            var polizas = ipoliza.ConsultarPolizas();
            if (polizas != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, polizas);

            }
            else
            {
                mensajes.Add("Message", "No se encontraron polizas");
                return Request.CreateResponse(HttpStatusCode.OK, polizas);

            }
        }
        [Authorize]
        [HttpDelete]
        [Route("eliminarPoliza")]
        public async Task<HttpResponseMessage> EliminarPoliza(int id)
        {
            bool respuesta = false;
            Dictionary<string, string> mensajes = new Dictionary<string, string>();
            try
            {
                respuesta = ipoliza.EliminarPoliza(id);
            }
            catch (Exception ex)
            {
                mensajes.Add("Message", ex.InnerException.Message);
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error: " + ex.InnerException);
            }
            if (respuesta)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "OK");
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Error");
            }
        }
       
    }
}
