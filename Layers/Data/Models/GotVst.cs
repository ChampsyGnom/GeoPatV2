using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("VST_GOT",Schema="GOT")]
    public partial class GotVst : ModelBase
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
        [Column("CAMP_GOT_ID_PK",Order=1)]
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
        
        [Column("INSPECTEUR_GOT_ID_PK",Order=2)]
        public Nullable<Int64> GotInspecteurIdPk {get;set;}
        
        public virtual ICollection<GotPhotoVst> GotPhotoVsts { get; set; }
        
        public virtual ICollection<GotSprtVst> GotSprtVsts { get; set; }
        
        public virtual ICollection<GotEntete> GotEntetes { get; set; }
        
        public virtual ICollection<GotCdPrecoSprtVst> GotCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=4)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_GOT__ID_CAMP",Order=5)]
        [Required()]
        [MaxLength(100)] 
        public String CampGotIdCamp { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_GOT__NOM",Order=6)]
        [MaxLength(60)] 
        public String InspecteurGotNom { get; set; }
        
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
