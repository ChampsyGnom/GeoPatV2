using System;
using System.Data.Entity;
using System.Data;
using System.Data.Common;
using Emash.GeoPat.Layers.Data.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Emash.GeoPat.Layers.Data
{
    public partial class DataContextDs : DataContextBase
    {
        public DataContextDs(DbConnection connection) : base(connection,false)
        {
        }
        
        public DbSet<DsMat> DsMats { get; set; }
        
        public DbSet<DsPon> DsPons { get; set; }
        
        public DbSet<DsMatParam> DsMatParams { get; set; }
        
        public DbSet<DsPonParam> DsPonParams { get; set; }
        
        public DbSet<DsTree> DsTrees { get; set; }
        
        public DbSet<DsNode> DsNodes { get; set; }
        
        public DbSet<DsNodeParam> DsNodeParams { get; set; }
        
        public DbSet<DsBpuColor> DsBpuColors { get; set; }
        
        public DbSet<DsTreeResultPave> DsTreeResultPaves { get; set; }
        
        public DbSet<DsTreeResultPaveVoie> DsTreeResultPaveVoies { get; set; }
        
        public DbSet<DsTreeResult> DsTreeResults { get; set; }
        
        public DbSet<DsSimDvp> DsSimDvps { get; set; }
        
        public DbSet<DsSimRec> DsSimRecs { get; set; }
        
        public DbSet<DsSimFis> DsSimFiss { get; set; }
        
        public DbSet<DsSimFisClasse> DsSimFisClasses { get; set; }
        
        public DbSet<DsSimRecValues> DsSimRecValuess { get; set; }
        
        public DbSet<DsSimDvpValues> DsSimDvpValuess { get; set; }
        
        public DbSet<DsSimFisValues> DsSimFisValuess { get; set; }
        
        public DbSet<DsSimCalculTrafic> DsSimCalculTrafics { get; set; }
        
        public DbSet<DsSimResult> DsSimResults { get; set; }
        
        public DbSet<DsSimCalculFis> DsSimCalculFiss { get; set; }
        
        public DbSet<DsSimEntretien> DsSimEntretiens { get; set; }
        
        public DbSet<DsSimEtude> DsSimEtudes { get; set; }
        
        public DbSet<DsSimCalcul> DsSimCalculs { get; set; }
        
        public DbSet<DsTraficColor> DsTraficColors { get; set; }
        
        public DbSet<DsAgrege> DsAgreges { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<DsMat>().HasMany<DsMatParam>(c => c.DsMatParams).WithRequired(t => t.DsMat).HasForeignKey(u => new {u.DsMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsMat>().ToTable("MAT_DS","DS");
            modelBuilder.Entity<DsMat>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsMat>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<DsMat>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<DsMat>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<DsMat>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<DsMat>().Property(item => item.Libelle).HasMaxLength(200);
            modelBuilder.Entity<DsMat>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsMat>().Property(item => item.AgrX).HasMaxLength(15);
            modelBuilder.Entity<DsMat>().Property(item => item.AgrX).HasColumnName("AGR_X");
            modelBuilder.Entity<DsMat>().Property(item => item.IndicX).HasMaxLength(15);
            modelBuilder.Entity<DsMat>().Property(item => item.IndicX).HasColumnName("INDIC_X");
            modelBuilder.Entity<DsMat>().Property(item => item.AgrY).HasMaxLength(15);
            modelBuilder.Entity<DsMat>().Property(item => item.AgrY).HasColumnName("AGR_Y");
            modelBuilder.Entity<DsMat>().Property(item => item.IndicY).HasMaxLength(15);
            modelBuilder.Entity<DsMat>().Property(item => item.IndicY).HasColumnName("INDIC_Y");
            modelBuilder.Entity<DsPon>().HasMany<DsPonParam>(c => c.DsPonParams).WithRequired(t => t.DsPon).HasForeignKey(u => new {u.DsPonIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsPon>().ToTable("PON_DS","DS");
            modelBuilder.Entity<DsPon>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsPon>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<DsPon>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<DsPon>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<DsPon>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<DsPon>().Property(item => item.Libelle).HasMaxLength(200);
            modelBuilder.Entity<DsPon>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsPon>().Property(item => item.Agr).HasMaxLength(15);
            modelBuilder.Entity<DsPon>().Property(item => item.Agr).HasColumnName("AGR");
            modelBuilder.Entity<DsMatParam>().HasRequired<DsMat>(c => c.DsMat).WithMany(t => t.DsMatParams).HasForeignKey(u => new { u.DsMatIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsMatParam>().ToTable("MAT_PARAM_DS","DS");
            modelBuilder.Entity<DsMatParam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsMatParam>().Property(item => item.MatDsCode).IsRequired();
            modelBuilder.Entity<DsMatParam>().Property(item => item.MatDsCode).HasMaxLength(15);
            modelBuilder.Entity<DsMatParam>().Property(item => item.MatDsCode).HasColumnName("MAT_DS__CODE");
            modelBuilder.Entity<DsMatParam>().Property(item => item.X).IsRequired();
            modelBuilder.Entity<DsMatParam>().Property(item => item.X).HasColumnName("X");
            modelBuilder.Entity<DsMatParam>().Property(item => item.Y).IsRequired();
            modelBuilder.Entity<DsMatParam>().Property(item => item.Y).HasColumnName("Y");
            modelBuilder.Entity<DsMatParam>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<DsMatParam>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<DsPonParam>().HasRequired<DsPon>(c => c.DsPon).WithMany(t => t.DsPonParams).HasForeignKey(u => new { u.DsPonIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsPonParam>().ToTable("PON_PARAM_DS","DS");
            modelBuilder.Entity<DsPonParam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsPonParam>().Property(item => item.PonDsCode).IsRequired();
            modelBuilder.Entity<DsPonParam>().Property(item => item.PonDsCode).HasMaxLength(15);
            modelBuilder.Entity<DsPonParam>().Property(item => item.PonDsCode).HasColumnName("PON_DS__CODE");
            modelBuilder.Entity<DsPonParam>().Property(item => item.Indic).IsRequired();
            modelBuilder.Entity<DsPonParam>().Property(item => item.Indic).HasMaxLength(12);
            modelBuilder.Entity<DsPonParam>().Property(item => item.Indic).HasColumnName("INDIC");
            modelBuilder.Entity<DsPonParam>().Property(item => item.Poid).IsRequired();
            modelBuilder.Entity<DsPonParam>().Property(item => item.Poid).HasColumnName("POID");
            modelBuilder.Entity<DsTree>().HasMany<DsNode>(c => c.DsNodes).WithRequired(t => t.DsTree).HasForeignKey(u => new {u.DsTreeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsTree>().HasMany<DsTreeResult>(c => c.DsTreeResults).WithRequired(t => t.DsTree).HasForeignKey(u => new {u.DsTreeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsTree>().ToTable("TREE_DS","DS");
            modelBuilder.Entity<DsTree>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsTree>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsTree>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsTree>().Property(item => item.Libelle).HasMaxLength(200);
            modelBuilder.Entity<DsTree>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsNode>().HasRequired<DsTree>(c => c.DsTree).WithMany(t => t.DsNodes).HasForeignKey(u => new { u.DsTreeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsNode>().HasMany<DsNodeParam>(c => c.DsNodeParams).WithRequired(t => t.DsNode).HasForeignKey(u => new {u.DsNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsNode>().ToTable("NODE_DS","DS");
            modelBuilder.Entity<DsNode>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsNode>().Property(item => item.TreeDsId).IsRequired();
            modelBuilder.Entity<DsNode>().Property(item => item.TreeDsId).HasColumnName("TREE_DS__ID");
            modelBuilder.Entity<DsNode>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsNode>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsNode>().Property(item => item.Libelle).HasMaxLength(200);
            modelBuilder.Entity<DsNode>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsNode>().Property(item => item.Type).IsRequired();
            modelBuilder.Entity<DsNode>().Property(item => item.Type).HasMaxLength(100);
            modelBuilder.Entity<DsNode>().Property(item => item.Type).HasColumnName("TYPE");
            modelBuilder.Entity<DsNode>().Property(item => item.ParentId).IsRequired();
            modelBuilder.Entity<DsNode>().Property(item => item.ParentId).HasColumnName("PARENT_ID");
            modelBuilder.Entity<DsNode>().Property(item => item.Technique).HasMaxLength(100);
            modelBuilder.Entity<DsNode>().Property(item => item.Technique).HasColumnName("TECHNIQUE");
            modelBuilder.Entity<DsNode>().Property(item => item.Structure).HasMaxLength(100);
            modelBuilder.Entity<DsNode>().Property(item => item.Structure).HasColumnName("STRUCTURE");
            modelBuilder.Entity<DsNode>().Property(item => item.NbSi).HasColumnName("NB_SI");
            modelBuilder.Entity<DsNode>().Property(item => item.IsForTrue).IsRequired();
            modelBuilder.Entity<DsNode>().Property(item => item.IsForTrue).HasColumnName("IS_FOR_TRUE");
            modelBuilder.Entity<DsNodeParam>().HasRequired<DsNode>(c => c.DsNode).WithMany(t => t.DsNodeParams).HasForeignKey(u => new { u.DsNodeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsNodeParam>().ToTable("NODE_PARAM_DS","DS");
            modelBuilder.Entity<DsNodeParam>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsNodeParam>().Property(item => item.TreeDsId).IsRequired();
            modelBuilder.Entity<DsNodeParam>().Property(item => item.TreeDsId).HasColumnName("TREE_DS__ID");
            modelBuilder.Entity<DsNodeParam>().Property(item => item.NodeDsId).IsRequired();
            modelBuilder.Entity<DsNodeParam>().Property(item => item.NodeDsId).HasColumnName("NODE_DS__ID");
            modelBuilder.Entity<DsNodeParam>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsNodeParam>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsNodeParam>().Property(item => item.Agr).HasMaxLength(20);
            modelBuilder.Entity<DsNodeParam>().Property(item => item.Agr).HasColumnName("AGR");
            modelBuilder.Entity<DsNodeParam>().Property(item => item.Indic).HasMaxLength(20);
            modelBuilder.Entity<DsNodeParam>().Property(item => item.Indic).HasColumnName("INDIC");
            modelBuilder.Entity<DsNodeParam>().Property(item => item.CompareValue).HasColumnName("COMPARE_VALUE");
            modelBuilder.Entity<DsNodeParam>().Property(item => item.CompareOp).HasMaxLength(50);
            modelBuilder.Entity<DsNodeParam>().Property(item => item.CompareOp).HasColumnName("COMPARE_OP");
            modelBuilder.Entity<DsBpuColor>().ToTable("BPU_COLOR_DS","DS");
            modelBuilder.Entity<DsBpuColor>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsBpuColor>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<DsBpuColor>().Property(item => item.Code).HasMaxLength(30);
            modelBuilder.Entity<DsBpuColor>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<DsBpuColor>().Property(item => item.Color).HasMaxLength(11);
            modelBuilder.Entity<DsBpuColor>().Property(item => item.Color).HasColumnName("COLOR");
            modelBuilder.Entity<DsTreeResultPave>().HasRequired<DsTreeResult>(c => c.DsTreeResult).WithMany(t => t.DsTreeResultPaves).HasForeignKey(u => new { u.DsTreeResultIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsTreeResultPave>().HasMany<DsTreeResultPaveVoie>(c => c.DsTreeResultPaveVoies).WithRequired(t => t.DsTreeResultPave).HasForeignKey(u => new {u.DsTreeResultPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsTreeResultPave>().ToTable("TREE_RESULT_PAVE_DS","DS");
            modelBuilder.Entity<DsTreeResultPave>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.TreeDsId).IsRequired();
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.TreeDsId).HasColumnName("TREE_DS__ID");
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.TreeResultDsId).IsRequired();
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.TreeResultDsId).HasColumnName("TREE_RESULT_DS__ID");
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Technique).IsRequired();
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Technique).HasMaxLength(25);
            modelBuilder.Entity<DsTreeResultPave>().Property(item => item.Technique).HasColumnName("TECHNIQUE");
            modelBuilder.Entity<DsTreeResultPaveVoie>().HasRequired<DsTreeResultPave>(c => c.DsTreeResultPave).WithMany(t => t.DsTreeResultPaveVoies).HasForeignKey(u => new { u.DsTreeResultPaveIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsTreeResultPaveVoie>().ToTable("TREE_RESULT_PAVE_VOIE_DS","DS");
            modelBuilder.Entity<DsTreeResultPaveVoie>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeDsId).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeDsId).HasColumnName("TREE_DS__ID");
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultDsId).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultDsId).HasColumnName("TREE_RESULT_DS__ID");
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsLiaison).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsLiaison).HasMaxLength(15);
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsLiaison).HasColumnName("TREE_RESULT_PAVE_DS__LIAISON");
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsSens).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsSens).HasMaxLength(6);
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsSens).HasColumnName("TREE_RESULT_PAVE_DS__SENS");
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsAbsDeb).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.TreeResultPaveDsAbsDeb).HasColumnName("TREE_RESULT_PAVE_DS__ABS_DEB");
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.Voie).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.Voie).HasMaxLength(6);
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.Voie).HasColumnName("VOIE");
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<DsTreeResultPaveVoie>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<DsTreeResult>().HasRequired<DsTree>(c => c.DsTree).WithMany(t => t.DsTreeResults).HasForeignKey(u => new { u.DsTreeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsTreeResult>().HasMany<DsTreeResultPave>(c => c.DsTreeResultPaves).WithRequired(t => t.DsTreeResult).HasForeignKey(u => new {u.DsTreeResultIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsTreeResult>().ToTable("TREE_RESULT_DS","DS");
            modelBuilder.Entity<DsTreeResult>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsTreeResult>().Property(item => item.TreeDsId).IsRequired();
            modelBuilder.Entity<DsTreeResult>().Property(item => item.TreeDsId).HasColumnName("TREE_DS__ID");
            modelBuilder.Entity<DsTreeResult>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsTreeResult>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsTreeResult>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<DsTreeResult>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<DsTreeResult>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsSimDvp>().HasRequired<DsSimEtude>(c => c.DsSimEtude).WithMany(t => t.DsSimDvps).HasForeignKey(u => new { u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimDvp>().HasMany<DsSimCalculTrafic>(c => c.DsSimCalculTrafics).WithOptional(t => t.DsSimDvp).HasForeignKey(u => new {u.DsSimDvpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimDvp>().HasMany<DsSimDvpValues>(c => c.DsSimDvpValuess).WithRequired(t => t.DsSimDvp).HasForeignKey(u => new {u.DsSimDvpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimDvp>().ToTable("SIM_DVP_DS","DS");
            modelBuilder.Entity<DsSimDvp>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimDvp>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimDvp>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimDvp>().Property(item => item.SimEtudeDsId).IsRequired();
            modelBuilder.Entity<DsSimDvp>().Property(item => item.SimEtudeDsId).HasColumnName("SIM_ETUDE_DS__ID");
            modelBuilder.Entity<DsSimDvp>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<DsSimDvp>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsSimDvp>().Property(item => item.Couleur).IsRequired();
            modelBuilder.Entity<DsSimDvp>().Property(item => item.Couleur).HasMaxLength(12);
            modelBuilder.Entity<DsSimDvp>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<DsSimRec>().HasRequired<DsSimEtude>(c => c.DsSimEtude).WithMany(t => t.DsSimRecs).HasForeignKey(u => new { u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimRec>().HasMany<DsSimCalculTrafic>(c => c.DsSimCalculTrafics).WithOptional(t => t.DsSimRec).HasForeignKey(u => new {u.DsSimRecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimRec>().HasMany<DsSimRecValues>(c => c.DsSimRecValuess).WithRequired(t => t.DsSimRec).HasForeignKey(u => new {u.DsSimRecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimRec>().ToTable("SIM_REC_DS","DS");
            modelBuilder.Entity<DsSimRec>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimRec>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimRec>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimRec>().Property(item => item.SimEtudeDsId).IsRequired();
            modelBuilder.Entity<DsSimRec>().Property(item => item.SimEtudeDsId).HasColumnName("SIM_ETUDE_DS__ID");
            modelBuilder.Entity<DsSimRec>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<DsSimRec>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsSimRec>().Property(item => item.Couleur).IsRequired();
            modelBuilder.Entity<DsSimRec>().Property(item => item.Couleur).HasMaxLength(12);
            modelBuilder.Entity<DsSimRec>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<DsSimRec>().Property(item => item.DurreeService).IsRequired();
            modelBuilder.Entity<DsSimRec>().Property(item => item.DurreeService).HasColumnName("DURREE_SERVICE");
            modelBuilder.Entity<DsSimFis>().HasRequired<DsSimEtude>(c => c.DsSimEtude).WithMany(t => t.DsSimFiss).HasForeignKey(u => new { u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimFis>().HasMany<DsSimFisClasse>(c => c.DsSimFisClasses).WithRequired(t => t.DsSimFis).HasForeignKey(u => new {u.DsSimFisIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimFis>().HasMany<DsSimCalculFis>(c => c.DsSimCalculFiss).WithRequired(t => t.DsSimFis).HasForeignKey(u => new {u.DsSimFisIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimFis>().ToTable("SIM_FIS_DS","DS");
            modelBuilder.Entity<DsSimFis>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimFis>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimFis>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimFis>().Property(item => item.SimEtudeDsId).IsRequired();
            modelBuilder.Entity<DsSimFis>().Property(item => item.SimEtudeDsId).HasColumnName("SIM_ETUDE_DS__ID");
            modelBuilder.Entity<DsSimFis>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<DsSimFis>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsSimFis>().Property(item => item.Couleur).IsRequired();
            modelBuilder.Entity<DsSimFis>().Property(item => item.Couleur).HasMaxLength(12);
            modelBuilder.Entity<DsSimFis>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<DsSimFisClasse>().HasRequired<DsSimFis>(c => c.DsSimFis).WithMany(t => t.DsSimFisClasses).HasForeignKey(u => new { u.DsSimFisIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimFisClasse>().HasMany<DsSimFisValues>(c => c.DsSimFisValuess).WithRequired(t => t.DsSimFisClasse).HasForeignKey(u => new {u.DsSimFisClasseIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimFisClasse>().ToTable("SIM_FIS_CLASSE_DS","DS");
            modelBuilder.Entity<DsSimFisClasse>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.SimFisDsId).IsRequired();
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.SimFisDsId).HasColumnName("SIM_FIS_DS__ID");
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.Couleur).IsRequired();
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.Couleur).HasMaxLength(12);
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.PercentMin).IsRequired();
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.PercentMin).HasColumnName("PERCENT_MIN");
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.PercentMax).IsRequired();
            modelBuilder.Entity<DsSimFisClasse>().Property(item => item.PercentMax).HasColumnName("PERCENT_MAX");
            modelBuilder.Entity<DsSimRecValues>().HasRequired<DsSimRec>(c => c.DsSimRec).WithMany(t => t.DsSimRecValuess).HasForeignKey(u => new { u.DsSimRecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimRecValues>().ToTable("SIM_REC_VALUES_DS","DS");
            modelBuilder.Entity<DsSimRecValues>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimRecValues>().Property(item => item.SimRecDsId).IsRequired();
            modelBuilder.Entity<DsSimRecValues>().Property(item => item.SimRecDsId).HasColumnName("SIM_REC_DS__ID");
            modelBuilder.Entity<DsSimRecValues>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<DsSimRecValues>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<DsSimRecValues>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<DsSimRecValues>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<DsSimDvpValues>().HasRequired<DsSimDvp>(c => c.DsSimDvp).WithMany(t => t.DsSimDvpValuess).HasForeignKey(u => new { u.DsSimDvpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimDvpValues>().ToTable("SIM_DVP_VALUES_DS","DS");
            modelBuilder.Entity<DsSimDvpValues>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimDvpValues>().Property(item => item.SimDvpDsId).IsRequired();
            modelBuilder.Entity<DsSimDvpValues>().Property(item => item.SimDvpDsId).HasColumnName("SIM_DVP_DS__ID");
            modelBuilder.Entity<DsSimDvpValues>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<DsSimDvpValues>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<DsSimDvpValues>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<DsSimDvpValues>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<DsSimFisValues>().HasRequired<DsSimFisClasse>(c => c.DsSimFisClasse).WithMany(t => t.DsSimFisValuess).HasForeignKey(u => new { u.DsSimFisClasseIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimFisValues>().ToTable("SIM_FIS_VALUES_DS","DS");
            modelBuilder.Entity<DsSimFisValues>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.SimFisDsId).IsRequired();
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.SimFisDsId).HasColumnName("SIM_FIS_DS__ID");
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.SimFisClasseDsId).IsRequired();
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.SimFisClasseDsId).HasColumnName("SIM_FIS_CLASSE_DS__ID");
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.Valeur).IsRequired();
            modelBuilder.Entity<DsSimFisValues>().Property(item => item.Valeur).HasColumnName("VALEUR");
            modelBuilder.Entity<DsSimCalculTrafic>().HasOptional<DsSimDvp>(c => c.DsSimDvp).WithMany(t => t.DsSimCalculTrafics).HasForeignKey(u => new {u.DsSimDvpIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculTrafic>().HasOptional<DsSimRec>(c => c.DsSimRec).WithMany(t => t.DsSimCalculTrafics).HasForeignKey(u => new {u.DsSimRecIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculTrafic>().HasOptional<DsSimEntretien>(c => c.DsSimEntretien).WithMany(t => t.DsSimCalculTrafics).HasForeignKey(u => new {u.DsSimEntretienIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculTrafic>().HasRequired<DsSimCalcul>(c => c.DsSimCalcul).WithMany(t => t.DsSimCalculTrafics).HasForeignKey(u => new { u.DsSimCalculIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculTrafic>().HasMany<DsSimCalculFis>(c => c.DsSimCalculFiss).WithRequired(t => t.DsSimCalculTrafic).HasForeignKey(u => new {u.DsSimCalculTraficIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculTrafic>().ToTable("SIM_CALCUL_TRAFIC_DS","DS");
            modelBuilder.Entity<DsSimCalculTrafic>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.SimCalculDsId).IsRequired();
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.SimCalculDsId).HasColumnName("SIM_CALCUL_DS__ID");
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.SimEntretienDsId).HasColumnName("SIM_ENTRETIEN_DS__ID");
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.SimDvpDsId).HasColumnName("SIM_DVP_DS__ID");
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.SimRecDsId).HasColumnName("SIM_REC_DS__ID");
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.Trafic).IsRequired();
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.Trafic).HasMaxLength(10);
            modelBuilder.Entity<DsSimCalculTrafic>().Property(item => item.Trafic).HasColumnName("TRAFIC");
            modelBuilder.Entity<DsSimResult>().HasRequired<DsSimCalculFis>(c => c.DsSimCalculFis).WithMany(t => t.DsSimResults).HasForeignKey(u => new { u.DsSimCalculFisIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimResult>().ToTable("SIM_RESULT_DS","DS");
            modelBuilder.Entity<DsSimResult>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimResult>().Property(item => item.SimCalculTraficDsId).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.SimCalculTraficDsId).HasColumnName("SIM_CALCUL_TRAFIC_DS__ID");
            modelBuilder.Entity<DsSimResult>().Property(item => item.SimFisDsId).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.SimFisDsId).HasColumnName("SIM_FIS_DS__ID");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Liaison).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Liaison).HasMaxLength(15);
            modelBuilder.Entity<DsSimResult>().Property(item => item.Liaison).HasColumnName("LIAISON");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Sens).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Sens).HasMaxLength(6);
            modelBuilder.Entity<DsSimResult>().Property(item => item.Sens).HasColumnName("SENS");
            modelBuilder.Entity<DsSimResult>().Property(item => item.AbsDeb).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.AbsDeb).HasColumnName("ABS_DEB");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Annee).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Annee).HasColumnName("ANNEE");
            modelBuilder.Entity<DsSimResult>().Property(item => item.AbsFin).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.AbsFin).HasColumnName("ABS_FIN");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Dvr).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Dvr).HasColumnName("DVR");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Fis).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Fis).HasColumnName("FIS");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Lineaire).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Lineaire).HasColumnName("LINEAIRE");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Surface).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Surface).HasColumnName("SURFACE");
            modelBuilder.Entity<DsSimResult>().Property(item => item.Epaisseur).IsRequired();
            modelBuilder.Entity<DsSimResult>().Property(item => item.Epaisseur).HasColumnName("EPAISSEUR");
            modelBuilder.Entity<DsSimCalculFis>().HasRequired<DsSimCalculTrafic>(c => c.DsSimCalculTrafic).WithMany(t => t.DsSimCalculFiss).HasForeignKey(u => new { u.DsSimCalculTraficIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculFis>().HasRequired<DsSimFis>(c => c.DsSimFis).WithMany(t => t.DsSimCalculFiss).HasForeignKey(u => new { u.DsSimFisIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculFis>().HasMany<DsSimResult>(c => c.DsSimResults).WithRequired(t => t.DsSimCalculFis).HasForeignKey(u => new {u.DsSimCalculFisIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalculFis>().ToTable("SIM_CALCUL_FIS_DS","DS");
            modelBuilder.Entity<DsSimCalculFis>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimCalculFis>().Property(item => item.SimCalculTraficDsId).IsRequired();
            modelBuilder.Entity<DsSimCalculFis>().Property(item => item.SimCalculTraficDsId).HasColumnName("SIM_CALCUL_TRAFIC_DS__ID");
            modelBuilder.Entity<DsSimCalculFis>().Property(item => item.SimFisDsId).IsRequired();
            modelBuilder.Entity<DsSimCalculFis>().Property(item => item.SimFisDsId).HasColumnName("SIM_FIS_DS__ID");
            modelBuilder.Entity<DsSimEntretien>().HasRequired<DsSimEtude>(c => c.DsSimEtude).WithMany(t => t.DsSimEntretiens).HasForeignKey(u => new { u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimEntretien>().HasMany<DsSimCalculTrafic>(c => c.DsSimCalculTrafics).WithOptional(t => t.DsSimEntretien).HasForeignKey(u => new {u.DsSimEntretienIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimEntretien>().ToTable("SIM_ENTRETIEN_DS","DS");
            modelBuilder.Entity<DsSimEntretien>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.SimEtudeDsId).IsRequired();
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.SimEtudeDsId).HasColumnName("SIM_ETUDE_DS__ID");
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Age).IsRequired();
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Age).HasColumnName("AGE");
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Epaisseur).HasColumnName("EPAISSEUR");
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Couleur).IsRequired();
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Couleur).HasMaxLength(12);
            modelBuilder.Entity<DsSimEntretien>().Property(item => item.Couleur).HasColumnName("COULEUR");
            modelBuilder.Entity<DsSimEtude>().HasMany<DsSimFis>(c => c.DsSimFiss).WithRequired(t => t.DsSimEtude).HasForeignKey(u => new {u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimEtude>().HasMany<DsSimDvp>(c => c.DsSimDvps).WithRequired(t => t.DsSimEtude).HasForeignKey(u => new {u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimEtude>().HasMany<DsSimRec>(c => c.DsSimRecs).WithRequired(t => t.DsSimEtude).HasForeignKey(u => new {u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimEtude>().HasMany<DsSimEntretien>(c => c.DsSimEntretiens).WithRequired(t => t.DsSimEtude).HasForeignKey(u => new {u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimEtude>().HasMany<DsSimCalcul>(c => c.DsSimCalculs).WithRequired(t => t.DsSimEtude).HasForeignKey(u => new {u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimEtude>().ToTable("SIM_ETUDE_DS","DS");
            modelBuilder.Entity<DsSimEtude>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimEtude>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimEtude>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimEtude>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<DsSimEtude>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMin).IsRequired();
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMin).HasColumnName("ANNEE_MIN");
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMax).IsRequired();
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMax).HasColumnName("ANNEE_MAX");
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMinCalcul).IsRequired();
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMinCalcul).HasColumnName("ANNEE_MIN_CALCUL");
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMaxCalcul).IsRequired();
            modelBuilder.Entity<DsSimEtude>().Property(item => item.AnneeMaxCalcul).HasColumnName("ANNEE_MAX_CALCUL");
            modelBuilder.Entity<DsSimCalcul>().HasRequired<DsSimEtude>(c => c.DsSimEtude).WithMany(t => t.DsSimCalculs).HasForeignKey(u => new { u.DsSimEtudeIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalcul>().HasMany<DsSimCalculTrafic>(c => c.DsSimCalculTrafics).WithRequired(t => t.DsSimCalcul).HasForeignKey(u => new {u.DsSimCalculIdPk }).WillCascadeOnDelete(true);
            modelBuilder.Entity<DsSimCalcul>().ToTable("SIM_CALCUL_DS","DS");
            modelBuilder.Entity<DsSimCalcul>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.Id).IsRequired();
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.Id).HasColumnName("ID");
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.SimEtudeDsId).IsRequired();
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.SimEtudeDsId).HasColumnName("SIM_ETUDE_DS__ID");
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.Libelle).HasMaxLength(100);
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.Comment).HasMaxLength(2000);
            modelBuilder.Entity<DsSimCalcul>().Property(item => item.Comment).HasColumnName("COMMENT");
            modelBuilder.Entity<DsTraficColor>().ToTable("TRAFIC_COLOR_DS","DS");
            modelBuilder.Entity<DsTraficColor>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsTraficColor>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<DsTraficColor>().Property(item => item.Code).HasMaxLength(10);
            modelBuilder.Entity<DsTraficColor>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<DsTraficColor>().Property(item => item.Color).HasMaxLength(11);
            modelBuilder.Entity<DsTraficColor>().Property(item => item.Color).HasColumnName("COLOR");
            modelBuilder.Entity<DsAgrege>().ToTable("AGREGE_DS","DS");
            modelBuilder.Entity<DsAgrege>().HasKey(item => new {item.IdPk});
            modelBuilder.Entity<DsAgrege>().Property(item => item.Code).IsRequired();
            modelBuilder.Entity<DsAgrege>().Property(item => item.Code).HasMaxLength(15);
            modelBuilder.Entity<DsAgrege>().Property(item => item.Code).HasColumnName("CODE");
            modelBuilder.Entity<DsAgrege>().Property(item => item.Libelle).IsRequired();
            modelBuilder.Entity<DsAgrege>().Property(item => item.Libelle).HasMaxLength(200);
            modelBuilder.Entity<DsAgrege>().Property(item => item.Libelle).HasColumnName("LIBELLE");
            modelBuilder.Entity<DsAgrege>().Property(item => item.SrcAgr).HasMaxLength(15);
            modelBuilder.Entity<DsAgrege>().Property(item => item.SrcAgr).HasColumnName("SRC_AGR");
            modelBuilder.Entity<DsAgrege>().Property(item => item.SrcIndic).HasMaxLength(15);
            modelBuilder.Entity<DsAgrege>().Property(item => item.SrcIndic).HasColumnName("SRC_INDIC");
            modelBuilder.Entity<DsAgrege>().Property(item => item.Seuil1).HasColumnName("SEUIL1");
            modelBuilder.Entity<DsAgrege>().Property(item => item.Seuil2).HasColumnName("SEUIL2");
            modelBuilder.Entity<DsAgrege>().Property(item => item.Seuil3).HasColumnName("SEUIL3");
            modelBuilder.Entity<DsAgrege>().Property(item => item.Seuil4).HasColumnName("SEUIL4");
            modelBuilder.Entity<DsAgrege>().Property(item => item.ValeurSens).HasMaxLength(2);
            modelBuilder.Entity<DsAgrege>().Property(item => item.ValeurSens).HasColumnName("VALEUR_SENS");
            modelBuilder.Entity<DsAgrege>().Property(item => item.ValeurAbsValueInt).HasColumnName("VALEUR_ABS");
            modelBuilder.Entity<DsAgrege>().Ignore(item => item.ValeurAbs);
        }
    }
}
