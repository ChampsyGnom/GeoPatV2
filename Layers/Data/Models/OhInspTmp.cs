using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_TMP_OH",Schema="OH")]
    public partial class OhInspTmp : ModelBase
    {
        private OhCdMeteo _ohCdMeteo;
        public virtual OhCdMeteo OhCdMeteo 
        {
            get
            {
                return this._ohCdMeteo;
                
            }
            set
            {
                this._ohCdMeteo = value;
                this.CdMeteoOhMeteo = this._ohCdMeteo.Meteo;
            }
        }
        
        [Column("CD_METEO_OH_ID_PK",Order=0)]
        public Nullable<Int64> OhCdMeteoIdPk {get;set;}
        
        private OhCdEtude _ohCdEtude;
        public virtual OhCdEtude OhCdEtude 
        {
            get
            {
                return this._ohCdEtude;
                
            }
            set
            {
                this._ohCdEtude = value;
                this.CdEtudeOhEtude = this._ohCdEtude.Etude;
            }
        }
        
        [Column("CD_ETUDE_OH_ID_PK",Order=1)]
        public Nullable<Int64> OhCdEtudeIdPk {get;set;}
        
        private OhDscTemp _ohDscTemp;
        public virtual OhDscTemp OhDscTemp 
        {
            get
            {
                return this._ohDscTemp;
                
            }
            set
            {
                this._ohDscTemp = value;
                this.CampOhIdCamp = this._ohDscTemp.CampOhIdCamp;
                this.DscTempOhNumOh = this._ohDscTemp.NumOh;
            }
        }
        
        [Required()]
        [Column("DSC_TEMP_OH_ID_PK",Order=2)]
        public Int64 OhDscTempIdPk {get;set;}
        
        private OhInspecteur _ohInspecteur;
        public virtual OhInspecteur OhInspecteur 
        {
            get
            {
                return this._ohInspecteur;
                
            }
            set
            {
                this._ohInspecteur = value;
                this.InspecteurOhNom = this._ohInspecteur.Nom;
            }
        }
        
        [Column("INSPECTEUR_OH_ID_PK",Order=3)]
        public Nullable<Int64> OhInspecteurIdPk {get;set;}
        
        public virtual ICollection<OhEltInspTmp> OhEltInspTmps { get; set; }
        
        public virtual ICollection<OhPhotoInspTmp> OhPhotoInspTmps { get; set; }
        
        public virtual ICollection<OhCdConclusionInspTmp> OhCdConclusionInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_TEMP_OH__NUM_OH",Order=6)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOhNumOh { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_OH__NOM",Order=7)]
        [MaxLength(60)] 
        public String InspecteurOhNom { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_OH__ETUDE",Order=8)]
        [MaxLength(65)] 
        public String CdEtudeOhEtude { get; set; }
        
        [Description("Météo")]
        [Column("CD_METEO_OH__METEO",Order=9)]
        [MaxLength(60)] 
        public String CdMeteoOhMeteo { get; set; }
        
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
        
        [Description("Nom Valideur")]
        [Column("NOM_VALID",Order=15)]
        [MaxLength(250)] 
        public String NomValid { get; set; }
        
        [Description("Date Validation")]
        [Column("DATE_VALID",Order=16)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=17)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=18)]
        [MaxLength(1000)] 
        public String Prioritaire { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=19)]
        [MaxLength(1000)] 
        public String Securite { get; set; }
        
        [Description("Abords amont")]
        [Column("NOTE1",Order=20)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Protection amont")]
        [Column("NOTE2",Order=21)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Conduit")]
        [Column("NOTE3",Order=22)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Protection aval")]
        [Column("NOTE4",Order=23)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Abordst aval")]
        [Column("NOTE5",Order=24)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Niveau urgence")]
        [Column("URGENCE",Order=25)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Image qualité")]
        [Column("QUALITE",Order=26)]
        [MaxLength(25)] 
        public String Qualite { get; set; }
        
    }
}
