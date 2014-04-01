using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_CHS",Schema="CHS")]
    public partial class ChsDoc
    {
        public virtual ChsCdDoc ChsCdDoc {get;set;}
        
        public virtual ICollection<ChsContact> ChsContacts { get; set; }
        
        public virtual ICollection<ChsClsDoc> ChsClsDocs { get; set; }
        
        [Key]
        [Description("Identifiant document(cpt)")]
        [Column("ID",Order=0)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_CHS__CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocChsCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Référence (fichier)")]
        [Column("REF",Order=3)]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
