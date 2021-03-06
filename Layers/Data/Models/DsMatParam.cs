using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("MAT_PARAM_DS",Schema="DS")]
    public partial class DsMatParam : ModelBase
    {
        private DsMat _dsMat;
        public virtual DsMat DsMat 
        {
            get
            {
                return this._dsMat;
                
            }
            set
            {
                this._dsMat = value;
                this.MatDsCode = this._dsMat.Code;
            }
        }
        
        [Required()]
        [Column("MAT_DS_ID_PK",Order=0)]
        public Int64 DsMatIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("MAT_DS__CODE")]
        [Column("MAT_DS__CODE",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String MatDsCode { get; set; }
        
        [Description("MAT_PARAM_DS__X")]
        [Column("X",Order=3)]
        [Required()]
        public Int64 X { get; set; }
        
        [Description("MAT_PARAM_DS__Y")]
        [Column("Y",Order=4)]
        [Required()]
        public Int64 Y { get; set; }
        
        [Description("MAT_PARAM_DS__VALEUR")]
        [Column("VALEUR",Order=5)]
        [Required()]
        public Int64 Valeur { get; set; }
        
    }
}
