using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CAMP_OH",Schema="OH")]
    public partial class OhCamp : ModelBase
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
        
        private OhCdTypePv _ohCdTypePv;
        public virtual OhCdTypePv OhCdTypePv 
        {
            get
            {
                return this._ohCdTypePv;
                
            }
            set
            {
                this._ohCdTypePv = value;
                this.CdTypePvOhCode = this._ohCdTypePv.Code;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_PV_OH_ID_PK",Order=1)]
        public Int64 OhCdTypePvIdPk {get;set;}
        
        public virtual ICollection<OhInsp> OhInsps { get; set; }
        
        public virtual ICollection<OhVst> OhVsts { get; set; }
        
        public virtual ICollection<OhDscTemp> OhDscTemps { get; set; }
        
        public virtual ICollection<OhDscCamp> OhDscCamps { get; set; }
        
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
        [Column("CD_PRESTA_OH__PRESTATAIRE",Order=4)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaOhPrestataire { get; set; }
        
        [Description("Type de PV")]
        [Column("CD_TYPE_PV_OH__CODE",Order=5)]
        [Required()]
        [MaxLength(15)] 
        public String CdTypePvOhCode { get; set; }
        
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
        
        [Description("Nom Créateur")]
        [Column("USERG",Order=9)]
        [MaxLength(250)] 
        public String Userg { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSERV",Order=10)]
        [MaxLength(500)] 
        public String Observ { get; set; }
        
    }
}
