using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SEUIL_QUALITE_BSN",Schema="BSN")]
    public partial class BsnSeuilQualite : ModelBase
    {
        private BsnCdQualite _bsnCdQualite;
        public virtual BsnCdQualite BsnCdQualite 
        {
            get
            {
                return this._bsnCdQualite;
                
            }
            set
            {
                this._bsnCdQualite = value;
                this.CdQualiteBsnQualite = this._bsnCdQualite.Qualite;
            }
        }
        
        [Required()]
        [Column("CD_QUALITE_BSN_ID_PK",Order=0)]
        public Int64 BsnCdQualiteIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Niveau qualité")]
        [Column("CD_QUALITE_BSN__QUALITE",Order=2)]
        [Required()]
        [MaxLength(25)] 
        public String CdQualiteBsnQualite { get; set; }
        
        [Description("Indice urgence")]
        [Column("INDICE_URGENCE",Order=3)]
        [Required()]
        [MaxLength(5)] 
        public String IndiceUrgence { get; set; }
        
    }
}
