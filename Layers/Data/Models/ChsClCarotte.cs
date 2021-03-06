using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CL_CAROTTE_CHS",Schema="CHS")]
    public partial class ChsClCarotte : ModelBase
    {
        public virtual ICollection<ChsDetailCarotte> ChsDetailCarottes { get; set; }
        
        public virtual ICollection<ChsExploitCarotte> ChsExploitCarottes { get; set; }
        
        public virtual ICollection<ChsClRoul> ChsClRouls { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Liaison")]
        [Column("LIAISON",Order=1)]
        [Required()]
        [MaxLength(15)] 
        public String Liaison { get; set; }
        
        [Description("Sens")]
        [Column("SENS",Order=2)]
        [Required()]
        [MaxLength(6)] 
        public String Sens { get; set; }
        
        [Description("Voie")]
        [Column("VOIE",Order=3)]
        [Required()]
        [MaxLength(6)] 
        public String Voie { get; set; }
        
        [Description("Début")]
        [Column("ABS_DEB",Order=4)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=5)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
    }
}
