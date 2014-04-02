using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("BPU_OH",Schema="OH")]
    public partial class OhBpu : ModelBase
    {
        public virtual OhCdTravaux OhCdTravaux {get;set;}
        
        [Required()]
        [Column("CD_TRAVAUX_OH_ID_PK",Order=0)]
        public Int64 OhCdTravauxIdPk {get;set;}
        
        public virtual OhCdUnite OhCdUnite {get;set;}
        
        [Column("CD_UNITE_OH_ID_PK",Order=1)]
        public Nullable<Int64> OhCdUniteIdPk {get;set;}
        
        public virtual ICollection<OhPrevision> OhPrevisions { get; set; }
        
        public virtual ICollection<OhCdPrecoSprtVst> OhCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Bordereau")]
        [Column("ID_BPU",Order=3)]
        [Required()]
        public Int64 IdBpu { get; set; }
        
        [Description("Unité")]
        [Column("CD_UNITE_OH__UNITE",Order=4)]
        [MaxLength(12)] 
        public String CdUniteOhUnite { get; set; }
        
        [Description("Type travaux")]
        [Column("CD_TRAVAUX_OH__CODE",Order=5)]
        [Required()]
        [MaxLength(60)] 
        public String CdTravauxOhCode { get; set; }
        
        [Description("Technique")]
        [Column("TECHN",Order=6)]
        [Required()]
        [MaxLength(255)] 
        public String Techn { get; set; }
        
        [Description("Prix Unitaire (€)")]
        [Column("PRIX",Order=7)]
        public Nullable<Int64> Prix { get; set; }
        
        [Description("Date MAJ")]
        [Column("DATE_MAJ",Order=8)]
        public Nullable<DateTime> DateMaj { get; set; }
        
        [Description("Fréquence (mois)")]
        [Column("FREQ",Order=9)]
        public Nullable<Int64> Freq { get; set; }
        
        [Description("Préconisation Visite")]
        [Column("PRECO_VST",Order=10)]
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
        [Column("REALIS_VST",Order=11)]
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
