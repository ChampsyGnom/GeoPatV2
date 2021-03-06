using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_RISQUE_GOT",Schema="GOT")]
    public partial class GotCdRisque : ModelBase
    {
        public virtual ICollection<GotDsc> GotDscs { get; set; }
        
        public virtual ICollection<GotHistoNote> GotHistoNotes { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Note Risque")]
        [Column("RISQUE",Order=1)]
        [Required()]
        [MaxLength(3)] 
        public String Risque { get; set; }
        
    }
}
