using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CAMP_GMS",Schema="GMS")]
    public partial class GmsCamp : ModelBase
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
        
        private GmsCdTypePv _gmsCdTypePv;
        public virtual GmsCdTypePv GmsCdTypePv 
        {
            get
            {
                return this._gmsCdTypePv;
                
            }
            set
            {
                this._gmsCdTypePv = value;
                this.CdTypePvGmsCode = this._gmsCdTypePv.Code;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_PV_GMS_ID_PK",Order=1)]
        public Int64 GmsCdTypePvIdPk {get;set;}
        
        public virtual ICollection<GmsInsp> GmsInsps { get; set; }
        
        public virtual ICollection<GmsVst> GmsVsts { get; set; }
        
        public virtual ICollection<GmsDscTemp> GmsDscTemps { get; set; }
        
        public virtual ICollection<GmsDscCamp> GmsDscCamps { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant")]
        [Column("ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String IdCamp { get; set; }
        
        [Description("Type de PV")]
        [Column("CD_TYPE_PV_GMS__CODE",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String CdTypePvGmsCode { get; set; }
        
        [Description("Prestataire")]
        [Column("CD_PRESTA_GMS__PRESTATAIRE",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaGmsPrestataire { get; set; }
        
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
        [MaxLength(2555)] 
        public String Userg { get; set; }
        
        [Description("Commentaire")]
        [Column("OBSERV",Order=10)]
        [MaxLength(255)] 
        public String Observ { get; set; }
        
    }
}
