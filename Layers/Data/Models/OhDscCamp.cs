using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("DSC_CAMP_OH",Schema="OH")]
    public partial class OhDscCamp : ModelBase
    {
        public virtual OhDsc OhDsc {get;set;}
        
        [Required()]
        [Column("DSC_OH_ID_PK",Order=0)]
        public Int64 OhDscIdPk {get;set;}
        
        public virtual OhCamp OhCamp {get;set;}
        
        [Required()]
        [Column("CAMP_OH_ID_PK",Order=1)]
        public Int64 OhCampIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
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
