using Microsoft.EntityFrameworkCore;
using LockInCoachWebApp.Models;

public class LockInCoachWebAppContext(DbContextOptions<LockInCoachWebAppContext> options) : DbContext(options)
{
    public DbSet<Athlete> Athletes { get; set; }

    public DbSet<Exercise> Exercises { get; set; } = default!;

}
