﻿using Microsoft.EntityFrameworkCore;
using miamibeleescorts.com.Models;

namespace miamibeleescorts.com.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<escorts> escorts { get; set; }
        public DbSet<inform> inform { get; set; }
        public DbSet<phoneNumber> phoneNumber { get; set; }

    }
}
