using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controle_Financeiro.Models
{
    public class Context: DbContext
    {
        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }


        public Context(DbContextOptions options) : base(options)
        {
        }

        public class ContextFactory : IDesignTimeDbContextFactory<Context>
        {
            public Context CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<Context>();

                optionsBuilder.UseSqlServer("Password=123;Persist Security Info=True;User ID=se;Initial Catalog=dbfinanceiro;Data Source=DESKTOP-KCDRR2D");
                return new Context(optionsBuilder.Options);
            }

        }
    }
}
