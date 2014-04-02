using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("COUCHE_GOT",Schema="GOT")]
    public partial class GotCouche : ModelBase
    {
        public virtual GotCdCouche GotCdCouche {get;set;}
        
        [Required()]
        [Column("CD_COUCHE_GOT_ID_PK",Order=0)]
        public Int64 GotCdCoucheIdPk {get;set;}
        
        public virtual GotDsc GotDsc {get;set;}
        
        [Required()]
        [Column("DSC_GOT_ID_PK",Order=1)]
        public Int64 GotDscIdPk {get;set;}
        
        public virtual GotCdTraitement GotCdTraitement {get;set;}
        
        [Required()]
        [Column("CD_TRAITEMENT_GOT_ID_PK",Order=2)]
        public Int64 GotCdTraitementIdPk {get;set;}
        
        public virtual GotCdHydrique GotCdHydrique {get;set;}
        
        [Required()]
        [Column("CD_HYDRIQUE_GOT_ID_PK",Order=3)]
        public Int64 GotCdHydriqueIdPk {get;set;}
        
        public virtual GotCdMateriau GotCdMateriau {get;set;}
        
        [Required()]
        [Column("CD_MATERIAU_GOT_ID_PK",Order=4)]
        public Int64 GotCdMateriauIdPk {get;set;}
        
        public virtual GotCdCompactage GotCdCompactage {get;set;}
        
        [Required()]
        [Column("CD_COMPACTAGE_GOT_ID_PK",Order=5)]
        public Int64 GotCdCompactageIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=6)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code couche")]
        [Column("CD_COUCHE_GOT__CODE",Order=7)]
        [Required()]
        [MaxLength(50)] 
        public String CdCoucheGotCode { get; set; }
        
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=8)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Traitement")]
        [Column("CD_TRAITEMENT_GOT__TYPE",Order=9)]
        [Required()]
        [MaxLength(25)] 
        public String CdTraitementGotType { get; set; }
        
        [Description("Etat hydrique")]
        [Column("CD_HYDRIQUE_GOT__ETAT",Order=10)]
        [Required()]
        [MaxLength(25)] 
        public String CdHydriqueGotEtat { get; set; }
        
        [Description("Matériaux")]
        [Column("CD_MATERIAU_GOT__TYPE",Order=11)]
        [Required()]
        [MaxLength(60)] 
        public String CdMateriauGotType { get; set; }
        
        [Description("Compactage")]
        [Column("CD_COMPACTAGE_GOT__CODE",Order=12)]
        [Required()]
        [MaxLength(50)] 
        public String CdCompactageGotCode { get; set; }
        
        [Description("Epaisseur (m)")]
        [Column("EPAI",Order=13)]
        public Nullable<Double> Epai { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=14)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
