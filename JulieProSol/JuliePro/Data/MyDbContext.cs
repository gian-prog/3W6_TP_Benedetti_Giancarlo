using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JuliePro.Models;

    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
        builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
        builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
        builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });
    }
    public DbSet<JuliePro.Models.Speciality> Speciality { get; set; } = default!;
    }
