using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NATURE_TRAV_EQP",Schema="EQP")]
    public partial class EqpNatureTrav : ModelBase
    {
        private EqpCdTravaux _eqpCdTravaux;
        public virtual EqpCdTravaux EqpCdTravaux 
        {
            get
            {
                return this._eqpCdTravaux;
                
            }
            set
            {
                this._eqpCdTravaux = value;
                this.CdTravauxEqpCode = this._eqpCdTravaux.Code;
            }
        }
        
        [Required()]
        [Column("CD_TRAVAUX_EQP_ID_PK",Order=0)]
        public Int64 EqpCdTravauxIdPk {get;set;}
        
        public virtual ICollection<EqpTravaux> EqpTravauxs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_EQP__CODE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxEqpCode { get; set; }
        
        [Description("Nature travaux")]
        [Column("NATURE",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String Nature { get; set; }
        
    }
}
