using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ToDoBackend.Models;

public partial class ToDoListContext : DbContext
{
    public ToDoListContext()
    {
    }

    public ToDoListContext(DbContextOptions<ToDoListContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<ToDo> ToDos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=ToDoList;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F9D218329");

            entity.ToTable("Employee");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Hours).HasColumnName("hours");
            entity.Property(e => e.Name)
                .HasMaxLength(20)
                .HasColumnName("name");
            entity.Property(e => e.Title)
                .HasMaxLength(40)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ToDo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ToDos__3213E83F7067FCBA");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssignedTo).HasColumnName("assignedTo");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .HasColumnName("description");
            entity.Property(e => e.HoursNeeded).HasColumnName("hoursNeeded");
            entity.Property(e => e.IsComplete).HasColumnName("isComplete");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("name");

            entity.HasOne(d => d.AssignedToNavigation).WithMany(p => p.ToDos)
                .HasForeignKey(d => d.AssignedTo)
                .HasConstraintName("FK__ToDos__assignedT__4E88ABD4");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
