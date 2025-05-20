using Microsoft.EntityFrameworkCore;
using PracticaSemana1.Models;

namespace PracticaSemana1.Data
{
    public class LoginDbContext : DbContext
    {
        public LoginDbContext(DbContextOptions<LoginDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Users { get; set; }
    }
}
