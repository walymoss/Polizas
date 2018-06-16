using GAP.Polizas.Modelo;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GAP.Polizas.AccesoDatos
{
    public class APIContext:DbContext
    {
        public APIContext() : base("GAPPolizasEntities1")
        {
               
        }

        public DbSet<Poliza> polizas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
