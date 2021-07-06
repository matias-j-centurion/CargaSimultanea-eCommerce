using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CSeC.web.Models;

namespace CSeC.web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    // <Usuario>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categorias {get; set;}
        // public DbSet<Usuario> Usuarios {get; set;}
        public DbSet<Publicaciones> Publicaciones {get; set;}
    }
}
