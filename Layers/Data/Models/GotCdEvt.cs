using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_EVT_GOT",Schema="GOT")]
    public partial class GotCdEvt : ModelBase
    {
        public virtual ICollection<GotEvt> GotEvts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type événement")]
        [Column("TYPE",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Type { get; set; }
        
        [Description("Impact métier")]
        [Column("IMPACT",Order=2)]
        public Nullable<int> ImpactValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Impact 
        {
            get
            {
                if (ImpactValueInt.HasValue) return Convert.ToBoolean(ImpactValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.ImpactValueInt = Convert.ToInt32(value.Value);}
                else {this.ImpactValueInt =null;}
            }
        }
        
    }
}
