using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_GMS",Schema="GMS")]
    public partial class GmsInsp : ModelBase
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
        
        private GmsCamp _gmsCamp;
        public virtual GmsCamp GmsCamp 
        {
            get
            {
                return this._gmsCamp;
                
            }
            set
            {
                this._gmsCamp = value;
                this.CampGmsIdCamp = this._gmsCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_GMS_ID_PK",Order=1)]
        public Int64 GmsCampIdPk {get;set;}
        
        private GmsDsc _gmsDsc;
        public virtual GmsDsc GmsDsc 
        {
            get
            {
                return this._gmsDsc;
                
            }
            set
            {
                this._gmsDsc = value;
                this.DscGmsNumGms = this._gmsDsc.NumGms;
            }
        }
        
        [Required()]
        [Column("DSC_GMS_ID_PK",Order=2)]
        public Int64 GmsDscIdPk {get;set;}
        
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
        
        [Column("CD_ETUDE_GMS_ID_PK",Order=3)]
        public Nullable<Int64> GmsCdEtudeIdPk {get;set;}
        
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
        
        [Column("INSPECTEUR_GMS_ID_PK",Order=4)]
        public Nullable<Int64> GmsInspecteurIdPk {get;set;}
        
        public virtual ICollection<GmsEltInsp> GmsEltInsps { get; set; }
        
        public virtual ICollection<GmsPhotoInsp> GmsPhotoInsps { get; set; }
        
        public virtual ICollection<GmsCdConclusionInsp> GmsCdConclusionInsps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=5)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=7)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_GMS__ETUDE",Order=8)]
        [MaxLength(65)] 
        public String CdEtudeGmsEtude { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_GMS__NOM",Order=9)]
        [MaxLength(60)] 
        public String InspecteurGmsNom { get; set; }
        
        [Description("Condition météo")]
        [Column("CD_METEO_GMS__METEO",Order=10)]
        [MaxLength(60)] 
        public String CdMeteoGmsMeteo { get; set; }
        
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
        
        [Description("Date de validation")]
        [Column("DATE_VALID",Order=16)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Nom valideur")]
        [Column("NOM_VALID",Order=17)]
        [MaxLength(255)] 
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
        
        [Description("Ancrage")]
        [Column("NOTE1",Order=21)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Structure")]
        [Column("NOTE2",Order=22)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Fixation")]
        [Column("NOTE3",Order=23)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Panneau")]
        [Column("NOTE4",Order=24)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Accessibilité")]
        [Column("NOTE5",Order=25)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Niveau urgence")]
        [Column("URGENCE",Order=26)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Image qualité")]
        [Column("QUALITE",Order=27)]
        [MaxLength(25)] 
        public String Qualite { get; set; }
        
    }
}
