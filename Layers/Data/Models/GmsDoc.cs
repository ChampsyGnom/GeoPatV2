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
        private GmsCdDoc _gmsCdDoc;
        public virtual GmsCdDoc GmsCdDoc 
        {
            get
            {
                return this._gmsCdDoc;
                
            }
            set
            {
                this._gmsCdDoc = value;
                this.CdDocGmsCode = this._gmsCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_GMS_ID_PK",Order=0)]
        public Int64 GmsCdDocIdPk {get;set;}
        
        public virtual ICollection<GmsContact> GmsContacts { get; set; }
        
        public virtual ICollection<GmsClsDoc> GmsClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant document(cpt)")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_GMS__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocGmsCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Réference (fichier)")]
        [Column("REF",Order=5)]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
