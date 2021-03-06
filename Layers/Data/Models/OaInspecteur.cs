using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSPECTEUR_OA",Schema="OA")]
    public partial class OaInspecteur : ModelBase
    {
        private OaCdPresta _oaCdPresta;
        public virtual OaCdPresta OaCdPresta 
        {
            get
            {
                return this._oaCdPresta;
                
            }
            set
            {
                this._oaCdPresta = value;
                this.CdPrestaOaPrestataire = this._oaCdPresta.Prestataire;
            }
        }
        
        [Required()]
        [Column("CD_PRESTA_OA_ID_PK",Order=0)]
        public Int64 OaCdPrestaIdPk {get;set;}
        
        public virtual ICollection<OaInsp> OaInsps { get; set; }
        
        public virtual ICollection<OaVst> OaVsts { get; set; }
        
        public virtual ICollection<OaInspTmp> OaInspTmps { get; set; }
        
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
        [Column("CD_PRESTA_OA__PRESTATAIRE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaOaPrestataire { get; set; }
        
        [Description("Fonction")]
        [Column("FONC",Order=4)]
        [MaxLength(60)] 
        public String Fonc { get; set; }
        
    }
}
