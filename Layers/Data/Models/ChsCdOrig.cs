using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_ORIG_CHS",Schema="CHS")]
    public partial class ChsCdOrig : ModelBase
    {
        public virtual ChsCdMat ChsCdMat {get;set;}
        
        public virtual ICollection<ChsFabCar> ChsFabCars { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nature de matériaux")]
        [Column("CD_MAT_CHS__CODE",Order=0)]
        [Required()]
        [MaxLength(12)] 
        public String CdMatChsCode { get; set; }
        
        [Description("Type fabricant/carrière")]
        [Column("CODE",Order=1)]
        [Required()]
        [MaxLength(20)] 
        public String Code { get; set; }
        
    }
}
