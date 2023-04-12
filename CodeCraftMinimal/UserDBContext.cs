using Microsoft.EntityFrameworkCore;
using CodeCraftMinimal.Model;

namespace CodeCraftMinimal
{
    class UserDBContext: DbContext
    {
        //TODO: 2 criar context
        //representa a tabela Users no banco de dados 
        public DbSet<User> Users => Set<User>();


        // Passando as opções de configuração para a classe base DbContext.
        // Isso permite que o DbContext seja configurado corretamente com base nas opções fornecidas.
        public UserDBContext(DbContextOptions<UserDBContext> options)
            : base(options)
        {

        }

        // Propriedade Id é a chave primária da tabela.
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
            => modelBuilder.Entity<User>(u => u.HasKey(x => x.Id)); 


    }
}
