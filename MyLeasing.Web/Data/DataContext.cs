﻿using Microsoft.EntityFrameworkCore;
using MyLeasing.Web.Data.Entities;

namespace MyLeasing.Web.Data
{
    /// <summary>
    ///     Conexión a la base de datos
    /// </summary>
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Lessee> Lessees { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<PropertyImage> PropertyImages { get; set; }

        public DbSet<PropertyType> PropertyTypes { get; set; }

    }
}
