using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_FAM_APPUI_OA",Schema="OA")]
    public partial class OaCdFamAppui : ModelBase
    {
        public virtual ICollection<OaAppuis> OaAppuiss { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Famille d'appuis")]
        [Column("FAM_APP",Order=1)]
        [Required()]
        [MaxLength(60)] 
        public String FamApp { get; set; }
        
    }
}
