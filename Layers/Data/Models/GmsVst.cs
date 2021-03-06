using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("VST_GMS",Schema="GMS")]
    public partial class GmsVst : ModelBase
    {
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
        [Column("CAMP_GMS_ID_PK",Order=0)]
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
        [Column("DSC_GMS_ID_PK",Order=1)]
        public Int64 GmsDscIdPk {get;set;}
        
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
        
        [Column("INSPECTEUR_GMS_ID_PK",Order=2)]
        public Nullable<Int64> GmsInspecteurIdPk {get;set;}
        
        public virtual ICollection<GmsSprtVst> GmsSprtVsts { get; set; }
        
        public virtual ICollection<GmsPhotoVst> GmsPhotoVsts { get; set; }
        
        public virtual ICollection<GmsEntete> GmsEntetes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=3)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=5)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_GMS__NOM",Order=6)]
        [MaxLength(60)] 
        public String InspecteurGmsNom { get; set; }
        
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
