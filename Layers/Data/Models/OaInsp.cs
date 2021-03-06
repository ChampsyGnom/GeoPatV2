using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_OA",Schema="OA")]
    public partial class OaInsp : ModelBase
    {
        private OaDsc _oaDsc;
        public virtual OaDsc OaDsc 
        {
            get
            {
                return this._oaDsc;
                
            }
            set
            {
                this._oaDsc = value;
                this.DscOaNumOa = this._oaDsc.NumOa;
            }
        }
        
        [Required()]
        [Column("DSC_OA_ID_PK",Order=0)]
        public Int64 OaDscIdPk {get;set;}
        
        private OaCdMeteo _oaCdMeteo;
        public virtual OaCdMeteo OaCdMeteo 
        {
            get
            {
                return this._oaCdMeteo;
                
            }
            set
            {
                this._oaCdMeteo = value;
                this.CdMeteoOaMeteo = this._oaCdMeteo.Meteo;
            }
        }
        
        [Column("CD_METEO_OA_ID_PK",Order=1)]
        public Nullable<Int64> OaCdMeteoIdPk {get;set;}
        
        private OaCdEtude _oaCdEtude;
        public virtual OaCdEtude OaCdEtude 
        {
            get
            {
                return this._oaCdEtude;
                
            }
            set
            {
                this._oaCdEtude = value;
                this.CdEtudeOaEtude = this._oaCdEtude.Etude;
            }
        }
        
        [Column("CD_ETUDE_OA_ID_PK",Order=2)]
        public Nullable<Int64> OaCdEtudeIdPk {get;set;}
        
        private OaCdIqoa _oaCdIqoa;
        public virtual OaCdIqoa OaCdIqoa 
        {
            get
            {
                return this._oaCdIqoa;
                
            }
            set
            {
                this._oaCdIqoa = value;
                this.CdIqoaOaNoteIqoa = this._oaCdIqoa.NoteIqoa;
            }
        }
        
        [Required()]
        [Column("CD_IQOA_OA_ID_PK",Order=3)]
        public Int64 OaCdIqoaIdPk {get;set;}
        
        private OaCamp _oaCamp;
        public virtual OaCamp OaCamp 
        {
            get
            {
                return this._oaCamp;
                
            }
            set
            {
                this._oaCamp = value;
                this.CampOaIdCamp = this._oaCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_OA_ID_PK",Order=4)]
        public Int64 OaCampIdPk {get;set;}
        
        private OaInspecteur _oaInspecteur;
        public virtual OaInspecteur OaInspecteur 
        {
            get
            {
                return this._oaInspecteur;
                
            }
            set
            {
                this._oaInspecteur = value;
                this.InspecteurOaNom = this._oaInspecteur.Nom;
            }
        }
        
        [Column("INSPECTEUR_OA_ID_PK",Order=5)]
        public Nullable<Int64> OaInspecteurIdPk {get;set;}
        
        public virtual ICollection<OaEltInsp> OaEltInsps { get; set; }
        
        public virtual ICollection<OaPhotoInsp> OaPhotoInsps { get; set; }
        
        public virtual ICollection<OaCdConclusionInsp> OaCdConclusionInsps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=6)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=7)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=8)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Condition météo")]
        [Column("CD_METEO_OA__METEO",Order=9)]
        [MaxLength(60)] 
        public String CdMeteoOaMeteo { get; set; }
        
        [Description("Note IQOA")]
        [Column("CD_IQOA_OA__NOTE_IQOA",Order=10)]
        [Required()]
        [MaxLength(3)] 
        public String CdIqoaOaNoteIqoa { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_OA__NOM",Order=11)]
        [MaxLength(60)] 
        public String InspecteurOaNom { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_OA__ETUDE",Order=12)]
        [MaxLength(60)] 
        public String CdEtudeOaEtude { get; set; }
        
        [Description("Statut visite")]
        [Column("ETAT",Order=13)]
        [Required()]
        [MaxLength(25)] 
        public String Etat { get; set; }
        
        [Description("Date de visite")]
        [Column("DATEV",Order=14)]
        public Nullable<DateTime> Datev { get; set; }
        
        [Description("Température")]
        [Column("TEMPERATURE",Order=15)]
        public Nullable<Double> Temperature { get; set; }
        
        [Description("Moyens utilisés")]
        [Column("MOYEN",Order=16)]
        [MaxLength(500)] 
        public String Moyen { get; set; }
        
        [Description("Conditions particulières")]
        [Column("CONDITIONS",Order=17)]
        [MaxLength(500)] 
        public String Conditions { get; set; }
        
        [Description("Date validation")]
        [Column("DATE_VALID",Order=18)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Nom valideur")]
        [Column("NOM_VALID",Order=19)]
        [MaxLength(255)] 
        public String NomValid { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=20)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=21)]
        [MaxLength(1000)] 
        public String Prioritaire { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=22)]
        [MaxLength(1000)] 
        public String Securite { get; set; }
        
        [Description("Appuis-Fondations")]
        [Column("NOTE1",Order=23)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Tabliers")]
        [Column("NOTE2",Order=24)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Equipements")]
        [Column("NOTE3",Order=25)]
        public Nullable<Int64> Note3 { get; set; }
        
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
