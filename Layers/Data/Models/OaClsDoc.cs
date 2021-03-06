using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_OA",Schema="OA")]
    public partial class OaClsDoc : ModelBase
    {
        private OaCls _oaCls;
        public virtual OaCls OaCls 
        {
            get
            {
                return this._oaCls;
                
            }
            set
            {
                this._oaCls = value;
                this.ClsOaId = this._oaCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_OA_ID_PK",Order=0)]
        public Int64 OaClsIdPk {get;set;}
        
        private OaDoc _oaDoc;
        public virtual OaDoc OaDoc 
        {
            get
            {
                return this._oaDoc;
                
            }
            set
            {
                this._oaDoc = value;
                this.DocOaId = this._oaDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_OA_ID_PK",Order=1)]
        public Int64 OaDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_OA__ID",Order=3)]
        [Required()]
        public Int64 ClsOaId { get; set; }
        
        [Description("Identifiant document(cpt)")]
        [Column("DOC_OA__ID",Order=4)]
        [Required()]
        public Int64 DocOaId { get; set; }
        
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
