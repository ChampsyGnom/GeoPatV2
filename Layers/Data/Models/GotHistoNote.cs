using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("HISTO_NOTE_GOT",Schema="GOT")]
    public partial class GotHistoNote : ModelBase
    {
        public virtual GotCdOrigin GotCdOrigin {get;set;}
        
        public virtual GotDsc GotDsc {get;set;}
        
        public virtual GotCdRisque GotCdRisque {get;set;}
        
        [Key]
        [Description("N° Ouvrage")]
        [Column("DSC_GOT__NUM_GOT",Order=0)]
        [Required()]
        [MaxLength(17)] 
        public String DscGotNumGot { get; set; }
        
        [Key]
        [Description("Date Note")]
        [Column("DATE_NOTE",Order=1)]
        [Required()]
        public DateTime DateNote { get; set; }
        
        [Description("Origine Note")]
        [Column("CD_ORIGIN_GOT__ORIGINE",Order=2)]
        [Required()]
        [MaxLength(20)] 
        public String CdOriginGotOrigine { get; set; }
        
        [Description("Note Risque")]
        [Column("CD_RISQUE_GOT__RISQUE",Order=3)]
        [MaxLength(3)] 
        public String CdRisqueGotRisque { get; set; }
        
        [Description("Note Plateforme 1")]
        [Column("NOTE1",Order=4)]
        public Nullable<Int64> Note1 { get; set; }
        
        [Description("Note Plateforme 2")]
        [Column("NOTE2",Order=5)]
        public Nullable<Int64> Note2 { get; set; }
        
        [Description("Note Talus 1")]
        [Column("NOTE3",Order=6)]
        public Nullable<Int64> Note3 { get; set; }
        
        [Description("Note Talus 2")]
        [Column("NOTE4",Order=7)]
        public Nullable<Int64> Note4 { get; set; }
        
        [Description("Note Environnement")]
        [Column("NOTE5",Order=8)]
        public Nullable<Int64> Note5 { get; set; }
        
        [Description("Niveau Urgence")]
        [Column("URGENCE",Order=9)]
        [MaxLength(5)] 
        public String Urgence { get; set; }
        
        [Description("Problème de sécurité")]
        [Column("SECURITE",Order=10)]
        public Nullable<int> SecuriteValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Securite 
        {
            get
            {
                if (SecuriteValueInt.HasValue) return Convert.ToBoolean(SecuriteValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.SecuriteValueInt = Convert.ToInt32(value.Value);}
                else {this.SecuriteValueInt =null;}
            }
        }
        
        [Description("Urgence traitement")]
        [Column("PRIORITAIRE",Order=11)]
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
        
    }
}
