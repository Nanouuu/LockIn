using Microsoft.EntityFrameworkCore;

public class LockInCoachWebAppContext(DbContextOptions<LockInCoachWebAppContext> options) : DbContext(options)
{
    public DbSet<LockInCoachWebApp.Models.Exercise> Exercise { get; set; } = default!;
}
