using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CD_LIGNE_GMS",Schema="GMS")]
    public partial class GmsCdLigne : ModelBase
    {
        private GmsCdChapitre _gmsCdChapitre;
        public virtual GmsCdChapitre GmsCdChapitre 
        {
            get
            {
                return this._gmsCdChapitre;
                
            }
            set
            {
                this._gmsCdChapitre = value;
                this.CdChapitreGmsIdChap = this._gmsCdChapitre.IdChap;
            }
        }
        
        [Required()]
        [Column("CD_CHAPITRE_GMS_ID_PK",Order=0)]
        public Int64 GmsCdChapitreIdPk {get;set;}
        
        public virtual ICollection<GmsSprtVst> GmsSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_GMS__ID_CHAP",Order=2)]
        [Required()]
        public Int64 CdChapitreGmsIdChap { get; set; }
        
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
        public Nullable<Int64> OrdreLigne { get; set; }
        
    }
}
