using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_OH",Schema="OH")]
    public partial class OhClsDoc : ModelBase
    {
        private OhCls _ohCls;
        public virtual OhCls OhCls 
        {
            get
            {
                return this._ohCls;
                
            }
            set
            {
                this._ohCls = value;
                this.ClsOhId = this._ohCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_OH_ID_PK",Order=0)]
        public Int64 OhClsIdPk {get;set;}
        
        private OhDoc _ohDoc;
        public virtual OhDoc OhDoc 
        {
            get
            {
                return this._ohDoc;
                
            }
            set
            {
                this._ohDoc = value;
                this.DocOhId = this._ohDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_OH_ID_PK",Order=1)]
        public Int64 OhDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_OH__ID",Order=3)]
        [Required()]
        public Int64 ClsOhId { get; set; }
        
        [Description("Id document")]
        [Column("DOC_OH__ID",Order=4)]
        [Required()]
        public Int64 DocOhId { get; set; }
        
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
