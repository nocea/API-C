using DAL.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {   //Constructor
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   //Para que se autoincremente
            modelBuilder.UseSerialColumns();
        }
        //Entidades(dbSet)
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Acceso> accesos { get; set; }
    }
}
