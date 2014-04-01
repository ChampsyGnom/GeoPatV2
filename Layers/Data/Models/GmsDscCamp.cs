using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_CAMP_GMS",Schema="GMS")]
    public partial class GmsDscCamp
    {
        public virtual GmsDsc GmsDsc {get;set;}
        
        public virtual GmsCamp GmsCamp {get;set;}
        
        [Key]
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=0)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Key]
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=1)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("Contrôle Réalisé")]
        [Column("REALISER",Order=2)]
        public Nullable<int> Realiser { get; set; }
        
    }
}
