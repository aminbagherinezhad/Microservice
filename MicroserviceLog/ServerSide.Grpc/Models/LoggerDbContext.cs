using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ServerSide.Grpc.Models;

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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
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
