using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_GOT",Schema="GOT")]
    public partial class GotCls : ModelBase
    {
        public virtual ICollection<GotClsDoc> GotClsDocs { get; set; }
        
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
        [MaxLength(30)] 
        public String TableName { get; set; }
        
        [Description("Enregistrement")]
        [Column("KEY_VALUE",Order=3)]
        [MaxLength(100)] 
        public String KeyValue { get; set; }
        
    }
}
