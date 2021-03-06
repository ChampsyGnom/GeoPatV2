using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_STYPE_SV_EQP",Schema="EQP")]
    public partial class EqpCdStypeSv : ModelBase
    {
        private EqpCdTypeSv _eqpCdTypeSv;
        public virtual EqpCdTypeSv EqpCdTypeSv 
        {
            get
            {
                return this._eqpCdTypeSv;
                
            }
            set
            {
                this._eqpCdTypeSv = value;
                this.CdFamSvEqpFamille = this._eqpCdTypeSv.CdFamSvEqpFamille;
                this.CdTypeSvEqpType = this._eqpCdTypeSv.Type;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_SV_EQP_ID_PK",Order=0)]
        public Int64 EqpCdTypeSvIdPk {get;set;}
        
        public virtual ICollection<EqpPanneau> EqpPanneaus { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille")]
        [Column("CD_FAM_SV_EQP__FAMILLE",Order=2)]
        [Required()]
        [MaxLength(6)] 
        public String CdFamSvEqpFamille { get; set; }
        
        [Description("Type")]
        [Column("CD_TYPE_SV_EQP__TYPE",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String CdTypeSvEqpType { get; set; }
        
        [Description("Sous type")]
        [Column("S_TYPE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String SType { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=5)]
        [Required()]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("Num Ordre")]
        [Column("N_ORDRE",Order=6)]
        [Required()]
        public Int64 NOrdre { get; set; }
        
    }
}
