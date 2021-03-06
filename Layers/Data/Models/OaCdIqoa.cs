using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_IQOA_OA",Schema="OA")]
    public partial class OaCdIqoa : ModelBase
    {
        public virtual ICollection<OaInsp> OaInsps { get; set; }
        
        public virtual ICollection<OaCdQualite> OaCdQualites { get; set; }
        
        public virtual ICollection<OaInspTmp> OaInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=0)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Note IQOA")]
        [Column("NOTE_IQOA",Order=1)]
        [Required()]
        [MaxLength(3)] 
        public String NoteIqoa { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=2)]
        [MaxLength(1000)] 
        public String Commentaire { get; set; }
        
    }
}
