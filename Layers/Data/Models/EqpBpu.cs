using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BPU_EQP",Schema="EQP")]
    public partial class EqpBpu : ModelBase
    {
        public virtual EqpCdTravaux EqpCdTravaux {get;set;}
        
        [Required()]
        [Column("CD_TRAVAUX_EQP_ID_PK",Order=0)]
        public Int64 EqpCdTravauxIdPk {get;set;}
        
        public virtual ICollection<EqpPrevision> EqpPrevisions { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Technique")]
        [Column("TECHN",Order=2)]
        [Required()]
        [MaxLength(250)] 
        public String Techn { get; set; }
        
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_EQP__CODE",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxEqpCode { get; set; }
        
        [Description("Prix Unitaire (€)")]
        [Column("PRIX",Order=4)]
        [Required()]
        public Int64 Prix { get; set; }
        
        [Description("Date MAJ")]
        [Column("DATE_MAJ",Order=5)]
        public Nullable<DateTime> DateMaj { get; set; }
        
        [Description("Fréquence (Mois)")]
        [Column("FREQ",Order=6)]
        public Nullable<Int64> Freq { get; set; }
        
    }
}
