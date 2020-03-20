﻿using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {            
        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
                .HasData(
                    new Value {Id= 1, Name = "Valor 101"},
                    new Value {Id= 2, Name = "Valor 102"},
                    new Value {Id= 3, Name = "Valor 103"}
                );
        }
    }
}
