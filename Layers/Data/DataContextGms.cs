using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextGms : DataContextBase
    {
        public DataContextGms(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<GmsCdType> GmsCdTypes { get; set; }
        
        public DbSet<GmsCdFam> GmsCdFams { get; set; }
        
        public DbSet<GmsCdEntp> GmsCdEntps { get; set; }
        
        public DbSet<GmsDsc> GmsDscs { get; set; }
        
        public DbSet<GmsCls> GmsClss { get; set; }
        
        public DbSet<GmsDoc> GmsDocs { get; set; }
        
        public DbSet<GmsCdDoc> GmsCdDocs { get; set; }
        
        public DbSet<GmsElt> GmsElts { get; set; }
        
        public DbSet<GmsSprt> GmsSprts { get; set; }
        
        public DbSet<GmsPrt> GmsPrts { get; set; }
        
        public DbSet<GmsGrp> GmsGrps { get; set; }
        
        public DbSet<GmsEltInsp> GmsEltInsps { get; set; }
        
        public DbSet<GmsCdMeteo> GmsCdMeteos { get; set; }
        
        public DbSet<GmsTravaux> GmsTravauxs { get; set; }
        
        public DbSet<GmsNatureTrav> GmsNatureTravs { get; set; }
        
        public DbSet<GmsCdTravaux> GmsCdTravauxs { get; set; }
        
        public DbSet<GmsCdPoutre> GmsCdPoutres { get; set; }
        
        public DbSet<GmsPrevision> GmsPrevisions { get; set; }
        
        public DbSet<GmsCdAncrage> GmsCdAncrages { get; set; }
        
        public DbSet<GmsPanneau> GmsPanneaus { get; set; }
        
        public DbSet<GmsCdPanneau> GmsCdPanneaus { get; set; }
        
        public DbSet<GmsCdAcces> GmsCdAccess { get; set; }
        
        public DbSet<GmsSysUser> GmsSysUsers { get; set; }
        
        public DbSet<GmsBpu> GmsBpus { get; set; }
        
        public DbSet<GmsCdContrainte> GmsCdContraintes { get; set; }
        
        public DbSet<GmsCamp> GmsCamps { get; set; }
        
        public DbSet<GmsCdPresta> GmsCdPrestas { get; set; }
        
        public DbSet<GmsCdTypePv> GmsCdTypePvs { get; set; }
        
        public DbSet<GmsPhotoEltInsp> GmsPhotoEltInsps { get; set; }
        
        public DbSet<GmsInsp> GmsInsps { get; set; }
        
        public DbSet<GmsPhotoInsp> GmsPhotoInsps { get; set; }
        
        public DbSet<GmsCdEtude> GmsCdEtudes { get; set; }
        
        public DbSet<GmsSeuilQualite> GmsSeuilQualites { get; set; }
        
        public DbSet<GmsSeuilUrgence> GmsSeuilUrgences { get; set; }
        
        public DbSet<GmsSprtVst> GmsSprtVsts { get; set; }
        
        public DbSet<GmsPhotoSprtVst> GmsPhotoSprtVsts { get; set; }
        
        public DbSet<GmsPhotoVst> GmsPhotoVsts { get; set; }
        
        public DbSet<GmsCdPosPan> GmsCdPosPans { get; set; }
        
        public DbSet<GmsCdPosMat> GmsCdPosMats { get; set; }
        
        public DbSet<GmsCdQualite> GmsCdQualites { get; set; }
        
        public DbSet<GmsCdProtec> GmsCdProtecs { get; set; }
        
        public DbSet<GmsHistoNote> GmsHistoNotes { get; set; }
        
        public DbSet<GmsCdOrigin> GmsCdOrigins { get; set; }
        
        public DbSet<GmsDictionnaire> GmsDictionnaires { get; set; }
        
        public DbSet<GmsCdEvt> GmsCdEvts { get; set; }
        
        public DbSet<GmsEvt> GmsEvts { get; set; }
        
        public DbSet<GmsCdInterface> GmsCdInterfaces { get; set; }
        
        public DbSet<GmsCdFournisseur> GmsCdFournisseurs { get; set; }
        
        public DbSet<GmsCdPoteau> GmsCdPoteaus { get; set; }
        
        public DbSet<GmsCdEntete> GmsCdEntetes { get; set; }
        
        public DbSet<GmsCdChapitre> GmsCdChapitres { get; set; }
        
        public DbSet<GmsCdLigne> GmsCdLignes { get; set; }
        
        public DbSet<GmsEntete> GmsEntetes { get; set; }
        
        public DbSet<GmsContact> GmsContacts { get; set; }
        
        public DbSet<GmsCdUnite> GmsCdUnites { get; set; }
        
        public DbSet<GmsInspecteur> GmsInspecteurs { get; set; }
        
        public DbSet<GmsCdComposant> GmsCdComposants { get; set; }
        
        public DbSet<GmsVst> GmsVsts { get; set; }
        
        public DbSet<GmsCdConclusion> GmsCdConclusions { get; set; }
        
        public DbSet<GmsDscTemp> GmsDscTemps { get; set; }
        
        public DbSet<GmsEltInspTmp> GmsEltInspTmps { get; set; }
        
        public DbSet<GmsPhotoEltInspTmp> GmsPhotoEltInspTmps { get; set; }
        
        public DbSet<GmsInspTmp> GmsInspTmps { get; set; }
        
        public DbSet<GmsPhotoInspTmp> GmsPhotoInspTmps { get; set; }
        
        public DbSet<GmsClsDoc> GmsClsDocs { get; set; }
        
        public DbSet<GmsDscCamp> GmsDscCamps { get; set; }
        
        public DbSet<GmsCdPrecoSprtVst> GmsCdPrecoSprtVsts { get; set; }
        
        public DbSet<GmsCdConclusionInsp> GmsCdConclusionInsps { get; set; }
        
        public DbSet<GmsCdConclusionInspTmp> GmsCdConclusionInspTmps { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<GmsCdType>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdType).HasForeignKey(u => new {u.GmsCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdType>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdType).HasForeignKey(u => new {u.GmsCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdType>().ToTable("CD_TYPE_GMS","GMS");
            modelBuilder.Entity<GmsCdType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdType>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdType>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GmsCdType>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsCdFam>().HasMany<GmsDsc>(c => c.GmsDscs).WithRequired(t => t.GmsCdFam).HasForeignKey(u => new {u.GmsCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdFam>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithRequired(t => t.GmsCdFam).HasForeignKey(u => new {u.GmsCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdFam>().ToTable("CD_FAM_GMS","GMS");
            modelBuilder.Entity<GmsCdFam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdFam>().Property(item => item.Famille).IsRequired();
            modelBuilder.Entity<GmsCdFam>().Property(item => item.Famille).HasMaxLength(20);
            modelBuilder.Entity<GmsCdFam>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<GmsCdFam>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GmsCdFam>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdEntp>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdEntp).HasForeignKey(u => new {u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEntp>().HasMany<GmsTravaux>(c => c.GmsTravauxs).WithRequired(t => t.GmsCdEntp).HasForeignKey(u => new {u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEntp>().HasMany<GmsPanneau>(c => c.GmsPanneaus).WithOptional(t => t.GmsCdEntp).HasForeignKey(u => new {u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEntp>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdEntp).HasForeignKey(u => new {u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEntp>().ToTable("CD_ENTP_GMS","GMS");
            modelBuilder.Entity<GmsCdEntp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdEntp>().Property(item => item.Entreprise).IsRequired();
            modelBuilder.Entity<GmsCdEntp>().Property(item => item.Entreprise).HasMaxLength(60);
            modelBuilder.Entity<GmsCdEntp>().Property(item => item.Entreprise).HasColumnName("ENTREPRISE");
            modelBuilder.Entity<GmsDsc>().HasRequired<GmsCdFam>(c => c.GmsCdFam).WithMany(t => t.GmsDscs).HasForeignKey(u => new { u.GmsCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdEntp>(c => c.GmsCdEntp).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdPoutre>(c => c.GmsCdPoutre).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdPoutreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdType>(c => c.GmsCdType).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdAncrage>(c => c.GmsCdAncrage).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdAncrageIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdAcces>(c => c.GmsCdAcces).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasRequired<GmsCdPosMat>(c => c.GmsCdPosMat).WithMany(t => t.GmsDscs).HasForeignKey(u => new { u.GmsCdPosMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdQualite>(c => c.GmsCdQualite).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdProtec>(c => c.GmsCdProtec).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdProtecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdInterface>(c => c.GmsCdInterface).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdInterfaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdFournisseur>(c => c.GmsCdFournisseur).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdFournisseurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasOptional<GmsCdPoteau>(c => c.GmsCdPoteau).WithMany(t => t.GmsDscs).HasForeignKey(u => new {u.GmsCdPoteauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsTravaux>(c => c.GmsTravauxs).WithRequired(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsPrevision>(c => c.GmsPrevisions).WithRequired(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsInsp>(c => c.GmsInsps).WithRequired(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsVst>(c => c.GmsVsts).WithRequired(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsHistoNote>(c => c.GmsHistoNotes).WithRequired(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsEvt>(c => c.GmsEvts).WithRequired(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().HasMany<GmsDscCamp>(c => c.GmsDscCamps).WithRequired(t => t.GmsDsc).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDsc>().ToTable("DSC_GMS","GMS");
            modelBuilder.Entity<GmsDsc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsDsc>().Property(item => item.NumGms).IsRequired();
            modelBuilder.Entity<GmsDsc>().Property(item => item.NumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsDsc>().Property(item => item.NumGms).HasColumnName("NUM_GMS");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdPoteauGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdPoteauGmsType).HasColumnName("CD_POTEAU_GMS__TYPE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdPosMatGmsPosit).IsRequired();
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdPosMatGmsPosit).HasMaxLength(4);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdPosMatGmsPosit).HasColumnName("CD_POS_MAT_GMS__POSIT");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdEntpGmsEntreprise).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdEntpGmsEntreprise).HasColumnName("CD_ENTP_GMS__ENTREPRISE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdAncrageGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdAncrageGmsType).HasColumnName("CD_ANCRAGE_GMS__TYPE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdAccesGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdAccesGmsType).HasColumnName("CD_ACCES_GMS__TYPE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdPoutreGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdPoutreGmsType).HasColumnName("CD_POUTRE_GMS__TYPE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdFournisseurGmsNom).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdFournisseurGmsNom).HasColumnName("CD_FOURNISSEUR_GMS__NOM");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdFamGmsFamille).IsRequired();
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdFamGmsFamille).HasMaxLength(20);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdFamGmsFamille).HasColumnName("CD_FAM_GMS__FAMILLE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdTypeGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdTypeGmsType).HasColumnName("CD_TYPE_GMS__TYPE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdInterfaceGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdInterfaceGmsType).HasColumnName("CD_INTERFACE_GMS__TYPE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdQualiteGmsQualite).HasMaxLength(25);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdQualiteGmsQualite).HasColumnName("CD_QUALITE_GMS__QUALITE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdProtecGmsProtec).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CdProtecGmsProtec).HasColumnName("CD_PROTEC_GMS__PROTEC");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<GmsDsc>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<GmsDsc>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<GmsDsc>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<GmsDsc>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<GmsDsc>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<GmsDsc>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<GmsDsc>().Property(item => item.NumExploit).HasMaxLength(17);
            modelBuilder.Entity<GmsDsc>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<GmsDsc>().Property(item => item.NomUsage).HasMaxLength(255);
            modelBuilder.Entity<GmsDsc>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<GmsDsc>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Haut).HasColumnName("HAUT");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Tirair).HasColumnName("TIRAIR");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Vent).HasColumnName("VENT");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Ancrage).HasMaxLength(60);
            modelBuilder.Entity<GmsDsc>().Property(item => item.Ancrage).HasColumnName("ANCRAGE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Larg).HasColumnName("LARG");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Traverse).HasColumnName("TRAVERSE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Element).HasColumnName("ELEMENT");
            modelBuilder.Entity<GmsDsc>().Property(item => item.NbPoteaux).HasColumnName("NB_POTEAUX");
            modelBuilder.Entity<GmsDsc>().Property(item => item.EclairageValueInt).HasColumnName("ECLAIRAGE");
            modelBuilder.Entity<GmsDsc>().Ignore(item => item.Eclairage);
            modelBuilder.Entity<GmsDsc>().Property(item => item.CondamneValueInt).HasColumnName("CONDAMNE");
            modelBuilder.Entity<GmsDsc>().Ignore(item => item.Condamne);
            modelBuilder.Entity<GmsDsc>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GmsDsc>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GmsDsc>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GmsDsc>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<GmsDsc>().Ignore(item => item.Securite);
            modelBuilder.Entity<GmsDsc>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GmsDsc>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GmsDsc>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<GmsDsc>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<GmsDsc>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<GmsDsc>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<GmsDsc>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<GmsDsc>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<GmsDsc>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<GmsDsc>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<GmsDsc>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<GmsDsc>().Ignore(item => item.Terrain);
            modelBuilder.Entity<GmsCls>().HasMany<GmsClsDoc>(c => c.GmsClsDocs).WithRequired(t => t.GmsCls).HasForeignKey(u => new {u.GmsClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCls>().ToTable("CLS_GMS","GMS");
            modelBuilder.Entity<GmsCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsCls>().Property(item => item.TableName).HasMaxLength(30);
            modelBuilder.Entity<GmsCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<GmsCls>().Property(item => item.KeyValue).HasMaxLength(100);
            modelBuilder.Entity<GmsCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<GmsDoc>().HasRequired<GmsCdDoc>(c => c.GmsCdDoc).WithMany(t => t.GmsDocs).HasForeignKey(u => new { u.GmsCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDoc>().HasMany<GmsContact>(c => c.GmsContacts).WithRequired(t => t.GmsDoc).HasForeignKey(u => new {u.GmsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDoc>().HasMany<GmsClsDoc>(c => c.GmsClsDocs).WithRequired(t => t.GmsDoc).HasForeignKey(u => new {u.GmsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDoc>().ToTable("DOC_GMS","GMS");
            modelBuilder.Entity<GmsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsDoc>().Property(item => item.CdDocGmsCode).IsRequired();
            modelBuilder.Entity<GmsDoc>().Property(item => item.CdDocGmsCode).HasMaxLength(15);
            modelBuilder.Entity<GmsDoc>().Property(item => item.CdDocGmsCode).HasColumnName("CD_DOC_GMS__CODE");
            modelBuilder.Entity<GmsDoc>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<GmsDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<GmsDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<GmsCdDoc>().HasMany<GmsDoc>(c => c.GmsDocs).WithRequired(t => t.GmsCdDoc).HasForeignKey(u => new {u.GmsCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdDoc>().ToTable("CD_DOC_GMS","GMS");
            modelBuilder.Entity<GmsCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GmsCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<GmsCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GmsCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GmsCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<GmsCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<GmsElt>().HasRequired<GmsSprt>(c => c.GmsSprt).WithMany(t => t.GmsElts).HasForeignKey(u => new { u.GmsSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsElt>().HasMany<GmsEltInsp>(c => c.GmsEltInsps).WithRequired(t => t.GmsElt).HasForeignKey(u => new {u.GmsEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsElt>().HasMany<GmsEltInspTmp>(c => c.GmsEltInspTmps).WithRequired(t => t.GmsElt).HasForeignKey(u => new {u.GmsEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsElt>().ToTable("ELT_GMS","GMS");
            modelBuilder.Entity<GmsElt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsElt>().Property(item => item.GrpGmsIdGrp).IsRequired();
            modelBuilder.Entity<GmsElt>().Property(item => item.GrpGmsIdGrp).HasColumnName("GRP_GMS__ID_GRP");
            modelBuilder.Entity<GmsElt>().Property(item => item.PrtGmsIdPrt).IsRequired();
            modelBuilder.Entity<GmsElt>().Property(item => item.PrtGmsIdPrt).HasColumnName("PRT_GMS__ID_PRT");
            modelBuilder.Entity<GmsElt>().Property(item => item.SprtGmsIdSprt).IsRequired();
            modelBuilder.Entity<GmsElt>().Property(item => item.SprtGmsIdSprt).HasColumnName("SPRT_GMS__ID_SPRT");
            modelBuilder.Entity<GmsElt>().Property(item => item.IdElem).IsRequired();
            modelBuilder.Entity<GmsElt>().Property(item => item.IdElem).HasColumnName("ID_ELEM");
            modelBuilder.Entity<GmsElt>().Property(item => item.Libe).IsRequired();
            modelBuilder.Entity<GmsElt>().Property(item => item.Libe).HasMaxLength(500);
            modelBuilder.Entity<GmsElt>().Property(item => item.Libe).HasColumnName("LIBE");
            modelBuilder.Entity<GmsElt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GmsElt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GmsElt>().Property(item => item.Aide).HasMaxLength(500);
            modelBuilder.Entity<GmsElt>().Property(item => item.Aide).HasColumnName("AIDE");
            modelBuilder.Entity<GmsElt>().Property(item => item.Indice1).HasMaxLength(500);
            modelBuilder.Entity<GmsElt>().Property(item => item.Indice1).HasColumnName("INDICE1");
            modelBuilder.Entity<GmsElt>().Property(item => item.Indice2).HasMaxLength(500);
            modelBuilder.Entity<GmsElt>().Property(item => item.Indice2).HasColumnName("INDICE2");
            modelBuilder.Entity<GmsElt>().Property(item => item.Indice3).HasMaxLength(500);
            modelBuilder.Entity<GmsElt>().Property(item => item.Indice3).HasColumnName("INDICE3");
            modelBuilder.Entity<GmsSprt>().HasRequired<GmsPrt>(c => c.GmsPrt).WithMany(t => t.GmsSprts).HasForeignKey(u => new { u.GmsPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsSprt>().HasMany<GmsElt>(c => c.GmsElts).WithRequired(t => t.GmsSprt).HasForeignKey(u => new {u.GmsSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsSprt>().ToTable("SPRT_GMS","GMS");
            modelBuilder.Entity<GmsSprt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsSprt>().Property(item => item.GrpGmsIdGrp).IsRequired();
            modelBuilder.Entity<GmsSprt>().Property(item => item.GrpGmsIdGrp).HasColumnName("GRP_GMS__ID_GRP");
            modelBuilder.Entity<GmsSprt>().Property(item => item.PrtGmsIdPrt).IsRequired();
            modelBuilder.Entity<GmsSprt>().Property(item => item.PrtGmsIdPrt).HasColumnName("PRT_GMS__ID_PRT");
            modelBuilder.Entity<GmsSprt>().Property(item => item.IdSprt).IsRequired();
            modelBuilder.Entity<GmsSprt>().Property(item => item.IdSprt).HasColumnName("ID_SPRT");
            modelBuilder.Entity<GmsSprt>().Property(item => item.Libs).IsRequired();
            modelBuilder.Entity<GmsSprt>().Property(item => item.Libs).HasMaxLength(500);
            modelBuilder.Entity<GmsSprt>().Property(item => item.Libs).HasColumnName("LIBS");
            modelBuilder.Entity<GmsSprt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GmsSprt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GmsPrt>().HasRequired<GmsGrp>(c => c.GmsGrp).WithMany(t => t.GmsPrts).HasForeignKey(u => new { u.GmsGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPrt>().HasMany<GmsSprt>(c => c.GmsSprts).WithRequired(t => t.GmsPrt).HasForeignKey(u => new {u.GmsPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPrt>().ToTable("PRT_GMS","GMS");
            modelBuilder.Entity<GmsPrt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPrt>().Property(item => item.GrpGmsIdGrp).IsRequired();
            modelBuilder.Entity<GmsPrt>().Property(item => item.GrpGmsIdGrp).HasColumnName("GRP_GMS__ID_GRP");
            modelBuilder.Entity<GmsPrt>().Property(item => item.IdPrt).IsRequired();
            modelBuilder.Entity<GmsPrt>().Property(item => item.IdPrt).HasColumnName("ID_PRT");
            modelBuilder.Entity<GmsPrt>().Property(item => item.Libp).IsRequired();
            modelBuilder.Entity<GmsPrt>().Property(item => item.Libp).HasMaxLength(500);
            modelBuilder.Entity<GmsPrt>().Property(item => item.Libp).HasColumnName("LIBP");
            modelBuilder.Entity<GmsPrt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GmsPrt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GmsGrp>().HasMany<GmsPrt>(c => c.GmsPrts).WithRequired(t => t.GmsGrp).HasForeignKey(u => new {u.GmsGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsGrp>().ToTable("GRP_GMS","GMS");
            modelBuilder.Entity<GmsGrp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsGrp>().Property(item => item.IdGrp).IsRequired();
            modelBuilder.Entity<GmsGrp>().Property(item => item.IdGrp).HasColumnName("ID_GRP");
            modelBuilder.Entity<GmsGrp>().Property(item => item.Libg).IsRequired();
            modelBuilder.Entity<GmsGrp>().Property(item => item.Libg).HasMaxLength(500);
            modelBuilder.Entity<GmsGrp>().Property(item => item.Libg).HasColumnName("LIBG");
            modelBuilder.Entity<GmsGrp>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GmsGrp>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GmsEltInsp>().HasRequired<GmsElt>(c => c.GmsElt).WithMany(t => t.GmsEltInsps).HasForeignKey(u => new { u.GmsEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEltInsp>().HasRequired<GmsInsp>(c => c.GmsInsp).WithMany(t => t.GmsEltInsps).HasForeignKey(u => new { u.GmsInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEltInsp>().HasMany<GmsPhotoEltInsp>(c => c.GmsPhotoEltInsps).WithRequired(t => t.GmsEltInsp).HasForeignKey(u => new {u.GmsEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEltInsp>().ToTable("ELT_INSP_GMS","GMS");
            modelBuilder.Entity<GmsEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.GrpGmsIdGrp).IsRequired();
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.GrpGmsIdGrp).HasColumnName("GRP_GMS__ID_GRP");
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.PrtGmsIdPrt).IsRequired();
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.PrtGmsIdPrt).HasColumnName("PRT_GMS__ID_PRT");
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.SprtGmsIdSprt).IsRequired();
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.SprtGmsIdSprt).HasColumnName("SPRT_GMS__ID_SPRT");
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.EltGmsIdElem).IsRequired();
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.EltGmsIdElem).HasColumnName("ELT_GMS__ID_ELEM");
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<GmsEltInsp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<GmsCdMeteo>().HasMany<GmsInsp>(c => c.GmsInsps).WithOptional(t => t.GmsCdMeteo).HasForeignKey(u => new {u.GmsCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdMeteo>().HasMany<GmsInspTmp>(c => c.GmsInspTmps).WithOptional(t => t.GmsCdMeteo).HasForeignKey(u => new {u.GmsCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdMeteo>().ToTable("CD_METEO_GMS","GMS");
            modelBuilder.Entity<GmsCdMeteo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdMeteo>().Property(item => item.Meteo).IsRequired();
            modelBuilder.Entity<GmsCdMeteo>().Property(item => item.Meteo).HasMaxLength(60);
            modelBuilder.Entity<GmsCdMeteo>().Property(item => item.Meteo).HasColumnName("METEO");
            modelBuilder.Entity<GmsTravaux>().HasRequired<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsTravauxs).HasForeignKey(u => new { u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsTravaux>().HasRequired<GmsNatureTrav>(c => c.GmsNatureTrav).WithMany(t => t.GmsTravauxs).HasForeignKey(u => new { u.GmsNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsTravaux>().HasRequired<GmsCdEntp>(c => c.GmsCdEntp).WithMany(t => t.GmsTravauxs).HasForeignKey(u => new { u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsTravaux>().ToTable("TRAVAUX_GMS","GMS");
            modelBuilder.Entity<GmsTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsTravaux>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsTravaux>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsTravaux>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.CdTravauxGmsCode).IsRequired();
            modelBuilder.Entity<GmsTravaux>().Property(item => item.CdTravauxGmsCode).HasMaxLength(60);
            modelBuilder.Entity<GmsTravaux>().Property(item => item.CdTravauxGmsCode).HasColumnName("CD_TRAVAUX_GMS__CODE");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.NatureTravGmsNature).IsRequired();
            modelBuilder.Entity<GmsTravaux>().Property(item => item.NatureTravGmsNature).HasMaxLength(255);
            modelBuilder.Entity<GmsTravaux>().Property(item => item.NatureTravGmsNature).HasColumnName("NATURE_TRAV_GMS__NATURE");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.DateRcp).IsRequired();
            modelBuilder.Entity<GmsTravaux>().Property(item => item.DateRcp).HasColumnName("DATE_RCP");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.CdEntpGmsEntreprise).IsRequired();
            modelBuilder.Entity<GmsTravaux>().Property(item => item.CdEntpGmsEntreprise).HasMaxLength(60);
            modelBuilder.Entity<GmsTravaux>().Property(item => item.CdEntpGmsEntreprise).HasColumnName("CD_ENTP_GMS__ENTREPRISE");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.DateFinGar).HasColumnName("DATE_FIN_GAR");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.Marche).HasMaxLength(25);
            modelBuilder.Entity<GmsTravaux>().Property(item => item.Marche).HasColumnName("MARCHE");
            modelBuilder.Entity<GmsTravaux>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<GmsTravaux>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsNatureTrav>().HasRequired<GmsCdTravaux>(c => c.GmsCdTravaux).WithMany(t => t.GmsNatureTravs).HasForeignKey(u => new { u.GmsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsNatureTrav>().HasMany<GmsTravaux>(c => c.GmsTravauxs).WithRequired(t => t.GmsNatureTrav).HasForeignKey(u => new {u.GmsNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsNatureTrav>().ToTable("NATURE_TRAV_GMS","GMS");
            modelBuilder.Entity<GmsNatureTrav>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsNatureTrav>().Property(item => item.CdTravauxGmsCode).IsRequired();
            modelBuilder.Entity<GmsNatureTrav>().Property(item => item.CdTravauxGmsCode).HasMaxLength(60);
            modelBuilder.Entity<GmsNatureTrav>().Property(item => item.CdTravauxGmsCode).HasColumnName("CD_TRAVAUX_GMS__CODE");
            modelBuilder.Entity<GmsNatureTrav>().Property(item => item.Nature).IsRequired();
            modelBuilder.Entity<GmsNatureTrav>().Property(item => item.Nature).HasMaxLength(255);
            modelBuilder.Entity<GmsNatureTrav>().Property(item => item.Nature).HasColumnName("NATURE");
            modelBuilder.Entity<GmsCdTravaux>().HasMany<GmsNatureTrav>(c => c.GmsNatureTravs).WithRequired(t => t.GmsCdTravaux).HasForeignKey(u => new {u.GmsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdTravaux>().HasMany<GmsBpu>(c => c.GmsBpus).WithRequired(t => t.GmsCdTravaux).HasForeignKey(u => new {u.GmsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdTravaux>().ToTable("CD_TRAVAUX_GMS","GMS");
            modelBuilder.Entity<GmsCdTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdTravaux>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GmsCdTravaux>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<GmsCdTravaux>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GmsCdPoutre>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdPoutre).HasForeignKey(u => new {u.GmsCdPoutreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPoutre>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdPoutre).HasForeignKey(u => new {u.GmsCdPoutreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPoutre>().ToTable("CD_POUTRE_GMS","GMS");
            modelBuilder.Entity<GmsCdPoutre>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdPoutre>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdPoutre>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GmsCdPoutre>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsCdPoutre>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<GmsCdPoutre>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<GmsPrevision>().HasRequired<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsPrevisions).HasForeignKey(u => new { u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPrevision>().HasOptional<GmsCdContrainte>(c => c.GmsCdContrainte).WithMany(t => t.GmsPrevisions).HasForeignKey(u => new {u.GmsCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPrevision>().HasRequired<GmsBpu>(c => c.GmsBpu).WithMany(t => t.GmsPrevisions).HasForeignKey(u => new { u.GmsBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPrevision>().ToTable("PREVISION_GMS","GMS");
            modelBuilder.Entity<GmsPrevision>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPrevision>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPrevision>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPrevision>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.BpuGmsIdBpu).IsRequired();
            modelBuilder.Entity<GmsPrevision>().Property(item => item.BpuGmsIdBpu).HasColumnName("BPU_GMS__ID_BPU");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.DateDebut).IsRequired();
            modelBuilder.Entity<GmsPrevision>().Property(item => item.DateDebut).HasColumnName("DATE_DEBUT");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.CdContrainteGmsType).HasMaxLength(100);
            modelBuilder.Entity<GmsPrevision>().Property(item => item.CdContrainteGmsType).HasColumnName("CD_CONTRAINTE_GMS__TYPE");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.DateDemPub).HasColumnName("DATE_DEM_PUB");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<GmsPrevision>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsPrevision>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<GmsPrevision>().Ignore(item => item.Realise);
            modelBuilder.Entity<GmsCdAncrage>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdAncrage).HasForeignKey(u => new {u.GmsCdAncrageIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdAncrage>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdAncrage).HasForeignKey(u => new {u.GmsCdAncrageIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdAncrage>().ToTable("CD_ANCRAGE_GMS","GMS");
            modelBuilder.Entity<GmsCdAncrage>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdAncrage>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdAncrage>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GmsCdAncrage>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsPanneau>().HasOptional<GmsCdPanneau>(c => c.GmsCdPanneau).WithMany(t => t.GmsPanneaus).HasForeignKey(u => new {u.GmsCdPanneauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPanneau>().HasRequired<GmsCdPosPan>(c => c.GmsCdPosPan).WithMany(t => t.GmsPanneaus).HasForeignKey(u => new { u.GmsCdPosPanIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPanneau>().HasOptional<GmsCdEntp>(c => c.GmsCdEntp).WithMany(t => t.GmsPanneaus).HasForeignKey(u => new {u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPanneau>().HasOptional<GmsCdInterface>(c => c.GmsCdInterface).WithMany(t => t.GmsPanneaus).HasForeignKey(u => new {u.GmsCdInterfaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPanneau>().HasOptional<GmsCdFournisseur>(c => c.GmsCdFournisseur).WithMany(t => t.GmsPanneaus).HasForeignKey(u => new {u.GmsCdFournisseurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPanneau>().ToTable("PANNEAU_GMS","GMS");
            modelBuilder.Entity<GmsPanneau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPanneau>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPanneau>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPanneau>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdPosPanGmsPosit).IsRequired();
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdPosPanGmsPosit).HasMaxLength(4);
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdPosPanGmsPosit).HasColumnName("CD_POS_PAN_GMS__POSIT");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdPanneauGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdPanneauGmsType).HasColumnName("CD_PANNEAU_GMS__TYPE");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdInterfaceGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdInterfaceGmsType).HasColumnName("CD_INTERFACE_GMS__TYPE");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdEntpGmsEntreprise).HasMaxLength(60);
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdEntpGmsEntreprise).HasColumnName("CD_ENTP_GMS__ENTREPRISE");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdFournisseurGmsNom).HasMaxLength(60);
            modelBuilder.Entity<GmsPanneau>().Property(item => item.CdFournisseurGmsNom).HasColumnName("CD_FOURNISSEUR_GMS__NOM");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<GmsPanneau>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.Hauteur).HasColumnName("HAUTEUR");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.Mention).HasMaxLength(255);
            modelBuilder.Entity<GmsPanneau>().Property(item => item.Mention).HasColumnName("MENTION");
            modelBuilder.Entity<GmsPanneau>().Property(item => item.Reserve).HasColumnName("RESERVE");
            modelBuilder.Entity<GmsCdPanneau>().HasMany<GmsPanneau>(c => c.GmsPanneaus).WithOptional(t => t.GmsCdPanneau).HasForeignKey(u => new {u.GmsCdPanneauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPanneau>().ToTable("CD_PANNEAU_GMS","GMS");
            modelBuilder.Entity<GmsCdPanneau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdPanneau>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdPanneau>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GmsCdPanneau>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsCdPanneau>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<GmsCdPanneau>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<GmsCdAcces>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdAcces).HasForeignKey(u => new {u.GmsCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdAcces>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdAcces).HasForeignKey(u => new {u.GmsCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdAcces>().ToTable("CD_ACCES_GMS","GMS");
            modelBuilder.Entity<GmsCdAcces>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdAcces>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdAcces>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GmsCdAcces>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsSysUser>().ToTable("SYS_USER_GMS","GMS");
            modelBuilder.Entity<GmsSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<GmsSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<GmsSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<GmsSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<GmsSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<GmsSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<GmsSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<GmsSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<GmsBpu>().HasRequired<GmsCdTravaux>(c => c.GmsCdTravaux).WithMany(t => t.GmsBpus).HasForeignKey(u => new { u.GmsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsBpu>().HasOptional<GmsCdUnite>(c => c.GmsCdUnite).WithMany(t => t.GmsBpus).HasForeignKey(u => new {u.GmsCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsBpu>().HasMany<GmsPrevision>(c => c.GmsPrevisions).WithRequired(t => t.GmsBpu).HasForeignKey(u => new {u.GmsBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsBpu>().HasMany<GmsCdPrecoSprtVst>(c => c.GmsCdPrecoSprtVsts).WithRequired(t => t.GmsBpu).HasForeignKey(u => new {u.GmsBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsBpu>().ToTable("BPU_GMS","GMS");
            modelBuilder.Entity<GmsBpu>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsBpu>().Property(item => item.IdBpu).IsRequired();
            modelBuilder.Entity<GmsBpu>().Property(item => item.IdBpu).HasColumnName("ID_BPU");
            modelBuilder.Entity<GmsBpu>().Property(item => item.CdUniteGmsUnite).HasMaxLength(12);
            modelBuilder.Entity<GmsBpu>().Property(item => item.CdUniteGmsUnite).HasColumnName("CD_UNITE_GMS__UNITE");
            modelBuilder.Entity<GmsBpu>().Property(item => item.CdTravauxGmsCode).IsRequired();
            modelBuilder.Entity<GmsBpu>().Property(item => item.CdTravauxGmsCode).HasMaxLength(60);
            modelBuilder.Entity<GmsBpu>().Property(item => item.CdTravauxGmsCode).HasColumnName("CD_TRAVAUX_GMS__CODE");
            modelBuilder.Entity<GmsBpu>().Property(item => item.Techn).IsRequired();
            modelBuilder.Entity<GmsBpu>().Property(item => item.Techn).HasMaxLength(255);
            modelBuilder.Entity<GmsBpu>().Property(item => item.Techn).HasColumnName("TECHN");
            modelBuilder.Entity<GmsBpu>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<GmsBpu>().Property(item => item.DateMaj).HasColumnName("DATE_MAJ");
            modelBuilder.Entity<GmsBpu>().Property(item => item.Freq).HasColumnName("FREQ");
            modelBuilder.Entity<GmsBpu>().Property(item => item.PrecoVstValueInt).HasColumnName("PRECO_VST");
            modelBuilder.Entity<GmsBpu>().Ignore(item => item.PrecoVst);
            modelBuilder.Entity<GmsBpu>().Property(item => item.RealisVstValueInt).HasColumnName("REALIS_VST");
            modelBuilder.Entity<GmsBpu>().Ignore(item => item.RealisVst);
            modelBuilder.Entity<GmsCdContrainte>().HasMany<GmsPrevision>(c => c.GmsPrevisions).WithOptional(t => t.GmsCdContrainte).HasForeignKey(u => new {u.GmsCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdContrainte>().ToTable("CD_CONTRAINTE_GMS","GMS");
            modelBuilder.Entity<GmsCdContrainte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdContrainte>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdContrainte>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<GmsCdContrainte>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsCamp>().HasRequired<GmsCdPresta>(c => c.GmsCdPresta).WithMany(t => t.GmsCamps).HasForeignKey(u => new { u.GmsCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCamp>().HasRequired<GmsCdTypePv>(c => c.GmsCdTypePv).WithMany(t => t.GmsCamps).HasForeignKey(u => new { u.GmsCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCamp>().HasMany<GmsInsp>(c => c.GmsInsps).WithRequired(t => t.GmsCamp).HasForeignKey(u => new {u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCamp>().HasMany<GmsVst>(c => c.GmsVsts).WithRequired(t => t.GmsCamp).HasForeignKey(u => new {u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCamp>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithRequired(t => t.GmsCamp).HasForeignKey(u => new {u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCamp>().HasMany<GmsDscCamp>(c => c.GmsDscCamps).WithRequired(t => t.GmsCamp).HasForeignKey(u => new {u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCamp>().ToTable("CAMP_GMS","GMS");
            modelBuilder.Entity<GmsCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCamp>().Property(item => item.IdCamp).IsRequired();
            modelBuilder.Entity<GmsCamp>().Property(item => item.IdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsCamp>().Property(item => item.IdCamp).HasColumnName("ID_CAMP");
            modelBuilder.Entity<GmsCamp>().Property(item => item.CdTypePvGmsCode).IsRequired();
            modelBuilder.Entity<GmsCamp>().Property(item => item.CdTypePvGmsCode).HasMaxLength(15);
            modelBuilder.Entity<GmsCamp>().Property(item => item.CdTypePvGmsCode).HasColumnName("CD_TYPE_PV_GMS__CODE");
            modelBuilder.Entity<GmsCamp>().Property(item => item.CdPrestaGmsPrestataire).IsRequired();
            modelBuilder.Entity<GmsCamp>().Property(item => item.CdPrestaGmsPrestataire).HasMaxLength(50);
            modelBuilder.Entity<GmsCamp>().Property(item => item.CdPrestaGmsPrestataire).HasColumnName("CD_PRESTA_GMS__PRESTATAIRE");
            modelBuilder.Entity<GmsCamp>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<GmsCamp>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<GmsCamp>().Property(item => item.Dater).IsRequired();
            modelBuilder.Entity<GmsCamp>().Property(item => item.Dater).HasColumnName("DATER");
            modelBuilder.Entity<GmsCamp>().Property(item => item.Dateg).HasColumnName("DATEG");
            modelBuilder.Entity<GmsCamp>().Property(item => item.Userg).HasMaxLength(2555);
            modelBuilder.Entity<GmsCamp>().Property(item => item.Userg).HasColumnName("USERG");
            modelBuilder.Entity<GmsCamp>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<GmsCamp>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<GmsCdPresta>().HasMany<GmsCamp>(c => c.GmsCamps).WithRequired(t => t.GmsCdPresta).HasForeignKey(u => new {u.GmsCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPresta>().HasMany<GmsInspecteur>(c => c.GmsInspecteurs).WithRequired(t => t.GmsCdPresta).HasForeignKey(u => new {u.GmsCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPresta>().ToTable("CD_PRESTA_GMS","GMS");
            modelBuilder.Entity<GmsCdPresta>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdPresta>().Property(item => item.Prestataire).IsRequired();
            modelBuilder.Entity<GmsCdPresta>().Property(item => item.Prestataire).HasMaxLength(50);
            modelBuilder.Entity<GmsCdPresta>().Property(item => item.Prestataire).HasColumnName("PRESTATAIRE");
            modelBuilder.Entity<GmsCdTypePv>().HasMany<GmsCamp>(c => c.GmsCamps).WithRequired(t => t.GmsCdTypePv).HasForeignKey(u => new {u.GmsCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdTypePv>().ToTable("CD_TYPE_PV_GMS","GMS");
            modelBuilder.Entity<GmsCdTypePv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Cycle).HasColumnName("CYCLE");
            modelBuilder.Entity<GmsCdTypePv>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<GmsPhotoEltInsp>().HasRequired<GmsEltInsp>(c => c.GmsEltInsp).WithMany(t => t.GmsPhotoEltInsps).HasForeignKey(u => new { u.GmsEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPhotoEltInsp>().ToTable("PHOTO_ELT_INSP_GMS","GMS");
            modelBuilder.Entity<GmsPhotoEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.GrpGmsIdGrp).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.GrpGmsIdGrp).HasColumnName("GRP_GMS__ID_GRP");
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.PrtGmsIdPrt).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.PrtGmsIdPrt).HasColumnName("PRT_GMS__ID_PRT");
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.SprtGmsIdSprt).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.SprtGmsIdSprt).HasColumnName("SPRT_GMS__ID_SPRT");
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.EltGmsIdElem).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.EltGmsIdElem).HasColumnName("ELT_GMS__ID_ELEM");
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoEltInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsInsp>().HasOptional<GmsCdMeteo>(c => c.GmsCdMeteo).WithMany(t => t.GmsInsps).HasForeignKey(u => new {u.GmsCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().HasRequired<GmsCamp>(c => c.GmsCamp).WithMany(t => t.GmsInsps).HasForeignKey(u => new { u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().HasRequired<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsInsps).HasForeignKey(u => new { u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().HasOptional<GmsCdEtude>(c => c.GmsCdEtude).WithMany(t => t.GmsInsps).HasForeignKey(u => new {u.GmsCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().HasOptional<GmsInspecteur>(c => c.GmsInspecteur).WithMany(t => t.GmsInsps).HasForeignKey(u => new {u.GmsInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().HasMany<GmsEltInsp>(c => c.GmsEltInsps).WithRequired(t => t.GmsInsp).HasForeignKey(u => new {u.GmsInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().HasMany<GmsPhotoInsp>(c => c.GmsPhotoInsps).WithRequired(t => t.GmsInsp).HasForeignKey(u => new {u.GmsInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().HasMany<GmsCdConclusionInsp>(c => c.GmsCdConclusionInsps).WithRequired(t => t.GmsInsp).HasForeignKey(u => new {u.GmsInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInsp>().ToTable("INSP_GMS","GMS");
            modelBuilder.Entity<GmsInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsInsp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsInsp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsInsp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsInsp>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsInsp>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsInsp>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsInsp>().Property(item => item.CdEtudeGmsEtude).HasMaxLength(65);
            modelBuilder.Entity<GmsInsp>().Property(item => item.CdEtudeGmsEtude).HasColumnName("CD_ETUDE_GMS__ETUDE");
            modelBuilder.Entity<GmsInsp>().Property(item => item.InspecteurGmsNom).HasMaxLength(60);
            modelBuilder.Entity<GmsInsp>().Property(item => item.InspecteurGmsNom).HasColumnName("INSPECTEUR_GMS__NOM");
            modelBuilder.Entity<GmsInsp>().Property(item => item.CdMeteoGmsMeteo).HasMaxLength(60);
            modelBuilder.Entity<GmsInsp>().Property(item => item.CdMeteoGmsMeteo).HasColumnName("CD_METEO_GMS__METEO");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<GmsInsp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<GmsInsp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<GmsInsp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<GmsInsp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<GmsInsp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<GmsInsp>().Property(item => item.NomValid).HasMaxLength(255);
            modelBuilder.Entity<GmsInsp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<GmsInsp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GmsInsp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<GmsInsp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<GmsInsp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GmsInsp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GmsInsp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<GmsInsp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<GmsPhotoInsp>().HasRequired<GmsInsp>(c => c.GmsInsp).WithMany(t => t.GmsPhotoInsps).HasForeignKey(u => new { u.GmsInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPhotoInsp>().ToTable("PHOTO_INSP_GMS","GMS");
            modelBuilder.Entity<GmsPhotoInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsCdEtude>().HasMany<GmsInsp>(c => c.GmsInsps).WithOptional(t => t.GmsCdEtude).HasForeignKey(u => new {u.GmsCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEtude>().HasMany<GmsInspTmp>(c => c.GmsInspTmps).WithOptional(t => t.GmsCdEtude).HasForeignKey(u => new {u.GmsCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEtude>().ToTable("CD_ETUDE_GMS","GMS");
            modelBuilder.Entity<GmsCdEtude>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdEtude>().Property(item => item.Etude).IsRequired();
            modelBuilder.Entity<GmsCdEtude>().Property(item => item.Etude).HasMaxLength(65);
            modelBuilder.Entity<GmsCdEtude>().Property(item => item.Etude).HasColumnName("ETUDE");
            modelBuilder.Entity<GmsSeuilQualite>().HasRequired<GmsCdQualite>(c => c.GmsCdQualite).WithMany(t => t.GmsSeuilQualites).HasForeignKey(u => new { u.GmsCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsSeuilQualite>().ToTable("SEUIL_QUALITE_GMS","GMS");
            modelBuilder.Entity<GmsSeuilQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsSeuilQualite>().Property(item => item.CdQualiteGmsQualite).IsRequired();
            modelBuilder.Entity<GmsSeuilQualite>().Property(item => item.CdQualiteGmsQualite).HasMaxLength(25);
            modelBuilder.Entity<GmsSeuilQualite>().Property(item => item.CdQualiteGmsQualite).HasColumnName("CD_QUALITE_GMS__QUALITE");
            modelBuilder.Entity<GmsSeuilQualite>().Property(item => item.IndiceUrgence).IsRequired();
            modelBuilder.Entity<GmsSeuilQualite>().Property(item => item.IndiceUrgence).HasMaxLength(5);
            modelBuilder.Entity<GmsSeuilQualite>().Property(item => item.IndiceUrgence).HasColumnName("INDICE_URGENCE");
            modelBuilder.Entity<GmsSeuilUrgence>().ToTable("SEUIL_URGENCE_GMS","GMS");
            modelBuilder.Entity<GmsSeuilUrgence>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsSeuilUrgence>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GmsSeuilUrgence>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GmsSeuilUrgence>().Property(item => item.NbrNote).HasColumnName("NBR_NOTE");
            modelBuilder.Entity<GmsSeuilUrgence>().Property(item => item.ValNote).HasColumnName("VAL_NOTE");
            modelBuilder.Entity<GmsSeuilUrgence>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GmsSprtVst>().HasRequired<GmsVst>(c => c.GmsVst).WithMany(t => t.GmsSprtVsts).HasForeignKey(u => new { u.GmsVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsSprtVst>().HasRequired<GmsCdLigne>(c => c.GmsCdLigne).WithMany(t => t.GmsSprtVsts).HasForeignKey(u => new { u.GmsCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsSprtVst>().HasMany<GmsPhotoSprtVst>(c => c.GmsPhotoSprtVsts).WithRequired(t => t.GmsSprtVst).HasForeignKey(u => new {u.GmsSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsSprtVst>().HasMany<GmsCdPrecoSprtVst>(c => c.GmsCdPrecoSprtVsts).WithRequired(t => t.GmsSprtVst).HasForeignKey(u => new {u.GmsSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsSprtVst>().ToTable("SPRT_VST_GMS","GMS");
            modelBuilder.Entity<GmsSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.CdChapitreGmsIdChap).IsRequired();
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.CdChapitreGmsIdChap).HasColumnName("CD_CHAPITRE_GMS__ID_CHAP");
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.CdLigneGmsIdLigne).IsRequired();
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.CdLigneGmsIdLigne).HasColumnName("CD_LIGNE_GMS__ID_LIGNE");
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.Obs).HasMaxLength(500);
            modelBuilder.Entity<GmsSprtVst>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<GmsPhotoSprtVst>().HasRequired<GmsSprtVst>(c => c.GmsSprtVst).WithMany(t => t.GmsPhotoSprtVsts).HasForeignKey(u => new { u.GmsSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPhotoSprtVst>().ToTable("PHOTO_SPRT_VST_GMS","GMS");
            modelBuilder.Entity<GmsPhotoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.CdChapitreGmsIdChap).IsRequired();
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.CdChapitreGmsIdChap).HasColumnName("CD_CHAPITRE_GMS__ID_CHAP");
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.CdLigneGmsIdLigne).IsRequired();
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.CdLigneGmsIdLigne).HasColumnName("CD_LIGNE_GMS__ID_LIGNE");
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoSprtVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsPhotoVst>().HasRequired<GmsVst>(c => c.GmsVst).WithMany(t => t.GmsPhotoVsts).HasForeignKey(u => new { u.GmsVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPhotoVst>().ToTable("PHOTO_VST_GMS","GMS");
            modelBuilder.Entity<GmsPhotoVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsCdPosPan>().HasMany<GmsPanneau>(c => c.GmsPanneaus).WithRequired(t => t.GmsCdPosPan).HasForeignKey(u => new {u.GmsCdPosPanIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPosPan>().ToTable("CD_POS_PAN_GMS","GMS");
            modelBuilder.Entity<GmsCdPosPan>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdPosPan>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<GmsCdPosPan>().Property(item => item.Posit).HasMaxLength(4);
            modelBuilder.Entity<GmsCdPosPan>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<GmsCdPosPan>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GmsCdPosPan>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdPosMat>().HasMany<GmsDsc>(c => c.GmsDscs).WithRequired(t => t.GmsCdPosMat).HasForeignKey(u => new {u.GmsCdPosMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPosMat>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithRequired(t => t.GmsCdPosMat).HasForeignKey(u => new {u.GmsCdPosMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPosMat>().ToTable("CD_POS_MAT_GMS","GMS");
            modelBuilder.Entity<GmsCdPosMat>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdPosMat>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<GmsCdPosMat>().Property(item => item.Posit).HasMaxLength(4);
            modelBuilder.Entity<GmsCdPosMat>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<GmsCdPosMat>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GmsCdPosMat>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdQualite>().HasMany<GmsSeuilQualite>(c => c.GmsSeuilQualites).WithRequired(t => t.GmsCdQualite).HasForeignKey(u => new {u.GmsCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdQualite>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdQualite).HasForeignKey(u => new {u.GmsCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdQualite>().ToTable("CD_QUALITE_GMS","GMS");
            modelBuilder.Entity<GmsCdQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdQualite>().Property(item => item.Qualite).IsRequired();
            modelBuilder.Entity<GmsCdQualite>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<GmsCdQualite>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<GmsCdProtec>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdProtec).HasForeignKey(u => new {u.GmsCdProtecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdProtec>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdProtec).HasForeignKey(u => new {u.GmsCdProtecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdProtec>().ToTable("CD_PROTEC_GMS","GMS");
            modelBuilder.Entity<GmsCdProtec>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdProtec>().Property(item => item.Protec).IsRequired();
            modelBuilder.Entity<GmsCdProtec>().Property(item => item.Protec).HasMaxLength(60);
            modelBuilder.Entity<GmsCdProtec>().Property(item => item.Protec).HasColumnName("PROTEC");
            modelBuilder.Entity<GmsHistoNote>().HasRequired<GmsCdOrigin>(c => c.GmsCdOrigin).WithMany(t => t.GmsHistoNotes).HasForeignKey(u => new { u.GmsCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsHistoNote>().HasRequired<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsHistoNotes).HasForeignKey(u => new { u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsHistoNote>().ToTable("HISTO_NOTE_GMS","GMS");
            modelBuilder.Entity<GmsHistoNote>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.DateNote).IsRequired();
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.DateNote).HasColumnName("DATE_NOTE");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.CdOriginGmsOrigine).IsRequired();
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.CdOriginGmsOrigine).HasMaxLength(20);
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.CdOriginGmsOrigine).HasColumnName("CD_ORIGIN_GMS__ORIGINE");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<GmsHistoNote>().Ignore(item => item.Securite);
            modelBuilder.Entity<GmsHistoNote>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GmsHistoNote>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GmsCdOrigin>().HasMany<GmsHistoNote>(c => c.GmsHistoNotes).WithRequired(t => t.GmsCdOrigin).HasForeignKey(u => new {u.GmsCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdOrigin>().ToTable("CD_ORIGIN_GMS","GMS");
            modelBuilder.Entity<GmsCdOrigin>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdOrigin>().Property(item => item.Origine).IsRequired();
            modelBuilder.Entity<GmsCdOrigin>().Property(item => item.Origine).HasMaxLength(20);
            modelBuilder.Entity<GmsCdOrigin>().Property(item => item.Origine).HasColumnName("ORIGINE");
            modelBuilder.Entity<GmsDictionnaire>().ToTable("DICTIONNAIRE_GMS","GMS");
            modelBuilder.Entity<GmsDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Definition).HasMaxLength(500);
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Definition).HasColumnName("DEFINITION");
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<GmsDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<GmsCdEvt>().HasMany<GmsEvt>(c => c.GmsEvts).WithRequired(t => t.GmsCdEvt).HasForeignKey(u => new {u.GmsCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEvt>().ToTable("CD_EVT_GMS","GMS");
            modelBuilder.Entity<GmsCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<GmsCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<GmsCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<GmsEvt>().HasRequired<GmsCdEvt>(c => c.GmsCdEvt).WithMany(t => t.GmsEvts).HasForeignKey(u => new { u.GmsCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEvt>().HasRequired<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsEvts).HasForeignKey(u => new { u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEvt>().ToTable("EVT_GMS","GMS");
            modelBuilder.Entity<GmsEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsEvt>().Property(item => item.CdEvtGmsType).IsRequired();
            modelBuilder.Entity<GmsEvt>().Property(item => item.CdEvtGmsType).HasMaxLength(25);
            modelBuilder.Entity<GmsEvt>().Property(item => item.CdEvtGmsType).HasColumnName("CD_EVT_GMS__TYPE");
            modelBuilder.Entity<GmsEvt>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsEvt>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsEvt>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<GmsEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<GmsEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<GmsEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<GmsEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<GmsCdInterface>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdInterface).HasForeignKey(u => new {u.GmsCdInterfaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdInterface>().HasMany<GmsPanneau>(c => c.GmsPanneaus).WithOptional(t => t.GmsCdInterface).HasForeignKey(u => new {u.GmsCdInterfaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdInterface>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdInterface).HasForeignKey(u => new {u.GmsCdInterfaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdInterface>().ToTable("CD_INTERFACE_GMS","GMS");
            modelBuilder.Entity<GmsCdInterface>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdInterface>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdInterface>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GmsCdInterface>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsCdInterface>().Property(item => item.Frequence).HasColumnName("FREQUENCE");
            modelBuilder.Entity<GmsCdFournisseur>().HasMany<GmsPanneau>(c => c.GmsPanneaus).WithOptional(t => t.GmsCdFournisseur).HasForeignKey(u => new {u.GmsCdFournisseurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdFournisseur>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdFournisseur).HasForeignKey(u => new {u.GmsCdFournisseurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdFournisseur>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdFournisseur).HasForeignKey(u => new {u.GmsCdFournisseurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdFournisseur>().ToTable("CD_FOURNISSEUR_GMS","GMS");
            modelBuilder.Entity<GmsCdFournisseur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdFournisseur>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<GmsCdFournisseur>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<GmsCdFournisseur>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<GmsCdPoteau>().HasMany<GmsDsc>(c => c.GmsDscs).WithOptional(t => t.GmsCdPoteau).HasForeignKey(u => new {u.GmsCdPoteauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPoteau>().HasMany<GmsDscTemp>(c => c.GmsDscTemps).WithOptional(t => t.GmsCdPoteau).HasForeignKey(u => new {u.GmsCdPoteauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPoteau>().ToTable("CD_POTEAU_GMS","GMS");
            modelBuilder.Entity<GmsCdPoteau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdPoteau>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GmsCdPoteau>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GmsCdPoteau>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GmsCdPoteau>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<GmsCdPoteau>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<GmsCdEntete>().HasRequired<GmsCdComposant>(c => c.GmsCdComposant).WithMany(t => t.GmsCdEntetes).HasForeignKey(u => new { u.GmsCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEntete>().HasMany<GmsEntete>(c => c.GmsEntetes).WithRequired(t => t.GmsCdEntete).HasForeignKey(u => new {u.GmsCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdEntete>().ToTable("CD_ENTETE_GMS","GMS");
            modelBuilder.Entity<GmsCdEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.IdEntete).IsRequired();
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.IdEntete).HasColumnName("ID_ENTETE");
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.CdComposantGmsTypeComp).IsRequired();
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.CdComposantGmsTypeComp).HasMaxLength(6);
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.CdComposantGmsTypeComp).HasColumnName("CD_COMPOSANT_GMS__TYPE_COMP");
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.OrdreEnt).IsRequired();
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.OrdreEnt).HasColumnName("ORDRE_ENT");
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.Guide).HasMaxLength(500);
            modelBuilder.Entity<GmsCdEntete>().Property(item => item.Guide).HasColumnName("GUIDE");
            modelBuilder.Entity<GmsCdChapitre>().HasMany<GmsCdLigne>(c => c.GmsCdLignes).WithRequired(t => t.GmsCdChapitre).HasForeignKey(u => new {u.GmsCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdChapitre>().ToTable("CD_CHAPITRE_GMS","GMS");
            modelBuilder.Entity<GmsCdChapitre>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.IdChap).IsRequired();
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.IdChap).HasColumnName("ID_CHAP");
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.OrdreChap).IsRequired();
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.OrdreChap).HasColumnName("ORDRE_CHAP");
            modelBuilder.Entity<GmsCdChapitre>().Property(item => item.Ponderation).HasColumnName("PONDERATION");
            modelBuilder.Entity<GmsCdLigne>().HasRequired<GmsCdChapitre>(c => c.GmsCdChapitre).WithMany(t => t.GmsCdLignes).HasForeignKey(u => new { u.GmsCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdLigne>().HasMany<GmsSprtVst>(c => c.GmsSprtVsts).WithRequired(t => t.GmsCdLigne).HasForeignKey(u => new {u.GmsCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdLigne>().ToTable("CD_LIGNE_GMS","GMS");
            modelBuilder.Entity<GmsCdLigne>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.CdChapitreGmsIdChap).IsRequired();
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.CdChapitreGmsIdChap).HasColumnName("CD_CHAPITRE_GMS__ID_CHAP");
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.IdLigne).IsRequired();
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.IdLigne).HasColumnName("ID_LIGNE");
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdLigne>().Property(item => item.OrdreLigne).HasColumnName("ORDRE_LIGNE");
            modelBuilder.Entity<GmsEntete>().HasRequired<GmsCdEntete>(c => c.GmsCdEntete).WithMany(t => t.GmsEntetes).HasForeignKey(u => new { u.GmsCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEntete>().HasRequired<GmsVst>(c => c.GmsVst).WithMany(t => t.GmsEntetes).HasForeignKey(u => new { u.GmsVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEntete>().ToTable("ENTETE_GMS","GMS");
            modelBuilder.Entity<GmsEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsEntete>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsEntete>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsEntete>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsEntete>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsEntete>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsEntete>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsEntete>().Property(item => item.CdEnteteGmsIdEntete).IsRequired();
            modelBuilder.Entity<GmsEntete>().Property(item => item.CdEnteteGmsIdEntete).HasColumnName("CD_ENTETE_GMS__ID_ENTETE");
            modelBuilder.Entity<GmsEntete>().Property(item => item.Valeur).HasMaxLength(250);
            modelBuilder.Entity<GmsEntete>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<GmsContact>().HasRequired<GmsDoc>(c => c.GmsDoc).WithMany(t => t.GmsContacts).HasForeignKey(u => new { u.GmsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsContact>().ToTable("CONTACT_GMS","GMS");
            modelBuilder.Entity<GmsContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsContact>().Property(item => item.DocGmsId).IsRequired();
            modelBuilder.Entity<GmsContact>().Property(item => item.DocGmsId).HasColumnName("DOC_GMS__ID");
            modelBuilder.Entity<GmsContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<GmsContact>().Property(item => item.Givenname).HasColumnName("GIVENNAME");
            modelBuilder.Entity<GmsContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<GmsContact>().Property(item => item.Sn).HasColumnName("SN");
            modelBuilder.Entity<GmsContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<GmsContact>().Property(item => item.Cn).HasColumnName("CN");
            modelBuilder.Entity<GmsContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<GmsContact>().Property(item => item.O).HasColumnName("O");
            modelBuilder.Entity<GmsContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<GmsContact>().Property(item => item.Mail).HasColumnName("MAIL");
            modelBuilder.Entity<GmsContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<GmsContact>().Property(item => item.Telephonenumber).HasColumnName("TELEPHONENUMBER");
            modelBuilder.Entity<GmsContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<GmsContact>().Property(item => item.Mobile).HasColumnName("MOBILE");
            modelBuilder.Entity<GmsContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<GmsContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("FACSIMILETELEPHONENUMBER");
            modelBuilder.Entity<GmsContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<GmsContact>().Property(item => item.Street).HasColumnName("STREET");
            modelBuilder.Entity<GmsContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<GmsContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("MOZILLAWORKSTREET2");
            modelBuilder.Entity<GmsContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<GmsContact>().Property(item => item.L).HasColumnName("L");
            modelBuilder.Entity<GmsContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<GmsContact>().Property(item => item.Postalcode).HasColumnName("POSTALCODE");
            modelBuilder.Entity<GmsContact>().Property(item => item.Modifytimestamp).HasColumnName("MODIFYTIMESTAMP");
            modelBuilder.Entity<GmsCdUnite>().HasMany<GmsBpu>(c => c.GmsBpus).WithOptional(t => t.GmsCdUnite).HasForeignKey(u => new {u.GmsCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdUnite>().ToTable("CD_UNITE_GMS","GMS");
            modelBuilder.Entity<GmsCdUnite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdUnite>().Property(item => item.Unite).IsRequired();
            modelBuilder.Entity<GmsCdUnite>().Property(item => item.Unite).HasMaxLength(12);
            modelBuilder.Entity<GmsCdUnite>().Property(item => item.Unite).HasColumnName("UNITE");
            modelBuilder.Entity<GmsInspecteur>().HasRequired<GmsCdPresta>(c => c.GmsCdPresta).WithMany(t => t.GmsInspecteurs).HasForeignKey(u => new { u.GmsCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspecteur>().HasMany<GmsInsp>(c => c.GmsInsps).WithOptional(t => t.GmsInspecteur).HasForeignKey(u => new {u.GmsInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspecteur>().HasMany<GmsVst>(c => c.GmsVsts).WithOptional(t => t.GmsInspecteur).HasForeignKey(u => new {u.GmsInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspecteur>().HasMany<GmsInspTmp>(c => c.GmsInspTmps).WithOptional(t => t.GmsInspecteur).HasForeignKey(u => new {u.GmsInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspecteur>().ToTable("INSPECTEUR_GMS","GMS");
            modelBuilder.Entity<GmsInspecteur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.CdPrestaGmsPrestataire).IsRequired();
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.CdPrestaGmsPrestataire).HasMaxLength(50);
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.CdPrestaGmsPrestataire).HasColumnName("CD_PRESTA_GMS__PRESTATAIRE");
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.Fonc).HasMaxLength(60);
            modelBuilder.Entity<GmsInspecteur>().Property(item => item.Fonc).HasColumnName("FONC");
            modelBuilder.Entity<GmsCdComposant>().HasMany<GmsCdEntete>(c => c.GmsCdEntetes).WithRequired(t => t.GmsCdComposant).HasForeignKey(u => new {u.GmsCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdComposant>().ToTable("CD_COMPOSANT_GMS","GMS");
            modelBuilder.Entity<GmsCdComposant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdComposant>().Property(item => item.TypeComp).IsRequired();
            modelBuilder.Entity<GmsCdComposant>().Property(item => item.TypeComp).HasMaxLength(6);
            modelBuilder.Entity<GmsCdComposant>().Property(item => item.TypeComp).HasColumnName("TYPE_COMP");
            modelBuilder.Entity<GmsCdComposant>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GmsCdComposant>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsVst>().HasRequired<GmsCamp>(c => c.GmsCamp).WithMany(t => t.GmsVsts).HasForeignKey(u => new { u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsVst>().HasRequired<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsVsts).HasForeignKey(u => new { u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsVst>().HasOptional<GmsInspecteur>(c => c.GmsInspecteur).WithMany(t => t.GmsVsts).HasForeignKey(u => new {u.GmsInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsVst>().HasMany<GmsSprtVst>(c => c.GmsSprtVsts).WithRequired(t => t.GmsVst).HasForeignKey(u => new {u.GmsVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsVst>().HasMany<GmsPhotoVst>(c => c.GmsPhotoVsts).WithRequired(t => t.GmsVst).HasForeignKey(u => new {u.GmsVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsVst>().HasMany<GmsEntete>(c => c.GmsEntetes).WithRequired(t => t.GmsVst).HasForeignKey(u => new {u.GmsVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsVst>().ToTable("VST_GMS","GMS");
            modelBuilder.Entity<GmsVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsVst>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsVst>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsVst>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsVst>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsVst>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsVst>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsVst>().Property(item => item.InspecteurGmsNom).HasMaxLength(60);
            modelBuilder.Entity<GmsVst>().Property(item => item.InspecteurGmsNom).HasColumnName("INSPECTEUR_GMS__NOM");
            modelBuilder.Entity<GmsVst>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<GmsVst>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<GmsVst>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<GmsVst>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<GmsVst>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GmsVst>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GmsVst>().Property(item => item.Observ).HasMaxLength(500);
            modelBuilder.Entity<GmsVst>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<GmsVst>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<GmsVst>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<GmsCdConclusion>().HasMany<GmsCdConclusionInsp>(c => c.GmsCdConclusionInsps).WithRequired(t => t.GmsCdConclusion).HasForeignKey(u => new {u.GmsCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdConclusion>().HasMany<GmsCdConclusionInspTmp>(c => c.GmsCdConclusionInspTmps).WithRequired(t => t.GmsCdConclusion).HasForeignKey(u => new {u.GmsCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdConclusion>().ToTable("CD_CONCLUSION_GMS","GMS");
            modelBuilder.Entity<GmsCdConclusion>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdConclusion>().Property(item => item.IdConc).IsRequired();
            modelBuilder.Entity<GmsCdConclusion>().Property(item => item.IdConc).HasColumnName("ID_CONC");
            modelBuilder.Entity<GmsCdConclusion>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GmsCdConclusion>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GmsCdConclusion>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GmsCdConclusion>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GmsCdConclusion>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GmsDscTemp>().HasRequired<GmsCdPosMat>(c => c.GmsCdPosMat).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new { u.GmsCdPosMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdProtec>(c => c.GmsCdProtec).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdProtecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdAcces>(c => c.GmsCdAcces).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdAccesIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdInterface>(c => c.GmsCdInterface).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdInterfaceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdFournisseur>(c => c.GmsCdFournisseur).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdFournisseurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasRequired<GmsCdFam>(c => c.GmsCdFam).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new { u.GmsCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdType>(c => c.GmsCdType).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdPoutre>(c => c.GmsCdPoutre).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdPoutreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdPoteau>(c => c.GmsCdPoteau).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdPoteauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdAncrage>(c => c.GmsCdAncrage).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdAncrageIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsCdEntp>(c => c.GmsCdEntp).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasRequired<GmsCamp>(c => c.GmsCamp).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new { u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasOptional<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsDscTemps).HasForeignKey(u => new {u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().HasMany<GmsInspTmp>(c => c.GmsInspTmps).WithRequired(t => t.GmsDscTemp).HasForeignKey(u => new {u.GmsDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscTemp>().ToTable("DSC_TEMP_GMS","GMS");
            modelBuilder.Entity<GmsDscTemp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NumGms).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NumGms).HasColumnName("NUM_GMS");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdFournisseurGmsNom).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdFournisseurGmsNom).HasColumnName("CD_FOURNISSEUR_GMS__NOM");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdPosMatGmsPosit).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdPosMatGmsPosit).HasMaxLength(4);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdPosMatGmsPosit).HasColumnName("CD_POS_MAT_GMS__POSIT");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdInterfaceGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdInterfaceGmsType).HasColumnName("CD_INTERFACE_GMS__TYPE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdEntpGmsEntreprise).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdEntpGmsEntreprise).HasColumnName("CD_ENTP_GMS__ENTREPRISE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdFamGmsFamille).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdFamGmsFamille).HasMaxLength(20);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdFamGmsFamille).HasColumnName("CD_FAM_GMS__FAMILLE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdAccesGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdAccesGmsType).HasColumnName("CD_ACCES_GMS__TYPE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdTypeGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdTypeGmsType).HasColumnName("CD_TYPE_GMS__TYPE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdProtecGmsProtec).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdProtecGmsProtec).HasColumnName("CD_PROTEC_GMS__PROTEC");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdAncrageGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdAncrageGmsType).HasColumnName("CD_ANCRAGE_GMS__TYPE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdPoteauGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdPoteauGmsType).HasColumnName("CD_POTEAU_GMS__TYPE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdPoutreGmsType).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CdPoutreGmsType).HasColumnName("CD_POUTRE_GMS__TYPE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NumExploit).HasMaxLength(17);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NomUsage).HasMaxLength(255);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Haut).HasColumnName("HAUT");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Tirair).HasColumnName("TIRAIR");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Vent).HasColumnName("VENT");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Ancrage).HasMaxLength(60);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Ancrage).HasColumnName("ANCRAGE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Larg).HasColumnName("LARG");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Traverse).HasColumnName("TRAVERSE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Element).HasColumnName("ELEMENT");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NbPoteaux).HasColumnName("NB_POTEAUX");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.EclairageValueInt).HasColumnName("ECLAIRAGE");
            modelBuilder.Entity<GmsDscTemp>().Ignore(item => item.Eclairage);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.CondamneValueInt).HasColumnName("CONDAMNE");
            modelBuilder.Entity<GmsDscTemp>().Ignore(item => item.Condamne);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<GmsDscTemp>().Ignore(item => item.Securite);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GmsDscTemp>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<GmsDscTemp>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<GmsDscTemp>().Ignore(item => item.Terrain);
            modelBuilder.Entity<GmsEltInspTmp>().HasRequired<GmsInspTmp>(c => c.GmsInspTmp).WithMany(t => t.GmsEltInspTmps).HasForeignKey(u => new { u.GmsInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEltInspTmp>().HasRequired<GmsElt>(c => c.GmsElt).WithMany(t => t.GmsEltInspTmps).HasForeignKey(u => new { u.GmsEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEltInspTmp>().HasMany<GmsPhotoEltInspTmp>(c => c.GmsPhotoEltInspTmps).WithRequired(t => t.GmsEltInspTmp).HasForeignKey(u => new {u.GmsEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsEltInspTmp>().ToTable("ELT_INSP_TMP_GMS","GMS");
            modelBuilder.Entity<GmsEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.DscTempGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.DscTempGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.DscTempGmsNumGms).HasColumnName("DSC_TEMP_GMS__NUM_GMS");
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.GrpGmsIdGrp).IsRequired();
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.GrpGmsIdGrp).HasColumnName("GRP_GMS__ID_GRP");
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.PrtGmsIdPrt).IsRequired();
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.PrtGmsIdPrt).HasColumnName("PRT_GMS__ID_PRT");
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.SprtGmsIdSprt).IsRequired();
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.SprtGmsIdSprt).HasColumnName("SPRT_GMS__ID_SPRT");
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.EltGmsIdElem).IsRequired();
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.EltGmsIdElem).HasColumnName("ELT_GMS__ID_ELEM");
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<GmsEltInspTmp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().HasRequired<GmsEltInspTmp>(c => c.GmsEltInspTmp).WithMany(t => t.GmsPhotoEltInspTmps).HasForeignKey(u => new { u.GmsEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPhotoEltInspTmp>().ToTable("PHOTO_ELT_INSP_TMP_GMS","GMS");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.GrpGmsIdGrp).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.GrpGmsIdGrp).HasColumnName("GRP_GMS__ID_GRP");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.PrtGmsIdPrt).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.PrtGmsIdPrt).HasColumnName("PRT_GMS__ID_PRT");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.SprtGmsIdSprt).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.SprtGmsIdSprt).HasColumnName("SPRT_GMS__ID_SPRT");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.DscTempGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.DscTempGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.DscTempGmsNumGms).HasColumnName("DSC_TEMP_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.EltGmsIdElem).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.EltGmsIdElem).HasColumnName("ELT_GMS__ID_ELEM");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoEltInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsInspTmp>().HasOptional<GmsCdMeteo>(c => c.GmsCdMeteo).WithMany(t => t.GmsInspTmps).HasForeignKey(u => new {u.GmsCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspTmp>().HasOptional<GmsCdEtude>(c => c.GmsCdEtude).WithMany(t => t.GmsInspTmps).HasForeignKey(u => new {u.GmsCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspTmp>().HasRequired<GmsDscTemp>(c => c.GmsDscTemp).WithMany(t => t.GmsInspTmps).HasForeignKey(u => new { u.GmsDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspTmp>().HasOptional<GmsInspecteur>(c => c.GmsInspecteur).WithMany(t => t.GmsInspTmps).HasForeignKey(u => new {u.GmsInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspTmp>().HasMany<GmsEltInspTmp>(c => c.GmsEltInspTmps).WithRequired(t => t.GmsInspTmp).HasForeignKey(u => new {u.GmsInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspTmp>().HasMany<GmsPhotoInspTmp>(c => c.GmsPhotoInspTmps).WithRequired(t => t.GmsInspTmp).HasForeignKey(u => new {u.GmsInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspTmp>().HasMany<GmsCdConclusionInspTmp>(c => c.GmsCdConclusionInspTmps).WithRequired(t => t.GmsInspTmp).HasForeignKey(u => new {u.GmsInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsInspTmp>().ToTable("INSP_TMP_GMS","GMS");
            modelBuilder.Entity<GmsInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.DscTempGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.DscTempGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.DscTempGmsNumGms).HasColumnName("DSC_TEMP_GMS__NUM_GMS");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.CdEtudeGmsEtude).HasMaxLength(65);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.CdEtudeGmsEtude).HasColumnName("CD_ETUDE_GMS__ETUDE");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.InspecteurGmsNom).HasMaxLength(60);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.InspecteurGmsNom).HasColumnName("INSPECTEUR_GMS__NOM");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.CdMeteoGmsMeteo).HasMaxLength(60);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.CdMeteoGmsMeteo).HasColumnName("CD_METEO_GMS__METEO");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.NomValid).HasMaxLength(255);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<GmsInspTmp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<GmsPhotoInspTmp>().HasRequired<GmsInspTmp>(c => c.GmsInspTmp).WithMany(t => t.GmsPhotoInspTmps).HasForeignKey(u => new { u.GmsInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsPhotoInspTmp>().ToTable("PHOTO_INSP_TMP_GMS","GMS");
            modelBuilder.Entity<GmsPhotoInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.DscTempGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.DscTempGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.DscTempGmsNumGms).HasColumnName("DSC_TEMP_GMS__NUM_GMS");
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GmsPhotoInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GmsClsDoc>().HasRequired<GmsCls>(c => c.GmsCls).WithMany(t => t.GmsClsDocs).HasForeignKey(u => new { u.GmsClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsClsDoc>().HasRequired<GmsDoc>(c => c.GmsDoc).WithMany(t => t.GmsClsDocs).HasForeignKey(u => new { u.GmsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsClsDoc>().ToTable("CLS_DOC_GMS","GMS");
            modelBuilder.Entity<GmsClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsClsDoc>().Property(item => item.ClsGmsId).IsRequired();
            modelBuilder.Entity<GmsClsDoc>().Property(item => item.ClsGmsId).HasColumnName("CLS_GMS__ID");
            modelBuilder.Entity<GmsClsDoc>().Property(item => item.DocGmsId).IsRequired();
            modelBuilder.Entity<GmsClsDoc>().Property(item => item.DocGmsId).HasColumnName("DOC_GMS__ID");
            modelBuilder.Entity<GmsClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<GmsClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<GmsClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<GmsClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
            modelBuilder.Entity<GmsDscCamp>().HasRequired<GmsDsc>(c => c.GmsDsc).WithMany(t => t.GmsDscCamps).HasForeignKey(u => new { u.GmsDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscCamp>().HasRequired<GmsCamp>(c => c.GmsCamp).WithMany(t => t.GmsDscCamps).HasForeignKey(u => new { u.GmsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsDscCamp>().ToTable("DSC_CAMP_GMS","GMS");
            modelBuilder.Entity<GmsDscCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsDscCamp>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsDscCamp>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsDscCamp>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsDscCamp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsDscCamp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsDscCamp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsDscCamp>().Property(item => item.RealiserValueInt).HasColumnName("REALISER");
            modelBuilder.Entity<GmsDscCamp>().Ignore(item => item.Realiser);
            modelBuilder.Entity<GmsCdPrecoSprtVst>().HasRequired<GmsBpu>(c => c.GmsBpu).WithMany(t => t.GmsCdPrecoSprtVsts).HasForeignKey(u => new { u.GmsBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPrecoSprtVst>().HasRequired<GmsSprtVst>(c => c.GmsSprtVst).WithMany(t => t.GmsCdPrecoSprtVsts).HasForeignKey(u => new { u.GmsSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdPrecoSprtVst>().ToTable("CD_PRECO__SPRT_VST_GMS","GMS");
            modelBuilder.Entity<GmsCdPrecoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.CdChapitreGmsIdChap).IsRequired();
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.CdChapitreGmsIdChap).HasColumnName("CD_CHAPITRE_GMS__ID_CHAP");
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.CdLigneGmsIdLigne).IsRequired();
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.CdLigneGmsIdLigne).HasColumnName("CD_LIGNE_GMS__ID_LIGNE");
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.BpuGmsIdBpu).IsRequired();
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.BpuGmsIdBpu).HasColumnName("BPU_GMS__ID_BPU");
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<GmsCdPrecoSprtVst>().Ignore(item => item.Realise);
            modelBuilder.Entity<GmsCdConclusionInsp>().HasRequired<GmsCdConclusion>(c => c.GmsCdConclusion).WithMany(t => t.GmsCdConclusionInsps).HasForeignKey(u => new { u.GmsCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdConclusionInsp>().HasRequired<GmsInsp>(c => c.GmsInsp).WithMany(t => t.GmsCdConclusionInsps).HasForeignKey(u => new { u.GmsInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdConclusionInsp>().ToTable("CD_CONCLUSION__INSP_GMS","GMS");
            modelBuilder.Entity<GmsCdConclusionInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.DscGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.DscGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.DscGmsNumGms).HasColumnName("DSC_GMS__NUM_GMS");
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.CdConclusionGmsIdConc).IsRequired();
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.CdConclusionGmsIdConc).HasColumnName("CD_CONCLUSION_GMS__ID_CONC");
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<GmsCdConclusionInsp>().Property(item => item.Contenu).HasColumnName("CONTENU");
            modelBuilder.Entity<GmsCdConclusionInspTmp>().HasRequired<GmsCdConclusion>(c => c.GmsCdConclusion).WithMany(t => t.GmsCdConclusionInspTmps).HasForeignKey(u => new { u.GmsCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdConclusionInspTmp>().HasRequired<GmsInspTmp>(c => c.GmsInspTmp).WithMany(t => t.GmsCdConclusionInspTmps).HasForeignKey(u => new { u.GmsInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GmsCdConclusionInspTmp>().ToTable("CD_CONCLUSION__INSP_TMP_GMS","GMS");
            modelBuilder.Entity<GmsCdConclusionInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.CampGmsIdCamp).IsRequired();
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.CampGmsIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.CampGmsIdCamp).HasColumnName("CAMP_GMS__ID_CAMP");
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.DscTempGmsNumGms).IsRequired();
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.DscTempGmsNumGms).HasMaxLength(17);
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.DscTempGmsNumGms).HasColumnName("DSC_TEMP_GMS__NUM_GMS");
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.CdConclusionGmsIdConc).IsRequired();
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.CdConclusionGmsIdConc).HasColumnName("CD_CONCLUSION_GMS__ID_CONC");
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<GmsCdConclusionInspTmp>().Property(item => item.Contenu).HasColumnName("CONTENU");
        }
    }
}
