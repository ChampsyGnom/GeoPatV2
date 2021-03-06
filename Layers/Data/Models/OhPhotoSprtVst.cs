using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_SPRT_VST_OH",Schema="OH")]
    public partial class OhPhotoSprtVst : ModelBase
    {
        private OhSprtVst _ohSprtVst;
        public virtual OhSprtVst OhSprtVst 
        {
            get
            {
                return this._ohSprtVst;
                
            }
            set
            {
                this._ohSprtVst = value;
                this.CampOhIdCamp = this._ohSprtVst.CampOhIdCamp;
                this.DscOhNumOh = this._ohSprtVst.DscOhNumOh;
                this.CdChapitreOhIdChap = this._ohSprtVst.CdChapitreOhIdChap;
                this.CdLigneOhIdLigne = this._ohSprtVst.CdLigneOhIdLigne;
            }
        }
        
        [Required()]
        [Column("SPRT_VST_OH_ID_PK",Order=0)]
        public Int64 OhSprtVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_OH__ID_CAMP",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String CampOhIdCamp { get; set; }
        
        [Description("NumOH")]
        [Column("DSC_OH__NUM_OH",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOhNumOh { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OH__ID_CHAP",Order=4)]
        [Required()]
        public Int64 CdChapitreOhIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_OH__ID_LIGNE",Order=5)]
        [Required()]
        public Int64 CdLigneOhIdLigne { get; set; }
        
        [Description("Identifiant de la photo")]
        [Column("ID",Order=6)]
        [Required()]
        [MaxLength(50)] 
        public String Id { get; set; }
        
        [Description("Commentaire")]
        [Column("COMMENTAIRE",Order=7)]
        [MaxLength(100)] 
        public String Commentaire { get; set; }
        
    }
}
