using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_PROTEC_GMS",Schema="GMS")]
    public partial class GmsCdProtec
    {
        public virtual ICollection<GmsDsc> GmsDscs { get; set; }
        
        public virtual ICollection<GmsDscTemp> GmsDscTemps { get; set; }
        
        [Key]
        [Description("Type protection")]
        [Column("PROTEC",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Protec { get; set; }
        
    }
}
