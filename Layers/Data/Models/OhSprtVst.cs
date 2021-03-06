using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_VST_OH",Schema="OH")]
    public partial class OhSprtVst : ModelBase
    {
        private OhVst _ohVst;
        public virtual OhVst OhVst 
        {
            get
            {
                return this._ohVst;
                
            }
            set
            {
                this._ohVst = value;
                this.CampOhIdCamp = this._ohVst.CampOhIdCamp;
                this.DscOhNumOh = this._ohVst.DscOhNumOh;
            }
        }
        
        [Required()]
        [Column("VST_OH_ID_PK",Order=0)]
        public Int64 OhVstIdPk {get;set;}
        
        private OhCdLigne _ohCdLigne;
        public virtual OhCdLigne OhCdLigne 
        {
            get
            {
                return this._ohCdLigne;
                
            }
            set
            {
                this._ohCdLigne = value;
                this.CdChapitreOhIdChap = this._ohCdLigne.CdChapitreOhIdChap;
                this.CdLigneOhIdLigne = this._ohCdLigne.IdLigne;
            }
        }
        
        [Required()]
        [Column("CD_LIGNE_OH_ID_PK",Order=1)]
        public Int64 OhCdLigneIdPk {get;set;}
        
        public virtual ICollection<OhPhotoSprtVst> OhPhotoSprtVsts { get; set; }
        
        public virtual ICollection<OhCdPrecoSprtVst> OhCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OH__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreOhIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_OH__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneOhIdLigne { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=7)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=8)]
        [MaxLength(500)] 
        public String Obs { get; set; }
        
    }
}
