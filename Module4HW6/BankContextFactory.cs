using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Module4HW6.DataAccess;

namespace Module4HW6
{
    public class BankContextFactory : IDesignTimeDbContextFactory<BankContext>
    {
        public BankContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().AddJsonFile("config.json").Build();
            var dbOptionsBuilder = new DbContextOptionsBuilder<BankContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            dbOptionsBuilder.UseSqlServer(connectionString, i => i.CommandTimeout(60));

            return new BankContext(dbOptionsBuilder.Options);
        }
    }
}
