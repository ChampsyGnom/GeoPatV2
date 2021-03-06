using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("INSPECTEUR_OH",Schema="OH")]
    public partial class OhInspecteur : ModelBase
    {
        private OhCdPresta _ohCdPresta;
        public virtual OhCdPresta OhCdPresta 
        {
            get
            {
                return this._ohCdPresta;
                
            }
            set
            {
                this._ohCdPresta = value;
                this.CdPrestaOhPrestataire = this._ohCdPresta.Prestataire;
            }
        }
        
        [Required()]
        [Column("CD_PRESTA_OH_ID_PK",Order=0)]
        public Int64 OhCdPrestaIdPk {get;set;}
        
        public virtual ICollection<OhInsp> OhInsps { get; set; }
        
        public virtual ICollection<OhVst> OhVsts { get; set; }
        
        public virtual ICollection<OhInspTmp> OhInspTmps { get; set; }
        
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
        [Column("CD_PRESTA_OH__PRESTATAIRE",Order=3)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaOhPrestataire { get; set; }
        
        [Description("Fonction")]
        [Column("FONC",Order=4)]
        [MaxLength(60)] 
        public String Fonc { get; set; }
        
    }
}
