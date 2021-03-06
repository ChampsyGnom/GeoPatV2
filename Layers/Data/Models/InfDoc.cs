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
        private InfCdDoc _infCdDoc;
        public virtual InfCdDoc InfCdDoc 
        {
            get
            {
                return this._infCdDoc;
                
            }
            set
            {
                this._infCdDoc = value;
                this.CdDocInfCode = this._infCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_INF_ID_PK",Order=0)]
        public Int64 InfCdDocIdPk {get;set;}
        
        public virtual ICollection<InfContact> InfContacts { get; set; }
        
        public virtual ICollection<InfClsDoc> InfClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identificant(cpt)")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code document")]
        [Column("CD_DOC_INF__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocInfCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Référence")]
        [Column("REF",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
