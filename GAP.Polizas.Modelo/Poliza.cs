//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GAP.Polizas.Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Poliza
    {
        [Key]
        public int IdPoliza { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Nullable<System.DateTime> InicioVigencia { get; set; }
        public Nullable<int> PeriodoCobertura { get; set; }
        public Nullable<decimal> Precio { get; set; }
        public Nullable<decimal> Cobertura { get; set; }
        public Nullable<int> IdTipoCubrimiento { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdTipoRiesgo { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual TiposCubrimiento TiposCubrimiento { get; set; }
        public virtual TiposRiesgo TiposRiesgo { get; set; }
    }
}
