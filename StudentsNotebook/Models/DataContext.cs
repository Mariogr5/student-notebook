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
        modelBuilder.Entity<Course>()
            .HasKey(x => x.Id);
            

        modelBuilder.Entity<NewCourse>()
            .HasKey(x => x.Courseid);

        modelBuilder.Entity<Course>()
            .HasMany(x => x.Notes)
            .WithOne(x => x.Course)
            .HasForeignKey(x => x.CourseId);
    }
    public DbSet<Course> curseslist { get; set; }
    public DbSet<NewCourse> newcurseslist { get; set; }
    public DbSet<Material> materials { get; set; }


}
