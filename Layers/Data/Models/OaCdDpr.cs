using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_DPR_OA",Schema="OA")]
    public partial class OaCdDpr : ModelBase
    {
        public virtual ICollection<OaEquipement> OaEquipements { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Dispositif de retenue")]
        [Column("DPR",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String Dpr { get; set; }
        
        [Description("Garantie (mois)")]
        [Column("GARANTIE",Order=2)]
        public Nullable<Int64> Garantie { get; set; }
        
        [Description("Durée de vie (mois)")]
        [Column("DVT",Order=3)]
        public Nullable<Int64> Dvt { get; set; }
        
    }
}
