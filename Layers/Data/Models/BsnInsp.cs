using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_BSN",Schema="BSN")]
    public partial class BsnInsp : ModelBase
    {
        public virtual BsnCamp BsnCamp {get;set;}
        
        [Required()]
        [Column("CAMP_BSN_ID_PK",Order=0)]
        public Int64 BsnCampIdPk {get;set;}
        
        public virtual BsnCdEtude BsnCdEtude {get;set;}
        
        [Column("CD_ETUDE_BSN_ID_PK",Order=1)]
        public Nullable<Int64> BsnCdEtudeIdPk {get;set;}
        
        public virtual BsnCdMeteo BsnCdMeteo {get;set;}
        
        [Column("CD_METEO_BSN_ID_PK",Order=2)]
        public Nullable<Int64> BsnCdMeteoIdPk {get;set;}
        
        public virtual BsnDsc BsnDsc {get;set;}
        
        [Required()]
        [Column("DSC_BSN_ID_PK",Order=3)]
        public Int64 BsnDscIdPk {get;set;}
        
        public virtual BsnInspecteur BsnInspecteur {get;set;}
        
        [Column("INSPECTEUR_BSN_ID_PK",Order=4)]
        public Nullable<Int64> BsnInspecteurIdPk {get;set;}
        
        public virtual ICollection<BsnEltInsp> BsnEltInsps { get; set; }
        
        public virtual ICollection<BsnPhotoInsp> BsnPhotoInsps { get; set; }
        
        public virtual ICollection<BsnCdConclusionInsp> BsnCdConclusionInsps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=5)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=7)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Météo")]
        [Column("CD_METEO_BSN__METEO",Order=8)]
        [MaxLength(60)] 
        public String CdMeteoBsnMeteo { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_BSN__NOM",Order=9)]
        [MaxLength(60)] 
        public String InspecteurBsnNom { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_BSN__ETUDE",Order=10)]
        [MaxLength(65)] 
        public String CdEtudeBsnEtude { get; set; }
        
        [Description("Statut visite")]
        [Column("ETAT",Order=11)]
        [Required()]
        [MaxLength(25)] 
        public String Etat { get; set; }
        
        [Description("Date de visite")]
        [Column("DATEV",Order=12)]
        public Nullable<DateTime> Datev { get; set; }
        
        [Description("Température")]
        [Column("TEMPERATURE",Order=13)]
        public Nullable<Double> Temperature { get; set; }
        
        [Description("Moyen utilisé")]
        [Column("MOYEN",Order=14)]
        [MaxLength(500)] 
        public String Moyen { get; set; }
        
        [Description("Condition particulière")]
        [Column("CONDITIONS",Order=15)]
        [MaxLength(500)] 
        public String Conditions { get; set; }
        
        [Description("Date Validation")]
        [Column("DATE_VALID",Order=16)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Nom Valideur")]
        [Column("NOM_VALID",Order=17)]
        [MaxLength(250)] 
        public String NomValid { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=18)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=19)]
        [MaxLength(1000)] 
        public String Securite { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=20)]
        [MaxLength(1000)] 
        public String Prioritaire { get; set; }
        
        [Description("Note Structure")]
        [Column("NOTE1",Order=21)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Equipements")]
        [Column("NOTE2",Order=22)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Abords-Végétation")]
        [Column("NOTE3",Order=23)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Sécurité")]
        [Column("NOTE4",Order=24)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=25)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Image qualité")]
        [Column("QUALITE",Order=26)]
        [MaxLength(25)] 
        public String Qualite { get; set; }
        
    }
}
