using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DOC_CHS",Schema="CHS")]
    public partial class ChsDoc : ModelBase
    {
        private ChsCdDoc _chsCdDoc;
        public virtual ChsCdDoc ChsCdDoc 
        {
            get
            {
                return this._chsCdDoc;
                
            }
            set
            {
                this._chsCdDoc = value;
                this.CdDocChsCode = this._chsCdDoc.Code;
            }
        }
        
        [Required()]
        [Column("CD_DOC_CHS_ID_PK",Order=0)]
        public Int64 ChsCdDocIdPk {get;set;}
        
        public virtual ICollection<ChsContact> ChsContacts { get; set; }
        
        public virtual ICollection<ChsClsDoc> ChsClsDocs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant document(cpt)")]
        [Column("ID",Order=2)]
        [Required()]
        public Int64 Id { get; set; }
        
        [Description("Code")]
        [Column("CD_DOC_CHS__CODE",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String CdDocChsCode { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(100)] 
        public String Libelle { get; set; }
        
        [Description("Référence (fichier)")]
        [Column("REF",Order=5)]
        [MaxLength(50)] 
        public String Ref { get; set; }
        
    }
}
