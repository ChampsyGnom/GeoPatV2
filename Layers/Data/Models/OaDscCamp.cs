using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_CAMP_OA",Schema="OA")]
    public partial class OaDscCamp : ModelBase
    {
        public virtual OaDsc OaDsc {get;set;}
        
        public virtual OaCamp OaCamp {get;set;}
        
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
        
        [Description("Contrôle réalisé")]
        [Column("REALISER",Order=2)]
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
