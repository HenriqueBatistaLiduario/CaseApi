using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>  //Provê a conexão para o tempo de Designer nesse contexto. Outros contextos podem ser adicionados
    {
        public MyContext CreateDbContext(string[] args)
        {
            //String de conexão
            var connectionString = "Server=localhost;Port=3306;Database=dbapi;Uid=root;Pwd=Mudar@123";
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30)),
                mySqlOptions => mySqlOptions.CharSetBehavior(CharSetBehavior.NeverAppend)
            );

            return new MyContext(optionsBuilder.Options);
        }
    }
}
