using Microsoft.EntityFrameworkCore;

namespace StudentsNotebook.Models;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kurs>()
            .HasKey(x => x.Id);

        modelBuilder.Entity<NewKurs>()
            .HasKey(x => x.Kursid);
    }
    public DbSet<Kurs> curseslist { get; set; }
    public DbSet<NewKurs> newcurseslist { get; set; }


}
