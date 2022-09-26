using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>  //Provê a conexão para o tempo de Designer nesse contexto. Outros contextos podem ser adicionados
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Usado para Criar as Migrations
            var connectionString = "Server=localhost;Port=3306;DataBase=dbCaseApi;Uid=root;Pwd=Mudar@123";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
