using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence
{
    class UniversidadDbContext : DbContext
    {
        public UniversidadDbContext(DbContextOptions<UniversidadDbContext> options) : base(options)
        {
            //Database.Migrate();
        }
        public DbSet<Carrera> Carrera { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrera>()
                .HasKey(c => c.CarreraId);

            modelBuilder.Entity<Estudiante>()
               .HasKey(c => c.EstudianteId);

            modelBuilder.Entity<Materia>()
               .HasKey(c => c.MateriaId);

            modelBuilder.Entity<Profesor>()
               .HasKey(c => c.ProfesorId);

            modelBuilder.Entity<Secciones>()
               .HasKey(c => c.SeccionId);

            modelBuilder.Entity<Carrera>()
            .HasOne(c => c.Estudiante)
            .WithMany(e => e.Carrera)
            .HasForeignKey(c => c.EstudianteForeingKey);
           

            modelBuilder.Entity<Materia>()
                .HasOne(m => m.Profesor)
                .WithMany(p => p.Materia)
                .HasForeignKey(m => m.ProfesorForeingKey);

            modelBuilder.Entity<Secciones>()
                .HasOne(s => s.Materia)
                .WithMany(m => m.Secciones)
                .HasForeignKey(s => s.MateriaForeingKey);

        }
        public DbSet<Estudiante> Estudiante { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Profesor> Profesor { get; set; }
        public DbSet<Secciones> Secciones  { get; set; }
    }
}
