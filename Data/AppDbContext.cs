using Microsoft.EntityFrameworkCore;
using ParcialAntonio2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParcialAntonio2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Carta> Carta { get; set; } 
    }
}
