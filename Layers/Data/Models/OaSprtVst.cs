using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Emash.GeoPat.Layers.Data.Models
{
    [Table("SPRT_VST_OA",Schema="OA")]
    public partial class OaSprtVst : ModelBase
    {
        private OaVst _oaVst;
        public virtual OaVst OaVst 
        {
            get
            {
                return this._oaVst;
                
            }
            set
            {
                this._oaVst = value;
                this.DscOaNumOa = this._oaVst.DscOaNumOa;
                this.CampOaIdCamp = this._oaVst.CampOaIdCamp;
            }
        }
        
        [Required()]
        [Column("VST_OA_ID_PK",Order=0)]
        public Int64 OaVstIdPk {get;set;}
        
        private OaCdLigne _oaCdLigne;
        public virtual OaCdLigne OaCdLigne 
        {
            get
            {
                return this._oaCdLigne;
                
            }
            set
            {
                this._oaCdLigne = value;
                this.CdChapitreOaIdChap = this._oaCdLigne.CdChapitreOaIdChap;
                this.CdLigneOaIdLigne = this._oaCdLigne.IdLigne;
            }
        }
        
        [Required()]
        [Column("CD_LIGNE_OA_ID_PK",Order=1)]
        public Int64 OaCdLigneIdPk {get;set;}
        
        public virtual ICollection<OaPhotoSprtVst> OaPhotoSprtVsts { get; set; }
        
        [Key]
        [Column("ID_PK",Order=2)]
        [Required()]
        public Int64 IdPk { get; set; }
        [Description("NumOA")]
        [Column("DSC_OA__NUM_OA",Order=3)]
        [Required()]
        [MaxLength(20)] 
        public String DscOaNumOa { get; set; }
        
        [Description("Identifiant campagne")]
        [Column("CAMP_OA__ID_CAMP",Order=4)]
        [Required()]
        [MaxLength(100)] 
        public String CampOaIdCamp { get; set; }
        
        [Description("Identifiant chapitre")]
        [Column("CD_CHAPITRE_OA__ID_CHAP",Order=5)]
        [Required()]
        public Int64 CdChapitreOaIdChap { get; set; }
        
        [Description("Identifiant ligne")]
        [Column("CD_LIGNE_OA__ID_LIGNE",Order=6)]
        [Required()]
        public Int64 CdLigneOaIdLigne { get; set; }
        
        [Description("Indice")]
        [Column("INDICE",Order=7)]
        [Required()]
        public Int64 Indice { get; set; }
        
        [Description("Observations")]
        [Column("OBS",Order=8)]
        [MaxLength(500)] 
        public String Obs { get; set; }
        
    }
}
