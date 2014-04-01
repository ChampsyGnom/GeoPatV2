using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRECO__SPRT_VST_OA",Schema="OA")]
    public partial class OaCdPrecoSprtVst : ModelBase
    {
        public virtual OaVst OaVst {get;set;}
        
        public virtual OaBpu OaBpu {get;set;}
        
        [Key]
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=0)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Key]
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Key]
        [Description("Identifiant Bordereau")]
        [Column("BPU_OA__ID_BPU",Order=2)]
        [Required()]
        public Int64 BpuOaIdBpu { get; set; }
        
        [Description("Entretien réalisé")]
        [Column("CD_PRECO__SPRT_VST_OH__REALISE",Order=3)]
        public Nullable<int> CdPrecoSprtVstOhRealiseValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> CdPrecoSprtVstOhRealise 
        {
            get
            {
                if (CdPrecoSprtVstOhRealiseValueInt.HasValue) return Convert.ToBoolean(CdPrecoSprtVstOhRealiseValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.CdPrecoSprtVstOhRealiseValueInt = Convert.ToInt32(value.Value);}
                else {this.CdPrecoSprtVstOhRealiseValueInt =null;}
            }
        }
        
    }
}
