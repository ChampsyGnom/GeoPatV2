using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_APP_APPUI_OA",Schema="OA")]
    public partial class OaCdAppAppui
    {
        public virtual ICollection<OaAppuis> OaAppuiss { get; set; }
        
        [Key]
        [Description("Type app appui")]
        [Column("APPUI",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Appui { get; set; }
        
        [Description("Garantie (mois)")]
        [Column("GARANTIE",Order=1)]
        public Nullable<Int64> Garantie { get; set; }
        
        [Description("Durée de vie (mois)")]
        [Column("DVT",Order=2)]
        public Nullable<Int64> Dvt { get; set; }
        
    }
}
