using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("NE_ADMIN_CHS",Schema="CHS")]
    public partial class ChsNeAdmin : ModelBase
    {
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
        
        [Description("Début")]
        [Column("ABS_DEB",Order=3)]
        [Required()]
        public Int64 AbsDeb { get; set; }
        
        [Description("Fin")]
        [Column("ABS_FIN",Order=4)]
        [Required()]
        public Int64 AbsFin { get; set; }
        
        [Description("Nbre Essieu Admissible")]
        [Column("NE_ADMISS",Order=5)]
        public Nullable<Int64> NeAdmiss { get; set; }
        
        [Description("Date démarage NE")]
        [Column("DATE_ADMISS",Order=6)]
        public Nullable<DateTime> DateAdmiss { get; set; }
        
    }
}
