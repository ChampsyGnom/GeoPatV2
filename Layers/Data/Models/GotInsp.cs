using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_GOT",Schema="GOT")]
    public partial class GotInsp : ModelBase
    {
        private GotDsc _gotDsc;
        public virtual GotDsc GotDsc 
        {
            get
            {
                return this._gotDsc;
                
            }
            set
            {
                this._gotDsc = value;
                this.DscGotNumGot = this._gotDsc.NumGot;
            }
        }
        
        [Required()]
        [Column("DSC_GOT_ID_PK",Order=0)]
        public Int64 GotDscIdPk {get;set;}
        
        private GotCdMeteo _gotCdMeteo;
        public virtual GotCdMeteo GotCdMeteo 
        {
            get
            {
                return this._gotCdMeteo;
                
            }
            set
            {
                this._gotCdMeteo = value;
                this.CdMeteoGotMeteo = this._gotCdMeteo.Meteo;
            }
        }
        
        [Column("CD_METEO_GOT_ID_PK",Order=1)]
        public Nullable<Int64> GotCdMeteoIdPk {get;set;}
        
        private GotCdEtude _gotCdEtude;
        public virtual GotCdEtude GotCdEtude 
        {
            get
            {
                return this._gotCdEtude;
                
            }
            set
            {
                this._gotCdEtude = value;
                this.CdEtudeGotEtude = this._gotCdEtude.Etude;
            }
        }
        
        [Column("CD_ETUDE_GOT_ID_PK",Order=2)]
        public Nullable<Int64> GotCdEtudeIdPk {get;set;}
        
        private GotCamp _gotCamp;
        public virtual GotCamp GotCamp 
        {
            get
            {
                return this._gotCamp;
                
            }
            set
            {
                this._gotCamp = value;
                this.CampGotIdCamp = this._gotCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_GOT_ID_PK",Order=3)]
        public Int64 GotCampIdPk {get;set;}
        
        private GotInspecteur _gotInspecteur;
        public virtual GotInspecteur GotInspecteur 
        {
            get
            {
                return this._gotInspecteur;
                
            }
            set
            {
                this._gotInspecteur = value;
                this.InspecteurGotNom = this._gotInspecteur.Nom;
            }
        }
        
        [Column("INSPECTEUR_GOT_ID_PK",Order=4)]
        public Nullable<Int64> GotInspecteurIdPk {get;set;}
        
        public virtual ICollection<GotEltInsp> GotEltInsps { get; set; }
        
        public virtual ICollection<GotPhotoInsp> GotPhotoInsps { get; set; }
        
        public virtual ICollection<GotCdConclusionInsp> GotCdConclusionInsps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=5)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=6)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=7)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Condition météo")]
        [Column("CD_METEO_GOT__METEO",Order=8)]
        [MaxLength(60)] 
        public String CdMeteoGotMeteo { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_GOT__ETUDE",Order=9)]
        [MaxLength(65)] 
        public String CdEtudeGotEtude { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_GOT__NOM",Order=10)]
        [MaxLength(60)] 
        public String InspecteurGotNom { get; set; }
        
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
        
        [Description("Moyens utilisés")]
        [Column("MOYEN",Order=14)]
        [MaxLength(500)] 
        public String Moyen { get; set; }
        
        [Description("Conditions particulières")]
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
        
        [Description("Note Plateforme 1")]
        [Column("NOTE1",Order=21)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Plateforme 2")]
        [Column("NOTE2",Order=22)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Talus 1")]
        [Column("NOTE3",Order=23)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Talus 2")]
        [Column("NOTE4",Order=24)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Environnement")]
        [Column("NOTE5",Order=25)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Note urgence")]
        [Column("URGENCE",Order=26)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Note qualité")]
        [Column("QUALITE",Order=27)]
        [MaxLength(25)] 
        public String Qualite { get; set; }
        
    }
}
