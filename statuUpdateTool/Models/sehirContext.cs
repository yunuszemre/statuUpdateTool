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

        public virtual DbSet<BüyükŞehirler> BüyükŞehirlers { get; set; } = null!;
        public virtual DbSet<HbjDagıtımBolgeleriEvetHayirSayili> HbjDagıtımBolgeleriEvetHayirSayilis { get; set; } = null!;
        public virtual DbSet<HjHizmetBoLgeleri> HjHizmetBoLgeleris { get; set; } = null!;
        public virtual DbSet<Ilceler> Ilcelers { get; set; } = null!;
        public virtual DbSet<PostaKodları> PostaKodlarıs { get; set; } = null!;
        public virtual DbSet<PostaKoduIdBilgili> PostaKoduIdBilgilis { get; set; } = null!;
        public virtual DbSet<Postakodu> Postakodus { get; set; } = null!;
        public virtual DbSet<Root> Roots { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public DbSet<CityModel> CityModel { get; set; }

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
            modelBuilder.Entity<BüyükŞehirler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BüyükŞehirler");

                entity.Property(e => e.İl).HasColumnName("İL");
            });
            modelBuilder.Entity<CityModel>(entity =>
            {
                entity.HasKey(x => x.Id);
            });

            modelBuilder.Entity<HbjDagıtımBolgeleriEvetHayirSayili>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("hbj_dagıtım_bolgeleri_evet_hayir_sayili");

                entity.Property(e => e.Evet).HasColumnName("EVET");

                entity.Property(e => e.Hayir).HasColumnName("HAYIR");

                entity.Property(e => e.İlçe)
                    .HasMaxLength(50)
                    .HasColumnName("İLÇE");

                entity.Property(e => e.Şehİr)
                    .HasMaxLength(50)
                    .HasColumnName("ŞEHİR");
            });

            modelBuilder.Entity<HjHizmetBoLgeleri>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HJ Hizmet Bölgeleri");

                entity.Property(e => e.DağıtımAlanıİçerisindeMi).HasColumnName("Dağıtım_Alanı_İçerisinde_mi");
            });

            modelBuilder.Entity<Ilceler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ILCELER");

                entity.Property(e => e.İl)
                    .HasMaxLength(50)
                    .HasColumnName("İL");

                entity.Property(e => e.İlçe)
                    .HasMaxLength(50)
                    .HasColumnName("İLÇE");
            });

            modelBuilder.Entity<PostaKodları>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("posta_kodları");

                entity.Property(e => e.Il).HasColumnName("IL");

                entity.Property(e => e.Ilce).HasColumnName("ILCE");

                entity.Property(e => e.Mahalle).HasColumnName("MAHALLE");

                entity.Property(e => e.Pk).HasColumnName("PK");

                entity.Property(e => e.SemtBucakBelde).HasColumnName("semt_bucak_belde");
            });

            modelBuilder.Entity<PostaKoduIdBilgili>(entity =>
            {
                entity.ToTable("posta_kodu_id_bilgili");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Il)
                    .HasMaxLength(100)
                    .HasColumnName("il");

                entity.Property(e => e.Ilce)
                    .HasMaxLength(100)
                    .HasColumnName("ilce");

                entity.Property(e => e.Mahalle).HasColumnName("mahalle");

                entity.Property(e => e.Pk)
                    .HasMaxLength(19)
                    .HasColumnName("pk");

                entity.Property(e => e.Plaka).HasColumnName("plaka");

                entity.Property(e => e.SemtBucakBelde)
                    .HasMaxLength(100)
                    .HasColumnName("semt_bucak_belde");
            });

            modelBuilder.Entity<Postakodu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Postakodu");

                entity.Property(e => e.il)
                    .HasMaxLength(100)
                    .HasColumnName("il");

                entity.Property(e => e.ilce)
                    .HasMaxLength(200)
                    .HasColumnName("ilce");

                entity.Property(e => e.mahalle)
                    .HasMaxLength(200)
                    .HasColumnName("mahalle");

                entity.Property(e => e.pk)
                    .HasMaxLength(20)
                    .HasColumnName("pk");

                entity.Property(e => e.plaka).HasColumnName("plaka");

                entity.Property(e => e.semt_bucak_belde)
                    .HasMaxLength(300)
                    .HasColumnName("semt_bucak_belde");
            });

            modelBuilder.Entity<Root>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Root");

                entity.Property(e => e.dataupdatedate)
                    .HasMaxLength(100)
                    .HasColumnName("dataupdatedate");

                entity.Property(e => e.description)
                    .HasMaxLength(1000)
                    .HasColumnName("description");

                entity.Property(e => e.pagecreatedate)
                    .HasMaxLength(100)
                    .HasColumnName("pagecreatedate");

                entity.Property(e => e.status)
                    .HasMaxLength(100)
                    .HasColumnName("status");

                entity.Property(e => e.success).HasColumnName("success");
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
