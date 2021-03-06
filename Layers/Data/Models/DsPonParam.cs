using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PON_PARAM_DS",Schema="DS")]
    public partial class DsPonParam : ModelBase
    {
        private DsPon _dsPon;
        public virtual DsPon DsPon 
        {
            get
            {
                return this._dsPon;
                
            }
            set
            {
                this._dsPon = value;
                this.PonDsCode = this._dsPon.Code;
            }
        }
        
        [Required()]
        [Column("PON_DS_ID_PK",Order=0)]
        public Int64 DsPonIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("PON_DS__CODE")]
        [Column("PON_DS__CODE",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String PonDsCode { get; set; }
        
        [Description("PON_PARAM_DS__INDIC")]
        [Column("INDIC",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String Indic { get; set; }
        
        [Description("PON_PARAM_DS__POID")]
        [Column("POID",Order=4)]
        [Required()]
        public Int64 Poid { get; set; }
        
    }
}
