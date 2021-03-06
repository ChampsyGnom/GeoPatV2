using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextMapinfo : DataContextBase
    {
        public DataContextMapinfo(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<MapinfoTbGroupe> MapinfoTbGroupes { get; set; }
        
        public DbSet<MapinfoTbTemplate> MapinfoTbTemplates { get; set; }
        
        public DbSet<MapinfoTbTemplateCfg> MapinfoTbTemplateCfgs { get; set; }
        
        public DbSet<MapinfoTbGroupeCfg> MapinfoTbGroupeCfgs { get; set; }
        
        public DbSet<MapinfoTbMap> MapinfoTbMaps { get; set; }
        
        public DbSet<MapinfoCdMotsReserve> MapinfoCdMotsReserves { get; set; }
        
        public DbSet<MapinfoTbMapCfg> MapinfoTbMapCfgs { get; set; }
        
        public DbSet<MapinfoSysUser> MapinfoSysUsers { get; set; }
        
        public DbSet<MapinfoTbMapGeoStyle> MapinfoTbMapGeoStyles { get; set; }
        
        public DbSet<MapinfoTbModele> MapinfoTbModeles { get; set; }
        
        public DbSet<MapinfoTbModeleCfg> MapinfoTbModeleCfgs { get; set; }
        
        public DbSet<MapinfoTbAnaThema> MapinfoTbAnaThemas { get; set; }
        
        public DbSet<MapinfoSiModel> MapinfoSiModels { get; set; }
        
        public DbSet<MapinfoSiZone> MapinfoSiZones { get; set; }
        
        public DbSet<MapinfoSiStyleValeur> MapinfoSiStyleValeurs { get; set; }
        
        public DbSet<MapinfoTbMapMetier> MapinfoTbMapMetiers { get; set; }
        
        public DbSet<MapinfoTbMapMetierCfg> MapinfoTbMapMetierCfgs { get; set; }
        
        public DbSet<MapinfoTbMapMetierColumns> MapinfoTbMapMetierColumnss { get; set; }
        
        public DbSet<MapinfoSiModelPredef> MapinfoSiModelPredefs { get; set; }
        
        public DbSet<MapinfoSiPrp> MapinfoSiPrps { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<MapinfoTbGroupe>().HasRequired<MapinfoTbTemplate>(c => c.MapinfoTbTemplate).WithMany(t => t.MapinfoTbGroupes).HasForeignKey(u => new { u.MapinfoTbTemplateIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbGroupe>().HasMany<MapinfoTbMap>(c => c.MapinfoTbMaps).WithRequired(t => t.MapinfoTbGroupe).HasForeignKey(u => new { u.MapinfoTbGroupeIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbGroupe>().HasMany<MapinfoTbGroupeCfg>(c => c.MapinfoTbGroupeCfgs).WithRequired(t => t.MapinfoTbGroupe).HasForeignKey(u => new { u.MapinfoTbGroupeIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbGroupe>().ToTable("TB_GROUPE","MAPINFO");
            modelBuilder.Entity<MapinfoTbGroupe>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.TbModeleModele).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.TbModeleModele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.TbModeleModele).HasColumnName("TB_MODELE__MODELE");
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.TbTemplateTpl).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.TbTemplateTpl).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.TbTemplateTpl).HasColumnName("TB_TEMPLATE__TPL");
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Groupe).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Groupe).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Groupe).HasColumnName("GROUPE");
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Titre).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Titre).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Titre).HasColumnName("TITRE");
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Rang).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Rang).HasColumnName("RANG");
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Chemin).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Chemin).HasColumnName("CHEMIN");
            modelBuilder.Entity<MapinfoTbGroupe>().Property(item => item.Boardvisible).HasColumnName("BOARDVISIBLE");
            modelBuilder.Entity<MapinfoTbTemplate>().HasRequired<MapinfoTbModele>(c => c.MapinfoTbModele).WithMany(t => t.MapinfoTbTemplates).HasForeignKey(u => new { u.MapinfoTbModeleIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbTemplate>().HasMany<MapinfoTbTemplateCfg>(c => c.MapinfoTbTemplateCfgs).WithRequired(t => t.MapinfoTbTemplate).HasForeignKey(u => new { u.MapinfoTbTemplateIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbTemplate>().HasMany<MapinfoTbGroupe>(c => c.MapinfoTbGroupes).WithRequired(t => t.MapinfoTbTemplate).HasForeignKey(u => new { u.MapinfoTbTemplateIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbTemplate>().ToTable("TB_TEMPLATE","MAPINFO");
            modelBuilder.Entity<MapinfoTbTemplate>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.TbModeleModele).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.TbModeleModele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.TbModeleModele).HasColumnName("TB_MODELE__MODELE");
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Tpl).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Tpl).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Tpl).HasColumnName("TPL");
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Titre).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Titre).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Titre).HasColumnName("TITRE");
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Rang).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Rang).HasColumnName("RANG");
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Chemin).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Chemin).HasColumnName("CHEMIN");
            modelBuilder.Entity<MapinfoTbTemplate>().Property(item => item.Isgeocode).HasColumnName("ISGEOCODE");
            modelBuilder.Entity<MapinfoTbTemplateCfg>().HasRequired<MapinfoTbTemplate>(c => c.MapinfoTbTemplate).WithMany(t => t.MapinfoTbTemplateCfgs).HasForeignKey(u => new { u.MapinfoTbTemplateIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbTemplateCfg>().ToTable("TB_TEMPLATE_CFG","MAPINFO");
            modelBuilder.Entity<MapinfoTbTemplateCfg>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.TbModeleModele).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.TbModeleModele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.TbModeleModele).HasColumnName("TB_MODELE__MODELE");
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.TbTemplateTpl).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.TbTemplateTpl).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.TbTemplateTpl).HasColumnName("TB_TEMPLATE__TPL");
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.Usercode).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.Usercode).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.Usercode).HasColumnName("USERCODE");
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.CodePrp).HasMaxLength(20);
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.ValPrp).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbTemplateCfg>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<MapinfoTbGroupeCfg>().HasRequired<MapinfoTbGroupe>(c => c.MapinfoTbGroupe).WithMany(t => t.MapinfoTbGroupeCfgs).HasForeignKey(u => new { u.MapinfoTbGroupeIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbGroupeCfg>().ToTable("TB_GROUPE_CFG","MAPINFO");
            modelBuilder.Entity<MapinfoTbGroupeCfg>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbModeleModele).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbModeleModele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbModeleModele).HasColumnName("TB_MODELE__MODELE");
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbTemplateTpl).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbTemplateTpl).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbTemplateTpl).HasColumnName("TB_TEMPLATE__TPL");
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbGroupeGroupe).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbGroupeGroupe).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.TbGroupeGroupe).HasColumnName("TB_GROUPE__GROUPE");
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.Usercode).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.Usercode).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.Usercode).HasColumnName("USERCODE");
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.CodePrp).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.ValPrp).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbGroupeCfg>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<MapinfoTbMap>().HasRequired<MapinfoTbGroupe>(c => c.MapinfoTbGroupe).WithMany(t => t.MapinfoTbMaps).HasForeignKey(u => new { u.MapinfoTbGroupeIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbMap>().HasMany<MapinfoTbMapCfg>(c => c.MapinfoTbMapCfgs).WithRequired(t => t.MapinfoTbMap).HasForeignKey(u => new { u.MapinfoTbMapIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbMap>().ToTable("TB_MAP","MAPINFO");
            modelBuilder.Entity<MapinfoTbMap>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbModeleModele).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbModeleModele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbModeleModele).HasColumnName("TB_MODELE__MODELE");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbTemplateTpl).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbTemplateTpl).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbTemplateTpl).HasColumnName("TB_TEMPLATE__TPL");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbGroupeGroupe).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbGroupeGroupe).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.TbGroupeGroupe).HasColumnName("TB_GROUPE__GROUPE");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Map).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Map).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Map).HasColumnName("MAP");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Titre).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Titre).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Titre).HasColumnName("TITRE");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Objtype).HasColumnName("OBJTYPE");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Rang).HasColumnName("RANG");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.MapOrder).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.MapOrder).HasColumnName("MAP_ORDER");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Owner).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Owner).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Owner).HasColumnName("OWNER");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Isgeocode).HasColumnName("ISGEOCODE");
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Chemin).IsRequired();
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Chemin).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbMap>().Property(item => item.Chemin).HasColumnName("CHEMIN");
            modelBuilder.Entity<MapinfoCdMotsReserve>().ToTable("CD_MOTS_RESERVE","MAPINFO");
            modelBuilder.Entity<MapinfoCdMotsReserve>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoCdMotsReserve>().Property(item => item.Keyword).IsRequired();
            modelBuilder.Entity<MapinfoCdMotsReserve>().Property(item => item.Keyword).HasMaxLength(50);
            modelBuilder.Entity<MapinfoCdMotsReserve>().Property(item => item.Keyword).HasColumnName("KEYWORD");
            modelBuilder.Entity<MapinfoTbMapCfg>().HasRequired<MapinfoTbMap>(c => c.MapinfoTbMap).WithMany(t => t.MapinfoTbMapCfgs).HasForeignKey(u => new { u.MapinfoTbMapIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbMapCfg>().ToTable("TB_MAP_CFG","MAPINFO");
            modelBuilder.Entity<MapinfoTbMapCfg>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbModeleModele).IsRequired();
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbModeleModele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbModeleModele).HasColumnName("TB_MODELE__MODELE");
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbTemplateTpl).IsRequired();
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbTemplateTpl).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbTemplateTpl).HasColumnName("TB_TEMPLATE__TPL");
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbGroupeGroupe).IsRequired();
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbGroupeGroupe).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbGroupeGroupe).HasColumnName("TB_GROUPE__GROUPE");
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbMapMap).IsRequired();
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbMapMap).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.TbMapMap).HasColumnName("TB_MAP__MAP");
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.Usercode).IsRequired();
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.Usercode).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.Usercode).HasColumnName("USERCODE");
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.CodePrp).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.ValPrp).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbMapCfg>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<MapinfoSysUser>().ToTable("SYS_USER_MAPINFO","MAPINFO");
            modelBuilder.Entity<MapinfoSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeTable).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeColonne).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.NomUser).HasMaxLength(150);
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.ValPrp).HasMaxLength(500);
            modelBuilder.Entity<MapinfoSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().ToTable("TB_MAP_GEO_STYLE","MAPINFO");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Map).IsRequired();
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Map).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Map).HasColumnName("MAP");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Username).IsRequired();
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Username).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Username).HasColumnName("USERNAME");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Representation).IsRequired();
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Representation).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Representation).HasColumnName("REPRESENTATION");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Color).IsRequired();
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Color).HasColumnName("COLOR");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Width).IsRequired();
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Width).HasColumnName("WIDTH");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Font).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Font).HasColumnName("FONT");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Ascii).HasColumnName("ASCII");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Style).HasColumnName("STYLE");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Interleaved).HasColumnName("INTERLEAVED");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Bordercolor).HasColumnName("BORDERCOLOR");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Borderstyle).HasColumnName("BORDERSTYLE");
            modelBuilder.Entity<MapinfoTbMapGeoStyle>().Property(item => item.Regionbackground).HasColumnName("REGIONBACKGROUND");
            modelBuilder.Entity<MapinfoTbModele>().HasMany<MapinfoTbModeleCfg>(c => c.MapinfoTbModeleCfgs).WithRequired(t => t.MapinfoTbModele).HasForeignKey(u => new { u.MapinfoTbModeleIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbModele>().HasMany<MapinfoTbTemplate>(c => c.MapinfoTbTemplates).WithRequired(t => t.MapinfoTbModele).HasForeignKey(u => new { u.MapinfoTbModeleIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbModele>().ToTable("TB_MODELE","MAPINFO");
            modelBuilder.Entity<MapinfoTbModele>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.Modele).IsRequired();
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.Modele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.Modele).HasColumnName("MODELE");
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.Ordre).HasColumnName("ORDRE");
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.LayerName).IsRequired();
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.LayerName).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.LayerName).HasColumnName("LAYER_NAME");
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.Path).IsRequired();
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.Path).HasMaxLength(255);
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.Path).HasColumnName("PATH");
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.TypeModele).IsRequired();
            modelBuilder.Entity<MapinfoTbModele>().Property(item => item.TypeModele).HasColumnName("TYPE_MODELE");
            modelBuilder.Entity<MapinfoTbModeleCfg>().HasRequired<MapinfoTbModele>(c => c.MapinfoTbModele).WithMany(t => t.MapinfoTbModeleCfgs).HasForeignKey(u => new { u.MapinfoTbModeleIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbModeleCfg>().ToTable("TB_MODELE_CFG","MAPINFO");
            modelBuilder.Entity<MapinfoTbModeleCfg>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.TbModeleModele).IsRequired();
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.TbModeleModele).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.TbModeleModele).HasColumnName("TB_MODELE__MODELE");
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.Usercode).IsRequired();
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.Usercode).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.Usercode).HasColumnName("USERCODE");
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.CodePrp).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.ValPrp).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbModeleCfg>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<MapinfoTbAnaThema>().ToTable("TB_ANA_THEMA","MAPINFO");
            modelBuilder.Entity<MapinfoTbAnaThema>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Usercode).IsRequired();
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Usercode).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Usercode).HasColumnName("USERCODE");
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Map).IsRequired();
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Map).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Map).HasColumnName("MAP");
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Modele).IsRequired();
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Modele).HasMaxLength(100);
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.Modele).HasColumnName("MODELE");
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.CodePrp).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.ValPrp).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbAnaThema>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<MapinfoSiModel>().HasMany<MapinfoSiZone>(c => c.MapinfoSiZones).WithRequired(t => t.MapinfoSiModel).HasForeignKey(u => new { u.MapinfoSiModelIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoSiModel>().ToTable("SI_MODEL","MAPINFO");
            modelBuilder.Entity<MapinfoSiModel>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoSiModel>().Property(item => item.NomModel).IsRequired();
            modelBuilder.Entity<MapinfoSiModel>().Property(item => item.NomModel).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiModel>().Property(item => item.NomModel).HasColumnName("NOM_MODEL");
            modelBuilder.Entity<MapinfoSiZone>().HasRequired<MapinfoSiModel>(c => c.MapinfoSiModel).WithMany(t => t.MapinfoSiZones).HasForeignKey(u => new { u.MapinfoSiModelIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoSiZone>().HasMany<MapinfoSiStyleValeur>(c => c.MapinfoSiStyleValeurs).WithRequired(t => t.MapinfoSiZone).HasForeignKey(u => new { u.MapinfoSiZoneIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoSiZone>().ToTable("SI_ZONE","MAPINFO");
            modelBuilder.Entity<MapinfoSiZone>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.SiModelNomModel).IsRequired();
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.SiModelNomModel).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.SiModelNomModel).HasColumnName("SI_MODEL__NOM_MODEL");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.NomZone).IsRequired();
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.NomZone).HasMaxLength(50);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.NomZone).HasColumnName("NOM_ZONE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.SchemaZone).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.SchemaZone).HasColumnName("SCHEMA_ZONE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.TableZone).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.TableZone).HasColumnName("TABLE_ZONE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.FieldZone).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.FieldZone).HasColumnName("FIELD_ZONE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.TypeZone).HasMaxLength(25);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.TypeZone).HasColumnName("TYPE_ZONE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.Position).HasColumnName("POSITION");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.Hauteur).HasColumnName("HAUTEUR");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.Valeur).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.ValeurSub).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.ValeurSub).HasColumnName("VALEUR_SUB");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.AnneeMesure).HasColumnName("ANNEE_MESURE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.PositionEtiquette).HasMaxLength(20);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.PositionEtiquette).HasColumnName("POSITION_ETIQUETTE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.ChampEtiquette).HasMaxLength(50);
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.ChampEtiquette).HasColumnName("CHAMP_ETIQUETTE");
            modelBuilder.Entity<MapinfoSiZone>().Property(item => item.Withcote).HasColumnName("WITHCOTE");
            modelBuilder.Entity<MapinfoSiStyleValeur>().HasRequired<MapinfoSiZone>(c => c.MapinfoSiZone).WithMany(t => t.MapinfoSiStyleValeurs).HasForeignKey(u => new { u.MapinfoSiZoneIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoSiStyleValeur>().ToTable("SI_STYLE_VALEUR","MAPINFO");
            modelBuilder.Entity<MapinfoSiStyleValeur>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.SiModelNomModel).IsRequired();
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.SiModelNomModel).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.SiModelNomModel).HasColumnName("SI_MODEL__NOM_MODEL");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.SiZoneNomZone).IsRequired();
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.SiZoneNomZone).HasMaxLength(50);
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.SiZoneNomZone).HasColumnName("SI_ZONE__NOM_ZONE");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Valeur).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Couleur).HasMaxLength(9);
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Border).HasColumnName("BORDER");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Taille).HasColumnName("TAILLE");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Representation).HasMaxLength(20);
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Representation).HasColumnName("REPRESENTATION");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Chemin).HasMaxLength(1024);
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Chemin).HasColumnName("CHEMIN");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.FontName).HasMaxLength(50);
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.FontName).HasColumnName("FONT_NAME");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.FontChar).HasColumnName("FONT_CHAR");
            modelBuilder.Entity<MapinfoSiStyleValeur>().Property(item => item.Opacity).HasColumnName("OPACITY");
            modelBuilder.Entity<MapinfoTbMapMetier>().HasMany<MapinfoTbMapMetierCfg>(c => c.MapinfoTbMapMetierCfgs).WithRequired(t => t.MapinfoTbMapMetier).HasForeignKey(u => new { u.MapinfoTbMapMetierIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbMapMetier>().HasMany<MapinfoTbMapMetierColumns>(c => c.MapinfoTbMapMetierColumnss).WithRequired(t => t.MapinfoTbMapMetier).HasForeignKey(u => new { u.MapinfoTbMapMetierIdPk  }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbMapMetier>().ToTable("TB_MAP_METIER","MAPINFO");
            modelBuilder.Entity<MapinfoTbMapMetier>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.SchemaName).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.SchemaName).HasMaxLength(20);
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.SchemaName).HasColumnName("SCHEMA_NAME");
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.TableName).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.TableName).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.Title).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.Title).HasColumnName("TITLE");
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.MapOrder).HasColumnName("MAP_ORDER");
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.Rang).HasColumnName("RANG");
            modelBuilder.Entity<MapinfoTbMapMetier>().Property(item => item.Objtype).HasColumnName("OBJTYPE");
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().HasRequired<MapinfoTbMapMetier>(c => c.MapinfoTbMapMetier).WithMany(t => t.MapinfoTbMapMetierCfgs).HasForeignKey(u => new { u.MapinfoTbMapMetierIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().ToTable("TB_MAP_METIER_CFG","MAPINFO");
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.TbMapMetierSchemaName).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.TbMapMetierSchemaName).HasMaxLength(20);
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.TbMapMetierSchemaName).HasColumnName("TB_MAP_METIER__SCHEMA_NAME");
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.TbMapMetierTableName).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.TbMapMetierTableName).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.TbMapMetierTableName).HasColumnName("TB_MAP_METIER__TABLE_NAME");
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.Usercode).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.Usercode).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.Usercode).HasColumnName("USERCODE");
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.CodePrp).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.ValPrp).HasMaxLength(254);
            modelBuilder.Entity<MapinfoTbMapMetierCfg>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().HasRequired<MapinfoTbMapMetier>(c => c.MapinfoTbMapMetier).WithMany(t => t.MapinfoTbMapMetierColumnss).HasForeignKey(u => new { u.MapinfoTbMapMetierIdPk }).WillCascadeOnDelete(false);
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().ToTable("TB_MAP_METIER_COLUMNS","MAPINFO");
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.TbMapMetierSchemaName).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.TbMapMetierSchemaName).HasMaxLength(20);
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.TbMapMetierSchemaName).HasColumnName("TB_MAP_METIER__SCHEMA_NAME");
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.TbMapMetierTableName).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.TbMapMetierTableName).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.TbMapMetierTableName).HasColumnName("TB_MAP_METIER__TABLE_NAME");
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColName).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColName).HasMaxLength(100);
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColName).HasColumnName("COL_NAME");
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColLibelle).IsRequired();
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColLibelle).HasMaxLength(50);
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColLibelle).HasColumnName("COL_LIBELLE");
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColOrder).HasColumnName("COL_ORDER");
            modelBuilder.Entity<MapinfoTbMapMetierColumns>().Property(item => item.ColVisible).HasColumnName("COL_VISIBLE");
            modelBuilder.Entity<MapinfoSiModelPredef>().ToTable("SI_MODEL_PREDEF","MAPINFO");
            modelBuilder.Entity<MapinfoSiModelPredef>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.Nomtable).IsRequired();
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.Nomtable).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.Nomtable).HasColumnName("NOMTABLE");
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.Nomschema).IsRequired();
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.Nomschema).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.Nomschema).HasColumnName("NOMSCHEMA");
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.NomModel).IsRequired();
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.NomModel).HasMaxLength(100);
            modelBuilder.Entity<MapinfoSiModelPredef>().Property(item => item.NomModel).HasColumnName("NOM_MODEL");
            modelBuilder.Entity<MapinfoSiPrp>().ToTable("SI_PRP","MAPINFO");
            modelBuilder.Entity<MapinfoSiPrp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<MapinfoSiPrp>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<MapinfoSiPrp>().Property(item => item.CodePrp).HasMaxLength(50);
            modelBuilder.Entity<MapinfoSiPrp>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<MapinfoSiPrp>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<MapinfoSiPrp>().Property(item => item.ValPrp).HasMaxLength(1024);
            modelBuilder.Entity<MapinfoSiPrp>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
        }
    }
}
