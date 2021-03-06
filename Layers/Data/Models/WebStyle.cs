using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("STYLE_WEB",Schema="WEB")]
    public partial class WebStyle : ModelBase
    {
        public virtual ICollection<WebStyleRule> WebStyleRules { get; set; }
        
        public virtual ICollection<WebNodeWebStyle> WebNodeWebStyles { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du style")]
        [Column("ID",Order=1)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Nom du schéma (optionel)")]
        [Column("SCHEMA_NAME",Order=2)]
        [MaxLength(255)] 
        public String SchemaName { get; set; }
        
        [Description("Nom de la table (optionel)")]
        [Column("TABLE_NAME",Order=3)]
        [MaxLength(255)] 
        public String TableName { get; set; }
        
        [Description("Nom de la colonne (optionel)")]
        [Column("COLUMN_NAME",Order=4)]
        [MaxLength(255)] 
        public String ColumnName { get; set; }
        
        [Description("Libellé du style")]
        [Column("LIBELLE",Order=5)]
        [Required()]
        [MaxLength(255)] 
        public String Libelle { get; set; }
        
        [Description("Style par défaut")]
        [Column("DEFAUT",Order=6)]
        [Required()]
        public int DefautValueInt { get; set; }
        [NotMapped]
        public Boolean Defaut 
        {
            get
            {
                return Convert.ToBoolean(DefautValueInt);
            }
            set
            {
                this.DefautValueInt = Convert.ToInt32(value);
            }
        }
        
    }
}
