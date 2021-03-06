using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextBsn : DataContextBase
    {
        public DataContextBsn(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<BsnCdType> BsnCdTypes { get; set; }
        
        public DbSet<BsnCdFam> BsnCdFams { get; set; }
        
        public DbSet<BsnCdEntp> BsnCdEntps { get; set; }
        
        public DbSet<BsnDsc> BsnDscs { get; set; }
        
        public DbSet<BsnCls> BsnClss { get; set; }
        
        public DbSet<BsnDoc> BsnDocs { get; set; }
        
        public DbSet<BsnCdDoc> BsnCdDocs { get; set; }
        
        public DbSet<BsnElt> BsnElts { get; set; }
        
        public DbSet<BsnSprt> BsnSprts { get; set; }
        
        public DbSet<BsnPrt> BsnPrts { get; set; }
        
        public DbSet<BsnGrp> BsnGrps { get; set; }
        
        public DbSet<BsnInsp> BsnInsps { get; set; }
        
        public DbSet<BsnEltInsp> BsnEltInsps { get; set; }
        
        public DbSet<BsnPhotoEltInsp> BsnPhotoEltInsps { get; set; }
        
        public DbSet<BsnCamp> BsnCamps { get; set; }
        
        public DbSet<BsnCdMeteo> BsnCdMeteos { get; set; }
        
        public DbSet<BsnCdPresta> BsnCdPrestas { get; set; }
        
        public DbSet<BsnTravaux> BsnTravauxs { get; set; }
        
        public DbSet<BsnNatureTrav> BsnNatureTravs { get; set; }
        
        public DbSet<BsnCdPermeable> BsnCdPermeables { get; set; }
        
        public DbSet<BsnSysUser> BsnSysUsers { get; set; }
        
        public DbSet<BsnCdTypePv> BsnCdTypePvs { get; set; }
        
        public DbSet<BsnCdEtude> BsnCdEtudes { get; set; }
        
        public DbSet<BsnBpu> BsnBpus { get; set; }
        
        public DbSet<BsnCdContrainte> BsnCdContraintes { get; set; }
        
        public DbSet<BsnCdTravaux> BsnCdTravauxs { get; set; }
        
        public DbSet<BsnCdExt> BsnCdExts { get; set; }
        
        public DbSet<BsnSeuilQualite> BsnSeuilQualites { get; set; }
        
        public DbSet<BsnSeuilUrgence> BsnSeuilUrgences { get; set; }
        
        public DbSet<BsnPrevision> BsnPrevisions { get; set; }
        
        public DbSet<BsnVst> BsnVsts { get; set; }
        
        public DbSet<BsnSprtVst> BsnSprtVsts { get; set; }
        
        public DbSet<BsnPhotoSprtVst> BsnPhotoSprtVsts { get; set; }
        
        public DbSet<BsnPhotoVst> BsnPhotoVsts { get; set; }
        
        public DbSet<BsnPhotoInsp> BsnPhotoInsps { get; set; }
        
        public DbSet<BsnCdQualite> BsnCdQualites { get; set; }
        
        public DbSet<BsnHistoNote> BsnHistoNotes { get; set; }
        
        public DbSet<BsnCdOrigin> BsnCdOrigins { get; set; }
        
        public DbSet<BsnDictionnaire> BsnDictionnaires { get; set; }
        
        public DbSet<BsnCdEvt> BsnCdEvts { get; set; }
        
        public DbSet<BsnEvt> BsnEvts { get; set; }
        
        public DbSet<BsnImpluvium> BsnImpluviums { get; set; }
        
        public DbSet<BsnGeometrie> BsnGeometries { get; set; }
        
        public DbSet<BsnCdAcces> BsnCdAccess { get; set; }
        
        public DbSet<BsnCdEntete> BsnCdEntetes { get; set; }
        
        public DbSet<BsnCdChapitre> BsnCdChapitres { get; set; }
        
        public DbSet<BsnCdLigne> BsnCdLignes { get; set; }
        
        public DbSet<BsnEntete> BsnEntetes { get; set; }
        
        public DbSet<BsnCdTypeqp> BsnCdTypeqps { get; set; }
        
        public DbSet<BsnCdFameqp> BsnCdFameqps { get; set; }
        
        public DbSet<BsnEquipement> BsnEquipements { get; set; }
        
        public DbSet<BsnContact> BsnContacts { get; set; }
        
        public DbSet<BsnCdUnite> BsnCdUnites { get; set; }
        
        public DbSet<BsnInspecteur> BsnInspecteurs { get; set; }
        
        public DbSet<BsnCdComposant> BsnCdComposants { get; set; }
        
        public DbSet<BsnCdSousType> BsnCdSousTypes { get; set; }
        
        public DbSet<BsnCdFrequence> BsnCdFrequences { get; set; }
        
        public DbSet<BsnCdRole> BsnCdRoles { get; set; }
        
        public DbSet<BsnCdConclusion> BsnCdConclusions { get; set; }
        
        public DbSet<BsnDscTemp> BsnDscTemps { get; set; }
        
        public DbSet<BsnPhotoInspTmp> BsnPhotoInspTmps { get; set; }
        
        public DbSet<BsnPhotoEltInspTmp> BsnPhotoEltInspTmps { get; set; }
        
        public DbSet<BsnEltInspTmp> BsnEltInspTmps { get; set; }
        
        public DbSet<BsnInspTmp> BsnInspTmps { get; set; }
        
        public DbSet<BsnClsDoc> BsnClsDocs { get; set; }
        
        public DbSet<BsnCdConclusionInsp> BsnCdConclusionInsps { get; set; }
        
        public DbSet<BsnDscCamp> BsnDscCamps { get; set; }
        
        public DbSet<BsnCdPrecoSprtVst> BsnCdPrecoSprtVsts { get; set; }
        
        public DbSet<BsnCdRoleDsc> BsnCdRoleDscs { get; set; }
        
        public DbSet<BsnCdConclusionInspTmp> BsnCdConclusionInspTmps { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<BsnCdType>().HasMany<BsnDsc>(c => c.BsnDscs).WithRequired(t => t.BsnCdType).HasForeignKey(u => new {u.BsnCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdType>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithRequired(t => t.BsnCdType).HasForeignKey(u => new {u.BsnCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdType>().ToTable("CD_TYPE_BSN","BSN");
            modelBuilder.Entity<BsnCdType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdType>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<BsnCdType>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<BsnCdType>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<BsnCdFam>().HasMany<BsnDsc>(c => c.BsnDscs).WithRequired(t => t.BsnCdFam).HasForeignKey(u => new {u.BsnCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdFam>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithRequired(t => t.BsnCdFam).HasForeignKey(u => new {u.BsnCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdFam>().ToTable("CD_FAM_BSN","BSN");
            modelBuilder.Entity<BsnCdFam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdFam>().Property(item => item.Famille).IsRequired();
            modelBuilder.Entity<BsnCdFam>().Property(item => item.Famille).HasMaxLength(60);
            modelBuilder.Entity<BsnCdFam>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<BsnCdFam>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<BsnCdFam>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdEntp>().HasMany<BsnTravaux>(c => c.BsnTravauxs).WithRequired(t => t.BsnCdEntp).HasForeignKey(u => new {u.BsnCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEntp>().HasMany<BsnDsc>(c => c.BsnDscs).WithOptional(t => t.BsnCdEntp).HasForeignKey(u => new {u.BsnCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEntp>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithOptional(t => t.BsnCdEntp).HasForeignKey(u => new {u.BsnCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEntp>().ToTable("CD_ENTP_BSN","BSN");
            modelBuilder.Entity<BsnCdEntp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdEntp>().Property(item => item.Entreprise).IsRequired();
            modelBuilder.Entity<BsnCdEntp>().Property(item => item.Entreprise).HasMaxLength(60);
            modelBuilder.Entity<BsnCdEntp>().Property(item => item.Entreprise).HasColumnName("ENTREPRISE");
            modelBuilder.Entity<BsnDsc>().HasRequired<BsnCdFam>(c => c.BsnCdFam).WithMany(t => t.BsnDscs).HasForeignKey(u => new { u.BsnCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasOptional<BsnCdPermeable>(c => c.BsnCdPermeable).WithMany(t => t.BsnDscs).HasForeignKey(u => new {u.BsnCdPermeableIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasRequired<BsnCdType>(c => c.BsnCdType).WithMany(t => t.BsnDscs).HasForeignKey(u => new { u.BsnCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasOptional<BsnCdExt>(c => c.BsnCdExt).WithMany(t => t.BsnDscs).HasForeignKey(u => new {u.BsnCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasOptional<BsnCdQualite>(c => c.BsnCdQualite).WithMany(t => t.BsnDscs).HasForeignKey(u => new {u.BsnCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasOptional<BsnCdAcces>(c => c.BsnCdAcces).WithMany(t => t.BsnDscs).HasForeignKey(u => new {u.BsnCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasOptional<BsnCdSousType>(c => c.BsnCdSousType).WithMany(t => t.BsnDscs).HasForeignKey(u => new {u.BsnCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasOptional<BsnCdFrequence>(c => c.BsnCdFrequence).WithMany(t => t.BsnDscs).HasForeignKey(u => new {u.BsnCdFrequenceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasOptional<BsnCdEntp>(c => c.BsnCdEntp).WithMany(t => t.BsnDscs).HasForeignKey(u => new {u.BsnCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnTravaux>(c => c.BsnTravauxs).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnPrevision>(c => c.BsnPrevisions).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnVst>(c => c.BsnVsts).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnInsp>(c => c.BsnInsps).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnHistoNote>(c => c.BsnHistoNotes).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnEvt>(c => c.BsnEvts).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnImpluvium>(c => c.BsnImpluviums).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnGeometrie>(c => c.BsnGeometries).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnEquipement>(c => c.BsnEquipements).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithOptional(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnDscCamp>(c => c.BsnDscCamps).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().HasMany<BsnCdRoleDsc>(c => c.BsnCdRoleDscs).WithRequired(t => t.BsnDsc).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDsc>().ToTable("DSC_BSN","BSN");
            modelBuilder.Entity<BsnDsc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnDsc>().Property(item => item.NumBsn).IsRequired();
            modelBuilder.Entity<BsnDsc>().Property(item => item.NumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnDsc>().Property(item => item.NumBsn).HasColumnName("NUM_BSN");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdAccesBsnVacces).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdAccesBsnVacces).HasColumnName("CD_ACCES_BSN__VACCES");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdPermeableBsnType).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdPermeableBsnType).HasColumnName("CD_PERMEABLE_BSN__TYPE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdEntpBsnEntreprise).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdEntpBsnEntreprise).HasColumnName("CD_ENTP_BSN__ENTREPRISE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdTypeBsnType).IsRequired();
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdTypeBsnType).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdTypeBsnType).HasColumnName("CD_TYPE_BSN__TYPE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdSousTypeBsnNatSensib).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdSousTypeBsnNatSensib).HasColumnName("CD_SOUS_TYPE_BSN__NAT_SENSIB");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdFrequenceBsnFreq).HasMaxLength(25);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdFrequenceBsnFreq).HasColumnName("CD_FREQUENCE_BSN__FREQ");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdQualiteBsnQualite).HasMaxLength(25);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdQualiteBsnQualite).HasColumnName("CD_QUALITE_BSN__QUALITE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdExtBsnType).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdExtBsnType).HasColumnName("CD_EXT_BSN__TYPE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdFamBsnFamille).IsRequired();
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdFamBsnFamille).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.CdFamBsnFamille).HasColumnName("CD_FAM_BSN__FAMILLE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<BsnDsc>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<BsnDsc>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<BsnDsc>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<BsnDsc>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<BsnDsc>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<BsnDsc>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<BsnDsc>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<BsnDsc>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<BsnDsc>().Property(item => item.VolUtil).HasColumnName("VOL_UTIL");
            modelBuilder.Entity<BsnDsc>().Property(item => item.VolMor).HasColumnName("VOL_MOR");
            modelBuilder.Entity<BsnDsc>().Property(item => item.VolPoll).HasColumnName("VOL_POLL");
            modelBuilder.Entity<BsnDsc>().Property(item => item.VolIncen).HasColumnName("VOL_INCEN");
            modelBuilder.Entity<BsnDsc>().Property(item => item.DureePluie).HasColumnName("DUREE_PLUIE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.FauneFlore).HasMaxLength(60);
            modelBuilder.Entity<BsnDsc>().Property(item => item.FauneFlore).HasColumnName("FAUNE_FLORE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.SurfVersant).HasColumnName("SURF_VERSANT");
            modelBuilder.Entity<BsnDsc>().Property(item => item.DebitMax).HasColumnName("DEBIT_MAX");
            modelBuilder.Entity<BsnDsc>().Property(item => item.TpsConcent).HasColumnName("TPS_CONCENT");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Vehicule).HasMaxLength(255);
            modelBuilder.Entity<BsnDsc>().Property(item => item.Vehicule).HasColumnName("VEHICULE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Pieton).HasMaxLength(255);
            modelBuilder.Entity<BsnDsc>().Property(item => item.Pieton).HasColumnName("PIETON");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<BsnDsc>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<BsnDsc>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<BsnDsc>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<BsnDsc>().Ignore(item => item.Securite);
            modelBuilder.Entity<BsnDsc>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<BsnDsc>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<BsnDsc>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<BsnDsc>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<BsnDsc>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<BsnDsc>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<BsnDsc>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.OuvAval).HasMaxLength(200);
            modelBuilder.Entity<BsnDsc>().Property(item => item.OuvAval).HasColumnName("OUV_AVAL");
            modelBuilder.Entity<BsnDsc>().Property(item => item.LoiEauValueInt).HasColumnName("LOI_EAU");
            modelBuilder.Entity<BsnDsc>().Ignore(item => item.LoiEau);
            modelBuilder.Entity<BsnDsc>().Property(item => item.EauxCollect).HasMaxLength(200);
            modelBuilder.Entity<BsnDsc>().Property(item => item.EauxCollect).HasColumnName("EAUX_COLLECT");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<BsnDsc>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<BsnDsc>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<BsnDsc>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<BsnDsc>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<BsnDsc>().Ignore(item => item.Terrain);
            modelBuilder.Entity<BsnCls>().HasMany<BsnClsDoc>(c => c.BsnClsDocs).WithRequired(t => t.BsnCls).HasForeignKey(u => new {u.BsnClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCls>().ToTable("CLS_BSN","BSN");
            modelBuilder.Entity<BsnCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnCls>().Property(item => item.TableName).IsRequired();
            modelBuilder.Entity<BsnCls>().Property(item => item.TableName).HasMaxLength(30);
            modelBuilder.Entity<BsnCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<BsnCls>().Property(item => item.KeyValue).IsRequired();
            modelBuilder.Entity<BsnCls>().Property(item => item.KeyValue).HasMaxLength(500);
            modelBuilder.Entity<BsnCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<BsnDoc>().HasRequired<BsnCdDoc>(c => c.BsnCdDoc).WithMany(t => t.BsnDocs).HasForeignKey(u => new { u.BsnCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDoc>().HasMany<BsnContact>(c => c.BsnContacts).WithRequired(t => t.BsnDoc).HasForeignKey(u => new {u.BsnDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDoc>().HasMany<BsnClsDoc>(c => c.BsnClsDocs).WithRequired(t => t.BsnDoc).HasForeignKey(u => new {u.BsnDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDoc>().ToTable("DOC_BSN","BSN");
            modelBuilder.Entity<BsnDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnDoc>().Property(item => item.CdDocBsnCode).IsRequired();
            modelBuilder.Entity<BsnDoc>().Property(item => item.CdDocBsnCode).HasMaxLength(15);
            modelBuilder.Entity<BsnDoc>().Property(item => item.CdDocBsnCode).HasColumnName("CD_DOC_BSN__CODE");
            modelBuilder.Entity<BsnDoc>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<BsnDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnDoc>().Property(item => item.Ref).IsRequired();
            modelBuilder.Entity<BsnDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<BsnDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<BsnCdDoc>().HasMany<BsnDoc>(c => c.BsnDocs).WithRequired(t => t.BsnCdDoc).HasForeignKey(u => new {u.BsnCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdDoc>().ToTable("CD_DOC_BSN","BSN");
            modelBuilder.Entity<BsnCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<BsnCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<BsnCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<BsnCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<BsnCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<BsnCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<BsnElt>().HasRequired<BsnSprt>(c => c.BsnSprt).WithMany(t => t.BsnElts).HasForeignKey(u => new { u.BsnSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnElt>().HasMany<BsnEltInsp>(c => c.BsnEltInsps).WithRequired(t => t.BsnElt).HasForeignKey(u => new {u.BsnEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnElt>().HasMany<BsnEltInspTmp>(c => c.BsnEltInspTmps).WithRequired(t => t.BsnElt).HasForeignKey(u => new {u.BsnEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnElt>().ToTable("ELT_BSN","BSN");
            modelBuilder.Entity<BsnElt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnElt>().Property(item => item.GrpBsnIdGrp).IsRequired();
            modelBuilder.Entity<BsnElt>().Property(item => item.GrpBsnIdGrp).HasColumnName("GRP_BSN__ID_GRP");
            modelBuilder.Entity<BsnElt>().Property(item => item.PrtBsnIdPrt).IsRequired();
            modelBuilder.Entity<BsnElt>().Property(item => item.PrtBsnIdPrt).HasColumnName("PRT_BSN__ID_PRT");
            modelBuilder.Entity<BsnElt>().Property(item => item.SprtBsnIdSprt).IsRequired();
            modelBuilder.Entity<BsnElt>().Property(item => item.SprtBsnIdSprt).HasColumnName("SPRT_BSN__ID_SPRT");
            modelBuilder.Entity<BsnElt>().Property(item => item.IdElem).IsRequired();
            modelBuilder.Entity<BsnElt>().Property(item => item.IdElem).HasColumnName("ID_ELEM");
            modelBuilder.Entity<BsnElt>().Property(item => item.Libe).IsRequired();
            modelBuilder.Entity<BsnElt>().Property(item => item.Libe).HasMaxLength(500);
            modelBuilder.Entity<BsnElt>().Property(item => item.Libe).HasColumnName("LIBE");
            modelBuilder.Entity<BsnElt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<BsnElt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<BsnElt>().Property(item => item.Aide).HasMaxLength(500);
            modelBuilder.Entity<BsnElt>().Property(item => item.Aide).HasColumnName("AIDE");
            modelBuilder.Entity<BsnElt>().Property(item => item.Indice1).HasMaxLength(500);
            modelBuilder.Entity<BsnElt>().Property(item => item.Indice1).HasColumnName("INDICE1");
            modelBuilder.Entity<BsnElt>().Property(item => item.Indice2).HasMaxLength(500);
            modelBuilder.Entity<BsnElt>().Property(item => item.Indice2).HasColumnName("INDICE2");
            modelBuilder.Entity<BsnElt>().Property(item => item.Indice3).HasMaxLength(500);
            modelBuilder.Entity<BsnElt>().Property(item => item.Indice3).HasColumnName("INDICE3");
            modelBuilder.Entity<BsnSprt>().HasRequired<BsnPrt>(c => c.BsnPrt).WithMany(t => t.BsnSprts).HasForeignKey(u => new { u.BsnPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnSprt>().HasMany<BsnElt>(c => c.BsnElts).WithRequired(t => t.BsnSprt).HasForeignKey(u => new {u.BsnSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnSprt>().ToTable("SPRT_BSN","BSN");
            modelBuilder.Entity<BsnSprt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnSprt>().Property(item => item.GrpBsnIdGrp).IsRequired();
            modelBuilder.Entity<BsnSprt>().Property(item => item.GrpBsnIdGrp).HasColumnName("GRP_BSN__ID_GRP");
            modelBuilder.Entity<BsnSprt>().Property(item => item.PrtBsnIdPrt).IsRequired();
            modelBuilder.Entity<BsnSprt>().Property(item => item.PrtBsnIdPrt).HasColumnName("PRT_BSN__ID_PRT");
            modelBuilder.Entity<BsnSprt>().Property(item => item.IdSprt).IsRequired();
            modelBuilder.Entity<BsnSprt>().Property(item => item.IdSprt).HasColumnName("ID_SPRT");
            modelBuilder.Entity<BsnSprt>().Property(item => item.Libs).IsRequired();
            modelBuilder.Entity<BsnSprt>().Property(item => item.Libs).HasMaxLength(500);
            modelBuilder.Entity<BsnSprt>().Property(item => item.Libs).HasColumnName("LIBS");
            modelBuilder.Entity<BsnSprt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<BsnSprt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<BsnPrt>().HasRequired<BsnGrp>(c => c.BsnGrp).WithMany(t => t.BsnPrts).HasForeignKey(u => new { u.BsnGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPrt>().HasMany<BsnSprt>(c => c.BsnSprts).WithRequired(t => t.BsnPrt).HasForeignKey(u => new {u.BsnPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPrt>().ToTable("PRT_BSN","BSN");
            modelBuilder.Entity<BsnPrt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPrt>().Property(item => item.GrpBsnIdGrp).IsRequired();
            modelBuilder.Entity<BsnPrt>().Property(item => item.GrpBsnIdGrp).HasColumnName("GRP_BSN__ID_GRP");
            modelBuilder.Entity<BsnPrt>().Property(item => item.IdPrt).IsRequired();
            modelBuilder.Entity<BsnPrt>().Property(item => item.IdPrt).HasColumnName("ID_PRT");
            modelBuilder.Entity<BsnPrt>().Property(item => item.Libp).IsRequired();
            modelBuilder.Entity<BsnPrt>().Property(item => item.Libp).HasMaxLength(500);
            modelBuilder.Entity<BsnPrt>().Property(item => item.Libp).HasColumnName("LIBP");
            modelBuilder.Entity<BsnPrt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<BsnPrt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<BsnGrp>().HasMany<BsnPrt>(c => c.BsnPrts).WithRequired(t => t.BsnGrp).HasForeignKey(u => new {u.BsnGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnGrp>().ToTable("GRP_BSN","BSN");
            modelBuilder.Entity<BsnGrp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnGrp>().Property(item => item.IdGrp).IsRequired();
            modelBuilder.Entity<BsnGrp>().Property(item => item.IdGrp).HasColumnName("ID_GRP");
            modelBuilder.Entity<BsnGrp>().Property(item => item.Libg).IsRequired();
            modelBuilder.Entity<BsnGrp>().Property(item => item.Libg).HasMaxLength(500);
            modelBuilder.Entity<BsnGrp>().Property(item => item.Libg).HasColumnName("LIBG");
            modelBuilder.Entity<BsnGrp>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<BsnGrp>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<BsnInsp>().HasRequired<BsnCamp>(c => c.BsnCamp).WithMany(t => t.BsnInsps).HasForeignKey(u => new { u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().HasOptional<BsnCdEtude>(c => c.BsnCdEtude).WithMany(t => t.BsnInsps).HasForeignKey(u => new {u.BsnCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().HasOptional<BsnCdMeteo>(c => c.BsnCdMeteo).WithMany(t => t.BsnInsps).HasForeignKey(u => new {u.BsnCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnInsps).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().HasOptional<BsnInspecteur>(c => c.BsnInspecteur).WithMany(t => t.BsnInsps).HasForeignKey(u => new {u.BsnInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().HasMany<BsnEltInsp>(c => c.BsnEltInsps).WithRequired(t => t.BsnInsp).HasForeignKey(u => new {u.BsnInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().HasMany<BsnPhotoInsp>(c => c.BsnPhotoInsps).WithRequired(t => t.BsnInsp).HasForeignKey(u => new {u.BsnInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().HasMany<BsnCdConclusionInsp>(c => c.BsnCdConclusionInsps).WithRequired(t => t.BsnInsp).HasForeignKey(u => new {u.BsnInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInsp>().ToTable("INSP_BSN","BSN");
            modelBuilder.Entity<BsnInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnInsp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnInsp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnInsp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnInsp>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnInsp>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnInsp>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnInsp>().Property(item => item.CdMeteoBsnMeteo).HasMaxLength(60);
            modelBuilder.Entity<BsnInsp>().Property(item => item.CdMeteoBsnMeteo).HasColumnName("CD_METEO_BSN__METEO");
            modelBuilder.Entity<BsnInsp>().Property(item => item.InspecteurBsnNom).HasMaxLength(60);
            modelBuilder.Entity<BsnInsp>().Property(item => item.InspecteurBsnNom).HasColumnName("INSPECTEUR_BSN__NOM");
            modelBuilder.Entity<BsnInsp>().Property(item => item.CdEtudeBsnEtude).HasMaxLength(65);
            modelBuilder.Entity<BsnInsp>().Property(item => item.CdEtudeBsnEtude).HasColumnName("CD_ETUDE_BSN__ETUDE");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<BsnInsp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<BsnInsp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<BsnInsp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<BsnInsp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<BsnInsp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<BsnInsp>().Property(item => item.NomValid).HasMaxLength(250);
            modelBuilder.Entity<BsnInsp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<BsnInsp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<BsnInsp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<BsnInsp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<BsnInsp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<BsnInsp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<BsnInsp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<BsnInsp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<BsnEltInsp>().HasRequired<BsnElt>(c => c.BsnElt).WithMany(t => t.BsnEltInsps).HasForeignKey(u => new { u.BsnEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEltInsp>().HasRequired<BsnInsp>(c => c.BsnInsp).WithMany(t => t.BsnEltInsps).HasForeignKey(u => new { u.BsnInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEltInsp>().HasMany<BsnPhotoEltInsp>(c => c.BsnPhotoEltInsps).WithRequired(t => t.BsnEltInsp).HasForeignKey(u => new {u.BsnEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEltInsp>().ToTable("ELT_INSP_BSN","BSN");
            modelBuilder.Entity<BsnEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.GrpBsnIdGrp).IsRequired();
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.GrpBsnIdGrp).HasColumnName("GRP_BSN__ID_GRP");
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.PrtBsnIdPrt).IsRequired();
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.PrtBsnIdPrt).HasColumnName("PRT_BSN__ID_PRT");
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.SprtBsnIdSprt).IsRequired();
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.SprtBsnIdSprt).HasColumnName("SPRT_BSN__ID_SPRT");
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.EltBsnIdElem).IsRequired();
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.EltBsnIdElem).HasColumnName("ELT_BSN__ID_ELEM");
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<BsnEltInsp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<BsnPhotoEltInsp>().HasRequired<BsnEltInsp>(c => c.BsnEltInsp).WithMany(t => t.BsnPhotoEltInsps).HasForeignKey(u => new { u.BsnEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPhotoEltInsp>().ToTable("PHOTO_ELT_INSP_BSN","BSN");
            modelBuilder.Entity<BsnPhotoEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.GrpBsnIdGrp).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.GrpBsnIdGrp).HasColumnName("GRP_BSN__ID_GRP");
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.PrtBsnIdPrt).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.PrtBsnIdPrt).HasColumnName("PRT_BSN__ID_PRT");
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.SprtBsnIdSprt).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.SprtBsnIdSprt).HasColumnName("SPRT_BSN__ID_SPRT");
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.EltBsnIdElem).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.EltBsnIdElem).HasColumnName("ELT_BSN__ID_ELEM");
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoEltInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnCamp>().HasRequired<BsnCdPresta>(c => c.BsnCdPresta).WithMany(t => t.BsnCamps).HasForeignKey(u => new { u.BsnCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCamp>().HasRequired<BsnCdTypePv>(c => c.BsnCdTypePv).WithMany(t => t.BsnCamps).HasForeignKey(u => new { u.BsnCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCamp>().HasMany<BsnInsp>(c => c.BsnInsps).WithRequired(t => t.BsnCamp).HasForeignKey(u => new {u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCamp>().HasMany<BsnVst>(c => c.BsnVsts).WithRequired(t => t.BsnCamp).HasForeignKey(u => new {u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCamp>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithRequired(t => t.BsnCamp).HasForeignKey(u => new {u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCamp>().HasMany<BsnDscCamp>(c => c.BsnDscCamps).WithRequired(t => t.BsnCamp).HasForeignKey(u => new {u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCamp>().ToTable("CAMP_BSN","BSN");
            modelBuilder.Entity<BsnCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCamp>().Property(item => item.IdCamp).IsRequired();
            modelBuilder.Entity<BsnCamp>().Property(item => item.IdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnCamp>().Property(item => item.IdCamp).HasColumnName("ID_CAMP");
            modelBuilder.Entity<BsnCamp>().Property(item => item.CdPrestaBsnPrestataire).IsRequired();
            modelBuilder.Entity<BsnCamp>().Property(item => item.CdPrestaBsnPrestataire).HasMaxLength(50);
            modelBuilder.Entity<BsnCamp>().Property(item => item.CdPrestaBsnPrestataire).HasColumnName("CD_PRESTA_BSN__PRESTATAIRE");
            modelBuilder.Entity<BsnCamp>().Property(item => item.CdTypePvBsnCode).IsRequired();
            modelBuilder.Entity<BsnCamp>().Property(item => item.CdTypePvBsnCode).HasMaxLength(15);
            modelBuilder.Entity<BsnCamp>().Property(item => item.CdTypePvBsnCode).HasColumnName("CD_TYPE_PV_BSN__CODE");
            modelBuilder.Entity<BsnCamp>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<BsnCamp>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<BsnCamp>().Property(item => item.Dater).IsRequired();
            modelBuilder.Entity<BsnCamp>().Property(item => item.Dater).HasColumnName("DATER");
            modelBuilder.Entity<BsnCamp>().Property(item => item.Dateg).HasColumnName("DATEG");
            modelBuilder.Entity<BsnCamp>().Property(item => item.Userg).HasMaxLength(255);
            modelBuilder.Entity<BsnCamp>().Property(item => item.Userg).HasColumnName("USERG");
            modelBuilder.Entity<BsnCamp>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<BsnCamp>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<BsnCdMeteo>().HasMany<BsnInsp>(c => c.BsnInsps).WithOptional(t => t.BsnCdMeteo).HasForeignKey(u => new {u.BsnCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdMeteo>().HasMany<BsnInspTmp>(c => c.BsnInspTmps).WithOptional(t => t.BsnCdMeteo).HasForeignKey(u => new {u.BsnCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdMeteo>().ToTable("CD_METEO_BSN","BSN");
            modelBuilder.Entity<BsnCdMeteo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdMeteo>().Property(item => item.Meteo).IsRequired();
            modelBuilder.Entity<BsnCdMeteo>().Property(item => item.Meteo).HasMaxLength(60);
            modelBuilder.Entity<BsnCdMeteo>().Property(item => item.Meteo).HasColumnName("METEO");
            modelBuilder.Entity<BsnCdPresta>().HasMany<BsnCamp>(c => c.BsnCamps).WithRequired(t => t.BsnCdPresta).HasForeignKey(u => new {u.BsnCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdPresta>().HasMany<BsnInspecteur>(c => c.BsnInspecteurs).WithRequired(t => t.BsnCdPresta).HasForeignKey(u => new {u.BsnCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdPresta>().ToTable("CD_PRESTA_BSN","BSN");
            modelBuilder.Entity<BsnCdPresta>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdPresta>().Property(item => item.Prestataire).IsRequired();
            modelBuilder.Entity<BsnCdPresta>().Property(item => item.Prestataire).HasMaxLength(50);
            modelBuilder.Entity<BsnCdPresta>().Property(item => item.Prestataire).HasColumnName("PRESTATAIRE");
            modelBuilder.Entity<BsnTravaux>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnTravauxs).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnTravaux>().HasRequired<BsnNatureTrav>(c => c.BsnNatureTrav).WithMany(t => t.BsnTravauxs).HasForeignKey(u => new { u.BsnNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnTravaux>().HasRequired<BsnCdEntp>(c => c.BsnCdEntp).WithMany(t => t.BsnTravauxs).HasForeignKey(u => new { u.BsnCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnTravaux>().ToTable("TRAVAUX_BSN","BSN");
            modelBuilder.Entity<BsnTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnTravaux>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnTravaux>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnTravaux>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.CdTravauxBsnCode).IsRequired();
            modelBuilder.Entity<BsnTravaux>().Property(item => item.CdTravauxBsnCode).HasMaxLength(60);
            modelBuilder.Entity<BsnTravaux>().Property(item => item.CdTravauxBsnCode).HasColumnName("CD_TRAVAUX_BSN__CODE");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.NatureTravBsnNature).IsRequired();
            modelBuilder.Entity<BsnTravaux>().Property(item => item.NatureTravBsnNature).HasMaxLength(100);
            modelBuilder.Entity<BsnTravaux>().Property(item => item.NatureTravBsnNature).HasColumnName("NATURE_TRAV_BSN__NATURE");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.DateRcp).IsRequired();
            modelBuilder.Entity<BsnTravaux>().Property(item => item.DateRcp).HasColumnName("DATE_RCP");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.CdEntpBsnEntreprise).IsRequired();
            modelBuilder.Entity<BsnTravaux>().Property(item => item.CdEntpBsnEntreprise).HasMaxLength(60);
            modelBuilder.Entity<BsnTravaux>().Property(item => item.CdEntpBsnEntreprise).HasColumnName("CD_ENTP_BSN__ENTREPRISE");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.DateFinGar).HasColumnName("DATE_FIN_GAR");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.Marche).HasMaxLength(25);
            modelBuilder.Entity<BsnTravaux>().Property(item => item.Marche).HasColumnName("MARCHE");
            modelBuilder.Entity<BsnTravaux>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<BsnTravaux>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnNatureTrav>().HasRequired<BsnCdTravaux>(c => c.BsnCdTravaux).WithMany(t => t.BsnNatureTravs).HasForeignKey(u => new { u.BsnCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnNatureTrav>().HasMany<BsnTravaux>(c => c.BsnTravauxs).WithRequired(t => t.BsnNatureTrav).HasForeignKey(u => new {u.BsnNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnNatureTrav>().ToTable("NATURE_TRAV_BSN","BSN");
            modelBuilder.Entity<BsnNatureTrav>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnNatureTrav>().Property(item => item.CdTravauxBsnCode).IsRequired();
            modelBuilder.Entity<BsnNatureTrav>().Property(item => item.CdTravauxBsnCode).HasMaxLength(60);
            modelBuilder.Entity<BsnNatureTrav>().Property(item => item.CdTravauxBsnCode).HasColumnName("CD_TRAVAUX_BSN__CODE");
            modelBuilder.Entity<BsnNatureTrav>().Property(item => item.Nature).IsRequired();
            modelBuilder.Entity<BsnNatureTrav>().Property(item => item.Nature).HasMaxLength(100);
            modelBuilder.Entity<BsnNatureTrav>().Property(item => item.Nature).HasColumnName("NATURE");
            modelBuilder.Entity<BsnCdPermeable>().HasMany<BsnDsc>(c => c.BsnDscs).WithOptional(t => t.BsnCdPermeable).HasForeignKey(u => new {u.BsnCdPermeableIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdPermeable>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithOptional(t => t.BsnCdPermeable).HasForeignKey(u => new {u.BsnCdPermeableIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdPermeable>().ToTable("CD_PERMEABLE_BSN","BSN");
            modelBuilder.Entity<BsnCdPermeable>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdPermeable>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<BsnCdPermeable>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<BsnCdPermeable>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<BsnSysUser>().ToTable("SYS_USER_BSN","BSN");
            modelBuilder.Entity<BsnSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<BsnSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<BsnSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<BsnSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<BsnSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<BsnSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<BsnSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<BsnSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<BsnCdTypePv>().HasMany<BsnCamp>(c => c.BsnCamps).WithRequired(t => t.BsnCdTypePv).HasForeignKey(u => new {u.BsnCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdTypePv>().ToTable("CD_TYPE_PV_BSN","BSN");
            modelBuilder.Entity<BsnCdTypePv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Cycle).HasColumnName("CYCLE");
            modelBuilder.Entity<BsnCdTypePv>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<BsnCdEtude>().HasMany<BsnInsp>(c => c.BsnInsps).WithOptional(t => t.BsnCdEtude).HasForeignKey(u => new {u.BsnCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEtude>().HasMany<BsnInspTmp>(c => c.BsnInspTmps).WithOptional(t => t.BsnCdEtude).HasForeignKey(u => new {u.BsnCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEtude>().ToTable("CD_ETUDE_BSN","BSN");
            modelBuilder.Entity<BsnCdEtude>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdEtude>().Property(item => item.Etude).IsRequired();
            modelBuilder.Entity<BsnCdEtude>().Property(item => item.Etude).HasMaxLength(65);
            modelBuilder.Entity<BsnCdEtude>().Property(item => item.Etude).HasColumnName("ETUDE");
            modelBuilder.Entity<BsnBpu>().HasRequired<BsnCdTravaux>(c => c.BsnCdTravaux).WithMany(t => t.BsnBpus).HasForeignKey(u => new { u.BsnCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnBpu>().HasOptional<BsnCdUnite>(c => c.BsnCdUnite).WithMany(t => t.BsnBpus).HasForeignKey(u => new {u.BsnCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnBpu>().HasMany<BsnPrevision>(c => c.BsnPrevisions).WithRequired(t => t.BsnBpu).HasForeignKey(u => new {u.BsnBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnBpu>().HasMany<BsnCdPrecoSprtVst>(c => c.BsnCdPrecoSprtVsts).WithRequired(t => t.BsnBpu).HasForeignKey(u => new {u.BsnBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnBpu>().ToTable("BPU_BSN","BSN");
            modelBuilder.Entity<BsnBpu>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnBpu>().Property(item => item.IdBpu).IsRequired();
            modelBuilder.Entity<BsnBpu>().Property(item => item.IdBpu).HasColumnName("ID_BPU");
            modelBuilder.Entity<BsnBpu>().Property(item => item.CdTravauxBsnCode).IsRequired();
            modelBuilder.Entity<BsnBpu>().Property(item => item.CdTravauxBsnCode).HasMaxLength(60);
            modelBuilder.Entity<BsnBpu>().Property(item => item.CdTravauxBsnCode).HasColumnName("CD_TRAVAUX_BSN__CODE");
            modelBuilder.Entity<BsnBpu>().Property(item => item.CdUniteBsnUnite).HasMaxLength(12);
            modelBuilder.Entity<BsnBpu>().Property(item => item.CdUniteBsnUnite).HasColumnName("CD_UNITE_BSN__UNITE");
            modelBuilder.Entity<BsnBpu>().Property(item => item.Techn).IsRequired();
            modelBuilder.Entity<BsnBpu>().Property(item => item.Techn).HasMaxLength(255);
            modelBuilder.Entity<BsnBpu>().Property(item => item.Techn).HasColumnName("TECHN");
            modelBuilder.Entity<BsnBpu>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<BsnBpu>().Property(item => item.DateMaj).HasColumnName("DATE_MAJ");
            modelBuilder.Entity<BsnBpu>().Property(item => item.Freq).HasColumnName("FREQ");
            modelBuilder.Entity<BsnBpu>().Property(item => item.PrecoVstValueInt).HasColumnName("PRECO_VST");
            modelBuilder.Entity<BsnBpu>().Ignore(item => item.PrecoVst);
            modelBuilder.Entity<BsnBpu>().Property(item => item.RealisVstValueInt).HasColumnName("REALIS_VST");
            modelBuilder.Entity<BsnBpu>().Ignore(item => item.RealisVst);
            modelBuilder.Entity<BsnCdContrainte>().HasMany<BsnPrevision>(c => c.BsnPrevisions).WithOptional(t => t.BsnCdContrainte).HasForeignKey(u => new {u.BsnCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdContrainte>().ToTable("CD_CONTRAINTE_BSN","BSN");
            modelBuilder.Entity<BsnCdContrainte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdContrainte>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<BsnCdContrainte>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<BsnCdContrainte>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<BsnCdTravaux>().HasMany<BsnNatureTrav>(c => c.BsnNatureTravs).WithRequired(t => t.BsnCdTravaux).HasForeignKey(u => new {u.BsnCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdTravaux>().HasMany<BsnBpu>(c => c.BsnBpus).WithRequired(t => t.BsnCdTravaux).HasForeignKey(u => new {u.BsnCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdTravaux>().ToTable("CD_TRAVAUX_BSN","BSN");
            modelBuilder.Entity<BsnCdTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdTravaux>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<BsnCdTravaux>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<BsnCdTravaux>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<BsnCdExt>().HasMany<BsnDsc>(c => c.BsnDscs).WithOptional(t => t.BsnCdExt).HasForeignKey(u => new {u.BsnCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdExt>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithOptional(t => t.BsnCdExt).HasForeignKey(u => new {u.BsnCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdExt>().ToTable("CD_EXT_BSN","BSN");
            modelBuilder.Entity<BsnCdExt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdExt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<BsnCdExt>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<BsnCdExt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<BsnCdExt>().Property(item => item.IsBsnValueInt).IsRequired();
            modelBuilder.Entity<BsnCdExt>().Property(item => item.IsBsnValueInt).HasColumnName("IS_BSN");
            modelBuilder.Entity<BsnCdExt>().Ignore(item => item.IsBsn);
            modelBuilder.Entity<BsnCdExt>().Property(item => item.IsOhValueInt).IsRequired();
            modelBuilder.Entity<BsnCdExt>().Property(item => item.IsOhValueInt).HasColumnName("IS_OH");
            modelBuilder.Entity<BsnCdExt>().Ignore(item => item.IsOh);
            modelBuilder.Entity<BsnSeuilQualite>().HasRequired<BsnCdQualite>(c => c.BsnCdQualite).WithMany(t => t.BsnSeuilQualites).HasForeignKey(u => new { u.BsnCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnSeuilQualite>().ToTable("SEUIL_QUALITE_BSN","BSN");
            modelBuilder.Entity<BsnSeuilQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnSeuilQualite>().Property(item => item.CdQualiteBsnQualite).IsRequired();
            modelBuilder.Entity<BsnSeuilQualite>().Property(item => item.CdQualiteBsnQualite).HasMaxLength(25);
            modelBuilder.Entity<BsnSeuilQualite>().Property(item => item.CdQualiteBsnQualite).HasColumnName("CD_QUALITE_BSN__QUALITE");
            modelBuilder.Entity<BsnSeuilQualite>().Property(item => item.IndiceUrgence).IsRequired();
            modelBuilder.Entity<BsnSeuilQualite>().Property(item => item.IndiceUrgence).HasMaxLength(5);
            modelBuilder.Entity<BsnSeuilQualite>().Property(item => item.IndiceUrgence).HasColumnName("INDICE_URGENCE");
            modelBuilder.Entity<BsnSeuilUrgence>().ToTable("SEUIL_URGENCE_BSN","BSN");
            modelBuilder.Entity<BsnSeuilUrgence>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnSeuilUrgence>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<BsnSeuilUrgence>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<BsnSeuilUrgence>().Property(item => item.NbrNote).HasColumnName("NBR_NOTE");
            modelBuilder.Entity<BsnSeuilUrgence>().Property(item => item.ValNote).HasColumnName("VAL_NOTE");
            modelBuilder.Entity<BsnSeuilUrgence>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<BsnPrevision>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnPrevisions).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPrevision>().HasRequired<BsnBpu>(c => c.BsnBpu).WithMany(t => t.BsnPrevisions).HasForeignKey(u => new { u.BsnBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPrevision>().HasOptional<BsnCdContrainte>(c => c.BsnCdContrainte).WithMany(t => t.BsnPrevisions).HasForeignKey(u => new {u.BsnCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPrevision>().ToTable("PREVISION_BSN","BSN");
            modelBuilder.Entity<BsnPrevision>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPrevision>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnPrevision>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnPrevision>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.BpuBsnIdBpu).IsRequired();
            modelBuilder.Entity<BsnPrevision>().Property(item => item.BpuBsnIdBpu).HasColumnName("BPU_BSN__ID_BPU");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.DateDebut).IsRequired();
            modelBuilder.Entity<BsnPrevision>().Property(item => item.DateDebut).HasColumnName("DATE_DEBUT");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.CdContrainteBsnType).HasMaxLength(100);
            modelBuilder.Entity<BsnPrevision>().Property(item => item.CdContrainteBsnType).HasColumnName("CD_CONTRAINTE_BSN__TYPE");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.DateDemPub).HasColumnName("DATE_DEM_PUB");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<BsnPrevision>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnPrevision>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<BsnPrevision>().Ignore(item => item.Realise);
            modelBuilder.Entity<BsnVst>().HasRequired<BsnCamp>(c => c.BsnCamp).WithMany(t => t.BsnVsts).HasForeignKey(u => new { u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnVst>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnVsts).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnVst>().HasOptional<BsnInspecteur>(c => c.BsnInspecteur).WithMany(t => t.BsnVsts).HasForeignKey(u => new {u.BsnInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnVst>().HasMany<BsnSprtVst>(c => c.BsnSprtVsts).WithRequired(t => t.BsnVst).HasForeignKey(u => new {u.BsnVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnVst>().HasMany<BsnPhotoVst>(c => c.BsnPhotoVsts).WithRequired(t => t.BsnVst).HasForeignKey(u => new {u.BsnVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnVst>().HasMany<BsnEntete>(c => c.BsnEntetes).WithRequired(t => t.BsnVst).HasForeignKey(u => new {u.BsnVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnVst>().ToTable("VST_BSN","BSN");
            modelBuilder.Entity<BsnVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnVst>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnVst>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnVst>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnVst>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnVst>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnVst>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnVst>().Property(item => item.InspecteurBsnNom).HasMaxLength(60);
            modelBuilder.Entity<BsnVst>().Property(item => item.InspecteurBsnNom).HasColumnName("INSPECTEUR_BSN__NOM");
            modelBuilder.Entity<BsnVst>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<BsnVst>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<BsnVst>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<BsnVst>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<BsnVst>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<BsnVst>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<BsnVst>().Property(item => item.Observ).HasMaxLength(500);
            modelBuilder.Entity<BsnVst>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<BsnVst>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<BsnVst>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<BsnSprtVst>().HasRequired<BsnVst>(c => c.BsnVst).WithMany(t => t.BsnSprtVsts).HasForeignKey(u => new { u.BsnVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnSprtVst>().HasRequired<BsnCdLigne>(c => c.BsnCdLigne).WithMany(t => t.BsnSprtVsts).HasForeignKey(u => new { u.BsnCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnSprtVst>().HasMany<BsnPhotoSprtVst>(c => c.BsnPhotoSprtVsts).WithRequired(t => t.BsnSprtVst).HasForeignKey(u => new {u.BsnSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnSprtVst>().HasMany<BsnCdPrecoSprtVst>(c => c.BsnCdPrecoSprtVsts).WithRequired(t => t.BsnSprtVst).HasForeignKey(u => new {u.BsnSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnSprtVst>().ToTable("SPRT_VST_BSN","BSN");
            modelBuilder.Entity<BsnSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.CdChapitreBsnIdChap).IsRequired();
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.CdChapitreBsnIdChap).HasColumnName("CD_CHAPITRE_BSN__ID_CHAP");
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.CdLigneBsnIdLigne).IsRequired();
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.CdLigneBsnIdLigne).HasColumnName("CD_LIGNE_BSN__ID_LIGNE");
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<BsnSprtVst>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<BsnPhotoSprtVst>().HasRequired<BsnSprtVst>(c => c.BsnSprtVst).WithMany(t => t.BsnPhotoSprtVsts).HasForeignKey(u => new { u.BsnSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPhotoSprtVst>().ToTable("PHOTO_SPRT_VST_BSN","BSN");
            modelBuilder.Entity<BsnPhotoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.CdChapitreBsnIdChap).IsRequired();
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.CdChapitreBsnIdChap).HasColumnName("CD_CHAPITRE_BSN__ID_CHAP");
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.CdLigneBsnIdLigne).IsRequired();
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.CdLigneBsnIdLigne).HasColumnName("CD_LIGNE_BSN__ID_LIGNE");
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoSprtVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnPhotoVst>().HasRequired<BsnVst>(c => c.BsnVst).WithMany(t => t.BsnPhotoVsts).HasForeignKey(u => new { u.BsnVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPhotoVst>().ToTable("PHOTO_VST_BSN","BSN");
            modelBuilder.Entity<BsnPhotoVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnPhotoInsp>().HasRequired<BsnInsp>(c => c.BsnInsp).WithMany(t => t.BsnPhotoInsps).HasForeignKey(u => new { u.BsnInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPhotoInsp>().ToTable("PHOTO_INSP_BSN","BSN");
            modelBuilder.Entity<BsnPhotoInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnCdQualite>().HasMany<BsnSeuilQualite>(c => c.BsnSeuilQualites).WithRequired(t => t.BsnCdQualite).HasForeignKey(u => new {u.BsnCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdQualite>().HasMany<BsnDsc>(c => c.BsnDscs).WithOptional(t => t.BsnCdQualite).HasForeignKey(u => new {u.BsnCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdQualite>().ToTable("CD_QUALITE_BSN","BSN");
            modelBuilder.Entity<BsnCdQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdQualite>().Property(item => item.Qualite).IsRequired();
            modelBuilder.Entity<BsnCdQualite>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<BsnCdQualite>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<BsnHistoNote>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnHistoNotes).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnHistoNote>().HasRequired<BsnCdOrigin>(c => c.BsnCdOrigin).WithMany(t => t.BsnHistoNotes).HasForeignKey(u => new { u.BsnCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnHistoNote>().ToTable("HISTO_NOTE_BSN","BSN");
            modelBuilder.Entity<BsnHistoNote>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.DateNote).IsRequired();
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.DateNote).HasColumnName("DATE_NOTE");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.CdOriginBsnOrigine).IsRequired();
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.CdOriginBsnOrigine).HasMaxLength(20);
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.CdOriginBsnOrigine).HasColumnName("CD_ORIGIN_BSN__ORIGINE");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<BsnHistoNote>().Ignore(item => item.Securite);
            modelBuilder.Entity<BsnHistoNote>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<BsnHistoNote>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<BsnCdOrigin>().HasMany<BsnHistoNote>(c => c.BsnHistoNotes).WithRequired(t => t.BsnCdOrigin).HasForeignKey(u => new {u.BsnCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdOrigin>().ToTable("CD_ORIGIN_BSN","BSN");
            modelBuilder.Entity<BsnCdOrigin>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdOrigin>().Property(item => item.Origine).IsRequired();
            modelBuilder.Entity<BsnCdOrigin>().Property(item => item.Origine).HasMaxLength(20);
            modelBuilder.Entity<BsnCdOrigin>().Property(item => item.Origine).HasColumnName("ORIGINE");
            modelBuilder.Entity<BsnDictionnaire>().ToTable("DICTIONNAIRE_BSN","BSN");
            modelBuilder.Entity<BsnDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Definition).HasMaxLength(500);
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Definition).HasColumnName("DEFINITION");
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<BsnDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<BsnCdEvt>().HasMany<BsnEvt>(c => c.BsnEvts).WithRequired(t => t.BsnCdEvt).HasForeignKey(u => new {u.BsnCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEvt>().ToTable("CD_EVT_BSN","BSN");
            modelBuilder.Entity<BsnCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<BsnCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<BsnCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<BsnCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<BsnCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<BsnEvt>().HasRequired<BsnCdEvt>(c => c.BsnCdEvt).WithMany(t => t.BsnEvts).HasForeignKey(u => new { u.BsnCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEvt>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnEvts).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEvt>().ToTable("EVT_BSN","BSN");
            modelBuilder.Entity<BsnEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnEvt>().Property(item => item.CdEvtBsnType).IsRequired();
            modelBuilder.Entity<BsnEvt>().Property(item => item.CdEvtBsnType).HasMaxLength(25);
            modelBuilder.Entity<BsnEvt>().Property(item => item.CdEvtBsnType).HasColumnName("CD_EVT_BSN__TYPE");
            modelBuilder.Entity<BsnEvt>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnEvt>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnEvt>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<BsnEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<BsnEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<BsnEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<BsnEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<BsnImpluvium>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnImpluviums).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnImpluvium>().ToTable("IMPLUVIUM_BSN","BSN");
            modelBuilder.Entity<BsnImpluvium>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Surface).HasColumnName("SURFACE");
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<BsnImpluvium>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnGeometrie>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnGeometries).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnGeometrie>().ToTable("GEOMETRIE_BSN","BSN");
            modelBuilder.Entity<BsnGeometrie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnGeometrie>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnGeometrie>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnGeometrie>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnGeometrie>().Property(item => item.Surf).HasColumnName("SURF");
            modelBuilder.Entity<BsnGeometrie>().Property(item => item.Prof).HasColumnName("PROF");
            modelBuilder.Entity<BsnGeometrie>().Property(item => item.Pente).HasColumnName("PENTE");
            modelBuilder.Entity<BsnGeometrie>().Property(item => item.Perimetre).HasColumnName("PERIMETRE");
            modelBuilder.Entity<BsnCdAcces>().HasMany<BsnDsc>(c => c.BsnDscs).WithOptional(t => t.BsnCdAcces).HasForeignKey(u => new {u.BsnCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdAcces>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithOptional(t => t.BsnCdAcces).HasForeignKey(u => new {u.BsnCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdAcces>().ToTable("CD_ACCES_BSN","BSN");
            modelBuilder.Entity<BsnCdAcces>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdAcces>().Property(item => item.Vacces).IsRequired();
            modelBuilder.Entity<BsnCdAcces>().Property(item => item.Vacces).HasMaxLength(60);
            modelBuilder.Entity<BsnCdAcces>().Property(item => item.Vacces).HasColumnName("VACCES");
            modelBuilder.Entity<BsnCdEntete>().HasRequired<BsnCdComposant>(c => c.BsnCdComposant).WithMany(t => t.BsnCdEntetes).HasForeignKey(u => new { u.BsnCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEntete>().HasMany<BsnEntete>(c => c.BsnEntetes).WithRequired(t => t.BsnCdEntete).HasForeignKey(u => new {u.BsnCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdEntete>().ToTable("CD_ENTETE_BSN","BSN");
            modelBuilder.Entity<BsnCdEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.IdEntete).IsRequired();
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.IdEntete).HasColumnName("ID_ENTETE");
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.CdComposantBsnTypeComp).IsRequired();
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.CdComposantBsnTypeComp).HasMaxLength(6);
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.CdComposantBsnTypeComp).HasColumnName("CD_COMPOSANT_BSN__TYPE_COMP");
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.OrdreEnt).IsRequired();
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.OrdreEnt).HasColumnName("ORDRE_ENT");
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.Guide).HasMaxLength(500);
            modelBuilder.Entity<BsnCdEntete>().Property(item => item.Guide).HasColumnName("GUIDE");
            modelBuilder.Entity<BsnCdChapitre>().HasMany<BsnCdLigne>(c => c.BsnCdLignes).WithRequired(t => t.BsnCdChapitre).HasForeignKey(u => new {u.BsnCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdChapitre>().ToTable("CD_CHAPITRE_BSN","BSN");
            modelBuilder.Entity<BsnCdChapitre>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.IdChap).IsRequired();
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.IdChap).HasColumnName("ID_CHAP");
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.OrdreChap).IsRequired();
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.OrdreChap).HasColumnName("ORDRE_CHAP");
            modelBuilder.Entity<BsnCdChapitre>().Property(item => item.Ponderation).HasColumnName("PONDERATION");
            modelBuilder.Entity<BsnCdLigne>().HasRequired<BsnCdChapitre>(c => c.BsnCdChapitre).WithMany(t => t.BsnCdLignes).HasForeignKey(u => new { u.BsnCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdLigne>().HasMany<BsnSprtVst>(c => c.BsnSprtVsts).WithRequired(t => t.BsnCdLigne).HasForeignKey(u => new {u.BsnCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdLigne>().ToTable("CD_LIGNE_BSN","BSN");
            modelBuilder.Entity<BsnCdLigne>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.CdChapitreBsnIdChap).IsRequired();
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.CdChapitreBsnIdChap).HasColumnName("CD_CHAPITRE_BSN__ID_CHAP");
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.IdLigne).IsRequired();
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.IdLigne).HasColumnName("ID_LIGNE");
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.OrdreLigne).IsRequired();
            modelBuilder.Entity<BsnCdLigne>().Property(item => item.OrdreLigne).HasColumnName("ORDRE_LIGNE");
            modelBuilder.Entity<BsnEntete>().HasRequired<BsnCdEntete>(c => c.BsnCdEntete).WithMany(t => t.BsnEntetes).HasForeignKey(u => new { u.BsnCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEntete>().HasRequired<BsnVst>(c => c.BsnVst).WithMany(t => t.BsnEntetes).HasForeignKey(u => new { u.BsnVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEntete>().ToTable("ENTETE_BSN","BSN");
            modelBuilder.Entity<BsnEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnEntete>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnEntete>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnEntete>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnEntete>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnEntete>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnEntete>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnEntete>().Property(item => item.CdEnteteBsnIdEntete).IsRequired();
            modelBuilder.Entity<BsnEntete>().Property(item => item.CdEnteteBsnIdEntete).HasColumnName("CD_ENTETE_BSN__ID_ENTETE");
            modelBuilder.Entity<BsnEntete>().Property(item => item.Valeur).HasMaxLength(250);
            modelBuilder.Entity<BsnEntete>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<BsnCdTypeqp>().HasRequired<BsnCdFameqp>(c => c.BsnCdFameqp).WithMany(t => t.BsnCdTypeqps).HasForeignKey(u => new { u.BsnCdFameqpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdTypeqp>().HasMany<BsnEquipement>(c => c.BsnEquipements).WithRequired(t => t.BsnCdTypeqp).HasForeignKey(u => new {u.BsnCdTypeqpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdTypeqp>().ToTable("CD_TYPEQP_BSN","BSN");
            modelBuilder.Entity<BsnCdTypeqp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.CdFameqpBsnFam).IsRequired();
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.CdFameqpBsnFam).HasMaxLength(25);
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.CdFameqpBsnFam).HasColumnName("CD_FAMEQP_BSN__FAM");
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<BsnCdTypeqp>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<BsnCdFameqp>().HasMany<BsnCdTypeqp>(c => c.BsnCdTypeqps).WithRequired(t => t.BsnCdFameqp).HasForeignKey(u => new {u.BsnCdFameqpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdFameqp>().ToTable("CD_FAMEQP_BSN","BSN");
            modelBuilder.Entity<BsnCdFameqp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdFameqp>().Property(item => item.Fam).IsRequired();
            modelBuilder.Entity<BsnCdFameqp>().Property(item => item.Fam).HasMaxLength(25);
            modelBuilder.Entity<BsnCdFameqp>().Property(item => item.Fam).HasColumnName("FAM");
            modelBuilder.Entity<BsnEquipement>().HasRequired<BsnCdTypeqp>(c => c.BsnCdTypeqp).WithMany(t => t.BsnEquipements).HasForeignKey(u => new { u.BsnCdTypeqpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEquipement>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnEquipements).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEquipement>().ToTable("EQUIPEMENT_BSN","BSN");
            modelBuilder.Entity<BsnEquipement>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnEquipement>().Property(item => item.CdFameqpBsnFam).IsRequired();
            modelBuilder.Entity<BsnEquipement>().Property(item => item.CdFameqpBsnFam).HasMaxLength(25);
            modelBuilder.Entity<BsnEquipement>().Property(item => item.CdFameqpBsnFam).HasColumnName("CD_FAMEQP_BSN__FAM");
            modelBuilder.Entity<BsnEquipement>().Property(item => item.CdTypeqpBsnType).IsRequired();
            modelBuilder.Entity<BsnEquipement>().Property(item => item.CdTypeqpBsnType).HasMaxLength(60);
            modelBuilder.Entity<BsnEquipement>().Property(item => item.CdTypeqpBsnType).HasColumnName("CD_TYPEQP_BSN__TYPE");
            modelBuilder.Entity<BsnEquipement>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnEquipement>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnEquipement>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnEquipement>().Property(item => item.Position).IsRequired();
            modelBuilder.Entity<BsnEquipement>().Property(item => item.Position).HasMaxLength(60);
            modelBuilder.Entity<BsnEquipement>().Property(item => item.Position).HasColumnName("POSITION");
            modelBuilder.Entity<BsnEquipement>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<BsnEquipement>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<BsnEquipement>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnContact>().HasRequired<BsnDoc>(c => c.BsnDoc).WithMany(t => t.BsnContacts).HasForeignKey(u => new { u.BsnDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnContact>().ToTable("CONTACT_BSN","BSN");
            modelBuilder.Entity<BsnContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnContact>().Property(item => item.DocBsnId).IsRequired();
            modelBuilder.Entity<BsnContact>().Property(item => item.DocBsnId).HasColumnName("DOC_BSN__ID");
            modelBuilder.Entity<BsnContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<BsnContact>().Property(item => item.Givenname).HasColumnName("GIVENNAME");
            modelBuilder.Entity<BsnContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<BsnContact>().Property(item => item.Sn).HasColumnName("SN");
            modelBuilder.Entity<BsnContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<BsnContact>().Property(item => item.Cn).HasColumnName("CN");
            modelBuilder.Entity<BsnContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<BsnContact>().Property(item => item.O).HasColumnName("O");
            modelBuilder.Entity<BsnContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<BsnContact>().Property(item => item.Mail).HasColumnName("MAIL");
            modelBuilder.Entity<BsnContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<BsnContact>().Property(item => item.Telephonenumber).HasColumnName("TELEPHONENUMBER");
            modelBuilder.Entity<BsnContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<BsnContact>().Property(item => item.Mobile).HasColumnName("MOBILE");
            modelBuilder.Entity<BsnContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<BsnContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("FACSIMILETELEPHONENUMBER");
            modelBuilder.Entity<BsnContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<BsnContact>().Property(item => item.Street).HasColumnName("STREET");
            modelBuilder.Entity<BsnContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<BsnContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("MOZILLAWORKSTREET2");
            modelBuilder.Entity<BsnContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<BsnContact>().Property(item => item.L).HasColumnName("L");
            modelBuilder.Entity<BsnContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<BsnContact>().Property(item => item.Postalcode).HasColumnName("POSTALCODE");
            modelBuilder.Entity<BsnContact>().Property(item => item.Modifytimestamp).HasColumnName("MODIFYTIMESTAMP");
            modelBuilder.Entity<BsnCdUnite>().HasMany<BsnBpu>(c => c.BsnBpus).WithOptional(t => t.BsnCdUnite).HasForeignKey(u => new {u.BsnCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdUnite>().ToTable("CD_UNITE_BSN","BSN");
            modelBuilder.Entity<BsnCdUnite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdUnite>().Property(item => item.Unite).IsRequired();
            modelBuilder.Entity<BsnCdUnite>().Property(item => item.Unite).HasMaxLength(12);
            modelBuilder.Entity<BsnCdUnite>().Property(item => item.Unite).HasColumnName("UNITE");
            modelBuilder.Entity<BsnInspecteur>().HasRequired<BsnCdPresta>(c => c.BsnCdPresta).WithMany(t => t.BsnInspecteurs).HasForeignKey(u => new { u.BsnCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspecteur>().HasMany<BsnInsp>(c => c.BsnInsps).WithOptional(t => t.BsnInspecteur).HasForeignKey(u => new {u.BsnInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspecteur>().HasMany<BsnVst>(c => c.BsnVsts).WithOptional(t => t.BsnInspecteur).HasForeignKey(u => new {u.BsnInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspecteur>().HasMany<BsnInspTmp>(c => c.BsnInspTmps).WithOptional(t => t.BsnInspecteur).HasForeignKey(u => new {u.BsnInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspecteur>().ToTable("INSPECTEUR_BSN","BSN");
            modelBuilder.Entity<BsnInspecteur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.CdPrestaBsnPrestataire).IsRequired();
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.CdPrestaBsnPrestataire).HasMaxLength(50);
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.CdPrestaBsnPrestataire).HasColumnName("CD_PRESTA_BSN__PRESTATAIRE");
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.Fonc).HasMaxLength(60);
            modelBuilder.Entity<BsnInspecteur>().Property(item => item.Fonc).HasColumnName("FONC");
            modelBuilder.Entity<BsnCdComposant>().HasMany<BsnCdEntete>(c => c.BsnCdEntetes).WithRequired(t => t.BsnCdComposant).HasForeignKey(u => new {u.BsnCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdComposant>().ToTable("CD_COMPOSANT_BSN","BSN");
            modelBuilder.Entity<BsnCdComposant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdComposant>().Property(item => item.TypeComp).IsRequired();
            modelBuilder.Entity<BsnCdComposant>().Property(item => item.TypeComp).HasMaxLength(6);
            modelBuilder.Entity<BsnCdComposant>().Property(item => item.TypeComp).HasColumnName("TYPE_COMP");
            modelBuilder.Entity<BsnCdComposant>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<BsnCdComposant>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdSousType>().HasMany<BsnDsc>(c => c.BsnDscs).WithOptional(t => t.BsnCdSousType).HasForeignKey(u => new {u.BsnCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdSousType>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithOptional(t => t.BsnCdSousType).HasForeignKey(u => new {u.BsnCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdSousType>().ToTable("CD_SOUS_TYPE_BSN","BSN");
            modelBuilder.Entity<BsnCdSousType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdSousType>().Property(item => item.NatSensib).IsRequired();
            modelBuilder.Entity<BsnCdSousType>().Property(item => item.NatSensib).HasMaxLength(60);
            modelBuilder.Entity<BsnCdSousType>().Property(item => item.NatSensib).HasColumnName("NAT_SENSIB");
            modelBuilder.Entity<BsnCdFrequence>().HasMany<BsnDsc>(c => c.BsnDscs).WithOptional(t => t.BsnCdFrequence).HasForeignKey(u => new {u.BsnCdFrequenceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdFrequence>().HasMany<BsnDscTemp>(c => c.BsnDscTemps).WithOptional(t => t.BsnCdFrequence).HasForeignKey(u => new {u.BsnCdFrequenceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdFrequence>().ToTable("CD_FREQUENCE_BSN","BSN");
            modelBuilder.Entity<BsnCdFrequence>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdFrequence>().Property(item => item.Freq).IsRequired();
            modelBuilder.Entity<BsnCdFrequence>().Property(item => item.Freq).HasMaxLength(25);
            modelBuilder.Entity<BsnCdFrequence>().Property(item => item.Freq).HasColumnName("FREQ");
            modelBuilder.Entity<BsnCdRole>().HasMany<BsnCdRoleDsc>(c => c.BsnCdRoleDscs).WithRequired(t => t.BsnCdRole).HasForeignKey(u => new {u.BsnCdRoleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdRole>().ToTable("CD_ROLE_BSN","BSN");
            modelBuilder.Entity<BsnCdRole>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdRole>().Property(item => item.Role).IsRequired();
            modelBuilder.Entity<BsnCdRole>().Property(item => item.Role).HasMaxLength(25);
            modelBuilder.Entity<BsnCdRole>().Property(item => item.Role).HasColumnName("ROLE");
            modelBuilder.Entity<BsnCdConclusion>().HasMany<BsnCdConclusionInsp>(c => c.BsnCdConclusionInsps).WithRequired(t => t.BsnCdConclusion).HasForeignKey(u => new {u.BsnCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdConclusion>().HasMany<BsnCdConclusionInspTmp>(c => c.BsnCdConclusionInspTmps).WithRequired(t => t.BsnCdConclusion).HasForeignKey(u => new {u.BsnCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdConclusion>().ToTable("CD_CONCLUSION_BSN","BSN");
            modelBuilder.Entity<BsnCdConclusion>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdConclusion>().Property(item => item.IdConc).IsRequired();
            modelBuilder.Entity<BsnCdConclusion>().Property(item => item.IdConc).HasColumnName("ID_CONC");
            modelBuilder.Entity<BsnCdConclusion>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<BsnCdConclusion>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<BsnCdConclusion>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<BsnCdConclusion>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<BsnCdConclusion>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<BsnDscTemp>().HasRequired<BsnCdFam>(c => c.BsnCdFam).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new { u.BsnCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasRequired<BsnCdType>(c => c.BsnCdType).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new { u.BsnCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasOptional<BsnCdSousType>(c => c.BsnCdSousType).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new {u.BsnCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasOptional<BsnCdEntp>(c => c.BsnCdEntp).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new {u.BsnCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasOptional<BsnCdExt>(c => c.BsnCdExt).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new {u.BsnCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasOptional<BsnCdPermeable>(c => c.BsnCdPermeable).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new {u.BsnCdPermeableIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasOptional<BsnCdFrequence>(c => c.BsnCdFrequence).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new {u.BsnCdFrequenceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasOptional<BsnCdAcces>(c => c.BsnCdAcces).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new {u.BsnCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasRequired<BsnCamp>(c => c.BsnCamp).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new { u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasOptional<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnDscTemps).HasForeignKey(u => new {u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().HasMany<BsnInspTmp>(c => c.BsnInspTmps).WithRequired(t => t.BsnDscTemp).HasForeignKey(u => new {u.BsnDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscTemp>().ToTable("DSC_TEMP_BSN","BSN");
            modelBuilder.Entity<BsnDscTemp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.NumBsn).IsRequired();
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.NumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.NumBsn).HasColumnName("NUM_BSN");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdPermeableBsnType).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdPermeableBsnType).HasColumnName("CD_PERMEABLE_BSN__TYPE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdSousTypeBsnNatSensib).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdSousTypeBsnNatSensib).HasColumnName("CD_SOUS_TYPE_BSN__NAT_SENSIB");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdExtBsnType).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdExtBsnType).HasColumnName("CD_EXT_BSN__TYPE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdTypeBsnType).IsRequired();
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdTypeBsnType).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdTypeBsnType).HasColumnName("CD_TYPE_BSN__TYPE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdAccesBsnVacces).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdAccesBsnVacces).HasColumnName("CD_ACCES_BSN__VACCES");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdFamBsnFamille).IsRequired();
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdFamBsnFamille).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdFamBsnFamille).HasColumnName("CD_FAM_BSN__FAMILLE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdFrequenceBsnFreq).HasMaxLength(25);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdFrequenceBsnFreq).HasColumnName("CD_FREQUENCE_BSN__FREQ");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdEntpBsnEntreprise).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.CdEntpBsnEntreprise).HasColumnName("CD_ENTP_BSN__ENTREPRISE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.VolUtil).HasColumnName("VOL_UTIL");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.VolMor).HasColumnName("VOL_MOR");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.VolPoll).HasColumnName("VOL_POLL");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.VolIncen).HasColumnName("VOL_INCEN");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DureePluie).HasColumnName("DUREE_PLUIE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.FauneFlore).HasMaxLength(60);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.FauneFlore).HasColumnName("FAUNE_FLORE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.SurfVersant).HasColumnName("SURF_VERSANT");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DebitMax).HasColumnName("DEBIT_MAX");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.TpsConcent).HasColumnName("TPS_CONCENT");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Vehicule).HasMaxLength(255);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Vehicule).HasColumnName("VEHICULE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Pieton).HasMaxLength(255);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Pieton).HasColumnName("PIETON");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<BsnDscTemp>().Ignore(item => item.Securite);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<BsnDscTemp>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.OuvAval).HasMaxLength(200);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.OuvAval).HasColumnName("OUV_AVAL");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.LoiEauValueInt).HasColumnName("LOI_EAU");
            modelBuilder.Entity<BsnDscTemp>().Ignore(item => item.LoiEau);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.EauxCollect).HasMaxLength(200);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.EauxCollect).HasColumnName("EAUX_COLLECT");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<BsnDscTemp>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<BsnDscTemp>().Ignore(item => item.Terrain);
            modelBuilder.Entity<BsnPhotoInspTmp>().HasRequired<BsnInspTmp>(c => c.BsnInspTmp).WithMany(t => t.BsnPhotoInspTmps).HasForeignKey(u => new { u.BsnInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPhotoInspTmp>().ToTable("PHOTO_INSP_TMP_BSN","BSN");
            modelBuilder.Entity<BsnPhotoInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.DscTempBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.DscTempBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.DscTempBsnNumBsn).HasColumnName("DSC_TEMP_BSN__NUM_BSN");
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().HasRequired<BsnEltInspTmp>(c => c.BsnEltInspTmp).WithMany(t => t.BsnPhotoEltInspTmps).HasForeignKey(u => new { u.BsnEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnPhotoEltInspTmp>().ToTable("PHOTO_ELT_INSP_TMP_BSN","BSN");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.GrpBsnIdGrp).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.GrpBsnIdGrp).HasColumnName("GRP_BSN__ID_GRP");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.PrtBsnIdPrt).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.PrtBsnIdPrt).HasColumnName("PRT_BSN__ID_PRT");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.SprtBsnIdSprt).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.SprtBsnIdSprt).HasColumnName("SPRT_BSN__ID_SPRT");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.DscTempBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.DscTempBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.DscTempBsnNumBsn).HasColumnName("DSC_TEMP_BSN__NUM_BSN");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.EltBsnIdElem).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.EltBsnIdElem).HasColumnName("ELT_BSN__ID_ELEM");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<BsnPhotoEltInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<BsnEltInspTmp>().HasRequired<BsnInspTmp>(c => c.BsnInspTmp).WithMany(t => t.BsnEltInspTmps).HasForeignKey(u => new { u.BsnInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEltInspTmp>().HasRequired<BsnElt>(c => c.BsnElt).WithMany(t => t.BsnEltInspTmps).HasForeignKey(u => new { u.BsnEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEltInspTmp>().HasMany<BsnPhotoEltInspTmp>(c => c.BsnPhotoEltInspTmps).WithRequired(t => t.BsnEltInspTmp).HasForeignKey(u => new {u.BsnEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnEltInspTmp>().ToTable("ELT_INSP_TMP_BSN","BSN");
            modelBuilder.Entity<BsnEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.DscTempBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.DscTempBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.DscTempBsnNumBsn).HasColumnName("DSC_TEMP_BSN__NUM_BSN");
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.GrpBsnIdGrp).IsRequired();
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.GrpBsnIdGrp).HasColumnName("GRP_BSN__ID_GRP");
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.PrtBsnIdPrt).IsRequired();
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.PrtBsnIdPrt).HasColumnName("PRT_BSN__ID_PRT");
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.SprtBsnIdSprt).IsRequired();
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.SprtBsnIdSprt).HasColumnName("SPRT_BSN__ID_SPRT");
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.EltBsnIdElem).IsRequired();
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.EltBsnIdElem).HasColumnName("ELT_BSN__ID_ELEM");
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<BsnEltInspTmp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<BsnInspTmp>().HasOptional<BsnCdEtude>(c => c.BsnCdEtude).WithMany(t => t.BsnInspTmps).HasForeignKey(u => new {u.BsnCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspTmp>().HasOptional<BsnCdMeteo>(c => c.BsnCdMeteo).WithMany(t => t.BsnInspTmps).HasForeignKey(u => new {u.BsnCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspTmp>().HasRequired<BsnDscTemp>(c => c.BsnDscTemp).WithMany(t => t.BsnInspTmps).HasForeignKey(u => new { u.BsnDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspTmp>().HasOptional<BsnInspecteur>(c => c.BsnInspecteur).WithMany(t => t.BsnInspTmps).HasForeignKey(u => new {u.BsnInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspTmp>().HasMany<BsnPhotoInspTmp>(c => c.BsnPhotoInspTmps).WithRequired(t => t.BsnInspTmp).HasForeignKey(u => new {u.BsnInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspTmp>().HasMany<BsnEltInspTmp>(c => c.BsnEltInspTmps).WithRequired(t => t.BsnInspTmp).HasForeignKey(u => new {u.BsnInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspTmp>().HasMany<BsnCdConclusionInspTmp>(c => c.BsnCdConclusionInspTmps).WithRequired(t => t.BsnInspTmp).HasForeignKey(u => new {u.BsnInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnInspTmp>().ToTable("INSP_TMP_BSN","BSN");
            modelBuilder.Entity<BsnInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.DscTempBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.DscTempBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.DscTempBsnNumBsn).HasColumnName("DSC_TEMP_BSN__NUM_BSN");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.InspecteurBsnNom).HasMaxLength(60);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.InspecteurBsnNom).HasColumnName("INSPECTEUR_BSN__NOM");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.CdMeteoBsnMeteo).HasMaxLength(60);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.CdMeteoBsnMeteo).HasColumnName("CD_METEO_BSN__METEO");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.CdEtudeBsnEtude).HasMaxLength(65);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.CdEtudeBsnEtude).HasColumnName("CD_ETUDE_BSN__ETUDE");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.NomValid).HasMaxLength(250);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<BsnInspTmp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<BsnClsDoc>().HasRequired<BsnCls>(c => c.BsnCls).WithMany(t => t.BsnClsDocs).HasForeignKey(u => new { u.BsnClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnClsDoc>().HasRequired<BsnDoc>(c => c.BsnDoc).WithMany(t => t.BsnClsDocs).HasForeignKey(u => new { u.BsnDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnClsDoc>().ToTable("CLS_DOC_BSN","BSN");
            modelBuilder.Entity<BsnClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnClsDoc>().Property(item => item.ClsBsnId).IsRequired();
            modelBuilder.Entity<BsnClsDoc>().Property(item => item.ClsBsnId).HasColumnName("CLS_BSN__ID");
            modelBuilder.Entity<BsnClsDoc>().Property(item => item.DocBsnId).IsRequired();
            modelBuilder.Entity<BsnClsDoc>().Property(item => item.DocBsnId).HasColumnName("DOC_BSN__ID");
            modelBuilder.Entity<BsnClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<BsnClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<BsnClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<BsnClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
            modelBuilder.Entity<BsnCdConclusionInsp>().HasRequired<BsnInsp>(c => c.BsnInsp).WithMany(t => t.BsnCdConclusionInsps).HasForeignKey(u => new { u.BsnInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdConclusionInsp>().HasRequired<BsnCdConclusion>(c => c.BsnCdConclusion).WithMany(t => t.BsnCdConclusionInsps).HasForeignKey(u => new { u.BsnCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdConclusionInsp>().ToTable("CD_CONCLUSION__INSP_BSN","BSN");
            modelBuilder.Entity<BsnCdConclusionInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.CdConclusionBsnIdConc).IsRequired();
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.CdConclusionBsnIdConc).HasColumnName("CD_CONCLUSION_BSN__ID_CONC");
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<BsnCdConclusionInsp>().Property(item => item.Contenu).HasColumnName("CONTENU");
            modelBuilder.Entity<BsnDscCamp>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnDscCamps).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscCamp>().HasRequired<BsnCamp>(c => c.BsnCamp).WithMany(t => t.BsnDscCamps).HasForeignKey(u => new { u.BsnCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnDscCamp>().ToTable("DSC_CAMP_BSN","BSN");
            modelBuilder.Entity<BsnDscCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnDscCamp>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnDscCamp>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnDscCamp>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnDscCamp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnDscCamp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnDscCamp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnDscCamp>().Property(item => item.RealiserValueInt).HasColumnName("REALISER");
            modelBuilder.Entity<BsnDscCamp>().Ignore(item => item.Realiser);
            modelBuilder.Entity<BsnCdPrecoSprtVst>().HasRequired<BsnBpu>(c => c.BsnBpu).WithMany(t => t.BsnCdPrecoSprtVsts).HasForeignKey(u => new { u.BsnBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdPrecoSprtVst>().HasRequired<BsnSprtVst>(c => c.BsnSprtVst).WithMany(t => t.BsnCdPrecoSprtVsts).HasForeignKey(u => new { u.BsnSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdPrecoSprtVst>().ToTable("CD_PRECO__SPRT_VST_BSN","BSN");
            modelBuilder.Entity<BsnCdPrecoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.CdChapitreBsnIdChap).IsRequired();
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.CdChapitreBsnIdChap).HasColumnName("CD_CHAPITRE_BSN__ID_CHAP");
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.CdLigneBsnIdLigne).IsRequired();
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.CdLigneBsnIdLigne).HasColumnName("CD_LIGNE_BSN__ID_LIGNE");
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.BpuBsnIdBpu).IsRequired();
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.BpuBsnIdBpu).HasColumnName("BPU_BSN__ID_BPU");
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<BsnCdPrecoSprtVst>().Ignore(item => item.Realise);
            modelBuilder.Entity<BsnCdRoleDsc>().HasRequired<BsnDsc>(c => c.BsnDsc).WithMany(t => t.BsnCdRoleDscs).HasForeignKey(u => new { u.BsnDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdRoleDsc>().HasRequired<BsnCdRole>(c => c.BsnCdRole).WithMany(t => t.BsnCdRoleDscs).HasForeignKey(u => new { u.BsnCdRoleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdRoleDsc>().ToTable("CD_ROLE__DSC_BSN","BSN");
            modelBuilder.Entity<BsnCdRoleDsc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdRoleDsc>().Property(item => item.DscBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnCdRoleDsc>().Property(item => item.DscBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnCdRoleDsc>().Property(item => item.DscBsnNumBsn).HasColumnName("DSC_BSN__NUM_BSN");
            modelBuilder.Entity<BsnCdRoleDsc>().Property(item => item.CdRoleBsnRole).IsRequired();
            modelBuilder.Entity<BsnCdRoleDsc>().Property(item => item.CdRoleBsnRole).HasMaxLength(25);
            modelBuilder.Entity<BsnCdRoleDsc>().Property(item => item.CdRoleBsnRole).HasColumnName("CD_ROLE_BSN__ROLE");
            modelBuilder.Entity<BsnCdConclusionInspTmp>().HasRequired<BsnCdConclusion>(c => c.BsnCdConclusion).WithMany(t => t.BsnCdConclusionInspTmps).HasForeignKey(u => new { u.BsnCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdConclusionInspTmp>().HasRequired<BsnInspTmp>(c => c.BsnInspTmp).WithMany(t => t.BsnCdConclusionInspTmps).HasForeignKey(u => new { u.BsnInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<BsnCdConclusionInspTmp>().ToTable("CD_CONCLUSION__INSP_TMP_BSN","BSN");
            modelBuilder.Entity<BsnCdConclusionInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.CampBsnIdCamp).IsRequired();
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.CampBsnIdCamp).HasMaxLength(100);
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.CampBsnIdCamp).HasColumnName("CAMP_BSN__ID_CAMP");
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.DscTempBsnNumBsn).IsRequired();
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.DscTempBsnNumBsn).HasMaxLength(20);
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.DscTempBsnNumBsn).HasColumnName("DSC_TEMP_BSN__NUM_BSN");
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.CdConclusionBsnIdConc).IsRequired();
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.CdConclusionBsnIdConc).HasColumnName("CD_CONCLUSION_BSN__ID_CONC");
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<BsnCdConclusionInspTmp>().Property(item => item.Contenu).HasColumnName("CONTENU");
        }
    }
}
