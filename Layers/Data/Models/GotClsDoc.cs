using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_GOT",Schema="GOT")]
    public partial class GotClsDoc : ModelBase
    {
        private GotCls _gotCls;
        public virtual GotCls GotCls 
        {
            get
            {
                return this._gotCls;
                
            }
            set
            {
                this._gotCls = value;
                this.ClsGotId = this._gotCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_GOT_ID_PK",Order=0)]
        public Int64 GotClsIdPk {get;set;}
        
        private GotDoc _gotDoc;
        public virtual GotDoc GotDoc 
        {
            get
            {
                return this._gotDoc;
                
            }
            set
            {
                this._gotDoc = value;
                this.DocGotId = this._gotDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_GOT_ID_PK",Order=1)]
        public Int64 GotDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_GOT__ID",Order=3)]
        [Required()]
        public Int64 ClsGotId { get; set; }
        
        [Description("Identifiant document(cpt)")]
        [Column("DOC_GOT__ID",Order=4)]
        [Required()]
        public Int64 DocGotId { get; set; }
        
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
