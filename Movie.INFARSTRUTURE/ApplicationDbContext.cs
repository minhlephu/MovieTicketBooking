﻿using Microsoft.EntityFrameworkCore;
using Movie.INFARSTRUTURE.Configurations;
using Movie.INFARSTRUTURE.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movie.INFARSTRUTURE
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Entities.Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Show> Shows { get; set; }

        public DbSet<Movie_type> Movie_type { get; set; }

        public DbSet<Theater> Theaters { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Seat> Seats { get; set; }

        public DbSet<Seat_type> Seat_type { get; set; }

        public DbSet<Booking> Booking { get; set; }

        public DbSet<Fare> Fare { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
            modelBuilder.ApplyConfiguration(new MovieConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new CinemaConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new FareConfiguraiton());
            modelBuilder.ApplyConfiguration(new Movie_typeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new SeatConfiguration());
            modelBuilder.ApplyConfiguration(new Seat_typeConfiguration());
            modelBuilder.ApplyConfiguration(new ShowConfiguration());
            modelBuilder.ApplyConfiguration(new TheaterConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
