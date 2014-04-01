using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("AIRE__PLACE_INF",Schema="INF")]
    public partial class InfAirePlace : ModelBase
    {
        public virtual InfCdPlace InfCdPlace {get;set;}
        
        public virtual InfAire InfAire {get;set;}
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Parking")]
        [Column("CD_PLACE_INF__PARKING",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String CdPlaceInfParking { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Type Aire")]
        [Column("CD_AIRE_INF__TYPE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String CdAireInfType { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("AIRE_INF__ABS_DEB",Order=4)]
        [Required()]
        public Int64 AireInfAbsDeb { get; set; }
        
        [Description("Nbre de place")]
        [Column("NBRE",Order=5)]
        public Nullable<Int64> Nbre { get; set; }
        
    }
}
