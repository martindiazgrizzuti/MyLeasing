using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    /// <summary>
    ///     Conexión a la base de datos
    /// </summary>
    public class DataContext : DbContext
    {
        public DbSet<Owner> Owners { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
