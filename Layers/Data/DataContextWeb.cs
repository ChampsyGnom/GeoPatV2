using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextWeb : DataContextBase
    {
        public DataContextWeb(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<WebNode> WebNodes { get; set; }
        
        public DbSet<WebCdNode> WebCdNodes { get; set; }
        
        public DbSet<WebNodeParam> WebNodeParams { get; set; }
        
        public DbSet<WebSysUser> WebSysUsers { get; set; }
        
        public DbSet<WebStyle> WebStyles { get; set; }
        
        public DbSet<WebStyleRule> WebStyleRules { get; set; }
        
        public DbSet<WebModele> WebModeles { get; set; }
        
        public DbSet<WebCdModele> WebCdModeles { get; set; }
        
        public DbSet<WebModeleWebNode> WebModeleWebNodes { get; set; }
        
        public DbSet<WebNodeWebStyle> WebNodeWebStyles { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<WebNode>().HasRequired<WebCdNode>(c => c.WebCdNode).WithMany(t => t.WebNodes).HasForeignKey(u => new { u.WebCdNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebNode>().HasMany<WebNodeParam>(c => c.WebNodeParams).WithRequired(t => t.WebNode).HasForeignKey(u => new {u.WebNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebNode>().HasMany<WebModeleWebNode>(c => c.WebModeleWebNodes).WithRequired(t => t.WebNode).HasForeignKey(u => new {u.WebNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebNode>().HasMany<WebNodeWebStyle>(c => c.WebNodeWebStyles).WithRequired(t => t.WebNode).HasForeignKey(u => new {u.WebNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebNode>().ToTable("NODE_WEB","WEB");
            modelBuilder.Entity<WebNode>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebNode>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<WebNode>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<WebNode>().Property(item => item.CdNodeWebName).IsRequired();
            modelBuilder.Entity<WebNode>().Property(item => item.CdNodeWebName).HasMaxLength(255);
            modelBuilder.Entity<WebNode>().Property(item => item.CdNodeWebName).HasColumnName("CD_NODE_WEB__NAME");
            modelBuilder.Entity<WebNode>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<WebNode>().Property(item => item.Libelle).HasMaxLength(255);
            modelBuilder.Entity<WebNode>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<WebNode>().Property(item => item.ParentId).HasColumnName("PARENT_ID");
            modelBuilder.Entity<WebNode>().Property(item => item.TreeOrder).HasColumnName("TREE_ORDER");
            modelBuilder.Entity<WebCdNode>().HasMany<WebNode>(c => c.WebNodes).WithRequired(t => t.WebCdNode).HasForeignKey(u => new {u.WebCdNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebCdNode>().ToTable("CD_NODE_WEB","WEB");
            modelBuilder.Entity<WebCdNode>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebCdNode>().Property(item => item.Name).IsRequired();
            modelBuilder.Entity<WebCdNode>().Property(item => item.Name).HasMaxLength(255);
            modelBuilder.Entity<WebCdNode>().Property(item => item.Name).HasColumnName("NAME");
            modelBuilder.Entity<WebNodeParam>().HasRequired<WebNode>(c => c.WebNode).WithMany(t => t.WebNodeParams).HasForeignKey(u => new { u.WebNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebNodeParam>().ToTable("NODE_PARAM_WEB","WEB");
            modelBuilder.Entity<WebNodeParam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebNodeParam>().Property(item => item.NodeWebId).IsRequired();
            modelBuilder.Entity<WebNodeParam>().Property(item => item.NodeWebId).HasColumnName("NODE_WEB__ID");
            modelBuilder.Entity<WebNodeParam>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<WebNodeParam>().Property(item => item.Code).HasMaxLength(255);
            modelBuilder.Entity<WebNodeParam>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<WebNodeParam>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<WebNodeParam>().Property(item => item.Valeur).HasMaxLength(255);
            modelBuilder.Entity<WebNodeParam>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<WebSysUser>().ToTable("SYS_USER_WEB","WEB");
            modelBuilder.Entity<WebSysUser>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeDbs).IsRequired();
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeDbs).HasMaxLength(50);
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeDbs).HasColumnName("CODE_DBS");
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeTable).IsRequired();
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeTable).HasMaxLength(200);
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeTable).HasColumnName("CODE_TABLE");
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeColonne).IsRequired();
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeColonne).HasMaxLength(200);
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodeColonne).HasColumnName("CODE_COLONNE");
            modelBuilder.Entity<WebSysUser>().Property(item => item.NomUser).IsRequired();
            modelBuilder.Entity<WebSysUser>().Property(item => item.NomUser).HasMaxLength(200);
            modelBuilder.Entity<WebSysUser>().Property(item => item.NomUser).HasColumnName("NOM_USER");
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodePrp).IsRequired();
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodePrp).HasMaxLength(255);
            modelBuilder.Entity<WebSysUser>().Property(item => item.CodePrp).HasColumnName("CODE_PRP");
            modelBuilder.Entity<WebSysUser>().Property(item => item.ValPrp).IsRequired();
            modelBuilder.Entity<WebSysUser>().Property(item => item.ValPrp).HasMaxLength(255);
            modelBuilder.Entity<WebSysUser>().Property(item => item.ValPrp).HasColumnName("VAL_PRP");
            modelBuilder.Entity<WebStyle>().HasMany<WebStyleRule>(c => c.WebStyleRules).WithRequired(t => t.WebStyle).HasForeignKey(u => new {u.WebStyleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebStyle>().HasMany<WebNodeWebStyle>(c => c.WebNodeWebStyles).WithRequired(t => t.WebStyle).HasForeignKey(u => new {u.WebStyleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebStyle>().ToTable("STYLE_WEB","WEB");
            modelBuilder.Entity<WebStyle>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebStyle>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<WebStyle>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<WebStyle>().Property(item => item.SchemaName).HasMaxLength(255);
            modelBuilder.Entity<WebStyle>().Property(item => item.SchemaName).HasColumnName("SCHEMA_NAME");
            modelBuilder.Entity<WebStyle>().Property(item => item.TableName).HasMaxLength(255);
            modelBuilder.Entity<WebStyle>().Property(item => item.TableName).HasColumnName("TABLE_NAME");
            modelBuilder.Entity<WebStyle>().Property(item => item.ColumnName).HasMaxLength(255);
            modelBuilder.Entity<WebStyle>().Property(item => item.ColumnName).HasColumnName("COLUMN_NAME");
            modelBuilder.Entity<WebStyle>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<WebStyle>().Property(item => item.Libelle).HasMaxLength(255);
            modelBuilder.Entity<WebStyle>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<WebStyle>().Property(item => item.DefautValueInt).IsRequired();
            modelBuilder.Entity<WebStyle>().Property(item => item.DefautValueInt).HasColumnName("DEFAUT");
            modelBuilder.Entity<WebStyle>().Ignore(item => item.Defaut);
            modelBuilder.Entity<WebStyleRule>().HasRequired<WebStyle>(c => c.WebStyle).WithMany(t => t.WebStyleRules).HasForeignKey(u => new { u.WebStyleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebStyleRule>().ToTable("STYLE_RULE_WEB","WEB");
            modelBuilder.Entity<WebStyleRule>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebStyleRule>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.StyleWebId).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.StyleWebId).HasColumnName("STYLE_WEB__ID");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.Libelle).HasMaxLength(255);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.IncrementRange).HasColumnName("INCREMENT_RANGE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.IsActiveValueInt).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.IsActiveValueInt).HasColumnName("IS_ACTIVE");
            modelBuilder.Entity<WebStyleRule>().Ignore(item => item.IsActive);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.MaxRange).HasColumnName("MAX_RANGE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.MinRange).HasColumnName("MIN_RANGE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.MaxValue).HasColumnName("MAX_VALUE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.MinValue).HasColumnName("MIN_VALUE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.UniqueValue).HasMaxLength(255);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.UniqueValue).HasColumnName("UNIQUE_VALUE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointSize).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointSize).HasColumnName("POINT_SIZE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeColor).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeColor).HasMaxLength(10);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeColor).HasColumnName("POINT_STROKE_COLOR");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeOpacity).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeOpacity).HasColumnName("POINT_STROKE_OPACITY");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeStyle).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeStyle).HasMaxLength(50);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeStyle).HasColumnName("POINT_STROKE_STYLE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeSize).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointStrokeSize).HasColumnName("POINT_STROKE_SIZE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointFillColor).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointFillColor).HasMaxLength(10);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointFillColor).HasColumnName("POINT_FILL_COLOR");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointFillOpacity).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointFillOpacity).HasColumnName("POINT_FILL_OPACITY");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointSymbol).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointSymbol).HasMaxLength(50);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointSymbol).HasColumnName("POINT_SYMBOL");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointImage).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointImage).HasMaxLength(255);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PointImage).HasColumnName("POINT_IMAGE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineSize).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineSize).HasColumnName("LINE_SIZE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeColor).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeColor).HasMaxLength(10);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeColor).HasColumnName("LINE_STROKE_COLOR");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeOpacity).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeOpacity).HasColumnName("LINE_STROKE_OPACITY");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeStyle).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeStyle).HasMaxLength(50);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.LineStrokeStyle).HasColumnName("LINE_STROKE_STYLE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeColor).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeColor).HasMaxLength(10);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeColor).HasColumnName("POLY_STROKE_COLOR");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeOpacity).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeOpacity).HasColumnName("POLY_STROKE_OPACITY");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeStyle).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeStyle).HasMaxLength(50);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeStyle).HasColumnName("POLY_STROKE_STYLE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeSize).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyStrokeSize).HasColumnName("POLY_STROKE_SIZE");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyFillColor).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyFillColor).HasMaxLength(10);
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyFillColor).HasColumnName("POLY_FILL_COLOR");
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyFillOpacity).IsRequired();
            modelBuilder.Entity<WebStyleRule>().Property(item => item.PolyFillOpacity).HasColumnName("POLY_FILL_OPACITY");
            modelBuilder.Entity<WebModele>().HasRequired<WebCdModele>(c => c.WebCdModele).WithMany(t => t.WebModeles).HasForeignKey(u => new { u.WebCdModeleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebModele>().HasMany<WebModeleWebNode>(c => c.WebModeleWebNodes).WithRequired(t => t.WebModele).HasForeignKey(u => new {u.WebModeleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebModele>().ToTable("MODELE_WEB","WEB");
            modelBuilder.Entity<WebModele>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebModele>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<WebModele>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<WebModele>().Property(item => item.CdModeleWebCode).IsRequired();
            modelBuilder.Entity<WebModele>().Property(item => item.CdModeleWebCode).HasMaxLength(50);
            modelBuilder.Entity<WebModele>().Property(item => item.CdModeleWebCode).HasColumnName("CD_MODELE_WEB__CODE");
            modelBuilder.Entity<WebModele>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<WebModele>().Property(item => item.Libelle).HasMaxLength(255);
            modelBuilder.Entity<WebModele>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<WebModele>().Property(item => item.IsPublicValueInt).HasColumnName("IS_PUBLIC");
            modelBuilder.Entity<WebModele>().Ignore(item => item.IsPublic);
            modelBuilder.Entity<WebCdModele>().HasMany<WebModele>(c => c.WebModeles).WithRequired(t => t.WebCdModele).HasForeignKey(u => new {u.WebCdModeleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebCdModele>().ToTable("CD_MODELE_WEB","WEB");
            modelBuilder.Entity<WebCdModele>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebCdModele>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<WebCdModele>().Property(item => item.Code).HasMaxLength(50);
            modelBuilder.Entity<WebCdModele>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<WebCdModele>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<WebCdModele>().Property(item => item.Libelle).HasMaxLength(255);
            modelBuilder.Entity<WebCdModele>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<WebModeleWebNode>().HasRequired<WebNode>(c => c.WebNode).WithMany(t => t.WebModeleWebNodes).HasForeignKey(u => new { u.WebNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebModeleWebNode>().HasRequired<WebModele>(c => c.WebModele).WithMany(t => t.WebModeleWebNodes).HasForeignKey(u => new { u.WebModeleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebModeleWebNode>().ToTable("MODELE_WEB__NODE_WEB","WEB");
            modelBuilder.Entity<WebModeleWebNode>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebModeleWebNode>().Property(item => item.NodeWebId).IsRequired();
            modelBuilder.Entity<WebModeleWebNode>().Property(item => item.NodeWebId).HasColumnName("NODE_WEB__ID");
            modelBuilder.Entity<WebModeleWebNode>().Property(item => item.ModeleWebId).IsRequired();
            modelBuilder.Entity<WebModeleWebNode>().Property(item => item.ModeleWebId).HasColumnName("MODELE_WEB__ID");
            modelBuilder.Entity<WebModeleWebNode>().Property(item => item.MapOrder).HasColumnName("MAP_ORDER");
            modelBuilder.Entity<WebModeleWebNode>().Property(item => item.StyleWebId).HasColumnName("STYLE_WEB__ID");
            modelBuilder.Entity<WebNodeWebStyle>().HasRequired<WebNode>(c => c.WebNode).WithMany(t => t.WebNodeWebStyles).HasForeignKey(u => new { u.WebNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebNodeWebStyle>().HasRequired<WebStyle>(c => c.WebStyle).WithMany(t => t.WebNodeWebStyles).HasForeignKey(u => new { u.WebStyleIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<WebNodeWebStyle>().ToTable("NODE_WEB__STYLE_WEB","WEB");
            modelBuilder.Entity<WebNodeWebStyle>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<WebNodeWebStyle>().Property(item => item.NodeWebId).IsRequired();
            modelBuilder.Entity<WebNodeWebStyle>().Property(item => item.NodeWebId).HasColumnName("NODE_WEB__ID");
            modelBuilder.Entity<WebNodeWebStyle>().Property(item => item.StyleWebId).IsRequired();
            modelBuilder.Entity<WebNodeWebStyle>().Property(item => item.StyleWebId).HasColumnName("STYLE_WEB__ID");
        }
    }
}
