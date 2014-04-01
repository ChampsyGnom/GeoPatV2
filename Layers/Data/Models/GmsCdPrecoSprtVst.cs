using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PRECO__SPRT_VST_GMS",Schema="GMS")]
    public partial class GmsCdPrecoSprtVst : ModelBase
    {
        public virtual GmsBpu GmsBpu {get;set;}
        
        public virtual GmsSprtVst GmsSprtVst {get;set;}
        
        [Key]
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=0)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Key]
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=1)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Key]
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GMS__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreGmsIdChap { get; set; }
        
        [Key]
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_GMS__ID_LIGNE",Order=3)]
        [Required()]
        public Int64 CdLigneGmsIdLigne { get; set; }
        
        [Key]
        [Description("Identifiant Bordereau")]
        [Column("BPU_GMS__ID_BPU",Order=4)]
        [Required()]
        public Int64 BpuGmsIdBpu { get; set; }
        
        [Description("Entretien réalisé")]
        [Column("REALISE",Order=5)]
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
