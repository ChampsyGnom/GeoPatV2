using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSPECTEUR_BSN",Schema="BSN")]
    public partial class BsnInspecteur : ModelBase
    {
        private BsnCdPresta _bsnCdPresta;
        public virtual BsnCdPresta BsnCdPresta 
        {
            get
            {
                return this._bsnCdPresta;
                
            }
            set
            {
                this._bsnCdPresta = value;
                this.CdPrestaBsnPrestataire = this._bsnCdPresta.Prestataire;
            }
        }
        
        [Required()]
        [Column("CD_PRESTA_BSN_ID_PK",Order=0)]
        public Int64 BsnCdPrestaIdPk {get;set;}
        
        public virtual ICollection<BsnInsp> BsnInsps { get; set; }
        
        public virtual ICollection<BsnVst> BsnVsts { get; set; }
        
        public virtual ICollection<BsnInspTmp> BsnInspTmps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Nom inspecteur")]
        [Column("NOM",Order=2)]
        [Required()]
        [MaxLength(60)] 
        public String Nom { get; set; }
        
        [Description("Prestataire")]
        [Column("CD_PRESTA_BSN__PRESTATAIRE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaBsnPrestataire { get; set; }
        
        [Description("Fonction")]
        [Column("FONC",Order=4)]
        [MaxLength(60)] 
        public String Fonc { get; set; }
        
    }
}
