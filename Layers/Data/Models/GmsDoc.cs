using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_GMS",Schema="GMS")]
    public partial class GmsDoc : ModelBase
    {
        public virtual GmsCdDoc GmsCdDoc {get;set;}
        
        public virtual ICollection<GmsContact> GmsContacts { get; set; }
        
        public virtual ICollection<GmsClsDoc> GmsClsDocs { get; set; }
        
        [Key]
        [Description("Identifiant document(cpt)")]
        [Column("ID",Order=0)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_GMS__CODE",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocGmsCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Réference (fichier)")]
        [Column("REF",Order=3)]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
