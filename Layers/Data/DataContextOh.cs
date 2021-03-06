using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextOh : DataContextBase
    {
        public DataContextOh(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<OhCdType> OhCdTypes { get; set; }
        
        public DbSet<OhCdFam> OhCdFams { get; set; }
        
        public DbSet<OhCdEntp> OhCdEntps { get; set; }
        
        public DbSet<OhDsc> OhDscs { get; set; }
        
        public DbSet<OhCls> OhClss { get; set; }
        
        public DbSet<OhDoc> OhDocs { get; set; }
        
        public DbSet<OhCdDoc> OhCdDocs { get; set; }
        
        public DbSet<OhElt> OhElts { get; set; }
        
        public DbSet<OhSprt> OhSprts { get; set; }
        
        public DbSet<OhPrt> OhPrts { get; set; }
        
        public DbSet<OhGrp> OhGrps { get; set; }
        
        public DbSet<OhInsp> OhInsps { get; set; }
        
        public DbSet<OhEltInsp> OhEltInsps { get; set; }
        
        public DbSet<OhPhotoEltInsp> OhPhotoEltInsps { get; set; }
        
        public DbSet<OhCamp> OhCamps { get; set; }
        
        public DbSet<OhCdMeteo> OhCdMeteos { get; set; }
        
        public DbSet<OhCdPresta> OhCdPrestas { get; set; }
        
        public DbSet<OhTravaux> OhTravauxs { get; set; }
        
        public DbSet<OhNatureTrav> OhNatureTravs { get; set; }
        
        public DbSet<OhCdMat> OhCdMats { get; set; }
        
        public DbSet<OhCdExt> OhCdExts { get; set; }
        
        public DbSet<OhCdEau> OhCdEaus { get; set; }
        
        public DbSet<OhCdOuv> OhCdOuvs { get; set; }
        
        public DbSet<OhCdEcoul> OhCdEcouls { get; set; }
        
        public DbSet<OhCdProAv> OhCdProAvs { get; set; }
        
        public DbSet<OhSysUser> OhSysUsers { get; set; }
        
        public DbSet<OhCdProAm> OhCdProAms { get; set; }
        
        public DbSet<OhCdTypePv> OhCdTypePvs { get; set; }
        
        public DbSet<OhCdEtude> OhCdEtudes { get; set; }
        
        public DbSet<OhBpu> OhBpus { get; set; }
        
        public DbSet<OhCdContrainte> OhCdContraintes { get; set; }
        
        public DbSet<OhCdTravaux> OhCdTravauxs { get; set; }
        
        public DbSet<OhCdSousType> OhCdSousTypes { get; set; }
        
        public DbSet<OhSeuilQualite> OhSeuilQualites { get; set; }
        
        public DbSet<OhSeuilUrgence> OhSeuilUrgences { get; set; }
        
        public DbSet<OhPrevision> OhPrevisions { get; set; }
        
        public DbSet<OhVst> OhVsts { get; set; }
        
        public DbSet<OhSprtVst> OhSprtVsts { get; set; }
        
        public DbSet<OhPhotoSprtVst> OhPhotoSprtVsts { get; set; }
        
        public DbSet<OhPhotoVst> OhPhotoVsts { get; set; }
        
        public DbSet<OhPhotoInsp> OhPhotoInsps { get; set; }
        
        public DbSet<OhCdQualite> OhCdQualites { get; set; }
        
        public DbSet<OhCdNomEau> OhCdNomEaus { get; set; }
        
        public DbSet<OhHistoNote> OhHistoNotes { get; set; }
        
        public DbSet<OhCdOrigin> OhCdOrigins { get; set; }
        
        public DbSet<OhDictionnaire> OhDictionnaires { get; set; }
        
        public DbSet<OhCdEvt> OhCdEvts { get; set; }
        
        public DbSet<OhEvt> OhEvts { get; set; }
        
        public DbSet<OhCdTeteAm> OhCdTeteAms { get; set; }
        
        public DbSet<OhCdTeteAv> OhCdTeteAvs { get; set; }
        
        public DbSet<OhCdEntete> OhCdEntetes { get; set; }
        
        public DbSet<OhCdChapitre> OhCdChapitres { get; set; }
        
        public DbSet<OhCdLigne> OhCdLignes { get; set; }
        
        public DbSet<OhEntete> OhEntetes { get; set; }
        
        public DbSet<OhContact> OhContacts { get; set; }
        
        public DbSet<OhCdComposant> OhCdComposants { get; set; }
        
        public DbSet<OhInspecteur> OhInspecteurs { get; set; }
        
        public DbSet<OhCdUnite> OhCdUnites { get; set; }
        
        public DbSet<OhCdMo> OhCdMos { get; set; }
        
        public DbSet<OhCdConclusion> OhCdConclusions { get; set; }
        
        public DbSet<OhDscTemp> OhDscTemps { get; set; }
        
        public DbSet<OhInspTmp> OhInspTmps { get; set; }
        
        public DbSet<OhEltInspTmp> OhEltInspTmps { get; set; }
        
        public DbSet<OhPhotoEltInspTmp> OhPhotoEltInspTmps { get; set; }
        
        public DbSet<OhPhotoInspTmp> OhPhotoInspTmps { get; set; }
        
        public DbSet<OhClsDoc> OhClsDocs { get; set; }
        
        public DbSet<OhCdConclusionInsp> OhCdConclusionInsps { get; set; }
        
        public DbSet<OhDscCamp> OhDscCamps { get; set; }
        
        public DbSet<OhCdPrecoSprtVst> OhCdPrecoSprtVsts { get; set; }
        
        public DbSet<OhCdConclusionInspTmp> OhCdConclusionInspTmps { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<OhCdType>().HasMany<OhDsc>(c => c.OhDscs).WithRequired(t => t.OhCdType).HasForeignKey(u => new {u.OhCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdType>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithRequired(t => t.OhCdType).HasForeignKey(u => new {u.OhCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdType>().ToTable("CD_TYPE_OH","OH");
            modelBuilder.Entity<OhCdType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdType>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OhCdType>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<OhCdType>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OhCdFam>().HasMany<OhDsc>(c => c.OhDscs).WithRequired(t => t.OhCdFam).HasForeignKey(u => new {u.OhCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdFam>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithRequired(t => t.OhCdFam).HasForeignKey(u => new {u.OhCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdFam>().ToTable("CD_FAM_OH","OH");
            modelBuilder.Entity<OhCdFam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdFam>().Property(item => item.Famille).IsRequired();
            modelBuilder.Entity<OhCdFam>().Property(item => item.Famille).HasMaxLength(20);
            modelBuilder.Entity<OhCdFam>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<OhCdFam>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OhCdFam>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhCdEntp>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdEntp).HasForeignKey(u => new {u.OhCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEntp>().HasMany<OhTravaux>(c => c.OhTravauxs).WithRequired(t => t.OhCdEntp).HasForeignKey(u => new {u.OhCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEntp>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdEntp).HasForeignKey(u => new {u.OhCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEntp>().ToTable("CD_ENTP_OH","OH");
            modelBuilder.Entity<OhCdEntp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdEntp>().Property(item => item.Entreprise).IsRequired();
            modelBuilder.Entity<OhCdEntp>().Property(item => item.Entreprise).HasMaxLength(60);
            modelBuilder.Entity<OhCdEntp>().Property(item => item.Entreprise).HasColumnName("ENTREPRISE");
            modelBuilder.Entity<OhDsc>().HasRequired<OhCdFam>(c => c.OhCdFam).WithMany(t => t.OhDscs).HasForeignKey(u => new { u.OhCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdEntp>(c => c.OhCdEntp).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdMat>(c => c.OhCdMat).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdEau>(c => c.OhCdEau).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdOuv>(c => c.OhCdOuv).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdOuvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdEcoul>(c => c.OhCdEcoul).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdEcoulIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasRequired<OhCdType>(c => c.OhCdType).WithMany(t => t.OhDscs).HasForeignKey(u => new { u.OhCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdProAv>(c => c.OhCdProAv).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdProAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdProAm>(c => c.OhCdProAm).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdProAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdSousType>(c => c.OhCdSousType).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdExt>(c => c.OhCdExt).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdQualite>(c => c.OhCdQualite).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdNomEau>(c => c.OhCdNomEau).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdNomEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdTeteAm>(c => c.OhCdTeteAm).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdTeteAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdTeteAv>(c => c.OhCdTeteAv).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdTeteAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasOptional<OhCdMo>(c => c.OhCdMo).WithMany(t => t.OhDscs).HasForeignKey(u => new {u.OhCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhTravaux>(c => c.OhTravauxs).WithRequired(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhPrevision>(c => c.OhPrevisions).WithRequired(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhVst>(c => c.OhVsts).WithRequired(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhInsp>(c => c.OhInsps).WithRequired(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhHistoNote>(c => c.OhHistoNotes).WithRequired(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhEvt>(c => c.OhEvts).WithRequired(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().HasMany<OhDscCamp>(c => c.OhDscCamps).WithRequired(t => t.OhDsc).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDsc>().ToTable("DSC_OH","OH");
            modelBuilder.Entity<OhDsc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhDsc>().Property(item => item.NumOh).IsRequired();
            modelBuilder.Entity<OhDsc>().Property(item => item.NumOh).HasMaxLength(20);
            modelBuilder.Entity<OhDsc>().Property(item => item.NumOh).HasColumnName("NUM_OH");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdMatOhCode).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdMatOhCode).HasColumnName("CD_MAT_OH__CODE");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdTeteAvOhTeteAv).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdTeteAvOhTeteAv).HasColumnName("CD_TETE_AV_OH__TETE_AV");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdOuvOhOuv).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdOuvOhOuv).HasColumnName("CD_OUV_OH__OUV");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdEcoulOhEcoul).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdEcoulOhEcoul).HasColumnName("CD_ECOUL_OH__ECOUL");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdExtOhType).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdExtOhType).HasColumnName("CD_EXT_OH__TYPE");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdEauOhEau).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdEauOhEau).HasColumnName("CD_EAU_OH__EAU");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdEntpOhEntreprise).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdEntpOhEntreprise).HasColumnName("CD_ENTP_OH__ENTREPRISE");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdTypeOhType).IsRequired();
            modelBuilder.Entity<OhDsc>().Property(item => item.CdTypeOhType).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdTypeOhType).HasColumnName("CD_TYPE_OH__TYPE");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdProAvOhProtect).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdProAvOhProtect).HasColumnName("CD_PRO_AV_OH__PROTECT");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdQualiteOhQualite).HasMaxLength(25);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdQualiteOhQualite).HasColumnName("CD_QUALITE_OH__QUALITE");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdMoOhMo).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdMoOhMo).HasColumnName("CD_MO_OH__MO");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdTeteAmOhTeteAm).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdTeteAmOhTeteAm).HasColumnName("CD_TETE_AM_OH__TETE_AM");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdNomEauOhNom).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdNomEauOhNom).HasColumnName("CD_NOM_EAU_OH__NOM");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdSousTypeOhSousType).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdSousTypeOhSousType).HasColumnName("CD_SOUS_TYPE_OH__SOUS_TYPE");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdProAmOhProtect).HasMaxLength(60);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdProAmOhProtect).HasColumnName("CD_PRO_AM_OH__PROTECT");
            modelBuilder.Entity<OhDsc>().Property(item => item.CdFamOhFamille).IsRequired();
            modelBuilder.Entity<OhDsc>().Property(item => item.CdFamOhFamille).HasMaxLength(20);
            modelBuilder.Entity<OhDsc>().Property(item => item.CdFamOhFamille).HasColumnName("CD_FAM_OH__FAMILLE");
            modelBuilder.Entity<OhDsc>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<OhDsc>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<OhDsc>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<OhDsc>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<OhDsc>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<OhDsc>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<OhDsc>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<OhDsc>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<OhDsc>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<OhDsc>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<OhDsc>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<OhDsc>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<OhDsc>().Property(item => item.Longueur).HasColumnName("LONGUEUR");
            modelBuilder.Entity<OhDsc>().Property(item => item.Hauteur).HasColumnName("HAUTEUR");
            modelBuilder.Entity<OhDsc>().Property(item => item.Biais).HasColumnName("BIAIS");
            modelBuilder.Entity<OhDsc>().Property(item => item.Pente).HasColumnName("PENTE");
            modelBuilder.Entity<OhDsc>().Property(item => item.Portee).HasColumnName("PORTEE");
            modelBuilder.Entity<OhDsc>().Property(item => item.Jum).HasColumnName("JUM");
            modelBuilder.Entity<OhDsc>().Property(item => item.Elem).HasColumnName("ELEM");
            modelBuilder.Entity<OhDsc>().Property(item => item.Regard).HasColumnName("REGARD");
            modelBuilder.Entity<OhDsc>().Property(item => item.PercheValueInt).HasColumnName("PERCHE");
            modelBuilder.Entity<OhDsc>().Ignore(item => item.Perche);
            modelBuilder.Entity<OhDsc>().Property(item => item.VulnerableValueInt).HasColumnName("VULNERABLE");
            modelBuilder.Entity<OhDsc>().Ignore(item => item.Vulnerable);
            modelBuilder.Entity<OhDsc>().Property(item => item.FauneValueInt).HasColumnName("FAUNE");
            modelBuilder.Entity<OhDsc>().Ignore(item => item.Faune);
            modelBuilder.Entity<OhDsc>().Property(item => item.LoiValueInt).HasColumnName("LOI");
            modelBuilder.Entity<OhDsc>().Ignore(item => item.Loi);
            modelBuilder.Entity<OhDsc>().Property(item => item.Phe).HasColumnName("PHE");
            modelBuilder.Entity<OhDsc>().Property(item => item.Debit).HasColumnName("DEBIT");
            modelBuilder.Entity<OhDsc>().Property(item => item.OuvAval).HasMaxLength(200);
            modelBuilder.Entity<OhDsc>().Property(item => item.OuvAval).HasColumnName("OUV_AVAL");
            modelBuilder.Entity<OhDsc>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OhDsc>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OhDsc>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OhDsc>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<OhDsc>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<OhDsc>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OhDsc>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OhDsc>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OhDsc>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OhDsc>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<OhDsc>().Ignore(item => item.Securite);
            modelBuilder.Entity<OhDsc>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OhDsc>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OhDsc>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<OhDsc>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<OhDsc>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<OhDsc>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<OhDsc>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<OhDsc>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<OhDsc>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<OhDsc>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<OhDsc>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhDsc>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<OhDsc>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<OhDsc>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<OhDsc>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<OhDsc>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<OhDsc>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<OhDsc>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<OhDsc>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<OhDsc>().Ignore(item => item.Terrain);
            modelBuilder.Entity<OhCls>().HasMany<OhClsDoc>(c => c.OhClsDocs).WithRequired(t => t.OhCls).HasForeignKey(u => new {u.OhClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCls>().ToTable("CLS_OH","OH");
            modelBuilder.Entity<OhCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhCls>().Property(item => item.TableName).IsRequired();
            modelBuilder.Entity<OhCls>().Property(item => item.TableName).HasMaxLength(30);
            modelBuilder.Entity<OhCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<OhCls>().Property(item => item.KeyValue).IsRequired();
            modelBuilder.Entity<OhCls>().Property(item => item.KeyValue).HasMaxLength(500);
            modelBuilder.Entity<OhCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<OhDoc>().HasRequired<OhCdDoc>(c => c.OhCdDoc).WithMany(t => t.OhDocs).HasForeignKey(u => new { u.OhCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDoc>().HasMany<OhContact>(c => c.OhContacts).WithRequired(t => t.OhDoc).HasForeignKey(u => new {u.OhDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDoc>().HasMany<OhClsDoc>(c => c.OhClsDocs).WithRequired(t => t.OhDoc).HasForeignKey(u => new {u.OhDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDoc>().ToTable("DOC_OH","OH");
            modelBuilder.Entity<OhDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhDoc>().Property(item => item.CdDocOhCode).IsRequired();
            modelBuilder.Entity<OhDoc>().Property(item => item.CdDocOhCode).HasMaxLength(15);
            modelBuilder.Entity<OhDoc>().Property(item => item.CdDocOhCode).HasColumnName("CD_DOC_OH__CODE");
            modelBuilder.Entity<OhDoc>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<OhDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhDoc>().Property(item => item.Ref).IsRequired();
            modelBuilder.Entity<OhDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<OhDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<OhCdDoc>().HasMany<OhDoc>(c => c.OhDocs).WithRequired(t => t.OhCdDoc).HasForeignKey(u => new {u.OhCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdDoc>().ToTable("CD_DOC_OH","OH");
            modelBuilder.Entity<OhCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<OhCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<OhCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<OhCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OhCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<OhCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<OhElt>().HasRequired<OhSprt>(c => c.OhSprt).WithMany(t => t.OhElts).HasForeignKey(u => new { u.OhSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhElt>().HasMany<OhEltInsp>(c => c.OhEltInsps).WithRequired(t => t.OhElt).HasForeignKey(u => new {u.OhEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhElt>().HasMany<OhEltInspTmp>(c => c.OhEltInspTmps).WithRequired(t => t.OhElt).HasForeignKey(u => new {u.OhEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhElt>().ToTable("ELT_OH","OH");
            modelBuilder.Entity<OhElt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhElt>().Property(item => item.GrpOhIdGrp).IsRequired();
            modelBuilder.Entity<OhElt>().Property(item => item.GrpOhIdGrp).HasColumnName("GRP_OH__ID_GRP");
            modelBuilder.Entity<OhElt>().Property(item => item.PrtOhIdPrt).IsRequired();
            modelBuilder.Entity<OhElt>().Property(item => item.PrtOhIdPrt).HasColumnName("PRT_OH__ID_PRT");
            modelBuilder.Entity<OhElt>().Property(item => item.SprtOhIdSprt).IsRequired();
            modelBuilder.Entity<OhElt>().Property(item => item.SprtOhIdSprt).HasColumnName("SPRT_OH__ID_SPRT");
            modelBuilder.Entity<OhElt>().Property(item => item.IdElem).IsRequired();
            modelBuilder.Entity<OhElt>().Property(item => item.IdElem).HasColumnName("ID_ELEM");
            modelBuilder.Entity<OhElt>().Property(item => item.Libe).IsRequired();
            modelBuilder.Entity<OhElt>().Property(item => item.Libe).HasMaxLength(500);
            modelBuilder.Entity<OhElt>().Property(item => item.Libe).HasColumnName("LIBE");
            modelBuilder.Entity<OhElt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OhElt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OhElt>().Property(item => item.Aide).HasMaxLength(500);
            modelBuilder.Entity<OhElt>().Property(item => item.Aide).HasColumnName("AIDE");
            modelBuilder.Entity<OhElt>().Property(item => item.Indice1).HasMaxLength(500);
            modelBuilder.Entity<OhElt>().Property(item => item.Indice1).HasColumnName("INDICE1");
            modelBuilder.Entity<OhElt>().Property(item => item.Indice2).HasMaxLength(500);
            modelBuilder.Entity<OhElt>().Property(item => item.Indice2).HasColumnName("INDICE2");
            modelBuilder.Entity<OhElt>().Property(item => item.Indice3).HasMaxLength(500);
            modelBuilder.Entity<OhElt>().Property(item => item.Indice3).HasColumnName("INDICE3");
            modelBuilder.Entity<OhSprt>().HasRequired<OhPrt>(c => c.OhPrt).WithMany(t => t.OhSprts).HasForeignKey(u => new { u.OhPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhSprt>().HasMany<OhElt>(c => c.OhElts).WithRequired(t => t.OhSprt).HasForeignKey(u => new {u.OhSprtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhSprt>().ToTable("SPRT_OH","OH");
            modelBuilder.Entity<OhSprt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhSprt>().Property(item => item.GrpOhIdGrp).IsRequired();
            modelBuilder.Entity<OhSprt>().Property(item => item.GrpOhIdGrp).HasColumnName("GRP_OH__ID_GRP");
            modelBuilder.Entity<OhSprt>().Property(item => item.PrtOhIdPrt).IsRequired();
            modelBuilder.Entity<OhSprt>().Property(item => item.PrtOhIdPrt).HasColumnName("PRT_OH__ID_PRT");
            modelBuilder.Entity<OhSprt>().Property(item => item.IdSprt).IsRequired();
            modelBuilder.Entity<OhSprt>().Property(item => item.IdSprt).HasColumnName("ID_SPRT");
            modelBuilder.Entity<OhSprt>().Property(item => item.Libs).IsRequired();
            modelBuilder.Entity<OhSprt>().Property(item => item.Libs).HasMaxLength(500);
            modelBuilder.Entity<OhSprt>().Property(item => item.Libs).HasColumnName("LIBS");
            modelBuilder.Entity<OhSprt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OhSprt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OhPrt>().HasRequired<OhGrp>(c => c.OhGrp).WithMany(t => t.OhPrts).HasForeignKey(u => new { u.OhGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPrt>().HasMany<OhSprt>(c => c.OhSprts).WithRequired(t => t.OhPrt).HasForeignKey(u => new {u.OhPrtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPrt>().ToTable("PRT_OH","OH");
            modelBuilder.Entity<OhPrt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPrt>().Property(item => item.GrpOhIdGrp).IsRequired();
            modelBuilder.Entity<OhPrt>().Property(item => item.GrpOhIdGrp).HasColumnName("GRP_OH__ID_GRP");
            modelBuilder.Entity<OhPrt>().Property(item => item.IdPrt).IsRequired();
            modelBuilder.Entity<OhPrt>().Property(item => item.IdPrt).HasColumnName("ID_PRT");
            modelBuilder.Entity<OhPrt>().Property(item => item.Libp).IsRequired();
            modelBuilder.Entity<OhPrt>().Property(item => item.Libp).HasMaxLength(500);
            modelBuilder.Entity<OhPrt>().Property(item => item.Libp).HasColumnName("LIBP");
            modelBuilder.Entity<OhPrt>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OhPrt>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OhGrp>().HasMany<OhPrt>(c => c.OhPrts).WithRequired(t => t.OhGrp).HasForeignKey(u => new {u.OhGrpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhGrp>().ToTable("GRP_OH","OH");
            modelBuilder.Entity<OhGrp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhGrp>().Property(item => item.IdGrp).IsRequired();
            modelBuilder.Entity<OhGrp>().Property(item => item.IdGrp).HasColumnName("ID_GRP");
            modelBuilder.Entity<OhGrp>().Property(item => item.Libg).IsRequired();
            modelBuilder.Entity<OhGrp>().Property(item => item.Libg).HasMaxLength(500);
            modelBuilder.Entity<OhGrp>().Property(item => item.Libg).HasColumnName("LIBG");
            modelBuilder.Entity<OhGrp>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OhGrp>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OhInsp>().HasRequired<OhCamp>(c => c.OhCamp).WithMany(t => t.OhInsps).HasForeignKey(u => new { u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().HasOptional<OhCdEtude>(c => c.OhCdEtude).WithMany(t => t.OhInsps).HasForeignKey(u => new {u.OhCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().HasOptional<OhCdMeteo>(c => c.OhCdMeteo).WithMany(t => t.OhInsps).HasForeignKey(u => new {u.OhCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().HasRequired<OhDsc>(c => c.OhDsc).WithMany(t => t.OhInsps).HasForeignKey(u => new { u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().HasOptional<OhInspecteur>(c => c.OhInspecteur).WithMany(t => t.OhInsps).HasForeignKey(u => new {u.OhInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().HasMany<OhEltInsp>(c => c.OhEltInsps).WithRequired(t => t.OhInsp).HasForeignKey(u => new {u.OhInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().HasMany<OhPhotoInsp>(c => c.OhPhotoInsps).WithRequired(t => t.OhInsp).HasForeignKey(u => new {u.OhInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().HasMany<OhCdConclusionInsp>(c => c.OhCdConclusionInsps).WithRequired(t => t.OhInsp).HasForeignKey(u => new {u.OhInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInsp>().ToTable("INSP_OH","OH");
            modelBuilder.Entity<OhInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhInsp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhInsp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhInsp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhInsp>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhInsp>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhInsp>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhInsp>().Property(item => item.CdMeteoOhMeteo).HasMaxLength(60);
            modelBuilder.Entity<OhInsp>().Property(item => item.CdMeteoOhMeteo).HasColumnName("CD_METEO_OH__METEO");
            modelBuilder.Entity<OhInsp>().Property(item => item.InspecteurOhNom).HasMaxLength(60);
            modelBuilder.Entity<OhInsp>().Property(item => item.InspecteurOhNom).HasColumnName("INSPECTEUR_OH__NOM");
            modelBuilder.Entity<OhInsp>().Property(item => item.CdEtudeOhEtude).HasMaxLength(65);
            modelBuilder.Entity<OhInsp>().Property(item => item.CdEtudeOhEtude).HasColumnName("CD_ETUDE_OH__ETUDE");
            modelBuilder.Entity<OhInsp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<OhInsp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<OhInsp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<OhInsp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<OhInsp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<OhInsp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<OhInsp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<OhInsp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<OhInsp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<OhInsp>().Property(item => item.NomValid).HasMaxLength(250);
            modelBuilder.Entity<OhInsp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<OhInsp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<OhInsp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OhInsp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OhInsp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<OhInsp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OhInsp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<OhInsp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<OhInsp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OhInsp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OhInsp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OhInsp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<OhInsp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<OhInsp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OhInsp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OhInsp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<OhInsp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<OhEltInsp>().HasRequired<OhElt>(c => c.OhElt).WithMany(t => t.OhEltInsps).HasForeignKey(u => new { u.OhEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEltInsp>().HasRequired<OhInsp>(c => c.OhInsp).WithMany(t => t.OhEltInsps).HasForeignKey(u => new { u.OhInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEltInsp>().HasMany<OhPhotoEltInsp>(c => c.OhPhotoEltInsps).WithRequired(t => t.OhEltInsp).HasForeignKey(u => new {u.OhEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEltInsp>().ToTable("ELT_INSP_OH","OH");
            modelBuilder.Entity<OhEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhEltInsp>().Property(item => item.GrpOhIdGrp).IsRequired();
            modelBuilder.Entity<OhEltInsp>().Property(item => item.GrpOhIdGrp).HasColumnName("GRP_OH__ID_GRP");
            modelBuilder.Entity<OhEltInsp>().Property(item => item.PrtOhIdPrt).IsRequired();
            modelBuilder.Entity<OhEltInsp>().Property(item => item.PrtOhIdPrt).HasColumnName("PRT_OH__ID_PRT");
            modelBuilder.Entity<OhEltInsp>().Property(item => item.SprtOhIdSprt).IsRequired();
            modelBuilder.Entity<OhEltInsp>().Property(item => item.SprtOhIdSprt).HasColumnName("SPRT_OH__ID_SPRT");
            modelBuilder.Entity<OhEltInsp>().Property(item => item.EltOhIdElem).IsRequired();
            modelBuilder.Entity<OhEltInsp>().Property(item => item.EltOhIdElem).HasColumnName("ELT_OH__ID_ELEM");
            modelBuilder.Entity<OhEltInsp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhEltInsp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhEltInsp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhEltInsp>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhEltInsp>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhEltInsp>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhEltInsp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<OhEltInsp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OhEltInsp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<OhEltInsp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<OhPhotoEltInsp>().HasRequired<OhEltInsp>(c => c.OhEltInsp).WithMany(t => t.OhPhotoEltInsps).HasForeignKey(u => new { u.OhEltInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPhotoEltInsp>().ToTable("PHOTO_ELT_INSP_OH","OH");
            modelBuilder.Entity<OhPhotoEltInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.GrpOhIdGrp).IsRequired();
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.GrpOhIdGrp).HasColumnName("GRP_OH__ID_GRP");
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.PrtOhIdPrt).IsRequired();
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.PrtOhIdPrt).HasColumnName("PRT_OH__ID_PRT");
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.SprtOhIdSprt).IsRequired();
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.SprtOhIdSprt).HasColumnName("SPRT_OH__ID_SPRT");
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.EltOhIdElem).IsRequired();
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.EltOhIdElem).HasColumnName("ELT_OH__ID_ELEM");
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoEltInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhCamp>().HasRequired<OhCdPresta>(c => c.OhCdPresta).WithMany(t => t.OhCamps).HasForeignKey(u => new { u.OhCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCamp>().HasRequired<OhCdTypePv>(c => c.OhCdTypePv).WithMany(t => t.OhCamps).HasForeignKey(u => new { u.OhCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCamp>().HasMany<OhInsp>(c => c.OhInsps).WithRequired(t => t.OhCamp).HasForeignKey(u => new {u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCamp>().HasMany<OhVst>(c => c.OhVsts).WithRequired(t => t.OhCamp).HasForeignKey(u => new {u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCamp>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithRequired(t => t.OhCamp).HasForeignKey(u => new {u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCamp>().HasMany<OhDscCamp>(c => c.OhDscCamps).WithRequired(t => t.OhCamp).HasForeignKey(u => new {u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCamp>().ToTable("CAMP_OH","OH");
            modelBuilder.Entity<OhCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCamp>().Property(item => item.IdCamp).IsRequired();
            modelBuilder.Entity<OhCamp>().Property(item => item.IdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhCamp>().Property(item => item.IdCamp).HasColumnName("ID_CAMP");
            modelBuilder.Entity<OhCamp>().Property(item => item.CdPrestaOhPrestataire).IsRequired();
            modelBuilder.Entity<OhCamp>().Property(item => item.CdPrestaOhPrestataire).HasMaxLength(50);
            modelBuilder.Entity<OhCamp>().Property(item => item.CdPrestaOhPrestataire).HasColumnName("CD_PRESTA_OH__PRESTATAIRE");
            modelBuilder.Entity<OhCamp>().Property(item => item.CdTypePvOhCode).IsRequired();
            modelBuilder.Entity<OhCamp>().Property(item => item.CdTypePvOhCode).HasMaxLength(15);
            modelBuilder.Entity<OhCamp>().Property(item => item.CdTypePvOhCode).HasColumnName("CD_TYPE_PV_OH__CODE");
            modelBuilder.Entity<OhCamp>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<OhCamp>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<OhCamp>().Property(item => item.Dater).IsRequired();
            modelBuilder.Entity<OhCamp>().Property(item => item.Dater).HasColumnName("DATER");
            modelBuilder.Entity<OhCamp>().Property(item => item.Dateg).HasColumnName("DATEG");
            modelBuilder.Entity<OhCamp>().Property(item => item.Userg).HasMaxLength(250);
            modelBuilder.Entity<OhCamp>().Property(item => item.Userg).HasColumnName("USERG");
            modelBuilder.Entity<OhCamp>().Property(item => item.Observ).HasMaxLength(500);
            modelBuilder.Entity<OhCamp>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<OhCdMeteo>().HasMany<OhInsp>(c => c.OhInsps).WithOptional(t => t.OhCdMeteo).HasForeignKey(u => new {u.OhCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdMeteo>().HasMany<OhInspTmp>(c => c.OhInspTmps).WithOptional(t => t.OhCdMeteo).HasForeignKey(u => new {u.OhCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdMeteo>().ToTable("CD_METEO_OH","OH");
            modelBuilder.Entity<OhCdMeteo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdMeteo>().Property(item => item.Meteo).IsRequired();
            modelBuilder.Entity<OhCdMeteo>().Property(item => item.Meteo).HasMaxLength(60);
            modelBuilder.Entity<OhCdMeteo>().Property(item => item.Meteo).HasColumnName("METEO");
            modelBuilder.Entity<OhCdPresta>().HasMany<OhCamp>(c => c.OhCamps).WithRequired(t => t.OhCdPresta).HasForeignKey(u => new {u.OhCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdPresta>().HasMany<OhInspecteur>(c => c.OhInspecteurs).WithRequired(t => t.OhCdPresta).HasForeignKey(u => new {u.OhCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdPresta>().ToTable("CD_PRESTA_OH","OH");
            modelBuilder.Entity<OhCdPresta>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdPresta>().Property(item => item.Prestataire).IsRequired();
            modelBuilder.Entity<OhCdPresta>().Property(item => item.Prestataire).HasMaxLength(50);
            modelBuilder.Entity<OhCdPresta>().Property(item => item.Prestataire).HasColumnName("PRESTATAIRE");
            modelBuilder.Entity<OhTravaux>().HasRequired<OhDsc>(c => c.OhDsc).WithMany(t => t.OhTravauxs).HasForeignKey(u => new { u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhTravaux>().HasRequired<OhNatureTrav>(c => c.OhNatureTrav).WithMany(t => t.OhTravauxs).HasForeignKey(u => new { u.OhNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhTravaux>().HasRequired<OhCdEntp>(c => c.OhCdEntp).WithMany(t => t.OhTravauxs).HasForeignKey(u => new { u.OhCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhTravaux>().ToTable("TRAVAUX_OH","OH");
            modelBuilder.Entity<OhTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhTravaux>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhTravaux>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhTravaux>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhTravaux>().Property(item => item.CdTravauxOhCode).IsRequired();
            modelBuilder.Entity<OhTravaux>().Property(item => item.CdTravauxOhCode).HasMaxLength(60);
            modelBuilder.Entity<OhTravaux>().Property(item => item.CdTravauxOhCode).HasColumnName("CD_TRAVAUX_OH__CODE");
            modelBuilder.Entity<OhTravaux>().Property(item => item.NatureTravOhNature).IsRequired();
            modelBuilder.Entity<OhTravaux>().Property(item => item.NatureTravOhNature).HasMaxLength(100);
            modelBuilder.Entity<OhTravaux>().Property(item => item.NatureTravOhNature).HasColumnName("NATURE_TRAV_OH__NATURE");
            modelBuilder.Entity<OhTravaux>().Property(item => item.DateRcp).IsRequired();
            modelBuilder.Entity<OhTravaux>().Property(item => item.DateRcp).HasColumnName("DATE_RCP");
            modelBuilder.Entity<OhTravaux>().Property(item => item.CdEntpOhEntreprise).IsRequired();
            modelBuilder.Entity<OhTravaux>().Property(item => item.CdEntpOhEntreprise).HasMaxLength(60);
            modelBuilder.Entity<OhTravaux>().Property(item => item.CdEntpOhEntreprise).HasColumnName("CD_ENTP_OH__ENTREPRISE");
            modelBuilder.Entity<OhTravaux>().Property(item => item.DateFinGar).HasColumnName("DATE_FIN_GAR");
            modelBuilder.Entity<OhTravaux>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<OhTravaux>().Property(item => item.Marche).HasMaxLength(25);
            modelBuilder.Entity<OhTravaux>().Property(item => item.Marche).HasColumnName("MARCHE");
            modelBuilder.Entity<OhTravaux>().Property(item => item.Commentaire).HasMaxLength(500);
            modelBuilder.Entity<OhTravaux>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhNatureTrav>().HasRequired<OhCdTravaux>(c => c.OhCdTravaux).WithMany(t => t.OhNatureTravs).HasForeignKey(u => new { u.OhCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhNatureTrav>().HasMany<OhTravaux>(c => c.OhTravauxs).WithRequired(t => t.OhNatureTrav).HasForeignKey(u => new {u.OhNatureTravIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhNatureTrav>().ToTable("NATURE_TRAV_OH","OH");
            modelBuilder.Entity<OhNatureTrav>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhNatureTrav>().Property(item => item.CdTravauxOhCode).IsRequired();
            modelBuilder.Entity<OhNatureTrav>().Property(item => item.CdTravauxOhCode).HasMaxLength(60);
            modelBuilder.Entity<OhNatureTrav>().Property(item => item.CdTravauxOhCode).HasColumnName("CD_TRAVAUX_OH__CODE");
            modelBuilder.Entity<OhNatureTrav>().Property(item => item.Nature).IsRequired();
            modelBuilder.Entity<OhNatureTrav>().Property(item => item.Nature).HasMaxLength(100);
            modelBuilder.Entity<OhNatureTrav>().Property(item => item.Nature).HasColumnName("NATURE");
            modelBuilder.Entity<OhCdMat>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdMat).HasForeignKey(u => new {u.OhCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdMat>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdMat).HasForeignKey(u => new {u.OhCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdMat>().ToTable("CD_MAT_OH","OH");
            modelBuilder.Entity<OhCdMat>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdMat>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<OhCdMat>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<OhCdMat>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<OhCdExt>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdExt).HasForeignKey(u => new {u.OhCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdExt>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdExt).HasForeignKey(u => new {u.OhCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdExt>().ToTable("CD_EXT_OH","OH");
            modelBuilder.Entity<OhCdExt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdExt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OhCdExt>().Property(item => item.Type).HasMaxLength(60);
            modelBuilder.Entity<OhCdExt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OhCdExt>().Property(item => item.IsOhValueInt).IsRequired();
            modelBuilder.Entity<OhCdExt>().Property(item => item.IsOhValueInt).HasColumnName("IS_OH");
            modelBuilder.Entity<OhCdExt>().Ignore(item => item.IsOh);
            modelBuilder.Entity<OhCdExt>().Property(item => item.IsBsnValueInt).IsRequired();
            modelBuilder.Entity<OhCdExt>().Property(item => item.IsBsnValueInt).HasColumnName("IS_BSN");
            modelBuilder.Entity<OhCdExt>().Ignore(item => item.IsBsn);
            modelBuilder.Entity<OhCdEau>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdEau).HasForeignKey(u => new {u.OhCdEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEau>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdEau).HasForeignKey(u => new {u.OhCdEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEau>().ToTable("CD_EAU_OH","OH");
            modelBuilder.Entity<OhCdEau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdEau>().Property(item => item.Eau).IsRequired();
            modelBuilder.Entity<OhCdEau>().Property(item => item.Eau).HasMaxLength(60);
            modelBuilder.Entity<OhCdEau>().Property(item => item.Eau).HasColumnName("EAU");
            modelBuilder.Entity<OhCdOuv>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdOuv).HasForeignKey(u => new {u.OhCdOuvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdOuv>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdOuv).HasForeignKey(u => new {u.OhCdOuvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdOuv>().ToTable("CD_OUV_OH","OH");
            modelBuilder.Entity<OhCdOuv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdOuv>().Property(item => item.Ouv).IsRequired();
            modelBuilder.Entity<OhCdOuv>().Property(item => item.Ouv).HasMaxLength(60);
            modelBuilder.Entity<OhCdOuv>().Property(item => item.Ouv).HasColumnName("OUV");
            modelBuilder.Entity<OhCdEcoul>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdEcoul).HasForeignKey(u => new {u.OhCdEcoulIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEcoul>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdEcoul).HasForeignKey(u => new {u.OhCdEcoulIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEcoul>().ToTable("CD_ECOUL_OH","OH");
            modelBuilder.Entity<OhCdEcoul>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdEcoul>().Property(item => item.Ecoul).IsRequired();
            modelBuilder.Entity<OhCdEcoul>().Property(item => item.Ecoul).HasMaxLength(60);
            modelBuilder.Entity<OhCdEcoul>().Property(item => item.Ecoul).HasColumnName("ECOUL");
            modelBuilder.Entity<OhCdProAv>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdProAv).HasForeignKey(u => new {u.OhCdProAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdProAv>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdProAv).HasForeignKey(u => new {u.OhCdProAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdProAv>().ToTable("CD_PRO_AV_OH","OH");
            modelBuilder.Entity<OhCdProAv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdProAv>().Property(item => item.Protect).IsRequired();
            modelBuilder.Entity<OhCdProAv>().Property(item => item.Protect).HasMaxLength(60);
            modelBuilder.Entity<OhCdProAv>().Property(item => item.Protect).HasColumnName("PROTECT");
            modelBuilder.Entity<OhSysUser>().ToTable("SYS_USER_OH","OH");
            modelBuilder.Entity<OhSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<OhSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<OhSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<OhSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<OhSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<OhSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<OhSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<OhSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<OhCdProAm>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdProAm).HasForeignKey(u => new {u.OhCdProAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdProAm>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdProAm).HasForeignKey(u => new {u.OhCdProAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdProAm>().ToTable("CD_PRO_AM_OH","OH");
            modelBuilder.Entity<OhCdProAm>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdProAm>().Property(item => item.Protect).IsRequired();
            modelBuilder.Entity<OhCdProAm>().Property(item => item.Protect).HasMaxLength(60);
            modelBuilder.Entity<OhCdProAm>().Property(item => item.Protect).HasColumnName("PROTECT");
            modelBuilder.Entity<OhCdTypePv>().HasMany<OhCamp>(c => c.OhCamps).WithRequired(t => t.OhCdTypePv).HasForeignKey(u => new {u.OhCdTypePvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdTypePv>().ToTable("CD_TYPE_PV_OH","OH");
            modelBuilder.Entity<OhCdTypePv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Cycle).HasColumnName("CYCLE");
            modelBuilder.Entity<OhCdTypePv>().Property(item => item.Cout).HasColumnName("COUT");
            modelBuilder.Entity<OhCdEtude>().HasMany<OhInsp>(c => c.OhInsps).WithOptional(t => t.OhCdEtude).HasForeignKey(u => new {u.OhCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEtude>().HasMany<OhInspTmp>(c => c.OhInspTmps).WithOptional(t => t.OhCdEtude).HasForeignKey(u => new {u.OhCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEtude>().ToTable("CD_ETUDE_OH","OH");
            modelBuilder.Entity<OhCdEtude>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdEtude>().Property(item => item.Etude).IsRequired();
            modelBuilder.Entity<OhCdEtude>().Property(item => item.Etude).HasMaxLength(65);
            modelBuilder.Entity<OhCdEtude>().Property(item => item.Etude).HasColumnName("ETUDE");
            modelBuilder.Entity<OhBpu>().HasRequired<OhCdTravaux>(c => c.OhCdTravaux).WithMany(t => t.OhBpus).HasForeignKey(u => new { u.OhCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhBpu>().HasOptional<OhCdUnite>(c => c.OhCdUnite).WithMany(t => t.OhBpus).HasForeignKey(u => new {u.OhCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhBpu>().HasMany<OhPrevision>(c => c.OhPrevisions).WithRequired(t => t.OhBpu).HasForeignKey(u => new {u.OhBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhBpu>().HasMany<OhCdPrecoSprtVst>(c => c.OhCdPrecoSprtVsts).WithRequired(t => t.OhBpu).HasForeignKey(u => new {u.OhBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhBpu>().ToTable("BPU_OH","OH");
            modelBuilder.Entity<OhBpu>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhBpu>().Property(item => item.IdBpu).IsRequired();
            modelBuilder.Entity<OhBpu>().Property(item => item.IdBpu).HasColumnName("ID_BPU");
            modelBuilder.Entity<OhBpu>().Property(item => item.CdUniteOhUnite).HasMaxLength(12);
            modelBuilder.Entity<OhBpu>().Property(item => item.CdUniteOhUnite).HasColumnName("CD_UNITE_OH__UNITE");
            modelBuilder.Entity<OhBpu>().Property(item => item.CdTravauxOhCode).IsRequired();
            modelBuilder.Entity<OhBpu>().Property(item => item.CdTravauxOhCode).HasMaxLength(60);
            modelBuilder.Entity<OhBpu>().Property(item => item.CdTravauxOhCode).HasColumnName("CD_TRAVAUX_OH__CODE");
            modelBuilder.Entity<OhBpu>().Property(item => item.Techn).IsRequired();
            modelBuilder.Entity<OhBpu>().Property(item => item.Techn).HasMaxLength(255);
            modelBuilder.Entity<OhBpu>().Property(item => item.Techn).HasColumnName("TECHN");
            modelBuilder.Entity<OhBpu>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<OhBpu>().Property(item => item.DateMaj).HasColumnName("DATE_MAJ");
            modelBuilder.Entity<OhBpu>().Property(item => item.Freq).HasColumnName("FREQ");
            modelBuilder.Entity<OhBpu>().Property(item => item.PrecoVstValueInt).HasColumnName("PRECO_VST");
            modelBuilder.Entity<OhBpu>().Ignore(item => item.PrecoVst);
            modelBuilder.Entity<OhBpu>().Property(item => item.RealisVstValueInt).HasColumnName("REALIS_VST");
            modelBuilder.Entity<OhBpu>().Ignore(item => item.RealisVst);
            modelBuilder.Entity<OhCdContrainte>().HasMany<OhPrevision>(c => c.OhPrevisions).WithOptional(t => t.OhCdContrainte).HasForeignKey(u => new {u.OhCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdContrainte>().ToTable("CD_CONTRAINTE_OH","OH");
            modelBuilder.Entity<OhCdContrainte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdContrainte>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OhCdContrainte>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<OhCdContrainte>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OhCdTravaux>().HasMany<OhNatureTrav>(c => c.OhNatureTravs).WithRequired(t => t.OhCdTravaux).HasForeignKey(u => new {u.OhCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdTravaux>().HasMany<OhBpu>(c => c.OhBpus).WithRequired(t => t.OhCdTravaux).HasForeignKey(u => new {u.OhCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdTravaux>().ToTable("CD_TRAVAUX_OH","OH");
            modelBuilder.Entity<OhCdTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdTravaux>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<OhCdTravaux>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<OhCdTravaux>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<OhCdSousType>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdSousType).HasForeignKey(u => new {u.OhCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdSousType>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdSousType).HasForeignKey(u => new {u.OhCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdSousType>().ToTable("CD_SOUS_TYPE_OH","OH");
            modelBuilder.Entity<OhCdSousType>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdSousType>().Property(item => item.SousType).IsRequired();
            modelBuilder.Entity<OhCdSousType>().Property(item => item.SousType).HasMaxLength(60);
            modelBuilder.Entity<OhCdSousType>().Property(item => item.SousType).HasColumnName("SOUS_TYPE");
            modelBuilder.Entity<OhSeuilQualite>().HasRequired<OhCdQualite>(c => c.OhCdQualite).WithMany(t => t.OhSeuilQualites).HasForeignKey(u => new { u.OhCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhSeuilQualite>().ToTable("SEUIL_QUALITE_OH","OH");
            modelBuilder.Entity<OhSeuilQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhSeuilQualite>().Property(item => item.CdQualiteOhQualite).IsRequired();
            modelBuilder.Entity<OhSeuilQualite>().Property(item => item.CdQualiteOhQualite).HasMaxLength(25);
            modelBuilder.Entity<OhSeuilQualite>().Property(item => item.CdQualiteOhQualite).HasColumnName("CD_QUALITE_OH__QUALITE");
            modelBuilder.Entity<OhSeuilQualite>().Property(item => item.IndiceUrgence).IsRequired();
            modelBuilder.Entity<OhSeuilQualite>().Property(item => item.IndiceUrgence).HasMaxLength(5);
            modelBuilder.Entity<OhSeuilQualite>().Property(item => item.IndiceUrgence).HasColumnName("INDICE_URGENCE");
            modelBuilder.Entity<OhSeuilUrgence>().ToTable("SEUIL_URGENCE_OH","OH");
            modelBuilder.Entity<OhSeuilUrgence>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhSeuilUrgence>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OhSeuilUrgence>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OhSeuilUrgence>().Property(item => item.NbrNote).HasColumnName("NBR_NOTE");
            modelBuilder.Entity<OhSeuilUrgence>().Property(item => item.ValNote).HasColumnName("VAL_NOTE");
            modelBuilder.Entity<OhSeuilUrgence>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OhPrevision>().HasRequired<OhDsc>(c => c.OhDsc).WithMany(t => t.OhPrevisions).HasForeignKey(u => new { u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPrevision>().HasRequired<OhBpu>(c => c.OhBpu).WithMany(t => t.OhPrevisions).HasForeignKey(u => new { u.OhBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPrevision>().HasOptional<OhCdContrainte>(c => c.OhCdContrainte).WithMany(t => t.OhPrevisions).HasForeignKey(u => new {u.OhCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPrevision>().ToTable("PREVISION_OH","OH");
            modelBuilder.Entity<OhPrevision>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPrevision>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhPrevision>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhPrevision>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhPrevision>().Property(item => item.BpuOhIdBpu).IsRequired();
            modelBuilder.Entity<OhPrevision>().Property(item => item.BpuOhIdBpu).HasColumnName("BPU_OH__ID_BPU");
            modelBuilder.Entity<OhPrevision>().Property(item => item.DateDebut).IsRequired();
            modelBuilder.Entity<OhPrevision>().Property(item => item.DateDebut).HasColumnName("DATE_DEBUT");
            modelBuilder.Entity<OhPrevision>().Property(item => item.CdContrainteOhType).HasMaxLength(100);
            modelBuilder.Entity<OhPrevision>().Property(item => item.CdContrainteOhType).HasColumnName("CD_CONTRAINTE_OH__TYPE");
            modelBuilder.Entity<OhPrevision>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<OhPrevision>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<OhPrevision>().Property(item => item.DateDemPub).HasColumnName("DATE_DEM_PUB");
            modelBuilder.Entity<OhPrevision>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<OhPrevision>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhPrevision>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<OhPrevision>().Ignore(item => item.Realise);
            modelBuilder.Entity<OhVst>().HasRequired<OhCamp>(c => c.OhCamp).WithMany(t => t.OhVsts).HasForeignKey(u => new { u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhVst>().HasRequired<OhDsc>(c => c.OhDsc).WithMany(t => t.OhVsts).HasForeignKey(u => new { u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhVst>().HasOptional<OhInspecteur>(c => c.OhInspecteur).WithMany(t => t.OhVsts).HasForeignKey(u => new {u.OhInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhVst>().HasMany<OhSprtVst>(c => c.OhSprtVsts).WithRequired(t => t.OhVst).HasForeignKey(u => new {u.OhVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhVst>().HasMany<OhPhotoVst>(c => c.OhPhotoVsts).WithRequired(t => t.OhVst).HasForeignKey(u => new {u.OhVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhVst>().HasMany<OhEntete>(c => c.OhEntetes).WithRequired(t => t.OhVst).HasForeignKey(u => new {u.OhVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhVst>().ToTable("VST_OH","OH");
            modelBuilder.Entity<OhVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhVst>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhVst>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhVst>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhVst>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhVst>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhVst>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhVst>().Property(item => item.InspecteurOhNom).HasMaxLength(60);
            modelBuilder.Entity<OhVst>().Property(item => item.InspecteurOhNom).HasColumnName("INSPECTEUR_OH__NOM");
            modelBuilder.Entity<OhVst>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<OhVst>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<OhVst>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<OhVst>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<OhVst>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OhVst>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OhVst>().Property(item => item.Observ).HasMaxLength(500);
            modelBuilder.Entity<OhVst>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<OhVst>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<OhVst>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<OhSprtVst>().HasRequired<OhVst>(c => c.OhVst).WithMany(t => t.OhSprtVsts).HasForeignKey(u => new { u.OhVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhSprtVst>().HasRequired<OhCdLigne>(c => c.OhCdLigne).WithMany(t => t.OhSprtVsts).HasForeignKey(u => new { u.OhCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhSprtVst>().HasMany<OhPhotoSprtVst>(c => c.OhPhotoSprtVsts).WithRequired(t => t.OhSprtVst).HasForeignKey(u => new {u.OhSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhSprtVst>().HasMany<OhCdPrecoSprtVst>(c => c.OhCdPrecoSprtVsts).WithRequired(t => t.OhSprtVst).HasForeignKey(u => new {u.OhSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhSprtVst>().ToTable("SPRT_VST_OH","OH");
            modelBuilder.Entity<OhSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhSprtVst>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhSprtVst>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhSprtVst>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhSprtVst>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhSprtVst>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhSprtVst>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhSprtVst>().Property(item => item.CdChapitreOhIdChap).IsRequired();
            modelBuilder.Entity<OhSprtVst>().Property(item => item.CdChapitreOhIdChap).HasColumnName("CD_CHAPITRE_OH__ID_CHAP");
            modelBuilder.Entity<OhSprtVst>().Property(item => item.CdLigneOhIdLigne).IsRequired();
            modelBuilder.Entity<OhSprtVst>().Property(item => item.CdLigneOhIdLigne).HasColumnName("CD_LIGNE_OH__ID_LIGNE");
            modelBuilder.Entity<OhSprtVst>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<OhSprtVst>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OhSprtVst>().Property(item => item.Obs).HasMaxLength(500);
            modelBuilder.Entity<OhSprtVst>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<OhPhotoSprtVst>().HasRequired<OhSprtVst>(c => c.OhSprtVst).WithMany(t => t.OhPhotoSprtVsts).HasForeignKey(u => new { u.OhSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPhotoSprtVst>().ToTable("PHOTO_SPRT_VST_OH","OH");
            modelBuilder.Entity<OhPhotoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.CdChapitreOhIdChap).IsRequired();
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.CdChapitreOhIdChap).HasColumnName("CD_CHAPITRE_OH__ID_CHAP");
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.CdLigneOhIdLigne).IsRequired();
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.CdLigneOhIdLigne).HasColumnName("CD_LIGNE_OH__ID_LIGNE");
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoSprtVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhPhotoVst>().HasRequired<OhVst>(c => c.OhVst).WithMany(t => t.OhPhotoVsts).HasForeignKey(u => new { u.OhVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPhotoVst>().ToTable("PHOTO_VST_OH","OH");
            modelBuilder.Entity<OhPhotoVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoVst>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhPhotoInsp>().HasRequired<OhInsp>(c => c.OhInsp).WithMany(t => t.OhPhotoInsps).HasForeignKey(u => new { u.OhInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPhotoInsp>().ToTable("PHOTO_INSP_OH","OH");
            modelBuilder.Entity<OhPhotoInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoInsp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhCdQualite>().HasMany<OhSeuilQualite>(c => c.OhSeuilQualites).WithRequired(t => t.OhCdQualite).HasForeignKey(u => new {u.OhCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdQualite>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdQualite).HasForeignKey(u => new {u.OhCdQualiteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdQualite>().ToTable("CD_QUALITE_OH","OH");
            modelBuilder.Entity<OhCdQualite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdQualite>().Property(item => item.Qualite).IsRequired();
            modelBuilder.Entity<OhCdQualite>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<OhCdQualite>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<OhCdNomEau>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdNomEau).HasForeignKey(u => new {u.OhCdNomEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdNomEau>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdNomEau).HasForeignKey(u => new {u.OhCdNomEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdNomEau>().ToTable("CD_NOM_EAU_OH","OH");
            modelBuilder.Entity<OhCdNomEau>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdNomEau>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<OhCdNomEau>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<OhCdNomEau>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<OhHistoNote>().HasRequired<OhDsc>(c => c.OhDsc).WithMany(t => t.OhHistoNotes).HasForeignKey(u => new { u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhHistoNote>().HasRequired<OhCdOrigin>(c => c.OhCdOrigin).WithMany(t => t.OhHistoNotes).HasForeignKey(u => new { u.OhCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhHistoNote>().ToTable("HISTO_NOTE_OH","OH");
            modelBuilder.Entity<OhHistoNote>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhHistoNote>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhHistoNote>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhHistoNote>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.DateNote).IsRequired();
            modelBuilder.Entity<OhHistoNote>().Property(item => item.DateNote).HasColumnName("DATE_NOTE");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.CdOriginOhOrigine).IsRequired();
            modelBuilder.Entity<OhHistoNote>().Property(item => item.CdOriginOhOrigine).HasMaxLength(20);
            modelBuilder.Entity<OhHistoNote>().Property(item => item.CdOriginOhOrigine).HasColumnName("CD_ORIGIN_OH__ORIGINE");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OhHistoNote>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OhHistoNote>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<OhHistoNote>().Ignore(item => item.Securite);
            modelBuilder.Entity<OhHistoNote>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OhHistoNote>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OhCdOrigin>().HasMany<OhHistoNote>(c => c.OhHistoNotes).WithRequired(t => t.OhCdOrigin).HasForeignKey(u => new {u.OhCdOriginIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdOrigin>().ToTable("CD_ORIGIN_OH","OH");
            modelBuilder.Entity<OhCdOrigin>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdOrigin>().Property(item => item.Origine).IsRequired();
            modelBuilder.Entity<OhCdOrigin>().Property(item => item.Origine).HasMaxLength(20);
            modelBuilder.Entity<OhCdOrigin>().Property(item => item.Origine).HasColumnName("ORIGINE");
            modelBuilder.Entity<OhDictionnaire>().ToTable("DICTIONNAIRE_OH","OH");
            modelBuilder.Entity<OhDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Definition).HasMaxLength(500);
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Definition).HasColumnName("DEFINITION");
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<OhDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<OhCdEvt>().HasMany<OhEvt>(c => c.OhEvts).WithRequired(t => t.OhCdEvt).HasForeignKey(u => new {u.OhCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEvt>().ToTable("CD_EVT_OH","OH");
            modelBuilder.Entity<OhCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<OhCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<OhCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<OhCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<OhCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<OhEvt>().HasRequired<OhCdEvt>(c => c.OhCdEvt).WithMany(t => t.OhEvts).HasForeignKey(u => new { u.OhCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEvt>().HasRequired<OhDsc>(c => c.OhDsc).WithMany(t => t.OhEvts).HasForeignKey(u => new { u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEvt>().ToTable("EVT_OH","OH");
            modelBuilder.Entity<OhEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhEvt>().Property(item => item.CdEvtOhType).IsRequired();
            modelBuilder.Entity<OhEvt>().Property(item => item.CdEvtOhType).HasMaxLength(25);
            modelBuilder.Entity<OhEvt>().Property(item => item.CdEvtOhType).HasColumnName("CD_EVT_OH__TYPE");
            modelBuilder.Entity<OhEvt>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhEvt>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhEvt>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<OhEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<OhEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<OhEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<OhEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<OhCdTeteAm>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdTeteAm).HasForeignKey(u => new {u.OhCdTeteAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdTeteAm>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdTeteAm).HasForeignKey(u => new {u.OhCdTeteAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdTeteAm>().ToTable("CD_TETE_AM_OH","OH");
            modelBuilder.Entity<OhCdTeteAm>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdTeteAm>().Property(item => item.TeteAm).IsRequired();
            modelBuilder.Entity<OhCdTeteAm>().Property(item => item.TeteAm).HasMaxLength(60);
            modelBuilder.Entity<OhCdTeteAm>().Property(item => item.TeteAm).HasColumnName("TETE_AM");
            modelBuilder.Entity<OhCdTeteAv>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdTeteAv).HasForeignKey(u => new {u.OhCdTeteAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdTeteAv>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdTeteAv).HasForeignKey(u => new {u.OhCdTeteAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdTeteAv>().ToTable("CD_TETE_AV_OH","OH");
            modelBuilder.Entity<OhCdTeteAv>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdTeteAv>().Property(item => item.TeteAv).IsRequired();
            modelBuilder.Entity<OhCdTeteAv>().Property(item => item.TeteAv).HasMaxLength(60);
            modelBuilder.Entity<OhCdTeteAv>().Property(item => item.TeteAv).HasColumnName("TETE_AV");
            modelBuilder.Entity<OhCdEntete>().HasRequired<OhCdComposant>(c => c.OhCdComposant).WithMany(t => t.OhCdEntetes).HasForeignKey(u => new { u.OhCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEntete>().HasMany<OhEntete>(c => c.OhEntetes).WithRequired(t => t.OhCdEntete).HasForeignKey(u => new {u.OhCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdEntete>().ToTable("CD_ENTETE_OH","OH");
            modelBuilder.Entity<OhCdEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdEntete>().Property(item => item.IdEntete).IsRequired();
            modelBuilder.Entity<OhCdEntete>().Property(item => item.IdEntete).HasColumnName("ID_ENTETE");
            modelBuilder.Entity<OhCdEntete>().Property(item => item.CdComposantOhTypeComp).IsRequired();
            modelBuilder.Entity<OhCdEntete>().Property(item => item.CdComposantOhTypeComp).HasMaxLength(6);
            modelBuilder.Entity<OhCdEntete>().Property(item => item.CdComposantOhTypeComp).HasColumnName("CD_COMPOSANT_OH__TYPE_COMP");
            modelBuilder.Entity<OhCdEntete>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OhCdEntete>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OhCdEntete>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhCdEntete>().Property(item => item.OrdreEnt).IsRequired();
            modelBuilder.Entity<OhCdEntete>().Property(item => item.OrdreEnt).HasColumnName("ORDRE_ENT");
            modelBuilder.Entity<OhCdEntete>().Property(item => item.Guide).HasMaxLength(500);
            modelBuilder.Entity<OhCdEntete>().Property(item => item.Guide).HasColumnName("GUIDE");
            modelBuilder.Entity<OhCdChapitre>().HasMany<OhCdLigne>(c => c.OhCdLignes).WithRequired(t => t.OhCdChapitre).HasForeignKey(u => new {u.OhCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdChapitre>().ToTable("CD_CHAPITRE_OH","OH");
            modelBuilder.Entity<OhCdChapitre>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.IdChap).IsRequired();
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.IdChap).HasColumnName("ID_CHAP");
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.OrdreChap).IsRequired();
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.OrdreChap).HasColumnName("ORDRE_CHAP");
            modelBuilder.Entity<OhCdChapitre>().Property(item => item.Ponderation).HasColumnName("PONDERATION");
            modelBuilder.Entity<OhCdLigne>().HasRequired<OhCdChapitre>(c => c.OhCdChapitre).WithMany(t => t.OhCdLignes).HasForeignKey(u => new { u.OhCdChapitreIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdLigne>().HasMany<OhSprtVst>(c => c.OhSprtVsts).WithRequired(t => t.OhCdLigne).HasForeignKey(u => new {u.OhCdLigneIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdLigne>().ToTable("CD_LIGNE_OH","OH");
            modelBuilder.Entity<OhCdLigne>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdLigne>().Property(item => item.CdChapitreOhIdChap).IsRequired();
            modelBuilder.Entity<OhCdLigne>().Property(item => item.CdChapitreOhIdChap).HasColumnName("CD_CHAPITRE_OH__ID_CHAP");
            modelBuilder.Entity<OhCdLigne>().Property(item => item.IdLigne).IsRequired();
            modelBuilder.Entity<OhCdLigne>().Property(item => item.IdLigne).HasColumnName("ID_LIGNE");
            modelBuilder.Entity<OhCdLigne>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OhCdLigne>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OhCdLigne>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhCdLigne>().Property(item => item.OrdreLigne).IsRequired();
            modelBuilder.Entity<OhCdLigne>().Property(item => item.OrdreLigne).HasColumnName("ORDRE_LIGNE");
            modelBuilder.Entity<OhEntete>().HasRequired<OhCdEntete>(c => c.OhCdEntete).WithMany(t => t.OhEntetes).HasForeignKey(u => new { u.OhCdEnteteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEntete>().HasRequired<OhVst>(c => c.OhVst).WithMany(t => t.OhEntetes).HasForeignKey(u => new { u.OhVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEntete>().ToTable("ENTETE_OH","OH");
            modelBuilder.Entity<OhEntete>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhEntete>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhEntete>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhEntete>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhEntete>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhEntete>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhEntete>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhEntete>().Property(item => item.CdEnteteOhIdEntete).IsRequired();
            modelBuilder.Entity<OhEntete>().Property(item => item.CdEnteteOhIdEntete).HasColumnName("CD_ENTETE_OH__ID_ENTETE");
            modelBuilder.Entity<OhEntete>().Property(item => item.Valeur).HasMaxLength(250);
            modelBuilder.Entity<OhEntete>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<OhContact>().HasRequired<OhDoc>(c => c.OhDoc).WithMany(t => t.OhContacts).HasForeignKey(u => new { u.OhDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhContact>().ToTable("CONTACT_OH","OH");
            modelBuilder.Entity<OhContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhContact>().Property(item => item.DocOhId).IsRequired();
            modelBuilder.Entity<OhContact>().Property(item => item.DocOhId).HasColumnName("DOC_OH__ID");
            modelBuilder.Entity<OhContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<OhContact>().Property(item => item.Givenname).HasColumnName("GIVENNAME");
            modelBuilder.Entity<OhContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<OhContact>().Property(item => item.Sn).HasColumnName("SN");
            modelBuilder.Entity<OhContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<OhContact>().Property(item => item.Cn).HasColumnName("CN");
            modelBuilder.Entity<OhContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<OhContact>().Property(item => item.O).HasColumnName("O");
            modelBuilder.Entity<OhContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<OhContact>().Property(item => item.Mail).HasColumnName("MAIL");
            modelBuilder.Entity<OhContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<OhContact>().Property(item => item.Telephonenumber).HasColumnName("TELEPHONENUMBER");
            modelBuilder.Entity<OhContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<OhContact>().Property(item => item.Mobile).HasColumnName("MOBILE");
            modelBuilder.Entity<OhContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<OhContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("FACSIMILETELEPHONENUMBER");
            modelBuilder.Entity<OhContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<OhContact>().Property(item => item.Street).HasColumnName("STREET");
            modelBuilder.Entity<OhContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<OhContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("MOZILLAWORKSTREET2");
            modelBuilder.Entity<OhContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<OhContact>().Property(item => item.L).HasColumnName("L");
            modelBuilder.Entity<OhContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<OhContact>().Property(item => item.Postalcode).HasColumnName("POSTALCODE");
            modelBuilder.Entity<OhContact>().Property(item => item.Modifytimestamp).HasColumnName("MODIFYTIMESTAMP");
            modelBuilder.Entity<OhCdComposant>().HasMany<OhCdEntete>(c => c.OhCdEntetes).WithRequired(t => t.OhCdComposant).HasForeignKey(u => new {u.OhCdComposantIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdComposant>().ToTable("CD_COMPOSANT_OH","OH");
            modelBuilder.Entity<OhCdComposant>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdComposant>().Property(item => item.TypeComp).IsRequired();
            modelBuilder.Entity<OhCdComposant>().Property(item => item.TypeComp).HasMaxLength(6);
            modelBuilder.Entity<OhCdComposant>().Property(item => item.TypeComp).HasColumnName("TYPE_COMP");
            modelBuilder.Entity<OhCdComposant>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<OhCdComposant>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhInspecteur>().HasRequired<OhCdPresta>(c => c.OhCdPresta).WithMany(t => t.OhInspecteurs).HasForeignKey(u => new { u.OhCdPrestaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspecteur>().HasMany<OhInsp>(c => c.OhInsps).WithOptional(t => t.OhInspecteur).HasForeignKey(u => new {u.OhInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspecteur>().HasMany<OhVst>(c => c.OhVsts).WithOptional(t => t.OhInspecteur).HasForeignKey(u => new {u.OhInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspecteur>().HasMany<OhInspTmp>(c => c.OhInspTmps).WithOptional(t => t.OhInspecteur).HasForeignKey(u => new {u.OhInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspecteur>().ToTable("INSPECTEUR_OH","OH");
            modelBuilder.Entity<OhInspecteur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhInspecteur>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<OhInspecteur>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<OhInspecteur>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<OhInspecteur>().Property(item => item.CdPrestaOhPrestataire).IsRequired();
            modelBuilder.Entity<OhInspecteur>().Property(item => item.CdPrestaOhPrestataire).HasMaxLength(50);
            modelBuilder.Entity<OhInspecteur>().Property(item => item.CdPrestaOhPrestataire).HasColumnName("CD_PRESTA_OH__PRESTATAIRE");
            modelBuilder.Entity<OhInspecteur>().Property(item => item.Fonc).HasMaxLength(60);
            modelBuilder.Entity<OhInspecteur>().Property(item => item.Fonc).HasColumnName("FONC");
            modelBuilder.Entity<OhCdUnite>().HasMany<OhBpu>(c => c.OhBpus).WithOptional(t => t.OhCdUnite).HasForeignKey(u => new {u.OhCdUniteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdUnite>().ToTable("CD_UNITE_OH","OH");
            modelBuilder.Entity<OhCdUnite>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdUnite>().Property(item => item.Unite).IsRequired();
            modelBuilder.Entity<OhCdUnite>().Property(item => item.Unite).HasMaxLength(12);
            modelBuilder.Entity<OhCdUnite>().Property(item => item.Unite).HasColumnName("UNITE");
            modelBuilder.Entity<OhCdMo>().HasMany<OhDsc>(c => c.OhDscs).WithOptional(t => t.OhCdMo).HasForeignKey(u => new {u.OhCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdMo>().HasMany<OhDscTemp>(c => c.OhDscTemps).WithOptional(t => t.OhCdMo).HasForeignKey(u => new {u.OhCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdMo>().ToTable("CD_MO_OH","OH");
            modelBuilder.Entity<OhCdMo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdMo>().Property(item => item.Mo).IsRequired();
            modelBuilder.Entity<OhCdMo>().Property(item => item.Mo).HasMaxLength(60);
            modelBuilder.Entity<OhCdMo>().Property(item => item.Mo).HasColumnName("MO");
            modelBuilder.Entity<OhCdConclusion>().HasMany<OhCdConclusionInsp>(c => c.OhCdConclusionInsps).WithRequired(t => t.OhCdConclusion).HasForeignKey(u => new {u.OhCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdConclusion>().HasMany<OhCdConclusionInspTmp>(c => c.OhCdConclusionInspTmps).WithRequired(t => t.OhCdConclusion).HasForeignKey(u => new {u.OhCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdConclusion>().ToTable("CD_CONCLUSION_OH","OH");
            modelBuilder.Entity<OhCdConclusion>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdConclusion>().Property(item => item.IdConc).IsRequired();
            modelBuilder.Entity<OhCdConclusion>().Property(item => item.IdConc).HasColumnName("ID_CONC");
            modelBuilder.Entity<OhCdConclusion>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<OhCdConclusion>().Property(item => item.Libelle).HasMaxLength(500);
            modelBuilder.Entity<OhCdConclusion>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<OhCdConclusion>().Property(item => item.Ordre).IsRequired();
            modelBuilder.Entity<OhCdConclusion>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<OhDscTemp>().HasRequired<OhCdFam>(c => c.OhCdFam).WithMany(t => t.OhDscTemps).HasForeignKey(u => new { u.OhCdFamIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasRequired<OhCdType>(c => c.OhCdType).WithMany(t => t.OhDscTemps).HasForeignKey(u => new { u.OhCdTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdSousType>(c => c.OhCdSousType).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdSousTypeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdMo>(c => c.OhCdMo).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdEntp>(c => c.OhCdEntp).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdMat>(c => c.OhCdMat).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdNomEau>(c => c.OhCdNomEau).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdNomEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdExt>(c => c.OhCdExt).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdExtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdTeteAv>(c => c.OhCdTeteAv).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdTeteAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdTeteAm>(c => c.OhCdTeteAm).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdTeteAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdProAm>(c => c.OhCdProAm).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdProAmIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdProAv>(c => c.OhCdProAv).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdProAvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdEau>(c => c.OhCdEau).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdEauIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdOuv>(c => c.OhCdOuv).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdOuvIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhCdEcoul>(c => c.OhCdEcoul).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhCdEcoulIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasRequired<OhCamp>(c => c.OhCamp).WithMany(t => t.OhDscTemps).HasForeignKey(u => new { u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasOptional<OhDsc>(c => c.OhDsc).WithMany(t => t.OhDscTemps).HasForeignKey(u => new {u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().HasMany<OhInspTmp>(c => c.OhInspTmps).WithRequired(t => t.OhDscTemp).HasForeignKey(u => new {u.OhDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscTemp>().ToTable("DSC_TEMP_OH","OH");
            modelBuilder.Entity<OhDscTemp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.NumOh).IsRequired();
            modelBuilder.Entity<OhDscTemp>().Property(item => item.NumOh).HasMaxLength(20);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.NumOh).HasColumnName("NUM_OH");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdProAmOhProtect).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdProAmOhProtect).HasColumnName("CD_PRO_AM_OH__PROTECT");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdOuvOhOuv).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdOuvOhOuv).HasColumnName("CD_OUV_OH__OUV");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdExtOhType).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdExtOhType).HasColumnName("CD_EXT_OH__TYPE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdTeteAmOhTeteAm).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdTeteAmOhTeteAm).HasColumnName("CD_TETE_AM_OH__TETE_AM");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdNomEauOhNom).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdNomEauOhNom).HasColumnName("CD_NOM_EAU_OH__NOM");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdTypeOhType).IsRequired();
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdTypeOhType).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdTypeOhType).HasColumnName("CD_TYPE_OH__TYPE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdEauOhEau).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdEauOhEau).HasColumnName("CD_EAU_OH__EAU");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdEcoulOhEcoul).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdEcoulOhEcoul).HasColumnName("CD_ECOUL_OH__ECOUL");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdMatOhCode).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdMatOhCode).HasColumnName("CD_MAT_OH__CODE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdTeteAvOhTeteAv).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdTeteAvOhTeteAv).HasColumnName("CD_TETE_AV_OH__TETE_AV");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdMoOhMo).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdMoOhMo).HasColumnName("CD_MO_OH__MO");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdEntpOhEntreprise).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdEntpOhEntreprise).HasColumnName("CD_ENTP_OH__ENTREPRISE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdFamOhFamille).IsRequired();
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdFamOhFamille).HasMaxLength(20);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdFamOhFamille).HasColumnName("CD_FAM_OH__FAMILLE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdProAvOhProtect).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdProAvOhProtect).HasColumnName("CD_PRO_AV_OH__PROTECT");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdSousTypeOhSousType).HasMaxLength(60);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.CdSousTypeOhSousType).HasColumnName("CD_SOUS_TYPE_OH__SOUS_TYPE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<OhDscTemp>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.NumExploit).HasMaxLength(30);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.NumExploit).HasColumnName("NUM_EXPLOIT");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Longueur).HasColumnName("LONGUEUR");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Hauteur).HasColumnName("HAUTEUR");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Biais).HasColumnName("BIAIS");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Pente).HasColumnName("PENTE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Portee).HasColumnName("PORTEE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Jum).HasColumnName("JUM");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Elem).HasColumnName("ELEM");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Regard).HasColumnName("REGARD");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.PercheValueInt).HasColumnName("PERCHE");
            modelBuilder.Entity<OhDscTemp>().Ignore(item => item.Perche);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.VulnerableValueInt).HasColumnName("VULNERABLE");
            modelBuilder.Entity<OhDscTemp>().Ignore(item => item.Vulnerable);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.FauneValueInt).HasColumnName("FAUNE");
            modelBuilder.Entity<OhDscTemp>().Ignore(item => item.Faune);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.LoiValueInt).HasColumnName("LOI");
            modelBuilder.Entity<OhDscTemp>().Ignore(item => item.Loi);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Phe).HasColumnName("PHE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Debit).HasColumnName("DEBIT");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.OuvAval).HasMaxLength(200);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.OuvAval).HasColumnName("OUV_AVAL");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.SecuriteValueInt).HasColumnName("SECURITE");
            modelBuilder.Entity<OhDscTemp>().Ignore(item => item.Securite);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.PrioritaireValueInt).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OhDscTemp>().Ignore(item => item.Prioritaire);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.ProsurvAnnee).HasColumnName("PROSURV_ANNEE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DernInsp).HasColumnName("DERN_INSP");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DernVst).HasColumnName("DERN_VST");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.NoteVst).HasMaxLength(5);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.NoteVst).HasColumnName("NOTE_VST");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Commentaire).HasMaxLength(1000);
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.X1).HasColumnName("X1");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Y1).HasColumnName("Y1");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Z1).HasColumnName("Z1");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.X2).HasColumnName("X2");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Y2).HasColumnName("Y2");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.Z2).HasColumnName("Z2");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.DateReleve).HasColumnName("DATE_RELEVE");
            modelBuilder.Entity<OhDscTemp>().Property(item => item.TerrainValueInt).HasColumnName("TERRAIN");
            modelBuilder.Entity<OhDscTemp>().Ignore(item => item.Terrain);
            modelBuilder.Entity<OhInspTmp>().HasOptional<OhCdMeteo>(c => c.OhCdMeteo).WithMany(t => t.OhInspTmps).HasForeignKey(u => new {u.OhCdMeteoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspTmp>().HasOptional<OhCdEtude>(c => c.OhCdEtude).WithMany(t => t.OhInspTmps).HasForeignKey(u => new {u.OhCdEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspTmp>().HasRequired<OhDscTemp>(c => c.OhDscTemp).WithMany(t => t.OhInspTmps).HasForeignKey(u => new { u.OhDscTempIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspTmp>().HasOptional<OhInspecteur>(c => c.OhInspecteur).WithMany(t => t.OhInspTmps).HasForeignKey(u => new {u.OhInspecteurIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspTmp>().HasMany<OhEltInspTmp>(c => c.OhEltInspTmps).WithRequired(t => t.OhInspTmp).HasForeignKey(u => new {u.OhInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspTmp>().HasMany<OhPhotoInspTmp>(c => c.OhPhotoInspTmps).WithRequired(t => t.OhInspTmp).HasForeignKey(u => new {u.OhInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspTmp>().HasMany<OhCdConclusionInspTmp>(c => c.OhCdConclusionInspTmps).WithRequired(t => t.OhInspTmp).HasForeignKey(u => new {u.OhInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhInspTmp>().ToTable("INSP_TMP_OH","OH");
            modelBuilder.Entity<OhInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhInspTmp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhInspTmp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.DscTempOhNumOh).IsRequired();
            modelBuilder.Entity<OhInspTmp>().Property(item => item.DscTempOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.DscTempOhNumOh).HasColumnName("DSC_TEMP_OH__NUM_OH");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.InspecteurOhNom).HasMaxLength(60);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.InspecteurOhNom).HasColumnName("INSPECTEUR_OH__NOM");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.CdEtudeOhEtude).HasMaxLength(65);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.CdEtudeOhEtude).HasColumnName("CD_ETUDE_OH__ETUDE");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.CdMeteoOhMeteo).HasMaxLength(60);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.CdMeteoOhMeteo).HasColumnName("CD_METEO_OH__METEO");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Etat).IsRequired();
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Etat).HasMaxLength(25);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Etat).HasColumnName("ETAT");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Datev).HasColumnName("DATEV");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Temperature).HasColumnName("TEMPERATURE");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Moyen).HasMaxLength(500);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Moyen).HasColumnName("MOYEN");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Conditions).HasMaxLength(500);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Conditions).HasColumnName("CONDITIONS");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.NomValid).HasMaxLength(250);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.NomValid).HasColumnName("NOM_VALID");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.DateValid).HasColumnName("DATE_VALID");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.DescInva).HasMaxLength(1000);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.DescInva).HasColumnName("DESC_INVA");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Prioritaire).HasMaxLength(1000);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Prioritaire).HasColumnName("PRIORITAIRE");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Securite).HasMaxLength(1000);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Securite).HasColumnName("SECURITE");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Note1).HasColumnName("NOTE1");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Note2).HasColumnName("NOTE2");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Note3).HasColumnName("NOTE3");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Note4).HasColumnName("NOTE4");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Note5).HasColumnName("NOTE5");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Urgence).HasMaxLength(5);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Urgence).HasColumnName("URGENCE");
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Qualite).HasMaxLength(25);
            modelBuilder.Entity<OhInspTmp>().Property(item => item.Qualite).HasColumnName("QUALITE");
            modelBuilder.Entity<OhEltInspTmp>().HasRequired<OhInspTmp>(c => c.OhInspTmp).WithMany(t => t.OhEltInspTmps).HasForeignKey(u => new { u.OhInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEltInspTmp>().HasRequired<OhElt>(c => c.OhElt).WithMany(t => t.OhEltInspTmps).HasForeignKey(u => new { u.OhEltIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEltInspTmp>().HasMany<OhPhotoEltInspTmp>(c => c.OhPhotoEltInspTmps).WithRequired(t => t.OhEltInspTmp).HasForeignKey(u => new {u.OhEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhEltInspTmp>().ToTable("ELT_INSP_TMP_OH","OH");
            modelBuilder.Entity<OhEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.DscTempOhNumOh).IsRequired();
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.DscTempOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.DscTempOhNumOh).HasColumnName("DSC_TEMP_OH__NUM_OH");
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.GrpOhIdGrp).IsRequired();
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.GrpOhIdGrp).HasColumnName("GRP_OH__ID_GRP");
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.PrtOhIdPrt).IsRequired();
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.PrtOhIdPrt).HasColumnName("PRT_OH__ID_PRT");
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.SprtOhIdSprt).IsRequired();
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.SprtOhIdSprt).HasColumnName("SPRT_OH__ID_SPRT");
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.EltOhIdElem).IsRequired();
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.EltOhIdElem).HasColumnName("ELT_OH__ID_ELEM");
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.Indice).IsRequired();
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.Indice).HasColumnName("INDICE");
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.Obs).HasMaxLength(255);
            modelBuilder.Entity<OhEltInspTmp>().Property(item => item.Obs).HasColumnName("OBS");
            modelBuilder.Entity<OhPhotoEltInspTmp>().HasRequired<OhEltInspTmp>(c => c.OhEltInspTmp).WithMany(t => t.OhPhotoEltInspTmps).HasForeignKey(u => new { u.OhEltInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPhotoEltInspTmp>().ToTable("PHOTO_ELT_INSP_TMP_OH","OH");
            modelBuilder.Entity<OhPhotoEltInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.GrpOhIdGrp).IsRequired();
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.GrpOhIdGrp).HasColumnName("GRP_OH__ID_GRP");
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.PrtOhIdPrt).IsRequired();
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.PrtOhIdPrt).HasColumnName("PRT_OH__ID_PRT");
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.SprtOhIdSprt).IsRequired();
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.SprtOhIdSprt).HasColumnName("SPRT_OH__ID_SPRT");
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.DscTempOhNumOh).IsRequired();
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.DscTempOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.DscTempOhNumOh).HasColumnName("DSC_TEMP_OH__NUM_OH");
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.EltOhIdElem).IsRequired();
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.EltOhIdElem).HasColumnName("ELT_OH__ID_ELEM");
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.Id).HasMaxLength(50);
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoEltInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhPhotoInspTmp>().HasRequired<OhInspTmp>(c => c.OhInspTmp).WithMany(t => t.OhPhotoInspTmps).HasForeignKey(u => new { u.OhInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhPhotoInspTmp>().ToTable("PHOTO_INSP_TMP_OH","OH");
            modelBuilder.Entity<OhPhotoInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.Id).HasMaxLength(30);
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.DscTempOhNumOh).IsRequired();
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.DscTempOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.DscTempOhNumOh).HasColumnName("DSC_TEMP_OH__NUM_OH");
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.Commentaire).HasMaxLength(100);
            modelBuilder.Entity<OhPhotoInspTmp>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<OhClsDoc>().HasRequired<OhCls>(c => c.OhCls).WithMany(t => t.OhClsDocs).HasForeignKey(u => new { u.OhClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhClsDoc>().HasRequired<OhDoc>(c => c.OhDoc).WithMany(t => t.OhClsDocs).HasForeignKey(u => new { u.OhDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhClsDoc>().ToTable("CLS_DOC_OH","OH");
            modelBuilder.Entity<OhClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhClsDoc>().Property(item => item.ClsOhId).IsRequired();
            modelBuilder.Entity<OhClsDoc>().Property(item => item.ClsOhId).HasColumnName("CLS_OH__ID");
            modelBuilder.Entity<OhClsDoc>().Property(item => item.DocOhId).IsRequired();
            modelBuilder.Entity<OhClsDoc>().Property(item => item.DocOhId).HasColumnName("DOC_OH__ID");
            modelBuilder.Entity<OhClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<OhClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<OhClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<OhClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
            modelBuilder.Entity<OhCdConclusionInsp>().HasRequired<OhInsp>(c => c.OhInsp).WithMany(t => t.OhCdConclusionInsps).HasForeignKey(u => new { u.OhInspIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdConclusionInsp>().HasRequired<OhCdConclusion>(c => c.OhCdConclusion).WithMany(t => t.OhCdConclusionInsps).HasForeignKey(u => new { u.OhCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdConclusionInsp>().ToTable("CD_CONCLUSION__INSP_OH","OH");
            modelBuilder.Entity<OhCdConclusionInsp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.CdConclusionOhIdConc).IsRequired();
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.CdConclusionOhIdConc).HasColumnName("CD_CONCLUSION_OH__ID_CONC");
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<OhCdConclusionInsp>().Property(item => item.Contenu).HasColumnName("CONTENU");
            modelBuilder.Entity<OhDscCamp>().HasRequired<OhDsc>(c => c.OhDsc).WithMany(t => t.OhDscCamps).HasForeignKey(u => new { u.OhDscIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscCamp>().HasRequired<OhCamp>(c => c.OhCamp).WithMany(t => t.OhDscCamps).HasForeignKey(u => new { u.OhCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhDscCamp>().ToTable("DSC_CAMP_OH","OH");
            modelBuilder.Entity<OhDscCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhDscCamp>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhDscCamp>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhDscCamp>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhDscCamp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhDscCamp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhDscCamp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhDscCamp>().Property(item => item.RealiserValueInt).HasColumnName("REALISER");
            modelBuilder.Entity<OhDscCamp>().Ignore(item => item.Realiser);
            modelBuilder.Entity<OhCdPrecoSprtVst>().HasRequired<OhSprtVst>(c => c.OhSprtVst).WithMany(t => t.OhCdPrecoSprtVsts).HasForeignKey(u => new { u.OhSprtVstIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdPrecoSprtVst>().HasRequired<OhBpu>(c => c.OhBpu).WithMany(t => t.OhCdPrecoSprtVsts).HasForeignKey(u => new { u.OhBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdPrecoSprtVst>().ToTable("CD_PRECO__SPRT_VST_OH","OH");
            modelBuilder.Entity<OhCdPrecoSprtVst>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.DscOhNumOh).IsRequired();
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.DscOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.DscOhNumOh).HasColumnName("DSC_OH__NUM_OH");
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.CdChapitreOhIdChap).IsRequired();
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.CdChapitreOhIdChap).HasColumnName("CD_CHAPITRE_OH__ID_CHAP");
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.CdLigneOhIdLigne).IsRequired();
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.CdLigneOhIdLigne).HasColumnName("CD_LIGNE_OH__ID_LIGNE");
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.BpuOhIdBpu).IsRequired();
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.BpuOhIdBpu).HasColumnName("BPU_OH__ID_BPU");
            modelBuilder.Entity<OhCdPrecoSprtVst>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<OhCdPrecoSprtVst>().Ignore(item => item.Realise);
            modelBuilder.Entity<OhCdConclusionInspTmp>().HasRequired<OhCdConclusion>(c => c.OhCdConclusion).WithMany(t => t.OhCdConclusionInspTmps).HasForeignKey(u => new { u.OhCdConclusionIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdConclusionInspTmp>().HasRequired<OhInspTmp>(c => c.OhInspTmp).WithMany(t => t.OhCdConclusionInspTmps).HasForeignKey(u => new { u.OhInspTmpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<OhCdConclusionInspTmp>().ToTable("CD_CONCLUSION__INSP_TMP_OH","OH");
            modelBuilder.Entity<OhCdConclusionInspTmp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.CampOhIdCamp).IsRequired();
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.CampOhIdCamp).HasMaxLength(100);
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.CampOhIdCamp).HasColumnName("CAMP_OH__ID_CAMP");
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.DscTempOhNumOh).IsRequired();
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.DscTempOhNumOh).HasMaxLength(20);
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.DscTempOhNumOh).HasColumnName("DSC_TEMP_OH__NUM_OH");
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.CdConclusionOhIdConc).IsRequired();
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.CdConclusionOhIdConc).HasColumnName("CD_CONCLUSION_OH__ID_CONC");
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.Contenu).HasMaxLength(1000);
            modelBuilder.Entity<OhCdConclusionInspTmp>().Property(item => item.Contenu).HasColumnName("CONTENU");
        }
    }
}
