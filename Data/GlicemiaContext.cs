using ControleGlicemiaDiario.Models;

using Microsoft.EntityFrameworkCore;

namespace ControleGlicemiaDiario.Data
{
    public class GlicemiaContext : DbContext
    {
        public GlicemiaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Glicemia> GLICEMIAS { get; set; }
    }
}
