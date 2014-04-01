using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("VST_OA",Schema="OA")]
    public partial class OaVst : ModelBase
    {
        public virtual OaDsc OaDsc {get;set;}
        
        public virtual OaCamp OaCamp {get;set;}
        
        public virtual OaInspecteur OaInspecteur {get;set;}
        
        public virtual ICollection<OaPhotoVst> OaPhotoVsts { get; set; }
        
        public virtual ICollection<OaSprtVst> OaSprtVsts { get; set; }
        
        public virtual ICollection<OaEntete> OaEntetes { get; set; }
        
        public virtual ICollection<OaCdPrecoSprtVst> OaCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Nom inspecteur")]
        [Column("INSPECTEUR_OA__NOM",Order=2)]
        [MaxLength(60)] 
        public String InspecteurOaNom { get; set; }
        
        [Description("Statut visite")]
        [Column("ETAT",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String Etat { get; set; }
        
        [Description("Date de visite")]
        [Column("DATEV",Order=4)]
        public Nullable<DateTime> Datev { get; set; }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=5)]
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
        [Column("OBSERV",Order=6)]
        [MaxLength(500)] 
        public String Observ { get; set; }
        
        [Description("Note Visite")]
        [Column("NOTE_VST",Order=7)]
        [MaxLength(5)] 
        public String NoteVst { get; set; }
        
    }
}
