using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_INF",Schema="INF")]
    public partial class InfCls : ModelBase
    {
        public virtual ICollection<InfClsDoc> InfClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant (cpt)")]
        [Column("ID",Order=1)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Nom de la table")]
        [Column("TABLE_NAME",Order=2)]
        [Required()]
        [MaxLength(40)] 
        public String TableName { get; set; }
        
        [Description("Enregistrement")]
        [Column("KEY_VALUE",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String KeyValue { get; set; }
        
    }
}
