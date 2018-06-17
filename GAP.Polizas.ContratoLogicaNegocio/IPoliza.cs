using GAP.Polizas.Modelo;
using System.Collections.Generic;

namespace GAP.Polizas.ContratoLogicaNegocio
{
    public interface IPoliza
    {
        bool GuardarPoliza(Poliza poliza);
        List<Poliza> ConsultarPolizas();
        Poliza ConsultarPoliza(int idPoliza);
        bool EliminarPoliza(int id);
        
    }
}
