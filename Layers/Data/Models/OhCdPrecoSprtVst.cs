using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRECO__SPRT_VST_OH",Schema="OH")]
    public partial class OhCdPrecoSprtVst : ModelBase
    {
        public virtual OhSprtVst OhSprtVst {get;set;}
        
        [Required()]
        [Column("SPRT_VST_OH_ID_PK",Order=0)]
        public Int64 OhSprtVstIdPk {get;set;}
        
        public virtual OhBpu OhBpu {get;set;}
        
        [Required()]
        [Column("BPU_OH_ID_PK",Order=1)]
        public Int64 OhBpuIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OH__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreOhIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_OH__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneOhIdLigne { get; set; }
        
        [Description("Identifiant Bordereau")]
        [Column("BPU_OH__ID_BPU",Order=7)]
        [Required()]
        public Int64 BpuOhIdBpu { get; set; }
        
        [Description("Entretien réalisé")]
        [Column("REALISE",Order=8)]
        public Nullable<int> RealiseValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Realise 
        {
            get
            {
                if (RealiseValueInt.HasValue) return Convert.ToBoolean(RealiseValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealiseValueInt = Convert.ToInt32(value.Value);}
                else {this.RealiseValueInt =null;}
            }
        }
        
    }
}
