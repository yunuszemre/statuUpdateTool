using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace statuUpdateTool.Models
{
    public partial class sehirContext : DbContext
    {
        public sehirContext()
        {
        }

        public sehirContext(DbContextOptions<sehirContext> options)
            : base(options)
        {
        }

        public virtual DbSet<HjHizmetBoLgeleri> HjHizmetBoLgeleris { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-72T9QQS\\YUNUS;Database=sehir;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HjHizmetBoLgeleri>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HJ Hizmet Bölgeleri");

                entity.Property(e => e.DağıtımAlanıİçerisindeMi).HasColumnName("Dağıtım_Alanı_İçerisinde_mi");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test");

                entity.Property(e => e.DağıtımStatü).HasMaxLength(100);

                entity.Property(e => e.Mahalle).HasMaxLength(100);

                entity.Property(e => e.İlçe).HasMaxLength(100);

                entity.Property(e => e.Şube).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
