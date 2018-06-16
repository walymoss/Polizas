using GAP.Polizas.Modelo;
using System.Data.Entity;

namespace GAP.Polizas.AccesoDatos
{
    public class APIContext:DbContext
    {
        public APIContext() : base("GAPPolizasEntities1")
        {
               
        }

        public DbSet<Poliza> polizas { get; set; }
    }
}
