using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TP3MPC.Dominio;

namespace TP3MPC.Repositorio.Data
{
     public class TP3MPCContext : DbContext
    {
        public TP3MPCContext (DbContextOptions<TP3MPCContext> options)
            : base(options)
        {
        }

        public DbSet<AlunoModel> AlunoModel { get; set; }
    }
}
