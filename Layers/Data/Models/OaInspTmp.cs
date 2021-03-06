using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSP_TMP_OA",Schema="OA")]
    public partial class OaInspTmp : ModelBase
    {
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
        
        [Column("CD_ETUDE_OA_ID_PK",Order=0)]
        public Nullable<Int64> OaCdEtudeIdPk {get;set;}
        
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
        [Column("CD_IQOA_OA_ID_PK",Order=2)]
        public Int64 OaCdIqoaIdPk {get;set;}
        
        private OaDscTemp _oaDscTemp;
        public virtual OaDscTemp OaDscTemp 
        {
            get
            {
                return this._oaDscTemp;
                
            }
            set
            {
                this._oaDscTemp = value;
                this.CampOaIdCamp = this._oaDscTemp.CampOaIdCamp;
                this.DscTempOaNumOa = this._oaDscTemp.NumOa;
            }
        }
        
        [Required()]
        [Column("DSC_TEMP_OA_ID_PK",Order=3)]
        public Int64 OaDscTempIdPk {get;set;}
        
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
        
        [Column("INSPECTEUR_OA_ID_PK",Order=4)]
        public Nullable<Int64> OaInspecteurIdPk {get;set;}
        
        public virtual ICollection<OaEltInspTmp> OaEltInspTmps { get; set; }
        
        public virtual ICollection<OaPhotoInspTmp> OaPhotoInspTmps { get; set; }
        
        public virtual ICollection<OaCdConclusionInspTmp> OaCdConclusionInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=5)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=6)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("NumOA")]
        [Column("DSC_TEMP_OA__NUM_OA",Order=7)]
        [Required()]
        [MaxLength(20)] 
        public String DscTempOaNumOa { get; set; }
        
        [Description("Note IQOA")]
        [Column("CD_IQOA_OA__NOTE_IQOA",Order=8)]
        [Required()]
        [MaxLength(3)] 
        public String CdIqoaOaNoteIqoa { get; set; }
        
        [Description("Condition météo")]
        [Column("CD_METEO_OA__METEO",Order=9)]
        [MaxLength(60)] 
        public String CdMeteoOaMeteo { get; set; }
        
        [Description("Etude-Expertise")]
        [Column("CD_ETUDE_OA__ETUDE",Order=10)]
        [MaxLength(60)] 
        public String CdEtudeOaEtude { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_OA__NOM",Order=11)]
        [MaxLength(60)] 
        public String InspecteurOaNom { get; set; }
        
        [Description("Statut visite")]
        [Column("ETAT",Order=12)]
        [Required()]
        [MaxLength(25)] 
        public String Etat { get; set; }
        
        [Description("Date de visite")]
        [Column("DATEV",Order=13)]
        public Nullable<DateTime> Datev { get; set; }
        
        [Description("Température")]
        [Column("TEMPERATURE",Order=14)]
        public Nullable<Double> Temperature { get; set; }
        
        [Description("Moyens utilisés")]
        [Column("MOYEN",Order=15)]
        [MaxLength(500)] 
        public String Moyen { get; set; }
        
        [Description("Conditions particulières")]
        [Column("CONDITIONS",Order=16)]
        [MaxLength(500)] 
        public String Conditions { get; set; }
        
        [Description("Date validation")]
        [Column("DATE_VALID",Order=17)]
        public Nullable<DateTime> DateValid { get; set; }
        
        [Description("Nom valideur")]
        [Column("NOM_VALID",Order=18)]
        [MaxLength(255)] 
        public String NomValid { get; set; }
        
        [Description("Description invalide")]
        [Column("DESC_INVA",Order=19)]
        [MaxLength(1000)] 
        public String DescInva { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=20)]
        [MaxLength(1000)] 
        public String Prioritaire { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=21)]
        [MaxLength(1000)] 
        public String Securite { get; set; }
        
        [Description("Appuis-Fondations")]
        [Column("NOTE1",Order=22)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Tabliers")]
        [Column("NOTE2",Order=23)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Equipements")]
        [Column("NOTE3",Order=24)]
        public Nullable<Int64> Note3 { get; set; }
        
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
