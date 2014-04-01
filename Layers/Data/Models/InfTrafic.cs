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
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=0)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Année")]
        [Column("ANNEE",Order=2)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("PL (%)")]
        [Column("PL",Order=3)]
        public Nullable<Double> Pl { get; set; }
        
        [Description("TMJA")]
        [Column("TMJA",Order=4)]
        public Nullable<Int64> Tmja { get; set; }
        
    }
}
