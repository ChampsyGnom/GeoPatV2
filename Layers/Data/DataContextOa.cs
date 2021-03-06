using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextOa : DataContextBase
    {
        public DataContextOa(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<OaCdFam> OaCdFams { get; set; }
        
        public DbSet<OaCdType> OaCdTypes { get; set; }
        
        public DbSet<OaCdEntp> OaCdEntps { get; set; }
        
        public DbSet<OaDsc> OaDscs { get; set; }
        
        public DbSet<OaCdCharge> OaCdCharges { get; set; }
        
        public DbSet<OaCdFond> OaCdFonds { get; set; }
        
        public DbSet<OaCdFamAppui> OaCdFamAppuis { get; set; }
        
        public DbSet<OaCdAppui> OaCdAppuis { get; set; }
        
        public DbSet<OaCdAppAppui> OaCdAppAppuis { get; set; }
        
        public DbSet<OaCdChape> OaCdChapes { get; set; }
        
        public DbSet<OaTablier> OaTabliers { get; set; }
        
        public DbSet<OaCdDpr> OaCdDprs { get; set; }
        
        public DbSet<OaEquipement> OaEquipements { get; set; }
        
        public DbSet<OaCdGc> OaCdGcs { get; set; }
        
        public DbSet<OaJoint> OaJoints { get; set; }
        
        public DbSet<OaCdJoint> OaCdJoints { get; set; }
        
        public DbSet<OaCdTablier> OaCdTabliers { get; set; }
        
        public DbSet<OaCdMat> OaCdMats { get; set; }
        
        public DbSet<OaCls> OaClss { get; set; }
        
        public DbSet<OaDoc> OaDocs { get; set; }
        
        public DbSet<OaCdDoc> OaCdDocs { get; set; }
        
        public DbSet<OaSysUser> OaSysUsers { get; set; }
        
        public DbSet<OaCdBe> OaCdBes { get; set; }
        
        public DbSet<OaCdGest> OaCdGests { get; set; }
        
        public DbSet<OaElt> OaElts { get; set; }
        
        public DbSet<OaSprt> OaSprts { get; set; }
        
        public DbSet<OaPrt> OaPrts { get; set; }
        
        public DbSet<OaGrp> OaGrps { get; set; }
        
        public DbSet<OaInsp> OaInsps { get; set; }
        
        public DbSet<OaEltInsp> OaEltInsps { get; set; }
        
        public DbSet<OaPhotoEltInsp> OaPhotoEltInsps { get; set; }
        
        public DbSet<OaCamp> OaCamps { get; set; }
        
        public DbSet<OaCdMeteo> OaCdMeteos { get; set; }
        
        public DbSet<OaCdPresta> OaCdPrestas { get; set; }
        
        public DbSet<OaTravaux> OaTravauxs { get; set; }
        
        public DbSet<OaNatureTrav> OaNatureTravs { get; set; }
        
        public DbSet<OaCdIqoa> OaCdIqoas { get; set; }
        
        public DbSet<OaCdMo> OaCdMos { get; set; }
        
        public DbSet<OaBpu> OaBpus { get; set; }
        
        public DbSet<OaCdTravaux> OaCdTravauxs { get; set; }
        
        public DbSet<OaCdTech> OaCdTechs { get; set; }
        
        public DbSet<OaCdOrigin> OaCdOrigins { get; set; }
        
        public DbSet<OaHistoNote> OaHistoNotes { get; set; }
        
        public DbSet<OaCdEvt> OaCdEvts { get; set; }
        
        public DbSet<OaEvt> OaEvts { get; set; }
        
        public DbSet<OaPrevision> OaPrevisions { get; set; }
        
        public DbSet<OaCdContrainte> OaCdContraintes { get; set; }
        
        public DbSet<OaSeuilUrgence> OaSeuilUrgences { get; set; }
        
        public DbSet<OaDictionnaire> OaDictionnaires { get; set; }
        
        public DbSet<OaPhotoInsp> OaPhotoInsps { get; set; }
        
        public DbSet<OaCdEtude> OaCdEtudes { get; set; }
        
        public DbSet<OaCdTypePv> OaCdTypePvs { get; set; }
        
        public DbSet<OaCdQualite> OaCdQualites { get; set; }
        
        public DbSet<OaPhotoVst> OaPhotoVsts { get; set; }
        
        public DbSet<OaSprtVst> OaSprtVsts { get; set; }
        
        public DbSet<OaPhotoSprtVst> OaPhotoSprtVsts { get; set; }
        
        public DbSet<OaVst> OaVsts { get; set; }
        
        public DbSet<OaCdHierarchie> OaCdHierarchies { get; set; }
        
        public DbSet<OaCdEntete> OaCdEntetes { get; set; }
        
        public DbSet<OaCdChapitre> OaCdChapitres { get; set; }
        
        public DbSet<OaCdLigne> OaCdLignes { get; set; }
        
        public DbSet<OaEntete> OaEntetes { get; set; }
        
        public DbSet<OaContact> OaContacts { get; set; }
        
        public DbSet<OaInspecteur> OaInspecteurs { get; set; }
        
        public DbSet<OaCdUnite> OaCdUnites { get; set; }
        
        public DbSet<OaCdComposant> OaCdComposants { get; set; }
        
        public DbSet<OaCdConclusion> OaCdConclusions { get; set; }
        
        public DbSet<OaDscTemp> OaDscTemps { get; set; }
        
        public DbSet<OaInspTmp> OaInspTmps { get; set; }
        
        public DbSet<OaEltInspTmp> OaEltInspTmps { get; set; }
        
        public DbSet<OaPhotoInspTmp> OaPhotoInspTmps { get; set; }
        
        public DbSet<OaPhotoEltInspTmp> OaPhotoEltInspTmps { get; set; }
        
        public DbSet<OaCdOccupant> OaCdOccupants { get; set; }
        
        public DbSet<OaOccupation> OaOccupations { get; set; }
        
        public DbSet<OaCdOccup> OaCdOccups { get; set; }
        
        public DbSet<OaArchive3> OaArchive3s { get; set; }
        
        public DbSet<OaClsDoc> OaClsDocs { get; set; }
        
        public DbSet<OaAppuis> OaAppuiss { get; set; }
        
        public DbSet<OaDscCamp> OaDscCamps { get; set; }
        
        public DbSet<OaCdPrecoSprtVst> OaCdPrecoSprtVsts { get; set; }
        
        public DbSet<OaCdConclusionInsp> OaCdConclusionInsps { get; set; }
        
        public DbSet<OaCdConclusionInspTmp> OaCdConclusionInspTmps { get; set; }
        
        public DbSet<OaDscArchive3> OaDscArchive3s { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<OaCdFam>().HasMany<OaDsc>(c => c.OaDscs).WithRequired(t => t.OaCdFam).HasForeignKey(u => new {u.OaCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdFam>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithRequired(t => t.OaCdFam).HasForeignKey(u => new {u.OaCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdFam>().ToTable("CD_FAM_OA","OA");
            modelBuilder.Entity<OaCdFam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdFam>().Property(item => item.Famille).IsRequired();
            modelBuilder.Entity<OaCdFam>().Property(item => item.Famille).HasMaxLength(20);
            modelBuilder.Entity<OaCdFam>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<OaCdFam>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OaCdFam>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdType>().HasMany<OaDsc>(c => c.OaDscs).WithRequired(t => t.OaCdType).HasForeignKey(u => new {u.OaCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdType>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithRequired(t => t.OaCdType).HasForeignKey(u => new {u.OaCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdType>().ToTable("CD_TYPE_OA","OA");
            modelBuilder.Entity<OaCdType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdType>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OaCdType>().Property(item => item.Type).HasMaxLength(20);
            modelBuilder.Entity<OaCdType>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OaCdType>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OaCdType>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdEntp>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdEntp).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEntp>().HasMany<OaTravaux>(c => c.OaTravauxs).WithOptional(t => t.OaCdEntp).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEntp>().HasMany<OaTablier>(c => c.OaTabliers).WithOptional(t => t.OaCdEntp).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEntp>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdEntp).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEntp>().ToTable("CD_ENTP_OA","OA");
            modelBuilder.Entity<OaCdEntp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdEntp>().Property(item => item.Entreprise).IsRequired();
            modelBuilder.Entity<OaCdEntp>().Property(item => item.Entreprise).HasMaxLength(60);
            modelBuilder.Entity<OaCdEntp>().Property(item => item.Entreprise).HasColumnName("ENTREPRISE");
            modelBuilder.Entity<OaDsc>().HasRequired<OaCdType>(c => c.OaCdType).WithMany(t => t.OaDscs).HasForeignKey(u => new { u.OaCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdEntp>(c => c.OaCdEntp).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdCharge>(c => c.OaCdCharge).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdChargeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdMat>(c => c.OaCdMat).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdBe>(c => c.OaCdBe).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdBeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdGest>(c => c.OaCdGest).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdGestIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdFond>(c => c.OaCdFond).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdFondIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdTablier>(c => c.OaCdTablier).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdMo>(c => c.OaCdMo).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdQualite>(c => c.OaCdQualite).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasRequired<OaCdFam>(c => c.OaCdFam).WithMany(t => t.OaDscs).HasForeignKey(u => new { u.OaCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasOptional<OaCdHierarchie>(c => c.OaCdHierarchie).WithMany(t => t.OaDscs).HasForeignKey(u => new {u.OaCdHierarchieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaTravaux>(c => c.OaTravauxs).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaHistoNote>(c => c.OaHistoNotes).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaPrevision>(c => c.OaPrevisions).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaInsp>(c => c.OaInsps).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaEvt>(c => c.OaEvts).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaVst>(c => c.OaVsts).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaOccupation>(c => c.OaOccupations).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaAppuis>(c => c.OaAppuiss).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaDscCamp>(c => c.OaDscCamps).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().HasMany<OaDscArchive3>(c => c.OaDscArchive3s).WithRequired(t => t.OaDsc).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDsc>().ToTable("DSC_OA","OA");
            modelBuilder.Entity<OaDsc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaDsc>().Property(item => item.NumOa).IsRequired();
            modelBuilder.Entity<OaDsc>().Property(item => item.NumOa).HasMaxLength(20);
            modelBuilder.Entity<OaDsc>().Property(item => item.NumOa).HasColumnName("NUM_OA");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdIqoaOaNoteIqoa).HasMaxLength(3);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdIqoaOaNoteIqoa).HasColumnName("CD_IQOA_OA__NOTE_IQOA");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdQualiteOaQualite).HasMaxLength(25);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdQualiteOaQualite).HasColumnName("CD_QUALITE_OA__QUALITE");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdFamOaFamille).IsRequired();
            modelBuilder.Entity<OaDsc>().Property(item => item.CdFamOaFamille).HasMaxLength(20);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdFamOaFamille).HasColumnName("CD_FAM_OA__FAMILLE");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdEntpOaEntreprise).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdEntpOaEntreprise).HasColumnName("CD_ENTP_OA__ENTREPRISE");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdTablierOaTablier).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdTablierOaTablier).HasColumnName("CD_TABLIER_OA__TABLIER");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdTypeOaType).IsRequired();
            modelBuilder.Entity<OaDsc>().Property(item => item.CdTypeOaType).HasMaxLength(20);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdTypeOaType).HasColumnName("CD_TYPE_OA__TYPE");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdGestOaGestionnaire).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdGestOaGestionnaire).HasColumnName("CD_GEST_OA__GESTIONNAIRE");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdHierarchieOaHierarchie).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdHierarchieOaHierarchie).HasColumnName("CD_HIERARCHIE_OA__HIERARCHIE");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdMatOaMateriaux).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdMatOaMateriaux).HasColumnName("CD_MAT_OA__MATERIAUX");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdChargeOaSurcharge).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdChargeOaSurcharge).HasColumnName("CD_CHARGE_OA__SURCHARGE");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdBeOaBureau).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdBeOaBureau).HasColumnName("CD_BE_OA__BUREAU");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdMoOaMaitreOuvr).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdMoOaMaitreOuvr).HasColumnName("CD_MO_OA__MAITRE_OUVR");
            modelBuilder.Entity<OaDsc>().Property(item => item.CdFondOaType).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.CdFondOaType).HasColumnName("CD_FOND_OA__TYPE");
            modelBuilder.Entity<OaDsc>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<OaDsc>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<OaDsc>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<OaDsc>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<OaDsc>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<OaDsc>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<OaDsc>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<OaDsc>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<OaDsc>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<OaDsc>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<OaDsc>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<OaDsc>().Property(item => item.NomUsage).HasMaxLength(255);
            modelBuilder.Entity<OaDsc>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<OaDsc>().Property(item => item.DateConst).HasColumnName("DATE_CONST");
            modelBuilder.Entity<OaDsc>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<OaDsc>().Property(item => item.Vpf).HasMaxLength(60);
            modelBuilder.Entity<OaDsc>().Property(item => item.Vpf).HasColumnName("VPF");
            modelBuilder.Entity<OaDsc>().Property(item => item.TraficVpf).HasColumnName("TRAFIC_VPF");
            modelBuilder.Entity<OaDsc>().Property(item => item.Deviation).HasColumnName("DEVIATION");
            modelBuilder.Entity<OaDsc>().Property(item => item.Nbpilesinter).HasColumnName("NBPILESINTER");
            modelBuilder.Entity<OaDsc>().Property(item => item.Travure).HasColumnName("TRAVURE");
            modelBuilder.Entity<OaDsc>().Property(item => item.LongMaxTrav).HasColumnName("LONG_MAX_TRAV");
            modelBuilder.Entity<OaDsc>().Property(item => item.GabMini).HasColumnName("GAB_MINI");
            modelBuilder.Entity<OaDsc>().Property(item => item.GabGraValueInt).HasColumnName("GAB_GRA");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.GabGra);
            modelBuilder.Entity<OaDsc>().Property(item => item.Biais).HasColumnName("BIAIS");
            modelBuilder.Entity<OaDsc>().Property(item => item.LongBiaise).HasColumnName("LONG_BIAISE");
            modelBuilder.Entity<OaDsc>().Property(item => item.LargTrav).HasColumnName("LARG_TRAV");
            modelBuilder.Entity<OaDsc>().Property(item => item.LargBiaise).HasColumnName("LARG_BIAISE");
            modelBuilder.Entity<OaDsc>().Property(item => item.LargGs).HasColumnName("LARG_GS");
            modelBuilder.Entity<OaDsc>().Property(item => item.SurfTablier).HasColumnName("SURF_TABLIER");
            modelBuilder.Entity<OaDsc>().Property(item => item.SurfVpf).HasColumnName("SURF_VPF");
            modelBuilder.Entity<OaDsc>().Property(item => item.ImmergeValueInt).HasColumnName("IMMERGE");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Immerge);
            modelBuilder.Entity<OaDsc>().Property(item => item.SismiciteValueInt).HasColumnName("SISMICITE");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Sismicite);
            modelBuilder.Entity<OaDsc>().Property(item => item.DalleValueInt).HasColumnName("DALLE");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Dalle);
            modelBuilder.Entity<OaDsc>().Property(item => item.CornValueInt).HasColumnName("CORN");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Corn);
            modelBuilder.Entity<OaDsc>().Property(item => item.LanterneauValueInt).HasColumnName("LANTERNEAU");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Lanterneau);
            modelBuilder.Entity<OaDsc>().Property(item => item.EquipVstValueInt).HasColumnName("EQUIP_VST");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.EquipVst);
            modelBuilder.Entity<OaDsc>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OaDsc>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OaDsc>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OaDsc>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OaDsc>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OaDsc>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OaDsc>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OaDsc>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Securite);
            modelBuilder.Entity<OaDsc>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OaDsc>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<OaDsc>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<OaDsc>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<OaDsc>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<OaDsc>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<OaDsc>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<OaDsc>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<OaDsc>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<OaDsc>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaDsc>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<OaDsc>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<OaDsc>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<OaDsc>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<OaDsc>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<OaDsc>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<OaDsc>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<OaDsc>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<OaDsc>().Ignore(item => item.Terrain);
            modelBuilder.Entity<OaCdCharge>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdCharge).HasForeignKey(u => new {u.OaCdChargeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdCharge>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdCharge).HasForeignKey(u => new {u.OaCdChargeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdCharge>().ToTable("CD_CHARGE_OA","OA");
            modelBuilder.Entity<OaCdCharge>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdCharge>().Property(item => item.Surcharge).IsRequired();
            modelBuilder.Entity<OaCdCharge>().Property(item => item.Surcharge).HasMaxLength(60);
            modelBuilder.Entity<OaCdCharge>().Property(item => item.Surcharge).HasColumnName("SURCHARGE");
            modelBuilder.Entity<OaCdFond>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdFond).HasForeignKey(u => new {u.OaCdFondIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdFond>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdFond).HasForeignKey(u => new {u.OaCdFondIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdFond>().ToTable("CD_FOND_OA","OA");
            modelBuilder.Entity<OaCdFond>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdFond>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OaCdFond>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<OaCdFond>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OaCdFamAppui>().HasMany<OaAppuis>(c => c.OaAppuiss).WithRequired(t => t.OaCdFamAppui).HasForeignKey(u => new {u.OaCdFamAppuiIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdFamAppui>().ToTable("CD_FAM_APPUI_OA","OA");
            modelBuilder.Entity<OaCdFamAppui>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdFamAppui>().Property(item => item.FamApp).IsRequired();
            modelBuilder.Entity<OaCdFamAppui>().Property(item => item.FamApp).HasMaxLength(60);
            modelBuilder.Entity<OaCdFamAppui>().Property(item => item.FamApp).HasColumnName("FAM_APP");
            modelBuilder.Entity<OaCdAppui>().HasMany<OaAppuis>(c => c.OaAppuiss).WithRequired(t => t.OaCdAppui).HasForeignKey(u => new {u.OaCdAppuiIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdAppui>().ToTable("CD_APPUI_OA","OA");
            modelBuilder.Entity<OaCdAppui>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdAppui>().Property(item => item.App).IsRequired();
            modelBuilder.Entity<OaCdAppui>().Property(item => item.App).HasMaxLength(60);
            modelBuilder.Entity<OaCdAppui>().Property(item => item.App).HasColumnName("APP");
            modelBuilder.Entity<OaCdAppAppui>().HasMany<OaAppuis>(c => c.OaAppuiss).WithRequired(t => t.OaCdAppAppui).HasForeignKey(u => new {u.OaCdAppAppuiIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdAppAppui>().ToTable("CD_APP_APPUI_OA","OA");
            modelBuilder.Entity<OaCdAppAppui>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdAppAppui>().Property(item => item.Appui).IsRequired();
            modelBuilder.Entity<OaCdAppAppui>().Property(item => item.Appui).HasMaxLength(60);
            modelBuilder.Entity<OaCdAppAppui>().Property(item => item.Appui).HasColumnName("APPUI");
            modelBuilder.Entity<OaCdAppAppui>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<OaCdAppAppui>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<OaCdChape>().HasMany<OaTablier>(c => c.OaTabliers).WithOptional(t => t.OaCdChape).HasForeignKey(u => new {u.OaCdChapeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdChape>().ToTable("CD_CHAPE_OA","OA");
            modelBuilder.Entity<OaCdChape>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdChape>().Property(item => item.Chape).IsRequired();
            modelBuilder.Entity<OaCdChape>().Property(item => item.Chape).HasMaxLength(60);
            modelBuilder.Entity<OaCdChape>().Property(item => item.Chape).HasColumnName("CHAPE");
            modelBuilder.Entity<OaCdChape>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<OaCdChape>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<OaTablier>().HasOptional<OaCdChape>(c => c.OaCdChape).WithMany(t => t.OaTabliers).HasForeignKey(u => new {u.OaCdChapeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTablier>().HasOptional<OaCdTech>(c => c.OaCdTech).WithMany(t => t.OaTabliers).HasForeignKey(u => new {u.OaCdTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTablier>().HasOptional<OaCdEntp>(c => c.OaCdEntp).WithMany(t => t.OaTabliers).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTablier>().HasMany<OaJoint>(c => c.OaJoints).WithRequired(t => t.OaTablier).HasForeignKey(u => new {u.OaTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTablier>().HasMany<OaEquipement>(c => c.OaEquipements).WithRequired(t => t.OaTablier).HasForeignKey(u => new {u.OaTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTablier>().ToTable("TABLIER_OA","OA");
            modelBuilder.Entity<OaTablier>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaTablier>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaTablier>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaTablier>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaTablier>().Property(item => item.NumTab).IsRequired();
            modelBuilder.Entity<OaTablier>().Property(item => item.NumTab).HasColumnName("NUM_TAB");
            modelBuilder.Entity<OaTablier>().Property(item => item.CdEntpOaEntreprise).HasMaxLength(60);
            modelBuilder.Entity<OaTablier>().Property(item => item.CdEntpOaEntreprise).HasColumnName("CD_ENTP_OA__ENTREPRISE");
            modelBuilder.Entity<OaTablier>().Property(item => item.CdTechOaTechnique).HasMaxLength(12);
            modelBuilder.Entity<OaTablier>().Property(item => item.CdTechOaTechnique).HasColumnName("CD_TECH_OA__TECHNIQUE");
            modelBuilder.Entity<OaTablier>().Property(item => item.CdChapeOaChape).HasMaxLength(60);
            modelBuilder.Entity<OaTablier>().Property(item => item.CdChapeOaChape).HasColumnName("CD_CHAPE_OA__CHAPE");
            modelBuilder.Entity<OaTablier>().Property(item => item.DateMsChape).HasColumnName("DATE_MS_CHAPE");
            modelBuilder.Entity<OaTablier>().Property(item => item.SurfChape).HasColumnName("SURF_CHAPE");
            modelBuilder.Entity<OaTablier>().Property(item => item.EpaisChape).HasColumnName("EPAIS_CHAPE");
            modelBuilder.Entity<OaTablier>().Property(item => item.DateMsBb).HasColumnName("DATE_MS_BB");
            modelBuilder.Entity<OaTablier>().Property(item => item.Epais).HasColumnName("EPAIS");
            modelBuilder.Entity<OaTablier>().Property(item => item.Granulo).HasMaxLength(8);
            modelBuilder.Entity<OaTablier>().Property(item => item.Granulo).HasColumnName("GRANULO");
            modelBuilder.Entity<OaTablier>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<OaTablier>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaCdDpr>().HasMany<OaEquipement>(c => c.OaEquipements).WithOptional(t => t.OaCdDpr).HasForeignKey(u => new {u.OaCdDprIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdDpr>().ToTable("CD_DPR_OA","OA");
            modelBuilder.Entity<OaCdDpr>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdDpr>().Property(item => item.Dpr).IsRequired();
            modelBuilder.Entity<OaCdDpr>().Property(item => item.Dpr).HasMaxLength(60);
            modelBuilder.Entity<OaCdDpr>().Property(item => item.Dpr).HasColumnName("DPR");
            modelBuilder.Entity<OaCdDpr>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<OaCdDpr>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<OaEquipement>().HasOptional<OaCdDpr>(c => c.OaCdDpr).WithMany(t => t.OaEquipements).HasForeignKey(u => new {u.OaCdDprIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEquipement>().HasRequired<OaTablier>(c => c.OaTablier).WithMany(t => t.OaEquipements).HasForeignKey(u => new { u.OaTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEquipement>().HasOptional<OaCdGc>(c => c.OaCdGc).WithMany(t => t.OaEquipements).HasForeignKey(u => new {u.OaCdGcIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEquipement>().ToTable("EQUIPEMENT_OA","OA");
            modelBuilder.Entity<OaEquipement>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaEquipement>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaEquipement>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaEquipement>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaEquipement>().Property(item => item.TablierOaNumTab).IsRequired();
            modelBuilder.Entity<OaEquipement>().Property(item => item.TablierOaNumTab).HasColumnName("TABLIER_OA__NUM_TAB");
            modelBuilder.Entity<OaEquipement>().Property(item => item.Cote).IsRequired();
            modelBuilder.Entity<OaEquipement>().Property(item => item.Cote).HasMaxLength(1);
            modelBuilder.Entity<OaEquipement>().Property(item => item.Cote).HasColumnName("COTE");
            modelBuilder.Entity<OaEquipement>().Property(item => item.CdDprOaDpr).HasMaxLength(60);
            modelBuilder.Entity<OaEquipement>().Property(item => item.CdDprOaDpr).HasColumnName("CD_DPR_OA__DPR");
            modelBuilder.Entity<OaEquipement>().Property(item => item.CdGcOaGardeCorps).HasMaxLength(60);
            modelBuilder.Entity<OaEquipement>().Property(item => item.CdGcOaGardeCorps).HasColumnName("CD_GC_OA__GARDE_CORPS");
            modelBuilder.Entity<OaEquipement>().Property(item => item.DateDpr).HasColumnName("DATE_DPR");
            modelBuilder.Entity<OaEquipement>().Property(item => item.DateGc).HasColumnName("DATE_GC");
            modelBuilder.Entity<OaEquipement>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<OaEquipement>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaCdGc>().HasMany<OaEquipement>(c => c.OaEquipements).WithOptional(t => t.OaCdGc).HasForeignKey(u => new {u.OaCdGcIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdGc>().ToTable("CD_GC_OA","OA");
            modelBuilder.Entity<OaCdGc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdGc>().Property(item => item.GardeCorps).IsRequired();
            modelBuilder.Entity<OaCdGc>().Property(item => item.GardeCorps).HasMaxLength(60);
            modelBuilder.Entity<OaCdGc>().Property(item => item.GardeCorps).HasColumnName("GARDE_CORPS");
            modelBuilder.Entity<OaCdGc>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<OaCdGc>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<OaJoint>().HasRequired<OaTablier>(c => c.OaTablier).WithMany(t => t.OaJoints).HasForeignKey(u => new { u.OaTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaJoint>().HasRequired<OaCdJoint>(c => c.OaCdJoint).WithMany(t => t.OaJoints).HasForeignKey(u => new { u.OaCdJointIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaJoint>().ToTable("JOINT_OA","OA");
            modelBuilder.Entity<OaJoint>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaJoint>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaJoint>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaJoint>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaJoint>().Property(item => item.TablierOaNumTab).IsRequired();
            modelBuilder.Entity<OaJoint>().Property(item => item.TablierOaNumTab).HasColumnName("TABLIER_OA__NUM_TAB");
            modelBuilder.Entity<OaJoint>().Property(item => item.NumJoint).IsRequired();
            modelBuilder.Entity<OaJoint>().Property(item => item.NumJoint).HasColumnName("NUM_JOINT");
            modelBuilder.Entity<OaJoint>().Property(item => item.CdJointOaType).IsRequired();
            modelBuilder.Entity<OaJoint>().Property(item => item.CdJointOaType).HasMaxLength(60);
            modelBuilder.Entity<OaJoint>().Property(item => item.CdJointOaType).HasColumnName("CD_JOINT_OA__TYPE");
            modelBuilder.Entity<OaJoint>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<OaJoint>().Property(item => item.Longueur).HasColumnName("LONGUEUR");
            modelBuilder.Entity<OaJoint>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<OaJoint>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaCdJoint>().HasMany<OaJoint>(c => c.OaJoints).WithRequired(t => t.OaCdJoint).HasForeignKey(u => new {u.OaCdJointIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdJoint>().ToTable("CD_JOINT_OA","OA");
            modelBuilder.Entity<OaCdJoint>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdJoint>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OaCdJoint>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<OaCdJoint>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OaCdJoint>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<OaCdJoint>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<OaCdTablier>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdTablier).HasForeignKey(u => new {u.OaCdTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdTablier>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdTablier).HasForeignKey(u => new {u.OaCdTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdTablier>().ToTable("CD_TABLIER_OA","OA");
            modelBuilder.Entity<OaCdTablier>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdTablier>().Property(item => item.Tablier).IsRequired();
            modelBuilder.Entity<OaCdTablier>().Property(item => item.Tablier).HasMaxLength(60);
            modelBuilder.Entity<OaCdTablier>().Property(item => item.Tablier).HasColumnName("TABLIER");
            modelBuilder.Entity<OaCdMat>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdMat).HasForeignKey(u => new {u.OaCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdMat>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdMat).HasForeignKey(u => new {u.OaCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdMat>().ToTable("CD_MAT_OA","OA");
            modelBuilder.Entity<OaCdMat>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdMat>().Property(item => item.Materiaux).IsRequired();
            modelBuilder.Entity<OaCdMat>().Property(item => item.Materiaux).HasMaxLength(60);
            modelBuilder.Entity<OaCdMat>().Property(item => item.Materiaux).HasColumnName("MATERIAUX");
            modelBuilder.Entity<OaCls>().HasMany<OaClsDoc>(c => c.OaClsDocs).WithRequired(t => t.OaCls).HasForeignKey(u => new {u.OaClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCls>().ToTable("CLS_OA","OA");
            modelBuilder.Entity<OaCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaCls>().Property(item => item.TableName).IsRequired();
            modelBuilder.Entity<OaCls>().Property(item => item.TableName).HasMaxLength(30);
            modelBuilder.Entity<OaCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<OaCls>().Property(item => item.KeyValue).IsRequired();
            modelBuilder.Entity<OaCls>().Property(item => item.KeyValue).HasMaxLength(1000);
            modelBuilder.Entity<OaCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<OaDoc>().HasRequired<OaCdDoc>(c => c.OaCdDoc).WithMany(t => t.OaDocs).HasForeignKey(u => new { u.OaCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDoc>().HasMany<OaContact>(c => c.OaContacts).WithRequired(t => t.OaDoc).HasForeignKey(u => new {u.OaDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDoc>().HasMany<OaClsDoc>(c => c.OaClsDocs).WithRequired(t => t.OaDoc).HasForeignKey(u => new {u.OaDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDoc>().ToTable("DOC_OA","OA");
            modelBuilder.Entity<OaDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaDoc>().Property(item => item.CdDocOaCode).IsRequired();
            modelBuilder.Entity<OaDoc>().Property(item => item.CdDocOaCode).HasMaxLength(15);
            modelBuilder.Entity<OaDoc>().Property(item => item.CdDocOaCode).HasColumnName("CD_DOC_OA__CODE");
            modelBuilder.Entity<OaDoc>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<OaDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaDoc>().Property(item => item.Ref).IsRequired();
            modelBuilder.Entity<OaDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<OaDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<OaCdDoc>().HasMany<OaDoc>(c => c.OaDocs).WithRequired(t => t.OaCdDoc).HasForeignKey(u => new {u.OaCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdDoc>().ToTable("CD_DOC_OA","OA");
            modelBuilder.Entity<OaCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<OaCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<OaCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<OaCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OaCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<OaCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<OaSysUser>().ToTable("SYS_USER_OA","OA");
            modelBuilder.Entity<OaSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<OaSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<OaSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<OaSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<OaSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<OaSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<OaSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<OaSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<OaCdBe>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdBe).HasForeignKey(u => new {u.OaCdBeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdBe>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdBe).HasForeignKey(u => new {u.OaCdBeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdBe>().ToTable("CD_BE_OA","OA");
            modelBuilder.Entity<OaCdBe>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdBe>().Property(item => item.Bureau).IsRequired();
            modelBuilder.Entity<OaCdBe>().Property(item => item.Bureau).HasMaxLength(60);
            modelBuilder.Entity<OaCdBe>().Property(item => item.Bureau).HasColumnName("BUREAU");
            modelBuilder.Entity<OaCdGest>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdGest).HasForeignKey(u => new {u.OaCdGestIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdGest>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdGest).HasForeignKey(u => new {u.OaCdGestIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdGest>().ToTable("CD_GEST_OA","OA");
            modelBuilder.Entity<OaCdGest>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdGest>().Property(item => item.Gestionnaire).IsRequired();
            modelBuilder.Entity<OaCdGest>().Property(item => item.Gestionnaire).HasMaxLength(60);
            modelBuilder.Entity<OaCdGest>().Property(item => item.Gestionnaire).HasColumnName("GESTIONNAIRE");
            modelBuilder.Entity<OaElt>().HasRequired<OaSprt>(c => c.OaSprt).WithMany(t => t.OaElts).HasForeignKey(u => new { u.OaSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaElt>().HasMany<OaEltInsp>(c => c.OaEltInsps).WithRequired(t => t.OaElt).HasForeignKey(u => new {u.OaEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaElt>().HasMany<OaEltInspTmp>(c => c.OaEltInspTmps).WithRequired(t => t.OaElt).HasForeignKey(u => new {u.OaEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaElt>().ToTable("ELT_OA","OA");
            modelBuilder.Entity<OaElt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaElt>().Property(item => item.GrpOaIdGrp).IsRequired();
            modelBuilder.Entity<OaElt>().Property(item => item.GrpOaIdGrp).HasColumnName("GRP_OA__ID_GRP");
            modelBuilder.Entity<OaElt>().Property(item => item.PrtOaIdPrt).IsRequired();
            modelBuilder.Entity<OaElt>().Property(item => item.PrtOaIdPrt).HasColumnName("PRT_OA__ID_PRT");
            modelBuilder.Entity<OaElt>().Property(item => item.SprtOaIdSprt).IsRequired();
            modelBuilder.Entity<OaElt>().Property(item => item.SprtOaIdSprt).HasColumnName("SPRT_OA__ID_SPRT");
            modelBuilder.Entity<OaElt>().Property(item => item.IdElem).IsRequired();
            modelBuilder.Entity<OaElt>().Property(item => item.IdElem).HasColumnName("ID_ELEM");
            modelBuilder.Entity<OaElt>().Property(item => item.Libe).IsRequired();
            modelBuilder.Entity<OaElt>().Property(item => item.Libe).HasMaxLength(500);
            modelBuilder.Entity<OaElt>().Property(item => item.Libe).HasColumnName("LIBE");
            modelBuilder.Entity<OaElt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OaElt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OaElt>().Property(item => item.Aide).HasMaxLength(500);
            modelBuilder.Entity<OaElt>().Property(item => item.Aide).HasColumnName("AIDE");
            modelBuilder.Entity<OaElt>().Property(item => item.Indice1).HasMaxLength(500);
            modelBuilder.Entity<OaElt>().Property(item => item.Indice1).HasColumnName("INDICE1");
            modelBuilder.Entity<OaElt>().Property(item => item.Indice2).HasMaxLength(500);
            modelBuilder.Entity<OaElt>().Property(item => item.Indice2).HasColumnName("INDICE2");
            modelBuilder.Entity<OaElt>().Property(item => item.Indice3).HasMaxLength(500);
            modelBuilder.Entity<OaElt>().Property(item => item.Indice3).HasColumnName("INDICE3");
            modelBuilder.Entity<OaSprt>().HasRequired<OaPrt>(c => c.OaPrt).WithMany(t => t.OaSprts).HasForeignKey(u => new { u.OaPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaSprt>().HasMany<OaElt>(c => c.OaElts).WithRequired(t => t.OaSprt).HasForeignKey(u => new {u.OaSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaSprt>().ToTable("SPRT_OA","OA");
            modelBuilder.Entity<OaSprt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaSprt>().Property(item => item.GrpOaIdGrp).IsRequired();
            modelBuilder.Entity<OaSprt>().Property(item => item.GrpOaIdGrp).HasColumnName("GRP_OA__ID_GRP");
            modelBuilder.Entity<OaSprt>().Property(item => item.PrtOaIdPrt).IsRequired();
            modelBuilder.Entity<OaSprt>().Property(item => item.PrtOaIdPrt).HasColumnName("PRT_OA__ID_PRT");
            modelBuilder.Entity<OaSprt>().Property(item => item.IdSprt).IsRequired();
            modelBuilder.Entity<OaSprt>().Property(item => item.IdSprt).HasColumnName("ID_SPRT");
            modelBuilder.Entity<OaSprt>().Property(item => item.Libs).IsRequired();
            modelBuilder.Entity<OaSprt>().Property(item => item.Libs).HasMaxLength(500);
            modelBuilder.Entity<OaSprt>().Property(item => item.Libs).HasColumnName("LIBS");
            modelBuilder.Entity<OaSprt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OaSprt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OaPrt>().HasRequired<OaGrp>(c => c.OaGrp).WithMany(t => t.OaPrts).HasForeignKey(u => new { u.OaGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPrt>().HasMany<OaSprt>(c => c.OaSprts).WithRequired(t => t.OaPrt).HasForeignKey(u => new {u.OaPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPrt>().ToTable("PRT_OA","OA");
            modelBuilder.Entity<OaPrt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPrt>().Property(item => item.GrpOaIdGrp).IsRequired();
            modelBuilder.Entity<OaPrt>().Property(item => item.GrpOaIdGrp).HasColumnName("GRP_OA__ID_GRP");
            modelBuilder.Entity<OaPrt>().Property(item => item.IdPrt).IsRequired();
            modelBuilder.Entity<OaPrt>().Property(item => item.IdPrt).HasColumnName("ID_PRT");
            modelBuilder.Entity<OaPrt>().Property(item => item.Libp).IsRequired();
            modelBuilder.Entity<OaPrt>().Property(item => item.Libp).HasMaxLength(500);
            modelBuilder.Entity<OaPrt>().Property(item => item.Libp).HasColumnName("LIBP");
            modelBuilder.Entity<OaPrt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OaPrt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OaGrp>().HasMany<OaPrt>(c => c.OaPrts).WithRequired(t => t.OaGrp).HasForeignKey(u => new {u.OaGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaGrp>().ToTable("GRP_OA","OA");
            modelBuilder.Entity<OaGrp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaGrp>().Property(item => item.IdGrp).IsRequired();
            modelBuilder.Entity<OaGrp>().Property(item => item.IdGrp).HasColumnName("ID_GRP");
            modelBuilder.Entity<OaGrp>().Property(item => item.Libg).IsRequired();
            modelBuilder.Entity<OaGrp>().Property(item => item.Libg).HasMaxLength(500);
            modelBuilder.Entity<OaGrp>().Property(item => item.Libg).HasColumnName("LIBG");
            modelBuilder.Entity<OaGrp>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OaGrp>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OaInsp>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaInsps).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasOptional<OaCdMeteo>(c => c.OaCdMeteo).WithMany(t => t.OaInsps).HasForeignKey(u => new {u.OaCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasOptional<OaCdEtude>(c => c.OaCdEtude).WithMany(t => t.OaInsps).HasForeignKey(u => new {u.OaCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasRequired<OaCdIqoa>(c => c.OaCdIqoa).WithMany(t => t.OaInsps).HasForeignKey(u => new { u.OaCdIqoaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasRequired<OaCamp>(c => c.OaCamp).WithMany(t => t.OaInsps).HasForeignKey(u => new { u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasOptional<OaInspecteur>(c => c.OaInspecteur).WithMany(t => t.OaInsps).HasForeignKey(u => new {u.OaInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasMany<OaEltInsp>(c => c.OaEltInsps).WithRequired(t => t.OaInsp).HasForeignKey(u => new {u.OaInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasMany<OaPhotoInsp>(c => c.OaPhotoInsps).WithRequired(t => t.OaInsp).HasForeignKey(u => new {u.OaInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().HasMany<OaCdConclusionInsp>(c => c.OaCdConclusionInsps).WithRequired(t => t.OaInsp).HasForeignKey(u => new {u.OaInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInsp>().ToTable("INSP_OA","OA");
            modelBuilder.Entity<OaInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaInsp>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaInsp>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaInsp>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaInsp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaInsp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaInsp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaInsp>().Property(item => item.CdMeteoOaMeteo).HasMaxLength(60);
            modelBuilder.Entity<OaInsp>().Property(item => item.CdMeteoOaMeteo).HasColumnName("CD_METEO_OA__METEO");
            modelBuilder.Entity<OaInsp>().Property(item => item.CdIqoaOaNoteIqoa).IsRequired();
            modelBuilder.Entity<OaInsp>().Property(item => item.CdIqoaOaNoteIqoa).HasMaxLength(3);
            modelBuilder.Entity<OaInsp>().Property(item => item.CdIqoaOaNoteIqoa).HasColumnName("CD_IQOA_OA__NOTE_IQOA");
            modelBuilder.Entity<OaInsp>().Property(item => item.InspecteurOaNom).HasMaxLength(60);
            modelBuilder.Entity<OaInsp>().Property(item => item.InspecteurOaNom).HasColumnName("INSPECTEUR_OA__NOM");
            modelBuilder.Entity<OaInsp>().Property(item => item.CdEtudeOaEtude).HasMaxLength(60);
            modelBuilder.Entity<OaInsp>().Property(item => item.CdEtudeOaEtude).HasColumnName("CD_ETUDE_OA__ETUDE");
            modelBuilder.Entity<OaInsp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<OaInsp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<OaInsp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<OaInsp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<OaInsp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<OaInsp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<OaInsp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<OaInsp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<OaInsp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<OaInsp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<OaInsp>().Property(item => item.NomValid).HasMaxLength(255);
            modelBuilder.Entity<OaInsp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<OaInsp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OaInsp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OaInsp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<OaInsp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OaInsp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<OaInsp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<OaInsp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OaInsp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OaInsp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OaInsp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OaInsp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OaInsp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<OaInsp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<OaEltInsp>().HasRequired<OaInsp>(c => c.OaInsp).WithMany(t => t.OaEltInsps).HasForeignKey(u => new { u.OaInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEltInsp>().HasRequired<OaElt>(c => c.OaElt).WithMany(t => t.OaEltInsps).HasForeignKey(u => new { u.OaEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEltInsp>().HasMany<OaPhotoEltInsp>(c => c.OaPhotoEltInsps).WithRequired(t => t.OaEltInsp).HasForeignKey(u => new {u.OaEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEltInsp>().ToTable("ELT_INSP_OA","OA");
            modelBuilder.Entity<OaEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaEltInsp>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaEltInsp>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaEltInsp>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaEltInsp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaEltInsp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaEltInsp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaEltInsp>().Property(item => item.GrpOaIdGrp).IsRequired();
            modelBuilder.Entity<OaEltInsp>().Property(item => item.GrpOaIdGrp).HasColumnName("GRP_OA__ID_GRP");
            modelBuilder.Entity<OaEltInsp>().Property(item => item.PrtOaIdPrt).IsRequired();
            modelBuilder.Entity<OaEltInsp>().Property(item => item.PrtOaIdPrt).HasColumnName("PRT_OA__ID_PRT");
            modelBuilder.Entity<OaEltInsp>().Property(item => item.SprtOaIdSprt).IsRequired();
            modelBuilder.Entity<OaEltInsp>().Property(item => item.SprtOaIdSprt).HasColumnName("SPRT_OA__ID_SPRT");
            modelBuilder.Entity<OaEltInsp>().Property(item => item.EltOaIdElem).IsRequired();
            modelBuilder.Entity<OaEltInsp>().Property(item => item.EltOaIdElem).HasColumnName("ELT_OA__ID_ELEM");
            modelBuilder.Entity<OaEltInsp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<OaEltInsp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OaEltInsp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<OaEltInsp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<OaPhotoEltInsp>().HasRequired<OaEltInsp>(c => c.OaEltInsp).WithMany(t => t.OaPhotoEltInsps).HasForeignKey(u => new { u.OaEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPhotoEltInsp>().ToTable("PHOTO_ELT_INSP_OA","OA");
            modelBuilder.Entity<OaPhotoEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.GrpOaIdGrp).IsRequired();
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.GrpOaIdGrp).HasColumnName("GRP_OA__ID_GRP");
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.PrtOaIdPrt).IsRequired();
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.PrtOaIdPrt).HasColumnName("PRT_OA__ID_PRT");
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.SprtOaIdSprt).IsRequired();
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.SprtOaIdSprt).HasColumnName("SPRT_OA__ID_SPRT");
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.EltOaIdElem).IsRequired();
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.EltOaIdElem).HasColumnName("ELT_OA__ID_ELEM");
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoEltInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaCamp>().HasRequired<OaCdPresta>(c => c.OaCdPresta).WithMany(t => t.OaCamps).HasForeignKey(u => new { u.OaCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCamp>().HasRequired<OaCdTypePv>(c => c.OaCdTypePv).WithMany(t => t.OaCamps).HasForeignKey(u => new { u.OaCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCamp>().HasMany<OaVst>(c => c.OaVsts).WithRequired(t => t.OaCamp).HasForeignKey(u => new {u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCamp>().HasMany<OaInsp>(c => c.OaInsps).WithRequired(t => t.OaCamp).HasForeignKey(u => new {u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCamp>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithRequired(t => t.OaCamp).HasForeignKey(u => new {u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCamp>().HasMany<OaDscCamp>(c => c.OaDscCamps).WithRequired(t => t.OaCamp).HasForeignKey(u => new {u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCamp>().ToTable("CAMP_OA","OA");
            modelBuilder.Entity<OaCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCamp>().Property(item => item.IdCamp).IsRequired();
            modelBuilder.Entity<OaCamp>().Property(item => item.IdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaCamp>().Property(item => item.IdCamp).HasColumnName("ID_CAMP");
            modelBuilder.Entity<OaCamp>().Property(item => item.CdTypePvOaCode).IsRequired();
            modelBuilder.Entity<OaCamp>().Property(item => item.CdTypePvOaCode).HasMaxLength(15);
            modelBuilder.Entity<OaCamp>().Property(item => item.CdTypePvOaCode).HasColumnName("CD_TYPE_PV_OA__CODE");
            modelBuilder.Entity<OaCamp>().Property(item => item.CdPrestaOaPrestataire).IsRequired();
            modelBuilder.Entity<OaCamp>().Property(item => item.CdPrestaOaPrestataire).HasMaxLength(50);
            modelBuilder.Entity<OaCamp>().Property(item => item.CdPrestaOaPrestataire).HasColumnName("CD_PRESTA_OA__PRESTATAIRE");
            modelBuilder.Entity<OaCamp>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<OaCamp>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<OaCamp>().Property(item => item.Dater).IsRequired();
            modelBuilder.Entity<OaCamp>().Property(item => item.Dater).HasColumnName("DATER");
            modelBuilder.Entity<OaCamp>().Property(item => item.Dateg).HasColumnName("DATEG");
            modelBuilder.Entity<OaCamp>().Property(item => item.Userg).HasMaxLength(255);
            modelBuilder.Entity<OaCamp>().Property(item => item.Userg).HasColumnName("USERG");
            modelBuilder.Entity<OaCamp>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<OaCamp>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<OaCdMeteo>().HasMany<OaInsp>(c => c.OaInsps).WithOptional(t => t.OaCdMeteo).HasForeignKey(u => new {u.OaCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdMeteo>().HasMany<OaInspTmp>(c => c.OaInspTmps).WithOptional(t => t.OaCdMeteo).HasForeignKey(u => new {u.OaCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdMeteo>().ToTable("CD_METEO_OA","OA");
            modelBuilder.Entity<OaCdMeteo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdMeteo>().Property(item => item.Meteo).IsRequired();
            modelBuilder.Entity<OaCdMeteo>().Property(item => item.Meteo).HasMaxLength(60);
            modelBuilder.Entity<OaCdMeteo>().Property(item => item.Meteo).HasColumnName("METEO");
            modelBuilder.Entity<OaCdPresta>().HasMany<OaCamp>(c => c.OaCamps).WithRequired(t => t.OaCdPresta).HasForeignKey(u => new {u.OaCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdPresta>().HasMany<OaInspecteur>(c => c.OaInspecteurs).WithRequired(t => t.OaCdPresta).HasForeignKey(u => new {u.OaCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdPresta>().ToTable("CD_PRESTA_OA","OA");
            modelBuilder.Entity<OaCdPresta>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdPresta>().Property(item => item.Prestataire).IsRequired();
            modelBuilder.Entity<OaCdPresta>().Property(item => item.Prestataire).HasMaxLength(50);
            modelBuilder.Entity<OaCdPresta>().Property(item => item.Prestataire).HasColumnName("PRESTATAIRE");
            modelBuilder.Entity<OaTravaux>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaTravauxs).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTravaux>().HasRequired<OaNatureTrav>(c => c.OaNatureTrav).WithMany(t => t.OaTravauxs).HasForeignKey(u => new { u.OaNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTravaux>().HasOptional<OaCdEntp>(c => c.OaCdEntp).WithMany(t => t.OaTravauxs).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaTravaux>().ToTable("TRAVAUX_OA","OA");
            modelBuilder.Entity<OaTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaTravaux>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaTravaux>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaTravaux>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaTravaux>().Property(item => item.CdTravauxOaCode).IsRequired();
            modelBuilder.Entity<OaTravaux>().Property(item => item.CdTravauxOaCode).HasMaxLength(60);
            modelBuilder.Entity<OaTravaux>().Property(item => item.CdTravauxOaCode).HasColumnName("CD_TRAVAUX_OA__CODE");
            modelBuilder.Entity<OaTravaux>().Property(item => item.NatureTravOaNature).IsRequired();
            modelBuilder.Entity<OaTravaux>().Property(item => item.NatureTravOaNature).HasMaxLength(100);
            modelBuilder.Entity<OaTravaux>().Property(item => item.NatureTravOaNature).HasColumnName("NATURE_TRAV_OA__NATURE");
            modelBuilder.Entity<OaTravaux>().Property(item => item.DateRcp).IsRequired();
            modelBuilder.Entity<OaTravaux>().Property(item => item.DateRcp).HasColumnName("DATE_RCP");
            modelBuilder.Entity<OaTravaux>().Property(item => item.CdEntpOaEntreprise).HasMaxLength(60);
            modelBuilder.Entity<OaTravaux>().Property(item => item.CdEntpOaEntreprise).HasColumnName("CD_ENTP_OA__ENTREPRISE");
            modelBuilder.Entity<OaTravaux>().Property(item => item.DateFinGar).HasColumnName("DATE_FIN_GAR");
            modelBuilder.Entity<OaTravaux>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<OaTravaux>().Property(item => item.Marche).HasMaxLength(25);
            modelBuilder.Entity<OaTravaux>().Property(item => item.Marche).HasColumnName("MARCHE");
            modelBuilder.Entity<OaTravaux>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<OaTravaux>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaNatureTrav>().HasRequired<OaCdTravaux>(c => c.OaCdTravaux).WithMany(t => t.OaNatureTravs).HasForeignKey(u => new { u.OaCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaNatureTrav>().HasMany<OaTravaux>(c => c.OaTravauxs).WithRequired(t => t.OaNatureTrav).HasForeignKey(u => new {u.OaNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaNatureTrav>().ToTable("NATURE_TRAV_OA","OA");
            modelBuilder.Entity<OaNatureTrav>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaNatureTrav>().Property(item => item.CdTravauxOaCode).IsRequired();
            modelBuilder.Entity<OaNatureTrav>().Property(item => item.CdTravauxOaCode).HasMaxLength(60);
            modelBuilder.Entity<OaNatureTrav>().Property(item => item.CdTravauxOaCode).HasColumnName("CD_TRAVAUX_OA__CODE");
            modelBuilder.Entity<OaNatureTrav>().Property(item => item.Nature).IsRequired();
            modelBuilder.Entity<OaNatureTrav>().Property(item => item.Nature).HasMaxLength(100);
            modelBuilder.Entity<OaNatureTrav>().Property(item => item.Nature).HasColumnName("NATURE");
            modelBuilder.Entity<OaCdIqoa>().HasMany<OaInsp>(c => c.OaInsps).WithRequired(t => t.OaCdIqoa).HasForeignKey(u => new {u.OaCdIqoaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdIqoa>().HasMany<OaCdQualite>(c => c.OaCdQualites).WithRequired(t => t.OaCdIqoa).HasForeignKey(u => new {u.OaCdIqoaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdIqoa>().HasMany<OaInspTmp>(c => c.OaInspTmps).WithRequired(t => t.OaCdIqoa).HasForeignKey(u => new {u.OaCdIqoaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdIqoa>().ToTable("CD_IQOA_OA","OA");
            modelBuilder.Entity<OaCdIqoa>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdIqoa>().Property(item => item.NoteIqoa).IsRequired();
            modelBuilder.Entity<OaCdIqoa>().Property(item => item.NoteIqoa).HasMaxLength(3);
            modelBuilder.Entity<OaCdIqoa>().Property(item => item.NoteIqoa).HasColumnName("NOTE_IQOA");
            modelBuilder.Entity<OaCdIqoa>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<OaCdIqoa>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaCdMo>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdMo).HasForeignKey(u => new {u.OaCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdMo>().HasMany<OaDscTemp>(c => c.OaDscTemps).WithOptional(t => t.OaCdMo).HasForeignKey(u => new {u.OaCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdMo>().ToTable("CD_MO_OA","OA");
            modelBuilder.Entity<OaCdMo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdMo>().Property(item => item.MaitreOuvr).IsRequired();
            modelBuilder.Entity<OaCdMo>().Property(item => item.MaitreOuvr).HasMaxLength(60);
            modelBuilder.Entity<OaCdMo>().Property(item => item.MaitreOuvr).HasColumnName("MAITRE_OUVR");
            modelBuilder.Entity<OaBpu>().HasRequired<OaCdTravaux>(c => c.OaCdTravaux).WithMany(t => t.OaBpus).HasForeignKey(u => new { u.OaCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaBpu>().HasOptional<OaCdUnite>(c => c.OaCdUnite).WithMany(t => t.OaBpus).HasForeignKey(u => new {u.OaCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaBpu>().HasMany<OaPrevision>(c => c.OaPrevisions).WithRequired(t => t.OaBpu).HasForeignKey(u => new {u.OaBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaBpu>().HasMany<OaCdPrecoSprtVst>(c => c.OaCdPrecoSprtVsts).WithRequired(t => t.OaBpu).HasForeignKey(u => new {u.OaBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaBpu>().ToTable("BPU_OA","OA");
            modelBuilder.Entity<OaBpu>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaBpu>().Property(item => item.IdBpu).IsRequired();
            modelBuilder.Entity<OaBpu>().Property(item => item.IdBpu).HasColumnName("ID_BPU");
            modelBuilder.Entity<OaBpu>().Property(item => item.CdTravauxOaCode).IsRequired();
            modelBuilder.Entity<OaBpu>().Property(item => item.CdTravauxOaCode).HasMaxLength(60);
            modelBuilder.Entity<OaBpu>().Property(item => item.CdTravauxOaCode).HasColumnName("CD_TRAVAUX_OA__CODE");
            modelBuilder.Entity<OaBpu>().Property(item => item.CdUniteOaUnite).HasMaxLength(12);
            modelBuilder.Entity<OaBpu>().Property(item => item.CdUniteOaUnite).HasColumnName("CD_UNITE_OA__UNITE");
            modelBuilder.Entity<OaBpu>().Property(item => item.Techn).IsRequired();
            modelBuilder.Entity<OaBpu>().Property(item => item.Techn).HasMaxLength(255);
            modelBuilder.Entity<OaBpu>().Property(item => item.Techn).HasColumnName("TECHN");
            modelBuilder.Entity<OaBpu>().Property(item => item.Prix).IsRequired();
            modelBuilder.Entity<OaBpu>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<OaBpu>().Property(item => item.DateMaj).HasColumnName("DATE_MAJ");
            modelBuilder.Entity<OaBpu>().Property(item => item.Freq).HasColumnName("FREQ");
            modelBuilder.Entity<OaBpu>().Property(item => item.PrecoVstValueInt).HasColumnName("PRECO_VST");
            modelBuilder.Entity<OaBpu>().Ignore(item => item.PrecoVst);
            modelBuilder.Entity<OaBpu>().Property(item => item.RealisVstValueInt).HasColumnName("REALIS_VST");
            modelBuilder.Entity<OaBpu>().Ignore(item => item.RealisVst);
            modelBuilder.Entity<OaCdTravaux>().HasMany<OaBpu>(c => c.OaBpus).WithRequired(t => t.OaCdTravaux).HasForeignKey(u => new {u.OaCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdTravaux>().HasMany<OaNatureTrav>(c => c.OaNatureTravs).WithRequired(t => t.OaCdTravaux).HasForeignKey(u => new {u.OaCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdTravaux>().ToTable("CD_TRAVAUX_OA","OA");
            modelBuilder.Entity<OaCdTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdTravaux>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<OaCdTravaux>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<OaCdTravaux>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<OaCdTech>().HasMany<OaTablier>(c => c.OaTabliers).WithOptional(t => t.OaCdTech).HasForeignKey(u => new {u.OaCdTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdTech>().ToTable("CD_TECH_OA","OA");
            modelBuilder.Entity<OaCdTech>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdTech>().Property(item => item.Technique).IsRequired();
            modelBuilder.Entity<OaCdTech>().Property(item => item.Technique).HasMaxLength(12);
            modelBuilder.Entity<OaCdTech>().Property(item => item.Technique).HasColumnName("TECHNIQUE");
            modelBuilder.Entity<OaCdTech>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OaCdTech>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdTech>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<OaCdTech>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<OaCdOrigin>().HasMany<OaHistoNote>(c => c.OaHistoNotes).WithRequired(t => t.OaCdOrigin).HasForeignKey(u => new {u.OaCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdOrigin>().ToTable("CD_ORIGIN_OA","OA");
            modelBuilder.Entity<OaCdOrigin>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdOrigin>().Property(item => item.Origine).IsRequired();
            modelBuilder.Entity<OaCdOrigin>().Property(item => item.Origine).HasMaxLength(20);
            modelBuilder.Entity<OaCdOrigin>().Property(item => item.Origine).HasColumnName("ORIGINE");
            modelBuilder.Entity<OaHistoNote>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaHistoNotes).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaHistoNote>().HasRequired<OaCdOrigin>(c => c.OaCdOrigin).WithMany(t => t.OaHistoNotes).HasForeignKey(u => new { u.OaCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaHistoNote>().ToTable("HISTO_NOTE_OA","OA");
            modelBuilder.Entity<OaHistoNote>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaHistoNote>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaHistoNote>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaHistoNote>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.DateNote).IsRequired();
            modelBuilder.Entity<OaHistoNote>().Property(item => item.DateNote).HasColumnName("DATE_NOTE");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.CdOriginOaOrigine).IsRequired();
            modelBuilder.Entity<OaHistoNote>().Property(item => item.CdOriginOaOrigine).HasMaxLength(20);
            modelBuilder.Entity<OaHistoNote>().Property(item => item.CdOriginOaOrigine).HasColumnName("CD_ORIGIN_OA__ORIGINE");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.NoteIqoa).HasMaxLength(3);
            modelBuilder.Entity<OaHistoNote>().Property(item => item.NoteIqoa).HasColumnName("NOTE_IQOA");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OaHistoNote>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OaHistoNote>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<OaHistoNote>().Ignore(item => item.Securite);
            modelBuilder.Entity<OaHistoNote>().Property(item => item.PrioritaireValueInt).IsRequired();
            modelBuilder.Entity<OaHistoNote>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OaHistoNote>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OaCdEvt>().HasMany<OaEvt>(c => c.OaEvts).WithRequired(t => t.OaCdEvt).HasForeignKey(u => new {u.OaCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEvt>().ToTable("CD_EVT_OA","OA");
            modelBuilder.Entity<OaCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OaCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<OaCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OaCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<OaCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<OaEvt>().HasRequired<OaCdEvt>(c => c.OaCdEvt).WithMany(t => t.OaEvts).HasForeignKey(u => new { u.OaCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEvt>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaEvts).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEvt>().ToTable("EVT_OA","OA");
            modelBuilder.Entity<OaEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaEvt>().Property(item => item.CdEvtOaType).IsRequired();
            modelBuilder.Entity<OaEvt>().Property(item => item.CdEvtOaType).HasMaxLength(25);
            modelBuilder.Entity<OaEvt>().Property(item => item.CdEvtOaType).HasColumnName("CD_EVT_OA__TYPE");
            modelBuilder.Entity<OaEvt>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaEvt>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaEvt>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<OaEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<OaEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<OaEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<OaEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<OaPrevision>().HasOptional<OaCdContrainte>(c => c.OaCdContrainte).WithMany(t => t.OaPrevisions).HasForeignKey(u => new {u.OaCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPrevision>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaPrevisions).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPrevision>().HasRequired<OaBpu>(c => c.OaBpu).WithMany(t => t.OaPrevisions).HasForeignKey(u => new { u.OaBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPrevision>().ToTable("PREVISION_OA","OA");
            modelBuilder.Entity<OaPrevision>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPrevision>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaPrevision>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaPrevision>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaPrevision>().Property(item => item.BpuOaIdBpu).IsRequired();
            modelBuilder.Entity<OaPrevision>().Property(item => item.BpuOaIdBpu).HasColumnName("BPU_OA__ID_BPU");
            modelBuilder.Entity<OaPrevision>().Property(item => item.DateDebut).IsRequired();
            modelBuilder.Entity<OaPrevision>().Property(item => item.DateDebut).HasColumnName("DATE_DEBUT");
            modelBuilder.Entity<OaPrevision>().Property(item => item.CdContrainteOaType).HasMaxLength(100);
            modelBuilder.Entity<OaPrevision>().Property(item => item.CdContrainteOaType).HasColumnName("CD_CONTRAINTE_OA__TYPE");
            modelBuilder.Entity<OaPrevision>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<OaPrevision>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<OaPrevision>().Property(item => item.DateDemPub).HasColumnName("DATE_DEM_PUB");
            modelBuilder.Entity<OaPrevision>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<OaPrevision>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaPrevision>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<OaPrevision>().Ignore(item => item.Realise);
            modelBuilder.Entity<OaCdContrainte>().HasMany<OaPrevision>(c => c.OaPrevisions).WithOptional(t => t.OaCdContrainte).HasForeignKey(u => new {u.OaCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdContrainte>().ToTable("CD_CONTRAINTE_OA","OA");
            modelBuilder.Entity<OaCdContrainte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdContrainte>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OaCdContrainte>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<OaCdContrainte>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OaSeuilUrgence>().ToTable("SEUIL_URGENCE_OA","OA");
            modelBuilder.Entity<OaSeuilUrgence>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaSeuilUrgence>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OaSeuilUrgence>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OaSeuilUrgence>().Property(item => item.NbrNote).HasColumnName("NBR_NOTE");
            modelBuilder.Entity<OaSeuilUrgence>().Property(item => item.ValNote).HasColumnName("VAL_NOTE");
            modelBuilder.Entity<OaSeuilUrgence>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OaDictionnaire>().ToTable("DICTIONNAIRE_OA","OA");
            modelBuilder.Entity<OaDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Definition).HasMaxLength(1000);
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Definition).HasColumnName("DEFINITION");
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<OaDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<OaPhotoInsp>().HasRequired<OaInsp>(c => c.OaInsp).WithMany(t => t.OaPhotoInsps).HasForeignKey(u => new { u.OaInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPhotoInsp>().ToTable("PHOTO_INSP_OA","OA");
            modelBuilder.Entity<OaPhotoInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaCdEtude>().HasMany<OaInsp>(c => c.OaInsps).WithOptional(t => t.OaCdEtude).HasForeignKey(u => new {u.OaCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEtude>().HasMany<OaInspTmp>(c => c.OaInspTmps).WithOptional(t => t.OaCdEtude).HasForeignKey(u => new {u.OaCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEtude>().ToTable("CD_ETUDE_OA","OA");
            modelBuilder.Entity<OaCdEtude>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdEtude>().Property(item => item.Etude).IsRequired();
            modelBuilder.Entity<OaCdEtude>().Property(item => item.Etude).HasMaxLength(60);
            modelBuilder.Entity<OaCdEtude>().Property(item => item.Etude).HasColumnName("ETUDE");
            modelBuilder.Entity<OaCdTypePv>().HasMany<OaCamp>(c => c.OaCamps).WithRequired(t => t.OaCdTypePv).HasForeignKey(u => new {u.OaCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdTypePv>().ToTable("CD_TYPE_PV_OA","OA");
            modelBuilder.Entity<OaCdTypePv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Cycle).HasColumnName("CYCLE");
            modelBuilder.Entity<OaCdTypePv>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<OaCdQualite>().HasRequired<OaCdIqoa>(c => c.OaCdIqoa).WithMany(t => t.OaCdQualites).HasForeignKey(u => new { u.OaCdIqoaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdQualite>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdQualite).HasForeignKey(u => new {u.OaCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdQualite>().ToTable("CD_QUALITE_OA","OA");
            modelBuilder.Entity<OaCdQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdQualite>().Property(item => item.CdIqoaOaNoteIqoa).IsRequired();
            modelBuilder.Entity<OaCdQualite>().Property(item => item.CdIqoaOaNoteIqoa).HasMaxLength(3);
            modelBuilder.Entity<OaCdQualite>().Property(item => item.CdIqoaOaNoteIqoa).HasColumnName("CD_IQOA_OA__NOTE_IQOA");
            modelBuilder.Entity<OaCdQualite>().Property(item => item.Qualite).IsRequired();
            modelBuilder.Entity<OaCdQualite>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<OaCdQualite>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<OaPhotoVst>().HasRequired<OaVst>(c => c.OaVst).WithMany(t => t.OaPhotoVsts).HasForeignKey(u => new { u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPhotoVst>().ToTable("PHOTO_VST_OA","OA");
            modelBuilder.Entity<OaPhotoVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaSprtVst>().HasRequired<OaVst>(c => c.OaVst).WithMany(t => t.OaSprtVsts).HasForeignKey(u => new { u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaSprtVst>().HasRequired<OaCdLigne>(c => c.OaCdLigne).WithMany(t => t.OaSprtVsts).HasForeignKey(u => new { u.OaCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaSprtVst>().HasMany<OaPhotoSprtVst>(c => c.OaPhotoSprtVsts).WithRequired(t => t.OaSprtVst).HasForeignKey(u => new {u.OaSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaSprtVst>().ToTable("SPRT_VST_OA","OA");
            modelBuilder.Entity<OaSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaSprtVst>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaSprtVst>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaSprtVst>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaSprtVst>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaSprtVst>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaSprtVst>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaSprtVst>().Property(item => item.CdChapitreOaIdChap).IsRequired();
            modelBuilder.Entity<OaSprtVst>().Property(item => item.CdChapitreOaIdChap).HasColumnName("CD_CHAPITRE_OA__ID_CHAP");
            modelBuilder.Entity<OaSprtVst>().Property(item => item.CdLigneOaIdLigne).IsRequired();
            modelBuilder.Entity<OaSprtVst>().Property(item => item.CdLigneOaIdLigne).HasColumnName("CD_LIGNE_OA__ID_LIGNE");
            modelBuilder.Entity<OaSprtVst>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<OaSprtVst>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OaSprtVst>().Property(item => item.Obs).HasMaxLength(500);
            modelBuilder.Entity<OaSprtVst>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<OaPhotoSprtVst>().HasRequired<OaSprtVst>(c => c.OaSprtVst).WithMany(t => t.OaPhotoSprtVsts).HasForeignKey(u => new { u.OaSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPhotoSprtVst>().ToTable("PHOTO_SPRT_VST_OA","OA");
            modelBuilder.Entity<OaPhotoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.CdChapitreOaIdChap).IsRequired();
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.CdChapitreOaIdChap).HasColumnName("CD_CHAPITRE_OA__ID_CHAP");
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.CdLigneOaIdLigne).IsRequired();
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.CdLigneOaIdLigne).HasColumnName("CD_LIGNE_OA__ID_LIGNE");
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoSprtVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaVst>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaVsts).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaVst>().HasRequired<OaCamp>(c => c.OaCamp).WithMany(t => t.OaVsts).HasForeignKey(u => new { u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaVst>().HasOptional<OaInspecteur>(c => c.OaInspecteur).WithMany(t => t.OaVsts).HasForeignKey(u => new {u.OaInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaVst>().HasMany<OaPhotoVst>(c => c.OaPhotoVsts).WithRequired(t => t.OaVst).HasForeignKey(u => new {u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaVst>().HasMany<OaSprtVst>(c => c.OaSprtVsts).WithRequired(t => t.OaVst).HasForeignKey(u => new {u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaVst>().HasMany<OaEntete>(c => c.OaEntetes).WithRequired(t => t.OaVst).HasForeignKey(u => new {u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaVst>().HasMany<OaCdPrecoSprtVst>(c => c.OaCdPrecoSprtVsts).WithRequired(t => t.OaVst).HasForeignKey(u => new {u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaVst>().ToTable("VST_OA","OA");
            modelBuilder.Entity<OaVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaVst>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaVst>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaVst>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaVst>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaVst>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaVst>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaVst>().Property(item => item.InspecteurOaNom).HasMaxLength(60);
            modelBuilder.Entity<OaVst>().Property(item => item.InspecteurOaNom).HasColumnName("INSPECTEUR_OA__NOM");
            modelBuilder.Entity<OaVst>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<OaVst>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<OaVst>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<OaVst>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<OaVst>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OaVst>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OaVst>().Property(item => item.Observ).HasMaxLength(500);
            modelBuilder.Entity<OaVst>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<OaVst>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<OaVst>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<OaCdHierarchie>().HasMany<OaDsc>(c => c.OaDscs).WithOptional(t => t.OaCdHierarchie).HasForeignKey(u => new {u.OaCdHierarchieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdHierarchie>().ToTable("CD_HIERARCHIE_OA","OA");
            modelBuilder.Entity<OaCdHierarchie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdHierarchie>().Property(item => item.Hierarchie).IsRequired();
            modelBuilder.Entity<OaCdHierarchie>().Property(item => item.Hierarchie).HasMaxLength(60);
            modelBuilder.Entity<OaCdHierarchie>().Property(item => item.Hierarchie).HasColumnName("HIERARCHIE");
            modelBuilder.Entity<OaCdEntete>().HasRequired<OaCdComposant>(c => c.OaCdComposant).WithMany(t => t.OaCdEntetes).HasForeignKey(u => new { u.OaCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEntete>().HasMany<OaEntete>(c => c.OaEntetes).WithRequired(t => t.OaCdEntete).HasForeignKey(u => new {u.OaCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdEntete>().ToTable("CD_ENTETE_OA","OA");
            modelBuilder.Entity<OaCdEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdEntete>().Property(item => item.IdEntete).IsRequired();
            modelBuilder.Entity<OaCdEntete>().Property(item => item.IdEntete).HasColumnName("ID_ENTETE");
            modelBuilder.Entity<OaCdEntete>().Property(item => item.CdComposantOaTypeComp).IsRequired();
            modelBuilder.Entity<OaCdEntete>().Property(item => item.CdComposantOaTypeComp).HasMaxLength(6);
            modelBuilder.Entity<OaCdEntete>().Property(item => item.CdComposantOaTypeComp).HasColumnName("CD_COMPOSANT_OA__TYPE_COMP");
            modelBuilder.Entity<OaCdEntete>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OaCdEntete>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OaCdEntete>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdEntete>().Property(item => item.OrdreEnt).IsRequired();
            modelBuilder.Entity<OaCdEntete>().Property(item => item.OrdreEnt).HasColumnName("ORDRE_ENT");
            modelBuilder.Entity<OaCdEntete>().Property(item => item.Guide).HasMaxLength(500);
            modelBuilder.Entity<OaCdEntete>().Property(item => item.Guide).HasColumnName("GUIDE");
            modelBuilder.Entity<OaCdChapitre>().HasMany<OaCdLigne>(c => c.OaCdLignes).WithRequired(t => t.OaCdChapitre).HasForeignKey(u => new {u.OaCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdChapitre>().ToTable("CD_CHAPITRE_OA","OA");
            modelBuilder.Entity<OaCdChapitre>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.IdChap).IsRequired();
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.IdChap).HasColumnName("ID_CHAP");
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.OrdreChap).IsRequired();
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.OrdreChap).HasColumnName("ORDRE_CHAP");
            modelBuilder.Entity<OaCdChapitre>().Property(item => item.Ponderation).HasColumnName("PONDERATION");
            modelBuilder.Entity<OaCdLigne>().HasRequired<OaCdChapitre>(c => c.OaCdChapitre).WithMany(t => t.OaCdLignes).HasForeignKey(u => new { u.OaCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdLigne>().HasMany<OaSprtVst>(c => c.OaSprtVsts).WithRequired(t => t.OaCdLigne).HasForeignKey(u => new {u.OaCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdLigne>().ToTable("CD_LIGNE_OA","OA");
            modelBuilder.Entity<OaCdLigne>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdLigne>().Property(item => item.CdChapitreOaIdChap).IsRequired();
            modelBuilder.Entity<OaCdLigne>().Property(item => item.CdChapitreOaIdChap).HasColumnName("CD_CHAPITRE_OA__ID_CHAP");
            modelBuilder.Entity<OaCdLigne>().Property(item => item.IdLigne).IsRequired();
            modelBuilder.Entity<OaCdLigne>().Property(item => item.IdLigne).HasColumnName("ID_LIGNE");
            modelBuilder.Entity<OaCdLigne>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OaCdLigne>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OaCdLigne>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdLigne>().Property(item => item.OrdreLigne).IsRequired();
            modelBuilder.Entity<OaCdLigne>().Property(item => item.OrdreLigne).HasColumnName("ORDRE_LIGNE");
            modelBuilder.Entity<OaEntete>().HasRequired<OaCdEntete>(c => c.OaCdEntete).WithMany(t => t.OaEntetes).HasForeignKey(u => new { u.OaCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEntete>().HasRequired<OaVst>(c => c.OaVst).WithMany(t => t.OaEntetes).HasForeignKey(u => new { u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEntete>().ToTable("ENTETE_OA","OA");
            modelBuilder.Entity<OaEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaEntete>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaEntete>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaEntete>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaEntete>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaEntete>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaEntete>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaEntete>().Property(item => item.CdEnteteOaIdEntete).IsRequired();
            modelBuilder.Entity<OaEntete>().Property(item => item.CdEnteteOaIdEntete).HasColumnName("CD_ENTETE_OA__ID_ENTETE");
            modelBuilder.Entity<OaEntete>().Property(item => item.Valeur).HasMaxLength(250);
            modelBuilder.Entity<OaEntete>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<OaContact>().HasRequired<OaDoc>(c => c.OaDoc).WithMany(t => t.OaContacts).HasForeignKey(u => new { u.OaDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaContact>().ToTable("CONTACT_OA","OA");
            modelBuilder.Entity<OaContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaContact>().Property(item => item.DocOaId).IsRequired();
            modelBuilder.Entity<OaContact>().Property(item => item.DocOaId).HasColumnName("DOC_OA__ID");
            modelBuilder.Entity<OaContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<OaContact>().Property(item => item.Givenname).HasColumnName("GIVENNAME");
            modelBuilder.Entity<OaContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<OaContact>().Property(item => item.Sn).HasColumnName("SN");
            modelBuilder.Entity<OaContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<OaContact>().Property(item => item.Cn).HasColumnName("CN");
            modelBuilder.Entity<OaContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<OaContact>().Property(item => item.O).HasColumnName("O");
            modelBuilder.Entity<OaContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<OaContact>().Property(item => item.Mail).HasColumnName("MAIL");
            modelBuilder.Entity<OaContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<OaContact>().Property(item => item.Telephonenumber).HasColumnName("TELEPHONENUMBER");
            modelBuilder.Entity<OaContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<OaContact>().Property(item => item.Mobile).HasColumnName("MOBILE");
            modelBuilder.Entity<OaContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<OaContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("FACSIMILETELEPHONENUMBER");
            modelBuilder.Entity<OaContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<OaContact>().Property(item => item.Street).HasColumnName("STREET");
            modelBuilder.Entity<OaContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<OaContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("MOZILLAWORKSTREET2");
            modelBuilder.Entity<OaContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<OaContact>().Property(item => item.L).HasColumnName("L");
            modelBuilder.Entity<OaContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<OaContact>().Property(item => item.Postalcode).HasColumnName("POSTALCODE");
            modelBuilder.Entity<OaContact>().Property(item => item.Modifytimestamp).HasColumnName("MODIFYTIMESTAMP");
            modelBuilder.Entity<OaInspecteur>().HasRequired<OaCdPresta>(c => c.OaCdPresta).WithMany(t => t.OaInspecteurs).HasForeignKey(u => new { u.OaCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspecteur>().HasMany<OaInsp>(c => c.OaInsps).WithOptional(t => t.OaInspecteur).HasForeignKey(u => new {u.OaInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspecteur>().HasMany<OaVst>(c => c.OaVsts).WithOptional(t => t.OaInspecteur).HasForeignKey(u => new {u.OaInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspecteur>().HasMany<OaInspTmp>(c => c.OaInspTmps).WithOptional(t => t.OaInspecteur).HasForeignKey(u => new {u.OaInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspecteur>().ToTable("INSPECTEUR_OA","OA");
            modelBuilder.Entity<OaInspecteur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaInspecteur>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<OaInspecteur>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<OaInspecteur>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<OaInspecteur>().Property(item => item.CdPrestaOaPrestataire).IsRequired();
            modelBuilder.Entity<OaInspecteur>().Property(item => item.CdPrestaOaPrestataire).HasMaxLength(50);
            modelBuilder.Entity<OaInspecteur>().Property(item => item.CdPrestaOaPrestataire).HasColumnName("CD_PRESTA_OA__PRESTATAIRE");
            modelBuilder.Entity<OaInspecteur>().Property(item => item.Fonc).HasMaxLength(60);
            modelBuilder.Entity<OaInspecteur>().Property(item => item.Fonc).HasColumnName("FONC");
            modelBuilder.Entity<OaCdUnite>().HasMany<OaBpu>(c => c.OaBpus).WithOptional(t => t.OaCdUnite).HasForeignKey(u => new {u.OaCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdUnite>().ToTable("CD_UNITE_OA","OA");
            modelBuilder.Entity<OaCdUnite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdUnite>().Property(item => item.Unite).IsRequired();
            modelBuilder.Entity<OaCdUnite>().Property(item => item.Unite).HasMaxLength(12);
            modelBuilder.Entity<OaCdUnite>().Property(item => item.Unite).HasColumnName("UNITE");
            modelBuilder.Entity<OaCdComposant>().HasMany<OaCdEntete>(c => c.OaCdEntetes).WithRequired(t => t.OaCdComposant).HasForeignKey(u => new {u.OaCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdComposant>().ToTable("CD_COMPOSANT_OA","OA");
            modelBuilder.Entity<OaCdComposant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdComposant>().Property(item => item.TypeComp).IsRequired();
            modelBuilder.Entity<OaCdComposant>().Property(item => item.TypeComp).HasMaxLength(6);
            modelBuilder.Entity<OaCdComposant>().Property(item => item.TypeComp).HasColumnName("TYPE_COMP");
            modelBuilder.Entity<OaCdComposant>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OaCdComposant>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdConclusion>().HasMany<OaCdConclusionInsp>(c => c.OaCdConclusionInsps).WithRequired(t => t.OaCdConclusion).HasForeignKey(u => new {u.OaCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdConclusion>().HasMany<OaCdConclusionInspTmp>(c => c.OaCdConclusionInspTmps).WithRequired(t => t.OaCdConclusion).HasForeignKey(u => new {u.OaCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdConclusion>().ToTable("CD_CONCLUSION_OA","OA");
            modelBuilder.Entity<OaCdConclusion>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdConclusion>().Property(item => item.IdConc).IsRequired();
            modelBuilder.Entity<OaCdConclusion>().Property(item => item.IdConc).HasColumnName("ID_CONC");
            modelBuilder.Entity<OaCdConclusion>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OaCdConclusion>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OaCdConclusion>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OaCdConclusion>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OaCdConclusion>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdMo>(c => c.OaCdMo).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdEntp>(c => c.OaCdEntp).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdBe>(c => c.OaCdBe).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdBeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdMat>(c => c.OaCdMat).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdCharge>(c => c.OaCdCharge).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdChargeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdGest>(c => c.OaCdGest).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdGestIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdFond>(c => c.OaCdFond).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdFondIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaCdTablier>(c => c.OaCdTablier).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaCdTablierIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasRequired<OaCdFam>(c => c.OaCdFam).WithMany(t => t.OaDscTemps).HasForeignKey(u => new { u.OaCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasRequired<OaCdType>(c => c.OaCdType).WithMany(t => t.OaDscTemps).HasForeignKey(u => new { u.OaCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasRequired<OaCamp>(c => c.OaCamp).WithMany(t => t.OaDscTemps).HasForeignKey(u => new { u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasOptional<OaDsc>(c => c.OaDsc).WithMany(t => t.OaDscTemps).HasForeignKey(u => new {u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().HasMany<OaInspTmp>(c => c.OaInspTmps).WithRequired(t => t.OaDscTemp).HasForeignKey(u => new {u.OaDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscTemp>().ToTable("DSC_TEMP_OA","OA");
            modelBuilder.Entity<OaDscTemp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NumOa).IsRequired();
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NumOa).HasMaxLength(20);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NumOa).HasColumnName("NUM_OA");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdBeOaBureau).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdBeOaBureau).HasColumnName("CD_BE_OA__BUREAU");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdGestOaGestionnaire).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdGestOaGestionnaire).HasColumnName("CD_GEST_OA__GESTIONNAIRE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdChargeOaSurcharge).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdChargeOaSurcharge).HasColumnName("CD_CHARGE_OA__SURCHARGE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdTypeOaType).IsRequired();
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdTypeOaType).HasMaxLength(20);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdTypeOaType).HasColumnName("CD_TYPE_OA__TYPE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdEntpOaEntreprise).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdEntpOaEntreprise).HasColumnName("CD_ENTP_OA__ENTREPRISE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdTablierOaTablier).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdTablierOaTablier).HasColumnName("CD_TABLIER_OA__TABLIER");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdFondOaType).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdFondOaType).HasColumnName("CD_FOND_OA__TYPE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdMatOaMateriaux).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdMatOaMateriaux).HasColumnName("CD_MAT_OA__MATERIAUX");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdMoOaMaitreOuvr).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdMoOaMaitreOuvr).HasColumnName("CD_MO_OA__MAITRE_OUVR");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdFamOaFamille).IsRequired();
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdFamOaFamille).HasMaxLength(20);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CdFamOaFamille).HasColumnName("CD_FAM_OA__FAMILLE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<OaDscTemp>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NomUsage).HasMaxLength(255);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DateConst).HasColumnName("DATE_CONST");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Vpf).HasMaxLength(60);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Vpf).HasColumnName("VPF");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.TraficVpf).HasColumnName("TRAFIC_VPF");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Deviation).HasColumnName("DEVIATION");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Nbpilesinter).HasColumnName("NBPILESINTER");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Travure).HasColumnName("TRAVURE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.LongMaxTrav).HasColumnName("LONG_MAX_TRAV");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.GabMini).HasColumnName("GAB_MINI");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.GabGraValueInt).HasColumnName("GAB_GRA");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.GabGra);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Biais).HasColumnName("BIAIS");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.LongBiaise).HasColumnName("LONG_BIAISE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.LargTrav).HasColumnName("LARG_TRAV");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.LargBiaise).HasColumnName("LARG_BIAISE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.LargGs).HasColumnName("LARG_GS");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.SurfTablier).HasColumnName("SURF_TABLIER");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.SurfVpf).HasColumnName("SURF_VPF");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.ImmergeValueInt).HasColumnName("IMMERGE");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Immerge);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.SismiciteValueInt).HasColumnName("SISMICITE");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Sismicite);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DalleValueInt).HasColumnName("DALLE");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Dalle);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.CornValueInt).HasColumnName("CORN");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Corn);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.LanterneauValueInt).HasColumnName("LANTERNEAU");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Lanterneau);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.EquipVstValueInt).HasColumnName("EQUIP_VST");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.EquipVst);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Securite);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<OaDscTemp>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<OaDscTemp>().Ignore(item => item.Terrain);
            modelBuilder.Entity<OaInspTmp>().HasOptional<OaCdEtude>(c => c.OaCdEtude).WithMany(t => t.OaInspTmps).HasForeignKey(u => new {u.OaCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().HasOptional<OaCdMeteo>(c => c.OaCdMeteo).WithMany(t => t.OaInspTmps).HasForeignKey(u => new {u.OaCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().HasRequired<OaCdIqoa>(c => c.OaCdIqoa).WithMany(t => t.OaInspTmps).HasForeignKey(u => new { u.OaCdIqoaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().HasRequired<OaDscTemp>(c => c.OaDscTemp).WithMany(t => t.OaInspTmps).HasForeignKey(u => new { u.OaDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().HasOptional<OaInspecteur>(c => c.OaInspecteur).WithMany(t => t.OaInspTmps).HasForeignKey(u => new {u.OaInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().HasMany<OaEltInspTmp>(c => c.OaEltInspTmps).WithRequired(t => t.OaInspTmp).HasForeignKey(u => new {u.OaInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().HasMany<OaPhotoInspTmp>(c => c.OaPhotoInspTmps).WithRequired(t => t.OaInspTmp).HasForeignKey(u => new {u.OaInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().HasMany<OaCdConclusionInspTmp>(c => c.OaCdConclusionInspTmps).WithRequired(t => t.OaInspTmp).HasForeignKey(u => new {u.OaInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaInspTmp>().ToTable("INSP_TMP_OA","OA");
            modelBuilder.Entity<OaInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.DscTempOaNumOa).IsRequired();
            modelBuilder.Entity<OaInspTmp>().Property(item => item.DscTempOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.DscTempOaNumOa).HasColumnName("DSC_TEMP_OA__NUM_OA");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CdIqoaOaNoteIqoa).IsRequired();
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CdIqoaOaNoteIqoa).HasMaxLength(3);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CdIqoaOaNoteIqoa).HasColumnName("CD_IQOA_OA__NOTE_IQOA");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CdMeteoOaMeteo).HasMaxLength(60);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CdMeteoOaMeteo).HasColumnName("CD_METEO_OA__METEO");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CdEtudeOaEtude).HasMaxLength(60);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.CdEtudeOaEtude).HasColumnName("CD_ETUDE_OA__ETUDE");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.InspecteurOaNom).HasMaxLength(60);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.InspecteurOaNom).HasColumnName("INSPECTEUR_OA__NOM");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.NomValid).HasMaxLength(255);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<OaInspTmp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<OaEltInspTmp>().HasRequired<OaInspTmp>(c => c.OaInspTmp).WithMany(t => t.OaEltInspTmps).HasForeignKey(u => new { u.OaInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEltInspTmp>().HasRequired<OaElt>(c => c.OaElt).WithMany(t => t.OaEltInspTmps).HasForeignKey(u => new { u.OaEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEltInspTmp>().HasMany<OaPhotoEltInspTmp>(c => c.OaPhotoEltInspTmps).WithRequired(t => t.OaEltInspTmp).HasForeignKey(u => new {u.OaEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaEltInspTmp>().ToTable("ELT_INSP_TMP_OA","OA");
            modelBuilder.Entity<OaEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.DscTempOaNumOa).IsRequired();
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.DscTempOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.DscTempOaNumOa).HasColumnName("DSC_TEMP_OA__NUM_OA");
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.GrpOaIdGrp).IsRequired();
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.GrpOaIdGrp).HasColumnName("GRP_OA__ID_GRP");
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.PrtOaIdPrt).IsRequired();
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.PrtOaIdPrt).HasColumnName("PRT_OA__ID_PRT");
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.SprtOaIdSprt).IsRequired();
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.SprtOaIdSprt).HasColumnName("SPRT_OA__ID_SPRT");
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.EltOaIdElem).IsRequired();
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.EltOaIdElem).HasColumnName("ELT_OA__ID_ELEM");
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<OaEltInspTmp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<OaPhotoInspTmp>().HasRequired<OaInspTmp>(c => c.OaInspTmp).WithMany(t => t.OaPhotoInspTmps).HasForeignKey(u => new { u.OaInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPhotoInspTmp>().ToTable("PHOTO_INSP_TMP_OA","OA");
            modelBuilder.Entity<OaPhotoInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.DscTempOaNumOa).IsRequired();
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.DscTempOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.DscTempOaNumOa).HasColumnName("DSC_TEMP_OA__NUM_OA");
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaPhotoEltInspTmp>().HasRequired<OaEltInspTmp>(c => c.OaEltInspTmp).WithMany(t => t.OaPhotoEltInspTmps).HasForeignKey(u => new { u.OaEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaPhotoEltInspTmp>().ToTable("PHOTO_ELT_INSP_TMP_OA","OA");
            modelBuilder.Entity<OaPhotoEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.GrpOaIdGrp).IsRequired();
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.GrpOaIdGrp).HasColumnName("GRP_OA__ID_GRP");
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.PrtOaIdPrt).IsRequired();
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.PrtOaIdPrt).HasColumnName("PRT_OA__ID_PRT");
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.SprtOaIdSprt).IsRequired();
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.SprtOaIdSprt).HasColumnName("SPRT_OA__ID_SPRT");
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.DscTempOaNumOa).IsRequired();
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.DscTempOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.DscTempOaNumOa).HasColumnName("DSC_TEMP_OA__NUM_OA");
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.EltOaIdElem).IsRequired();
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.EltOaIdElem).HasColumnName("ELT_OA__ID_ELEM");
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OaPhotoEltInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaCdOccupant>().HasMany<OaOccupation>(c => c.OaOccupations).WithRequired(t => t.OaCdOccupant).HasForeignKey(u => new {u.OaCdOccupantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdOccupant>().ToTable("CD_OCCUPANT_OA","OA");
            modelBuilder.Entity<OaCdOccupant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdOccupant>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<OaCdOccupant>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<OaCdOccupant>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<OaOccupation>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaOccupations).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaOccupation>().HasRequired<OaCdOccupant>(c => c.OaCdOccupant).WithMany(t => t.OaOccupations).HasForeignKey(u => new { u.OaCdOccupantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaOccupation>().HasRequired<OaCdOccup>(c => c.OaCdOccup).WithMany(t => t.OaOccupations).HasForeignKey(u => new { u.OaCdOccupIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaOccupation>().ToTable("OCCUPATION_OA","OA");
            modelBuilder.Entity<OaOccupation>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaOccupation>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaOccupation>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaOccupation>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaOccupation>().Property(item => item.CdOccupantOaNom).IsRequired();
            modelBuilder.Entity<OaOccupation>().Property(item => item.CdOccupantOaNom).HasMaxLength(60);
            modelBuilder.Entity<OaOccupation>().Property(item => item.CdOccupantOaNom).HasColumnName("CD_OCCUPANT_OA__NOM");
            modelBuilder.Entity<OaOccupation>().Property(item => item.CdOccupOaType).IsRequired();
            modelBuilder.Entity<OaOccupation>().Property(item => item.CdOccupOaType).HasMaxLength(60);
            modelBuilder.Entity<OaOccupation>().Property(item => item.CdOccupOaType).HasColumnName("CD_OCCUP_OA__TYPE");
            modelBuilder.Entity<OaOccupation>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<OaOccupation>().Property(item => item.DateFv).HasColumnName("DATE_FV");
            modelBuilder.Entity<OaOccupation>().Property(item => item.TravValueInt).HasColumnName("TRAV");
            modelBuilder.Entity<OaOccupation>().Ignore(item => item.Trav);
            modelBuilder.Entity<OaOccupation>().Property(item => item.NumConv).HasMaxLength(60);
            modelBuilder.Entity<OaOccupation>().Property(item => item.NumConv).HasColumnName("NUM_CONV");
            modelBuilder.Entity<OaOccupation>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<OaOccupation>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<OaCdOccup>().HasMany<OaOccupation>(c => c.OaOccupations).WithRequired(t => t.OaCdOccup).HasForeignKey(u => new {u.OaCdOccupIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdOccup>().ToTable("CD_OCCUP_OA","OA");
            modelBuilder.Entity<OaCdOccup>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdOccup>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OaCdOccup>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<OaCdOccup>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OaArchive3>().HasMany<OaDscArchive3>(c => c.OaDscArchive3s).WithRequired(t => t.OaArchive3).HasForeignKey(u => new {u.OaArchive3IdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaArchive3>().ToTable("ARCHIVE_3_OA","OA");
            modelBuilder.Entity<OaArchive3>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaArchive3>().Property(item => item.DateCalc).IsRequired();
            modelBuilder.Entity<OaArchive3>().Property(item => item.DateCalc).HasColumnName("DATE_CALC");
            modelBuilder.Entity<OaArchive3>().Property(item => item.Nbre).IsRequired();
            modelBuilder.Entity<OaArchive3>().Property(item => item.Nbre).HasColumnName("NBRE");
            modelBuilder.Entity<OaArchive3>().Property(item => item.Surf).IsRequired();
            modelBuilder.Entity<OaArchive3>().Property(item => item.Surf).HasColumnName("SURF");
            modelBuilder.Entity<OaArchive3>().Property(item => item.Etat3x).IsRequired();
            modelBuilder.Entity<OaArchive3>().Property(item => item.Etat3x).HasMaxLength(3);
            modelBuilder.Entity<OaArchive3>().Property(item => item.Etat3x).HasColumnName("ETAT_3X");
            modelBuilder.Entity<OaArchive3>().Property(item => item.Delai).HasColumnName("DELAI");
            modelBuilder.Entity<OaArchive3>().Property(item => item.EtatLolf).HasColumnName("ETAT_LOLF");
            modelBuilder.Entity<OaArchive3>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<OaArchive3>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<OaArchive3>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<OaClsDoc>().HasRequired<OaCls>(c => c.OaCls).WithMany(t => t.OaClsDocs).HasForeignKey(u => new { u.OaClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaClsDoc>().HasRequired<OaDoc>(c => c.OaDoc).WithMany(t => t.OaClsDocs).HasForeignKey(u => new { u.OaDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaClsDoc>().ToTable("CLS_DOC_OA","OA");
            modelBuilder.Entity<OaClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaClsDoc>().Property(item => item.ClsOaId).IsRequired();
            modelBuilder.Entity<OaClsDoc>().Property(item => item.ClsOaId).HasColumnName("CLS_OA__ID");
            modelBuilder.Entity<OaClsDoc>().Property(item => item.DocOaId).IsRequired();
            modelBuilder.Entity<OaClsDoc>().Property(item => item.DocOaId).HasColumnName("DOC_OA__ID");
            modelBuilder.Entity<OaClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<OaClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<OaClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<OaClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
            modelBuilder.Entity<OaAppuis>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaAppuiss).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaAppuis>().HasRequired<OaCdFamAppui>(c => c.OaCdFamAppui).WithMany(t => t.OaAppuiss).HasForeignKey(u => new { u.OaCdFamAppuiIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaAppuis>().HasRequired<OaCdAppui>(c => c.OaCdAppui).WithMany(t => t.OaAppuiss).HasForeignKey(u => new { u.OaCdAppuiIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaAppuis>().HasRequired<OaCdAppAppui>(c => c.OaCdAppAppui).WithMany(t => t.OaAppuiss).HasForeignKey(u => new { u.OaCdAppAppuiIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaAppuis>().ToTable("APPUIS_OA","OA");
            modelBuilder.Entity<OaAppuis>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaAppuis>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaAppuis>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaAppuis>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdFamAppuiOaFamApp).IsRequired();
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdFamAppuiOaFamApp).HasMaxLength(60);
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdFamAppuiOaFamApp).HasColumnName("CD_FAM_APPUI_OA__FAM_APP");
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdAppuiOaApp).IsRequired();
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdAppuiOaApp).HasMaxLength(60);
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdAppuiOaApp).HasColumnName("CD_APPUI_OA__APP");
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdAppAppuiOaAppui).IsRequired();
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdAppAppuiOaAppui).HasMaxLength(60);
            modelBuilder.Entity<OaAppuis>().Property(item => item.CdAppAppuiOaAppui).HasColumnName("CD_APP_APPUI_OA__APPUI");
            modelBuilder.Entity<OaAppuis>().Property(item => item.NbrAppareil).HasColumnName("NBR_APPAREIL");
            modelBuilder.Entity<OaAppuis>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<OaAppuis>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<OaAppuis>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OaDscCamp>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaDscCamps).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscCamp>().HasRequired<OaCamp>(c => c.OaCamp).WithMany(t => t.OaDscCamps).HasForeignKey(u => new { u.OaCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscCamp>().ToTable("DSC_CAMP_OA","OA");
            modelBuilder.Entity<OaDscCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaDscCamp>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaDscCamp>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaDscCamp>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaDscCamp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaDscCamp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaDscCamp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaDscCamp>().Property(item => item.RealiserValueInt).HasColumnName("REALISER");
            modelBuilder.Entity<OaDscCamp>().Ignore(item => item.Realiser);
            modelBuilder.Entity<OaCdPrecoSprtVst>().HasRequired<OaVst>(c => c.OaVst).WithMany(t => t.OaCdPrecoSprtVsts).HasForeignKey(u => new { u.OaVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdPrecoSprtVst>().HasRequired<OaBpu>(c => c.OaBpu).WithMany(t => t.OaCdPrecoSprtVsts).HasForeignKey(u => new { u.OaBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdPrecoSprtVst>().ToTable("CD_PRECO__SPRT_VST_OA","OA");
            modelBuilder.Entity<OaCdPrecoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.BpuOaIdBpu).IsRequired();
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.BpuOaIdBpu).HasColumnName("BPU_OA__ID_BPU");
            modelBuilder.Entity<OaCdPrecoSprtVst>().Property(item => item.CdPrecoSprtVstOhRealiseValueInt).HasColumnName("CD_PRECO__SPRT_VST_OH__REALISE");
            modelBuilder.Entity<OaCdPrecoSprtVst>().Ignore(item => item.CdPrecoSprtVstOhRealise);
            modelBuilder.Entity<OaCdConclusionInsp>().HasRequired<OaCdConclusion>(c => c.OaCdConclusion).WithMany(t => t.OaCdConclusionInsps).HasForeignKey(u => new { u.OaCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdConclusionInsp>().HasRequired<OaInsp>(c => c.OaInsp).WithMany(t => t.OaCdConclusionInsps).HasForeignKey(u => new { u.OaInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdConclusionInsp>().ToTable("CD_CONCLUSION__INSP_OA","OA");
            modelBuilder.Entity<OaCdConclusionInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.CdConclusionOaIdConc).IsRequired();
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.CdConclusionOaIdConc).HasColumnName("CD_CONCLUSION_OA__ID_CONC");
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<OaCdConclusionInsp>().Property(item => item.Contenu).HasColumnName("CONTENU");
            modelBuilder.Entity<OaCdConclusionInspTmp>().HasRequired<OaCdConclusion>(c => c.OaCdConclusion).WithMany(t => t.OaCdConclusionInspTmps).HasForeignKey(u => new { u.OaCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdConclusionInspTmp>().HasRequired<OaInspTmp>(c => c.OaInspTmp).WithMany(t => t.OaCdConclusionInspTmps).HasForeignKey(u => new { u.OaInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaCdConclusionInspTmp>().ToTable("CD_CONCLUSION__INSP_TMP_OA","OA");
            modelBuilder.Entity<OaCdConclusionInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.CampOaIdCamp).IsRequired();
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.CampOaIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.CampOaIdCamp).HasColumnName("CAMP_OA__ID_CAMP");
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.DscTempOaNumOa).IsRequired();
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.DscTempOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.DscTempOaNumOa).HasColumnName("DSC_TEMP_OA__NUM_OA");
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.CdConclusionOaIdConc).IsRequired();
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.CdConclusionOaIdConc).HasColumnName("CD_CONCLUSION_OA__ID_CONC");
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<OaCdConclusionInspTmp>().Property(item => item.Contenu).HasColumnName("CONTENU");
            modelBuilder.Entity<OaDscArchive3>().HasRequired<OaArchive3>(c => c.OaArchive3).WithMany(t => t.OaDscArchive3s).HasForeignKey(u => new { u.OaArchive3IdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscArchive3>().HasRequired<OaDsc>(c => c.OaDsc).WithMany(t => t.OaDscArchive3s).HasForeignKey(u => new { u.OaDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OaDscArchive3>().ToTable("DSC__ARCHIVE_3_OA","OA");
            modelBuilder.Entity<OaDscArchive3>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.Archive3OaDateCalc).IsRequired();
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.Archive3OaDateCalc).HasColumnName("ARCHIVE_3_OA__DATE_CALC");
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.DscOaNumOa).IsRequired();
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.DscOaNumOa).HasMaxLength(20);
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.DscOaNumOa).HasColumnName("DSC_OA__NUM_OA");
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.Note3x).IsRequired();
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.Note3x).HasMaxLength(3);
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.Note3x).HasColumnName("NOTE3X");
            modelBuilder.Entity<OaDscArchive3>().Property(item => item.EcarteValueInt).HasColumnName("ECARTE");
            modelBuilder.Entity<OaDscArchive3>().Ignore(item => item.Ecarte);
        }
    }
}
