﻿using BussinessLogicLibrary;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessLibrary
{
    public class FabolousDbContext : DbContext
    {
        public DbSet<Car> cars { get; set; } 
        public DbSet<Motorcycle> motorcycles { get; set; }
        public FabolousDbContext(DbContextOptions<FabolousDbContext> options ) : base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(SeedTestData());
            modelBuilder.Entity<Motorcycle>().HasData(SeedTestDataMc());

        }

        public List<Car> SeedTestData()
        {
            var cars = new List<Car>();
            using (StreamReader reader = new StreamReader(@"CarsTestData.json"))
            {
                string json = reader.ReadToEnd();
                cars = JsonConvert.DeserializeObject<List<Car>>(json);
            }
            return cars;
        }
        public List<Motorcycle> SeedTestDataMc()
        {
            var mc = new List<Motorcycle>();
            using (StreamReader reader = new StreamReader(@"McTestData.json"))
            {
                string json = reader.ReadToEnd();
                mc = JsonConvert.DeserializeObject<List<Motorcycle>>(json);
            }
            return mc;
        }
    }
}
