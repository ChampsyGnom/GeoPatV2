using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_VST_BSN",Schema="BSN")]
    public partial class BsnSprtVst : ModelBase
    {
        private BsnVst _bsnVst;
        public virtual BsnVst BsnVst 
        {
            get
            {
                return this._bsnVst;
                
            }
            set
            {
                this._bsnVst = value;
                this.CampBsnIdCamp = this._bsnVst.CampBsnIdCamp;
                this.DscBsnNumBsn = this._bsnVst.DscBsnNumBsn;
            }
        }
        
        [Required()]
        [Column("VST_BSN_ID_PK",Order=0)]
        public Int64 BsnVstIdPk {get;set;}
        
        private BsnCdLigne _bsnCdLigne;
        public virtual BsnCdLigne BsnCdLigne 
        {
            get
            {
                return this._bsnCdLigne;
                
            }
            set
            {
                this._bsnCdLigne = value;
                this.CdChapitreBsnIdChap = this._bsnCdLigne.CdChapitreBsnIdChap;
                this.CdLigneBsnIdLigne = this._bsnCdLigne.IdLigne;
            }
        }
        
        [Required()]
        [Column("CD_LIGNE_BSN_ID_PK",Order=1)]
        public Int64 BsnCdLigneIdPk {get;set;}
        
        public virtual ICollection<BsnPhotoSprtVst> BsnPhotoSprtVsts { get; set; }
        
        public virtual ICollection<BsnCdPrecoSprtVst> BsnCdPrecoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("Identifiant Campagne")]
        [Column("CAMP_BSN__ID_CAMP",Order=3)]
        [Required()]
        [MaxLength(100)] 
        public String CampBsnIdCamp { get; set; }
        
        [Description("N° Bassin")]
        [Column("DSC_BSN__NUM_BSN",Order=4)]
        [Required()]
        [MaxLength(20)] 
        public String DscBsnNumBsn { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_BSN__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreBsnIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_BSN__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneBsnIdLigne { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=7)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observation")]
        [Column("OBS",Order=8)]
        [MaxLength(255)] 
        public String Obs { get; set; }
        
    }
}
