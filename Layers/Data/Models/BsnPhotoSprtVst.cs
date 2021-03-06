using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("PHOTO_SPRT_VST_BSN",Schema="BSN")]
    public partial class BsnPhotoSprtVst : ModelBase
    {
        private BsnSprtVst _bsnSprtVst;
        public virtual BsnSprtVst BsnSprtVst 
        {
            get
            {
                return this._bsnSprtVst;
                
            }
            set
            {
                this._bsnSprtVst = value;
                this.CampBsnIdCamp = this._bsnSprtVst.CampBsnIdCamp;
                this.DscBsnNumBsn = this._bsnSprtVst.DscBsnNumBsn;
                this.CdChapitreBsnIdChap = this._bsnSprtVst.CdChapitreBsnIdChap;
                this.CdLigneBsnIdLigne = this._bsnSprtVst.CdLigneBsnIdLigne;
            }
        }
        
        [Required()]
        [Column("SPRT_VST_BSN_ID_PK",Order=0)]
        public Int64 BsnSprtVstIdPk {get;set;}
        
        [Key]
        [Column("ID_PK",Order=1)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=2)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_BSN__ID_CHAP",Order=4)]
        [Required()]
        public Int64 CdChapitreBsnIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_BSN__ID_LIGNE",Order=5)]
        [Required()]
        public Int64 CdLigneBsnIdLigne { get; set; }
        
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
