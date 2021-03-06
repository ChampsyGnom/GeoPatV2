using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_GOT",Schema="GOT")]
    public partial class GotDoc : ModelBase
    {
        private GotCdDoc _gotCdDoc;
        public virtual GotCdDoc GotCdDoc 
        {
            get
            {
                return this._gotCdDoc;
                
            }
            set
            {
                this._gotCdDoc = value;
                this.CdDocGotCode = this._gotCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_GOT_ID_PK",Order=0)]
        public Int64 GotCdDocIdPk {get;set;}
        
        public virtual ICollection<GotContact> GotContacts { get; set; }
        
        public virtual ICollection<GotClsDoc> GotClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant document(cpt)")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_GOT__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocGotCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Réference(fichier)")]
        [Column("REF",Order=5)]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
