using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_GEST_OA",Schema="OA")]
    public partial class OaCdGest : ModelBase
    {
        public virtual ICollection<OaDsc> OaDscs { get; set; }
        
        public virtual ICollection<OaDscTemp> OaDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Gestionnaire")]
        [Column("GESTIONNAIRE",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Gestionnaire { get; set; }
        
    }
}
