using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("REPARTITION_TRAFIC_INF",Schema="INF")]
    public partial class InfRepartitionTrafic : ModelBase
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
        
        [Description("PR debut")]
        [Column("ABS_DEB",Order=2)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Année")]
        [Column("ANNEE",Order=3)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("PR fin")]
        [Column("ABS_FIN",Order=4)]
        public Nullable<Int64> AbsFin { get; set; }
        
        [Description("Répartition trafic PL (%)")]
        [Column("P_PL",Order=5)]
        public Nullable<Int64> PPl { get; set; }
        
    }
}
