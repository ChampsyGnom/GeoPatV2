using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_EQP",Schema="EQP")]
    public partial class EqpDoc : ModelBase
    {
        public virtual EqpCdDoc EqpCdDoc {get;set;}
        
        public virtual ICollection<EqpContact> EqpContacts { get; set; }
        
        public virtual ICollection<EqpClsDoc> EqpClsDocs { get; set; }
        
        [Key]
        [Description("Id document")]
        [Column("ID",Order=0)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_EQP__CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocEqpCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Réference (fichier)")]
        [Column("REF",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
