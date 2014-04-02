using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("TRAFIC_INF",Schema="INF")]
    public partial class InfTrafic : ModelBase
    {
        public virtual InfChaussee InfChaussee {get;set;}
        
        [Required()]
        [Column("CHAUSSEE_INF_ID_PK",Order=0)]
        public Int64 InfChausseeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=2)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Année")]
        [Column("ANNEE",Order=4)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("PL (%)")]
        [Column("PL",Order=5)]
        public Nullable<Double> Pl { get; set; }
        
        [Description("TMJA")]
        [Column("TMJA",Order=6)]
        public Nullable<Int64> Tmja { get; set; }
        
    }
}
