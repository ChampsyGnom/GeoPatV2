using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_VOIE_INF",Schema="INF")]
    public partial class InfCdVoie : ModelBase
    {
        public virtual ICollection<InfPaveVoie> InfPaveVoies { get; set; }
        
        public virtual ICollection<InfClVoie> InfClVoies { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Voie")]
        [Column("VOIE",Order=1)]
        [Required()]
        [MaxLength(6)] 
        public String Voie { get; set; }
        
        [Description("Position")]
        [Column("POSIT",Order=2)]
        [Required()]
        public Int64 Posit { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=3)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Roulable")]
        [Column("ROULABLE",Order=4)]
        public Nullable<int> RoulableValueInt { get; set; }
        [NotMapped]
        public Nullable<Boolean> Roulable 
        {
            get
            {
                if (RoulableValueInt.HasValue) return Convert.ToBoolean(RoulableValueInt.Value);
                else return null;
            }
            set
            {
                if (value.HasValue) {this.RoulableValueInt = Convert.ToInt32(value.Value);}
                else {this.RoulableValueInt =null;}
            }
        }
        
    }
}
