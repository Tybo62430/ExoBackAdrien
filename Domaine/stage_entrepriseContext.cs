using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExoBackAdrien.Domaine
{
    public partial class stage_entrepriseContext : DbContext
    {
        public stage_entrepriseContext()
        {
        }

        public stage_entrepriseContext(DbContextOptions<stage_entrepriseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Annonce> Annonce { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Convention> Convention { get; set; }
        public virtual DbSet<Enseignant> Enseignant { get; set; }
        public virtual DbSet<Entreprise> Entreprise { get; set; }
        public virtual DbSet<Etudiant> Etudiant { get; set; }
        public virtual DbSet<Visite> Visite { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=2306;user=root;password=root;database=stage_entreprise", x => x.ServerVersion("10.4.8-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Annonce>(entity =>
            {
                entity.ToTable("annonce");

                entity.HasIndex(e => e.EntrepriseId)
                    .HasName("fk_annonce_entreprise1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntrepriseId)
                    .HasColumnName("entreprise_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Remuneration)
                    .HasColumnName("remuneration")
                    .HasColumnType("decimal(10,0)");

                entity.Property(e => e.Sujet)
                    .HasColumnName("sujet")
                    .HasColumnType("longtext")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.HasOne(d => d.Entreprise)
                    .WithMany(p => p.Annonce)
                    .HasForeignKey(d => d.EntrepriseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_annonce_entreprise1");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("contact");

                entity.HasIndex(e => e.AnnonceId)
                    .HasName("fk_contact_annonce1_idx");

                entity.HasIndex(e => e.EntrepriseId)
                    .HasName("fk_contact_entreprise_idx");

                entity.HasIndex(e => e.EtudiantId)
                    .HasName("fk_contact_etudiant1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnnonceId)
                    .HasColumnName("annonce_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntrepriseId)
                    .HasColumnName("entreprise_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EtudiantId)
                    .HasColumnName("etudiant_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Annonce)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.AnnonceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_annonce1");

                entity.HasOne(d => d.Entreprise)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.EntrepriseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_entreprise");

                entity.HasOne(d => d.Etudiant)
                    .WithMany(p => p.Contact)
                    .HasForeignKey(d => d.EtudiantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_contact_etudiant1");
            });

            modelBuilder.Entity<Convention>(entity =>
            {
                entity.ToTable("convention");

                entity.HasIndex(e => e.AnnonceId)
                    .HasName("fk_convention_annonce1_idx");

                entity.HasIndex(e => e.EtudiantId)
                    .HasName("fk_convention_etudiant1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AnnonceId)
                    .HasColumnName("annonce_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EtudiantId)
                    .HasColumnName("etudiant_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Annonce)
                    .WithMany(p => p.Convention)
                    .HasForeignKey(d => d.AnnonceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_convention_annonce1");

                entity.HasOne(d => d.Etudiant)
                    .WithMany(p => p.Convention)
                    .HasForeignKey(d => d.EtudiantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_convention_etudiant1");
            });

            modelBuilder.Entity<Enseignant>(entity =>
            {
                entity.ToTable("enseignant");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Entreprise>(entity =>
            {
                entity.ToTable("entreprise");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Etudiant>(entity =>
            {
                entity.ToTable("etudiant");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");

                entity.Property(e => e.Prenom)
                    .HasColumnName("prenom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_general_ci");
            });

            modelBuilder.Entity<Visite>(entity =>
            {
                entity.ToTable("visite");

                entity.HasIndex(e => e.EnseignantId)
                    .HasName("fk_visite_enseignant1_idx");

                entity.HasIndex(e => e.EntrepriseId)
                    .HasName("fk_visite_entreprise1_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EnseignantId)
                    .HasColumnName("enseignant_id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.EntrepriseId)
                    .HasColumnName("entreprise_id")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.Enseignant)
                    .WithMany(p => p.Visite)
                    .HasForeignKey(d => d.EnseignantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_visite_enseignant1");

                entity.HasOne(d => d.Entreprise)
                    .WithMany(p => p.Visite)
                    .HasForeignKey(d => d.EntrepriseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_visite_entreprise1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
