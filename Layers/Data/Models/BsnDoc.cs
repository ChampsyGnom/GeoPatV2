using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_BSN",Schema="BSN")]
    public partial class BsnDoc : ModelBase
    {
        public virtual BsnCdDoc BsnCdDoc {get;set;}
        
        public virtual ICollection<BsnContact> BsnContacts { get; set; }
        
        public virtual ICollection<BsnClsDoc> BsnClsDocs { get; set; }
        
        [Key]
        [Description("Id document")]
        [Column("ID",Order=0)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_BSN__CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocBsnCode { get; set; }
        
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
