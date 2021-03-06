using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_GMS",Schema="GMS")]
    public partial class GmsClsDoc : ModelBase
    {
        private GmsCls _gmsCls;
        public virtual GmsCls GmsCls 
        {
            get
            {
                return this._gmsCls;
                
            }
            set
            {
                this._gmsCls = value;
                this.ClsGmsId = this._gmsCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_GMS_ID_PK",Order=0)]
        public Int64 GmsClsIdPk {get;set;}
        
        private GmsDoc _gmsDoc;
        public virtual GmsDoc GmsDoc 
        {
            get
            {
                return this._gmsDoc;
                
            }
            set
            {
                this._gmsDoc = value;
                this.DocGmsId = this._gmsDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_GMS_ID_PK",Order=1)]
        public Int64 GmsDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_GMS__ID",Order=3)]
        [Required()]
        public Int64 ClsGmsId { get; set; }
        
        [Description("Identifiant document(cpt)")]
        [Column("DOC_GMS__ID",Order=4)]
        [Required()]
        public Int64 DocGmsId { get; set; }
        
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
