using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MARQUAGE_SH_EQP",Schema="EQP")]
    public partial class EqpCdMarquageSh : ModelBase
    {
        private EqpCdModSh _eqpCdModSh;
        public virtual EqpCdModSh EqpCdModSh 
        {
            get
            {
                return this._eqpCdModSh;
                
            }
            set
            {
                this._eqpCdModSh = value;
                this.CdModShEqpMod = this._eqpCdModSh.Mod;
            }
        }
        
        [Required()]
        [Column("CD_MOD_SH_EQP_ID_PK",Order=0)]
        public Int64 EqpCdModShIdPk {get;set;}
        
        public virtual ICollection<EqpDscSh> EqpDscShs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Modulation")]
        [Column("CD_MOD_SH_EQP__MOD",Order=2)]
        [Required()]
        [MaxLength(6)] 
        public String CdModShEqpMod { get; set; }
        
        [Description("Marquage")]
        [Column("MARQUAGE",Order=3)]
        [Required()]
        [MaxLength(255)] 
        public String Marquage { get; set; }
        
        [Description("Largeur (xU)")]
        [Column("LARGEUR",Order=4)]
        public Nullable<Int64> Largeur { get; set; }
        
    }
}
