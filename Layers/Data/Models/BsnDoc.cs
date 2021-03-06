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
        private BsnCdDoc _bsnCdDoc;
        public virtual BsnCdDoc BsnCdDoc 
        {
            get
            {
                return this._bsnCdDoc;
                
            }
            set
            {
                this._bsnCdDoc = value;
                this.CdDocBsnCode = this._bsnCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_BSN_ID_PK",Order=0)]
        public Int64 BsnCdDocIdPk {get;set;}
        
        public virtual ICollection<BsnContact> BsnContacts { get; set; }
        
        public virtual ICollection<BsnClsDoc> BsnClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Id document")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_BSN__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocBsnCode { get; set; }
        
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
