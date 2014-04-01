using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_OA",Schema="OA")]
    public partial class OaDoc : ModelBase
    {
        public virtual OaCdDoc OaCdDoc {get;set;}
        
        public virtual ICollection<OaContact> OaContacts { get; set; }
        
        public virtual ICollection<OaClsDoc> OaClsDocs { get; set; }
        
        [Key]
        [Description("Identifiant document(cpt)")]
        [Column("ID",Order=0)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_OA__CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocOaCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Réference(fichier)")]
        [Column("REF",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
