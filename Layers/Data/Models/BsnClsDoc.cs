using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_BSN",Schema="BSN")]
    public partial class BsnClsDoc : ModelBase
    {
        private BsnCls _bsnCls;
        public virtual BsnCls BsnCls 
        {
            get
            {
                return this._bsnCls;
                
            }
            set
            {
                this._bsnCls = value;
                this.ClsBsnId = this._bsnCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_BSN_ID_PK",Order=0)]
        public Int64 BsnClsIdPk {get;set;}
        
        private BsnDoc _bsnDoc;
        public virtual BsnDoc BsnDoc 
        {
            get
            {
                return this._bsnDoc;
                
            }
            set
            {
                this._bsnDoc = value;
                this.DocBsnId = this._bsnDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_BSN_ID_PK",Order=1)]
        public Int64 BsnDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_BSN__ID",Order=3)]
        [Required()]
        public Int64 ClsBsnId { get; set; }
        
        [Description("Id document")]
        [Column("DOC_BSN__ID",Order=4)]
        [Required()]
        public Int64 DocBsnId { get; set; }
        
        [Description("Document par défaut")]
        [Column("DEFAUT",Order=5)]
        public Nullable<int> DefautValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Defaut 
        {
            get
            {
                if (DefautValueInt.HasValue) return Convert.ToBoolean(DefautValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.DefautValueInt = Convert.ToInt32(value.Value);}
                else {this.DefautValueInt =null;}
            }
        }
        
        [Description("Dossier")]
        [Column("DOSSIER",Order=6)]
        [MaxLength(15)] 
        public String Dossier { get; set; }
        
    }
}
