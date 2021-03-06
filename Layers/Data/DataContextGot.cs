using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextGot : DataContextBase
    {
        public DataContextGot(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<GotCdEntp> GotCdEntps { get; set; }
        
        public DbSet<GotDsc> GotDscs { get; set; }
        
        public DbSet<GotCls> GotClss { get; set; }
        
        public DbSet<GotDoc> GotDocs { get; set; }
        
        public DbSet<GotCdDoc> GotCdDocs { get; set; }
        
        public DbSet<GotElt> GotElts { get; set; }
        
        public DbSet<GotPrt> GotPrts { get; set; }
        
        public DbSet<GotGrp> GotGrps { get; set; }
        
        public DbSet<GotEltInsp> GotEltInsps { get; set; }
        
        public DbSet<GotPhotoEltInsp> GotPhotoEltInsps { get; set; }
        
        public DbSet<GotCamp> GotCamps { get; set; }
        
        public DbSet<GotCdMeteo> GotCdMeteos { get; set; }
        
        public DbSet<GotCdPresta> GotCdPrestas { get; set; }
        
        public DbSet<GotTravaux> GotTravauxs { get; set; }
        
        public DbSet<GotNatureTrav> GotNatureTravs { get; set; }
        
        public DbSet<GotCdTravaux> GotCdTravauxs { get; set; }
        
        public DbSet<GotCdFam> GotCdFams { get; set; }
        
        public DbSet<GotCdPente> GotCdPentes { get; set; }
        
        public DbSet<GotCdProtect> GotCdProtects { get; set; }
        
        public DbSet<GotCdGeo> GotCdGeos { get; set; }
        
        public DbSet<GotCdMateriau> GotCdMateriaus { get; set; }
        
        public DbSet<GotCdHydrique> GotCdHydriques { get; set; }
        
        public DbSet<GotCdTraitement> GotCdTraitements { get; set; }
        
        public DbSet<GotSprt> GotSprts { get; set; }
        
        public DbSet<GotSysUser> GotSysUsers { get; set; }
        
        public DbSet<GotCdTypePv> GotCdTypePvs { get; set; }
        
        public DbSet<GotInsp> GotInsps { get; set; }
        
        public DbSet<GotCdCouche> GotCdCouches { get; set; }
        
        public DbSet<GotCdCompactage> GotCdCompactages { get; set; }
        
        public DbSet<GotCdEtude> GotCdEtudes { get; set; }
        
        public DbSet<GotSeuilQualite> GotSeuilQualites { get; set; }
        
        public DbSet<GotSeuilUrgence> GotSeuilUrgences { get; set; }
        
        public DbSet<GotVst> GotVsts { get; set; }
        
        public DbSet<GotPhotoSprtVst> GotPhotoSprtVsts { get; set; }
        
        public DbSet<GotBpu> GotBpus { get; set; }
        
        public DbSet<GotPrevision> GotPrevisions { get; set; }
        
        public DbSet<GotCdContrainte> GotCdContraintes { get; set; }
        
        public DbSet<GotPhotoInsp> GotPhotoInsps { get; set; }
        
        public DbSet<GotPhotoVst> GotPhotoVsts { get; set; }
        
        public DbSet<GotCdQualite> GotCdQualites { get; set; }
        
        public DbSet<GotHistoNote> GotHistoNotes { get; set; }
        
        public DbSet<GotCdOrigin> GotCdOrigins { get; set; }
        
        public DbSet<GotCdRisque> GotCdRisques { get; set; }
        
        public DbSet<GotDictionnaire> GotDictionnaires { get; set; }
        
        public DbSet<GotCdType> GotCdTypes { get; set; }
        
        public DbSet<GotCdEvt> GotCdEvts { get; set; }
        
        public DbSet<GotEvt> GotEvts { get; set; }
        
        public DbSet<GotCdLigne> GotCdLignes { get; set; }
        
        public DbSet<GotCdChapitre> GotCdChapitres { get; set; }
        
        public DbSet<GotSprtVst> GotSprtVsts { get; set; }
        
        public DbSet<GotCdEntete> GotCdEntetes { get; set; }
        
        public DbSet<GotEntete> GotEntetes { get; set; }
        
        public DbSet<GotContact> GotContacts { get; set; }
        
        public DbSet<GotCdComposant> GotCdComposants { get; set; }
        
        public DbSet<GotInspecteur> GotInspecteurs { get; set; }
        
        public DbSet<GotCdUnite> GotCdUnites { get; set; }
        
        public DbSet<GotCdConclusion> GotCdConclusions { get; set; }
        
        public DbSet<GotDscTemp> GotDscTemps { get; set; }
        
        public DbSet<GotEltInspTmp> GotEltInspTmps { get; set; }
        
        public DbSet<GotPhotoEltInspTmp> GotPhotoEltInspTmps { get; set; }
        
        public DbSet<GotInspTmp> GotInspTmps { get; set; }
        
        public DbSet<GotPhotoInspTmp> GotPhotoInspTmps { get; set; }
        
        public DbSet<GotClsDoc> GotClsDocs { get; set; }
        
        public DbSet<GotCouche> GotCouches { get; set; }
        
        public DbSet<GotDscCamp> GotDscCamps { get; set; }
        
        public DbSet<GotCdPrecoSprtVst> GotCdPrecoSprtVsts { get; set; }
        
        public DbSet<GotCdConclusionInsp> GotCdConclusionInsps { get; set; }
        
        public DbSet<GotCdConclusionInspTmp> GotCdConclusionInspTmps { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<GotCdEntp>().HasMany<GotTravaux>(c => c.GotTravauxs).WithRequired(t => t.GotCdEntp).HasForeignKey(u => new {u.GotCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEntp>().HasMany<GotDsc>(c => c.GotDscs).WithOptional(t => t.GotCdEntp).HasForeignKey(u => new {u.GotCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEntp>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithOptional(t => t.GotCdEntp).HasForeignKey(u => new {u.GotCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEntp>().ToTable("CD_ENTP_GOT","GOT");
            modelBuilder.Entity<GotCdEntp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdEntp>().Property(item => item.Entreprise).IsRequired();
            modelBuilder.Entity<GotCdEntp>().Property(item => item.Entreprise).HasMaxLength(60);
            modelBuilder.Entity<GotCdEntp>().Property(item => item.Entreprise).HasColumnName("ENTREPRISE");
            modelBuilder.Entity<GotDsc>().HasRequired<GotCdFam>(c => c.GotCdFam).WithMany(t => t.GotDscs).HasForeignKey(u => new { u.GotCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasOptional<GotCdPente>(c => c.GotCdPente).WithMany(t => t.GotDscs).HasForeignKey(u => new {u.GotCdPenteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasOptional<GotCdProtect>(c => c.GotCdProtect).WithMany(t => t.GotDscs).HasForeignKey(u => new {u.GotCdProtectIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasOptional<GotCdGeo>(c => c.GotCdGeo).WithMany(t => t.GotDscs).HasForeignKey(u => new {u.GotCdGeoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasOptional<GotCdEntp>(c => c.GotCdEntp).WithMany(t => t.GotDscs).HasForeignKey(u => new {u.GotCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasOptional<GotCdQualite>(c => c.GotCdQualite).WithMany(t => t.GotDscs).HasForeignKey(u => new {u.GotCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasOptional<GotCdRisque>(c => c.GotCdRisque).WithMany(t => t.GotDscs).HasForeignKey(u => new {u.GotCdRisqueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasOptional<GotCdType>(c => c.GotCdType).WithMany(t => t.GotDscs).HasForeignKey(u => new {u.GotCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotTravaux>(c => c.GotTravauxs).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotInsp>(c => c.GotInsps).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotVst>(c => c.GotVsts).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotPrevision>(c => c.GotPrevisions).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotHistoNote>(c => c.GotHistoNotes).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotEvt>(c => c.GotEvts).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithOptional(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotCouche>(c => c.GotCouches).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().HasMany<GotDscCamp>(c => c.GotDscCamps).WithRequired(t => t.GotDsc).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDsc>().ToTable("DSC_GOT","GOT");
            modelBuilder.Entity<GotDsc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotDsc>().Property(item => item.NumGot).IsRequired();
            modelBuilder.Entity<GotDsc>().Property(item => item.NumGot).HasMaxLength(17);
            modelBuilder.Entity<GotDsc>().Property(item => item.NumGot).HasColumnName("NUM_GOT");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdFamGotFamille).IsRequired();
            modelBuilder.Entity<GotDsc>().Property(item => item.CdFamGotFamille).HasMaxLength(20);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdFamGotFamille).HasColumnName("CD_FAM_GOT__FAMILLE");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdQualiteGotQualite).HasMaxLength(25);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdQualiteGotQualite).HasColumnName("CD_QUALITE_GOT__QUALITE");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdGeoGotGeologie).HasMaxLength(60);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdGeoGotGeologie).HasColumnName("CD_GEO_GOT__GEOLOGIE");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdProtectGotType).HasMaxLength(60);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdProtectGotType).HasColumnName("CD_PROTECT_GOT__TYPE");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdTypeGotType).HasMaxLength(20);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdTypeGotType).HasColumnName("CD_TYPE_GOT__TYPE");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdEntpGotEntreprise).HasMaxLength(60);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdEntpGotEntreprise).HasColumnName("CD_ENTP_GOT__ENTREPRISE");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdRisqueGotRisque).HasMaxLength(3);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdRisqueGotRisque).HasColumnName("CD_RISQUE_GOT__RISQUE");
            modelBuilder.Entity<GotDsc>().Property(item => item.CdPenteGotPente).HasMaxLength(25);
            modelBuilder.Entity<GotDsc>().Property(item => item.CdPenteGotPente).HasColumnName("CD_PENTE_GOT__PENTE");
            modelBuilder.Entity<GotDsc>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<GotDsc>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<GotDsc>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<GotDsc>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<GotDsc>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<GotDsc>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<GotDsc>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<GotDsc>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<GotDsc>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<GotDsc>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<GotDsc>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<GotDsc>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<GotDsc>().Property(item => item.DateConst).HasColumnName("DATE_CONST");
            modelBuilder.Entity<GotDsc>().Property(item => item.PenteTnValueInt).HasColumnName("PENTE_TN");
            modelBuilder.Entity<GotDsc>().Ignore(item => item.PenteTn);
            modelBuilder.Entity<GotDsc>().Property(item => item.Haut).HasColumnName("HAUT");
            modelBuilder.Entity<GotDsc>().Property(item => item.LargCrete).HasColumnName("LARG_CRETE");
            modelBuilder.Entity<GotDsc>().Property(item => item.Volume).HasColumnName("VOLUME");
            modelBuilder.Entity<GotDsc>().Property(item => item.RisbNbr).HasColumnName("RISB_NBR");
            modelBuilder.Entity<GotDsc>().Property(item => item.RisbEsp).HasColumnName("RISB_ESP");
            modelBuilder.Entity<GotDsc>().Property(item => item.RisbLarg).HasColumnName("RISB_LARG");
            modelBuilder.Entity<GotDsc>().Property(item => item.HautEau).HasColumnName("HAUT_EAU");
            modelBuilder.Entity<GotDsc>().Property(item => item.InstableValueInt).HasColumnName("INSTABLE");
            modelBuilder.Entity<GotDsc>().Ignore(item => item.Instable);
            modelBuilder.Entity<GotDsc>().Property(item => item.NomUsage).HasMaxLength(255);
            modelBuilder.Entity<GotDsc>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<GotDsc>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GotDsc>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GotDsc>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GotDsc>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GotDsc>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GotDsc>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GotDsc>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GotDsc>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GotDsc>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GotDsc>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<GotDsc>().Ignore(item => item.Securite);
            modelBuilder.Entity<GotDsc>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GotDsc>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GotDsc>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<GotDsc>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<GotDsc>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<GotDsc>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<GotDsc>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<GotDsc>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<GotDsc>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<GotDsc>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<GotDsc>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotDsc>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<GotDsc>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<GotDsc>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<GotDsc>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<GotDsc>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<GotDsc>().Ignore(item => item.Terrain);
            modelBuilder.Entity<GotDsc>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<GotDsc>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<GotDsc>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<GotCls>().HasMany<GotClsDoc>(c => c.GotClsDocs).WithRequired(t => t.GotCls).HasForeignKey(u => new {u.GotClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCls>().ToTable("CLS_GOT","GOT");
            modelBuilder.Entity<GotCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotCls>().Property(item => item.TableName).HasMaxLength(30);
            modelBuilder.Entity<GotCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<GotCls>().Property(item => item.KeyValue).HasMaxLength(100);
            modelBuilder.Entity<GotCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<GotDoc>().HasRequired<GotCdDoc>(c => c.GotCdDoc).WithMany(t => t.GotDocs).HasForeignKey(u => new { u.GotCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDoc>().HasMany<GotContact>(c => c.GotContacts).WithRequired(t => t.GotDoc).HasForeignKey(u => new {u.GotDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDoc>().HasMany<GotClsDoc>(c => c.GotClsDocs).WithRequired(t => t.GotDoc).HasForeignKey(u => new {u.GotDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDoc>().ToTable("DOC_GOT","GOT");
            modelBuilder.Entity<GotDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotDoc>().Property(item => item.CdDocGotCode).IsRequired();
            modelBuilder.Entity<GotDoc>().Property(item => item.CdDocGotCode).HasMaxLength(15);
            modelBuilder.Entity<GotDoc>().Property(item => item.CdDocGotCode).HasColumnName("CD_DOC_GOT__CODE");
            modelBuilder.Entity<GotDoc>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<GotDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<GotDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<GotCdDoc>().HasMany<GotDoc>(c => c.GotDocs).WithRequired(t => t.GotCdDoc).HasForeignKey(u => new {u.GotCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdDoc>().ToTable("CD_DOC_GOT","GOT");
            modelBuilder.Entity<GotCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GotCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<GotCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GotCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GotCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<GotCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<GotElt>().HasRequired<GotSprt>(c => c.GotSprt).WithMany(t => t.GotElts).HasForeignKey(u => new { u.GotSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotElt>().HasMany<GotEltInsp>(c => c.GotEltInsps).WithRequired(t => t.GotElt).HasForeignKey(u => new {u.GotEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotElt>().HasMany<GotEltInspTmp>(c => c.GotEltInspTmps).WithRequired(t => t.GotElt).HasForeignKey(u => new {u.GotEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotElt>().ToTable("ELT_GOT","GOT");
            modelBuilder.Entity<GotElt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotElt>().Property(item => item.GrpGotIdGrp).IsRequired();
            modelBuilder.Entity<GotElt>().Property(item => item.GrpGotIdGrp).HasColumnName("GRP_GOT__ID_GRP");
            modelBuilder.Entity<GotElt>().Property(item => item.PrtGotIdPrt).IsRequired();
            modelBuilder.Entity<GotElt>().Property(item => item.PrtGotIdPrt).HasColumnName("PRT_GOT__ID_PRT");
            modelBuilder.Entity<GotElt>().Property(item => item.SprtGotIdSprt).IsRequired();
            modelBuilder.Entity<GotElt>().Property(item => item.SprtGotIdSprt).HasColumnName("SPRT_GOT__ID_SPRT");
            modelBuilder.Entity<GotElt>().Property(item => item.IdElem).IsRequired();
            modelBuilder.Entity<GotElt>().Property(item => item.IdElem).HasColumnName("ID_ELEM");
            modelBuilder.Entity<GotElt>().Property(item => item.Libe).IsRequired();
            modelBuilder.Entity<GotElt>().Property(item => item.Libe).HasMaxLength(500);
            modelBuilder.Entity<GotElt>().Property(item => item.Libe).HasColumnName("LIBE");
            modelBuilder.Entity<GotElt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GotElt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GotElt>().Property(item => item.Aide).HasMaxLength(500);
            modelBuilder.Entity<GotElt>().Property(item => item.Aide).HasColumnName("AIDE");
            modelBuilder.Entity<GotElt>().Property(item => item.Indice1).HasMaxLength(500);
            modelBuilder.Entity<GotElt>().Property(item => item.Indice1).HasColumnName("INDICE1");
            modelBuilder.Entity<GotElt>().Property(item => item.Indice2).HasMaxLength(500);
            modelBuilder.Entity<GotElt>().Property(item => item.Indice2).HasColumnName("INDICE2");
            modelBuilder.Entity<GotElt>().Property(item => item.Indice3).HasMaxLength(500);
            modelBuilder.Entity<GotElt>().Property(item => item.Indice3).HasColumnName("INDICE3");
            modelBuilder.Entity<GotPrt>().HasRequired<GotGrp>(c => c.GotGrp).WithMany(t => t.GotPrts).HasForeignKey(u => new { u.GotGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPrt>().HasMany<GotSprt>(c => c.GotSprts).WithRequired(t => t.GotPrt).HasForeignKey(u => new {u.GotPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPrt>().ToTable("PRT_GOT","GOT");
            modelBuilder.Entity<GotPrt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPrt>().Property(item => item.GrpGotIdGrp).IsRequired();
            modelBuilder.Entity<GotPrt>().Property(item => item.GrpGotIdGrp).HasColumnName("GRP_GOT__ID_GRP");
            modelBuilder.Entity<GotPrt>().Property(item => item.IdPrt).IsRequired();
            modelBuilder.Entity<GotPrt>().Property(item => item.IdPrt).HasColumnName("ID_PRT");
            modelBuilder.Entity<GotPrt>().Property(item => item.Libp).IsRequired();
            modelBuilder.Entity<GotPrt>().Property(item => item.Libp).HasMaxLength(500);
            modelBuilder.Entity<GotPrt>().Property(item => item.Libp).HasColumnName("LIBP");
            modelBuilder.Entity<GotPrt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GotPrt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GotGrp>().HasMany<GotPrt>(c => c.GotPrts).WithRequired(t => t.GotGrp).HasForeignKey(u => new {u.GotGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotGrp>().ToTable("GRP_GOT","GOT");
            modelBuilder.Entity<GotGrp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotGrp>().Property(item => item.IdGrp).IsRequired();
            modelBuilder.Entity<GotGrp>().Property(item => item.IdGrp).HasColumnName("ID_GRP");
            modelBuilder.Entity<GotGrp>().Property(item => item.Libg).IsRequired();
            modelBuilder.Entity<GotGrp>().Property(item => item.Libg).HasMaxLength(500);
            modelBuilder.Entity<GotGrp>().Property(item => item.Libg).HasColumnName("LIBG");
            modelBuilder.Entity<GotGrp>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GotGrp>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GotEltInsp>().HasRequired<GotInsp>(c => c.GotInsp).WithMany(t => t.GotEltInsps).HasForeignKey(u => new { u.GotInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEltInsp>().HasRequired<GotElt>(c => c.GotElt).WithMany(t => t.GotEltInsps).HasForeignKey(u => new { u.GotEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEltInsp>().HasMany<GotPhotoEltInsp>(c => c.GotPhotoEltInsps).WithRequired(t => t.GotEltInsp).HasForeignKey(u => new {u.GotEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEltInsp>().ToTable("ELT_INSP_GOT","GOT");
            modelBuilder.Entity<GotEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotEltInsp>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotEltInsp>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotEltInsp>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotEltInsp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotEltInsp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotEltInsp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotEltInsp>().Property(item => item.GrpGotIdGrp).IsRequired();
            modelBuilder.Entity<GotEltInsp>().Property(item => item.GrpGotIdGrp).HasColumnName("GRP_GOT__ID_GRP");
            modelBuilder.Entity<GotEltInsp>().Property(item => item.PrtGotIdPrt).IsRequired();
            modelBuilder.Entity<GotEltInsp>().Property(item => item.PrtGotIdPrt).HasColumnName("PRT_GOT__ID_PRT");
            modelBuilder.Entity<GotEltInsp>().Property(item => item.SprtGotIdSprt).IsRequired();
            modelBuilder.Entity<GotEltInsp>().Property(item => item.SprtGotIdSprt).HasColumnName("SPRT_GOT__ID_SPRT");
            modelBuilder.Entity<GotEltInsp>().Property(item => item.EltGotIdElem).IsRequired();
            modelBuilder.Entity<GotEltInsp>().Property(item => item.EltGotIdElem).HasColumnName("ELT_GOT__ID_ELEM");
            modelBuilder.Entity<GotEltInsp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<GotEltInsp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GotEltInsp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<GotEltInsp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<GotPhotoEltInsp>().HasRequired<GotEltInsp>(c => c.GotEltInsp).WithMany(t => t.GotPhotoEltInsps).HasForeignKey(u => new { u.GotEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPhotoEltInsp>().ToTable("PHOTO_ELT_INSP_GOT","GOT");
            modelBuilder.Entity<GotPhotoEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.GrpGotIdGrp).IsRequired();
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.GrpGotIdGrp).HasColumnName("GRP_GOT__ID_GRP");
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.PrtGotIdPrt).IsRequired();
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.PrtGotIdPrt).HasColumnName("PRT_GOT__ID_PRT");
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.SprtGotIdSprt).IsRequired();
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.SprtGotIdSprt).HasColumnName("SPRT_GOT__ID_SPRT");
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.EltGotIdElem).IsRequired();
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.EltGotIdElem).HasColumnName("ELT_GOT__ID_ELEM");
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoEltInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotCamp>().HasRequired<GotCdPresta>(c => c.GotCdPresta).WithMany(t => t.GotCamps).HasForeignKey(u => new { u.GotCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCamp>().HasRequired<GotCdTypePv>(c => c.GotCdTypePv).WithMany(t => t.GotCamps).HasForeignKey(u => new { u.GotCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCamp>().HasMany<GotInsp>(c => c.GotInsps).WithRequired(t => t.GotCamp).HasForeignKey(u => new {u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCamp>().HasMany<GotVst>(c => c.GotVsts).WithRequired(t => t.GotCamp).HasForeignKey(u => new {u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCamp>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithRequired(t => t.GotCamp).HasForeignKey(u => new {u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCamp>().HasMany<GotDscCamp>(c => c.GotDscCamps).WithRequired(t => t.GotCamp).HasForeignKey(u => new {u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCamp>().ToTable("CAMP_GOT","GOT");
            modelBuilder.Entity<GotCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCamp>().Property(item => item.IdCamp).IsRequired();
            modelBuilder.Entity<GotCamp>().Property(item => item.IdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotCamp>().Property(item => item.IdCamp).HasColumnName("ID_CAMP");
            modelBuilder.Entity<GotCamp>().Property(item => item.CdTypePvGotCode).IsRequired();
            modelBuilder.Entity<GotCamp>().Property(item => item.CdTypePvGotCode).HasMaxLength(15);
            modelBuilder.Entity<GotCamp>().Property(item => item.CdTypePvGotCode).HasColumnName("CD_TYPE_PV_GOT__CODE");
            modelBuilder.Entity<GotCamp>().Property(item => item.CdPrestaGotPrestataire).IsRequired();
            modelBuilder.Entity<GotCamp>().Property(item => item.CdPrestaGotPrestataire).HasMaxLength(50);
            modelBuilder.Entity<GotCamp>().Property(item => item.CdPrestaGotPrestataire).HasColumnName("CD_PRESTA_GOT__PRESTATAIRE");
            modelBuilder.Entity<GotCamp>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<GotCamp>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<GotCamp>().Property(item => item.Dater).IsRequired();
            modelBuilder.Entity<GotCamp>().Property(item => item.Dater).HasColumnName("DATER");
            modelBuilder.Entity<GotCamp>().Property(item => item.Dateg).HasColumnName("DATEG");
            modelBuilder.Entity<GotCamp>().Property(item => item.Userg).HasMaxLength(255);
            modelBuilder.Entity<GotCamp>().Property(item => item.Userg).HasColumnName("USERG");
            modelBuilder.Entity<GotCamp>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<GotCamp>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<GotCdMeteo>().HasMany<GotInsp>(c => c.GotInsps).WithOptional(t => t.GotCdMeteo).HasForeignKey(u => new {u.GotCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdMeteo>().HasMany<GotInspTmp>(c => c.GotInspTmps).WithOptional(t => t.GotCdMeteo).HasForeignKey(u => new {u.GotCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdMeteo>().ToTable("CD_METEO_GOT","GOT");
            modelBuilder.Entity<GotCdMeteo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdMeteo>().Property(item => item.Meteo).IsRequired();
            modelBuilder.Entity<GotCdMeteo>().Property(item => item.Meteo).HasMaxLength(60);
            modelBuilder.Entity<GotCdMeteo>().Property(item => item.Meteo).HasColumnName("METEO");
            modelBuilder.Entity<GotCdPresta>().HasMany<GotCamp>(c => c.GotCamps).WithRequired(t => t.GotCdPresta).HasForeignKey(u => new {u.GotCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdPresta>().HasMany<GotInspecteur>(c => c.GotInspecteurs).WithRequired(t => t.GotCdPresta).HasForeignKey(u => new {u.GotCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdPresta>().ToTable("CD_PRESTA_GOT","GOT");
            modelBuilder.Entity<GotCdPresta>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdPresta>().Property(item => item.Prestataire).IsRequired();
            modelBuilder.Entity<GotCdPresta>().Property(item => item.Prestataire).HasMaxLength(50);
            modelBuilder.Entity<GotCdPresta>().Property(item => item.Prestataire).HasColumnName("PRESTATAIRE");
            modelBuilder.Entity<GotTravaux>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotTravauxs).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotTravaux>().HasRequired<GotNatureTrav>(c => c.GotNatureTrav).WithMany(t => t.GotTravauxs).HasForeignKey(u => new { u.GotNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotTravaux>().HasRequired<GotCdEntp>(c => c.GotCdEntp).WithMany(t => t.GotTravauxs).HasForeignKey(u => new { u.GotCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotTravaux>().ToTable("TRAVAUX_GOT","GOT");
            modelBuilder.Entity<GotTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotTravaux>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotTravaux>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotTravaux>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotTravaux>().Property(item => item.CdTravauxGotCode).IsRequired();
            modelBuilder.Entity<GotTravaux>().Property(item => item.CdTravauxGotCode).HasMaxLength(60);
            modelBuilder.Entity<GotTravaux>().Property(item => item.CdTravauxGotCode).HasColumnName("CD_TRAVAUX_GOT__CODE");
            modelBuilder.Entity<GotTravaux>().Property(item => item.NatureTravGotNature).IsRequired();
            modelBuilder.Entity<GotTravaux>().Property(item => item.NatureTravGotNature).HasMaxLength(255);
            modelBuilder.Entity<GotTravaux>().Property(item => item.NatureTravGotNature).HasColumnName("NATURE_TRAV_GOT__NATURE");
            modelBuilder.Entity<GotTravaux>().Property(item => item.DateRcp).IsRequired();
            modelBuilder.Entity<GotTravaux>().Property(item => item.DateRcp).HasColumnName("DATE_RCP");
            modelBuilder.Entity<GotTravaux>().Property(item => item.CdEntpGotEntreprise).IsRequired();
            modelBuilder.Entity<GotTravaux>().Property(item => item.CdEntpGotEntreprise).HasMaxLength(60);
            modelBuilder.Entity<GotTravaux>().Property(item => item.CdEntpGotEntreprise).HasColumnName("CD_ENTP_GOT__ENTREPRISE");
            modelBuilder.Entity<GotTravaux>().Property(item => item.DateFinGar).HasColumnName("DATE_FIN_GAR");
            modelBuilder.Entity<GotTravaux>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<GotTravaux>().Property(item => item.Marche).HasMaxLength(25);
            modelBuilder.Entity<GotTravaux>().Property(item => item.Marche).HasColumnName("MARCHE");
            modelBuilder.Entity<GotTravaux>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<GotTravaux>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotNatureTrav>().HasRequired<GotCdTravaux>(c => c.GotCdTravaux).WithMany(t => t.GotNatureTravs).HasForeignKey(u => new { u.GotCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotNatureTrav>().HasMany<GotTravaux>(c => c.GotTravauxs).WithRequired(t => t.GotNatureTrav).HasForeignKey(u => new {u.GotNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotNatureTrav>().ToTable("NATURE_TRAV_GOT","GOT");
            modelBuilder.Entity<GotNatureTrav>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotNatureTrav>().Property(item => item.CdTravauxGotCode).IsRequired();
            modelBuilder.Entity<GotNatureTrav>().Property(item => item.CdTravauxGotCode).HasMaxLength(60);
            modelBuilder.Entity<GotNatureTrav>().Property(item => item.CdTravauxGotCode).HasColumnName("CD_TRAVAUX_GOT__CODE");
            modelBuilder.Entity<GotNatureTrav>().Property(item => item.Nature).IsRequired();
            modelBuilder.Entity<GotNatureTrav>().Property(item => item.Nature).HasMaxLength(255);
            modelBuilder.Entity<GotNatureTrav>().Property(item => item.Nature).HasColumnName("NATURE");
            modelBuilder.Entity<GotCdTravaux>().HasMany<GotNatureTrav>(c => c.GotNatureTravs).WithRequired(t => t.GotCdTravaux).HasForeignKey(u => new {u.GotCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdTravaux>().HasMany<GotBpu>(c => c.GotBpus).WithRequired(t => t.GotCdTravaux).HasForeignKey(u => new {u.GotCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdTravaux>().ToTable("CD_TRAVAUX_GOT","GOT");
            modelBuilder.Entity<GotCdTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdTravaux>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GotCdTravaux>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<GotCdTravaux>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GotCdFam>().HasMany<GotDsc>(c => c.GotDscs).WithRequired(t => t.GotCdFam).HasForeignKey(u => new {u.GotCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdFam>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithRequired(t => t.GotCdFam).HasForeignKey(u => new {u.GotCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdFam>().ToTable("CD_FAM_GOT","GOT");
            modelBuilder.Entity<GotCdFam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdFam>().Property(item => item.Famille).IsRequired();
            modelBuilder.Entity<GotCdFam>().Property(item => item.Famille).HasMaxLength(20);
            modelBuilder.Entity<GotCdFam>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<GotCdFam>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GotCdFam>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdPente>().HasMany<GotDsc>(c => c.GotDscs).WithOptional(t => t.GotCdPente).HasForeignKey(u => new {u.GotCdPenteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdPente>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithOptional(t => t.GotCdPente).HasForeignKey(u => new {u.GotCdPenteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdPente>().ToTable("CD_PENTE_GOT","GOT");
            modelBuilder.Entity<GotCdPente>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdPente>().Property(item => item.Pente).IsRequired();
            modelBuilder.Entity<GotCdPente>().Property(item => item.Pente).HasMaxLength(25);
            modelBuilder.Entity<GotCdPente>().Property(item => item.Pente).HasColumnName("PENTE");
            modelBuilder.Entity<GotCdPente>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GotCdPente>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdProtect>().HasMany<GotDsc>(c => c.GotDscs).WithOptional(t => t.GotCdProtect).HasForeignKey(u => new {u.GotCdProtectIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdProtect>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithOptional(t => t.GotCdProtect).HasForeignKey(u => new {u.GotCdProtectIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdProtect>().ToTable("CD_PROTECT_GOT","GOT");
            modelBuilder.Entity<GotCdProtect>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdProtect>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GotCdProtect>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GotCdProtect>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GotCdGeo>().HasMany<GotDsc>(c => c.GotDscs).WithOptional(t => t.GotCdGeo).HasForeignKey(u => new {u.GotCdGeoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdGeo>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithOptional(t => t.GotCdGeo).HasForeignKey(u => new {u.GotCdGeoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdGeo>().ToTable("CD_GEO_GOT","GOT");
            modelBuilder.Entity<GotCdGeo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdGeo>().Property(item => item.Geologie).IsRequired();
            modelBuilder.Entity<GotCdGeo>().Property(item => item.Geologie).HasMaxLength(60);
            modelBuilder.Entity<GotCdGeo>().Property(item => item.Geologie).HasColumnName("GEOLOGIE");
            modelBuilder.Entity<GotCdMateriau>().HasMany<GotCouche>(c => c.GotCouches).WithRequired(t => t.GotCdMateriau).HasForeignKey(u => new {u.GotCdMateriauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdMateriau>().ToTable("CD_MATERIAU_GOT","GOT");
            modelBuilder.Entity<GotCdMateriau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdMateriau>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GotCdMateriau>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<GotCdMateriau>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GotCdHydrique>().HasMany<GotCouche>(c => c.GotCouches).WithRequired(t => t.GotCdHydrique).HasForeignKey(u => new {u.GotCdHydriqueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdHydrique>().ToTable("CD_HYDRIQUE_GOT","GOT");
            modelBuilder.Entity<GotCdHydrique>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdHydrique>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<GotCdHydrique>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<GotCdHydrique>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<GotCdTraitement>().HasMany<GotCouche>(c => c.GotCouches).WithRequired(t => t.GotCdTraitement).HasForeignKey(u => new {u.GotCdTraitementIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdTraitement>().ToTable("CD_TRAITEMENT_GOT","GOT");
            modelBuilder.Entity<GotCdTraitement>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdTraitement>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GotCdTraitement>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<GotCdTraitement>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GotSprt>().HasRequired<GotPrt>(c => c.GotPrt).WithMany(t => t.GotSprts).HasForeignKey(u => new { u.GotPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotSprt>().HasMany<GotElt>(c => c.GotElts).WithRequired(t => t.GotSprt).HasForeignKey(u => new {u.GotSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotSprt>().ToTable("SPRT_GOT","GOT");
            modelBuilder.Entity<GotSprt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotSprt>().Property(item => item.GrpGotIdGrp).IsRequired();
            modelBuilder.Entity<GotSprt>().Property(item => item.GrpGotIdGrp).HasColumnName("GRP_GOT__ID_GRP");
            modelBuilder.Entity<GotSprt>().Property(item => item.PrtGotIdPrt).IsRequired();
            modelBuilder.Entity<GotSprt>().Property(item => item.PrtGotIdPrt).HasColumnName("PRT_GOT__ID_PRT");
            modelBuilder.Entity<GotSprt>().Property(item => item.IdSprt).IsRequired();
            modelBuilder.Entity<GotSprt>().Property(item => item.IdSprt).HasColumnName("ID_SPRT");
            modelBuilder.Entity<GotSprt>().Property(item => item.Libs).IsRequired();
            modelBuilder.Entity<GotSprt>().Property(item => item.Libs).HasMaxLength(500);
            modelBuilder.Entity<GotSprt>().Property(item => item.Libs).HasColumnName("LIBS");
            modelBuilder.Entity<GotSprt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GotSprt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GotSysUser>().ToTable("SYS_USER_GOT","GOT");
            modelBuilder.Entity<GotSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<GotSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<GotSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<GotSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<GotSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<GotSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<GotSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<GotSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<GotCdTypePv>().HasMany<GotCamp>(c => c.GotCamps).WithRequired(t => t.GotCdTypePv).HasForeignKey(u => new {u.GotCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdTypePv>().ToTable("CD_TYPE_PV_GOT","GOT");
            modelBuilder.Entity<GotCdTypePv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdTypePv>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GotCdTypePv>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<GotCdTypePv>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GotCdTypePv>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GotCdTypePv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdTypePv>().Property(item => item.Cycle).HasColumnName("CYCLE");
            modelBuilder.Entity<GotCdTypePv>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<GotInsp>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotInsps).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().HasOptional<GotCdMeteo>(c => c.GotCdMeteo).WithMany(t => t.GotInsps).HasForeignKey(u => new {u.GotCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().HasOptional<GotCdEtude>(c => c.GotCdEtude).WithMany(t => t.GotInsps).HasForeignKey(u => new {u.GotCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().HasRequired<GotCamp>(c => c.GotCamp).WithMany(t => t.GotInsps).HasForeignKey(u => new { u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().HasOptional<GotInspecteur>(c => c.GotInspecteur).WithMany(t => t.GotInsps).HasForeignKey(u => new {u.GotInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().HasMany<GotEltInsp>(c => c.GotEltInsps).WithRequired(t => t.GotInsp).HasForeignKey(u => new {u.GotInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().HasMany<GotPhotoInsp>(c => c.GotPhotoInsps).WithRequired(t => t.GotInsp).HasForeignKey(u => new {u.GotInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().HasMany<GotCdConclusionInsp>(c => c.GotCdConclusionInsps).WithRequired(t => t.GotInsp).HasForeignKey(u => new {u.GotInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInsp>().ToTable("INSP_GOT","GOT");
            modelBuilder.Entity<GotInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotInsp>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotInsp>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotInsp>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotInsp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotInsp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotInsp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotInsp>().Property(item => item.CdMeteoGotMeteo).HasMaxLength(60);
            modelBuilder.Entity<GotInsp>().Property(item => item.CdMeteoGotMeteo).HasColumnName("CD_METEO_GOT__METEO");
            modelBuilder.Entity<GotInsp>().Property(item => item.CdEtudeGotEtude).HasMaxLength(65);
            modelBuilder.Entity<GotInsp>().Property(item => item.CdEtudeGotEtude).HasColumnName("CD_ETUDE_GOT__ETUDE");
            modelBuilder.Entity<GotInsp>().Property(item => item.InspecteurGotNom).HasMaxLength(60);
            modelBuilder.Entity<GotInsp>().Property(item => item.InspecteurGotNom).HasColumnName("INSPECTEUR_GOT__NOM");
            modelBuilder.Entity<GotInsp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<GotInsp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<GotInsp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<GotInsp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<GotInsp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<GotInsp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<GotInsp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<GotInsp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<GotInsp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<GotInsp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<GotInsp>().Property(item => item.NomValid).HasMaxLength(255);
            modelBuilder.Entity<GotInsp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<GotInsp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GotInsp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GotInsp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<GotInsp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<GotInsp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<GotInsp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GotInsp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GotInsp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GotInsp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GotInsp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GotInsp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GotInsp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GotInsp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GotInsp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<GotInsp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<GotCdCouche>().HasMany<GotCouche>(c => c.GotCouches).WithRequired(t => t.GotCdCouche).HasForeignKey(u => new {u.GotCdCoucheIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdCouche>().ToTable("CD_COUCHE_GOT","GOT");
            modelBuilder.Entity<GotCdCouche>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdCouche>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GotCdCouche>().Property(item => item.Code).HasMaxLength(50);
            modelBuilder.Entity<GotCdCouche>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GotCdCouche>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<GotCdCouche>().Property(item => item.Couleur).HasMaxLength(16);
            modelBuilder.Entity<GotCdCouche>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<GotCdCompactage>().HasMany<GotCouche>(c => c.GotCouches).WithRequired(t => t.GotCdCompactage).HasForeignKey(u => new {u.GotCdCompactageIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdCompactage>().ToTable("CD_COMPACTAGE_GOT","GOT");
            modelBuilder.Entity<GotCdCompactage>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdCompactage>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<GotCdCompactage>().Property(item => item.Code).HasMaxLength(50);
            modelBuilder.Entity<GotCdCompactage>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<GotCdEtude>().HasMany<GotInsp>(c => c.GotInsps).WithOptional(t => t.GotCdEtude).HasForeignKey(u => new {u.GotCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEtude>().HasMany<GotInspTmp>(c => c.GotInspTmps).WithOptional(t => t.GotCdEtude).HasForeignKey(u => new {u.GotCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEtude>().ToTable("CD_ETUDE_GOT","GOT");
            modelBuilder.Entity<GotCdEtude>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdEtude>().Property(item => item.Etude).IsRequired();
            modelBuilder.Entity<GotCdEtude>().Property(item => item.Etude).HasMaxLength(65);
            modelBuilder.Entity<GotCdEtude>().Property(item => item.Etude).HasColumnName("ETUDE");
            modelBuilder.Entity<GotSeuilQualite>().HasRequired<GotCdQualite>(c => c.GotCdQualite).WithMany(t => t.GotSeuilQualites).HasForeignKey(u => new { u.GotCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotSeuilQualite>().ToTable("SEUIL_QUALITE_GOT","GOT");
            modelBuilder.Entity<GotSeuilQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotSeuilQualite>().Property(item => item.CdQualiteGotQualite).IsRequired();
            modelBuilder.Entity<GotSeuilQualite>().Property(item => item.CdQualiteGotQualite).HasMaxLength(25);
            modelBuilder.Entity<GotSeuilQualite>().Property(item => item.CdQualiteGotQualite).HasColumnName("CD_QUALITE_GOT__QUALITE");
            modelBuilder.Entity<GotSeuilQualite>().Property(item => item.IndiceUrgence).IsRequired();
            modelBuilder.Entity<GotSeuilQualite>().Property(item => item.IndiceUrgence).HasMaxLength(5);
            modelBuilder.Entity<GotSeuilQualite>().Property(item => item.IndiceUrgence).HasColumnName("INDICE_URGENCE");
            modelBuilder.Entity<GotSeuilUrgence>().ToTable("SEUIL_URGENCE_GOT","GOT");
            modelBuilder.Entity<GotSeuilUrgence>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotSeuilUrgence>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GotSeuilUrgence>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GotSeuilUrgence>().Property(item => item.NbrNote).HasColumnName("NBR_NOTE");
            modelBuilder.Entity<GotSeuilUrgence>().Property(item => item.ValNote).HasColumnName("VAL_NOTE");
            modelBuilder.Entity<GotSeuilUrgence>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GotVst>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotVsts).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotVst>().HasRequired<GotCamp>(c => c.GotCamp).WithMany(t => t.GotVsts).HasForeignKey(u => new { u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotVst>().HasOptional<GotInspecteur>(c => c.GotInspecteur).WithMany(t => t.GotVsts).HasForeignKey(u => new {u.GotInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotVst>().HasMany<GotPhotoVst>(c => c.GotPhotoVsts).WithRequired(t => t.GotVst).HasForeignKey(u => new {u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotVst>().HasMany<GotSprtVst>(c => c.GotSprtVsts).WithRequired(t => t.GotVst).HasForeignKey(u => new {u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotVst>().HasMany<GotEntete>(c => c.GotEntetes).WithRequired(t => t.GotVst).HasForeignKey(u => new {u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotVst>().HasMany<GotCdPrecoSprtVst>(c => c.GotCdPrecoSprtVsts).WithRequired(t => t.GotVst).HasForeignKey(u => new {u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotVst>().ToTable("VST_GOT","GOT");
            modelBuilder.Entity<GotVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotVst>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotVst>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotVst>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotVst>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotVst>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotVst>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotVst>().Property(item => item.InspecteurGotNom).HasMaxLength(60);
            modelBuilder.Entity<GotVst>().Property(item => item.InspecteurGotNom).HasColumnName("INSPECTEUR_GOT__NOM");
            modelBuilder.Entity<GotVst>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<GotVst>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<GotVst>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<GotVst>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<GotVst>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GotVst>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GotVst>().Property(item => item.Observ).HasMaxLength(500);
            modelBuilder.Entity<GotVst>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<GotVst>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<GotVst>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<GotPhotoSprtVst>().HasRequired<GotSprtVst>(c => c.GotSprtVst).WithMany(t => t.GotPhotoSprtVsts).HasForeignKey(u => new { u.GotSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPhotoSprtVst>().ToTable("PHOTO_SPRT_VST_GOT","GOT");
            modelBuilder.Entity<GotPhotoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.CdChapitreGotIdChap).IsRequired();
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.CdChapitreGotIdChap).HasColumnName("CD_CHAPITRE_GOT__ID_CHAP");
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.CdLigneGotIdLigne).IsRequired();
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.CdLigneGotIdLigne).HasColumnName("CD_LIGNE_GOT__ID_LIGNE");
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoSprtVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotBpu>().HasRequired<GotCdTravaux>(c => c.GotCdTravaux).WithMany(t => t.GotBpus).HasForeignKey(u => new { u.GotCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotBpu>().HasOptional<GotCdUnite>(c => c.GotCdUnite).WithMany(t => t.GotBpus).HasForeignKey(u => new {u.GotCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotBpu>().HasMany<GotPrevision>(c => c.GotPrevisions).WithRequired(t => t.GotBpu).HasForeignKey(u => new {u.GotBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotBpu>().HasMany<GotCdPrecoSprtVst>(c => c.GotCdPrecoSprtVsts).WithRequired(t => t.GotBpu).HasForeignKey(u => new {u.GotBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotBpu>().ToTable("BPU_GOT","GOT");
            modelBuilder.Entity<GotBpu>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotBpu>().Property(item => item.IdBpu).IsRequired();
            modelBuilder.Entity<GotBpu>().Property(item => item.IdBpu).HasColumnName("ID_BPU");
            modelBuilder.Entity<GotBpu>().Property(item => item.CdTravauxGotCode).IsRequired();
            modelBuilder.Entity<GotBpu>().Property(item => item.CdTravauxGotCode).HasMaxLength(60);
            modelBuilder.Entity<GotBpu>().Property(item => item.CdTravauxGotCode).HasColumnName("CD_TRAVAUX_GOT__CODE");
            modelBuilder.Entity<GotBpu>().Property(item => item.CdUniteGotUnite).HasMaxLength(12);
            modelBuilder.Entity<GotBpu>().Property(item => item.CdUniteGotUnite).HasColumnName("CD_UNITE_GOT__UNITE");
            modelBuilder.Entity<GotBpu>().Property(item => item.Techn).IsRequired();
            modelBuilder.Entity<GotBpu>().Property(item => item.Techn).HasMaxLength(255);
            modelBuilder.Entity<GotBpu>().Property(item => item.Techn).HasColumnName("TECHN");
            modelBuilder.Entity<GotBpu>().Property(item => item.Prix).IsRequired();
            modelBuilder.Entity<GotBpu>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<GotBpu>().Property(item => item.DateMaj).HasColumnName("DATE_MAJ");
            modelBuilder.Entity<GotBpu>().Property(item => item.Freq).HasColumnName("FREQ");
            modelBuilder.Entity<GotBpu>().Property(item => item.PrecoVstValueInt).HasColumnName("PRECO_VST");
            modelBuilder.Entity<GotBpu>().Ignore(item => item.PrecoVst);
            modelBuilder.Entity<GotBpu>().Property(item => item.RealisVstValueInt).HasColumnName("REALIS_VST");
            modelBuilder.Entity<GotBpu>().Ignore(item => item.RealisVst);
            modelBuilder.Entity<GotPrevision>().HasRequired<GotBpu>(c => c.GotBpu).WithMany(t => t.GotPrevisions).HasForeignKey(u => new { u.GotBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPrevision>().HasOptional<GotCdContrainte>(c => c.GotCdContrainte).WithMany(t => t.GotPrevisions).HasForeignKey(u => new {u.GotCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPrevision>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotPrevisions).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPrevision>().ToTable("PREVISION_GOT","GOT");
            modelBuilder.Entity<GotPrevision>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPrevision>().Property(item => item.BpuGotIdBpu).IsRequired();
            modelBuilder.Entity<GotPrevision>().Property(item => item.BpuGotIdBpu).HasColumnName("BPU_GOT__ID_BPU");
            modelBuilder.Entity<GotPrevision>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotPrevision>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotPrevision>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotPrevision>().Property(item => item.DateDebut).IsRequired();
            modelBuilder.Entity<GotPrevision>().Property(item => item.DateDebut).HasColumnName("DATE_DEBUT");
            modelBuilder.Entity<GotPrevision>().Property(item => item.CdContrainteGotType).HasMaxLength(100);
            modelBuilder.Entity<GotPrevision>().Property(item => item.CdContrainteGotType).HasColumnName("CD_CONTRAINTE_GOT__TYPE");
            modelBuilder.Entity<GotPrevision>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<GotPrevision>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<GotPrevision>().Property(item => item.DateDemPub).HasColumnName("DATE_DEM_PUB");
            modelBuilder.Entity<GotPrevision>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<GotPrevision>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotPrevision>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<GotPrevision>().Ignore(item => item.Realise);
            modelBuilder.Entity<GotCdContrainte>().HasMany<GotPrevision>(c => c.GotPrevisions).WithOptional(t => t.GotCdContrainte).HasForeignKey(u => new {u.GotCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdContrainte>().ToTable("CD_CONTRAINTE_GOT","GOT");
            modelBuilder.Entity<GotCdContrainte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdContrainte>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GotCdContrainte>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<GotCdContrainte>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GotPhotoInsp>().HasRequired<GotInsp>(c => c.GotInsp).WithMany(t => t.GotPhotoInsps).HasForeignKey(u => new { u.GotInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPhotoInsp>().ToTable("PHOTO_INSP_GOT","GOT");
            modelBuilder.Entity<GotPhotoInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotPhotoVst>().HasRequired<GotVst>(c => c.GotVst).WithMany(t => t.GotPhotoVsts).HasForeignKey(u => new { u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPhotoVst>().ToTable("PHOTO_VST_GOT","GOT");
            modelBuilder.Entity<GotPhotoVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotCdQualite>().HasMany<GotDsc>(c => c.GotDscs).WithOptional(t => t.GotCdQualite).HasForeignKey(u => new {u.GotCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdQualite>().HasMany<GotSeuilQualite>(c => c.GotSeuilQualites).WithRequired(t => t.GotCdQualite).HasForeignKey(u => new {u.GotCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdQualite>().ToTable("CD_QUALITE_GOT","GOT");
            modelBuilder.Entity<GotCdQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdQualite>().Property(item => item.Qualite).IsRequired();
            modelBuilder.Entity<GotCdQualite>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<GotCdQualite>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<GotHistoNote>().HasRequired<GotCdOrigin>(c => c.GotCdOrigin).WithMany(t => t.GotHistoNotes).HasForeignKey(u => new { u.GotCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotHistoNote>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotHistoNotes).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotHistoNote>().HasOptional<GotCdRisque>(c => c.GotCdRisque).WithMany(t => t.GotHistoNotes).HasForeignKey(u => new {u.GotCdRisqueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotHistoNote>().ToTable("HISTO_NOTE_GOT","GOT");
            modelBuilder.Entity<GotHistoNote>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotHistoNote>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotHistoNote>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotHistoNote>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.DateNote).IsRequired();
            modelBuilder.Entity<GotHistoNote>().Property(item => item.DateNote).HasColumnName("DATE_NOTE");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.CdOriginGotOrigine).IsRequired();
            modelBuilder.Entity<GotHistoNote>().Property(item => item.CdOriginGotOrigine).HasMaxLength(20);
            modelBuilder.Entity<GotHistoNote>().Property(item => item.CdOriginGotOrigine).HasColumnName("CD_ORIGIN_GOT__ORIGINE");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.CdRisqueGotRisque).HasMaxLength(3);
            modelBuilder.Entity<GotHistoNote>().Property(item => item.CdRisqueGotRisque).HasColumnName("CD_RISQUE_GOT__RISQUE");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GotHistoNote>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GotHistoNote>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<GotHistoNote>().Ignore(item => item.Securite);
            modelBuilder.Entity<GotHistoNote>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GotHistoNote>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GotCdOrigin>().HasMany<GotHistoNote>(c => c.GotHistoNotes).WithRequired(t => t.GotCdOrigin).HasForeignKey(u => new {u.GotCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdOrigin>().ToTable("CD_ORIGIN_GOT","GOT");
            modelBuilder.Entity<GotCdOrigin>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdOrigin>().Property(item => item.Origine).IsRequired();
            modelBuilder.Entity<GotCdOrigin>().Property(item => item.Origine).HasMaxLength(20);
            modelBuilder.Entity<GotCdOrigin>().Property(item => item.Origine).HasColumnName("ORIGINE");
            modelBuilder.Entity<GotCdRisque>().HasMany<GotDsc>(c => c.GotDscs).WithOptional(t => t.GotCdRisque).HasForeignKey(u => new {u.GotCdRisqueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdRisque>().HasMany<GotHistoNote>(c => c.GotHistoNotes).WithOptional(t => t.GotCdRisque).HasForeignKey(u => new {u.GotCdRisqueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdRisque>().ToTable("CD_RISQUE_GOT","GOT");
            modelBuilder.Entity<GotCdRisque>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdRisque>().Property(item => item.Risque).IsRequired();
            modelBuilder.Entity<GotCdRisque>().Property(item => item.Risque).HasMaxLength(3);
            modelBuilder.Entity<GotCdRisque>().Property(item => item.Risque).HasColumnName("RISQUE");
            modelBuilder.Entity<GotDictionnaire>().ToTable("DICTIONNAIRE_GOT","GOT");
            modelBuilder.Entity<GotDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Definition).HasMaxLength(500);
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Definition).HasColumnName("DICTIONNAIRE_GOT_DEFINITION");
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<GotDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<GotCdType>().HasMany<GotDsc>(c => c.GotDscs).WithOptional(t => t.GotCdType).HasForeignKey(u => new {u.GotCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdType>().HasMany<GotDscTemp>(c => c.GotDscTemps).WithOptional(t => t.GotCdType).HasForeignKey(u => new {u.GotCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdType>().ToTable("CD_TYPE_GOT","GOT");
            modelBuilder.Entity<GotCdType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdType>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GotCdType>().Property(item => item.Type).HasMaxLength(20);
            modelBuilder.Entity<GotCdType>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GotCdEvt>().HasMany<GotEvt>(c => c.GotEvts).WithRequired(t => t.GotCdEvt).HasForeignKey(u => new {u.GotCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEvt>().ToTable("CD_EVT_GOT","GOT");
            modelBuilder.Entity<GotCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<GotCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<GotCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<GotCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<GotCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<GotEvt>().HasRequired<GotCdEvt>(c => c.GotCdEvt).WithMany(t => t.GotEvts).HasForeignKey(u => new { u.GotCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEvt>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotEvts).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEvt>().ToTable("EVT_GOT","GOT");
            modelBuilder.Entity<GotEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotEvt>().Property(item => item.CdEvtGotType).IsRequired();
            modelBuilder.Entity<GotEvt>().Property(item => item.CdEvtGotType).HasMaxLength(25);
            modelBuilder.Entity<GotEvt>().Property(item => item.CdEvtGotType).HasColumnName("CD_EVT_GOT__TYPE");
            modelBuilder.Entity<GotEvt>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotEvt>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotEvt>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<GotEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<GotEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<GotEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<GotEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<GotCdLigne>().HasRequired<GotCdChapitre>(c => c.GotCdChapitre).WithMany(t => t.GotCdLignes).HasForeignKey(u => new { u.GotCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdLigne>().HasMany<GotSprtVst>(c => c.GotSprtVsts).WithRequired(t => t.GotCdLigne).HasForeignKey(u => new {u.GotCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdLigne>().ToTable("CD_LIGNE_GOT","GOT");
            modelBuilder.Entity<GotCdLigne>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdLigne>().Property(item => item.CdChapitreGotIdChap).IsRequired();
            modelBuilder.Entity<GotCdLigne>().Property(item => item.CdChapitreGotIdChap).HasColumnName("CD_CHAPITRE_GOT__ID_CHAP");
            modelBuilder.Entity<GotCdLigne>().Property(item => item.IdLigne).IsRequired();
            modelBuilder.Entity<GotCdLigne>().Property(item => item.IdLigne).HasColumnName("ID_LIGNE");
            modelBuilder.Entity<GotCdLigne>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GotCdLigne>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GotCdLigne>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdLigne>().Property(item => item.OrdreLigne).IsRequired();
            modelBuilder.Entity<GotCdLigne>().Property(item => item.OrdreLigne).HasColumnName("ORDRE_LIGNE");
            modelBuilder.Entity<GotCdChapitre>().HasMany<GotCdLigne>(c => c.GotCdLignes).WithRequired(t => t.GotCdChapitre).HasForeignKey(u => new {u.GotCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdChapitre>().ToTable("CD_CHAPITRE_GOT","GOT");
            modelBuilder.Entity<GotCdChapitre>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.IdChap).IsRequired();
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.IdChap).HasColumnName("ID_CHAP");
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.OrdreChap).IsRequired();
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.OrdreChap).HasColumnName("ORDRE_CHAP");
            modelBuilder.Entity<GotCdChapitre>().Property(item => item.Ponderation).HasColumnName("PONDERATION");
            modelBuilder.Entity<GotSprtVst>().HasRequired<GotCdLigne>(c => c.GotCdLigne).WithMany(t => t.GotSprtVsts).HasForeignKey(u => new { u.GotCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotSprtVst>().HasRequired<GotVst>(c => c.GotVst).WithMany(t => t.GotSprtVsts).HasForeignKey(u => new { u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotSprtVst>().HasMany<GotPhotoSprtVst>(c => c.GotPhotoSprtVsts).WithRequired(t => t.GotSprtVst).HasForeignKey(u => new {u.GotSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotSprtVst>().ToTable("SPRT_VST_GOT","GOT");
            modelBuilder.Entity<GotSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotSprtVst>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotSprtVst>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotSprtVst>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotSprtVst>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotSprtVst>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotSprtVst>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotSprtVst>().Property(item => item.CdChapitreGotIdChap).IsRequired();
            modelBuilder.Entity<GotSprtVst>().Property(item => item.CdChapitreGotIdChap).HasColumnName("CD_CHAPITRE_GOT__ID_CHAP");
            modelBuilder.Entity<GotSprtVst>().Property(item => item.CdLigneGotIdLigne).IsRequired();
            modelBuilder.Entity<GotSprtVst>().Property(item => item.CdLigneGotIdLigne).HasColumnName("CD_LIGNE_GOT__ID_LIGNE");
            modelBuilder.Entity<GotSprtVst>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<GotSprtVst>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GotSprtVst>().Property(item => item.Obs).HasMaxLength(500);
            modelBuilder.Entity<GotSprtVst>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<GotCdEntete>().HasRequired<GotCdComposant>(c => c.GotCdComposant).WithMany(t => t.GotCdEntetes).HasForeignKey(u => new { u.GotCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEntete>().HasMany<GotEntete>(c => c.GotEntetes).WithRequired(t => t.GotCdEntete).HasForeignKey(u => new {u.GotCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdEntete>().ToTable("CD_ENTETE_GOT","GOT");
            modelBuilder.Entity<GotCdEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdEntete>().Property(item => item.IdEntete).IsRequired();
            modelBuilder.Entity<GotCdEntete>().Property(item => item.IdEntete).HasColumnName("ID_ENTETE");
            modelBuilder.Entity<GotCdEntete>().Property(item => item.CdComposantGotTypeComp).IsRequired();
            modelBuilder.Entity<GotCdEntete>().Property(item => item.CdComposantGotTypeComp).HasMaxLength(6);
            modelBuilder.Entity<GotCdEntete>().Property(item => item.CdComposantGotTypeComp).HasColumnName("CD_COMPOSANT_GOT__TYPE_COMP");
            modelBuilder.Entity<GotCdEntete>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GotCdEntete>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GotCdEntete>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdEntete>().Property(item => item.OrdreEnt).IsRequired();
            modelBuilder.Entity<GotCdEntete>().Property(item => item.OrdreEnt).HasColumnName("ORDRE_ENT");
            modelBuilder.Entity<GotCdEntete>().Property(item => item.Guide).HasMaxLength(500);
            modelBuilder.Entity<GotCdEntete>().Property(item => item.Guide).HasColumnName("GUIDE");
            modelBuilder.Entity<GotEntete>().HasRequired<GotCdEntete>(c => c.GotCdEntete).WithMany(t => t.GotEntetes).HasForeignKey(u => new { u.GotCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEntete>().HasRequired<GotVst>(c => c.GotVst).WithMany(t => t.GotEntetes).HasForeignKey(u => new { u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEntete>().ToTable("ENTETE_GOT","GOT");
            modelBuilder.Entity<GotEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotEntete>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotEntete>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotEntete>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotEntete>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotEntete>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotEntete>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotEntete>().Property(item => item.CdEnteteGotIdEntete).IsRequired();
            modelBuilder.Entity<GotEntete>().Property(item => item.CdEnteteGotIdEntete).HasColumnName("CD_ENTETE_GOT__ID_ENTETE");
            modelBuilder.Entity<GotEntete>().Property(item => item.Valeur).HasMaxLength(250);
            modelBuilder.Entity<GotEntete>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<GotContact>().HasRequired<GotDoc>(c => c.GotDoc).WithMany(t => t.GotContacts).HasForeignKey(u => new { u.GotDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotContact>().ToTable("CONTACT_GOT","GOT");
            modelBuilder.Entity<GotContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotContact>().Property(item => item.DocGotId).IsRequired();
            modelBuilder.Entity<GotContact>().Property(item => item.DocGotId).HasColumnName("DOC_GOT__ID");
            modelBuilder.Entity<GotContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<GotContact>().Property(item => item.Givenname).HasColumnName("GIVENNAME");
            modelBuilder.Entity<GotContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<GotContact>().Property(item => item.Sn).HasColumnName("SN");
            modelBuilder.Entity<GotContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<GotContact>().Property(item => item.Cn).HasColumnName("CN");
            modelBuilder.Entity<GotContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<GotContact>().Property(item => item.O).HasColumnName("O");
            modelBuilder.Entity<GotContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<GotContact>().Property(item => item.Mail).HasColumnName("MAIL");
            modelBuilder.Entity<GotContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<GotContact>().Property(item => item.Telephonenumber).HasColumnName("TELEPHONENUMBER");
            modelBuilder.Entity<GotContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<GotContact>().Property(item => item.Mobile).HasColumnName("MOBILE");
            modelBuilder.Entity<GotContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<GotContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("FACSIMILETELEPHONENUMBER");
            modelBuilder.Entity<GotContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<GotContact>().Property(item => item.Street).HasColumnName("STREET");
            modelBuilder.Entity<GotContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<GotContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("MOZILLAWORKSTREET2");
            modelBuilder.Entity<GotContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<GotContact>().Property(item => item.L).HasColumnName("L");
            modelBuilder.Entity<GotContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<GotContact>().Property(item => item.Postalcode).HasColumnName("POSTALCODE");
            modelBuilder.Entity<GotContact>().Property(item => item.Modifytimestamp).HasColumnName("MODIFYTIMESTAMP");
            modelBuilder.Entity<GotCdComposant>().HasMany<GotCdEntete>(c => c.GotCdEntetes).WithRequired(t => t.GotCdComposant).HasForeignKey(u => new {u.GotCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdComposant>().ToTable("CD_COMPOSANT_GOT","GOT");
            modelBuilder.Entity<GotCdComposant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdComposant>().Property(item => item.TypeComp).IsRequired();
            modelBuilder.Entity<GotCdComposant>().Property(item => item.TypeComp).HasMaxLength(6);
            modelBuilder.Entity<GotCdComposant>().Property(item => item.TypeComp).HasColumnName("TYPE_COMP");
            modelBuilder.Entity<GotCdComposant>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<GotCdComposant>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotInspecteur>().HasRequired<GotCdPresta>(c => c.GotCdPresta).WithMany(t => t.GotInspecteurs).HasForeignKey(u => new { u.GotCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspecteur>().HasMany<GotInsp>(c => c.GotInsps).WithOptional(t => t.GotInspecteur).HasForeignKey(u => new {u.GotInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspecteur>().HasMany<GotVst>(c => c.GotVsts).WithOptional(t => t.GotInspecteur).HasForeignKey(u => new {u.GotInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspecteur>().HasMany<GotInspTmp>(c => c.GotInspTmps).WithOptional(t => t.GotInspecteur).HasForeignKey(u => new {u.GotInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspecteur>().ToTable("INSPECTEUR_GOT","GOT");
            modelBuilder.Entity<GotInspecteur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotInspecteur>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<GotInspecteur>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<GotInspecteur>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<GotInspecteur>().Property(item => item.CdPrestaGotPrestataire).IsRequired();
            modelBuilder.Entity<GotInspecteur>().Property(item => item.CdPrestaGotPrestataire).HasMaxLength(50);
            modelBuilder.Entity<GotInspecteur>().Property(item => item.CdPrestaGotPrestataire).HasColumnName("CD_PRESTA_GOT__PRESTATAIRE");
            modelBuilder.Entity<GotInspecteur>().Property(item => item.Fonc).HasMaxLength(60);
            modelBuilder.Entity<GotInspecteur>().Property(item => item.Fonc).HasColumnName("FONC");
            modelBuilder.Entity<GotCdUnite>().HasMany<GotBpu>(c => c.GotBpus).WithOptional(t => t.GotCdUnite).HasForeignKey(u => new {u.GotCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdUnite>().ToTable("CD_UNITE_GOT","GOT");
            modelBuilder.Entity<GotCdUnite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdUnite>().Property(item => item.Unite).IsRequired();
            modelBuilder.Entity<GotCdUnite>().Property(item => item.Unite).HasMaxLength(12);
            modelBuilder.Entity<GotCdUnite>().Property(item => item.Unite).HasColumnName("UNITE");
            modelBuilder.Entity<GotCdConclusion>().HasMany<GotCdConclusionInsp>(c => c.GotCdConclusionInsps).WithRequired(t => t.GotCdConclusion).HasForeignKey(u => new {u.GotCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdConclusion>().HasMany<GotCdConclusionInspTmp>(c => c.GotCdConclusionInspTmps).WithRequired(t => t.GotCdConclusion).HasForeignKey(u => new {u.GotCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdConclusion>().ToTable("CD_CONCLUSION_GOT","GOT");
            modelBuilder.Entity<GotCdConclusion>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdConclusion>().Property(item => item.IdConc).IsRequired();
            modelBuilder.Entity<GotCdConclusion>().Property(item => item.IdConc).HasColumnName("ID_CONC");
            modelBuilder.Entity<GotCdConclusion>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<GotCdConclusion>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<GotCdConclusion>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<GotCdConclusion>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<GotCdConclusion>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<GotDscTemp>().HasRequired<GotCdFam>(c => c.GotCdFam).WithMany(t => t.GotDscTemps).HasForeignKey(u => new { u.GotCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasOptional<GotCdType>(c => c.GotCdType).WithMany(t => t.GotDscTemps).HasForeignKey(u => new {u.GotCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasOptional<GotCdPente>(c => c.GotCdPente).WithMany(t => t.GotDscTemps).HasForeignKey(u => new {u.GotCdPenteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasOptional<GotCdEntp>(c => c.GotCdEntp).WithMany(t => t.GotDscTemps).HasForeignKey(u => new {u.GotCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasOptional<GotCdProtect>(c => c.GotCdProtect).WithMany(t => t.GotDscTemps).HasForeignKey(u => new {u.GotCdProtectIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasOptional<GotCdGeo>(c => c.GotCdGeo).WithMany(t => t.GotDscTemps).HasForeignKey(u => new {u.GotCdGeoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasRequired<GotCamp>(c => c.GotCamp).WithMany(t => t.GotDscTemps).HasForeignKey(u => new { u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasOptional<GotDsc>(c => c.GotDsc).WithMany(t => t.GotDscTemps).HasForeignKey(u => new {u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().HasMany<GotInspTmp>(c => c.GotInspTmps).WithRequired(t => t.GotDscTemp).HasForeignKey(u => new {u.GotDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscTemp>().ToTable("DSC_TEMP_GOT","GOT");
            modelBuilder.Entity<GotDscTemp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NumGot).IsRequired();
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NumGot).HasMaxLength(17);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NumGot).HasColumnName("NUM_GOT");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdEntpGotEntreprise).HasMaxLength(60);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdEntpGotEntreprise).HasColumnName("CD_ENTP_GOT__ENTREPRISE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdTypeGotType).HasMaxLength(20);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdTypeGotType).HasColumnName("CD_TYPE_GOT__TYPE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdPenteGotPente).HasMaxLength(25);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdPenteGotPente).HasColumnName("CD_PENTE_GOT__PENTE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdProtectGotType).HasMaxLength(60);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdProtectGotType).HasColumnName("CD_PROTECT_GOT__TYPE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdFamGotFamille).IsRequired();
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdFamGotFamille).HasMaxLength(20);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdFamGotFamille).HasColumnName("CD_FAM_GOT__FAMILLE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdGeoGotGeologie).HasMaxLength(60);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.CdGeoGotGeologie).HasColumnName("CD_GEO_GOT__GEOLOGIE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<GotDscTemp>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<GotDscTemp>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DateConst).HasColumnName("DATE_CONST");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.PenteTnValueInt).HasColumnName("PENTE_TN");
            modelBuilder.Entity<GotDscTemp>().Ignore(item => item.PenteTn);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Haut).HasColumnName("HAUT");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.LargCrete).HasColumnName("LARG_CRETE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Volume).HasColumnName("VOLUME");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.RisbNbr).HasColumnName("RISB_NBR");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.RisbEsp).HasColumnName("RISB_ESP");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.RisbLarg).HasColumnName("RISB_LARG");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.HautEau).HasColumnName("HAUT_EAU");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.InstableValueInt).HasColumnName("INSTABLE");
            modelBuilder.Entity<GotDscTemp>().Ignore(item => item.Instable);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NomUsage).HasMaxLength(255);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NomUsage).HasColumnName("NOM_USAGE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<GotDscTemp>().Ignore(item => item.Securite);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GotDscTemp>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<GotDscTemp>().Ignore(item => item.Terrain);
            modelBuilder.Entity<GotDscTemp>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<GotDscTemp>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<GotEltInspTmp>().HasRequired<GotInspTmp>(c => c.GotInspTmp).WithMany(t => t.GotEltInspTmps).HasForeignKey(u => new { u.GotInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEltInspTmp>().HasRequired<GotElt>(c => c.GotElt).WithMany(t => t.GotEltInspTmps).HasForeignKey(u => new { u.GotEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEltInspTmp>().HasMany<GotPhotoEltInspTmp>(c => c.GotPhotoEltInspTmps).WithRequired(t => t.GotEltInspTmp).HasForeignKey(u => new {u.GotEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotEltInspTmp>().ToTable("ELT_INSP_TMP_GOT","GOT");
            modelBuilder.Entity<GotEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.DscTempGotNumGot).IsRequired();
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.DscTempGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.DscTempGotNumGot).HasColumnName("DSC_TEMP_GOT__NUM_GOT");
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.GrpGotIdGrp).IsRequired();
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.GrpGotIdGrp).HasColumnName("GRP_GOT__ID_GRP");
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.PrtGotIdPrt).IsRequired();
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.PrtGotIdPrt).HasColumnName("PRT_GOT__ID_PRT");
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.SprtGotIdSprt).IsRequired();
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.SprtGotIdSprt).HasColumnName("SPRT_GOT__ID_SPRT");
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.EltGotIdElem).IsRequired();
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.EltGotIdElem).HasColumnName("ELT_GOT__ID_ELEM");
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<GotEltInspTmp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<GotPhotoEltInspTmp>().HasRequired<GotEltInspTmp>(c => c.GotEltInspTmp).WithMany(t => t.GotPhotoEltInspTmps).HasForeignKey(u => new { u.GotEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPhotoEltInspTmp>().ToTable("PHOTO_ELT_INSP_TMP_GOT","GOT");
            modelBuilder.Entity<GotPhotoEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.GrpGotIdGrp).IsRequired();
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.GrpGotIdGrp).HasColumnName("GRP_GOT__ID_GRP");
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.PrtGotIdPrt).IsRequired();
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.PrtGotIdPrt).HasColumnName("PRT_GOT__ID_PRT");
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.SprtGotIdSprt).IsRequired();
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.SprtGotIdSprt).HasColumnName("SPRT_GOT__ID_SPRT");
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.DscTempGotNumGot).IsRequired();
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.DscTempGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.DscTempGotNumGot).HasColumnName("DSC_TEMP_GOT__NUM_GOT");
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.EltGotIdElem).IsRequired();
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.EltGotIdElem).HasColumnName("ELT_GOT__ID_ELEM");
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoEltInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotInspTmp>().HasOptional<GotCdMeteo>(c => c.GotCdMeteo).WithMany(t => t.GotInspTmps).HasForeignKey(u => new {u.GotCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspTmp>().HasOptional<GotCdEtude>(c => c.GotCdEtude).WithMany(t => t.GotInspTmps).HasForeignKey(u => new {u.GotCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspTmp>().HasRequired<GotDscTemp>(c => c.GotDscTemp).WithMany(t => t.GotInspTmps).HasForeignKey(u => new { u.GotDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspTmp>().HasOptional<GotInspecteur>(c => c.GotInspecteur).WithMany(t => t.GotInspTmps).HasForeignKey(u => new {u.GotInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspTmp>().HasMany<GotEltInspTmp>(c => c.GotEltInspTmps).WithRequired(t => t.GotInspTmp).HasForeignKey(u => new {u.GotInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspTmp>().HasMany<GotPhotoInspTmp>(c => c.GotPhotoInspTmps).WithRequired(t => t.GotInspTmp).HasForeignKey(u => new {u.GotInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspTmp>().HasMany<GotCdConclusionInspTmp>(c => c.GotCdConclusionInspTmps).WithRequired(t => t.GotInspTmp).HasForeignKey(u => new {u.GotInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotInspTmp>().ToTable("INSP_TMP_GOT","GOT");
            modelBuilder.Entity<GotInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotInspTmp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotInspTmp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.DscTempGotNumGot).IsRequired();
            modelBuilder.Entity<GotInspTmp>().Property(item => item.DscTempGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.DscTempGotNumGot).HasColumnName("DSC_TEMP_GOT__NUM_GOT");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.CdMeteoGotMeteo).HasMaxLength(60);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.CdMeteoGotMeteo).HasColumnName("CD_METEO_GOT__METEO");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.CdEtudeGotEtude).HasMaxLength(65);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.CdEtudeGotEtude).HasColumnName("CD_ETUDE_GOT__ETUDE");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.InspecteurGotNom).HasMaxLength(60);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.InspecteurGotNom).HasColumnName("INSPECTEUR_GOT__NOM");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.NomValid).HasMaxLength(255);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<GotInspTmp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<GotPhotoInspTmp>().HasRequired<GotInspTmp>(c => c.GotInspTmp).WithMany(t => t.GotPhotoInspTmps).HasForeignKey(u => new { u.GotInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotPhotoInspTmp>().ToTable("PHOTO_INSP_TMP_GOT","GOT");
            modelBuilder.Entity<GotPhotoInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.DscTempGotNumGot).IsRequired();
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.DscTempGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.DscTempGotNumGot).HasColumnName("DSC_TEMP_GOT__NUM_GOT");
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<GotPhotoInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<GotClsDoc>().HasRequired<GotCls>(c => c.GotCls).WithMany(t => t.GotClsDocs).HasForeignKey(u => new { u.GotClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotClsDoc>().HasRequired<GotDoc>(c => c.GotDoc).WithMany(t => t.GotClsDocs).HasForeignKey(u => new { u.GotDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotClsDoc>().ToTable("CLS_DOC_GOT","GOT");
            modelBuilder.Entity<GotClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotClsDoc>().Property(item => item.ClsGotId).IsRequired();
            modelBuilder.Entity<GotClsDoc>().Property(item => item.ClsGotId).HasColumnName("CLS_GOT__ID");
            modelBuilder.Entity<GotClsDoc>().Property(item => item.DocGotId).IsRequired();
            modelBuilder.Entity<GotClsDoc>().Property(item => item.DocGotId).HasColumnName("DOC_GOT__ID");
            modelBuilder.Entity<GotClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<GotClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<GotClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<GotClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
            modelBuilder.Entity<GotCouche>().HasRequired<GotCdCouche>(c => c.GotCdCouche).WithMany(t => t.GotCouches).HasForeignKey(u => new { u.GotCdCoucheIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCouche>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotCouches).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCouche>().HasRequired<GotCdTraitement>(c => c.GotCdTraitement).WithMany(t => t.GotCouches).HasForeignKey(u => new { u.GotCdTraitementIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCouche>().HasRequired<GotCdHydrique>(c => c.GotCdHydrique).WithMany(t => t.GotCouches).HasForeignKey(u => new { u.GotCdHydriqueIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCouche>().HasRequired<GotCdMateriau>(c => c.GotCdMateriau).WithMany(t => t.GotCouches).HasForeignKey(u => new { u.GotCdMateriauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCouche>().HasRequired<GotCdCompactage>(c => c.GotCdCompactage).WithMany(t => t.GotCouches).HasForeignKey(u => new { u.GotCdCompactageIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCouche>().ToTable("COUCHE_GOT","GOT");
            modelBuilder.Entity<GotCouche>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCouche>().Property(item => item.CdCoucheGotCode).IsRequired();
            modelBuilder.Entity<GotCouche>().Property(item => item.CdCoucheGotCode).HasMaxLength(50);
            modelBuilder.Entity<GotCouche>().Property(item => item.CdCoucheGotCode).HasColumnName("CD_COUCHE_GOT__CODE");
            modelBuilder.Entity<GotCouche>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotCouche>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotCouche>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotCouche>().Property(item => item.CdTraitementGotType).IsRequired();
            modelBuilder.Entity<GotCouche>().Property(item => item.CdTraitementGotType).HasMaxLength(25);
            modelBuilder.Entity<GotCouche>().Property(item => item.CdTraitementGotType).HasColumnName("CD_TRAITEMENT_GOT__TYPE");
            modelBuilder.Entity<GotCouche>().Property(item => item.CdHydriqueGotEtat).IsRequired();
            modelBuilder.Entity<GotCouche>().Property(item => item.CdHydriqueGotEtat).HasMaxLength(25);
            modelBuilder.Entity<GotCouche>().Property(item => item.CdHydriqueGotEtat).HasColumnName("CD_HYDRIQUE_GOT__ETAT");
            modelBuilder.Entity<GotCouche>().Property(item => item.CdMateriauGotType).IsRequired();
            modelBuilder.Entity<GotCouche>().Property(item => item.CdMateriauGotType).HasMaxLength(60);
            modelBuilder.Entity<GotCouche>().Property(item => item.CdMateriauGotType).HasColumnName("CD_MATERIAU_GOT__TYPE");
            modelBuilder.Entity<GotCouche>().Property(item => item.CdCompactageGotCode).IsRequired();
            modelBuilder.Entity<GotCouche>().Property(item => item.CdCompactageGotCode).HasMaxLength(50);
            modelBuilder.Entity<GotCouche>().Property(item => item.CdCompactageGotCode).HasColumnName("CD_COMPACTAGE_GOT__CODE");
            modelBuilder.Entity<GotCouche>().Property(item => item.Epai).HasColumnName("EPAI");
            modelBuilder.Entity<GotCouche>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<GotCouche>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<GotDscCamp>().HasRequired<GotDsc>(c => c.GotDsc).WithMany(t => t.GotDscCamps).HasForeignKey(u => new { u.GotDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscCamp>().HasRequired<GotCamp>(c => c.GotCamp).WithMany(t => t.GotDscCamps).HasForeignKey(u => new { u.GotCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotDscCamp>().ToTable("DSC_CAMP_GOT","GOT");
            modelBuilder.Entity<GotDscCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotDscCamp>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotDscCamp>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotDscCamp>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotDscCamp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotDscCamp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotDscCamp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotDscCamp>().Property(item => item.RealiserValueInt).HasColumnName("REALISER");
            modelBuilder.Entity<GotDscCamp>().Ignore(item => item.Realiser);
            modelBuilder.Entity<GotCdPrecoSprtVst>().HasRequired<GotVst>(c => c.GotVst).WithMany(t => t.GotCdPrecoSprtVsts).HasForeignKey(u => new { u.GotVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdPrecoSprtVst>().HasRequired<GotBpu>(c => c.GotBpu).WithMany(t => t.GotCdPrecoSprtVsts).HasForeignKey(u => new { u.GotBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdPrecoSprtVst>().ToTable("CD_PRECO__SPRT_VST_GOT","GOT");
            modelBuilder.Entity<GotCdPrecoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.BpuGotIdBpu).IsRequired();
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.BpuGotIdBpu).HasColumnName("BPU_GOT__ID_BPU");
            modelBuilder.Entity<GotCdPrecoSprtVst>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<GotCdPrecoSprtVst>().Ignore(item => item.Realise);
            modelBuilder.Entity<GotCdConclusionInsp>().HasRequired<GotCdConclusion>(c => c.GotCdConclusion).WithMany(t => t.GotCdConclusionInsps).HasForeignKey(u => new { u.GotCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdConclusionInsp>().HasRequired<GotInsp>(c => c.GotInsp).WithMany(t => t.GotCdConclusionInsps).HasForeignKey(u => new { u.GotInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdConclusionInsp>().ToTable("CD_CONCLUSION__INSP_GOT","GOT");
            modelBuilder.Entity<GotCdConclusionInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.DscGotNumGot).IsRequired();
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.DscGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.DscGotNumGot).HasColumnName("DSC_GOT__NUM_GOT");
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.CdConclusionGotIdConc).IsRequired();
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.CdConclusionGotIdConc).HasColumnName("CD_CONCLUSION_GOT__ID_CONC");
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<GotCdConclusionInsp>().Property(item => item.Contenu).HasColumnName("CONTENU");
            modelBuilder.Entity<GotCdConclusionInspTmp>().HasRequired<GotCdConclusion>(c => c.GotCdConclusion).WithMany(t => t.GotCdConclusionInspTmps).HasForeignKey(u => new { u.GotCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdConclusionInspTmp>().HasRequired<GotInspTmp>(c => c.GotInspTmp).WithMany(t => t.GotCdConclusionInspTmps).HasForeignKey(u => new { u.GotInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<GotCdConclusionInspTmp>().ToTable("CD_CONCLUSION__INSP_TMP_GOT","GOT");
            modelBuilder.Entity<GotCdConclusionInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.CampGotIdCamp).IsRequired();
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.CampGotIdCamp).HasMaxLength(100);
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.CampGotIdCamp).HasColumnName("CAMP_GOT__ID_CAMP");
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.DscTempGotNumGot).IsRequired();
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.DscTempGotNumGot).HasMaxLength(17);
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.DscTempGotNumGot).HasColumnName("DSC_TEMP_GOT__NUM_GOT");
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.CdConclusionGotIdConc).IsRequired();
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.CdConclusionGotIdConc).HasColumnName("CD_CONCLUSION_GOT__ID_CONC");
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<GotCdConclusionInspTmp>().Property(item => item.Contenu).HasColumnName("CONTENU");
        }
    }
}
