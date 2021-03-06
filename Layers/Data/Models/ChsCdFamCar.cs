using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FAM_CAR_CHS",Schema="CHS")]
    public partial class ChsCdFamCar : ModelBase
    {
        public virtual ICollection<ChsFamCar> ChsFamCars { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille")]
        [Column("FAMILLE",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Famille { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Coefficient Agressivité Moyen")]
        [Column("CAM",Order=3)]
        [Required()]
        public Double Cam { get; set; }
        
    }
}
