using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_LIGNE_GOT",Schema="GOT")]
    public partial class GotCdLigne : ModelBase
    {
        private GotCdChapitre _gotCdChapitre;
        public virtual GotCdChapitre GotCdChapitre 
        {
            get
            {
                return this._gotCdChapitre;
                
            }
            set
            {
                this._gotCdChapitre = value;
                this.CdChapitreGotIdChap = this._gotCdChapitre.IdChap;
            }
        }
        
        [Required()]
        [Column("CD_CHAPITRE_GOT_ID_PK",Order=0)]
        public Int64 GotCdChapitreIdPk {get;set;}
        
        public virtual ICollection<GotSprtVst> GotSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GOT__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreGotIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("ID_LIGNE",Order=3)]
        [Required()]
        public Int64 IdLigne { get; set; }
        
        [Description("Libellé ligne")]
        [Column("LIBELLE",Order=4)]
        [Required()]
        [MaxLength(500)] 
        public String Libelle { get; set; }
        
        [Description("N° d'ordre ligne")]
        [Column("ORDRE_LIGNE",Order=5)]
        [Required()]
        public Int64 OrdreLigne { get; set; }
        
    }
}
