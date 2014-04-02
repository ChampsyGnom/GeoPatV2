using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_CAMP_GMS",Schema="GMS")]
    public partial class GmsDscCamp : ModelBase
    {
        public virtual GmsDsc GmsDsc {get;set;}
        
        [Required()]
        [Column("DSC_GMS_ID_PK",Order=0)]
        public Int64 GmsDscIdPk {get;set;}
        
        public virtual GmsCamp GmsCamp {get;set;}
        
        [Required()]
        [Column("CAMP_GMS_ID_PK",Order=1)]
        public Int64 GmsCampIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("No GMS")]
        [Column("DSC_GMS__NUM_GMS",Order=3)]
        [Required()]
        [MaxLength(17)] 
        public String DscGmsNumGms { get; set; }
        
        [Description("Identifiant")]
        [Column("CAMP_GMS__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampGmsIdCamp { get; set; }
        
        [Description("Contrôle Réalisé")]
        [Column("REALISER",Order=5)]
        public Nullable<int> RealiserValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Realiser 
        {
            get
            {
                if (RealiserValueInt.HasValue) return Convert.ToBoolean(RealiserValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RealiserValueInt = Convert.ToInt32(value.Value);}
                else {this.RealiserValueInt =null;}
            }
        }
        
    }
}
