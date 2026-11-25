using HahuEvents.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HahuEvents.Data.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // Database tables
    public DbSet<User> Users { get; set; }

    public DbSet<Event> Events { get; set; }

    public DbSet<Participant> Participants { get; set; }

    public DbSet<Registration> Registrations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // User configuration
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(u => u.Id);

            entity.HasIndex(u => u.Username)
                  .IsUnique();

            entity.Property(u => u.Username)
                  .IsRequired()
                  .HasMaxLength(50);

            entity.Property(u => u.PasswordHash)
                  .IsRequired();
        });

        // User -> Event (One-to-Many)
        modelBuilder.Entity<Event>()
            .HasOne(e => e.Organizer)
            .WithMany(u => u.Events)
            .HasForeignKey(e => e.OrganizerId)
            .OnDelete(DeleteBehavior.Restrict);

        // Event -> Registration (One-to-Many)
        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Event)
            .WithMany(e => e.Registrations)
            .HasForeignKey(r => r.EventId)
            .OnDelete(DeleteBehavior.Restrict);

        // Participant -> Registration (One-to-Many)
        modelBuilder.Entity<Registration>()
            .HasOne(r => r.Participant)
            .WithMany(p => p.Registrations)
            .HasForeignKey(r => r.ParticipantId)
            .OnDelete(DeleteBehavior.Restrict);

        // Prevent duplicate registrations
        modelBuilder.Entity<Registration>()
            .HasIndex(r => new { r.EventId, r.ParticipantId })
            .IsUnique();
    }
}