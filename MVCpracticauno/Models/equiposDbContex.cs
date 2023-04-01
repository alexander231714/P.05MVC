using Microsoft.EntityFrameworkCore;
namespace MVCpracticauno.Models
{
    public class equiposDbContex : DbContext
    {
        public equiposDbContex(DbContextOptions options) : base(options)
        {
        }
        public DbSet<marcas> marcas { get; set; }
    }
}
