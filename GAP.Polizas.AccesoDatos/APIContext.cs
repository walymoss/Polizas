using GAP.Polizas.Modelo;
using System.Data.Entity;

namespace GAP.Polizas.AccesoDatos
{
    public class APIContext:DbContext
    {
        public APIContext() //: base("PolizasConnection")
        {
               
        }

        public DbSet<Poliza> polizas { get; set; }
    }
}
