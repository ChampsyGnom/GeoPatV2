using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextEqp : DataContextBase
    {
        public DataContextEqp(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<EqpCdTypeSv> EqpCdTypeSvs { get; set; }
        
        public DbSet<EqpCdFamSv> EqpCdFamSvs { get; set; }
        
        public DbSet<EqpCls> EqpClss { get; set; }
        
        public DbSet<EqpDoc> EqpDocs { get; set; }
        
        public DbSet<EqpCdDoc> EqpCdDocs { get; set; }
        
        public DbSet<EqpNatureTrav> EqpNatureTravs { get; set; }
        
        public DbSet<EqpSysUser> EqpSysUsers { get; set; }
        
        public DbSet<EqpBpu> EqpBpus { get; set; }
        
        public DbSet<EqpCdTravaux> EqpCdTravauxs { get; set; }
        
        public DbSet<EqpCdStypeSv> EqpCdStypeSvs { get; set; }
        
        public DbSet<EqpDictionnaire> EqpDictionnaires { get; set; }
        
        public DbSet<EqpCdEvt> EqpCdEvts { get; set; }
        
        public DbSet<EqpDscSv> EqpDscSvs { get; set; }
        
        public DbSet<EqpCdFabricant> EqpCdFabricants { get; set; }
        
        public DbSet<EqpCdProtect> EqpCdProtects { get; set; }
        
        public DbSet<EqpCdClasseSv> EqpCdClasseSvs { get; set; }
        
        public DbSet<EqpCdGammeSv> EqpCdGammeSvs { get; set; }
        
        public DbSet<EqpCdSupportSv> EqpCdSupportSvs { get; set; }
        
        public DbSet<EqpCdFondation> EqpCdFondations { get; set; }
        
        public DbSet<EqpDscSh> EqpDscShs { get; set; }
        
        public DbSet<EqpDscEs> EqpDscEss { get; set; }
        
        public DbSet<EqpCdProduitSh> EqpCdProduitShs { get; set; }
        
        public DbSet<EqpCdBarretteSh> EqpCdBarretteShs { get; set; }
        
        public DbSet<EqpCdMarquageSh> EqpCdMarquageShs { get; set; }
        
        public DbSet<EqpCdModSh> EqpCdModShs { get; set; }
        
        public DbSet<EqpCdType> EqpCdTypes { get; set; }
        
        public DbSet<EqpCdRetenue> EqpCdRetenues { get; set; }
        
        public DbSet<EqpCdMateriau> EqpCdMateriaus { get; set; }
        
        public DbSet<EqpCdExtAm> EqpCdExtAms { get; set; }
        
        public DbSet<EqpCdExtAv> EqpCdExtAvs { get; set; }
        
        public DbSet<EqpDscPo> EqpDscPos { get; set; }
        
        public DbSet<EqpCdPortail> EqpCdPortails { get; set; }
        
        public DbSet<EqpDscCl> EqpDscCls { get; set; }
        
        public DbSet<EqpCdCloture> EqpCdClotures { get; set; }
        
        public DbSet<EqpCdMaille> EqpCdMailles { get; set; }
        
        public DbSet<EqpCdFranch> EqpCdFranchs { get; set; }
        
        public DbSet<EqpCdPoteauCl> EqpCdPoteauCls { get; set; }
        
        public DbSet<EqpPanneau> EqpPanneaus { get; set; }
        
        public DbSet<EqpTravaux> EqpTravauxs { get; set; }
        
        public DbSet<EqpPrevision> EqpPrevisions { get; set; }
        
        public DbSet<EqpEvt> EqpEvts { get; set; }
        
        public DbSet<EqpCdEntp> EqpCdEntps { get; set; }
        
        public DbSet<EqpCdPosit> EqpCdPosits { get; set; }
        
        public DbSet<EqpCdMatSv> EqpCdMatSvs { get; set; }
        
        public DbSet<EqpCdContrainte> EqpCdContraintes { get; set; }
        
        public DbSet<EqpCdTypeDv> EqpCdTypeDvs { get; set; }
        
        public DbSet<EqpDscDv> EqpDscDvs { get; set; }
        
        public DbSet<EqpContact> EqpContacts { get; set; }
        
        public DbSet<EqpClsDoc> EqpClsDocs { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<EqpCdTypeSv>().HasRequired<EqpCdFamSv>(c => c.EqpCdFamSv).WithMany(t => t.EqpCdTypeSvs).HasForeignKey(u => new { u.EqpCdFamSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdTypeSv>().HasMany<EqpCdStypeSv>(c => c.EqpCdStypeSvs).WithRequired(t => t.EqpCdTypeSv).HasForeignKey(u => new {u.EqpCdTypeSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdTypeSv>().ToTable("CD_TYPE_SV_EQP","EQP");
            modelBuilder.Entity<EqpCdTypeSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.CdFamSvEqpFamille).IsRequired();
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.CdFamSvEqpFamille).HasMaxLength(6);
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.CdFamSvEqpFamille).HasColumnName("CD_FAM_SV_EQP__FAMILLE");
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.Type).HasMaxLength(12);
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<EqpCdTypeSv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpCdFamSv>().HasMany<EqpDscSv>(c => c.EqpDscSvs).WithRequired(t => t.EqpCdFamSv).HasForeignKey(u => new {u.EqpCdFamSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFamSv>().HasMany<EqpCdTypeSv>(c => c.EqpCdTypeSvs).WithRequired(t => t.EqpCdFamSv).HasForeignKey(u => new {u.EqpCdFamSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFamSv>().ToTable("CD_FAM_SV_EQP","EQP");
            modelBuilder.Entity<EqpCdFamSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdFamSv>().Property(item => item.Famille).IsRequired();
            modelBuilder.Entity<EqpCdFamSv>().Property(item => item.Famille).HasMaxLength(6);
            modelBuilder.Entity<EqpCdFamSv>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<EqpCdFamSv>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<EqpCdFamSv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpCls>().HasMany<EqpClsDoc>(c => c.EqpClsDocs).WithRequired(t => t.EqpCls).HasForeignKey(u => new {u.EqpClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCls>().ToTable("CLS_EQP","EQP");
            modelBuilder.Entity<EqpCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<EqpCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<EqpCls>().Property(item => item.TableName).IsRequired();
            modelBuilder.Entity<EqpCls>().Property(item => item.TableName).HasMaxLength(30);
            modelBuilder.Entity<EqpCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<EqpCls>().Property(item => item.KeyValue).IsRequired();
            modelBuilder.Entity<EqpCls>().Property(item => item.KeyValue).HasMaxLength(1000);
            modelBuilder.Entity<EqpCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<EqpDoc>().HasRequired<EqpCdDoc>(c => c.EqpCdDoc).WithMany(t => t.EqpDocs).HasForeignKey(u => new { u.EqpCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDoc>().HasMany<EqpContact>(c => c.EqpContacts).WithRequired(t => t.EqpDoc).HasForeignKey(u => new {u.EqpDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDoc>().HasMany<EqpClsDoc>(c => c.EqpClsDocs).WithRequired(t => t.EqpDoc).HasForeignKey(u => new {u.EqpDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDoc>().ToTable("DOC_EQP","EQP");
            modelBuilder.Entity<EqpDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<EqpDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<EqpDoc>().Property(item => item.CdDocEqpCode).IsRequired();
            modelBuilder.Entity<EqpDoc>().Property(item => item.CdDocEqpCode).HasMaxLength(15);
            modelBuilder.Entity<EqpDoc>().Property(item => item.CdDocEqpCode).HasColumnName("CD_DOC_EQP__CODE");
            modelBuilder.Entity<EqpDoc>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<EqpDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpDoc>().Property(item => item.Ref).IsRequired();
            modelBuilder.Entity<EqpDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<EqpDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<EqpCdDoc>().HasMany<EqpDoc>(c => c.EqpDocs).WithRequired(t => t.EqpCdDoc).HasForeignKey(u => new {u.EqpCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdDoc>().ToTable("CD_DOC_EQP","EQP");
            modelBuilder.Entity<EqpCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<EqpCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<EqpCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<EqpCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<EqpCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<EqpCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<EqpNatureTrav>().HasRequired<EqpCdTravaux>(c => c.EqpCdTravaux).WithMany(t => t.EqpNatureTravs).HasForeignKey(u => new { u.EqpCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpNatureTrav>().HasMany<EqpTravaux>(c => c.EqpTravauxs).WithRequired(t => t.EqpNatureTrav).HasForeignKey(u => new {u.EqpNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpNatureTrav>().ToTable("NATURE_TRAV_EQP","EQP");
            modelBuilder.Entity<EqpNatureTrav>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpNatureTrav>().Property(item => item.CdTravauxEqpCode).IsRequired();
            modelBuilder.Entity<EqpNatureTrav>().Property(item => item.CdTravauxEqpCode).HasMaxLength(60);
            modelBuilder.Entity<EqpNatureTrav>().Property(item => item.CdTravauxEqpCode).HasColumnName("CD_TRAVAUX_EQP__CODE");
            modelBuilder.Entity<EqpNatureTrav>().Property(item => item.Nature).IsRequired();
            modelBuilder.Entity<EqpNatureTrav>().Property(item => item.Nature).HasMaxLength(100);
            modelBuilder.Entity<EqpNatureTrav>().Property(item => item.Nature).HasColumnName("NATURE");
            modelBuilder.Entity<EqpSysUser>().ToTable("SYS_USER_EQP","EQP");
            modelBuilder.Entity<EqpSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<EqpSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<EqpSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<EqpSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<EqpSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<EqpSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<EqpSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<EqpSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<EqpBpu>().HasRequired<EqpCdTravaux>(c => c.EqpCdTravaux).WithMany(t => t.EqpBpus).HasForeignKey(u => new { u.EqpCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpBpu>().HasMany<EqpPrevision>(c => c.EqpPrevisions).WithRequired(t => t.EqpBpu).HasForeignKey(u => new {u.EqpBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpBpu>().ToTable("BPU_EQP","EQP");
            modelBuilder.Entity<EqpBpu>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpBpu>().Property(item => item.Techn).IsRequired();
            modelBuilder.Entity<EqpBpu>().Property(item => item.Techn).HasMaxLength(250);
            modelBuilder.Entity<EqpBpu>().Property(item => item.Techn).HasColumnName("TECHN");
            modelBuilder.Entity<EqpBpu>().Property(item => item.CdTravauxEqpCode).IsRequired();
            modelBuilder.Entity<EqpBpu>().Property(item => item.CdTravauxEqpCode).HasMaxLength(60);
            modelBuilder.Entity<EqpBpu>().Property(item => item.CdTravauxEqpCode).HasColumnName("CD_TRAVAUX_EQP__CODE");
            modelBuilder.Entity<EqpBpu>().Property(item => item.Prix).IsRequired();
            modelBuilder.Entity<EqpBpu>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<EqpBpu>().Property(item => item.DateMaj).HasColumnName("DATE_MAJ");
            modelBuilder.Entity<EqpBpu>().Property(item => item.Freq).HasColumnName("FREQ");
            modelBuilder.Entity<EqpCdTravaux>().HasMany<EqpNatureTrav>(c => c.EqpNatureTravs).WithRequired(t => t.EqpCdTravaux).HasForeignKey(u => new {u.EqpCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdTravaux>().HasMany<EqpBpu>(c => c.EqpBpus).WithRequired(t => t.EqpCdTravaux).HasForeignKey(u => new {u.EqpCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdTravaux>().ToTable("CD_TRAVAUX_EQP","EQP");
            modelBuilder.Entity<EqpCdTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdTravaux>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<EqpCdTravaux>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<EqpCdTravaux>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<EqpCdStypeSv>().HasRequired<EqpCdTypeSv>(c => c.EqpCdTypeSv).WithMany(t => t.EqpCdStypeSvs).HasForeignKey(u => new { u.EqpCdTypeSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdStypeSv>().HasMany<EqpPanneau>(c => c.EqpPanneaus).WithRequired(t => t.EqpCdStypeSv).HasForeignKey(u => new {u.EqpCdStypeSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdStypeSv>().ToTable("CD_STYPE_SV_EQP","EQP");
            modelBuilder.Entity<EqpCdStypeSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.CdFamSvEqpFamille).IsRequired();
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.CdFamSvEqpFamille).HasMaxLength(6);
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.CdFamSvEqpFamille).HasColumnName("CD_FAM_SV_EQP__FAMILLE");
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.CdTypeSvEqpType).IsRequired();
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.CdTypeSvEqpType).HasMaxLength(12);
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.CdTypeSvEqpType).HasColumnName("CD_TYPE_SV_EQP__TYPE");
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.SType).IsRequired();
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.SType).HasMaxLength(60);
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.SType).HasColumnName("S_TYPE");
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.NOrdre).IsRequired();
            modelBuilder.Entity<EqpCdStypeSv>().Property(item => item.NOrdre).HasColumnName("N_ORDRE");
            modelBuilder.Entity<EqpDictionnaire>().ToTable("DICTIONNAIRE_EQP","EQP");
            modelBuilder.Entity<EqpDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Definition).HasMaxLength(1000);
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Definition).HasColumnName("DEFINITION");
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<EqpDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<EqpCdEvt>().HasMany<EqpEvt>(c => c.EqpEvts).WithRequired(t => t.EqpCdEvt).HasForeignKey(u => new {u.EqpCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEvt>().ToTable("CD_EVT_EQP","EQP");
            modelBuilder.Entity<EqpCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<EqpCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<EqpCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<EqpCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<EqpCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<EqpDscSv>().HasOptional<EqpCdEntp>(c => c.EqpCdEntp).WithMany(t => t.EqpDscSvs).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSv>().HasRequired<EqpCdPosit>(c => c.EqpCdPosit).WithMany(t => t.EqpDscSvs).HasForeignKey(u => new { u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSv>().HasOptional<EqpCdProtect>(c => c.EqpCdProtect).WithMany(t => t.EqpDscSvs).HasForeignKey(u => new {u.EqpCdProtectIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSv>().HasOptional<EqpCdSupportSv>(c => c.EqpCdSupportSv).WithMany(t => t.EqpDscSvs).HasForeignKey(u => new {u.EqpCdSupportSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSv>().HasOptional<EqpCdFondation>(c => c.EqpCdFondation).WithMany(t => t.EqpDscSvs).HasForeignKey(u => new {u.EqpCdFondationIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSv>().HasRequired<EqpCdFamSv>(c => c.EqpCdFamSv).WithMany(t => t.EqpDscSvs).HasForeignKey(u => new { u.EqpCdFamSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSv>().HasMany<EqpPanneau>(c => c.EqpPanneaus).WithRequired(t => t.EqpDscSv).HasForeignKey(u => new {u.EqpDscSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSv>().ToTable("DSC_SV_EQP","EQP");
            modelBuilder.Entity<EqpDscSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdPositEqpPosit).IsRequired();
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.NumExploit).IsRequired();
            modelBuilder.Entity<EqpDscSv>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdFondationEqpFondation).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdFondationEqpFondation).HasColumnName("CD_FONDATION_EQP__FONDATION");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdEntpEqpEntreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdEntpEqpEntreprise).HasColumnName("CD_ENTP_EQP__ENTREPRISE");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdSupportSvEqpSupport).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdSupportSvEqpSupport).HasColumnName("CD_SUPPORT_SV_EQP__SUPPORT");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdProtectEqpProtect).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdProtectEqpProtect).HasColumnName("CD_PROTECT_EQP__PROTECT");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdFamSvEqpFamille).IsRequired();
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdFamSvEqpFamille).HasMaxLength(6);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.CdFamSvEqpFamille).HasColumnName("CD_FAM_SV_EQP__FAMILLE");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<EqpDscSv>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Massif).HasMaxLength(20);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Massif).HasColumnName("MASSIF");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.NbreSupport).HasColumnName("NBRE_SUPPORT");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Resist).HasColumnName("RESIST");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.EclairageValueInt).HasColumnName("ECLAIRAGE");
            modelBuilder.Entity<EqpDscSv>().Ignore(item => item.Eclairage);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.AccessibiliteValueInt).HasColumnName("ACCESSIBILITE");
            modelBuilder.Entity<EqpDscSv>().Ignore(item => item.Accessibilite);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.HauteurSp).HasColumnName("HAUTEUR_SP");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<EqpDscSv>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<EqpDscSv>().Ignore(item => item.Terrain);
            modelBuilder.Entity<EqpCdFabricant>().HasMany<EqpDscSh>(c => c.EqpDscShs).WithOptional(t => t.EqpCdFabricant).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFabricant>().HasMany<EqpDscPo>(c => c.EqpDscPos).WithOptional(t => t.EqpCdFabricant).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFabricant>().HasMany<EqpPanneau>(c => c.EqpPanneaus).WithOptional(t => t.EqpCdFabricant).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFabricant>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithOptional(t => t.EqpCdFabricant).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFabricant>().HasMany<EqpDscEs>(c => c.EqpDscEss).WithOptional(t => t.EqpCdFabricant).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFabricant>().HasMany<EqpDscDv>(c => c.EqpDscDvs).WithOptional(t => t.EqpCdFabricant).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFabricant>().ToTable("CD_FABRICANT_EQP","EQP");
            modelBuilder.Entity<EqpCdFabricant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdFabricant>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<EqpCdFabricant>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<EqpCdFabricant>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<EqpCdProtect>().HasMany<EqpDscSv>(c => c.EqpDscSvs).WithOptional(t => t.EqpCdProtect).HasForeignKey(u => new {u.EqpCdProtectIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdProtect>().ToTable("CD_PROTECT_EQP","EQP");
            modelBuilder.Entity<EqpCdProtect>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdProtect>().Property(item => item.Protect).IsRequired();
            modelBuilder.Entity<EqpCdProtect>().Property(item => item.Protect).HasMaxLength(60);
            modelBuilder.Entity<EqpCdProtect>().Property(item => item.Protect).HasColumnName("PROTECT");
            modelBuilder.Entity<EqpCdClasseSv>().HasMany<EqpPanneau>(c => c.EqpPanneaus).WithOptional(t => t.EqpCdClasseSv).HasForeignKey(u => new {u.EqpCdClasseSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdClasseSv>().ToTable("CD_CLASSE_SV_EQP","EQP");
            modelBuilder.Entity<EqpCdClasseSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdClasseSv>().Property(item => item.Classe).IsRequired();
            modelBuilder.Entity<EqpCdClasseSv>().Property(item => item.Classe).HasMaxLength(5);
            modelBuilder.Entity<EqpCdClasseSv>().Property(item => item.Classe).HasColumnName("CLASSE");
            modelBuilder.Entity<EqpCdGammeSv>().HasMany<EqpPanneau>(c => c.EqpPanneaus).WithOptional(t => t.EqpCdGammeSv).HasForeignKey(u => new {u.EqpCdGammeSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdGammeSv>().ToTable("CD_GAMME_SV_EQP","EQP");
            modelBuilder.Entity<EqpCdGammeSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdGammeSv>().Property(item => item.Gamme).IsRequired();
            modelBuilder.Entity<EqpCdGammeSv>().Property(item => item.Gamme).HasMaxLength(20);
            modelBuilder.Entity<EqpCdGammeSv>().Property(item => item.Gamme).HasColumnName("GAMME");
            modelBuilder.Entity<EqpCdGammeSv>().Property(item => item.Dimension).HasColumnName("DIMENSION");
            modelBuilder.Entity<EqpCdSupportSv>().HasMany<EqpDscSv>(c => c.EqpDscSvs).WithOptional(t => t.EqpCdSupportSv).HasForeignKey(u => new {u.EqpCdSupportSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdSupportSv>().ToTable("CD_SUPPORT_SV_EQP","EQP");
            modelBuilder.Entity<EqpCdSupportSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdSupportSv>().Property(item => item.Support).IsRequired();
            modelBuilder.Entity<EqpCdSupportSv>().Property(item => item.Support).HasMaxLength(60);
            modelBuilder.Entity<EqpCdSupportSv>().Property(item => item.Support).HasColumnName("SUPPORT");
            modelBuilder.Entity<EqpCdSupportSv>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<EqpCdSupportSv>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<EqpCdFondation>().HasMany<EqpDscSv>(c => c.EqpDscSvs).WithOptional(t => t.EqpCdFondation).HasForeignKey(u => new {u.EqpCdFondationIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFondation>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithOptional(t => t.EqpCdFondation).HasForeignKey(u => new {u.EqpCdFondationIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFondation>().ToTable("CD_FONDATION_EQP","EQP");
            modelBuilder.Entity<EqpCdFondation>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdFondation>().Property(item => item.Fondation).IsRequired();
            modelBuilder.Entity<EqpCdFondation>().Property(item => item.Fondation).HasMaxLength(60);
            modelBuilder.Entity<EqpCdFondation>().Property(item => item.Fondation).HasColumnName("FONDATION");
            modelBuilder.Entity<EqpDscSh>().HasOptional<EqpCdEntp>(c => c.EqpCdEntp).WithMany(t => t.EqpDscShs).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSh>().HasOptional<EqpCdFabricant>(c => c.EqpCdFabricant).WithMany(t => t.EqpDscShs).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSh>().HasOptional<EqpCdProduitSh>(c => c.EqpCdProduitSh).WithMany(t => t.EqpDscShs).HasForeignKey(u => new {u.EqpCdProduitShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSh>().HasOptional<EqpCdBarretteSh>(c => c.EqpCdBarretteSh).WithMany(t => t.EqpDscShs).HasForeignKey(u => new {u.EqpCdBarretteShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSh>().HasRequired<EqpCdMarquageSh>(c => c.EqpCdMarquageSh).WithMany(t => t.EqpDscShs).HasForeignKey(u => new { u.EqpCdMarquageShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSh>().HasRequired<EqpCdPosit>(c => c.EqpCdPosit).WithMany(t => t.EqpDscShs).HasForeignKey(u => new { u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscSh>().ToTable("DSC_SH_EQP","EQP");
            modelBuilder.Entity<EqpDscSh>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdPositEqpPosit).IsRequired();
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<EqpDscSh>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdModShEqpMod).IsRequired();
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdModShEqpMod).HasMaxLength(6);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdModShEqpMod).HasColumnName("CD_MOD_SH_EQP__MOD");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdMarquageShEqpMarquage).IsRequired();
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdMarquageShEqpMarquage).HasMaxLength(255);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdMarquageShEqpMarquage).HasColumnName("CD_MARQUAGE_SH_EQP__MARQUAGE");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdEntpEqpEntreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdEntpEqpEntreprise).HasColumnName("CD_ENTP_EQP__ENTREPRISE");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdBarretteShEqpBarette).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdBarretteShEqpBarette).HasColumnName("CD_BARRETTE_SH_EQP__BARETTE");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdProduitShEqpProduit).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdProduitShEqpProduit).HasColumnName("CD_PRODUIT_SH_EQP__PRODUIT");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdFabricantEqpNom).HasMaxLength(60);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.CdFabricantEqpNom).HasColumnName("CD_FABRICANT_EQP__NOM");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.RevetementVntpValueInt).HasColumnName("REVETEMENT_VNTP");
            modelBuilder.Entity<EqpDscSh>().Ignore(item => item.RevetementVntp);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.SaupoudrageValueInt).HasColumnName("SAUPOUDRAGE");
            modelBuilder.Entity<EqpDscSh>().Ignore(item => item.Saupoudrage);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<EqpDscSh>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<EqpDscSh>().Ignore(item => item.Terrain);
            modelBuilder.Entity<EqpDscEs>().HasRequired<EqpCdPosit>(c => c.EqpCdPosit).WithMany(t => t.EqpDscEss).HasForeignKey(u => new { u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscEs>().HasOptional<EqpCdEntp>(c => c.EqpCdEntp).WithMany(t => t.EqpDscEss).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscEs>().HasRequired<EqpCdRetenue>(c => c.EqpCdRetenue).WithMany(t => t.EqpDscEss).HasForeignKey(u => new { u.EqpCdRetenueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscEs>().HasOptional<EqpCdExtAm>(c => c.EqpCdExtAm).WithMany(t => t.EqpDscEss).HasForeignKey(u => new {u.EqpCdExtAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscEs>().HasOptional<EqpCdExtAv>(c => c.EqpCdExtAv).WithMany(t => t.EqpDscEss).HasForeignKey(u => new {u.EqpCdExtAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscEs>().HasOptional<EqpCdFabricant>(c => c.EqpCdFabricant).WithMany(t => t.EqpDscEss).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscEs>().ToTable("DSC_ES_EQP","EQP");
            modelBuilder.Entity<EqpDscEs>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdPositEqpPosit).IsRequired();
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<EqpDscEs>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdEntpEqpEntreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdEntpEqpEntreprise).HasColumnName("CD_ENTP_EQP__ENTREPRISE");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdExtAvEqpExtFin).HasMaxLength(60);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdExtAvEqpExtFin).HasColumnName("CD_EXT_AV_EQP__EXT_FIN");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdFabricantEqpNom).HasMaxLength(60);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdFabricantEqpNom).HasColumnName("CD_FABRICANT_EQP__NOM");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdMateriauEqpMateriaux).IsRequired();
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdMateriauEqpMateriaux).HasMaxLength(60);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdMateriauEqpMateriaux).HasColumnName("CD_MATERIAU_EQP__MATERIAUX");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdRetenueEqpDispositif).IsRequired();
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdRetenueEqpDispositif).HasMaxLength(60);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdRetenueEqpDispositif).HasColumnName("CD_RETENUE_EQP__DISPOSITIF");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdExtAmEqpExtDeb).HasMaxLength(60);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.CdExtAmEqpExtDeb).HasColumnName("CD_EXT_AM_EQP__EXT_DEB");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<EqpDscEs>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<EqpDscEs>().Ignore(item => item.Terrain);
            modelBuilder.Entity<EqpCdProduitSh>().HasMany<EqpDscSh>(c => c.EqpDscShs).WithOptional(t => t.EqpCdProduitSh).HasForeignKey(u => new {u.EqpCdProduitShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdProduitSh>().ToTable("CD_PRODUIT_SH_EQP","EQP");
            modelBuilder.Entity<EqpCdProduitSh>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdProduitSh>().Property(item => item.Produit).IsRequired();
            modelBuilder.Entity<EqpCdProduitSh>().Property(item => item.Produit).HasMaxLength(60);
            modelBuilder.Entity<EqpCdProduitSh>().Property(item => item.Produit).HasColumnName("PRODUIT");
            modelBuilder.Entity<EqpCdProduitSh>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<EqpCdProduitSh>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<EqpCdBarretteSh>().HasMany<EqpDscSh>(c => c.EqpDscShs).WithOptional(t => t.EqpCdBarretteSh).HasForeignKey(u => new {u.EqpCdBarretteShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdBarretteSh>().ToTable("CD_BARRETTE_SH_EQP","EQP");
            modelBuilder.Entity<EqpCdBarretteSh>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdBarretteSh>().Property(item => item.Barette).IsRequired();
            modelBuilder.Entity<EqpCdBarretteSh>().Property(item => item.Barette).HasMaxLength(60);
            modelBuilder.Entity<EqpCdBarretteSh>().Property(item => item.Barette).HasColumnName("BARETTE");
            modelBuilder.Entity<EqpCdMarquageSh>().HasRequired<EqpCdModSh>(c => c.EqpCdModSh).WithMany(t => t.EqpCdMarquageShs).HasForeignKey(u => new { u.EqpCdModShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdMarquageSh>().HasMany<EqpDscSh>(c => c.EqpDscShs).WithRequired(t => t.EqpCdMarquageSh).HasForeignKey(u => new {u.EqpCdMarquageShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdMarquageSh>().ToTable("CD_MARQUAGE_SH_EQP","EQP");
            modelBuilder.Entity<EqpCdMarquageSh>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdMarquageSh>().Property(item => item.CdModShEqpMod).IsRequired();
            modelBuilder.Entity<EqpCdMarquageSh>().Property(item => item.CdModShEqpMod).HasMaxLength(6);
            modelBuilder.Entity<EqpCdMarquageSh>().Property(item => item.CdModShEqpMod).HasColumnName("CD_MOD_SH_EQP__MOD");
            modelBuilder.Entity<EqpCdMarquageSh>().Property(item => item.Marquage).IsRequired();
            modelBuilder.Entity<EqpCdMarquageSh>().Property(item => item.Marquage).HasMaxLength(255);
            modelBuilder.Entity<EqpCdMarquageSh>().Property(item => item.Marquage).HasColumnName("MARQUAGE");
            modelBuilder.Entity<EqpCdMarquageSh>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<EqpCdModSh>().HasMany<EqpCdMarquageSh>(c => c.EqpCdMarquageShs).WithRequired(t => t.EqpCdModSh).HasForeignKey(u => new {u.EqpCdModShIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdModSh>().ToTable("CD_MOD_SH_EQP","EQP");
            modelBuilder.Entity<EqpCdModSh>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdModSh>().Property(item => item.Mod).IsRequired();
            modelBuilder.Entity<EqpCdModSh>().Property(item => item.Mod).HasMaxLength(6);
            modelBuilder.Entity<EqpCdModSh>().Property(item => item.Mod).HasColumnName("MOD");
            modelBuilder.Entity<EqpCdModSh>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<EqpCdModSh>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpCdType>().HasMany<EqpTravaux>(c => c.EqpTravauxs).WithRequired(t => t.EqpCdType).HasForeignKey(u => new {u.EqpCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdType>().HasMany<EqpPrevision>(c => c.EqpPrevisions).WithRequired(t => t.EqpCdType).HasForeignKey(u => new {u.EqpCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdType>().HasMany<EqpEvt>(c => c.EqpEvts).WithRequired(t => t.EqpCdType).HasForeignKey(u => new {u.EqpCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdType>().ToTable("CD_TYPE_EQP","EQP");
            modelBuilder.Entity<EqpCdType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdType>().Property(item => item.TypeEquip).IsRequired();
            modelBuilder.Entity<EqpCdType>().Property(item => item.TypeEquip).HasMaxLength(6);
            modelBuilder.Entity<EqpCdType>().Property(item => item.TypeEquip).HasColumnName("TYPE_EQUIP");
            modelBuilder.Entity<EqpCdType>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<EqpCdType>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpCdRetenue>().HasRequired<EqpCdMateriau>(c => c.EqpCdMateriau).WithMany(t => t.EqpCdRetenues).HasForeignKey(u => new { u.EqpCdMateriauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdRetenue>().HasMany<EqpDscEs>(c => c.EqpDscEss).WithRequired(t => t.EqpCdRetenue).HasForeignKey(u => new {u.EqpCdRetenueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdRetenue>().ToTable("CD_RETENUE_EQP","EQP");
            modelBuilder.Entity<EqpCdRetenue>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.CdMateriauEqpMateriaux).IsRequired();
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.CdMateriauEqpMateriaux).HasMaxLength(60);
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.CdMateriauEqpMateriaux).HasColumnName("CD_MATERIAU_EQP__MATERIAUX");
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.Dispositif).IsRequired();
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.Dispositif).HasMaxLength(60);
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.Dispositif).HasColumnName("DISPOSITIF");
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<EqpCdRetenue>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<EqpCdMateriau>().HasMany<EqpCdRetenue>(c => c.EqpCdRetenues).WithRequired(t => t.EqpCdMateriau).HasForeignKey(u => new {u.EqpCdMateriauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdMateriau>().ToTable("CD_MATERIAU_EQP","EQP");
            modelBuilder.Entity<EqpCdMateriau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdMateriau>().Property(item => item.Materiaux).IsRequired();
            modelBuilder.Entity<EqpCdMateriau>().Property(item => item.Materiaux).HasMaxLength(60);
            modelBuilder.Entity<EqpCdMateriau>().Property(item => item.Materiaux).HasColumnName("MATERIAUX");
            modelBuilder.Entity<EqpCdExtAm>().HasMany<EqpDscEs>(c => c.EqpDscEss).WithOptional(t => t.EqpCdExtAm).HasForeignKey(u => new {u.EqpCdExtAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdExtAm>().ToTable("CD_EXT_AM_EQP","EQP");
            modelBuilder.Entity<EqpCdExtAm>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdExtAm>().Property(item => item.ExtDeb).IsRequired();
            modelBuilder.Entity<EqpCdExtAm>().Property(item => item.ExtDeb).HasMaxLength(60);
            modelBuilder.Entity<EqpCdExtAm>().Property(item => item.ExtDeb).HasColumnName("EXT_DEB");
            modelBuilder.Entity<EqpCdExtAv>().HasMany<EqpDscEs>(c => c.EqpDscEss).WithOptional(t => t.EqpCdExtAv).HasForeignKey(u => new {u.EqpCdExtAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdExtAv>().ToTable("CD_EXT_AV_EQP","EQP");
            modelBuilder.Entity<EqpCdExtAv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdExtAv>().Property(item => item.ExtFin).IsRequired();
            modelBuilder.Entity<EqpCdExtAv>().Property(item => item.ExtFin).HasMaxLength(60);
            modelBuilder.Entity<EqpCdExtAv>().Property(item => item.ExtFin).HasColumnName("EXT_FIN");
            modelBuilder.Entity<EqpDscPo>().HasRequired<EqpCdPortail>(c => c.EqpCdPortail).WithMany(t => t.EqpDscPos).HasForeignKey(u => new { u.EqpCdPortailIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscPo>().HasOptional<EqpCdFabricant>(c => c.EqpCdFabricant).WithMany(t => t.EqpDscPos).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscPo>().HasOptional<EqpCdEntp>(c => c.EqpCdEntp).WithMany(t => t.EqpDscPos).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscPo>().HasOptional<EqpCdPosit>(c => c.EqpCdPosit).WithMany(t => t.EqpDscPos).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscPo>().ToTable("DSC_PO_EQP","EQP");
            modelBuilder.Entity<EqpDscPo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDscPo>().Property(item => item.NumExploit).IsRequired();
            modelBuilder.Entity<EqpDscPo>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdEntpEqpEntreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdEntpEqpEntreprise).HasColumnName("CD_ENTP_EQP__ENTREPRISE");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdPortailEqpPortail).IsRequired();
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdPortailEqpPortail).HasMaxLength(60);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdPortailEqpPortail).HasColumnName("CD_PORTAIL_EQP__PORTAIL");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdFabricantEqpNom).HasMaxLength(60);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdFabricantEqpNom).HasColumnName("CD_FABRICANT_EQP__NOM");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<EqpDscPo>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Hauteur).HasColumnName("HAUTEUR");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.DispoAccesValueInt).HasColumnName("DISPO_ACCES");
            modelBuilder.Entity<EqpDscPo>().Ignore(item => item.DispoAcces);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<EqpDscPo>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<EqpDscPo>().Ignore(item => item.Terrain);
            modelBuilder.Entity<EqpCdPortail>().HasMany<EqpDscPo>(c => c.EqpDscPos).WithRequired(t => t.EqpCdPortail).HasForeignKey(u => new {u.EqpCdPortailIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPortail>().ToTable("CD_PORTAIL_EQP","EQP");
            modelBuilder.Entity<EqpCdPortail>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdPortail>().Property(item => item.Portail).IsRequired();
            modelBuilder.Entity<EqpCdPortail>().Property(item => item.Portail).HasMaxLength(60);
            modelBuilder.Entity<EqpCdPortail>().Property(item => item.Portail).HasColumnName("PORTAIL");
            modelBuilder.Entity<EqpCdPortail>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<EqpCdPortail>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<EqpDscCl>().HasOptional<EqpCdCloture>(c => c.EqpCdCloture).WithMany(t => t.EqpDscCls).HasForeignKey(u => new {u.EqpCdClotureIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().HasOptional<EqpCdMaille>(c => c.EqpCdMaille).WithMany(t => t.EqpDscCls).HasForeignKey(u => new {u.EqpCdMailleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().HasOptional<EqpCdFranch>(c => c.EqpCdFranch).WithMany(t => t.EqpDscCls).HasForeignKey(u => new {u.EqpCdFranchIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().HasOptional<EqpCdPoteauCl>(c => c.EqpCdPoteauCl).WithMany(t => t.EqpDscCls).HasForeignKey(u => new {u.EqpCdPoteauClIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().HasOptional<EqpCdFondation>(c => c.EqpCdFondation).WithMany(t => t.EqpDscCls).HasForeignKey(u => new {u.EqpCdFondationIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().HasOptional<EqpCdEntp>(c => c.EqpCdEntp).WithMany(t => t.EqpDscCls).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().HasOptional<EqpCdFabricant>(c => c.EqpCdFabricant).WithMany(t => t.EqpDscCls).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().HasRequired<EqpCdPosit>(c => c.EqpCdPosit).WithMany(t => t.EqpDscCls).HasForeignKey(u => new { u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscCl>().ToTable("DSC_CL_EQP","EQP");
            modelBuilder.Entity<EqpDscCl>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdPositEqpPosit).IsRequired();
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<EqpDscCl>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdFondationEqpFondation).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdFondationEqpFondation).HasColumnName("CD_FONDATION_EQP__FONDATION");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdMailleEqpMaille).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdMailleEqpMaille).HasColumnName("CD_MAILLE_EQP__MAILLE");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdEntpEqpEntreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdEntpEqpEntreprise).HasColumnName("CD_ENTP_EQP__ENTREPRISE");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdFabricantEqpNom).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdFabricantEqpNom).HasColumnName("CD_FABRICANT_EQP__NOM");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdPoteauClEqpPoteaux).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdPoteauClEqpPoteaux).HasColumnName("CD_POTEAU_CL_EQP__POTEAUX");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdFranchEqpAntiFranch).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdFranchEqpAntiFranch).HasColumnName("CD_FRANCH_EQP__ANTI_FRANCH");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdClotureEqpCloture).HasMaxLength(60);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.CdClotureEqpCloture).HasColumnName("CD_CLOTURE_EQP__CLOTURE");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Hauteur).HasColumnName("HAUTEUR");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Distance).HasColumnName("DISTANCE");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<EqpDscCl>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<EqpDscCl>().Ignore(item => item.Terrain);
            modelBuilder.Entity<EqpCdCloture>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithOptional(t => t.EqpCdCloture).HasForeignKey(u => new {u.EqpCdClotureIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdCloture>().ToTable("CD_CLOTURE_EQP","EQP");
            modelBuilder.Entity<EqpCdCloture>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdCloture>().Property(item => item.Cloture).IsRequired();
            modelBuilder.Entity<EqpCdCloture>().Property(item => item.Cloture).HasMaxLength(60);
            modelBuilder.Entity<EqpCdCloture>().Property(item => item.Cloture).HasColumnName("CLOTURE");
            modelBuilder.Entity<EqpCdCloture>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<EqpCdCloture>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<EqpCdMaille>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithOptional(t => t.EqpCdMaille).HasForeignKey(u => new {u.EqpCdMailleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdMaille>().ToTable("CD_MAILLE_EQP","EQP");
            modelBuilder.Entity<EqpCdMaille>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdMaille>().Property(item => item.Maille).IsRequired();
            modelBuilder.Entity<EqpCdMaille>().Property(item => item.Maille).HasMaxLength(60);
            modelBuilder.Entity<EqpCdMaille>().Property(item => item.Maille).HasColumnName("MAILLE");
            modelBuilder.Entity<EqpCdFranch>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithOptional(t => t.EqpCdFranch).HasForeignKey(u => new {u.EqpCdFranchIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdFranch>().ToTable("CD_FRANCH_EQP","EQP");
            modelBuilder.Entity<EqpCdFranch>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdFranch>().Property(item => item.AntiFranch).IsRequired();
            modelBuilder.Entity<EqpCdFranch>().Property(item => item.AntiFranch).HasMaxLength(60);
            modelBuilder.Entity<EqpCdFranch>().Property(item => item.AntiFranch).HasColumnName("ANTI_FRANCH");
            modelBuilder.Entity<EqpCdPoteauCl>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithOptional(t => t.EqpCdPoteauCl).HasForeignKey(u => new {u.EqpCdPoteauClIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPoteauCl>().ToTable("CD_POTEAU_CL_EQP","EQP");
            modelBuilder.Entity<EqpCdPoteauCl>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdPoteauCl>().Property(item => item.Poteaux).IsRequired();
            modelBuilder.Entity<EqpCdPoteauCl>().Property(item => item.Poteaux).HasMaxLength(60);
            modelBuilder.Entity<EqpCdPoteauCl>().Property(item => item.Poteaux).HasColumnName("POTEAUX");
            modelBuilder.Entity<EqpPanneau>().HasOptional<EqpCdFabricant>(c => c.EqpCdFabricant).WithMany(t => t.EqpPanneaus).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPanneau>().HasOptional<EqpCdClasseSv>(c => c.EqpCdClasseSv).WithMany(t => t.EqpPanneaus).HasForeignKey(u => new {u.EqpCdClasseSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPanneau>().HasOptional<EqpCdGammeSv>(c => c.EqpCdGammeSv).WithMany(t => t.EqpPanneaus).HasForeignKey(u => new {u.EqpCdGammeSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPanneau>().HasRequired<EqpDscSv>(c => c.EqpDscSv).WithMany(t => t.EqpPanneaus).HasForeignKey(u => new { u.EqpDscSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPanneau>().HasRequired<EqpCdStypeSv>(c => c.EqpCdStypeSv).WithMany(t => t.EqpPanneaus).HasForeignKey(u => new { u.EqpCdStypeSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPanneau>().HasOptional<EqpCdMatSv>(c => c.EqpCdMatSv).WithMany(t => t.EqpPanneaus).HasForeignKey(u => new {u.EqpCdMatSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPanneau>().ToTable("PANNEAU_EQP","EQP");
            modelBuilder.Entity<EqpPanneau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdPositEqpPosit).IsRequired();
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.DscSvEqpNumExploit).IsRequired();
            modelBuilder.Entity<EqpPanneau>().Property(item => item.DscSvEqpNumExploit).HasMaxLength(30);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.DscSvEqpNumExploit).HasColumnName("DSC_SV_EQP__NUM_EXPLOIT");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<EqpPanneau>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdFamSvEqpFamille).IsRequired();
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdFamSvEqpFamille).HasMaxLength(6);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdFamSvEqpFamille).HasColumnName("CD_FAM_SV_EQP__FAMILLE");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdTypeSvEqpType).IsRequired();
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdTypeSvEqpType).HasMaxLength(12);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdTypeSvEqpType).HasColumnName("CD_TYPE_SV_EQP__TYPE");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdStypeSvEqpSType).IsRequired();
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdStypeSvEqpSType).HasMaxLength(60);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdStypeSvEqpSType).HasColumnName("CD_STYPE_SV_EQP__S_TYPE");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdGammeSvEqpGamme).HasMaxLength(20);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdGammeSvEqpGamme).HasColumnName("CD_GAMME_SV_EQP__GAMME");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdClasseSvEqpClasse).HasMaxLength(5);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdClasseSvEqpClasse).HasColumnName("CD_CLASSE_SV_EQP__CLASSE");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdMatSvEqpMateriaux).HasMaxLength(60);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdMatSvEqpMateriaux).HasColumnName("CD_MAT_SV_EQP__MATERIAUX");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdFabricantEqpNom).HasMaxLength(60);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.CdFabricantEqpNom).HasColumnName("CD_FABRICANT_EQP__NOM");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.Hauteur).HasColumnName("HAUTEUR");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.Reserve).HasColumnName("RESERVE");
            modelBuilder.Entity<EqpPanneau>().Property(item => item.AntiGraffitiValueInt).HasColumnName("ANTI_GRAFFITI");
            modelBuilder.Entity<EqpPanneau>().Ignore(item => item.AntiGraffiti);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.Mention).HasMaxLength(255);
            modelBuilder.Entity<EqpPanneau>().Property(item => item.Mention).HasColumnName("MENTION");
            modelBuilder.Entity<EqpTravaux>().HasRequired<EqpNatureTrav>(c => c.EqpNatureTrav).WithMany(t => t.EqpTravauxs).HasForeignKey(u => new { u.EqpNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpTravaux>().HasRequired<EqpCdEntp>(c => c.EqpCdEntp).WithMany(t => t.EqpTravauxs).HasForeignKey(u => new { u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpTravaux>().HasRequired<EqpCdType>(c => c.EqpCdType).WithMany(t => t.EqpTravauxs).HasForeignKey(u => new { u.EqpCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpTravaux>().ToTable("TRAVAUX_EQP","EQP");
            modelBuilder.Entity<EqpTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdTravauxEqpCode).IsRequired();
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdTravauxEqpCode).HasMaxLength(60);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdTravauxEqpCode).HasColumnName("CD_TRAVAUX_EQP__CODE");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.NatureTravEqpNature).IsRequired();
            modelBuilder.Entity<EqpTravaux>().Property(item => item.NatureTravEqpNature).HasMaxLength(100);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.NatureTravEqpNature).HasColumnName("NATURE_TRAV_EQP__NATURE");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdTypeEqpTypeEquip).IsRequired();
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdTypeEqpTypeEquip).HasMaxLength(6);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdTypeEqpTypeEquip).HasColumnName("CD_TYPE_EQP__TYPE_EQUIP");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.IdTrav).IsRequired();
            modelBuilder.Entity<EqpTravaux>().Property(item => item.IdTrav).HasColumnName("ID_TRAV");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdEntpEqpEntreprise).IsRequired();
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdEntpEqpEntreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.CdEntpEqpEntreprise).HasColumnName("CD_ENTP_EQP__ENTREPRISE");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Ouvrage).HasMaxLength(30);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Ouvrage).HasColumnName("OUVRAGE");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Position).HasMaxLength(60);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Position).HasColumnName("POSITION");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.DateRcp).HasColumnName("DATE_RCP");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.DateFinGar).HasColumnName("DATE_FIN_GAR");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Marche).HasMaxLength(25);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Marche).HasColumnName("MARCHE");
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<EqpTravaux>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpPrevision>().HasRequired<EqpBpu>(c => c.EqpBpu).WithMany(t => t.EqpPrevisions).HasForeignKey(u => new { u.EqpBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPrevision>().HasRequired<EqpCdType>(c => c.EqpCdType).WithMany(t => t.EqpPrevisions).HasForeignKey(u => new { u.EqpCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPrevision>().HasOptional<EqpCdContrainte>(c => c.EqpCdContrainte).WithMany(t => t.EqpPrevisions).HasForeignKey(u => new {u.EqpCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpPrevision>().ToTable("PREVISION_EQP","EQP");
            modelBuilder.Entity<EqpPrevision>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpPrevision>().Property(item => item.BpuEqpTechn).IsRequired();
            modelBuilder.Entity<EqpPrevision>().Property(item => item.BpuEqpTechn).HasMaxLength(250);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.BpuEqpTechn).HasColumnName("BPU_EQP__TECHN");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.CdTypeEqpTypeEquip).IsRequired();
            modelBuilder.Entity<EqpPrevision>().Property(item => item.CdTypeEqpTypeEquip).HasMaxLength(6);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.CdTypeEqpTypeEquip).HasColumnName("CD_TYPE_EQP__TYPE_EQUIP");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.IdPrev).IsRequired();
            modelBuilder.Entity<EqpPrevision>().Property(item => item.IdPrev).HasColumnName("ID_PREV");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.CdContrainteEqpType).HasMaxLength(100);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.CdContrainteEqpType).HasColumnName("CD_CONTRAINTE_EQP__TYPE");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Ouvrage).HasMaxLength(30);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Ouvrage).HasColumnName("OUVRAGE");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Position).HasMaxLength(60);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Position).HasColumnName("POSITION");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.DateDebut).IsRequired();
            modelBuilder.Entity<EqpPrevision>().Property(item => item.DateDebut).HasColumnName("DATE_DEBUT");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<EqpPrevision>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpPrevision>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<EqpPrevision>().Ignore(item => item.Realise);
            modelBuilder.Entity<EqpEvt>().HasRequired<EqpCdType>(c => c.EqpCdType).WithMany(t => t.EqpEvts).HasForeignKey(u => new { u.EqpCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpEvt>().HasRequired<EqpCdEvt>(c => c.EqpCdEvt).WithMany(t => t.EqpEvts).HasForeignKey(u => new { u.EqpCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpEvt>().HasOptional<EqpCdPosit>(c => c.EqpCdPosit).WithMany(t => t.EqpEvts).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpEvt>().ToTable("EVT_EQP","EQP");
            modelBuilder.Entity<EqpEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdTypeEqpTypeEquip).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdTypeEqpTypeEquip).HasMaxLength(6);
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdTypeEqpTypeEquip).HasColumnName("CD_TYPE_EQP__TYPE_EQUIP");
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdEvtEqpType).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdEvtEqpType).HasMaxLength(25);
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdEvtEqpType).HasColumnName("CD_EVT_EQP__TYPE");
            modelBuilder.Entity<EqpEvt>().Property(item => item.IdEvt).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.IdEvt).HasColumnName("ID_EVT");
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpEvt>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpEvt>().Property(item => item.Ouvrage).HasMaxLength(30);
            modelBuilder.Entity<EqpEvt>().Property(item => item.Ouvrage).HasColumnName("OUVRAGE");
            modelBuilder.Entity<EqpEvt>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpEvt>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpEvt>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpEvt>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpEvt>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpEvt>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<EqpEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<EqpEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<EqpEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<EqpEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<EqpEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<EqpCdEntp>().HasMany<EqpDscSv>(c => c.EqpDscSvs).WithOptional(t => t.EqpCdEntp).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEntp>().HasMany<EqpDscSh>(c => c.EqpDscShs).WithOptional(t => t.EqpCdEntp).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEntp>().HasMany<EqpDscEs>(c => c.EqpDscEss).WithOptional(t => t.EqpCdEntp).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEntp>().HasMany<EqpDscPo>(c => c.EqpDscPos).WithOptional(t => t.EqpCdEntp).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEntp>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithOptional(t => t.EqpCdEntp).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEntp>().HasMany<EqpTravaux>(c => c.EqpTravauxs).WithRequired(t => t.EqpCdEntp).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEntp>().HasMany<EqpDscDv>(c => c.EqpDscDvs).WithOptional(t => t.EqpCdEntp).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdEntp>().ToTable("CD_ENTP_EQP","EQP");
            modelBuilder.Entity<EqpCdEntp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdEntp>().Property(item => item.Entreprise).IsRequired();
            modelBuilder.Entity<EqpCdEntp>().Property(item => item.Entreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpCdEntp>().Property(item => item.Entreprise).HasColumnName("ENTREPRISE");
            modelBuilder.Entity<EqpCdPosit>().HasMany<EqpDscSv>(c => c.EqpDscSvs).WithRequired(t => t.EqpCdPosit).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPosit>().HasMany<EqpDscEs>(c => c.EqpDscEss).WithRequired(t => t.EqpCdPosit).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPosit>().HasMany<EqpDscPo>(c => c.EqpDscPos).WithOptional(t => t.EqpCdPosit).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPosit>().HasMany<EqpDscSh>(c => c.EqpDscShs).WithRequired(t => t.EqpCdPosit).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPosit>().HasMany<EqpDscCl>(c => c.EqpDscCls).WithRequired(t => t.EqpCdPosit).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPosit>().HasMany<EqpEvt>(c => c.EqpEvts).WithOptional(t => t.EqpCdPosit).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPosit>().HasMany<EqpDscDv>(c => c.EqpDscDvs).WithRequired(t => t.EqpCdPosit).HasForeignKey(u => new {u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdPosit>().ToTable("CD_POSIT_EQP","EQP");
            modelBuilder.Entity<EqpCdPosit>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdPosit>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<EqpCdPosit>().Property(item => item.Posit).HasMaxLength(60);
            modelBuilder.Entity<EqpCdPosit>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<EqpCdMatSv>().HasMany<EqpPanneau>(c => c.EqpPanneaus).WithOptional(t => t.EqpCdMatSv).HasForeignKey(u => new {u.EqpCdMatSvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdMatSv>().ToTable("CD_MAT_SV_EQP","EQP");
            modelBuilder.Entity<EqpCdMatSv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdMatSv>().Property(item => item.Materiaux).IsRequired();
            modelBuilder.Entity<EqpCdMatSv>().Property(item => item.Materiaux).HasMaxLength(60);
            modelBuilder.Entity<EqpCdMatSv>().Property(item => item.Materiaux).HasColumnName("MATERIAUX");
            modelBuilder.Entity<EqpCdMatSv>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<EqpCdMatSv>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<EqpCdContrainte>().HasMany<EqpPrevision>(c => c.EqpPrevisions).WithOptional(t => t.EqpCdContrainte).HasForeignKey(u => new {u.EqpCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdContrainte>().ToTable("CD_CONTRAINTE_EQP","EQP");
            modelBuilder.Entity<EqpCdContrainte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdContrainte>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<EqpCdContrainte>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<EqpCdContrainte>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<EqpCdTypeDv>().HasMany<EqpDscDv>(c => c.EqpDscDvs).WithRequired(t => t.EqpCdTypeDv).HasForeignKey(u => new {u.EqpCdTypeDvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpCdTypeDv>().ToTable("CD_TYPE_DV_EQP","EQP");
            modelBuilder.Entity<EqpCdTypeDv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpCdTypeDv>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<EqpCdTypeDv>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<EqpCdTypeDv>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<EqpCdTypeDv>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<EqpCdTypeDv>().Property(item => item.Libelle).HasMaxLength(255);
            modelBuilder.Entity<EqpCdTypeDv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<EqpDscDv>().HasRequired<EqpCdPosit>(c => c.EqpCdPosit).WithMany(t => t.EqpDscDvs).HasForeignKey(u => new { u.EqpCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscDv>().HasOptional<EqpCdFabricant>(c => c.EqpCdFabricant).WithMany(t => t.EqpDscDvs).HasForeignKey(u => new {u.EqpCdFabricantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscDv>().HasOptional<EqpCdEntp>(c => c.EqpCdEntp).WithMany(t => t.EqpDscDvs).HasForeignKey(u => new {u.EqpCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscDv>().HasRequired<EqpCdTypeDv>(c => c.EqpCdTypeDv).WithMany(t => t.EqpDscDvs).HasForeignKey(u => new { u.EqpCdTypeDvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpDscDv>().ToTable("DSC_DV_EQP","EQP");
            modelBuilder.Entity<EqpDscDv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdPositEqpPosit).IsRequired();
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdPositEqpPosit).HasMaxLength(60);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdPositEqpPosit).HasColumnName("CD_POSIT_EQP__POSIT");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdTypeDvEqpCode).IsRequired();
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdTypeDvEqpCode).HasMaxLength(15);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdTypeDvEqpCode).HasColumnName("CD_TYPE_DV_EQP__CODE");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<EqpDscDv>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdEntpEqpEntreprise).HasMaxLength(60);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdEntpEqpEntreprise).HasColumnName("CD_ENTP_EQP__ENTREPRISE");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdFabricantEqpNom).HasMaxLength(60);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.CdFabricantEqpNom).HasColumnName("CD_FABRICANT_EQP__NOM");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<EqpDscDv>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Alimentation).HasMaxLength(60);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Alimentation).HasColumnName("ALIMENTATION");
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<EqpDscDv>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<EqpContact>().HasRequired<EqpDoc>(c => c.EqpDoc).WithMany(t => t.EqpContacts).HasForeignKey(u => new { u.EqpDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpContact>().ToTable("CONTACT_EQP","EQP");
            modelBuilder.Entity<EqpContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpContact>().Property(item => item.DocEqpId).IsRequired();
            modelBuilder.Entity<EqpContact>().Property(item => item.DocEqpId).HasColumnName("DOC_EQP__ID");
            modelBuilder.Entity<EqpContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<EqpContact>().Property(item => item.Givenname).HasColumnName("GIVENNAME");
            modelBuilder.Entity<EqpContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<EqpContact>().Property(item => item.Sn).HasColumnName("SN");
            modelBuilder.Entity<EqpContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<EqpContact>().Property(item => item.Cn).HasColumnName("CN");
            modelBuilder.Entity<EqpContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<EqpContact>().Property(item => item.O).HasColumnName("O");
            modelBuilder.Entity<EqpContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<EqpContact>().Property(item => item.Mail).HasColumnName("MAIL");
            modelBuilder.Entity<EqpContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<EqpContact>().Property(item => item.Telephonenumber).HasColumnName("TELEPHONENUMBER");
            modelBuilder.Entity<EqpContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<EqpContact>().Property(item => item.Mobile).HasColumnName("MOBILE");
            modelBuilder.Entity<EqpContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<EqpContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("FACSIMILETELEPHONENUMBER");
            modelBuilder.Entity<EqpContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<EqpContact>().Property(item => item.Street).HasColumnName("STREET");
            modelBuilder.Entity<EqpContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<EqpContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("MOZILLAWORKSTREET2");
            modelBuilder.Entity<EqpContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<EqpContact>().Property(item => item.L).HasColumnName("L");
            modelBuilder.Entity<EqpContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<EqpContact>().Property(item => item.Postalcode).HasColumnName("POSTALCODE");
            modelBuilder.Entity<EqpContact>().Property(item => item.Modifytimestamp).HasColumnName("MODIFYTIMESTAMP");
            modelBuilder.Entity<EqpClsDoc>().HasRequired<EqpCls>(c => c.EqpCls).WithMany(t => t.EqpClsDocs).HasForeignKey(u => new { u.EqpClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpClsDoc>().HasRequired<EqpDoc>(c => c.EqpDoc).WithMany(t => t.EqpClsDocs).HasForeignKey(u => new { u.EqpDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<EqpClsDoc>().ToTable("CLS_DOC_EQP","EQP");
            modelBuilder.Entity<EqpClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<EqpClsDoc>().Property(item => item.ClsEqpId).IsRequired();
            modelBuilder.Entity<EqpClsDoc>().Property(item => item.ClsEqpId).HasColumnName("CLS_EQP__ID");
            modelBuilder.Entity<EqpClsDoc>().Property(item => item.DocEqpId).IsRequired();
            modelBuilder.Entity<EqpClsDoc>().Property(item => item.DocEqpId).HasColumnName("DOC_EQP__ID");
            modelBuilder.Entity<EqpClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<EqpClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<EqpClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<EqpClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
        }
    }
}
