using Microsoft.EntityFrameworkCore;
using WebAPI.Api.Models;

namespace WebAPI.Api.Data
{
    public class UsuariosDbContext : DbContext
    {
        
        public UsuariosDbContext(DbContextOptions<UsuariosDbContext> options) : base(options)
        {
        }
        public DbSet<Usuarios> Usuarios { get; set; } // Tabela para estudos de crud
    }
}
