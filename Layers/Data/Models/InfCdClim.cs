using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_CLIM_INF",Schema="INF")]
    public partial class InfCdClim : ModelBase
    {
        public virtual ICollection<InfClim> InfClims { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Type Climat")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(25)] 
        public String Code { get; set; }
        
    }
}
