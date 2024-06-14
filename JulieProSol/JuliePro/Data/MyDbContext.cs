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

        builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" });
        builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });

        builder.Entity<Objective>().HasData(new Objective() { Id = 1, Name = "Perte massive de poids", LostWeightKg = 8, DistanceKm = 7, AchievedDate = new DateTime(2024,08,30), CustomerId = 1  });
        builder.Entity<Objective>().HasData(new Objective() { Id = 2, Name = "Meilleure cardio", LostWeightKg = 7, DistanceKm = 9, AchievedDate = null, CustomerId = 1 });
        builder.Entity<Objective>().HasData(new Objective() { Id = 3, Name = "Perte de poids rapide", LostWeightKg = 9, DistanceKm = 4, AchievedDate = null, CustomerId = 2 });
        builder.Entity<Objective>().HasData(new Objective() { Id = 4, Name = "Course rapide", LostWeightKg = 2, DistanceKm = 7, AchievedDate = null, CustomerId = 2 });
        builder.Entity<Objective>().HasData(new Objective() { Id = 5, Name = "Perte massive de poids", LostWeightKg = 8, DistanceKm = 7, AchievedDate = new DateTime(2024, 01, 19), CustomerId = 3 });
        builder.Entity<Objective>().HasData(new Objective() { Id = 6, Name = "Course d'endurance", LostWeightKg = 16, DistanceKm = 9.5, AchievedDate = new DateTime(2024, 10, 30), CustomerId = 3 });




        builder.Entity<Customer>().HasData(new Customer() { Id = 1, FirstName = "Georges", LastName = "Washington", Email = "georgewashington@gmail.com", BirthDate = new DateTime(1993,11,18), StartWeight = 280, TrainerId = 1 });
        builder.Entity<Customer>().HasData(new Customer() { Id = 2, FirstName = "Elon", LastName = "Musk", Email = "elonMusk@gmail.com", BirthDate = new DateTime(1990, 09, 29), StartWeight = 240, TrainerId = 1 });
        builder.Entity<Customer>().HasData(new Customer() { Id = 3, FirstName = "Gary", LastName = "Kasparov", Email = "garykasparov@gmail.com", BirthDate = new DateTime(1989, 06, 28), StartWeight = 190, TrainerId = 1 });


    }
    public DbSet<JuliePro.Models.Speciality> Speciality { get; set; } = default!;
    public DbSet<JuliePro.Models.Trainer> Trainer { get; set; } = default!;
    public DbSet<JuliePro.Models.Objective> Objective { get; set; } = default!;
    public DbSet<JuliePro.Models.Customer> Customer { get; set; } = default!;


}
