using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_TMP_BSN",Schema="BSN")]
    public partial class BsnInspTmp : ModelBase
    {
        private BsnCdEtude _bsnCdEtude;
        public virtual BsnCdEtude BsnCdEtude 
        {
            get
            {
                return this._bsnCdEtude;
                
            }
            set
            {
                this._bsnCdEtude = value;
                this.CdEtudeBsnEtude = this._bsnCdEtude.Etude;
            }
        }
        
        [Column("CD_ETUDE_BSN_ID_PK",Order=0)]
        public Nullable<Int64> BsnCdEtudeIdPk {get;set;}
        
        private BsnCdMeteo _bsnCdMeteo;
        public virtual BsnCdMeteo BsnCdMeteo 
        {
            get
            {
                return this._bsnCdMeteo;
                
            }
            set
            {
                this._bsnCdMeteo = value;
                this.CdMeteoBsnMeteo = this._bsnCdMeteo.Meteo;
            }
        }
        
        [Column("CD_METEO_BSN_ID_PK",Order=1)]
        public Nullable<Int64> BsnCdMeteoIdPk {get;set;}
        
        private BsnDscTemp _bsnDscTemp;
        public virtual BsnDscTemp BsnDscTemp 
        {
            get
            {
                return this._bsnDscTemp;
                
            }
            set
            {
                this._bsnDscTemp = value;
                this.CampBsnIdCamp = this._bsnDscTemp.CampBsnIdCamp;
                this.DscTempBsnNumBsn = this._bsnDscTemp.NumBsn;
            }
        }
        
        [Required()]
        [Column("DSC_TEMP_BSN_ID_PK",Order=2)]
        public Int64 BsnDscTempIdPk {get;set;}
        
        private BsnInspecteur _bsnInspecteur;
        public virtual BsnInspecteur BsnInspecteur 
        {
            get
            {
                return this._bsnInspecteur;
                
            }
            set
            {
                this._bsnInspecteur = value;
                this.InspecteurBsnNom = this._bsnInspecteur.Nom;
            }
        }
        
        [Column("INSPECTEUR_BSN_ID_PK",Order=3)]
        public Nullable<Int64> BsnInspecteurIdPk {get;set;}
        
        public virtual ICollection<BsnPhotoInspTmp> BsnPhotoInspTmps { get; set; }
        
        public virtual ICollection<BsnEltInspTmp> BsnEltInspTmps { get; set; }
        
        public virtual ICollection<BsnCdConclusionInspTmp> BsnCdConclusionInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_TEMP_BSN__NUM_BSN",Order=6)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempBsnNumBsn { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_BSN__NOM",Order=7)]
        [MaxLength(60)] 
        public String InspecteurBsnNom { get; set; }
        
        [Description("Météo")]
        [Column("CD_METEO_BSN__METEO",Order=8)]
        [MaxLength(60)] 
        public String CdMeteoBsnMeteo { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_BSN__ETUDE",Order=9)]
        [MaxLength(65)] 
        public String CdEtudeBsnEtude { get; set; }
        
        [Description("Statut visite")]
        [Column("ETAT",Order=10)]
        [Required()]
        [MaxLength(25)] 
        public String Etat { get; set; }
        
        [Description("Date de visite")]
        [Column("DATEV",Order=11)]
        public Nullable<DateTime> Datev { get; set; }
        
        [Description("Température")]
        [Column("TEMPERATURE",Order=12)]
        public Nullable<Double> Temperature { get; set; }
        
        [Description("Moyen utilisé")]
        [Column("MOYEN",Order=13)]
        [MaxLength(500)] 
        public String Moyen { get; set; }
        
        [Description("Condition particulière")]
        [Column("CONDITIONS",Order=14)]
        [MaxLength(500)] 
        public String Conditions { get; set; }
        
        [Description("Date Validation")]
        [Column("DATE_VALID",Order=15)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Nom Valideur")]
        [Column("NOM_VALID",Order=16)]
        [MaxLength(250)] 
        public String NomValid { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=17)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=18)]
        [MaxLength(1000)] 
        public String Securite { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=19)]
        [MaxLength(1000)] 
        public String Prioritaire { get; set; }
        
        [Description("Note Structure")]
        [Column("NOTE1",Order=20)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Equipements")]
        [Column("NOTE2",Order=21)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Abords-Végétation")]
        [Column("NOTE3",Order=22)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Sécurité")]
        [Column("NOTE4",Order=23)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=24)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Image qualité")]
        [Column("QUALITE",Order=25)]
        [MaxLength(25)] 
        public String Qualite { get; set; }
        
    }
}
