﻿using Microsoft.EntityFrameworkCore;
using SistemaVendasWeb.Models;

namespace SistemaVendasWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AuditoriaModel> Auditorias { get; set; }
    }
}
