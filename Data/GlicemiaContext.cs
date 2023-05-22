using ControleGlicemiaDiario.Models;

using Microsoft.EntityFrameworkCore;
using ControleGlicemiaDiario.ViewModels;

namespace ControleGlicemiaDiario.Data
{
    public class GlicemiaContext : DbContext
    {
        public GlicemiaContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Glicemia> GLICEMIAS { get; set; }

        public DbSet<ControleGlicemiaDiario.ViewModels.GlicemiaVM>? GlicemiaVM { get; set; }
    }
}
