using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("VST_OH",Schema="OH")]
    public partial class OhVst : ModelBase
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
        [Column("DSC_OH_ID_PK",Order=1)]
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
        
        [Column("INSPECTEUR_OH_ID_PK",Order=2)]
        public Nullable<Int64> OhInspecteurIdPk {get;set;}
        
        public virtual ICollection<OhSprtVst> OhSprtVsts { get; set; }
        
        public virtual ICollection<OhPhotoVst> OhPhotoVsts { get; set; }
        
        public virtual ICollection<OhEntete> OhEntetes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_OH__NOM",Order=6)]
        [MaxLength(60)] 
        public String InspecteurOhNom { get; set; }
        
        [Description("Statut visite")]
        [Column("ETAT",Order=7)]
        [Required()]
        [MaxLength(25)] 
        public String Etat { get; set; }
        
        [Description("Date de visite")]
        [Column("DATEV",Order=8)]
        public Nullable<DateTime> Datev { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=9)]
        public Nullable<int> PrioritaireValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Prioritaire 
        {
            get
            {
                if (PrioritaireValueInt.HasValue) return Convert.ToBoolean(PrioritaireValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PrioritaireValueInt = Convert.ToInt32(value.Value);}
                else {this.PrioritaireValueInt =null;}
            }
        }
        
        [Description("Observation")]
        [Column("OBSERV",Order=10)]
        [MaxLength(500)] 
        public String Observ { get; set; }
        
        [Description("Note Visite")]
        [Column("NOTE_VST",Order=11)]
        [MaxLength(5)] 
        public String NoteVst { get; set; }
        
    }
}
