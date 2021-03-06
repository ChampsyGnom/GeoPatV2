using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SEUIL_QUALITE_OH",Schema="OH")]
    public partial class OhSeuilQualite : ModelBase
    {
        private OhCdQualite _ohCdQualite;
        public virtual OhCdQualite OhCdQualite 
        {
            get
            {
                return this._ohCdQualite;
                
            }
            set
            {
                this._ohCdQualite = value;
                this.CdQualiteOhQualite = this._ohCdQualite.Qualite;
            }
        }
        
        [Required()]
        [Column("CD_QUALITE_OH_ID_PK",Order=0)]
        public Int64 OhCdQualiteIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Niveau qualité")]
        [Column("CD_QUALITE_OH__QUALITE",Order=2)]
        [Required()]
        [MaxLength(25)] 
        public String CdQualiteOhQualite { get; set; }
        
        [Description("Indice urgence")]
        [Column("INDICE_URGENCE",Order=3)]
        [Required()]
        [MaxLength(5)] 
        public String IndiceUrgence { get; set; }
        
    }
}
