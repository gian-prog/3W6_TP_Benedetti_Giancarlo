﻿using System;
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

        builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });
    }
    public DbSet<JuliePro.Models.Speciality> Speciality { get; set; } = default!;
    public DbSet<JuliePro.Models.Trainer> Trainer { get; set; } = default!;
    }
