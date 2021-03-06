using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_TMP_GMS",Schema="GMS")]
    public partial class GmsInspTmp : ModelBase
    {
        private GmsCdMeteo _gmsCdMeteo;
        public virtual GmsCdMeteo GmsCdMeteo 
        {
            get
            {
                return this._gmsCdMeteo;
                
            }
            set
            {
                this._gmsCdMeteo = value;
                this.CdMeteoGmsMeteo = this._gmsCdMeteo.Meteo;
            }
        }
        
        [Column("CD_METEO_GMS_ID_PK",Order=0)]
        public Nullable<Int64> GmsCdMeteoIdPk {get;set;}
        
        private GmsCdEtude _gmsCdEtude;
        public virtual GmsCdEtude GmsCdEtude 
        {
            get
            {
                return this._gmsCdEtude;
                
            }
            set
            {
                this._gmsCdEtude = value;
                this.CdEtudeGmsEtude = this._gmsCdEtude.Etude;
            }
        }
        
        [Column("CD_ETUDE_GMS_ID_PK",Order=1)]
        public Nullable<Int64> GmsCdEtudeIdPk {get;set;}
        
        private GmsDscTemp _gmsDscTemp;
        public virtual GmsDscTemp GmsDscTemp 
        {
            get
            {
                return this._gmsDscTemp;
                
            }
            set
            {
                this._gmsDscTemp = value;
                this.CampGmsIdCamp = this._gmsDscTemp.CampGmsIdCamp;
                this.DscTempGmsNumGms = this._gmsDscTemp.NumGms;
            }
        }
        
        [Required()]
        [Column("DSC_TEMP_GMS_ID_PK",Order=2)]
        public Int64 GmsDscTempIdPk {get;set;}
        
        private GmsInspecteur _gmsInspecteur;
        public virtual GmsInspecteur GmsInspecteur 
        {
            get
            {
                return this._gmsInspecteur;
                
            }
            set
            {
                this._gmsInspecteur = value;
                this.InspecteurGmsNom = this._gmsInspecteur.Nom;
            }
        }
        
        [Column("INSPECTEUR_GMS_ID_PK",Order=3)]
        public Nullable<Int64> GmsInspecteurIdPk {get;set;}
        
        public virtual ICollection<GmsEltInspTmp> GmsEltInspTmps { get; set; }
        
        public virtual ICollection<GmsPhotoInspTmp> GmsPhotoInspTmps { get; set; }
        
        public virtual ICollection<GmsCdConclusionInspTmp> GmsCdConclusionInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=4)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_TEMP_GMS__NUM_GMS",Order=6)]
        [Required()]
        [MaxLength(17)] 
        public String DscTempGmsNumGms { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_GMS__ETUDE",Order=7)]
        [MaxLength(65)] 
        public String CdEtudeGmsEtude { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_GMS__NOM",Order=8)]
        [MaxLength(60)] 
        public String InspecteurGmsNom { get; set; }
        
        [Description("Condition météo")]
        [Column("CD_METEO_GMS__METEO",Order=9)]
        [MaxLength(60)] 
        public String CdMeteoGmsMeteo { get; set; }
        
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
        
        [Description("Date de validation")]
        [Column("DATE_VALID",Order=15)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Nom valideur")]
        [Column("NOM_VALID",Order=16)]
        [MaxLength(255)] 
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
        
        [Description("Ancrage")]
        [Column("NOTE1",Order=20)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Structure")]
        [Column("NOTE2",Order=21)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Fixation")]
        [Column("NOTE3",Order=22)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Panneau")]
        [Column("NOTE4",Order=23)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Accessibilité")]
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
