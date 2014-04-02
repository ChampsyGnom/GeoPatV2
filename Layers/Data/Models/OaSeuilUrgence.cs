using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SEUIL_URGENCE_OA",Schema="OA")]
    public partial class OaSeuilUrgence : ModelBase
    {
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("No Ordre")]
        [Column("ORDRE",Order=1)]
        [Required()]
        public Int64 Ordre { get; set; }
        
        [Description(">= Nbre de Note")]
        [Column("NBR_NOTE",Order=2)]
        public Nullable<Int64> NbrNote { get; set; }
        
        [Description("Valeur Note")]
        [Column("VAL_NOTE",Order=3)]
        public Nullable<Int64> ValNote { get; set; }
        
        [Description("Indice dégradation")]
        [Column("INDICE",Order=4)]
        public Nullable<Int64> Indice { get; set; }
        
    }
}
