using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CAMP_GOT",Schema="GOT")]
    public partial class GotCamp : ModelBase
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
        
        private GotCdTypePv _gotCdTypePv;
        public virtual GotCdTypePv GotCdTypePv 
        {
            get
            {
                return this._gotCdTypePv;
                
            }
            set
            {
                this._gotCdTypePv = value;
                this.CdTypePvGotCode = this._gotCdTypePv.Code;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_PV_GOT_ID_PK",Order=1)]
        public Int64 GotCdTypePvIdPk {get;set;}
        
        public virtual ICollection<GotInsp> GotInsps { get; set; }
        
        public virtual ICollection<GotVst> GotVsts { get; set; }
        
        public virtual ICollection<GotDscTemp> GotDscTemps { get; set; }
        
        public virtual ICollection<GotDscCamp> GotDscCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant campagne")]
        [Column("ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String IdCamp { get; set; }
        
        [Description("Type de PV")]
        [Column("CD_TYPE_PV_GOT__CODE",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String CdTypePvGotCode { get; set; }
        
        [Description("Prestataire")]
        [Column("CD_PRESTA_GOT__PRESTATAIRE",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaGotPrestataire { get; set; }
        
        [Description("Année")]
        [Column("ANNEE",Order=6)]
        [Required()]
        public Int64 Annee { get; set; }
        
        [Description("Date maxi retour")]
        [Column("DATER",Order=7)]
        [Required()]
        public DateTime Dater { get; set; }
        
        [Description("Date Génération")]
        [Column("DATEG",Order=8)]
        public Nullable<DateTime> Dateg { get; set; }
        
        [Description("Nom créateur")]
        [Column("USERG",Order=9)]
        [MaxLength(255)] 
        public String Userg { get; set; }
        
        [Description("Observation")]
        [Column("OBSERV",Order=10)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
