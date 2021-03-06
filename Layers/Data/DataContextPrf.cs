using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextPrf : DataContextBase
    {
        public DataContextPrf(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<PrfBmUser> PrfBmUsers { get; set; }
        
        public DbSet<PrfBmSchema> PrfBmSchemas { get; set; }
        
        public DbSet<PrfBmTable> PrfBmTables { get; set; }
        
        public DbSet<PrfBmProfil> PrfBmProfils { get; set; }
        
        public DbSet<PrfSysLang> PrfSysLangs { get; set; }
        
        public DbSet<PrfBmParam> PrfBmParams { get; set; }
        
        public DbSet<PrfBmProfilTable> PrfBmProfilTables { get; set; }
        
        public DbSet<PrfBmUserProfil> PrfBmUserProfils { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<PrfBmUser>().HasMany<PrfBmUserProfil>(c => c.PrfBmUserProfils).WithRequired(t => t.PrfBmUser).HasForeignKey(u => new {u.PrfBmUserIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmUser>().ToTable("BM_USER","PRF");
            modelBuilder.Entity<PrfBmUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Login).IsRequired();
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Login).HasMaxLength(50);
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Login).HasColumnName("LOGIN");
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Prenom).HasMaxLength(60);
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Prenom).HasColumnName("PRENOM");
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Passwords).HasMaxLength(100);
            modelBuilder.Entity<PrfBmUser>().Property(item => item.Passwords).HasColumnName("PASSWORDS");
            modelBuilder.Entity<PrfBmUser>().Property(item => item.FamDecInf).HasMaxLength(6);
            modelBuilder.Entity<PrfBmUser>().Property(item => item.FamDecInf).HasColumnName("FAM_DEC_INF");
            modelBuilder.Entity<PrfBmUser>().Property(item => item.CdDecInf).HasMaxLength(15);
            modelBuilder.Entity<PrfBmUser>().Property(item => item.CdDecInf).HasColumnName("CD_DEC_INF");
            modelBuilder.Entity<PrfBmSchema>().HasMany<PrfBmTable>(c => c.PrfBmTables).WithRequired(t => t.PrfBmSchema).HasForeignKey(u => new {u.PrfBmSchemaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmSchema>().HasMany<PrfBmProfil>(c => c.PrfBmProfils).WithRequired(t => t.PrfBmSchema).HasForeignKey(u => new {u.PrfBmSchemaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmSchema>().ToTable("BM_SCHEMA","PRF");
            modelBuilder.Entity<PrfBmSchema>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfBmSchema>().Property(item => item.Schema).IsRequired();
            modelBuilder.Entity<PrfBmSchema>().Property(item => item.Schema).HasMaxLength(20);
            modelBuilder.Entity<PrfBmSchema>().Property(item => item.Schema).HasColumnName("SCHEMA");
            modelBuilder.Entity<PrfBmSchema>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<PrfBmSchema>().Property(item => item.Libelle).HasMaxLength(200);
            modelBuilder.Entity<PrfBmSchema>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<PrfBmTable>().HasRequired<PrfBmSchema>(c => c.PrfBmSchema).WithMany(t => t.PrfBmTables).HasForeignKey(u => new { u.PrfBmSchemaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmTable>().HasMany<PrfBmProfilTable>(c => c.PrfBmProfilTables).WithRequired(t => t.PrfBmTable).HasForeignKey(u => new {u.PrfBmTableIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmTable>().ToTable("BM_TABLE","PRF");
            modelBuilder.Entity<PrfBmTable>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfBmTable>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<PrfBmTable>().Property(item => item.Nom).HasMaxLength(30);
            modelBuilder.Entity<PrfBmTable>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<PrfBmTable>().Property(item => item.BmSchemaSchema).IsRequired();
            modelBuilder.Entity<PrfBmTable>().Property(item => item.BmSchemaSchema).HasMaxLength(20);
            modelBuilder.Entity<PrfBmTable>().Property(item => item.BmSchemaSchema).HasColumnName("BM_SCHEMA__SCHEMA");
            modelBuilder.Entity<PrfBmTable>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<PrfBmTable>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<PrfBmTable>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<PrfBmProfil>().HasRequired<PrfBmSchema>(c => c.PrfBmSchema).WithMany(t => t.PrfBmProfils).HasForeignKey(u => new { u.PrfBmSchemaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmProfil>().HasMany<PrfBmProfilTable>(c => c.PrfBmProfilTables).WithRequired(t => t.PrfBmProfil).HasForeignKey(u => new {u.PrfBmProfilIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmProfil>().HasMany<PrfBmUserProfil>(c => c.PrfBmUserProfils).WithRequired(t => t.PrfBmProfil).HasForeignKey(u => new {u.PrfBmProfilIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmProfil>().ToTable("BM_PROFIL","PRF");
            modelBuilder.Entity<PrfBmProfil>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.Profil).IsRequired();
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.Profil).HasMaxLength(20);
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.Profil).HasColumnName("PROFIL");
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.BmSchemaSchema).IsRequired();
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.BmSchemaSchema).HasMaxLength(20);
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.BmSchemaSchema).HasColumnName("BM_SCHEMA__SCHEMA");
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<PrfBmProfil>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<PrfSysLang>().ToTable("SYS_LANG","PRF");
            modelBuilder.Entity<PrfSysLang>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfSysLang>().Property(item => item.CodeApp).IsRequired();
            modelBuilder.Entity<PrfSysLang>().Property(item => item.CodeApp).HasMaxLength(50);
            modelBuilder.Entity<PrfSysLang>().Property(item => item.CodeApp).HasColumnName("CODE_APP");
            modelBuilder.Entity<PrfSysLang>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<PrfSysLang>().Property(item => item.CodePrp).HasMaxLength(1000);
            modelBuilder.Entity<PrfSysLang>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<PrfSysLang>().Property(item => item.ValPrp).HasMaxLength(1000);
            modelBuilder.Entity<PrfSysLang>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<PrfSysLang>().Property(item => item.SortTrad).HasColumnName("SORT_TRAD");
            modelBuilder.Entity<PrfBmParam>().ToTable("BM_PARAM","PRF");
            modelBuilder.Entity<PrfBmParam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfBmParam>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<PrfBmParam>().Property(item => item.Code).HasMaxLength(25);
            modelBuilder.Entity<PrfBmParam>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<PrfBmParam>().Property(item => item.Valeur).HasMaxLength(500);
            modelBuilder.Entity<PrfBmParam>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<PrfBmProfilTable>().HasRequired<PrfBmProfil>(c => c.PrfBmProfil).WithMany(t => t.PrfBmProfilTables).HasForeignKey(u => new { u.PrfBmProfilIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmProfilTable>().HasRequired<PrfBmTable>(c => c.PrfBmTable).WithMany(t => t.PrfBmProfilTables).HasForeignKey(u => new { u.PrfBmTableIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmProfilTable>().ToTable("BM_PROFIL_TABLE","PRF");
            modelBuilder.Entity<PrfBmProfilTable>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.BmProfilProfil).IsRequired();
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.BmProfilProfil).HasMaxLength(20);
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.BmProfilProfil).HasColumnName("BM_PROFIL__PROFIL");
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.BmTableNom).IsRequired();
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.BmTableNom).HasMaxLength(30);
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.BmTableNom).HasColumnName("BM_TABLE__NOM");
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.EcrireValueInt).IsRequired();
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.EcrireValueInt).HasColumnName("ECRIRE");
            modelBuilder.Entity<PrfBmProfilTable>().Ignore(item => item.Ecrire);
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.ImporterValueInt).IsRequired();
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.ImporterValueInt).HasColumnName("IMPORTER");
            modelBuilder.Entity<PrfBmProfilTable>().Ignore(item => item.Importer);
            modelBuilder.Entity<PrfBmProfilTable>().Property(item => item.AfficherValueInt).HasColumnName("AFFICHER");
            modelBuilder.Entity<PrfBmProfilTable>().Ignore(item => item.Afficher);
            modelBuilder.Entity<PrfBmUserProfil>().HasRequired<PrfBmUser>(c => c.PrfBmUser).WithMany(t => t.PrfBmUserProfils).HasForeignKey(u => new { u.PrfBmUserIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmUserProfil>().HasRequired<PrfBmProfil>(c => c.PrfBmProfil).WithMany(t => t.PrfBmUserProfils).HasForeignKey(u => new { u.PrfBmProfilIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<PrfBmUserProfil>().ToTable("BM_USER_PROFIL","PRF");
            modelBuilder.Entity<PrfBmUserProfil>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<PrfBmUserProfil>().Property(item => item.BmUserLogin).IsRequired();
            modelBuilder.Entity<PrfBmUserProfil>().Property(item => item.BmUserLogin).HasMaxLength(50);
            modelBuilder.Entity<PrfBmUserProfil>().Property(item => item.BmUserLogin).HasColumnName("BM_USER__LOGIN");
            modelBuilder.Entity<PrfBmUserProfil>().Property(item => item.BmProfilProfil).IsRequired();
            modelBuilder.Entity<PrfBmUserProfil>().Property(item => item.BmProfilProfil).HasMaxLength(20);
            modelBuilder.Entity<PrfBmUserProfil>().Property(item => item.BmProfilProfil).HasColumnName("BM_PROFIL__PROFIL");
        }
    }
}
