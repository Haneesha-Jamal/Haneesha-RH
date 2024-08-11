using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DBtoRazor.Models;

public partial class SchooldbContext : DbContext
{
    public SchooldbContext()
    {
    }

    public SchooldbContext(DbContextOptions<SchooldbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-A4LFVAT;Initial Catalog=SCHOOLDB;Integrated Security=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.GradeId).HasName("PK__Grade__FB4362F9D0768AF6");

            entity.ToTable("Grade");

            entity.Property(e => e.GradeId)
                .ValueGeneratedNever()
                .HasColumnName("gradeId");
            entity.Property(e => e.Grade1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("grade");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Students__32C52A79800E9E96");

            entity.Property(e => e.StudentId)
                .ValueGeneratedNever()
                .HasColumnName("StudentID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Grade).WithMany(p => p.Students)
                .HasForeignKey(d => d.GradeId)
                .HasConstraintName("FK__Students__GradeI__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
