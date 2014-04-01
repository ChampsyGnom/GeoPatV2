using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_GOT",Schema="GOT")]
    public partial class GotClsDoc
    {
        public virtual GotCls GotCls {get;set;}
        
        public virtual GotDoc GotDoc {get;set;}
        
        [Key]
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_GOT__ID",Order=0)]
        [Required()]
        public Int64 ClsGotId { get; set; }
        
        [Key]
        [Description("Identifiant document(cpt)")]
        [Column("DOC_GOT__ID",Order=1)]
        [Required()]
        public Int64 DocGotId { get; set; }
        
        [Description("Document par défaut")]
        [Column("DEFAUT",Order=2)]
        public Nullable<int> Defaut { get; set; }
        
        [Description("Dossier")]
        [Column("DOSSIER",Order=3)]
        [MaxLength(15)] 
        public String Dossier { get; set; }
        
    }
}
