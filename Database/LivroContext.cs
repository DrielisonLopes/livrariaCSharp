using Livraria.Models;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Database
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> opt) : base(opt)
        {
        }
        public DbSet<Livro> Livros {get; set;}
        public DbSet<Autor> Autores {get; set;}
        public DbSet<Editora> Editoras {get; set;}
    }
}