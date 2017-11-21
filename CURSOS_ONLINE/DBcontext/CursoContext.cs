using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CURSOS_ONLINE.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CURSOS_ONLINE.DBcontext
{
    public class CursoContext : DbContext
    {
        public DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}