using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ServerSide.Core.CW.Models;

public partial class LoggerDbContext : DbContext
{
    public LoggerDbContext()
    {
    }

    public LoggerDbContext(DbContextOptions<LoggerDbContext> options)
        : base(options)
    {
    }








    public virtual DbSet<LogMessageReciver> LogMessageRecivers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost,1401;Database=LoggerDb;User Id=SA;Password=Amin061bvb;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LogMessageReciver>(entity =>
        {
            entity.ToTable("LogMessageReciver");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MessageLogs)
                .HasMaxLength(4000)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
