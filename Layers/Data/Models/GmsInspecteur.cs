using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSPECTEUR_GMS",Schema="GMS")]
    public partial class GmsInspecteur : ModelBase
    {
        private GmsCdPresta _gmsCdPresta;
        public virtual GmsCdPresta GmsCdPresta 
        {
            get
            {
                return this._gmsCdPresta;
                
            }
            set
            {
                this._gmsCdPresta = value;
                this.CdPrestaGmsPrestataire = this._gmsCdPresta.Prestataire;
            }
        }
        
        [Required()]
        [Column("CD_PRESTA_GMS_ID_PK",Order=0)]
        public Int64 GmsCdPrestaIdPk {get;set;}
        
        public virtual ICollection<GmsInsp> GmsInsps { get; set; }
        
        public virtual ICollection<GmsVst> GmsVsts { get; set; }
        
        public virtual ICollection<GmsInspTmp> GmsInspTmps { get; set; }
        
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
        [Column("CD_PRESTA_GMS__PRESTATAIRE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaGmsPrestataire { get; set; }
        
        [Description("Fonction")]
        [Column("FONC",Order=4)]
        [MaxLength(60)] 
        public String Fonc { get; set; }
        
    }
}
