using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("AIRE__PRESTATAIRE_INF",Schema="INF")]
    public partial class InfAirePrestataire : ModelBase
    {
        public virtual InfAire InfAire {get;set;}
        
        [Required()]
        [Column("AIRE_INF_ID_PK",Order=0)]
        public Int64 InfAireIdPk {get;set;}
        
        public virtual InfPrestataire InfPrestataire {get;set;}
        
        [Required()]
        [Column("PRESTATAIRE_INF_ID_PK",Order=1)]
        public Int64 InfPrestataireIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=3)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Type Aire")]
        [Column("CD_AIRE_INF__TYPE",Order=4)]
        [Required()]
        [MaxLength(60)] 
        public String CdAireInfType { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("AIRE_INF__ABS_DEB",Order=6)]
        [Required()]
        public Int64 AireInfAbsDeb { get; set; }
        
        [Description("Type Prestataire")]
        [Column("CD_PRESTATAIRE_INF__TYPE",Order=7)]
        [Required()]
        [MaxLength(60)] 
        public String CdPrestataireInfType { get; set; }
        
        [Description("Enseigne")]
        [Column("PRESTATAIRE_INF__NOM",Order=8)]
        [Required()]
        [MaxLength(60)] 
        public String PrestataireInfNom { get; set; }
        
    }
}
