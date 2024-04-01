using Microsoft.EntityFrameworkCore;


namespace Hotel.Classes
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<Person> Persons { get; set; } = null!;
        public DbSet<Status> Statuses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../Hotel.db");
        }
    }
}
