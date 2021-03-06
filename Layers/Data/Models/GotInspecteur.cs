using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSPECTEUR_GOT",Schema="GOT")]
    public partial class GotInspecteur : ModelBase
    {
        private GotCdPresta _gotCdPresta;
        public virtual GotCdPresta GotCdPresta 
        {
            get
            {
                return this._gotCdPresta;
                
            }
            set
            {
                this._gotCdPresta = value;
                this.CdPrestaGotPrestataire = this._gotCdPresta.Prestataire;
            }
        }
        
        [Required()]
        [Column("CD_PRESTA_GOT_ID_PK",Order=0)]
        public Int64 GotCdPrestaIdPk {get;set;}
        
        public virtual ICollection<GotInsp> GotInsps { get; set; }
        
        public virtual ICollection<GotVst> GotVsts { get; set; }
        
        public virtual ICollection<GotInspTmp> GotInspTmps { get; set; }
        
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
        [Column("CD_PRESTA_GOT__PRESTATAIRE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaGotPrestataire { get; set; }
        
        [Description("Fonction")]
        [Column("FONC",Order=4)]
        [MaxLength(60)] 
        public String Fonc { get; set; }
        
    }
}
