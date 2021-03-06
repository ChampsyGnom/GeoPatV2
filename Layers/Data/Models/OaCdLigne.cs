using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_LIGNE_OA",Schema="OA")]
    public partial class OaCdLigne : ModelBase
    {
        private OaCdChapitre _oaCdChapitre;
        public virtual OaCdChapitre OaCdChapitre 
        {
            get
            {
                return this._oaCdChapitre;
                
            }
            set
            {
                this._oaCdChapitre = value;
                this.CdChapitreOaIdChap = this._oaCdChapitre.IdChap;
            }
        }
        
        [Required()]
        [Column("CD_CHAPITRE_OA_ID_PK",Order=0)]
        public Int64 OaCdChapitreIdPk {get;set;}
        
        public virtual ICollection<OaSprtVst> OaSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OA__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreOaIdChap { get; set; }
        
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
