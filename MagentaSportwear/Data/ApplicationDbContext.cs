using MagentaSportwear.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace MagentaSportwear.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Articulo> AspNetArticulos { get; set; }
        public DbSet<Categoria> AspNetCategorias { get; set; }

        public class Articulo
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public int Precio { get; set; }
        }

        public class Categoria
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public List<Articulo> Articulos { get; set; }
        }
    }
}
