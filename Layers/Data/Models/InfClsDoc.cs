using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_INF",Schema="INF")]
    public partial class InfClsDoc : ModelBase
    {
        private InfDoc _infDoc;
        public virtual InfDoc InfDoc 
        {
            get
            {
                return this._infDoc;
                
            }
            set
            {
                this._infDoc = value;
                this.DocInfId = this._infDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_INF_ID_PK",Order=0)]
        public Int64 InfDocIdPk {get;set;}
        
        private InfCls _infCls;
        public virtual InfCls InfCls 
        {
            get
            {
                return this._infCls;
                
            }
            set
            {
                this._infCls = value;
                this.ClsInfId = this._infCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_INF_ID_PK",Order=1)]
        public Int64 InfClsIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identificant(cpt)")]
        [Column("DOC_INF__ID",Order=3)]
        [Required()]
        public Int64 DocInfId { get; set; }
        
        [Description("Identifiant (cpt)")]
        [Column("CLS_INF__ID",Order=4)]
        [Required()]
        public Int64 ClsInfId { get; set; }
        
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
