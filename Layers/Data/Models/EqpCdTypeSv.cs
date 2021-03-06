using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_TYPE_SV_EQP",Schema="EQP")]
    public partial class EqpCdTypeSv : ModelBase
    {
        private EqpCdFamSv _eqpCdFamSv;
        public virtual EqpCdFamSv EqpCdFamSv 
        {
            get
            {
                return this._eqpCdFamSv;
                
            }
            set
            {
                this._eqpCdFamSv = value;
                this.CdFamSvEqpFamille = this._eqpCdFamSv.Famille;
            }
        }
        
        [Required()]
        [Column("CD_FAM_SV_EQP_ID_PK",Order=0)]
        public Int64 EqpCdFamSvIdPk {get;set;}
        
        public virtual ICollection<EqpCdStypeSv> EqpCdStypeSvs { get; set; }
        
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
        [Column("TYPE",Order=3)]
        [Required()]
        [MaxLength(12)] 
        public String Type { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=4)]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
    }
}
