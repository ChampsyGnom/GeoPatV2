using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_OH",Schema="OH")]
    public partial class OhInsp : ModelBase
    {
        private OhCamp _ohCamp;
        public virtual OhCamp OhCamp 
        {
            get
            {
                return this._ohCamp;
                
            }
            set
            {
                this._ohCamp = value;
                this.CampOhIdCamp = this._ohCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_OH_ID_PK",Order=0)]
        public Int64 OhCampIdPk {get;set;}
        
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
        
        [Column("CD_METEO_OH_ID_PK",Order=2)]
        public Nullable<Int64> OhCdMeteoIdPk {get;set;}
        
        private OhDsc _ohDsc;
        public virtual OhDsc OhDsc 
        {
            get
            {
                return this._ohDsc;
                
            }
            set
            {
                this._ohDsc = value;
                this.DscOhNumOh = this._ohDsc.NumOh;
            }
        }
        
        [Required()]
        [Column("DSC_OH_ID_PK",Order=3)]
        public Int64 OhDscIdPk {get;set;}
        
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
        
        [Column("INSPECTEUR_OH_ID_PK",Order=4)]
        public Nullable<Int64> OhInspecteurIdPk {get;set;}
        
        public virtual ICollection<OhEltInsp> OhEltInsps { get; set; }
        
        public virtual ICollection<OhPhotoInsp> OhPhotoInsps { get; set; }
        
        public virtual ICollection<OhCdConclusionInsp> OhCdConclusionInsps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=5)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=7)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Météo")]
        [Column("CD_METEO_OH__METEO",Order=8)]
        [MaxLength(60)] 
        public String CdMeteoOhMeteo { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_OH__NOM",Order=9)]
        [MaxLength(60)] 
        public String InspecteurOhNom { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_OH__ETUDE",Order=10)]
        [MaxLength(65)] 
        public String CdEtudeOhEtude { get; set; }
        
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
        
        [Description("Nom Valideur")]
        [Column("NOM_VALID",Order=16)]
        [MaxLength(250)] 
        public String NomValid { get; set; }
        
        [Description("Date Validation")]
        [Column("DATE_VALID",Order=17)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=18)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=19)]
        [MaxLength(1000)] 
        public String Prioritaire { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=20)]
        [MaxLength(1000)] 
        public String Securite { get; set; }
        
        [Description("Abords amont")]
        [Column("NOTE1",Order=21)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Protection amont")]
        [Column("NOTE2",Order=22)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Conduit")]
        [Column("NOTE3",Order=23)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Protection aval")]
        [Column("NOTE4",Order=24)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Abordst aval")]
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
