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
        
        [Required()]
        [Column("CD_PLACE_INF_ID_PK",Order=0)]
        public Int64 InfCdPlaceIdPk {get;set;}
        
        public virtual InfAire InfAire {get;set;}
        
        [Required()]
        [Column("AIRE_INF_ID_PK",Order=1)]
        public Int64 InfAireIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Parking")]
        [Column("CD_PLACE_INF__PARKING",Order=3)]
        [Required()]
        [MaxLength(60)] 
        public String CdPlaceInfParking { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Type Aire")]
        [Column("CD_AIRE_INF__TYPE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdAireInfType { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=6)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("AIRE_INF__ABS_DEB",Order=7)]
        [Required()]
        public Int64 AireInfAbsDeb { get; set; }
        
        [Description("Nbre de place")]
        [Column("NBRE",Order=8)]
        public Nullable<Int64> Nbre { get; set; }
        
    }
}
