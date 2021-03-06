using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextChs : DataContextBase
    {
        public DataContextChs(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<ChsCdCou> ChsCdCous { get; set; }
        
        public DbSet<ChsCdEntp> ChsCdEntps { get; set; }
        
        public DbSet<ChsCdTech> ChsCdTechs { get; set; }
        
        public DbSet<ChsPave> ChsPaves { get; set; }
        
        public DbSet<ChsCdCause> ChsCdCauses { get; set; }
        
        public DbSet<ChsCls> ChsClss { get; set; }
        
        public DbSet<ChsCdDoc> ChsCdDocs { get; set; }
        
        public DbSet<ChsDoc> ChsDocs { get; set; }
        
        public DbSet<ChsMatPave> ChsMatPaves { get; set; }
        
        public DbSet<ChsFabCar> ChsFabCars { get; set; }
        
        public DbSet<ChsMat> ChsMats { get; set; }
        
        public DbSet<ChsParamsis> ChsParamsiss { get; set; }
        
        public DbSet<ChsCdMesure> ChsCdMesures { get; set; }
        
        public DbSet<ChsCdIndic> ChsCdIndics { get; set; }
        
        public DbSet<ChsCdSeuil> ChsCdSeuils { get; set; }
        
        public DbSet<ChsCamp> ChsCamps { get; set; }
        
        public DbSet<ChsClCamp> ChsClCamps { get; set; }
        
        public DbSet<ChsMesure> ChsMesures { get; set; }
        
        public DbSet<ChsAgrege> ChsAgreges { get; set; }
        
        public DbSet<ChsCdFamCar> ChsCdFamCars { get; set; }
        
        public DbSet<ChsSysUser> ChsSysUsers { get; set; }
        
        public DbSet<ChsCdFamTech> ChsCdFamTechs { get; set; }
        
        public DbSet<ChsCdOrig> ChsCdOrigs { get; set; }
        
        public DbSet<ChsCdMat> ChsCdMats { get; set; }
        
        public DbSet<ChsCdAgrege> ChsCdAgreges { get; set; }
        
        public DbSet<ChsPrevision> ChsPrevisions { get; set; }
        
        public DbSet<ChsCdContrainte> ChsCdContraintes { get; set; }
        
        public DbSet<ChsBpu> ChsBpus { get; set; }
        
        public DbSet<ChsCdTravaux> ChsCdTravauxs { get; set; }
        
        public DbSet<ChsPlateforme> ChsPlateformes { get; set; }
        
        public DbSet<ChsCdPortance> ChsCdPortances { get; set; }
        
        public DbSet<ChsCdMpa> ChsCdMpas { get; set; }
        
        public DbSet<ChsCdMo> ChsCdMos { get; set; }
        
        public DbSet<ChsSousCouche> ChsSousCouches { get; set; }
        
        public DbSet<ChsClCarotte> ChsClCarottes { get; set; }
        
        public DbSet<ChsDetailCarotte> ChsDetailCarottes { get; set; }
        
        public DbSet<ChsExploitCarotte> ChsExploitCarottes { get; set; }
        
        public DbSet<ChsFamCar> ChsFamCars { get; set; }
        
        public DbSet<ChsClRoul> ChsClRouls { get; set; }
        
        public DbSet<ChsZh> ChsZhs { get; set; }
        
        public DbSet<ChsDetailCamp> ChsDetailCamps { get; set; }
        
        public DbSet<ChsPaveVoie> ChsPaveVoies { get; set; }
        
        public DbSet<ChsClPaveVoie> ChsClPaveVoies { get; set; }
        
        public DbSet<ChsDictionnaire> ChsDictionnaires { get; set; }
        
        public DbSet<ChsCdEvt> ChsCdEvts { get; set; }
        
        public DbSet<ChsEvt> ChsEvts { get; set; }
        
        public DbSet<ChsCdPosit> ChsCdPosits { get; set; }
        
        public DbSet<ChsNeAdmin> ChsNeAdmins { get; set; }
        
        public DbSet<ChsContact> ChsContacts { get; set; }
        
        public DbSet<ChsClsDoc> ChsClsDocs { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<ChsCdCou>().HasMany<ChsPave>(c => c.ChsPaves).WithRequired(t => t.ChsCdCou).HasForeignKey(u => new {u.ChsCdCouIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdCou>().ToTable("CD_COU_CHS","CHS");
            modelBuilder.Entity<ChsCdCou>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdCou>().Property(item => item.Couche).IsRequired();
            modelBuilder.Entity<ChsCdCou>().Property(item => item.Couche).HasMaxLength(14);
            modelBuilder.Entity<ChsCdCou>().Property(item => item.Couche).HasColumnName("COUCHE");
            modelBuilder.Entity<ChsCdCou>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<ChsCdCou>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<ChsCdCou>().Property(item => item.Couleur).HasMaxLength(16);
            modelBuilder.Entity<ChsCdCou>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<ChsCdEntp>().HasMany<ChsPave>(c => c.ChsPaves).WithOptional(t => t.ChsCdEntp).HasForeignKey(u => new {u.ChsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdEntp>().ToTable("CD_ENTP_CHS","CHS");
            modelBuilder.Entity<ChsCdEntp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdEntp>().Property(item => item.Entreprise).IsRequired();
            modelBuilder.Entity<ChsCdEntp>().Property(item => item.Entreprise).HasMaxLength(60);
            modelBuilder.Entity<ChsCdEntp>().Property(item => item.Entreprise).HasColumnName("ENTREPRISE");
            modelBuilder.Entity<ChsCdTech>().HasRequired<ChsCdFamTech>(c => c.ChsCdFamTech).WithMany(t => t.ChsCdTechs).HasForeignKey(u => new { u.ChsCdFamTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdTech>().HasMany<ChsPave>(c => c.ChsPaves).WithRequired(t => t.ChsCdTech).HasForeignKey(u => new {u.ChsCdTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdTech>().HasMany<ChsSousCouche>(c => c.ChsSousCouches).WithRequired(t => t.ChsCdTech).HasForeignKey(u => new {u.ChsCdTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdTech>().ToTable("CD_TECH_CHS","CHS");
            modelBuilder.Entity<ChsCdTech>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdTech>().Property(item => item.CdFamTechChsCode).IsRequired();
            modelBuilder.Entity<ChsCdTech>().Property(item => item.CdFamTechChsCode).HasMaxLength(15);
            modelBuilder.Entity<ChsCdTech>().Property(item => item.CdFamTechChsCode).HasColumnName("CD_FAM_TECH_CHS__CODE");
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Technique).IsRequired();
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Technique).HasMaxLength(12);
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Technique).HasColumnName("TECHNIQUE");
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Garantie).HasColumnName("GARANTIE");
            modelBuilder.Entity<ChsCdTech>().Property(item => item.Dvt).HasColumnName("DVT");
            modelBuilder.Entity<ChsPave>().HasOptional<ChsCdCause>(c => c.ChsCdCause).WithMany(t => t.ChsPaves).HasForeignKey(u => new {u.ChsCdCauseIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasOptional<ChsCdEntp>(c => c.ChsCdEntp).WithMany(t => t.ChsPaves).HasForeignKey(u => new {u.ChsCdEntpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasRequired<ChsCdTech>(c => c.ChsCdTech).WithMany(t => t.ChsPaves).HasForeignKey(u => new { u.ChsCdTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasRequired<ChsCdCou>(c => c.ChsCdCou).WithMany(t => t.ChsPaves).HasForeignKey(u => new { u.ChsCdCouIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasRequired<ChsCdTravaux>(c => c.ChsCdTravaux).WithMany(t => t.ChsPaves).HasForeignKey(u => new { u.ChsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasOptional<ChsCdMo>(c => c.ChsCdMo).WithMany(t => t.ChsPaves).HasForeignKey(u => new {u.ChsCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasMany<ChsMatPave>(c => c.ChsMatPaves).WithRequired(t => t.ChsPave).HasForeignKey(u => new {u.ChsPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasMany<ChsSousCouche>(c => c.ChsSousCouches).WithRequired(t => t.ChsPave).HasForeignKey(u => new {u.ChsPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().HasMany<ChsPaveVoie>(c => c.ChsPaveVoies).WithRequired(t => t.ChsPave).HasForeignKey(u => new {u.ChsPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPave>().ToTable("PAVE_CHS","CHS");
            modelBuilder.Entity<ChsPave>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsPave>().Property(item => item.CdCouChsCouche).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.CdCouChsCouche).HasMaxLength(14);
            modelBuilder.Entity<ChsPave>().Property(item => item.CdCouChsCouche).HasColumnName("CD_COU_CHS__COUCHE");
            modelBuilder.Entity<ChsPave>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<ChsPave>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsPave>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsPave>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsPave>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsPave>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsPave>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsPave>().Property(item => item.CdEntpChsEntreprise).HasMaxLength(60);
            modelBuilder.Entity<ChsPave>().Property(item => item.CdEntpChsEntreprise).HasColumnName("CD_ENTP_CHS__ENTREPRISE");
            modelBuilder.Entity<ChsPave>().Property(item => item.CdCauseChsCause).HasMaxLength(60);
            modelBuilder.Entity<ChsPave>().Property(item => item.CdCauseChsCause).HasColumnName("CD_CAUSE_CHS__CAUSE");
            modelBuilder.Entity<ChsPave>().Property(item => item.CdMoChsMo).HasMaxLength(25);
            modelBuilder.Entity<ChsPave>().Property(item => item.CdMoChsMo).HasColumnName("CD_MO_CHS__MO");
            modelBuilder.Entity<ChsPave>().Property(item => item.CdFamTechChsCode).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.CdFamTechChsCode).HasMaxLength(15);
            modelBuilder.Entity<ChsPave>().Property(item => item.CdFamTechChsCode).HasColumnName("CD_FAM_TECH_CHS__CODE");
            modelBuilder.Entity<ChsPave>().Property(item => item.CdTechChsTechnique).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.CdTechChsTechnique).HasMaxLength(12);
            modelBuilder.Entity<ChsPave>().Property(item => item.CdTechChsTechnique).HasColumnName("CD_TECH_CHS__TECHNIQUE");
            modelBuilder.Entity<ChsPave>().Property(item => item.CdTravauxChsCode).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.CdTravauxChsCode).HasMaxLength(60);
            modelBuilder.Entity<ChsPave>().Property(item => item.CdTravauxChsCode).HasColumnName("CD_TRAVAUX_CHS__CODE");
            modelBuilder.Entity<ChsPave>().Property(item => item.Largeur).HasColumnName("LARGEUR");
            modelBuilder.Entity<ChsPave>().Property(item => item.Epais).IsRequired();
            modelBuilder.Entity<ChsPave>().Property(item => item.Epais).HasColumnName("EPAIS");
            modelBuilder.Entity<ChsPave>().Property(item => item.Granulo).HasMaxLength(6);
            modelBuilder.Entity<ChsPave>().Property(item => item.Granulo).HasColumnName("GRANULO");
            modelBuilder.Entity<ChsPave>().Property(item => item.DureeVie).HasColumnName("DUREE_VIE");
            modelBuilder.Entity<ChsPave>().Property(item => item.Archive).HasMaxLength(255);
            modelBuilder.Entity<ChsPave>().Property(item => item.Archive).HasColumnName("ARCHIVE");
            modelBuilder.Entity<ChsPave>().Property(item => item.Marche).HasMaxLength(25);
            modelBuilder.Entity<ChsPave>().Property(item => item.Marche).HasColumnName("MARCHE");
            modelBuilder.Entity<ChsPave>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<ChsPave>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<ChsPave>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<ChsCdCause>().HasMany<ChsPave>(c => c.ChsPaves).WithOptional(t => t.ChsCdCause).HasForeignKey(u => new {u.ChsCdCauseIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdCause>().ToTable("CD_CAUSE_CHS","CHS");
            modelBuilder.Entity<ChsCdCause>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdCause>().Property(item => item.Cause).IsRequired();
            modelBuilder.Entity<ChsCdCause>().Property(item => item.Cause).HasMaxLength(60);
            modelBuilder.Entity<ChsCdCause>().Property(item => item.Cause).HasColumnName("CAUSE");
            modelBuilder.Entity<ChsCls>().HasMany<ChsClsDoc>(c => c.ChsClsDocs).WithRequired(t => t.ChsCls).HasForeignKey(u => new {u.ChsClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCls>().ToTable("CLS_CHS","CHS");
            modelBuilder.Entity<ChsCls>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCls>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<ChsCls>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<ChsCls>().Property(item => item.TableName).HasMaxLength(30);
            modelBuilder.Entity<ChsCls>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<ChsCls>().Property(item => item.KeyValue).HasMaxLength(100);
            modelBuilder.Entity<ChsCls>().Property(item => item.KeyValue).HasColumnName("KEY_VALUE");
            modelBuilder.Entity<ChsCdDoc>().HasMany<ChsDoc>(c => c.ChsDocs).WithRequired(t => t.ChsCdDoc).HasForeignKey(u => new {u.ChsCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdDoc>().ToTable("CD_DOC_CHS","CHS");
            modelBuilder.Entity<ChsCdDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdDoc>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<ChsCdDoc>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<ChsCdDoc>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<ChsCdDoc>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<ChsCdDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsCdDoc>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<ChsCdDoc>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<ChsDoc>().HasRequired<ChsCdDoc>(c => c.ChsCdDoc).WithMany(t => t.ChsDocs).HasForeignKey(u => new { u.ChsCdDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDoc>().HasMany<ChsContact>(c => c.ChsContacts).WithRequired(t => t.ChsDoc).HasForeignKey(u => new {u.ChsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDoc>().HasMany<ChsClsDoc>(c => c.ChsClsDocs).WithRequired(t => t.ChsDoc).HasForeignKey(u => new {u.ChsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDoc>().ToTable("DOC_CHS","CHS");
            modelBuilder.Entity<ChsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsDoc>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<ChsDoc>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<ChsDoc>().Property(item => item.CdDocChsCode).IsRequired();
            modelBuilder.Entity<ChsDoc>().Property(item => item.CdDocChsCode).HasMaxLength(15);
            modelBuilder.Entity<ChsDoc>().Property(item => item.CdDocChsCode).HasColumnName("CD_DOC_CHS__CODE");
            modelBuilder.Entity<ChsDoc>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<ChsDoc>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsDoc>().Property(item => item.Ref).HasMaxLength(50);
            modelBuilder.Entity<ChsDoc>().Property(item => item.Ref).HasColumnName("REF");
            modelBuilder.Entity<ChsMatPave>().HasRequired<ChsFabCar>(c => c.ChsFabCar).WithMany(t => t.ChsMatPaves).HasForeignKey(u => new { u.ChsFabCarIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsMatPave>().HasRequired<ChsMat>(c => c.ChsMat).WithMany(t => t.ChsMatPaves).HasForeignKey(u => new { u.ChsMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsMatPave>().HasRequired<ChsPave>(c => c.ChsPave).WithMany(t => t.ChsMatPaves).HasForeignKey(u => new { u.ChsPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsMatPave>().ToTable("MAT_PAVE_CHS","CHS");
            modelBuilder.Entity<ChsMatPave>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdCouChsCouche).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdCouChsCouche).HasMaxLength(14);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdCouChsCouche).HasColumnName("CD_COU_CHS__COUCHE");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsDateMs).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsDateMs).HasColumnName("PAVE_CHS__DATE_MS");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsLiaison).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsLiaison).HasColumnName("PAVE_CHS__LIAISON");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsSens).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsSens).HasColumnName("PAVE_CHS__SENS");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsAbsDeb).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsAbsDeb).HasColumnName("PAVE_CHS__ABS_DEB");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsAbsFin).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.PaveChsAbsFin).HasColumnName("PAVE_CHS__ABS_FIN");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Num).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Num).HasColumnName("NUM");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdMatChsCode).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdMatChsCode).HasMaxLength(12);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdMatChsCode).HasColumnName("CD_MAT_CHS__CODE");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdOrigChsCode).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdOrigChsCode).HasMaxLength(20);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.CdOrigChsCode).HasColumnName("CD_ORIG_CHS__CODE");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.FabCarChsNom).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.FabCarChsNom).HasMaxLength(60);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.FabCarChsNom).HasColumnName("FAB_CAR_CHS__NOM");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.MatChsMat).IsRequired();
            modelBuilder.Entity<ChsMatPave>().Property(item => item.MatChsMat).HasMaxLength(60);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.MatChsMat).HasColumnName("MAT_CHS__MAT");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Classe).HasMaxLength(8);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Classe).HasColumnName("CLASSE");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Dosage).HasMaxLength(50);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Dosage).HasColumnName("DOSAGE");
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<ChsMatPave>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<ChsFabCar>().HasRequired<ChsCdOrig>(c => c.ChsCdOrig).WithMany(t => t.ChsFabCars).HasForeignKey(u => new { u.ChsCdOrigIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsFabCar>().HasMany<ChsMatPave>(c => c.ChsMatPaves).WithRequired(t => t.ChsFabCar).HasForeignKey(u => new {u.ChsFabCarIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsFabCar>().ToTable("FAB_CAR_CHS","CHS");
            modelBuilder.Entity<ChsFabCar>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsFabCar>().Property(item => item.CdMatChsCode).IsRequired();
            modelBuilder.Entity<ChsFabCar>().Property(item => item.CdMatChsCode).HasMaxLength(12);
            modelBuilder.Entity<ChsFabCar>().Property(item => item.CdMatChsCode).HasColumnName("CD_MAT_CHS__CODE");
            modelBuilder.Entity<ChsFabCar>().Property(item => item.CdOrigChsCode).IsRequired();
            modelBuilder.Entity<ChsFabCar>().Property(item => item.CdOrigChsCode).HasMaxLength(20);
            modelBuilder.Entity<ChsFabCar>().Property(item => item.CdOrigChsCode).HasColumnName("CD_ORIG_CHS__CODE");
            modelBuilder.Entity<ChsFabCar>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<ChsFabCar>().Property(item => item.Nom).HasMaxLength(60);
            modelBuilder.Entity<ChsFabCar>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<ChsMat>().HasRequired<ChsCdMat>(c => c.ChsCdMat).WithMany(t => t.ChsMats).HasForeignKey(u => new { u.ChsCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsMat>().HasMany<ChsMatPave>(c => c.ChsMatPaves).WithRequired(t => t.ChsMat).HasForeignKey(u => new {u.ChsMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsMat>().ToTable("MAT_CHS","CHS");
            modelBuilder.Entity<ChsMat>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsMat>().Property(item => item.Mat).IsRequired();
            modelBuilder.Entity<ChsMat>().Property(item => item.Mat).HasMaxLength(60);
            modelBuilder.Entity<ChsMat>().Property(item => item.Mat).HasColumnName("MAT");
            modelBuilder.Entity<ChsMat>().Property(item => item.CdMatChsCode).IsRequired();
            modelBuilder.Entity<ChsMat>().Property(item => item.CdMatChsCode).HasMaxLength(12);
            modelBuilder.Entity<ChsMat>().Property(item => item.CdMatChsCode).HasColumnName("CD_MAT_CHS__CODE");
            modelBuilder.Entity<ChsParamsis>().ToTable("PARAMSIS","CHS");
            modelBuilder.Entity<ChsParamsis>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Entree).IsRequired();
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Entree).HasMaxLength(50);
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Entree).HasColumnName("ENTREE");
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Parametre).IsRequired();
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Parametre).HasMaxLength(50);
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Parametre).HasColumnName("PARAMETRE");
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Type).HasMaxLength(50);
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Valeur).HasMaxLength(50);
            modelBuilder.Entity<ChsParamsis>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<ChsCdMesure>().HasMany<ChsCdIndic>(c => c.ChsCdIndics).WithRequired(t => t.ChsCdMesure).HasForeignKey(u => new {u.ChsCdMesureIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdMesure>().HasMany<ChsCamp>(c => c.ChsCamps).WithRequired(t => t.ChsCdMesure).HasForeignKey(u => new {u.ChsCdMesureIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdMesure>().ToTable("CD_MESURE_CHS","CHS");
            modelBuilder.Entity<ChsCdMesure>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Agr).IsRequired();
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Agr).HasMaxLength(12);
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Agr).HasColumnName("AGR");
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Cycle).IsRequired();
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Cycle).HasColumnName("CYCLE");
            modelBuilder.Entity<ChsCdMesure>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<ChsCdIndic>().HasRequired<ChsCdMesure>(c => c.ChsCdMesure).WithMany(t => t.ChsCdIndics).HasForeignKey(u => new { u.ChsCdMesureIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdIndic>().HasMany<ChsCdSeuil>(c => c.ChsCdSeuils).WithRequired(t => t.ChsCdIndic).HasForeignKey(u => new {u.ChsCdIndicIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdIndic>().HasMany<ChsDetailCamp>(c => c.ChsDetailCamps).WithRequired(t => t.ChsCdIndic).HasForeignKey(u => new {u.ChsCdIndicIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdIndic>().ToTable("CD_INDIC_CHS","CHS");
            modelBuilder.Entity<ChsCdIndic>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Indic).IsRequired();
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Indic).HasMaxLength(12);
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Indic).HasColumnName("INDIC");
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Unite).HasMaxLength(8);
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Unite).HasColumnName("UNITE");
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Vmin).HasColumnName("VMIN");
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Vmax).HasColumnName("VMAX");
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Invalide).HasColumnName("INVALIDE");
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Formats).HasMaxLength(12);
            modelBuilder.Entity<ChsCdIndic>().Property(item => item.Formats).HasColumnName("FORMATS");
            modelBuilder.Entity<ChsCdSeuil>().HasRequired<ChsCdIndic>(c => c.ChsCdIndic).WithMany(t => t.ChsCdSeuils).HasForeignKey(u => new { u.ChsCdIndicIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdSeuil>().ToTable("CD_SEUIL_CHS","CHS");
            modelBuilder.Entity<ChsCdSeuil>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.CdIndicChsIndic).IsRequired();
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.CdIndicChsIndic).HasMaxLength(12);
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.CdIndicChsIndic).HasColumnName("CD_INDIC_CHS__INDIC");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Seuil1).IsRequired();
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Seuil1).HasColumnName("SEUIL1");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Seuil2).HasColumnName("SEUIL2");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Seuil3).HasColumnName("SEUIL3");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Seuil4).HasColumnName("SEUIL4");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Interp).IsRequired();
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Interp).HasMaxLength(1);
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.Interp).HasColumnName("INTERP");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.ValabsValueInt).IsRequired();
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.ValabsValueInt).HasColumnName("VALABS");
            modelBuilder.Entity<ChsCdSeuil>().Ignore(item => item.Valabs);
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.ZoneValueInt).HasColumnName("ZONE");
            modelBuilder.Entity<ChsCdSeuil>().Ignore(item => item.Zone);
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.UAlpha).HasColumnName("U_ALPHA");
            modelBuilder.Entity<ChsCdSeuil>().Property(item => item.CaractEcart).HasColumnName("CARACT_ECART");
            modelBuilder.Entity<ChsCamp>().HasRequired<ChsCdMesure>(c => c.ChsCdMesure).WithMany(t => t.ChsCamps).HasForeignKey(u => new { u.ChsCdMesureIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCamp>().HasMany<ChsDetailCamp>(c => c.ChsDetailCamps).WithRequired(t => t.ChsCamp).HasForeignKey(u => new {u.ChsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCamp>().ToTable("CAMP_CHS","CHS");
            modelBuilder.Entity<ChsCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCamp>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsCamp>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Section).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.Section).HasMaxLength(15);
            modelBuilder.Entity<ChsCamp>().Property(item => item.Section).HasColumnName("SECTION");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsCamp>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsCamp>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsCamp>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Dateg).HasColumnName("DATEG");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Datec).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.Datec).HasColumnName("DATEC");
            modelBuilder.Entity<ChsCamp>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsCamp>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsCamp>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsCamp>().Property(item => item.DateLoad).HasColumnName("DATE_LOAD");
            modelBuilder.Entity<ChsCamp>().Property(item => item.DateMes).HasColumnName("DATE_MES");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Pas).HasColumnName("PAS");
            modelBuilder.Entity<ChsCamp>().Property(item => item.Observ).HasMaxLength(255);
            modelBuilder.Entity<ChsCamp>().Property(item => item.Observ).HasColumnName("OBSERV");
            modelBuilder.Entity<ChsClCamp>().HasRequired<ChsDetailCamp>(c => c.ChsDetailCamp).WithMany(t => t.ChsClCamps).HasForeignKey(u => new { u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClCamp>().ToTable("CL_CAMP_CHS","CHS");
            modelBuilder.Entity<ChsClCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdCdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdCdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdCdMesureChsAgr).HasColumnName("CD__CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdIndicChsIndic).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdIndicChsIndic).HasMaxLength(12);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CdIndicChsIndic).HasColumnName("CD_INDIC_CHS__INDIC");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsSection).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsSection).HasMaxLength(15);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsSection).HasColumnName("CAMP_CHS__SECTION");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsAnnee).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsAnnee).HasColumnName("CAMP_CHS__ANNEE");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsLiaison).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsLiaison).HasColumnName("CAMP_CHS__LIAISON");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsSens).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsSens).HasColumnName("CAMP_CHS__SENS");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsVoie).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.CampChsVoie).HasColumnName("CAMP_CHS__VOIE");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.AnneeCalc).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.AnneeCalc).HasColumnName("ANNEE_CALC");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsClCamp>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsClCamp>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsClCamp>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsMesure>().HasRequired<ChsDetailCamp>(c => c.ChsDetailCamp).WithMany(t => t.ChsMesures).HasForeignKey(u => new { u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsMesure>().ToTable("MESURE_CHS","CHS");
            modelBuilder.Entity<ChsMesure>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdCdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdCdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdCdMesureChsAgr).HasColumnName("CD__CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdIndicChsIndic).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdIndicChsIndic).HasMaxLength(12);
            modelBuilder.Entity<ChsMesure>().Property(item => item.CdIndicChsIndic).HasColumnName("CD_INDIC_CHS__INDIC");
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsSection).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsSection).HasMaxLength(15);
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsSection).HasColumnName("CAMP_CHS__SECTION");
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsAnnee).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsAnnee).HasColumnName("CAMP_CHS__ANNEE");
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsLiaison).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsLiaison).HasColumnName("CAMP_CHS__LIAISON");
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsSens).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsSens).HasColumnName("CAMP_CHS__SENS");
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsVoie).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsMesure>().Property(item => item.CampChsVoie).HasColumnName("CAMP_CHS__VOIE");
            modelBuilder.Entity<ChsMesure>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsMesure>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsMesure>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsMesure>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsMesure>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsMesure>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<ChsAgrege>().HasRequired<ChsCdAgrege>(c => c.ChsCdAgrege).WithMany(t => t.ChsAgreges).HasForeignKey(u => new { u.ChsCdAgregeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsAgrege>().HasRequired<ChsDetailCamp>(c => c.ChsDetailCamp).WithMany(t => t.ChsAgreges).HasForeignKey(u => new { u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsAgrege>().ToTable("AGREGE_CHS","CHS");
            modelBuilder.Entity<ChsAgrege>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdCdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdCdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdCdMesureChsAgr).HasColumnName("CD__CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdIndicChsIndic).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdIndicChsIndic).HasMaxLength(12);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdIndicChsIndic).HasColumnName("CD_INDIC_CHS__INDIC");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsSection).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsSection).HasMaxLength(15);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsSection).HasColumnName("CAMP_CHS__SECTION");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsAnnee).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsAnnee).HasColumnName("CAMP_CHS__ANNEE");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsLiaison).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsLiaison).HasColumnName("CAMP_CHS__LIAISON");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsSens).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsSens).HasColumnName("CAMP_CHS__SENS");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsVoie).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CampChsVoie).HasColumnName("CAMP_CHS__VOIE");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsAgrege>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdAgregeChsValeur).IsRequired();
            modelBuilder.Entity<ChsAgrege>().Property(item => item.CdAgregeChsValeur).HasColumnName("CD_AGREGE_CHS__VALEUR");
            modelBuilder.Entity<ChsAgrege>().Property(item => item.Moyenne).HasColumnName("MOYENNE");
            modelBuilder.Entity<ChsCdFamCar>().HasMany<ChsFamCar>(c => c.ChsFamCars).WithRequired(t => t.ChsCdFamCar).HasForeignKey(u => new {u.ChsCdFamCarIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdFamCar>().ToTable("CD_FAM_CAR_CHS","CHS");
            modelBuilder.Entity<ChsCdFamCar>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdFamCar>().Property(item => item.Famille).IsRequired();
            modelBuilder.Entity<ChsCdFamCar>().Property(item => item.Famille).HasMaxLength(12);
            modelBuilder.Entity<ChsCdFamCar>().Property(item => item.Famille).HasColumnName("FAMILLE");
            modelBuilder.Entity<ChsCdFamCar>().Property(item => item.Libelle).HasMaxLength(60);
            modelBuilder.Entity<ChsCdFamCar>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsCdFamCar>().Property(item => item.Cam).IsRequired();
            modelBuilder.Entity<ChsCdFamCar>().Property(item => item.Cam).HasColumnName("CAM");
            modelBuilder.Entity<ChsSysUser>().ToTable("SYS_USER_CHS","CHS");
            modelBuilder.Entity<ChsSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<ChsSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<ChsSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<ChsSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<ChsSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<ChsSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<ChsSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<ChsSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<ChsCdFamTech>().HasMany<ChsCdTech>(c => c.ChsCdTechs).WithRequired(t => t.ChsCdFamTech).HasForeignKey(u => new {u.ChsCdFamTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdFamTech>().ToTable("CD_FAM_TECH_CHS","CHS");
            modelBuilder.Entity<ChsCdFamTech>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdFamTech>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<ChsCdFamTech>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<ChsCdFamTech>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<ChsCdOrig>().HasRequired<ChsCdMat>(c => c.ChsCdMat).WithMany(t => t.ChsCdOrigs).HasForeignKey(u => new { u.ChsCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdOrig>().HasMany<ChsFabCar>(c => c.ChsFabCars).WithRequired(t => t.ChsCdOrig).HasForeignKey(u => new {u.ChsCdOrigIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdOrig>().ToTable("CD_ORIG_CHS","CHS");
            modelBuilder.Entity<ChsCdOrig>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdOrig>().Property(item => item.CdMatChsCode).IsRequired();
            modelBuilder.Entity<ChsCdOrig>().Property(item => item.CdMatChsCode).HasMaxLength(12);
            modelBuilder.Entity<ChsCdOrig>().Property(item => item.CdMatChsCode).HasColumnName("CD_MAT_CHS__CODE");
            modelBuilder.Entity<ChsCdOrig>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<ChsCdOrig>().Property(item => item.Code).HasMaxLength(20);
            modelBuilder.Entity<ChsCdOrig>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<ChsCdMat>().HasMany<ChsMat>(c => c.ChsMats).WithRequired(t => t.ChsCdMat).HasForeignKey(u => new {u.ChsCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdMat>().HasMany<ChsCdOrig>(c => c.ChsCdOrigs).WithRequired(t => t.ChsCdMat).HasForeignKey(u => new {u.ChsCdMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdMat>().ToTable("CD_MAT_CHS","CHS");
            modelBuilder.Entity<ChsCdMat>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdMat>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<ChsCdMat>().Property(item => item.Code).HasMaxLength(12);
            modelBuilder.Entity<ChsCdMat>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<ChsCdAgrege>().HasMany<ChsAgrege>(c => c.ChsAgreges).WithRequired(t => t.ChsCdAgrege).HasForeignKey(u => new {u.ChsCdAgregeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdAgrege>().ToTable("CD_AGREGE_CHS","CHS");
            modelBuilder.Entity<ChsCdAgrege>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdAgrege>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<ChsCdAgrege>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<ChsCdAgrege>().Property(item => item.Libelle).HasMaxLength(50);
            modelBuilder.Entity<ChsCdAgrege>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsCdAgrege>().Property(item => item.Couleur).HasMaxLength(15);
            modelBuilder.Entity<ChsCdAgrege>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<ChsPrevision>().HasOptional<ChsCdContrainte>(c => c.ChsCdContrainte).WithMany(t => t.ChsPrevisions).HasForeignKey(u => new {u.ChsCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPrevision>().HasRequired<ChsBpu>(c => c.ChsBpu).WithMany(t => t.ChsPrevisions).HasForeignKey(u => new { u.ChsBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPrevision>().ToTable("PREVISION_CHS","CHS");
            modelBuilder.Entity<ChsPrevision>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsPrevision>().Property(item => item.BpuChsCode).IsRequired();
            modelBuilder.Entity<ChsPrevision>().Property(item => item.BpuChsCode).HasMaxLength(25);
            modelBuilder.Entity<ChsPrevision>().Property(item => item.BpuChsCode).HasColumnName("BPU_CHS__CODE");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsPrevision>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.CdContrainteChsType).HasMaxLength(100);
            modelBuilder.Entity<ChsPrevision>().Property(item => item.CdContrainteChsType).HasColumnName("CD_CONTRAINTE_CHS__TYPE");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsPrevision>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Montant).HasColumnName("MONTANT");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.DateDebut).HasColumnName("DATE_DEBUT");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.DateFin).HasColumnName("DATE_FIN");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.DateDemPub).HasColumnName("DATE_DEM_PUB");
            modelBuilder.Entity<ChsPrevision>().Property(item => item.RealiseValueInt).HasColumnName("REALISE");
            modelBuilder.Entity<ChsPrevision>().Ignore(item => item.Realise);
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<ChsPrevision>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<ChsCdContrainte>().HasMany<ChsPrevision>(c => c.ChsPrevisions).WithOptional(t => t.ChsCdContrainte).HasForeignKey(u => new {u.ChsCdContrainteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdContrainte>().ToTable("CD_CONTRAINTE_CHS","CHS");
            modelBuilder.Entity<ChsCdContrainte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdContrainte>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<ChsCdContrainte>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<ChsCdContrainte>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<ChsBpu>().HasRequired<ChsCdTravaux>(c => c.ChsCdTravaux).WithMany(t => t.ChsBpus).HasForeignKey(u => new { u.ChsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsBpu>().HasMany<ChsPrevision>(c => c.ChsPrevisions).WithRequired(t => t.ChsBpu).HasForeignKey(u => new {u.ChsBpuIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsBpu>().ToTable("BPU_CHS","CHS");
            modelBuilder.Entity<ChsBpu>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsBpu>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<ChsBpu>().Property(item => item.Code).HasMaxLength(25);
            modelBuilder.Entity<ChsBpu>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<ChsBpu>().Property(item => item.CdTravauxChsCode).IsRequired();
            modelBuilder.Entity<ChsBpu>().Property(item => item.CdTravauxChsCode).HasMaxLength(60);
            modelBuilder.Entity<ChsBpu>().Property(item => item.CdTravauxChsCode).HasColumnName("CD_TRAVAUX_CHS__CODE");
            modelBuilder.Entity<ChsBpu>().Property(item => item.Libelle).HasMaxLength(250);
            modelBuilder.Entity<ChsBpu>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<ChsBpu>().Property(item => item.Prix).HasColumnName("PRIX");
            modelBuilder.Entity<ChsBpu>().Property(item => item.DateMaj).HasColumnName("DATE_MAJ");
            modelBuilder.Entity<ChsCdTravaux>().HasMany<ChsBpu>(c => c.ChsBpus).WithRequired(t => t.ChsCdTravaux).HasForeignKey(u => new {u.ChsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdTravaux>().HasMany<ChsPave>(c => c.ChsPaves).WithRequired(t => t.ChsCdTravaux).HasForeignKey(u => new {u.ChsCdTravauxIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdTravaux>().ToTable("CD_TRAVAUX_CHS","CHS");
            modelBuilder.Entity<ChsCdTravaux>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdTravaux>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<ChsCdTravaux>().Property(item => item.Code).HasMaxLength(60);
            modelBuilder.Entity<ChsCdTravaux>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<ChsPlateforme>().HasRequired<ChsCdPortance>(c => c.ChsCdPortance).WithMany(t => t.ChsPlateformes).HasForeignKey(u => new { u.ChsCdPortanceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPlateforme>().HasRequired<ChsCdMpa>(c => c.ChsCdMpa).WithMany(t => t.ChsPlateformes).HasForeignKey(u => new { u.ChsCdMpaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPlateforme>().ToTable("PLATEFORME_CHS","CHS");
            modelBuilder.Entity<ChsPlateforme>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.CdMpaChsValeur).IsRequired();
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.CdMpaChsValeur).HasColumnName("CD_MPA_CHS__VALEUR");
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.CdPortanceChsClasse).IsRequired();
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.CdPortanceChsClasse).HasMaxLength(6);
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.CdPortanceChsClasse).HasColumnName("CD_PORTANCE_CHS__CLASSE");
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsPlateforme>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsCdPortance>().HasMany<ChsPlateforme>(c => c.ChsPlateformes).WithRequired(t => t.ChsCdPortance).HasForeignKey(u => new {u.ChsCdPortanceIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdPortance>().ToTable("CD_PORTANCE_CHS","CHS");
            modelBuilder.Entity<ChsCdPortance>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdPortance>().Property(item => item.Classe).IsRequired();
            modelBuilder.Entity<ChsCdPortance>().Property(item => item.Classe).HasMaxLength(6);
            modelBuilder.Entity<ChsCdPortance>().Property(item => item.Classe).HasColumnName("CLASSE");
            modelBuilder.Entity<ChsCdMpa>().HasMany<ChsPlateforme>(c => c.ChsPlateformes).WithRequired(t => t.ChsCdMpa).HasForeignKey(u => new {u.ChsCdMpaIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdMpa>().ToTable("CD_MPA_CHS","CHS");
            modelBuilder.Entity<ChsCdMpa>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdMpa>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<ChsCdMpa>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<ChsCdMo>().HasMany<ChsPave>(c => c.ChsPaves).WithOptional(t => t.ChsCdMo).HasForeignKey(u => new {u.ChsCdMoIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdMo>().ToTable("CD_MO_CHS","CHS");
            modelBuilder.Entity<ChsCdMo>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdMo>().Property(item => item.Mo).IsRequired();
            modelBuilder.Entity<ChsCdMo>().Property(item => item.Mo).HasMaxLength(25);
            modelBuilder.Entity<ChsCdMo>().Property(item => item.Mo).HasColumnName("MO");
            modelBuilder.Entity<ChsSousCouche>().HasRequired<ChsPave>(c => c.ChsPave).WithMany(t => t.ChsSousCouches).HasForeignKey(u => new { u.ChsPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsSousCouche>().HasRequired<ChsCdTech>(c => c.ChsCdTech).WithMany(t => t.ChsSousCouches).HasForeignKey(u => new { u.ChsCdTechIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsSousCouche>().ToTable("SOUS_COUCHE_CHS","CHS");
            modelBuilder.Entity<ChsSousCouche>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdCouChsCouche).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdCouChsCouche).HasMaxLength(14);
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdCouChsCouche).HasColumnName("CD_COU_CHS__COUCHE");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsDateMs).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsDateMs).HasColumnName("PAVE_CHS__DATE_MS");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsLiaison).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsLiaison).HasColumnName("PAVE_CHS__LIAISON");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsSens).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsSens).HasColumnName("PAVE_CHS__SENS");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsAbsDeb).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsAbsDeb).HasColumnName("PAVE_CHS__ABS_DEB");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsAbsFin).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.PaveChsAbsFin).HasColumnName("PAVE_CHS__ABS_FIN");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.Numordre).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.Numordre).HasColumnName("NUMORDRE");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdFamTechChsCode).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdFamTechChsCode).HasMaxLength(15);
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdFamTechChsCode).HasColumnName("CD_FAM_TECH_CHS__CODE");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdTechChsTechnique).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdTechChsTechnique).HasMaxLength(12);
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.CdTechChsTechnique).HasColumnName("CD_TECH_CHS__TECHNIQUE");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.Epais).IsRequired();
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.Epais).HasColumnName("EPAIS");
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.Dosage).HasMaxLength(5);
            modelBuilder.Entity<ChsSousCouche>().Property(item => item.Dosage).HasColumnName("DOSAGE");
            modelBuilder.Entity<ChsClCarotte>().HasMany<ChsDetailCarotte>(c => c.ChsDetailCarottes).WithRequired(t => t.ChsClCarotte).HasForeignKey(u => new {u.ChsClCarotteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClCarotte>().HasMany<ChsExploitCarotte>(c => c.ChsExploitCarottes).WithRequired(t => t.ChsClCarotte).HasForeignKey(u => new {u.ChsClCarotteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClCarotte>().HasMany<ChsClRoul>(c => c.ChsClRouls).WithRequired(t => t.ChsClCarotte).HasForeignKey(u => new {u.ChsClCarotteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClCarotte>().ToTable("CL_CAROTTE_CHS","CHS");
            modelBuilder.Entity<ChsClCarotte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsClCarotte>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsDetailCarotte>().HasRequired<ChsClCarotte>(c => c.ChsClCarotte).WithMany(t => t.ChsDetailCarottes).HasForeignKey(u => new { u.ChsClCarotteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDetailCarotte>().ToTable("DETAIL_CAROTTE_CHS","CHS");
            modelBuilder.Entity<ChsDetailCarotte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsLiaison).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsLiaison).HasColumnName("CL_CAROTTE_CHS__LIAISON");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsSens).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsSens).HasColumnName("CL_CAROTTE_CHS__SENS");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsVoie).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsVoie).HasColumnName("CL_CAROTTE_CHS__VOIE");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsAbsDeb).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.ClCarotteChsAbsDeb).HasColumnName("CL_CAROTTE_CHS__ABS_DEB");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Numordre).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Numordre).HasColumnName("NUMORDRE");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Couche).IsRequired();
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Couche).HasMaxLength(12);
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Couche).HasColumnName("COUCHE");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Technique).HasMaxLength(12);
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Technique).HasColumnName("TECHNIQUE");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Epais).HasColumnName("EPAIS");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Granulo).HasMaxLength(6);
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.Granulo).HasColumnName("GRANULO");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.TypeSc).HasMaxLength(25);
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.TypeSc).HasColumnName("TYPE_SC");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.EpaisSc).HasColumnName("EPAIS_SC");
            modelBuilder.Entity<ChsDetailCarotte>().Property(item => item.DureeServ).HasColumnName("DUREE_SERV");
            modelBuilder.Entity<ChsExploitCarotte>().HasRequired<ChsClCarotte>(c => c.ChsClCarotte).WithMany(t => t.ChsExploitCarottes).HasForeignKey(u => new { u.ChsClCarotteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsExploitCarotte>().ToTable("EXPLOIT_CAROTTE_CHS","CHS");
            modelBuilder.Entity<ChsExploitCarotte>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsLiaison).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsLiaison).HasColumnName("CL_CAROTTE_CHS__LIAISON");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsSens).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsSens).HasColumnName("CL_CAROTTE_CHS__SENS");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsVoie).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsVoie).HasColumnName("CL_CAROTTE_CHS__VOIE");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsAbsDeb).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.ClCarotteChsAbsDeb).HasColumnName("CL_CAROTTE_CHS__ABS_DEB");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Numordre).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Numordre).HasColumnName("NUMORDRE");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Couche).IsRequired();
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Couche).HasMaxLength(12);
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Couche).HasColumnName("COUCHE");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Technique).HasMaxLength(12);
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Technique).HasColumnName("TECHNIQUE");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Epais).HasColumnName("EPAIS");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Granulo).HasMaxLength(6);
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.Granulo).HasColumnName("GRANULO");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.TypeSc).HasMaxLength(25);
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.TypeSc).HasColumnName("TYPE_SC");
            modelBuilder.Entity<ChsExploitCarotte>().Property(item => item.EpaisSc).HasColumnName("EPAIS_SC");
            modelBuilder.Entity<ChsFamCar>().HasRequired<ChsCdFamCar>(c => c.ChsCdFamCar).WithMany(t => t.ChsFamCars).HasForeignKey(u => new { u.ChsCdFamCarIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsFamCar>().ToTable("FAM_CAR_CHS","CHS");
            modelBuilder.Entity<ChsFamCar>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsFamCar>().Property(item => item.CdFamCarChsFamille).IsRequired();
            modelBuilder.Entity<ChsFamCar>().Property(item => item.CdFamCarChsFamille).HasMaxLength(12);
            modelBuilder.Entity<ChsFamCar>().Property(item => item.CdFamCarChsFamille).HasColumnName("CD_FAM_CAR_CHS__FAMILLE");
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsFamCar>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsFamCar>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsFamCar>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsFamCar>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsFamCar>().Property(item => item.ProgressiveValueInt).HasColumnName("PROGRESSIVE");
            modelBuilder.Entity<ChsFamCar>().Ignore(item => item.Progressive);
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Commentaire).HasMaxLength(255);
            modelBuilder.Entity<ChsFamCar>().Property(item => item.Commentaire).HasColumnName("COMMENTAIRE");
            modelBuilder.Entity<ChsClRoul>().HasRequired<ChsClCarotte>(c => c.ChsClCarotte).WithMany(t => t.ChsClRouls).HasForeignKey(u => new { u.ChsClCarotteIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClRoul>().ToTable("CL_ROUL_CHS","CHS");
            modelBuilder.Entity<ChsClRoul>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsLiaison).IsRequired();
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsLiaison).HasColumnName("CL_CAROTTE_CHS__LIAISON");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsSens).IsRequired();
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsSens).HasColumnName("CL_CAROTTE_CHS__SENS");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsVoie).IsRequired();
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsVoie).HasColumnName("CL_CAROTTE_CHS__VOIE");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsAbsDeb).IsRequired();
            modelBuilder.Entity<ChsClRoul>().Property(item => item.ClCarotteChsAbsDeb).HasColumnName("CL_CAROTTE_CHS__ABS_DEB");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.DateMs).IsRequired();
            modelBuilder.Entity<ChsClRoul>().Property(item => item.DateMs).HasColumnName("DATE_MS");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsClRoul>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.Technique).HasMaxLength(12);
            modelBuilder.Entity<ChsClRoul>().Property(item => item.Technique).HasColumnName("TECHNIQUE");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.Epais).HasColumnName("EPAIS");
            modelBuilder.Entity<ChsClRoul>().Property(item => item.Granulo).HasMaxLength(6);
            modelBuilder.Entity<ChsClRoul>().Property(item => item.Granulo).HasColumnName("GRANULO");
            modelBuilder.Entity<ChsZh>().HasRequired<ChsDetailCamp>(c => c.ChsDetailCamp).WithMany(t => t.ChsZhs).HasForeignKey(u => new { u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsZh>().ToTable("ZH_CHS","CHS");
            modelBuilder.Entity<ChsZh>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsZh>().Property(item => item.CdCdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CdCdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsZh>().Property(item => item.CdCdMesureChsAgr).HasColumnName("CD__CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsZh>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsZh>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsZh>().Property(item => item.CdIndicChsIndic).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CdIndicChsIndic).HasMaxLength(12);
            modelBuilder.Entity<ChsZh>().Property(item => item.CdIndicChsIndic).HasColumnName("CD_INDIC_CHS__INDIC");
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsSection).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsSection).HasMaxLength(15);
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsSection).HasColumnName("CAMP_CHS__SECTION");
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsAnnee).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsAnnee).HasColumnName("CAMP_CHS__ANNEE");
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsLiaison).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsLiaison).HasColumnName("CAMP_CHS__LIAISON");
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsSens).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsSens).HasColumnName("CAMP_CHS__SENS");
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsVoie).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsZh>().Property(item => item.CampChsVoie).HasColumnName("CAMP_CHS__VOIE");
            modelBuilder.Entity<ChsZh>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsZh>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsZh>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsZh>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsZh>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<ChsZh>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<ChsDetailCamp>().HasRequired<ChsCdIndic>(c => c.ChsCdIndic).WithMany(t => t.ChsDetailCamps).HasForeignKey(u => new { u.ChsCdIndicIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDetailCamp>().HasRequired<ChsCamp>(c => c.ChsCamp).WithMany(t => t.ChsDetailCamps).HasForeignKey(u => new { u.ChsCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDetailCamp>().HasMany<ChsMesure>(c => c.ChsMesures).WithRequired(t => t.ChsDetailCamp).HasForeignKey(u => new {u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDetailCamp>().HasMany<ChsAgrege>(c => c.ChsAgreges).WithRequired(t => t.ChsDetailCamp).HasForeignKey(u => new {u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDetailCamp>().HasMany<ChsZh>(c => c.ChsZhs).WithRequired(t => t.ChsDetailCamp).HasForeignKey(u => new {u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDetailCamp>().HasMany<ChsClCamp>(c => c.ChsClCamps).WithRequired(t => t.ChsDetailCamp).HasForeignKey(u => new {u.ChsDetailCampIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsDetailCamp>().ToTable("DETAIL_CAMP_CHS","CHS");
            modelBuilder.Entity<ChsDetailCamp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdCdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdCdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdCdMesureChsAgr).HasColumnName("CD__CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdIndicChsIndic).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdIndicChsIndic).HasMaxLength(12);
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdIndicChsIndic).HasColumnName("CD_INDIC_CHS__INDIC");
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdMesureChsAgr).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdMesureChsAgr).HasMaxLength(12);
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CdMesureChsAgr).HasColumnName("CD_MESURE_CHS__AGR");
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsSection).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsSection).HasMaxLength(15);
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsSection).HasColumnName("CAMP_CHS__SECTION");
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsAnnee).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsAnnee).HasColumnName("CAMP_CHS__ANNEE");
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsLiaison).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsLiaison).HasColumnName("CAMP_CHS__LIAISON");
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsSens).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsSens).HasColumnName("CAMP_CHS__SENS");
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsVoie).IsRequired();
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsDetailCamp>().Property(item => item.CampChsVoie).HasColumnName("CAMP_CHS__VOIE");
            modelBuilder.Entity<ChsPaveVoie>().HasRequired<ChsPave>(c => c.ChsPave).WithMany(t => t.ChsPaveVoies).HasForeignKey(u => new { u.ChsPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPaveVoie>().HasMany<ChsClPaveVoie>(c => c.ChsClPaveVoies).WithRequired(t => t.ChsPaveVoie).HasForeignKey(u => new {u.ChsPaveVoieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsPaveVoie>().ToTable("PAVE_VOIE_CHS","CHS");
            modelBuilder.Entity<ChsPaveVoie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.CdCouChsCouche).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.CdCouChsCouche).HasMaxLength(14);
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.CdCouChsCouche).HasColumnName("CD_COU_CHS__COUCHE");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsDateMs).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsDateMs).HasColumnName("PAVE_CHS__DATE_MS");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsLiaison).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsLiaison).HasColumnName("PAVE_CHS__LIAISON");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsSens).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsSens).HasColumnName("PAVE_CHS__SENS");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsAbsDeb).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsAbsDeb).HasColumnName("PAVE_CHS__ABS_DEB");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsAbsFin).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.PaveChsAbsFin).HasColumnName("PAVE_CHS__ABS_FIN");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.Voiedeb).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.Voiedeb).HasColumnName("VOIEDEB");
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.Voiefin).IsRequired();
            modelBuilder.Entity<ChsPaveVoie>().Property(item => item.Voiefin).HasColumnName("VOIEFIN");
            modelBuilder.Entity<ChsClPaveVoie>().HasRequired<ChsPaveVoie>(c => c.ChsPaveVoie).WithMany(t => t.ChsClPaveVoies).HasForeignKey(u => new { u.ChsPaveVoieIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClPaveVoie>().ToTable("CL_PAVE_VOIE_CHS","CHS");
            modelBuilder.Entity<ChsClPaveVoie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.CdCouChsCouche).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.CdCouChsCouche).HasMaxLength(14);
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.CdCouChsCouche).HasColumnName("CD_COU_CHS__COUCHE");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsDateMs).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsDateMs).HasColumnName("PAVE_CHS__DATE_MS");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsLiaison).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsLiaison).HasMaxLength(15);
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsLiaison).HasColumnName("PAVE_CHS__LIAISON");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsSens).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsSens).HasMaxLength(6);
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsSens).HasColumnName("PAVE_CHS__SENS");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsAbsDeb).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsAbsDeb).HasColumnName("PAVE_CHS__ABS_DEB");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsAbsFin).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveChsAbsFin).HasColumnName("PAVE_CHS__ABS_FIN");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveVoieChsVoie).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveVoieChsVoie).HasMaxLength(6);
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveVoieChsVoie).HasColumnName("PAVE_VOIE_CHS__VOIE");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveVoieChsVoiedeb).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveVoieChsVoiedeb).HasColumnName("PAVE_VOIE_CHS__VOIEDEB");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveVoieChsVoiefin).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.PaveVoieChsVoiefin).HasColumnName("PAVE_VOIE_CHS__VOIEFIN");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsClPaveVoie>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsDictionnaire>().ToTable("DICTIONNAIRE_CHS","CHS");
            modelBuilder.Entity<ChsDictionnaire>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Nom).IsRequired();
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Nom).HasMaxLength(100);
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Nom).HasColumnName("NOM");
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Description).HasMaxLength(255);
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Description).HasColumnName("DESCRIPTION");
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Definition).HasMaxLength(1000);
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Definition).HasColumnName("DEFINITION");
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Motscles).HasMaxLength(255);
            modelBuilder.Entity<ChsDictionnaire>().Property(item => item.Motscles).HasColumnName("MOTSCLES");
            modelBuilder.Entity<ChsCdEvt>().HasMany<ChsEvt>(c => c.ChsEvts).WithRequired(t => t.ChsCdEvt).HasForeignKey(u => new {u.ChsCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdEvt>().ToTable("CD_EVT_CHS","CHS");
            modelBuilder.Entity<ChsCdEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdEvt>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<ChsCdEvt>().Property(item => item.Type).HasMaxLength(25);
            modelBuilder.Entity<ChsCdEvt>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<ChsCdEvt>().Property(item => item.ImpactValueInt).HasColumnName("IMPACT");
            modelBuilder.Entity<ChsCdEvt>().Ignore(item => item.Impact);
            modelBuilder.Entity<ChsEvt>().HasRequired<ChsCdEvt>(c => c.ChsCdEvt).WithMany(t => t.ChsEvts).HasForeignKey(u => new { u.ChsCdEvtIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsEvt>().HasOptional<ChsCdPosit>(c => c.ChsCdPosit).WithMany(t => t.ChsEvts).HasForeignKey(u => new {u.ChsCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsEvt>().ToTable("EVT_CHS","CHS");
            modelBuilder.Entity<ChsEvt>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsEvt>().Property(item => item.CdEvtChsType).IsRequired();
            modelBuilder.Entity<ChsEvt>().Property(item => item.CdEvtChsType).HasMaxLength(25);
            modelBuilder.Entity<ChsEvt>().Property(item => item.CdEvtChsType).HasColumnName("CD_EVT_CHS__TYPE");
            modelBuilder.Entity<ChsEvt>().Property(item => item.IdEvt).IsRequired();
            modelBuilder.Entity<ChsEvt>().Property(item => item.IdEvt).HasColumnName("ID_EVT");
            modelBuilder.Entity<ChsEvt>().Property(item => item.CdPositChsPosit).HasMaxLength(60);
            modelBuilder.Entity<ChsEvt>().Property(item => item.CdPositChsPosit).HasColumnName("CD_POSIT_CHS__POSIT");
            modelBuilder.Entity<ChsEvt>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsEvt>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsEvt>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsEvt>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsEvt>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsEvt>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsEvt>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsEvt>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsEvt>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsEvt>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsEvt>().Property(item => item.DateRel).IsRequired();
            modelBuilder.Entity<ChsEvt>().Property(item => item.DateRel).HasColumnName("DATE_REL");
            modelBuilder.Entity<ChsEvt>().Property(item => item.VstaValueInt).HasColumnName("VSTA");
            modelBuilder.Entity<ChsEvt>().Ignore(item => item.Vsta);
            modelBuilder.Entity<ChsEvt>().Property(item => item.Obsv).HasMaxLength(255);
            modelBuilder.Entity<ChsEvt>().Property(item => item.Obsv).HasColumnName("OBSV");
            modelBuilder.Entity<ChsEvt>().Property(item => item.DateTrt).HasColumnName("DATE_TRT");
            modelBuilder.Entity<ChsCdPosit>().HasMany<ChsEvt>(c => c.ChsEvts).WithOptional(t => t.ChsCdPosit).HasForeignKey(u => new {u.ChsCdPositIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsCdPosit>().ToTable("CD_POSIT_CHS","CHS");
            modelBuilder.Entity<ChsCdPosit>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsCdPosit>().Property(item => item.Posit).IsRequired();
            modelBuilder.Entity<ChsCdPosit>().Property(item => item.Posit).HasMaxLength(60);
            modelBuilder.Entity<ChsCdPosit>().Property(item => item.Posit).HasColumnName("POSIT");
            modelBuilder.Entity<ChsNeAdmin>().ToTable("NE_ADMIN_CHS","CHS");
            modelBuilder.Entity<ChsNeAdmin>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.NeAdmiss).HasColumnName("NE_ADMISS");
            modelBuilder.Entity<ChsNeAdmin>().Property(item => item.DateAdmiss).HasColumnName("DATE_ADMISS");
            modelBuilder.Entity<ChsContact>().HasRequired<ChsDoc>(c => c.ChsDoc).WithMany(t => t.ChsContacts).HasForeignKey(u => new { u.ChsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsContact>().ToTable("CONTACT_CHS","CHS");
            modelBuilder.Entity<ChsContact>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsContact>().Property(item => item.DocChsId).IsRequired();
            modelBuilder.Entity<ChsContact>().Property(item => item.DocChsId).HasColumnName("DOC_CHS__ID");
            modelBuilder.Entity<ChsContact>().Property(item => item.Givenname).HasMaxLength(60);
            modelBuilder.Entity<ChsContact>().Property(item => item.Givenname).HasColumnName("GIVENNAME");
            modelBuilder.Entity<ChsContact>().Property(item => item.Sn).HasMaxLength(60);
            modelBuilder.Entity<ChsContact>().Property(item => item.Sn).HasColumnName("SN");
            modelBuilder.Entity<ChsContact>().Property(item => item.Cn).HasMaxLength(125);
            modelBuilder.Entity<ChsContact>().Property(item => item.Cn).HasColumnName("CN");
            modelBuilder.Entity<ChsContact>().Property(item => item.O).HasMaxLength(60);
            modelBuilder.Entity<ChsContact>().Property(item => item.O).HasColumnName("O");
            modelBuilder.Entity<ChsContact>().Property(item => item.Mail).HasMaxLength(60);
            modelBuilder.Entity<ChsContact>().Property(item => item.Mail).HasColumnName("MAIL");
            modelBuilder.Entity<ChsContact>().Property(item => item.Telephonenumber).HasMaxLength(20);
            modelBuilder.Entity<ChsContact>().Property(item => item.Telephonenumber).HasColumnName("TELEPHONENUMBER");
            modelBuilder.Entity<ChsContact>().Property(item => item.Mobile).HasMaxLength(20);
            modelBuilder.Entity<ChsContact>().Property(item => item.Mobile).HasColumnName("MOBILE");
            modelBuilder.Entity<ChsContact>().Property(item => item.Facsimiletelephonenumber).HasMaxLength(20);
            modelBuilder.Entity<ChsContact>().Property(item => item.Facsimiletelephonenumber).HasColumnName("FACSIMILETELEPHONENUMBER");
            modelBuilder.Entity<ChsContact>().Property(item => item.Street).HasMaxLength(60);
            modelBuilder.Entity<ChsContact>().Property(item => item.Street).HasColumnName("STREET");
            modelBuilder.Entity<ChsContact>().Property(item => item.Mozillaworkstreet2).HasMaxLength(60);
            modelBuilder.Entity<ChsContact>().Property(item => item.Mozillaworkstreet2).HasColumnName("MOZILLAWORKSTREET2");
            modelBuilder.Entity<ChsContact>().Property(item => item.L).HasMaxLength(60);
            modelBuilder.Entity<ChsContact>().Property(item => item.L).HasColumnName("L");
            modelBuilder.Entity<ChsContact>().Property(item => item.Postalcode).HasMaxLength(12);
            modelBuilder.Entity<ChsContact>().Property(item => item.Postalcode).HasColumnName("POSTALCODE");
            modelBuilder.Entity<ChsContact>().Property(item => item.Modifytimestamp).HasColumnName("MODIFYTIMESTAMP");
            modelBuilder.Entity<ChsClsDoc>().HasRequired<ChsCls>(c => c.ChsCls).WithMany(t => t.ChsClsDocs).HasForeignKey(u => new { u.ChsClsIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClsDoc>().HasRequired<ChsDoc>(c => c.ChsDoc).WithMany(t => t.ChsClsDocs).HasForeignKey(u => new { u.ChsDocIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<ChsClsDoc>().ToTable("CLS_DOC_CHS","CHS");
            modelBuilder.Entity<ChsClsDoc>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<ChsClsDoc>().Property(item => item.ClsChsId).IsRequired();
            modelBuilder.Entity<ChsClsDoc>().Property(item => item.ClsChsId).HasColumnName("CLS_CHS__ID");
            modelBuilder.Entity<ChsClsDoc>().Property(item => item.DocChsId).IsRequired();
            modelBuilder.Entity<ChsClsDoc>().Property(item => item.DocChsId).HasColumnName("DOC_CHS__ID");
            modelBuilder.Entity<ChsClsDoc>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<ChsClsDoc>().Ignore(item => item.Defaut);
            modelBuilder.Entity<ChsClsDoc>().Property(item => item.Dossier).HasMaxLength(15);
            modelBuilder.Entity<ChsClsDoc>().Property(item => item.Dossier).HasColumnName("DOSSIER");
        }
    }
}
