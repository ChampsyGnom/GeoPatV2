using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextInf : DataContextBase
    {
        public DataContextInf(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<InfLiaison> InfLiaisons { get; set; }
        
        public DbSet<InfCdLiaison> InfCdLiaisons { get; set; }
        
        public DbSet<InfChaussee> InfChaussees { get; set; }
        
        public DbSet<InfPtSing> InfPtSings { get; set; }
        
        public DbSet<InfCdPtSing> InfCdPtSings { get; set; }
        
        public DbSet<InfCls> InfClss { get; set; }
        
        public DbSet<InfCdDoc> InfCdDocs { get; set; }
        
        public DbSet<InfDoc> InfDocs { get; set; }
        
        public DbSet<InfCdDec> InfCdDecs { get; set; }
        
        public DbSet<InfFamDec> InfFamDecs { get; set; }
        
        public DbSet<InfTrDec> InfTrDecs { get; set; }
        
        public DbSet<InfTpc> InfTpcs { get; set; }
        
        public DbSet<InfCdTpc> InfCdTpcs { get; set; }
        
        public DbSet<InfDictionnaire> InfDictionnaires { get; set; }
        
        public DbSet<InfRepere> InfReperes { get; set; }
        
        public DbSet<InfPrevSge> InfPrevSges { get; set; }
        
        public DbSet<InfPk> InfPks { get; set; }
        
        public DbSet<InfPrOld> InfPrOlds { get; set; }
        
        public DbSet<InfSysUser> InfSysUsers { get; set; }
        
        public DbSet<InfSensible> InfSensibles { get; set; }
        
        public DbSet<InfCdSensible> InfCdSensibles { get; set; }
        
        public DbSet<InfClim> InfClims { get; set; }
        
        public DbSet<InfCdClim> InfCdClims { get; set; }
        
        public DbSet<InfAmenagement> InfAmenagements { get; set; }
        
        public DbSet<InfCdAmenag> InfCdAmenags { get; set; }
        
        public DbSet<InfAccident> InfAccidents { get; set; }
        
        public DbSet<InfDscOa> InfDscOas { get; set; }
        
        public DbSet<InfCorrespondance> InfCorrespondances { get; set; }
        
        public DbSet<InfCdPosit> InfCdPosits { get; set; }
        
        public DbSet<InfSecurite> InfSecurites { get; set; }
        
        public DbSet<InfEclairage> InfEclairages { get; set; }
        
        public DbSet<InfCdSecur> InfCdSecurs { get; set; }
        
        public DbSet<InfCdEclair> InfCdEclairs { get; set; }
        
        public DbSet<InfOccupation> InfOccupations { get; set; }
        
        public DbSet<InfCdOccup> InfCdOccups { get; set; }
        
        public DbSet<InfCdOccupant> InfCdOccupants { get; set; }
        
        public DbSet<InfTalus> InfTaluss { get; set; }
        
        public DbSet<InfCdTalus> InfCdTaluss { get; set; }
        
        public DbSet<InfWgs> InfWgss { get; set; }
        
        public DbSet<InfCdVoie> InfCdVoies { get; set; }
        
        public DbSet<InfPaveVoie> InfPaveVoies { get; set; }
        
        public DbSet<InfClVoie> InfClVoies { get; set; }
        
        public DbSet<InfTrafic> InfTrafics { get; set; }
        
        public DbSet<InfSectionTrafic> InfSectionTrafics { get; set; }
        
        public DbSet<InfCdClassTraf> InfCdClassTrafs { get; set; }
        
        public DbSet<InfRepartitionTrafic> InfRepartitionTrafics { get; set; }
        
        public DbSet<InfGare> InfGares { get; set; }
        
        public DbSet<InfCdGare> InfCdGares { get; set; }
        
        public DbSet<InfAire> InfAires { get; set; }
        
        public DbSet<InfCdAire> InfCdAires { get; set; }
        
        public DbSet<InfCdPrestataire> InfCdPrestataires { get; set; }
        
        public DbSet<InfPrestataire> InfPrestataires { get; set; }
        
        public DbSet<InfCdService> InfCdServices { get; set; }
        
        public DbSet<InfCdBif> InfCdBifs { get; set; }
        
        public DbSet<InfBifurcation> InfBifurcations { get; set; }
        
        public DbSet<InfBretelle> InfBretelles { get; set; }
        
        public DbSet<InfCdPlace> InfCdPlaces { get; set; }
        
        public DbSet<InfCdEvt> InfCdEvts { get; set; }
        
        public DbSet<InfEvt> InfEvts { get; set; }
        
        public DbSet<InfContact> InfContacts { get; set; }
        
        public DbSet<InfClsDoc> InfClsDocs { get; set; }
        
        public DbSet<InfAirePrestataire> InfAirePrestataires { get; set; }
        
        public DbSet<InfAireService> InfAireServices { get; set; }
        
        public DbSet<InfAirePlace> InfAirePlaces { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<InfLiaison>().HasRequired<InfCdLiaison>(c => c.InfCdLiaison).WithMany(t => t.InfLiaisons).HasForeignKey(u => new { u.InfCdLiaisonIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfLiaison>().HasMany<InfChaussee>(c => c.InfChaussees).WithRequired(t => t.InfLiaison).HasForeignKey(u => new {u.InfLiaisonIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfLiaison>().ToTable("LIAISON_INF","INF");
            modelBuilder.Entity<InfLiaison>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfLiaison>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<InfLiaison>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<InfLiaison>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<InfLiaison>().Property(item => item.CdLiaisonInfCdLiaison).IsRequired();
            modelBuilder.Entity<InfLiaison>().Property(item => item.CdLiaisonInfCdLiaison).HasMaxLength(5);
            modelBuilder.Entity<InfLiaison>().Property(item => item.CdLiaisonInfCdLiaison).HasColumnName("CD_LIAISON_INF__CD_LIAISON");
            modelBuilder.Entity<InfLiaison>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfLiaison>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfCdLiaison>().HasMany<InfLiaison>(c => c.InfLiaisons).WithRequired(t => t.InfCdLiaison).HasForeignKey(u => new {u.InfCdLiaisonIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdLiaison>().ToTable("CD_LIAISON_INF","INF");
            modelBuilder.Entity<InfCdLiaison>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdLiaison>().Property(item => item.CdLiaison).IsRequired();
            modelBuilder.Entity<InfCdLiaison>().Property(item => item.CdLiaison).HasMaxLength(5);
            modelBuilder.Entity<InfCdLiaison>().Property(item => item.CdLiaison).HasColumnName("CD_LIAISON");
            modelBuilder.Entity<InfCdLiaison>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<InfCdLiaison>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfCdLiaison>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfChaussee>().HasRequired<InfLiaison>(c => c.InfLiaison).WithMany(t => t.InfChaussees).HasForeignKey(u => new { u.InfLiaisonIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfPtSing>(c => c.InfPtSings).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfTrDec>(c => c.InfTrDecs).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfRepere>(c => c.InfReperes).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfPrevSge>(c => c.InfPrevSges).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfPk>(c => c.InfPks).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfTpc>(c => c.InfTpcs).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfPrOld>(c => c.InfPrOlds).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfSensible>(c => c.InfSensibles).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfClim>(c => c.InfClims).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfAmenagement>(c => c.InfAmenagements).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfAccident>(c => c.InfAccidents).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfCorrespondance>(c => c.InfCorrespondances).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfSecurite>(c => c.InfSecurites).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfOccupation>(c => c.InfOccupations).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfEclairage>(c => c.InfEclairages).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfTalus>(c => c.InfTaluss).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfClVoie>(c => c.InfClVoies).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfTrafic>(c => c.InfTrafics).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfPaveVoie>(c => c.InfPaveVoies).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfSectionTrafic>(c => c.InfSectionTrafics).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfRepartitionTrafic>(c => c.InfRepartitionTrafics).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfGare>(c => c.InfGares).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfAire>(c => c.InfAires).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfBifurcation>(c => c.InfBifurcations).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().HasMany<InfBretelle>(c => c.InfBretelles).WithRequired(t => t.InfChaussee).HasForeignKey(u => new {u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfChaussee>().ToTable("CHAUSSEE_INF","INF");
            modelBuilder.Entity<InfChaussee>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfChaussee>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfChaussee>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfChaussee>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfChaussee>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<InfChaussee>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<InfChaussee>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<InfChaussee>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfChaussee>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfChaussee>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<InfChaussee>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfChaussee>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfChaussee>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfChaussee>().Property(item => item.Tenant).HasMaxLength(60);
            modelBuilder.Entity<InfChaussee>().Property(item => item.Tenant).HasColumnName("TENANT");
            modelBuilder.Entity<InfChaussee>().Property(item => item.About).HasMaxLength(60);
            modelBuilder.Entity<InfChaussee>().Property(item => item.About).HasColumnName("ABOUT");
            modelBuilder.Entity<InfPtSing>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfPtSings).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPtSing>().HasRequired<InfCdPtSing>(c => c.InfCdPtSing).WithMany(t => t.InfPtSings).HasForeignKey(u => new { u.InfCdPtSingIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPtSing>().ToTable("PT_SING_INF","INF");
            modelBuilder.Entity<InfPtSing>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfPtSing>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfPtSing>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfPtSing>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfPtSing>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfPtSing>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfPtSing>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfPtSing>().Property(item => item.CdPtSingInfCode).IsRequired();
            modelBuilder.Entity<InfPtSing>().Property(item => item.CdPtSingInfCode).HasMaxLength(6);
            modelBuilder.Entity<InfPtSing>().Property(item => item.CdPtSingInfCode).HasColumnName("CD_PT_SING_INF__CODE");
            modelBuilder.Entity<InfPtSing>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfPtSing>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfPtSing>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfPtSing>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfPtSing>().Property(item => item.NomUsage).HasMaxLength(60);
            modelBuilder.Entity<InfPtSing>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<InfPtSing>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<InfPtSing>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<InfCdPtSing>().HasMany<InfPtSing>(c => c.InfPtSings).WithRequired(t => t.InfCdPtSing).HasForeignKey(u => new {u.InfCdPtSingIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdPtSing>().ToTable("CD_PT_SING_INF","INF");
            modelBuilder.Entity<InfCdPtSing>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdPtSing>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<InfCdPtSing>().Property(item => item.Code).HasMaxLength(6);
            modelBuilder.Entity<InfCdPtSing>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<InfCdPtSing>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<InfCdPtSing>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfCdPtSing>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfCls>().HasMany<InfClsDoc>(c => c.InfClsDocs).WithRequired(t => t.InfCls).HasForeignKey(u => new {u.InfClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCls>().ToTable("CLS_INF","INF");
            modelBuilder.Entity<InfCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<InfCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<InfCls>().Property(item => item.TableName).IsRequired();
            modelBuilder.Entity<InfCls>().Property(item => item.TableName).HasMaxLength(40);
            modelBuilder.Entity<InfCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<InfCls>().Property(item => item.KeyValue).IsRequired();
            modelBuilder.Entity<InfCls>().Property(item => item.KeyValue).HasMaxLength(100);
            modelBuilder.Entity<InfCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<InfCdDoc>().HasMany<InfDoc>(c => c.InfDocs).WithRequired(t => t.InfCdDoc).HasForeignKey(u => new {u.InfCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdDoc>().ToTable("CD_DOC_INF","INF");
            modelBuilder.Entity<InfCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Path).IsRequired();
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfDoc>().HasRequired<InfCdDoc>(c => c.InfCdDoc).WithMany(t => t.InfDocs).HasForeignKey(u => new { u.InfCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfDoc>().HasMany<InfContact>(c => c.InfContacts).WithRequired(t => t.InfDoc).HasForeignKey(u => new {u.InfDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfDoc>().HasMany<InfClsDoc>(c => c.InfClsDocs).WithRequired(t => t.InfDoc).HasForeignKey(u => new {u.InfDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfDoc>().ToTable("DOC_INF","INF");
            modelBuilder.Entity<InfDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<InfDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<InfDoc>().Property(item => item.CdDocInfCode).IsRequired();
            modelBuilder.Entity<InfDoc>().Property(item => item.CdDocInfCode).HasMaxLength(15);
            modelBuilder.Entity<InfDoc>().Property(item => item.CdDocInfCode).HasColumnName("CD_DOC_INF__CODE");
            modelBuilder.Entity<InfDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfDoc>().Property(item => item.Ref).IsRequired();
            modelBuilder.Entity<InfDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<InfDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<InfCdDec>().HasRequired<InfFamDec>(c => c.InfFamDec).WithMany(t => t.InfCdDecs).HasForeignKey(u => new { u.InfFamDecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdDec>().HasMany<InfTrDec>(c => c.InfTrDecs).WithRequired(t => t.InfCdDec).HasForeignKey(u => new {u.InfCdDecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdDec>().ToTable("CD_DEC_INF","INF");
            modelBuilder.Entity<InfCdDec>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdDec>().Property(item => item.FamDecInfFamDec).IsRequired();
            modelBuilder.Entity<InfCdDec>().Property(item => item.FamDecInfFamDec).HasMaxLength(6);
            modelBuilder.Entity<InfCdDec>().Property(item => item.FamDecInfFamDec).HasColumnName("FAM_DEC_INF__FAM_DEC");
            modelBuilder.Entity<InfCdDec>().Property(item => item.CdDec).IsRequired();
            modelBuilder.Entity<InfCdDec>().Property(item => item.CdDec).HasMaxLength(15);
            modelBuilder.Entity<InfCdDec>().Property(item => item.CdDec).HasColumnName("CD_DEC");
            modelBuilder.Entity<InfCdDec>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<InfCdDec>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfCdDec>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfFamDec>().HasMany<InfCdDec>(c => c.InfCdDecs).WithRequired(t => t.InfFamDec).HasForeignKey(u => new {u.InfFamDecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfFamDec>().ToTable("FAM_DEC_INF","INF");
            modelBuilder.Entity<InfFamDec>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfFamDec>().Property(item => item.FamDec).IsRequired();
            modelBuilder.Entity<InfFamDec>().Property(item => item.FamDec).HasMaxLength(6);
            modelBuilder.Entity<InfFamDec>().Property(item => item.FamDec).HasColumnName("FAM_DEC");
            modelBuilder.Entity<InfFamDec>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<InfFamDec>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfFamDec>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfTrDec>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfTrDecs).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfTrDec>().HasRequired<InfCdDec>(c => c.InfCdDec).WithMany(t => t.InfTrDecs).HasForeignKey(u => new { u.InfCdDecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfTrDec>().ToTable("TR_DEC_INF","INF");
            modelBuilder.Entity<InfTrDec>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfTrDec>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfTrDec>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfTrDec>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfTrDec>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfTrDec>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfTrDec>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfTrDec>().Property(item => item.FamDecInfFamDec).IsRequired();
            modelBuilder.Entity<InfTrDec>().Property(item => item.FamDecInfFamDec).HasMaxLength(6);
            modelBuilder.Entity<InfTrDec>().Property(item => item.FamDecInfFamDec).HasColumnName("FAM_DEC_INF__FAM_DEC");
            modelBuilder.Entity<InfTrDec>().Property(item => item.CdDecInfCdDec).IsRequired();
            modelBuilder.Entity<InfTrDec>().Property(item => item.CdDecInfCdDec).HasMaxLength(15);
            modelBuilder.Entity<InfTrDec>().Property(item => item.CdDecInfCdDec).HasColumnName("CD_DEC_INF__CD_DEC");
            modelBuilder.Entity<InfTrDec>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfTrDec>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfTrDec>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<InfTrDec>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfTpc>().HasRequired<InfCdTpc>(c => c.InfCdTpc).WithMany(t => t.InfTpcs).HasForeignKey(u => new { u.InfCdTpcIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfTpc>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfTpcs).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfTpc>().ToTable("TPC_INF","INF");
            modelBuilder.Entity<InfTpc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfTpc>().Property(item => item.CdTpcInfCode).IsRequired();
            modelBuilder.Entity<InfTpc>().Property(item => item.CdTpcInfCode).HasMaxLength(6);
            modelBuilder.Entity<InfTpc>().Property(item => item.CdTpcInfCode).HasColumnName("CD_TPC_INF__CODE");
            modelBuilder.Entity<InfTpc>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfTpc>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfTpc>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfTpc>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfTpc>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfTpc>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfTpc>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfTpc>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfTpc>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<InfTpc>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfTpc>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<InfCdTpc>().HasMany<InfTpc>(c => c.InfTpcs).WithRequired(t => t.InfCdTpc).HasForeignKey(u => new {u.InfCdTpcIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdTpc>().ToTable("CD_TPC_INF","INF");
            modelBuilder.Entity<InfCdTpc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdTpc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<InfCdTpc>().Property(item => item.Code).HasMaxLength(6);
            modelBuilder.Entity<InfCdTpc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<InfCdTpc>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<InfCdTpc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfCdTpc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfDictionnaire>().ToTable("DICTIONNAIRE_INF","INF");
            modelBuilder.Entity<InfDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Definition).HasMaxLength(1000);
            modelBuilder.Entity<InfDictionnaire>().Property(item => item.Definition).HasColumnName("DEFINITION");
            modelBuilder.Entity<InfRepere>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfReperes).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfRepere>().ToTable("REPERE_INF","INF");
            modelBuilder.Entity<InfRepere>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfRepere>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfRepere>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfRepere>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfRepere>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfRepere>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfRepere>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfRepere>().Property(item => item.Num).IsRequired();
            modelBuilder.Entity<InfRepere>().Property(item => item.Num).HasColumnName("NUM");
            modelBuilder.Entity<InfRepere>().Property(item => item.Inter).IsRequired();
            modelBuilder.Entity<InfRepere>().Property(item => item.Inter).HasColumnName("INTER");
            modelBuilder.Entity<InfRepere>().Property(item => item.AbsCum).HasColumnName("ABS_CUM");
            modelBuilder.Entity<InfPrevSge>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfPrevSges).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPrevSge>().ToTable("PREV_SGE_INF","INF");
            modelBuilder.Entity<InfPrevSge>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfPrevSge>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfPrevSge>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfPrevSge>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Schema).IsRequired();
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Schema).HasMaxLength(5);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Schema).HasColumnName("SCHEMA");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.DateDeb).IsRequired();
            modelBuilder.Entity<InfPrevSge>().Property(item => item.DateDeb).HasColumnName("DATE_DEB");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfPrevSge>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Nature).IsRequired();
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Nature).HasMaxLength(125);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Nature).HasColumnName("NATURE");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.NumOuvrage).IsRequired();
            modelBuilder.Entity<InfPrevSge>().Property(item => item.NumOuvrage).HasMaxLength(20);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.NumOuvrage).HasColumnName("NUM_OUVRAGE");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Ce).HasMaxLength(100);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Ce).HasColumnName("CE");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.DatePub).HasColumnName("DATE_PUB");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.DateFinpub).HasColumnName("DATE_FINPUB");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.DateDemande).HasColumnName("DATE_DEMANDE");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.NomUsage).HasMaxLength(30);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<InfPrevSge>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<InfPk>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfPks).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPk>().ToTable("PK_INF","INF");
            modelBuilder.Entity<InfPk>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfPk>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfPk>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfPk>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfPk>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfPk>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfPk>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfPk>().Property(item => item.AbsCum).IsRequired();
            modelBuilder.Entity<InfPk>().Property(item => item.AbsCum).HasColumnName("ABS_CUM");
            modelBuilder.Entity<InfPk>().Property(item => item.Num).IsRequired();
            modelBuilder.Entity<InfPk>().Property(item => item.Num).HasColumnName("NUM");
            modelBuilder.Entity<InfPk>().Property(item => item.Inter).IsRequired();
            modelBuilder.Entity<InfPk>().Property(item => item.Inter).HasColumnName("INTER");
            modelBuilder.Entity<InfPrOld>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfPrOlds).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPrOld>().ToTable("PR_OLD_INF","INF");
            modelBuilder.Entity<InfPrOld>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfPrOld>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfPrOld>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfPrOld>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfPrOld>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfPrOld>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfPrOld>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfPrOld>().Property(item => item.Num).IsRequired();
            modelBuilder.Entity<InfPrOld>().Property(item => item.Num).HasColumnName("NUM");
            modelBuilder.Entity<InfPrOld>().Property(item => item.Inter).IsRequired();
            modelBuilder.Entity<InfPrOld>().Property(item => item.Inter).HasColumnName("INTER");
            modelBuilder.Entity<InfPrOld>().Property(item => item.AbsCum).HasColumnName("ABS_CUM");
            modelBuilder.Entity<InfSysUser>().ToTable("SYS_USER_INF","INF");
            modelBuilder.Entity<InfSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<InfSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<InfSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<InfSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<InfSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<InfSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<InfSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<InfSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<InfSensible>().HasRequired<InfCdSensible>(c => c.InfCdSensible).WithMany(t => t.InfSensibles).HasForeignKey(u => new { u.InfCdSensibleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfSensible>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfSensibles).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfSensible>().ToTable("SENSIBLE_INF","INF");
            modelBuilder.Entity<InfSensible>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfSensible>().Property(item => item.CdSensibleInfCode).IsRequired();
            modelBuilder.Entity<InfSensible>().Property(item => item.CdSensibleInfCode).HasMaxLength(25);
            modelBuilder.Entity<InfSensible>().Property(item => item.CdSensibleInfCode).HasColumnName("CD_SENSIBLE_INF__CODE");
            modelBuilder.Entity<InfSensible>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfSensible>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfSensible>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfSensible>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfSensible>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfSensible>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfSensible>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfSensible>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfSensible>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfSensible>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfSensible>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfCdSensible>().HasMany<InfSensible>(c => c.InfSensibles).WithRequired(t => t.InfCdSensible).HasForeignKey(u => new {u.InfCdSensibleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdSensible>().ToTable("CD_SENSIBLE_INF","INF");
            modelBuilder.Entity<InfCdSensible>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdSensible>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<InfCdSensible>().Property(item => item.Code).HasMaxLength(25);
            modelBuilder.Entity<InfCdSensible>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<InfClim>().HasRequired<InfCdClim>(c => c.InfCdClim).WithMany(t => t.InfClims).HasForeignKey(u => new { u.InfCdClimIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfClim>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfClims).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfClim>().ToTable("CLIM_INF","INF");
            modelBuilder.Entity<InfClim>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfClim>().Property(item => item.CdClimInfCode).IsRequired();
            modelBuilder.Entity<InfClim>().Property(item => item.CdClimInfCode).HasMaxLength(25);
            modelBuilder.Entity<InfClim>().Property(item => item.CdClimInfCode).HasColumnName("CD_CLIM_INF__CODE");
            modelBuilder.Entity<InfClim>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfClim>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfClim>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfClim>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfClim>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfClim>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfClim>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfClim>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfClim>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfClim>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfClim>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfCdClim>().HasMany<InfClim>(c => c.InfClims).WithRequired(t => t.InfCdClim).HasForeignKey(u => new {u.InfCdClimIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdClim>().ToTable("CD_CLIM_INF","INF");
            modelBuilder.Entity<InfCdClim>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdClim>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<InfCdClim>().Property(item => item.Code).HasMaxLength(25);
            modelBuilder.Entity<InfCdClim>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<InfAmenagement>().HasRequired<InfCdAmenag>(c => c.InfCdAmenag).WithMany(t => t.InfAmenagements).HasForeignKey(u => new { u.InfCdAmenagIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAmenagement>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfAmenagements).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAmenagement>().ToTable("AMENAGEMENT_INF","INF");
            modelBuilder.Entity<InfAmenagement>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfAmenagement>().Property(item => item.CdAmenagInfTypeAmenag).IsRequired();
            modelBuilder.Entity<InfAmenagement>().Property(item => item.CdAmenagInfTypeAmenag).HasMaxLength(60);
            modelBuilder.Entity<InfAmenagement>().Property(item => item.CdAmenagInfTypeAmenag).HasColumnName("CD_AMENAG_INF__TYPE_AMENAG");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfAmenagement>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfAmenagement>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfAmenagement>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfAmenagement>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.DateDeb).IsRequired();
            modelBuilder.Entity<InfAmenagement>().Property(item => item.DateDeb).HasColumnName("DATE_DEB");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfAmenagement>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<InfAmenagement>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<InfAmenagement>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<InfCdAmenag>().HasMany<InfAmenagement>(c => c.InfAmenagements).WithRequired(t => t.InfCdAmenag).HasForeignKey(u => new {u.InfCdAmenagIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdAmenag>().ToTable("CD_AMENAG_INF","INF");
            modelBuilder.Entity<InfCdAmenag>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdAmenag>().Property(item => item.TypeAmenag).IsRequired();
            modelBuilder.Entity<InfCdAmenag>().Property(item => item.TypeAmenag).HasMaxLength(60);
            modelBuilder.Entity<InfCdAmenag>().Property(item => item.TypeAmenag).HasColumnName("TYPE_AMENAG");
            modelBuilder.Entity<InfAccident>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfAccidents).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAccident>().ToTable("ACCIDENT_INF","INF");
            modelBuilder.Entity<InfAccident>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfAccident>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfAccident>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfAccident>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfAccident>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfAccident>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfAccident>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfAccident>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<InfAccident>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<InfAccident>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfAccident>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfAccident>().Property(item => item.Mois).IsRequired();
            modelBuilder.Entity<InfAccident>().Property(item => item.Mois).HasColumnName("MOIS");
            modelBuilder.Entity<InfAccident>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfAccident>().Property(item => item.NbrAcc).HasColumnName("NBR_ACC");
            modelBuilder.Entity<InfAccident>().Property(item => item.NbrAccMois).HasColumnName("NBR_ACC_MOIS");
            modelBuilder.Entity<InfDscOa>().ToTable("DSC_OA_INF","INF");
            modelBuilder.Entity<InfDscOa>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfDscOa>().Property(item => item.CodeOa).IsRequired();
            modelBuilder.Entity<InfDscOa>().Property(item => item.CodeOa).HasColumnName("CODE_OA");
            modelBuilder.Entity<InfDscOa>().Property(item => item.NumOa).HasMaxLength(40);
            modelBuilder.Entity<InfDscOa>().Property(item => item.NumOa).HasColumnName("NUM_OA");
            modelBuilder.Entity<InfDscOa>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<InfDscOa>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<InfDscOa>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<InfDscOa>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<InfDscOa>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<InfDscOa>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<InfDscOa>().Property(item => item.PrOa).HasMaxLength(10);
            modelBuilder.Entity<InfDscOa>().Property(item => item.PrOa).HasColumnName("PR_OA");
            modelBuilder.Entity<InfDscOa>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfDscOa>().Property(item => item.NumExploit).HasMaxLength(80);
            modelBuilder.Entity<InfDscOa>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<InfDscOa>().Property(item => item.NomUsage).HasMaxLength(100);
            modelBuilder.Entity<InfDscOa>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<InfDscOa>().Property(item => item.Famille).HasMaxLength(80);
            modelBuilder.Entity<InfDscOa>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<InfDscOa>().Property(item => item.TypeOuvrage).HasMaxLength(80);
            modelBuilder.Entity<InfDscOa>().Property(item => item.TypeOuvrage).HasColumnName("TYPE_OUVRAGE");
            modelBuilder.Entity<InfDscOa>().Property(item => item.Materiaux).HasMaxLength(80);
            modelBuilder.Entity<InfDscOa>().Property(item => item.Materiaux).HasColumnName("MATERIAUX");
            modelBuilder.Entity<InfDscOa>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<InfDscOa>().Property(item => item.NbreTabliers).HasColumnName("NBRE_TABLIERS");
            modelBuilder.Entity<InfDscOa>().Property(item => item.NbreTravee).HasColumnName("NBRE_TRAVEE");
            modelBuilder.Entity<InfDscOa>().Property(item => item.Gabarit).HasColumnName("GABARIT");
            modelBuilder.Entity<InfDscOa>().Property(item => item.Longueur).HasColumnName("LONGUEUR");
            modelBuilder.Entity<InfDscOa>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<InfDscOa>().Property(item => item.SectCouranteValueInt).HasColumnName("SECT_COURANTE");
            modelBuilder.Entity<InfDscOa>().Ignore(item => item.SectCourante);
            modelBuilder.Entity<InfDscOa>().Property(item => item.Iqoa).HasMaxLength(8);
            modelBuilder.Entity<InfDscOa>().Property(item => item.Iqoa).HasColumnName("IQOA");
            modelBuilder.Entity<InfDscOa>().Property(item => item.NoteUrgence).HasColumnName("NOTE_URGENCE");
            modelBuilder.Entity<InfCorrespondance>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfCorrespondances).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCorrespondance>().ToTable("CORRESPONDANCE_INF","INF");
            modelBuilder.Entity<InfCorrespondance>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.AxeSae).IsRequired();
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.AxeSae).HasMaxLength(60);
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.AxeSae).HasColumnName("AXE_SAE");
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.EmplaceSae).IsRequired();
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.EmplaceSae).HasMaxLength(60);
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.EmplaceSae).HasColumnName("EMPLACE_SAE");
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.SensSae).IsRequired();
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.SensSae).HasMaxLength(60);
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.SensSae).HasColumnName("SENS_SAE");
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfCorrespondance>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfCdPosit>().HasMany<InfSecurite>(c => c.InfSecurites).WithRequired(t => t.InfCdPosit).HasForeignKey(u => new {u.InfCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdPosit>().HasMany<InfEclairage>(c => c.InfEclairages).WithRequired(t => t.InfCdPosit).HasForeignKey(u => new {u.InfCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdPosit>().HasMany<InfEvt>(c => c.InfEvts).WithOptional(t => t.InfCdPosit).HasForeignKey(u => new {u.InfCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdPosit>().ToTable("CD_POSIT_INF","INF");
            modelBuilder.Entity<InfCdPosit>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdPosit>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<InfCdPosit>().Property(item => item.Posit).HasMaxLength(12);
            modelBuilder.Entity<InfCdPosit>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<InfCdPosit>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<InfSecurite>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfSecurites).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfSecurite>().HasRequired<InfCdSecur>(c => c.InfCdSecur).WithMany(t => t.InfSecurites).HasForeignKey(u => new { u.InfCdSecurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfSecurite>().HasRequired<InfCdPosit>(c => c.InfCdPosit).WithMany(t => t.InfSecurites).HasForeignKey(u => new { u.InfCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfSecurite>().ToTable("SECURITE_INF","INF");
            modelBuilder.Entity<InfSecurite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfSecurite>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfSecurite>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfSecurite>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfSecurite>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfSecurite>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfSecurite>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfSecurite>().Property(item => item.CdSecurInfType).IsRequired();
            modelBuilder.Entity<InfSecurite>().Property(item => item.CdSecurInfType).HasMaxLength(25);
            modelBuilder.Entity<InfSecurite>().Property(item => item.CdSecurInfType).HasColumnName("CD_SECUR_INF__TYPE");
            modelBuilder.Entity<InfSecurite>().Property(item => item.CdPositInfPosit).IsRequired();
            modelBuilder.Entity<InfSecurite>().Property(item => item.CdPositInfPosit).HasMaxLength(12);
            modelBuilder.Entity<InfSecurite>().Property(item => item.CdPositInfPosit).HasColumnName("CD_POSIT_INF__POSIT");
            modelBuilder.Entity<InfSecurite>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfSecurite>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfSecurite>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfEclairage>().HasRequired<InfCdEclair>(c => c.InfCdEclair).WithMany(t => t.InfEclairages).HasForeignKey(u => new { u.InfCdEclairIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfEclairage>().HasRequired<InfCdPosit>(c => c.InfCdPosit).WithMany(t => t.InfEclairages).HasForeignKey(u => new { u.InfCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfEclairage>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfEclairages).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfEclairage>().ToTable("ECLAIRAGE_INF","INF");
            modelBuilder.Entity<InfEclairage>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfEclairage>().Property(item => item.CdEclairInfType).IsRequired();
            modelBuilder.Entity<InfEclairage>().Property(item => item.CdEclairInfType).HasMaxLength(25);
            modelBuilder.Entity<InfEclairage>().Property(item => item.CdEclairInfType).HasColumnName("CD_ECLAIR_INF__TYPE");
            modelBuilder.Entity<InfEclairage>().Property(item => item.CdPositInfPosit).IsRequired();
            modelBuilder.Entity<InfEclairage>().Property(item => item.CdPositInfPosit).HasMaxLength(12);
            modelBuilder.Entity<InfEclairage>().Property(item => item.CdPositInfPosit).HasColumnName("CD_POSIT_INF__POSIT");
            modelBuilder.Entity<InfEclairage>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfEclairage>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfEclairage>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfEclairage>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfEclairage>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfEclairage>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfEclairage>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfEclairage>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfCdSecur>().HasMany<InfSecurite>(c => c.InfSecurites).WithRequired(t => t.InfCdSecur).HasForeignKey(u => new {u.InfCdSecurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdSecur>().ToTable("CD_SECUR_INF","INF");
            modelBuilder.Entity<InfCdSecur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdSecur>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdSecur>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<InfCdSecur>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfCdEclair>().HasMany<InfEclairage>(c => c.InfEclairages).WithRequired(t => t.InfCdEclair).HasForeignKey(u => new {u.InfCdEclairIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdEclair>().ToTable("CD_ECLAIR_INF","INF");
            modelBuilder.Entity<InfCdEclair>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdEclair>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdEclair>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<InfCdEclair>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfOccupation>().HasRequired<InfCdOccup>(c => c.InfCdOccup).WithMany(t => t.InfOccupations).HasForeignKey(u => new { u.InfCdOccupIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfOccupation>().HasRequired<InfCdOccupant>(c => c.InfCdOccupant).WithMany(t => t.InfOccupations).HasForeignKey(u => new { u.InfCdOccupantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfOccupation>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfOccupations).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfOccupation>().ToTable("OCCUPATION_INF","INF");
            modelBuilder.Entity<InfOccupation>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfOccupation>().Property(item => item.CdOccupInfType).IsRequired();
            modelBuilder.Entity<InfOccupation>().Property(item => item.CdOccupInfType).HasMaxLength(60);
            modelBuilder.Entity<InfOccupation>().Property(item => item.CdOccupInfType).HasColumnName("CD_OCCUP_INF__TYPE");
            modelBuilder.Entity<InfOccupation>().Property(item => item.CdOccupantInfNom).IsRequired();
            modelBuilder.Entity<InfOccupation>().Property(item => item.CdOccupantInfNom).HasMaxLength(60);
            modelBuilder.Entity<InfOccupation>().Property(item => item.CdOccupantInfNom).HasColumnName("CD_OCCUPANT_INF__NOM");
            modelBuilder.Entity<InfOccupation>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfOccupation>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfOccupation>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfOccupation>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfOccupation>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfOccupation>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfOccupation>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfOccupation>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfOccupation>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfOccupation>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<InfOccupation>().Property(item => item.DateFv).HasColumnName("DATE_FV");
            modelBuilder.Entity<InfOccupation>().Property(item => item.TravValueInt).HasColumnName("TRAV");
            modelBuilder.Entity<InfOccupation>().Ignore(item => item.Trav);
            modelBuilder.Entity<InfOccupation>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<InfOccupation>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<InfCdOccup>().HasMany<InfOccupation>(c => c.InfOccupations).WithRequired(t => t.InfCdOccup).HasForeignKey(u => new {u.InfCdOccupIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdOccup>().ToTable("CD_OCCUP_INF","INF");
            modelBuilder.Entity<InfCdOccup>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdOccup>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdOccup>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<InfCdOccup>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfCdOccupant>().HasMany<InfOccupation>(c => c.InfOccupations).WithRequired(t => t.InfCdOccupant).HasForeignKey(u => new {u.InfCdOccupantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdOccupant>().ToTable("CD_OCCUPANT_INF","INF");
            modelBuilder.Entity<InfCdOccupant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdOccupant>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<InfCdOccupant>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<InfCdOccupant>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<InfTalus>().HasRequired<InfCdTalus>(c => c.InfCdTalus).WithMany(t => t.InfTaluss).HasForeignKey(u => new { u.InfCdTalusIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfTalus>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfTaluss).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfTalus>().ToTable("TALUS_INF","INF");
            modelBuilder.Entity<InfTalus>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfTalus>().Property(item => item.CdTalusInfType).IsRequired();
            modelBuilder.Entity<InfTalus>().Property(item => item.CdTalusInfType).HasMaxLength(25);
            modelBuilder.Entity<InfTalus>().Property(item => item.CdTalusInfType).HasColumnName("CD_TALUS_INF__TYPE");
            modelBuilder.Entity<InfTalus>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfTalus>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfTalus>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfTalus>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfTalus>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfTalus>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfTalus>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfTalus>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfTalus>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfTalus>().Property(item => item.Haut).HasColumnName("HAUT");
            modelBuilder.Entity<InfCdTalus>().HasMany<InfTalus>(c => c.InfTaluss).WithRequired(t => t.InfCdTalus).HasForeignKey(u => new {u.InfCdTalusIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdTalus>().ToTable("CD_TALUS_INF","INF");
            modelBuilder.Entity<InfCdTalus>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdTalus>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdTalus>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<InfCdTalus>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfWgs>().ToTable("WGS_INF","INF");
            modelBuilder.Entity<InfWgs>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfWgs>().Property(item => item.LineIndex).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.LineIndex).HasColumnName("LINE_INDEX");
            modelBuilder.Entity<InfWgs>().Property(item => item.LayerName).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.LayerName).HasMaxLength(100);
            modelBuilder.Entity<InfWgs>().Property(item => item.LayerName).HasColumnName("LAYER_NAME");
            modelBuilder.Entity<InfWgs>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.Liaison).HasMaxLength(16);
            modelBuilder.Entity<InfWgs>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<InfWgs>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<InfWgs>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<InfWgs>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfWgs>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfWgs>().Property(item => item.X1).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<InfWgs>().Property(item => item.Y1).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<InfWgs>().Property(item => item.X2).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<InfWgs>().Property(item => item.Y2).IsRequired();
            modelBuilder.Entity<InfWgs>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<InfCdVoie>().HasMany<InfPaveVoie>(c => c.InfPaveVoies).WithRequired(t => t.InfCdVoie).HasForeignKey(u => new {u.InfCdVoieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdVoie>().HasMany<InfClVoie>(c => c.InfClVoies).WithRequired(t => t.InfCdVoie).HasForeignKey(u => new {u.InfCdVoieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdVoie>().ToTable("CD_VOIE_INF","INF");
            modelBuilder.Entity<InfCdVoie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdVoie>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<InfCdVoie>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<InfCdVoie>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<InfCdVoie>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<InfCdVoie>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<InfCdVoie>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfCdVoie>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfCdVoie>().Property(item => item.RoulableValueInt).HasColumnName("ROULABLE");
            modelBuilder.Entity<InfCdVoie>().Ignore(item => item.Roulable);
            modelBuilder.Entity<InfPaveVoie>().HasRequired<InfCdVoie>(c => c.InfCdVoie).WithMany(t => t.InfPaveVoies).HasForeignKey(u => new { u.InfCdVoieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPaveVoie>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfPaveVoies).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPaveVoie>().ToTable("PAVE_VOIE_INF","INF");
            modelBuilder.Entity<InfPaveVoie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.CdVoieInfVoie).IsRequired();
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.CdVoieInfVoie).HasMaxLength(6);
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.CdVoieInfVoie).HasColumnName("CD_VOIE_INF__VOIE");
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.Largeur).IsRequired();
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<InfPaveVoie>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<InfClVoie>().HasRequired<InfCdVoie>(c => c.InfCdVoie).WithMany(t => t.InfClVoies).HasForeignKey(u => new { u.InfCdVoieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfClVoie>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfClVoies).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfClVoie>().ToTable("CL_VOIE_INF","INF");
            modelBuilder.Entity<InfClVoie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfClVoie>().Property(item => item.CdVoieInfVoie).IsRequired();
            modelBuilder.Entity<InfClVoie>().Property(item => item.CdVoieInfVoie).HasMaxLength(6);
            modelBuilder.Entity<InfClVoie>().Property(item => item.CdVoieInfVoie).HasColumnName("CD_VOIE_INF__VOIE");
            modelBuilder.Entity<InfClVoie>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfClVoie>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfClVoie>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfClVoie>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfClVoie>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfClVoie>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfClVoie>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfClVoie>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfClVoie>().Property(item => item.NumVnr).IsRequired();
            modelBuilder.Entity<InfClVoie>().Property(item => item.NumVnr).HasColumnName("NUM_VNR");
            modelBuilder.Entity<InfClVoie>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<InfClVoie>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfClVoie>().Property(item => item.Num).HasColumnName("NUM");
            modelBuilder.Entity<InfClVoie>().Property(item => item.Nbre).HasColumnName("NBRE");
            modelBuilder.Entity<InfClVoie>().Property(item => item.NbreVnr).IsRequired();
            modelBuilder.Entity<InfClVoie>().Property(item => item.NbreVnr).HasColumnName("NBRE_VNR");
            modelBuilder.Entity<InfTrafic>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfTrafics).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfTrafic>().ToTable("TRAFIC_INF","INF");
            modelBuilder.Entity<InfTrafic>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfTrafic>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfTrafic>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfTrafic>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfTrafic>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfTrafic>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfTrafic>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfTrafic>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<InfTrafic>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<InfTrafic>().Property(item => item.Pl).HasColumnName("PL");
            modelBuilder.Entity<InfTrafic>().Property(item => item.Tmja).HasColumnName("TMJA");
            modelBuilder.Entity<InfSectionTrafic>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfSectionTrafics).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfSectionTrafic>().HasRequired<InfCdClassTraf>(c => c.InfCdClassTraf).WithMany(t => t.InfSectionTrafics).HasForeignKey(u => new { u.InfCdClassTrafIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfSectionTrafic>().ToTable("SECTION_TRAFIC_INF","INF");
            modelBuilder.Entity<InfSectionTrafic>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.CdClassTrafInfCode).IsRequired();
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.CdClassTrafInfCode).HasMaxLength(6);
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.CdClassTrafInfCode).HasColumnName("CD_CLASS_TRAF_INF__CODE");
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.Tenant).HasMaxLength(60);
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.Tenant).HasColumnName("TENANT");
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.Aboutis).HasMaxLength(60);
            modelBuilder.Entity<InfSectionTrafic>().Property(item => item.Aboutis).HasColumnName("ABOUTIS");
            modelBuilder.Entity<InfCdClassTraf>().HasMany<InfSectionTrafic>(c => c.InfSectionTrafics).WithRequired(t => t.InfCdClassTraf).HasForeignKey(u => new {u.InfCdClassTrafIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdClassTraf>().ToTable("CD_CLASS_TRAF_INF","INF");
            modelBuilder.Entity<InfCdClassTraf>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdClassTraf>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<InfCdClassTraf>().Property(item => item.Code).HasMaxLength(6);
            modelBuilder.Entity<InfCdClassTraf>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<InfRepartitionTrafic>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfRepartitionTrafics).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfRepartitionTrafic>().ToTable("REPARTITION_TRAFIC_INF","INF");
            modelBuilder.Entity<InfRepartitionTrafic>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfRepartitionTrafic>().Property(item => item.PPl).HasColumnName("P_PL");
            modelBuilder.Entity<InfGare>().HasRequired<InfCdGare>(c => c.InfCdGare).WithMany(t => t.InfGares).HasForeignKey(u => new { u.InfCdGareIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfGare>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfGares).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfGare>().ToTable("GARE_INF","INF");
            modelBuilder.Entity<InfGare>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfGare>().Property(item => item.CdGareInfType).IsRequired();
            modelBuilder.Entity<InfGare>().Property(item => item.CdGareInfType).HasMaxLength(60);
            modelBuilder.Entity<InfGare>().Property(item => item.CdGareInfType).HasColumnName("CD_GARE_INF__TYPE");
            modelBuilder.Entity<InfGare>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfGare>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfGare>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfGare>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfGare>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfGare>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfGare>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfGare>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfGare>().Property(item => item.NumExploit).HasMaxLength(15);
            modelBuilder.Entity<InfGare>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<InfGare>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<InfGare>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<InfGare>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<InfGare>().Property(item => item.VoiEntree).HasColumnName("VOI_ENTREE");
            modelBuilder.Entity<InfGare>().Property(item => item.VoiSortie).HasColumnName("VOI_SORTIE");
            modelBuilder.Entity<InfGare>().Property(item => item.VoiMixte).HasColumnName("VOI_MIXTE");
            modelBuilder.Entity<InfGare>().Property(item => item.VoiTsa).HasColumnName("VOI_TSA");
            modelBuilder.Entity<InfGare>().Property(item => item.Observ).HasMaxLength(250);
            modelBuilder.Entity<InfGare>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<InfGare>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<InfGare>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<InfGare>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<InfGare>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<InfGare>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<InfGare>().Ignore(item => item.Terrain);
            modelBuilder.Entity<InfCdGare>().HasMany<InfGare>(c => c.InfGares).WithRequired(t => t.InfCdGare).HasForeignKey(u => new {u.InfCdGareIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdGare>().ToTable("CD_GARE_INF","INF");
            modelBuilder.Entity<InfCdGare>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdGare>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdGare>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<InfCdGare>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfAire>().HasRequired<InfCdAire>(c => c.InfCdAire).WithMany(t => t.InfAires).HasForeignKey(u => new { u.InfCdAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAire>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfAires).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAire>().HasMany<InfAirePrestataire>(c => c.InfAirePrestataires).WithRequired(t => t.InfAire).HasForeignKey(u => new {u.InfAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAire>().HasMany<InfAireService>(c => c.InfAireServices).WithRequired(t => t.InfAire).HasForeignKey(u => new {u.InfAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAire>().HasMany<InfAirePlace>(c => c.InfAirePlaces).WithRequired(t => t.InfAire).HasForeignKey(u => new {u.InfAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAire>().ToTable("AIRE_INF","INF");
            modelBuilder.Entity<InfAire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfAire>().Property(item => item.CdAireInfType).IsRequired();
            modelBuilder.Entity<InfAire>().Property(item => item.CdAireInfType).HasMaxLength(60);
            modelBuilder.Entity<InfAire>().Property(item => item.CdAireInfType).HasColumnName("CD_AIRE_INF__TYPE");
            modelBuilder.Entity<InfAire>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfAire>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfAire>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfAire>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfAire>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfAire>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfAire>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfAire>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfAire>().Property(item => item.NumExploit).HasMaxLength(15);
            modelBuilder.Entity<InfAire>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<InfAire>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<InfAire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<InfAire>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<InfAire>().Property(item => item.PasserelleValueInt).HasColumnName("PASSERELLE");
            modelBuilder.Entity<InfAire>().Ignore(item => item.Passerelle);
            modelBuilder.Entity<InfAire>().Property(item => item.DemiTourValueInt).HasColumnName("DEMI_TOUR");
            modelBuilder.Entity<InfAire>().Ignore(item => item.DemiTour);
            modelBuilder.Entity<InfAire>().Property(item => item.BilateraleValueInt).HasColumnName("BILATERALE");
            modelBuilder.Entity<InfAire>().Ignore(item => item.Bilaterale);
            modelBuilder.Entity<InfAire>().Property(item => item.Observ).HasMaxLength(250);
            modelBuilder.Entity<InfAire>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<InfAire>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<InfAire>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<InfAire>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<InfAire>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<InfAire>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<InfAire>().Ignore(item => item.Terrain);
            modelBuilder.Entity<InfCdAire>().HasMany<InfAire>(c => c.InfAires).WithRequired(t => t.InfCdAire).HasForeignKey(u => new {u.InfCdAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdAire>().ToTable("CD_AIRE_INF","INF");
            modelBuilder.Entity<InfCdAire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdAire>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdAire>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<InfCdAire>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfCdPrestataire>().HasMany<InfPrestataire>(c => c.InfPrestataires).WithRequired(t => t.InfCdPrestataire).HasForeignKey(u => new {u.InfCdPrestataireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdPrestataire>().ToTable("CD_PRESTATAIRE_INF","INF");
            modelBuilder.Entity<InfCdPrestataire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdPrestataire>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdPrestataire>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<InfCdPrestataire>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfPrestataire>().HasRequired<InfCdPrestataire>(c => c.InfCdPrestataire).WithMany(t => t.InfPrestataires).HasForeignKey(u => new { u.InfCdPrestataireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPrestataire>().HasMany<InfAirePrestataire>(c => c.InfAirePrestataires).WithRequired(t => t.InfPrestataire).HasForeignKey(u => new {u.InfPrestataireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfPrestataire>().ToTable("PRESTATAIRE_INF","INF");
            modelBuilder.Entity<InfPrestataire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfPrestataire>().Property(item => item.CdPrestataireInfType).IsRequired();
            modelBuilder.Entity<InfPrestataire>().Property(item => item.CdPrestataireInfType).HasMaxLength(60);
            modelBuilder.Entity<InfPrestataire>().Property(item => item.CdPrestataireInfType).HasColumnName("CD_PRESTATAIRE_INF__TYPE");
            modelBuilder.Entity<InfPrestataire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<InfPrestataire>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<InfPrestataire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<InfCdService>().HasMany<InfAireService>(c => c.InfAireServices).WithRequired(t => t.InfCdService).HasForeignKey(u => new {u.InfCdServiceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdService>().ToTable("CD_SERVICE_INF","INF");
            modelBuilder.Entity<InfCdService>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdService>().Property(item => item.Service).IsRequired();
            modelBuilder.Entity<InfCdService>().Property(item => item.Service).HasMaxLength(60);
            modelBuilder.Entity<InfCdService>().Property(item => item.Service).HasColumnName("SERVICE");
            modelBuilder.Entity<InfCdBif>().HasMany<InfBifurcation>(c => c.InfBifurcations).WithRequired(t => t.InfCdBif).HasForeignKey(u => new {u.InfCdBifIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdBif>().ToTable("CD_BIF_INF","INF");
            modelBuilder.Entity<InfCdBif>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdBif>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdBif>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<InfCdBif>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfBifurcation>().HasRequired<InfCdBif>(c => c.InfCdBif).WithMany(t => t.InfBifurcations).HasForeignKey(u => new { u.InfCdBifIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfBifurcation>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfBifurcations).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfBifurcation>().ToTable("BIFURCATION_INF","INF");
            modelBuilder.Entity<InfBifurcation>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfBifurcation>().Property(item => item.CdBifInfType).IsRequired();
            modelBuilder.Entity<InfBifurcation>().Property(item => item.CdBifInfType).HasMaxLength(60);
            modelBuilder.Entity<InfBifurcation>().Property(item => item.CdBifInfType).HasColumnName("CD_BIF_INF__TYPE");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfBifurcation>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfBifurcation>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfBifurcation>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfBifurcation>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfBifurcation>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<InfBifurcation>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.NumExploit).HasMaxLength(15);
            modelBuilder.Entity<InfBifurcation>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.Observ).HasMaxLength(250);
            modelBuilder.Entity<InfBifurcation>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<InfBifurcation>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<InfBifurcation>().Ignore(item => item.Terrain);
            modelBuilder.Entity<InfBretelle>().HasRequired<InfChaussee>(c => c.InfChaussee).WithMany(t => t.InfBretelles).HasForeignKey(u => new { u.InfChausseeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfBretelle>().ToTable("BRETELLE_INF","INF");
            modelBuilder.Entity<InfBretelle>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfBretelle>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfBretelle>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfBretelle>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfBretelle>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfBretelle>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfBretelle>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfBretelle>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfBretelle>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfBretelle>().Property(item => item.NumExploit).HasMaxLength(15);
            modelBuilder.Entity<InfBretelle>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<InfBretelle>().Property(item => item.NumBretelle).HasMaxLength(15);
            modelBuilder.Entity<InfBretelle>().Property(item => item.NumBretelle).HasColumnName("NUM_BRETELLE");
            modelBuilder.Entity<InfBretelle>().Property(item => item.NomBretelle).HasMaxLength(15);
            modelBuilder.Entity<InfBretelle>().Property(item => item.NomBretelle).HasColumnName("NOM_BRETELLE");
            modelBuilder.Entity<InfBretelle>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<InfBretelle>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<InfBretelle>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<InfBretelle>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfBretelle>().Property(item => item.Extremite).HasMaxLength(60);
            modelBuilder.Entity<InfBretelle>().Property(item => item.Extremite).HasColumnName("EXTREMITE");
            modelBuilder.Entity<InfCdPlace>().HasMany<InfAirePlace>(c => c.InfAirePlaces).WithRequired(t => t.InfCdPlace).HasForeignKey(u => new {u.InfCdPlaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdPlace>().ToTable("CD_PLACE_INF","INF");
            modelBuilder.Entity<InfCdPlace>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdPlace>().Property(item => item.Parking).IsRequired();
            modelBuilder.Entity<InfCdPlace>().Property(item => item.Parking).HasMaxLength(60);
            modelBuilder.Entity<InfCdPlace>().Property(item => item.Parking).HasColumnName("PARKING");
            modelBuilder.Entity<InfCdEvt>().HasMany<InfEvt>(c => c.InfEvts).WithRequired(t => t.InfCdEvt).HasForeignKey(u => new {u.InfCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfCdEvt>().ToTable("CD_EVT_INF","INF");
            modelBuilder.Entity<InfCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<InfCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<InfCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<InfCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<InfCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<InfEvt>().HasRequired<InfCdEvt>(c => c.InfCdEvt).WithMany(t => t.InfEvts).HasForeignKey(u => new { u.InfCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfEvt>().HasOptional<InfCdPosit>(c => c.InfCdPosit).WithMany(t => t.InfEvts).HasForeignKey(u => new {u.InfCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfEvt>().ToTable("EVT_INF","INF");
            modelBuilder.Entity<InfEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfEvt>().Property(item => item.CdEvtInfType).IsRequired();
            modelBuilder.Entity<InfEvt>().Property(item => item.CdEvtInfType).HasMaxLength(25);
            modelBuilder.Entity<InfEvt>().Property(item => item.CdEvtInfType).HasColumnName("CD_EVT_INF__TYPE");
            modelBuilder.Entity<InfEvt>().Property(item => item.IdEvt).IsRequired();
            modelBuilder.Entity<InfEvt>().Property(item => item.IdEvt).HasColumnName("ID_EVT");
            modelBuilder.Entity<InfEvt>().Property(item => item.CdPositInfPosit).HasMaxLength(12);
            modelBuilder.Entity<InfEvt>().Property(item => item.CdPositInfPosit).HasColumnName("CD_POSIT_INF__POSIT");
            modelBuilder.Entity<InfEvt>().Property(item => item.NomTable).IsRequired();
            modelBuilder.Entity<InfEvt>().Property(item => item.NomTable).HasMaxLength(60);
            modelBuilder.Entity<InfEvt>().Property(item => item.NomTable).HasColumnName("NOM_TABLE");
            modelBuilder.Entity<InfEvt>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<InfEvt>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<InfEvt>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<InfEvt>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<InfEvt>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<InfEvt>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<InfEvt>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<InfEvt>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<InfEvt>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<InfEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<InfEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<InfEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<InfEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<InfEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<InfContact>().HasRequired<InfDoc>(c => c.InfDoc).WithMany(t => t.InfContacts).HasForeignKey(u => new { u.InfDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfContact>().ToTable("CONTACT_INF","INF");
            modelBuilder.Entity<InfContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfContact>().Property(item => item.DocInfId).IsRequired();
            modelBuilder.Entity<InfContact>().Property(item => item.DocInfId).HasColumnName("DOC_INF__ID");
            modelBuilder.Entity<InfContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<InfContact>().Property(item => item.Givenname).HasColumnName("givenName");
            modelBuilder.Entity<InfContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<InfContact>().Property(item => item.Sn).HasColumnName("sn");
            modelBuilder.Entity<InfContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<InfContact>().Property(item => item.Cn).HasColumnName("cn");
            modelBuilder.Entity<InfContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<InfContact>().Property(item => item.O).HasColumnName("o");
            modelBuilder.Entity<InfContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<InfContact>().Property(item => item.Mail).HasColumnName("mail");
            modelBuilder.Entity<InfContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<InfContact>().Property(item => item.Telephonenumber).HasColumnName("telephoneNumber");
            modelBuilder.Entity<InfContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<InfContact>().Property(item => item.Mobile).HasColumnName("mobile");
            modelBuilder.Entity<InfContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<InfContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("facsimiletelephonenumber");
            modelBuilder.Entity<InfContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<InfContact>().Property(item => item.Street).HasColumnName("street");
            modelBuilder.Entity<InfContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<InfContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("mozillaWorkStreet2");
            modelBuilder.Entity<InfContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<InfContact>().Property(item => item.L).HasColumnName("l");
            modelBuilder.Entity<InfContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<InfContact>().Property(item => item.Postalcode).HasColumnName("postalCode");
            modelBuilder.Entity<InfContact>().Property(item => item.Modifytimestamp).HasColumnName("modifytimestamp");
            modelBuilder.Entity<InfClsDoc>().HasRequired<InfDoc>(c => c.InfDoc).WithMany(t => t.InfClsDocs).HasForeignKey(u => new { u.InfDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfClsDoc>().HasRequired<InfCls>(c => c.InfCls).WithMany(t => t.InfClsDocs).HasForeignKey(u => new { u.InfClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfClsDoc>().ToTable("CLS_DOC_INF","INF");
            modelBuilder.Entity<InfClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfClsDoc>().Property(item => item.DocInfId).IsRequired();
            modelBuilder.Entity<InfClsDoc>().Property(item => item.DocInfId).HasColumnName("DOC_INF__ID");
            modelBuilder.Entity<InfClsDoc>().Property(item => item.ClsInfId).IsRequired();
            modelBuilder.Entity<InfClsDoc>().Property(item => item.ClsInfId).HasColumnName("CLS_INF__ID");
            modelBuilder.Entity<InfClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<InfClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<InfClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<InfClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
            modelBuilder.Entity<InfAirePrestataire>().HasRequired<InfAire>(c => c.InfAire).WithMany(t => t.InfAirePrestataires).HasForeignKey(u => new { u.InfAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAirePrestataire>().HasRequired<InfPrestataire>(c => c.InfPrestataire).WithMany(t => t.InfAirePrestataires).HasForeignKey(u => new { u.InfPrestataireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAirePrestataire>().ToTable("AIRE__PRESTATAIRE_INF","INF");
            modelBuilder.Entity<InfAirePrestataire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.CdAireInfType).IsRequired();
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.CdAireInfType).HasMaxLength(60);
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.CdAireInfType).HasColumnName("CD_AIRE_INF__TYPE");
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.AireInfAbsDeb).IsRequired();
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.AireInfAbsDeb).HasColumnName("AIRE_INF__ABS_DEB");
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.CdPrestataireInfType).IsRequired();
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.CdPrestataireInfType).HasMaxLength(60);
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.CdPrestataireInfType).HasColumnName("CD_PRESTATAIRE_INF__TYPE");
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.PrestataireInfNom).IsRequired();
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.PrestataireInfNom).HasMaxLength(60);
            modelBuilder.Entity<InfAirePrestataire>().Property(item => item.PrestataireInfNom).HasColumnName("PRESTATAIRE_INF__NOM");
            modelBuilder.Entity<InfAireService>().HasRequired<InfCdService>(c => c.InfCdService).WithMany(t => t.InfAireServices).HasForeignKey(u => new { u.InfCdServiceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAireService>().HasRequired<InfAire>(c => c.InfAire).WithMany(t => t.InfAireServices).HasForeignKey(u => new { u.InfAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAireService>().ToTable("AIRE__SERVICE_INF","INF");
            modelBuilder.Entity<InfAireService>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfAireService>().Property(item => item.CdServiceInfService).IsRequired();
            modelBuilder.Entity<InfAireService>().Property(item => item.CdServiceInfService).HasMaxLength(60);
            modelBuilder.Entity<InfAireService>().Property(item => item.CdServiceInfService).HasColumnName("CD_SERVICE_INF__SERVICE");
            modelBuilder.Entity<InfAireService>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfAireService>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfAireService>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfAireService>().Property(item => item.CdAireInfType).IsRequired();
            modelBuilder.Entity<InfAireService>().Property(item => item.CdAireInfType).HasMaxLength(60);
            modelBuilder.Entity<InfAireService>().Property(item => item.CdAireInfType).HasColumnName("CD_AIRE_INF__TYPE");
            modelBuilder.Entity<InfAireService>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfAireService>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfAireService>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfAireService>().Property(item => item.AireInfAbsDeb).IsRequired();
            modelBuilder.Entity<InfAireService>().Property(item => item.AireInfAbsDeb).HasColumnName("AIRE_INF__ABS_DEB");
            modelBuilder.Entity<InfAirePlace>().HasRequired<InfCdPlace>(c => c.InfCdPlace).WithMany(t => t.InfAirePlaces).HasForeignKey(u => new { u.InfCdPlaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAirePlace>().HasRequired<InfAire>(c => c.InfAire).WithMany(t => t.InfAirePlaces).HasForeignKey(u => new { u.InfAireIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<InfAirePlace>().ToTable("AIRE__PLACE_INF","INF");
            modelBuilder.Entity<InfAirePlace>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<InfAirePlace>().Property(item => item.CdPlaceInfParking).IsRequired();
            modelBuilder.Entity<InfAirePlace>().Property(item => item.CdPlaceInfParking).HasMaxLength(60);
            modelBuilder.Entity<InfAirePlace>().Property(item => item.CdPlaceInfParking).HasColumnName("CD_PLACE_INF__PARKING");
            modelBuilder.Entity<InfAirePlace>().Property(item => item.LiaisonInfLiaison).IsRequired();
            modelBuilder.Entity<InfAirePlace>().Property(item => item.LiaisonInfLiaison).HasMaxLength(15);
            modelBuilder.Entity<InfAirePlace>().Property(item => item.LiaisonInfLiaison).HasColumnName("LIAISON_INF__LIAISON");
            modelBuilder.Entity<InfAirePlace>().Property(item => item.CdAireInfType).IsRequired();
            modelBuilder.Entity<InfAirePlace>().Property(item => item.CdAireInfType).HasMaxLength(60);
            modelBuilder.Entity<InfAirePlace>().Property(item => item.CdAireInfType).HasColumnName("CD_AIRE_INF__TYPE");
            modelBuilder.Entity<InfAirePlace>().Property(item => item.ChausseeInfSens).IsRequired();
            modelBuilder.Entity<InfAirePlace>().Property(item => item.ChausseeInfSens).HasMaxLength(6);
            modelBuilder.Entity<InfAirePlace>().Property(item => item.ChausseeInfSens).HasColumnName("CHAUSSEE_INF__SENS");
            modelBuilder.Entity<InfAirePlace>().Property(item => item.AireInfAbsDeb).IsRequired();
            modelBuilder.Entity<InfAirePlace>().Property(item => item.AireInfAbsDeb).HasColumnName("AIRE_INF__ABS_DEB");
            modelBuilder.Entity<InfAirePlace>().Property(item => item.Nbre).HasColumnName("NBRE");
        }
    }
}
