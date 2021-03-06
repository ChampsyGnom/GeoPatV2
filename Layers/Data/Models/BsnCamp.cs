using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CAMP_BSN",Schema="BSN")]
    public partial class BsnCamp : ModelBase
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
        
        private BsnCdTypePv _bsnCdTypePv;
        public virtual BsnCdTypePv BsnCdTypePv 
        {
            get
            {
                return this._bsnCdTypePv;
                
            }
            set
            {
                this._bsnCdTypePv = value;
                this.CdTypePvBsnCode = this._bsnCdTypePv.Code;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_PV_BSN_ID_PK",Order=1)]
        public Int64 BsnCdTypePvIdPk {get;set;}
        
        public virtual ICollection<BsnInsp> BsnInsps { get; set; }
        
        public virtual ICollection<BsnVst> BsnVsts { get; set; }
        
        public virtual ICollection<BsnDscTemp> BsnDscTemps { get; set; }
        
        public virtual ICollection<BsnDscCamp> BsnDscCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String IdCamp { get; set; }
        
        [Description("Prestataire")]
        [Column("CD_PRESTA_BSN__PRESTATAIRE",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaBsnPrestataire { get; set; }
        
        [Description("Type de PV")]
        [Column("CD_TYPE_PV_BSN__CODE",Order=5)]
        [Required()]
        [MaxLength(15)] 
        public String CdTypePvBsnCode { get; set; }
        
        [Description("Année")]
        [Column("ANNEE",Order=6)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("Date maxi retour")]
        [Column("DATER",Order=7)]
        [Required()]
        public DateTime Dater { get; set; }
        
        [Description("Date génération")]
        [Column("DATEG",Order=8)]
        public Nullable<DateTime> Dateg { get; set; }
        
        [Description("Nom créateur")]
        [Column("USERG",Order=9)]
        [MaxLength(255)] 
        public String Userg { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSERV",Order=10)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
