using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APINETCORE.Modelo;

namespace APINETCORE.Data
{
    public class APINETCOREContext : DbContext
    {
        public APINETCOREContext (DbContextOptions<APINETCOREContext> options)
            : base(options)
        {
        }

        public DbSet<APINETCORE.Modelo.Producto>? Producto { get; set; }
    }
}
