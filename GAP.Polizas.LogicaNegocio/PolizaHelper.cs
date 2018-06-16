using GAP.Polizas.AccesoDatos;
using GAP.Polizas.ContratoLogicaNegocio;
using GAP.Polizas.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace GAP.Polizas.LogicaNegocio
{
    public class PolizaHelper : IPoliza
    {
        APIContext contexto = new APIContext();
        public bool GuardarPoliza(Poliza poliza)
        {
            contexto.polizas.Add(poliza);
            return (contexto.SaveChanges() == 1 ? true : false);
        }
        public List<Poliza> ConsultarPolizas()
        {
            List<Poliza> listaPolizas = new List<Poliza>();
            var polizas = contexto.polizas;
            if (polizas != null)
            {
                try
                {
                    foreach (var poliza in polizas)
                    {
                        Poliza pol = new Poliza();
                        pol.Cobertura = poliza.Cobertura;
                        pol.Descripcion = poliza.Descripcion;
                        pol.IdPoliza = poliza.IdPoliza;
                        pol.InicioVigencia = poliza.InicioVigencia;
                        pol.Nombre = poliza.Nombre;
                        pol.Precio = poliza.Precio;
                        pol.PeriodoCobertura = poliza.PeriodoCobertura;
                        pol.IdCliente = poliza.IdCliente;
                        pol.IdTipoCubrimiento = poliza.IdTipoCubrimiento;
                        pol.IdTipoRiesgo = poliza.IdTipoRiesgo;
                        pol.Precio = poliza.Precio;
                        pol.Cliente = poliza.Cliente;
                        pol.TiposCubrimiento = poliza.TiposCubrimiento;
                        pol.TiposRiesgo = poliza.TiposRiesgo;
                        listaPolizas.Add(pol);
                    }
                }
                catch (System.Exception ex)
                {
                    throw ex;
                }
                
            }
            return listaPolizas;
        }
        public bool EliminarPoliza(int id)
        {
            var polizaEliminar = contexto.polizas.Where(
                x => x.IdPoliza == id).FirstOrDefault();
            contexto.polizas.Remove(polizaEliminar);
            return (contexto.SaveChanges() == 1 ? true : false);
        }




    }
}
