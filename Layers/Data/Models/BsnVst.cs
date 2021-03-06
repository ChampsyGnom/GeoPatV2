using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("VST_BSN",Schema="BSN")]
    public partial class BsnVst : ModelBase
    {
        private BsnCamp _bsnCamp;
        public virtual BsnCamp BsnCamp 
        {
            get
            {
                return this._bsnCamp;
                
            }
            set
            {
                this._bsnCamp = value;
                this.CampBsnIdCamp = this._bsnCamp.IdCamp;
            }
        }
        
        [Required()]
        [Column("CAMP_BSN_ID_PK",Order=0)]
        public Int64 BsnCampIdPk {get;set;}
        
        private BsnDsc _bsnDsc;
        public virtual BsnDsc BsnDsc 
        {
            get
            {
                return this._bsnDsc;
                
            }
            set
            {
                this._bsnDsc = value;
                this.DscBsnNumBsn = this._bsnDsc.NumBsn;
            }
        }
        
        [Required()]
        [Column("DSC_BSN_ID_PK",Order=1)]
        public Int64 BsnDscIdPk {get;set;}
        
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
        
        [Column("INSPECTEUR_BSN_ID_PK",Order=2)]
        public Nullable<Int64> BsnInspecteurIdPk {get;set;}
        
        public virtual ICollection<BsnSprtVst> BsnSprtVsts { get; set; }
        
        public virtual ICollection<BsnPhotoVst> BsnPhotoVsts { get; set; }
        
        public virtual ICollection<BsnEntete> BsnEntetes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=5)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_BSN__NOM",Order=6)]
        [MaxLength(60)] 
        public String InspecteurBsnNom { get; set; }
        
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
