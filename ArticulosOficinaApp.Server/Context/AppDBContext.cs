﻿using Microsoft.EntityFrameworkCore;

using ArticulosOficina.Models;

namespace ArticulosOficinaApp.Server.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Articulos> Articulos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }


        public DbSet<Login> Logins { get; set; }


        public DbSet<Tienda> Tiendas { get; set; }


        public DbSet<Tienda_Articulos> Tienda_Articulos { get; set; }

        public DbSet<Venta> Ventas { get; set; }

    }
}
