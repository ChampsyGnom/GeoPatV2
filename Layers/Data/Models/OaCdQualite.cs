using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_QUALITE_OA",Schema="OA")]
    public partial class OaCdQualite : ModelBase
    {
        private OaCdIqoa _oaCdIqoa;
        public virtual OaCdIqoa OaCdIqoa 
        {
            get
            {
                return this._oaCdIqoa;
                
            }
            set
            {
                this._oaCdIqoa = value;
                this.CdIqoaOaNoteIqoa = this._oaCdIqoa.NoteIqoa;
            }
        }
        
        [Required()]
        [Column("CD_IQOA_OA_ID_PK",Order=0)]
        public Int64 OaCdIqoaIdPk {get;set;}
        
        public virtual ICollection<OaDsc> OaDscs { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Note IQOA")]
        [Column("CD_IQOA_OA__NOTE_IQOA",Order=2)]
        [Required()]
        [MaxLength(3)] 
        public String CdIqoaOaNoteIqoa { get; set; }
        
        [Description("Niveau qualité")]
        [Column("QUALITE",Order=3)]
        [Required()]
        [MaxLength(25)] 
        public String Qualite { get; set; }
        
    }
}
