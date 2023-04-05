using Microsoft.EntityFrameworkCore;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Data
{
    //Herdar de :
    public class SistemaTarefaDBContex : DbContext
    {
        //ctro - Criar um Construtor
        public SistemaTarefaDBContex(DbContextOptions<SistemaTarefaDBContex> options)
            :base(options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
