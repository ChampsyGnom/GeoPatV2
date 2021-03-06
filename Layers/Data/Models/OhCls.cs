using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_OH",Schema="OH")]
    public partial class OhCls : ModelBase
    {
        public virtual ICollection<OhClsDoc> OhClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("ID",Order=1)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Table")]
        [Column("TABLE_NAME",Order=2)]
        [Required()]
        [MaxLength(30)] 
        public String TableName { get; set; }
        
        [Description("Enregistrement")]
        [Column("KEY_VALUE",Order=3)]
        [Required()]
        [MaxLength(500)] 
        public String KeyValue { get; set; }
        
    }
}
