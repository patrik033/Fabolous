using BussinessLogicLibrary;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
    }
}
