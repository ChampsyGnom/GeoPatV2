using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_LIGNE_BSN",Schema="BSN")]
    public partial class BsnCdLigne : ModelBase
    {
        private BsnCdChapitre _bsnCdChapitre;
        public virtual BsnCdChapitre BsnCdChapitre 
        {
            get
            {
                return this._bsnCdChapitre;
                
            }
            set
            {
                this._bsnCdChapitre = value;
                this.CdChapitreBsnIdChap = this._bsnCdChapitre.IdChap;
            }
        }
        
        [Required()]
        [Column("CD_CHAPITRE_BSN_ID_PK",Order=0)]
        public Int64 BsnCdChapitreIdPk {get;set;}
        
        public virtual ICollection<BsnSprtVst> BsnSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_BSN__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreBsnIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("ID_LIGNE",Order=3)]
        [Required()]
        public Int64 IdLigne { get; set; }
        
        [Description("Libellé Ligne")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("N° ordre ligne")]
        [Column("ORDRE_LIGNE",Order=5)]
        [Required()]
        public Int64 OrdreLigne { get; set; }
        
    }
}
