using Academico.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Academico.Data
{
    public class AcademicoContext : DbContext
    {
        public AcademicoContext(DbContextOptions<AcademicoContext> options) : base(options)
        { } 
            public DbSet<Instituicao> Instituicoes { get; set; }
            public DbSet<Departamento> Departamentos { get; set; }
        
    }
}
