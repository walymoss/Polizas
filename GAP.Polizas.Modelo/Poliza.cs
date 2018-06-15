using System;

namespace GAP.Polizas.Modelo
{
    public class Poliza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Enum TipoCubrimiento { get; set; }
        public DateTime InicioVigencia { get; set; }
        public int PeriodoCobertura { get; set; }
        public decimal Precio { get; set; }
        public Enum TipoRiesgo { get; set; }
        public decimal Cobertura { get; set; }


    }

}
