using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost; Port=3306;Database=dbAPI;Uid=root;Pwd=091217";
            var optionBuilder = new DbContextOptionsBuilder<MyContext> ();
            optionBuilder.UseMySql(connectionString);
            return new MyContext (optionBuilder.Options); 
        }
    }
}