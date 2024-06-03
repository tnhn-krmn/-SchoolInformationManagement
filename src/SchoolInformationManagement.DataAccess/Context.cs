using Microsoft.EntityFrameworkCore;
using SchoolInformationManagement.Entities.Concrete;

namespace SchoolInformationManagement.DataAccess;

public class Context : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Database=SchoolInformationManagement;Username=postgres;Password=12345");

    }

    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<SchoolEntryExit> SchoolEntryExits { get; set; }
    public DbSet<Principal> Principals { get; set; }
    public DbSet<Parent> Parents { get; set; }

    public DbSet<Class> Classes { get; set; }
    public DbSet<ClassAssignment> ClassAssignments { get; set; }

    public DbSet<CafeteriaPurchase> CafeteriaPurchases { get; set; }
    public DbSet<CafeteriaProduct> CafeteriaProducts { get; set; }
}