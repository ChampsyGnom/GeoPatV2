using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_POS_MAT_GMS",Schema="GMS")]
    public partial class GmsCdPosMat : ModelBase
    {
        public virtual ICollection<GmsDsc> GmsDscs { get; set; }
        
        public virtual ICollection<GmsDscTemp> GmsDscTemps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Position")]
        [Column("POSIT",Order=1)]
        [Required()]
        [MaxLength(4)] 
        public String Posit { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
    }
}
