using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Aplicacao.Models;

namespace Aplicacao.Data
{
    public class AplicacaoContext : DbContext
    {
        public AplicacaoContext (DbContextOptions<AplicacaoContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }



    }
}
