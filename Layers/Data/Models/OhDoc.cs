using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_OH",Schema="OH")]
    public partial class OhDoc : ModelBase
    {
        private OhCdDoc _ohCdDoc;
        public virtual OhCdDoc OhCdDoc 
        {
            get
            {
                return this._ohCdDoc;
                
            }
            set
            {
                this._ohCdDoc = value;
                this.CdDocOhCode = this._ohCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_OH_ID_PK",Order=0)]
        public Int64 OhCdDocIdPk {get;set;}
        
        public virtual ICollection<OhContact> OhContacts { get; set; }
        
        public virtual ICollection<OhClsDoc> OhClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Id document")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_OH__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocOhCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Réference (fichier)")]
        [Column("REF",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
