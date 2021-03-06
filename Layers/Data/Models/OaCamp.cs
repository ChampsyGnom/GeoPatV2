using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("CAMP_OA",Schema="OA")]
    public partial class OaCamp : ModelBase
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
        
        private OaCdTypePv _oaCdTypePv;
        public virtual OaCdTypePv OaCdTypePv 
        {
            get
            {
                return this._oaCdTypePv;
                
            }
            set
            {
                this._oaCdTypePv = value;
                this.CdTypePvOaCode = this._oaCdTypePv.Code;
            }
        }
        
        [Required()]
        [Column("CD_TYPE_PV_OA_ID_PK",Order=1)]
        public Int64 OaCdTypePvIdPk {get;set;}
        
        public virtual ICollection<OaVst> OaVsts { get; set; }
        
        public virtual ICollection<OaInsp> OaInsps { get; set; }
        
        public virtual ICollection<OaDscTemp> OaDscTemps { get; set; }
        
        public virtual ICollection<OaDscCamp> OaDscCamps { get; set; }
        
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
        [Column("CD_TYPE_PV_OA__CODE",Order=4)]
        [Required()]
        [MaxLength(15)] 
        public String CdTypePvOaCode { get; set; }
        
        [Description("Prestataire")]
        [Column("CD_PRESTA_OA__PRESTATAIRE",Order=5)]
        [Required()]
        [MaxLength(50)] 
        public String CdPrestaOaPrestataire { get; set; }
        
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
