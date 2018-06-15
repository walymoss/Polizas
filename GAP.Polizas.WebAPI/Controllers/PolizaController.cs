using GAP.Polizas.ContratoLogicaNegocio;
using GAP.Polizas.LogicaNegocio;
using GAP.Polizas.Modelo;
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

        public async Task<HttpResponseMessage> GuardarPoliza(Poliza poliza)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, "");
        }
        public async Task<HttpResponseMessage> ConsultarPolizas()
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, "");
        }
        public async Task<HttpResponseMessage> EliminarPoliza(int id)
        {
            return Request.CreateResponse(HttpStatusCode.BadRequest, "");
        }
       
    }
}
