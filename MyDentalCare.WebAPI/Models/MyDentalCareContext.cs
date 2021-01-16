using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyDentalCare.WebAPI.Models
{
    public partial class MyDentalCareContext : DbContext
    {
        public MyDentalCareContext()
        {
        }

        public MyDentalCareContext(DbContextOptions<MyDentalCareContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresa> Adresa { get; set; }
        public virtual DbSet<Clanak> Clanak { get; set; }
        public virtual DbSet<Dijagnoza> Dijagnoza { get; set; }
        public virtual DbSet<Drzava> Drzava { get; set; }
        public virtual DbSet<Grad> Grad { get; set; }
        public virtual DbSet<Kategorija> Kategorija { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<KorisnikUloga> KorisnikUloga { get; set; }
        public virtual DbSet<Lijek> Lijek { get; set; }
        public virtual DbSet<MedicinskiKarton> MedicinskiKarton { get; set; }
        public virtual DbSet<Ocjena> Ocjena { get; set; }
        public virtual DbSet<Pacijent> Pacijent { get; set; }
        public virtual DbSet<Pregled> Pregled { get; set; }
        public virtual DbSet<Rezervacija> Rezervacija { get; set; }
        public virtual DbSet<StomatoloskaOrdinacija> StomatoloskaOrdinacija { get; set; }
        public virtual DbSet<Uloga> Uloga { get; set; }
        public virtual DbSet<Usluga> Usluga { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MyDentalCare;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresa>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Adresa)
                    .HasForeignKey(d => d.GradId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Adresa_GradId");
            });

            modelBuilder.Entity<Clanak>(entity =>
            {
                entity.Property(e => e.Naslov).IsRequired();

                entity.Property(e => e.Sadrzaj).IsRequired();

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Clanak)
                    .HasForeignKey(d => d.KategorijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clanak_KategorijaId");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Clanak)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Clanak_KorisnikId");
            });

            modelBuilder.Entity<Dijagnoza>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();

                entity.Property(e => e.PostanskiBroj).IsRequired();

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grad)
                    .HasForeignKey(d => d.DrzavaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Grad_DrzavaId");
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Korisnik>(entity =>
            {
                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();
            });

            modelBuilder.Entity<KorisnikUloga>(entity =>
            {
                entity.Property(e => e.DatumIzmjene).HasColumnType("datetime");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisnikUloga)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikUloga_KorisnikId");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisnikUloga)
                    .HasForeignKey(d => d.UlogaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KorisnikUloga_UlogaId");
            });

            modelBuilder.Entity<Lijek>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<MedicinskiKarton>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.MedicinskiKarton)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MedicinskiKarton_PacijentId");
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.Property(e => e.Ocjena1)
                    .HasColumnName("ocjena")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Clanak)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.ClanakId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjena_ClanakId");

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Ocjena)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ocjena_PacijentId");
            });

            modelBuilder.Entity<Pacijent>(entity =>
            {
                entity.Property(e => e.DatumRegistracije).HasColumnType("datetime");

                entity.Property(e => e.Ime).IsRequired();

                entity.Property(e => e.Prezime).IsRequired();
            });

            modelBuilder.Entity<Pregled>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();

                entity.HasOne(d => d.Dijagnoza)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.DijagnozaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_DijagnozaId");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.KorisnikId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_KorisnikId");

                entity.HasOne(d => d.Lijek)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.LijekId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_LijekId");

                entity.HasOne(d => d.MedicinskiKarton)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.MedicinskiKartonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_MedicinskiKartonId");

                entity.HasOne(d => d.Rezervacija)
                    .WithMany(p => p.Pregled)
                    .HasForeignKey(d => d.RezervacijaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pregled_RezervacijaId");
            });

            modelBuilder.Entity<Rezervacija>(entity =>
            {
                entity.Property(e => e.Razlog).IsRequired();

                entity.HasOne(d => d.Pacijent)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.PacijentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacija_PacijentId");

                entity.HasOne(d => d.Usluga)
                    .WithMany(p => p.Rezervacija)
                    .HasForeignKey(d => d.UslugaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rezervacija_UslugaId");
            });

            modelBuilder.Entity<StomatoloskaOrdinacija>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();

                entity.HasOne(d => d.Adresa)
                    .WithMany(p => p.StomatoloskaOrdinacija)
                    .HasForeignKey(d => d.AdresaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StomatoloskaOrdinacija_AdresaId");
            });

            modelBuilder.Entity<Uloga>(entity =>
            {
                entity.Property(e => e.Naziv).IsRequired();
            });

            modelBuilder.Entity<Usluga>(entity =>
            {
                entity.Property(e => e.Cijena).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Naziv).IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
