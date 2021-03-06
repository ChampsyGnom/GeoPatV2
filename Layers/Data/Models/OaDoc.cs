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
        private OaCdDoc _oaCdDoc;
        public virtual OaCdDoc OaCdDoc 
        {
            get
            {
                return this._oaCdDoc;
                
            }
            set
            {
                this._oaCdDoc = value;
                this.CdDocOaCode = this._oaCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_OA_ID_PK",Order=0)]
        public Int64 OaCdDocIdPk {get;set;}
        
        public virtual ICollection<OaContact> OaContacts { get; set; }
        
        public virtual ICollection<OaClsDoc> OaClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant document(cpt)")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_OA__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocOaCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Réference(fichier)")]
        [Column("REF",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
