using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TPC_INF",Schema="INF")]
    public partial class InfTpc : ModelBase
    {
        public virtual InfCdTpc InfCdTpc {get;set;}
        
        public virtual InfChaussee InfChaussee {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code type")]
        [Column("CD_TPC_INF__CODE",Order=0)]
        [Required()]
        [MaxLength(6)] 
        public String CdTpcInfCode { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=2)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=3)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=4)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Largeur (m)")]
        [Column("LARGEUR",Order=5)]
        public Nullable<Double> Largeur { get; set; }
        
    }
}
