using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_INTERFACE_GMS",Schema="GMS")]
    public partial class GmsCdInterface : ModelBase
    {
        public virtual ICollection<GmsDsc> GmsDscs { get; set; }
        
        public virtual ICollection<GmsPanneau> GmsPanneaus { get; set; }
        
        public virtual ICollection<GmsDscTemp> GmsDscTemps { get; set; }
        
        [Key]
        [Description("Type de liaison GMS")]
        [Column("TYPE",Order=0)]
        [Required()]
        [MaxLength(60)] 
        public String Type { get; set; }
        
        [Description("Fréquence vérification des serrages (mois)")]
        [Column("FREQUENCE",Order=1)]
        public Nullable<Int64> Frequence { get; set; }
        
    }
}
