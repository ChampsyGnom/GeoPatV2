using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_LIGNE_OH",Schema="OH")]
    public partial class OhCdLigne : ModelBase
    {
        private OhCdChapitre _ohCdChapitre;
        public virtual OhCdChapitre OhCdChapitre 
        {
            get
            {
                return this._ohCdChapitre;
                
            }
            set
            {
                this._ohCdChapitre = value;
                this.CdChapitreOhIdChap = this._ohCdChapitre.IdChap;
            }
        }
        
        [Required()]
        [Column("CD_CHAPITRE_OH_ID_PK",Order=0)]
        public Int64 OhCdChapitreIdPk {get;set;}
        
        public virtual ICollection<OhSprtVst> OhSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OH__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreOhIdChap { get; set; }
        
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
