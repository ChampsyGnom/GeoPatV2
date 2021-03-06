using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_CHS",Schema="CHS")]
    public partial class ChsClsDoc : ModelBase
    {
        private ChsCls _chsCls;
        public virtual ChsCls ChsCls 
        {
            get
            {
                return this._chsCls;
                
            }
            set
            {
                this._chsCls = value;
                this.ClsChsId = this._chsCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_CHS_ID_PK",Order=0)]
        public Int64 ChsClsIdPk {get;set;}
        
        private ChsDoc _chsDoc;
        public virtual ChsDoc ChsDoc 
        {
            get
            {
                return this._chsDoc;
                
            }
            set
            {
                this._chsDoc = value;
                this.DocChsId = this._chsDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_CHS_ID_PK",Order=1)]
        public Int64 ChsDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_CHS__ID",Order=3)]
        [Required()]
        public Int64 ClsChsId { get; set; }
        
        [Description("Identifiant document(cpt)")]
        [Column("DOC_CHS__ID",Order=4)]
        [Required()]
        public Int64 DocChsId { get; set; }
        
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
