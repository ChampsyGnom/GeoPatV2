using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CL_VOIE_INF",Schema="INF")]
    public partial class InfClVoie : ModelBase
    {
        public virtual InfCdVoie InfCdVoie {get;set;}
        
        [Required()]
        [Column("CD_VOIE_INF_ID_PK",Order=0)]
        public Int64 InfCdVoieIdPk {get;set;}
        
        public virtual InfChaussee InfChaussee {get;set;}
        
        [Required()]
        [Column("CHAUSSEE_INF_ID_PK",Order=1)]
        public Int64 InfChausseeIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Voie")]
        [Column("CD_VOIE_INF__VOIE",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String CdVoieInfVoie { get; set; }
        
        [Description("Liaison")]
        [Column("LIAISON_INF__LIAISON",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String LiaisonInfLiaison { get; set; }
        
        [Description("Sens")]
        [Column("CHAUSSEE_INF__SENS",Order=5)]
        [Required()]
        [MaxLength(6)] 
        public String ChausseeInfSens { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=6)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Num Voie total")]
        [Column("NUM_VNR",Order=7)]
        [Required()]
        public Int64 NumVnr { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=8)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Numéro Voie")]
        [Column("NUM",Order=9)]
        public Nullable<Int64> Num { get; set; }
        
        [Description("Nbre de voies")]
        [Column("NBRE",Order=10)]
        public Nullable<Int64> Nbre { get; set; }
        
        [Description("Nbre Voie total")]
        [Column("NBRE_VNR",Order=11)]
        [Required()]
        public Int64 NbreVnr { get; set; }
        
    }
}
