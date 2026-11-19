using Academy.Models;
using Microsoft.EntityFrameworkCore;

public class AcademyContext(DbContextOptions<AcademyContext> options) : DbContext(options)
{
    public DbSet<Academy.Models.Direction> Directions { get; set; } = default!;
    public DbSet<Academy.Models.Group> Groups { get; set; } = default!;
    public DbSet<Academy.Models.Student> Students { get; set; } = default!;
    public DbSet<Academy.Models.Teacher> Teachers { get; set; } = default!;
    public DbSet<Academy.Models.Discipline> Disciplines { get; set; } = default!;
    public DbSet<Academy.Models.TeachersDisciplinesRelation> TeachersDisciplinesRelation { get; set; } = default!;
    public DbSet<Academy.Models.DependentDiscciplines> DependentDiscciplines { get; set; } = default!;

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
        modelBuilder.Entity<Discipline>()
            .HasMany(d => d.DependentDiscciplines)
            .WithOne(dd => dd.Discipline)
            .HasForeignKey(dd => dd.discipline);

        //modelBuilder.Entity<DependentDiscciplines>()
        //    .HasOne(dd => dd.Discipline)
        //    .WithMany(d => d.DependentDiscciplines)
    }
}
