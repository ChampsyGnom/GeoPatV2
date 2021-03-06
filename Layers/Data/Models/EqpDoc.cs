using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_EQP",Schema="EQP")]
    public partial class EqpDoc : ModelBase
    {
        private EqpCdDoc _eqpCdDoc;
        public virtual EqpCdDoc EqpCdDoc 
        {
            get
            {
                return this._eqpCdDoc;
                
            }
            set
            {
                this._eqpCdDoc = value;
                this.CdDocEqpCode = this._eqpCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_EQP_ID_PK",Order=0)]
        public Int64 EqpCdDocIdPk {get;set;}
        
        public virtual ICollection<EqpContact> EqpContacts { get; set; }
        
        public virtual ICollection<EqpClsDoc> EqpClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Id document")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_EQP__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocEqpCode { get; set; }
        
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
