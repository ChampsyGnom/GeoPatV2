using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_INF",Schema="INF")]
    public partial class InfDoc : ModelBase
    {
        public virtual InfCdDoc InfCdDoc {get;set;}
        
        public virtual ICollection<InfContact> InfContacts { get; set; }
        
        public virtual ICollection<InfClsDoc> InfClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identificant(cpt)")]
        [Column("ID",Order=0)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code document")]
        [Column("CD_DOC_INF__CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocInfCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Référence")]
        [Column("REF",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
