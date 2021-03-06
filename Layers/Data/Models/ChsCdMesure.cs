using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_MESURE_CHS",Schema="CHS")]
    public partial class ChsCdMesure : ModelBase
    {
        public virtual ICollection<ChsCdIndic> ChsCdIndics { get; set; }
        
        public virtual ICollection<ChsCamp> ChsCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Code Agr")]
        [Column("AGR",Order=1)]
        [Required()]
        [MaxLength(12)] 
        public String Agr { get; set; }
        
        [Description("Libellé")]
        [Column("LIBELLE",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String Libelle { get; set; }
        
        [Description("Cycle de surveillance")]
        [Column("CYCLE",Order=3)]
        [Required()]
        public Int64 Cycle { get; set; }
        
        [Description("Prix Unitaire (km)")]
        [Column("PRIX",Order=4)]
        public Nullable<Int64> Prix { get; set; }
        
    }
}
