using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataFirstApproach.Models
{
    public partial class trainingContext : DbContext
    {
        public trainingContext()
        {
        }

        public trainingContext(DbContextOptions<trainingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; } = null!;

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        if (!optionsBuilder.IsConfigured)
    //        {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    //            optionsBuilder.UseSqlServer("Server=ELW5120\\SQLExpress; Database=training; trusted_Connection=True;");
    //        }
    //    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId)
                    .HasName("PK__Employee__16EBFA260B19C6A1");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpId).HasColumnName("EMP_ID");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EMP_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
