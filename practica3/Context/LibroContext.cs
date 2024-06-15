using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using practica3.Models;

namespace practica3.Context
{
    public partial class LibroContext : DbContext
    {

        public LibroContext ()
        {
        }
        public LibroContext(DbContextOptions<LibroContext> options)
            : base(options)
        {
        }
        public DbSet<EDITORIAL> EDITORIAL { get; set; }
        public DbSet<LIBRO> LIBRO { get; set; }
        public DbSet<INVENTARIO> INVENTARIO { get; set; }
        public DbSet<SUCURSAL> SUCURSAL { get; set; }
        

    }
}
