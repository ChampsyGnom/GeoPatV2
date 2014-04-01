using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BPU_GOT",Schema="GOT")]
    public partial class GotBpu : ModelBase
    {
        public virtual GotCdTravaux GotCdTravaux {get;set;}
        
        public virtual GotCdUnite GotCdUnite {get;set;}
        
        public virtual ICollection<GotPrevision> GotPrevisions { get; set; }
        
        public virtual ICollection<GotCdPrecoSprtVst> GotCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Bordereau")]
        [Column("ID_BPU",Order=0)]
        [Required()]
        public Int64 IdBpu { get; set; }
        
        [Description("Type Travaux")]
        [Column("CD_TRAVAUX_GOT__CODE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxGotCode { get; set; }
        
        [Description("Unité")]
        [Column("CD_UNITE_GOT__UNITE",Order=2)]
        [MaxLength(12)] 
        public String CdUniteGotUnite { get; set; }
        
        [Description("Technique")]
        [Column("TECHN",Order=3)]
        [Required()]
        [MaxLength(255)] 
        public String Techn { get; set; }
        
        [Description("Prix Unitaire (€)")]
        [Column("PRIX",Order=4)]
        [Required()]
        public Int64 Prix { get; set; }
        
        [Description("Date MAJ")]
        [Column("DATE_MAJ",Order=5)]
        public Nullable<DateTime> DateMaj { get; set; }
        
        [Description("Fréquence (mois)")]
        [Column("FREQ",Order=6)]
        public Nullable<Int64> Freq { get; set; }
        
        [Description("Préconisation Visite")]
        [Column("PRECO_VST",Order=7)]
        public Nullable<int> PrecoVstValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> PrecoVst 
        {
            get
            {
                if (PrecoVstValueInt.HasValue) return Convert.ToBoolean(PrecoVstValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.PrecoVstValueInt = Convert.ToInt32(value.Value);}
                else {this.PrecoVstValueInt =null;}
            }
        }
        
        [Description("Entretien réalisable")]
        [Column("REALIS_VST",Order=8)]
        public Nullable<int> RealisVstValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> RealisVst 
        {
            get
            {
                if (RealisVstValueInt.HasValue) return Convert.ToBoolean(RealisVstValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealisVstValueInt = Convert.ToInt32(value.Value);}
                else {this.RealisVstValueInt =null;}
            }
        }
        
    }
}
