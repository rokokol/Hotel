﻿using Microsoft.EntityFrameworkCore;


namespace Hotel.Classes
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../Source/Hotel.db");
        }
    }
}
