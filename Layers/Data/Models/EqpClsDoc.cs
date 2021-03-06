using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CLS_DOC_EQP",Schema="EQP")]
    public partial class EqpClsDoc : ModelBase
    {
        private EqpCls _eqpCls;
        public virtual EqpCls EqpCls 
        {
            get
            {
                return this._eqpCls;
                
            }
            set
            {
                this._eqpCls = value;
                this.ClsEqpId = this._eqpCls.Id;
            }
        }
        
        [Required()]
        [Column("CLS_EQP_ID_PK",Order=0)]
        public Int64 EqpClsIdPk {get;set;}
        
        private EqpDoc _eqpDoc;
        public virtual EqpDoc EqpDoc 
        {
            get
            {
                return this._eqpDoc;
                
            }
            set
            {
                this._eqpDoc = value;
                this.DocEqpId = this._eqpDoc.Id;
            }
        }
        
        [Required()]
        [Column("DOC_EQP_ID_PK",Order=1)]
        public Int64 EqpDocIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant du classeur(cpt)")]
        [Column("CLS_EQP__ID",Order=3)]
        [Required()]
        public Int64 ClsEqpId { get; set; }
        
        [Description("Id document")]
        [Column("DOC_EQP__ID",Order=4)]
        [Required()]
        public Int64 DocEqpId { get; set; }
        
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
